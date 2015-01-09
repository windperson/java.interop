using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace Java.Interop
{
	delegate int DestroyJavaVMDelegate (JavaVMSafeHandle javavm);
	delegate int GetEnvDelegate (JavaVMSafeHandle javavm, out IntPtr envptr, int version);
	delegate int AttachCurrentThreadDelegate (JavaVMSafeHandle javavm, out IntPtr env, ref JavaVMThreadAttachArgs args);
	delegate int DetachCurrentThreadDelegate (JavaVMSafeHandle javavm);
	delegate int AttachCurrentThreadAsDaemonDelegate (JavaVMSafeHandle javavm, out IntPtr env, IntPtr args);

	struct JavaVMInterface {
		public IntPtr reserved0;
		public IntPtr reserved1;
		public IntPtr reserved2;

		public DestroyJavaVMDelegate DestroyJavaVM; // jint       (*DestroyJavaVM)(JavaVM*);
		public AttachCurrentThreadDelegate AttachCurrentThread;
		public DetachCurrentThreadDelegate DetachCurrentThread;
		public GetEnvDelegate GetEnv;
		public AttachCurrentThreadAsDaemonDelegate AttachCurrentThreadAsDaemon; //jint        (*AttachCurrentThreadAsDaemon)(JavaVM*, JNIEnv**, void*);
	}

	public enum JniVersion {
		// v1_1    = 0x00010001,
		v1_2    = 0x00010002,
		v1_4    = 0x00010004,
		v1_6	= 0x00010006,
	}

	struct JavaVMThreadAttachArgs {
		public  JniVersion 	        version;    /*		 must be >= JNI_VERSION_1_2 */
		public  IntPtr              name;       /*		 NULL or name of thread as modified UTF-8 str */
		public  IntPtr              group;      /*		 global ref of a ThreadGroup object, or NULL */
	}

	public sealed class JavaVMSafeHandle : SafeHandle {

		JavaVMSafeHandle ()
			: base (IntPtr.Zero, ownsHandle:false)
		{
		}

		public JavaVMSafeHandle (IntPtr handle)
			: this ()
		{
			SetHandle (handle);
		}

		public override bool IsInvalid {
			get {return handle == IntPtr.Zero;}
		}

		internal IntPtr Handle {
			get {return base.handle;}
		}

		protected override bool ReleaseHandle ()
		{
			return false;
		}

		internal unsafe JavaVMInterface CreateInvoker ()
		{
			IntPtr p = Marshal.ReadIntPtr (handle);
			return (JavaVMInterface) Marshal.PtrToStructure (p, typeof(JavaVMInterface));
		}

		public override string ToString ()
		{
			return string.Format ("{0}(0x{1})", GetType ().FullName, handle.ToString ("x"));
		}
	}

	public class JavaVMOptions {

		public  bool        TrackIDs                    {get; set;}
		public  bool        DestroyVMOnDispose          {get; set;}

		// Prefer JNIEnv::NewObject() over JNIEnv::AllocObject() + JNIEnv::CallNonvirtualVoidMethod()
		public  bool        NewObjectRequired           {get; set;}

		public  JavaVMSafeHandle            VMHandle            {get; set;}
		public  JniEnvironmentSafeHandle    EnvironmentHandle   {get; set;}
		public  IJniHandleManager           JniHandleManager    {get; set;}

		public JavaVMOptions ()
		{
		}
	}

	public abstract partial class JavaVM : IDisposable
	{

		static ConcurrentDictionary<IntPtr, JavaVM>     JavaVMs = new ConcurrentDictionary<IntPtr, JavaVM> ();

		public static IEnumerable<JavaVM> GetRegisteredJavaVMs ()
		{
			return JavaVMs.Values;
		}

		public static JavaVM GetRegisteredJavaVM (JavaVMSafeHandle handle)
		{
			JavaVM vm;
			return JavaVMs.TryGetValue (handle.DangerousGetHandle (), out vm)
				? vm
				: null;
		}

		static JavaVM current;
		public static JavaVM Current {
			get {
				if (current != null)
					return current;
				JavaVM  c       = null;
				int     count   = 0;
				foreach (var vm in JavaVMs.Values) {
					if (count++ == 0)
						c = vm;
				}
				if (count == 0)
					throw new InvalidOperationException ("No JavaVM has been created. Please use Java.Interop.JreVMBuilder.CreateJreVM().");
				if (count > 1)
					throw new NotSupportedException (string.Format ("Found {0} JavaVMs. Don't know which to use. Use JavaVM.SetCurrent().", count));
				return current = c;
			}
		}

		public static void SetCurrent (JavaVM newCurrent)
		{
			if (newCurrent == null)
				throw new ArgumentNullException ("newCurrent");
			JavaVMs.TryAdd (newCurrent.SafeHandle.DangerousGetHandle (), newCurrent);
			current = newCurrent;
		}

		ConcurrentDictionary<SafeHandle, IDisposable>   TrackedInstances    = new ConcurrentDictionary<SafeHandle, IDisposable> ();

		JavaVMInterface                                 Invoker;
		bool                                            DestroyVM;

		public  JavaVMSafeHandle                        SafeHandle      {get; private set;}

		public  bool                                    NewObjectRequired   {get; private set;}

		protected JavaVM (JavaVMOptions options)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			if (options.VMHandle == null)
				throw new ArgumentException ("options.VMHandle is null", "options");
			if (options.VMHandle.IsInvalid)
				throw new ArgumentException ("options.VMHandle is not valid.", "options");

			TrackIDs     = options.TrackIDs;
			DestroyVM    = options.DestroyVMOnDispose;

			JniHandleManager    = options.JniHandleManager ?? new JniHandleManager ();
			NewObjectRequired   = options.NewObjectRequired;

			SafeHandle  = options.VMHandle;
			Invoker     = SafeHandle.CreateInvoker ();

			if (current == null)
				current = this;

			if (options.EnvironmentHandle != null) {
				var env = new JniEnvironment (options.EnvironmentHandle, this);
				JniEnvironment.SetRootEnvironment (env);
			}

			JavaVMs.TryAdd (SafeHandle.DangerousGetHandle (), this);

			ManagedPeer.Init ();
		}

		~JavaVM ()
		{
			Dispose (false);
		}

		public virtual void FailFast (string message)
		{
			var t = typeof (Environment);
			var m = t.GetMethod ("FailFast");
			m.Invoke (null, new object[]{ message });
		}

		public override string ToString ()
		{
			return string.Format ("{0}(0x{1})", GetType ().FullName, SafeHandle.DangerousGetHandle ().ToString ("x"));
		}

		public void Dispose ()
		{
			Dispose (true);
		}

		protected virtual void Dispose (bool disposing)
		{
			if (SafeHandle == null || SafeHandle.IsInvalid)
				return;

			if (current == this)
				current = null;

			foreach (var o in RegisteredInstances.Values) {
				var t = (IDisposable) o.Target;
				t.Dispose ();
			}
			RegisteredInstances.Clear ();
			ClearTrackedReferences ();
			JavaVM _;
			JavaVMs.TryRemove (SafeHandle.DangerousGetHandle (), out _);
			JniHandleManager.Dispose ();
			// TODO: Dispose JniEnvironment.RootEnvironments
			// Requires .NET 4.5+
			JniEnvironment.RootEnvironments.Dispose ();
			if (DestroyVM)
				DestroyJavaVM ();
			SafeHandle.Dispose ();
			SafeHandle = null;
		}

		public JniEnvironment AttachCurrentThread (string name = null, JniReferenceSafeHandle group = null)
		{
			var threadArgs = new JavaVMThreadAttachArgs () {
				version = JniVersion.v1_2,
			};
			try {
				if (name != null)
					threadArgs.name = Marshal.StringToHGlobalAnsi (name);
				if (group != null)
					threadArgs.group = group.DangerousGetHandle ();
				IntPtr jnienv;
				int r = Invoker.AttachCurrentThread (SafeHandle, out jnienv, ref threadArgs);
				if (r != 0)
					throw new NotSupportedException ("AttachCurrentThread returned " + r);
				var env = new JniEnvironment (new JniEnvironmentSafeHandle (jnienv), this);
				return env;
			} finally {
				Marshal.FreeHGlobal (threadArgs.name);
			}
		}

		public void DestroyJavaVM ()
		{
			Invoker.DestroyJavaVM (SafeHandle);
		}

		public virtual Exception GetExceptionForThrowable (JniLocalReference value, JniHandleOwnership transfer)
		{
			var o   = PeekObject (value);
			var e   = o as JavaException;
			if (e != null) {
				JniEnvironment.Handles.Dispose (value, transfer);
				var p   = e as JavaProxyThrowable;
				if (p != null)
					return p.Exception;
				return e;
			}
			return GetObject<JavaException> (value, transfer);
		}

		public int GlobalReferenceCount {
			get {return JniHandleManager.GlobalReferenceCount;}
		}

		public int WeakGlobalReferenceCount {
			get {return JniHandleManager.WeakGlobalReferenceCount;}
		}

		public IJniHandleManager JniHandleManager   {get; private set;}

		public bool TrackIDs {get; private set;}

		internal void TrackID (SafeHandle key, IDisposable value)
		{
			if (TrackIDs)
				TrackedInstances.TryAdd (key, value);
		}

		internal void Track (JniType value)
		{
			TrackedInstances.TryAdd (value.SafeHandle, value);
		}

		internal void UnTrack (SafeHandle key)
		{
			IDisposable _;
			TrackedInstances.TryRemove (key, out _);
		}

		void ClearTrackedReferences ()
		{
			foreach (var k in TrackedInstances.Keys.ToList ()) {
				IDisposable d;
				if (TrackedInstances.TryRemove (k, out d))
					d.Dispose ();
			}
			TrackedInstances.Clear ();
		}
	}

	partial class JavaVM {

		Dictionary<int, WeakReference>  RegisteredInstances = new Dictionary<int, WeakReference>();

		public List<WeakReference> GetSurfacedObjects ()
		{
			lock (RegisteredInstances) {
				return RegisteredInstances.Values.ToList ();
			}
		}

		internal void RegisterObject<T> (T value)
			where T : IJavaObject, IJavaObjectEx
		{
			if (value.SafeHandle == null || value.SafeHandle.IsInvalid)
				throw new ObjectDisposedException (value.GetType ().FullName);
			if (value.Registered)
				return;

			if (value.SafeHandle.ReferenceType != JniReferenceType.Global) {
				var o = value.SafeHandle;
				value.SetSafeHandle (o.NewGlobalRef ());
				o.Dispose ();
			}
			int key = value.IdentityHashCode;
			lock (RegisteredInstances) {
				WeakReference   existing;
				IJavaObject     target;
				if (RegisteredInstances.TryGetValue (key, out existing) && (target = (IJavaObject) existing.Target) != null)
					throw new NotSupportedException (
							string.Format ("Cannot register instance {0}(0x{1}), as an instance with the same handle {2}(0x{3}) has already been registered.",
								value.GetType ().FullName, value.SafeHandle.DangerousGetHandle ().ToString ("x"),
								target.GetType ().FullName, target.SafeHandle.DangerousGetHandle ().ToString ("x")));
				RegisteredInstances [key] = new WeakReference (value, trackResurrection: true);
			}
			value.Registered = true;
		}

		internal void UnRegisterObject (IJavaObjectEx value)
		{
			int key = value.IdentityHashCode;
			lock (RegisteredInstances) {
				WeakReference               wv;
				IJavaObject                 t;
				if (RegisteredInstances.TryGetValue (key, out wv) &&
						(t = (IJavaObject) wv.Target) != null &&
						object.ReferenceEquals (value, t))
					RegisteredInstances.Remove (key);
				value.Registered = false;
			}
		}

		internal TCleanup SetObjectSafeHandle<T, TCleanup> (T value, JniReferenceSafeHandle handle, JniHandleOwnership transfer, Func<Action, TCleanup> createCleanup)
			where T : IJavaObject, IJavaObjectEx
			where TCleanup : IDisposable
		{
			if (handle == null)
				throw new ArgumentNullException ("handle");
			if (handle.IsInvalid)
				throw new ArgumentException ("handle is invalid.", "handle");

			bool register   = handle is JniAllocObjectRef;

			value.SetSafeHandle (handle.NewLocalRef ());
			JniEnvironment.Handles.Dispose (handle, transfer);

			value.IdentityHashCode = JniSystem.IdentityHashCode (value.SafeHandle);

			if (register) {
				RegisterObject (value);
				Action unregister = () => {
					UnRegisterObject (value);
					using (var g = value.SafeHandle)
						value.SetSafeHandle (g.NewLocalRef ());
				};
				return createCleanup (unregister);
			}
			return createCleanup (null);
		}

		internal void DisposeObject<T> (T value)
			where T : IJavaObject, IJavaObjectEx
		{
			if (value.SafeHandle == null || value.SafeHandle.IsInvalid)
				return;

			if (value.Registered)
				UnRegisterObject (value);
			value.Dispose (disposing: true);
			value.SafeHandle.Dispose ();
			value.SetSafeHandle (null);
			GC.SuppressFinalize (value);
		}

		internal void TryCollectObject<T> (T value)
			where T : IJavaObject, IJavaObjectEx
		{
			// MUST NOT use SafeHandle.ReferenceType: local refs are tied to a JniEnvironment
			// and the JniEnvironment's corresponding thread; it's a thread-local value.
			// Accessing SafeHandle.ReferenceType won't kill anything (so far...), but
			// instead it always returns JniReferenceType.Invalid.
			if (value.SafeHandle == null || value.SafeHandle.IsInvalid || value.SafeHandle is JniLocalReference) {

				if (value.SafeHandle != null) {
					value.SafeHandle.Dispose ();
					value.SetSafeHandle (null);
				}

				value.Dispose (disposing: false);
				return;
			}

			try {
				var  h          = value.SafeHandle;
				bool collected = TryGC (value, ref h);;
				if (collected) {
					value.SetSafeHandle (null);
					if (value.Registered)
						UnRegisterObject (value);
					value.Dispose (disposing: false);
				} else {
					value.SetSafeHandle (h);
					GC.ReRegisterForFinalize (value);
				}
			} catch (Exception e) {
				FailFast ("Unable to perform a GC! " + e);
			}
		}

		/// <summary>
		///   Try to garbage collect <paramref name="value"/>.
		/// </summary>
		/// <returns>
		///   <c>true</c>, if <paramref name="value"/> was collected and
		///   <paramref name="handle"/> is invalid; otherwise <c>false</c>.
		/// </returns>
		/// <param name="value">
		///   The <see cref="T:Java.Interop.IJavaObject"/> instance to collect.
		/// </param>
		/// <param name="handle">
		///   The <see cref="T:Java.Interop.JniReferenceSafeHandle"/> of <paramref name="value"/>.
		///   This value may be updated, and <see cref="P:Java.Interop.IJavaObject.SafeHandle"/>
		///   will be updated with this value.
		/// </param>
		internal protected abstract bool TryGC (IJavaObject value, ref JniReferenceSafeHandle handle);

		public IJavaObject PeekObject (JniReferenceSafeHandle handle)
		{
			if (handle == null || handle.IsInvalid)
				return null;
			int key = JniSystem.IdentityHashCode (handle);
			lock (RegisteredInstances) {
				WeakReference               wv;
				if (RegisteredInstances.TryGetValue (key, out wv)) {
					IJavaObject   t = (IJavaObject) wv.Target;
					if (t != null)
						return t;
					RegisteredInstances.Remove (key);
				}
			}
			return null;
		}

		public IJavaObject GetObject (JniReferenceSafeHandle handle, JniHandleOwnership transfer, Type targetType = null)
		{
			if (handle == null || handle.IsInvalid)
				return null;

			var existing = PeekObject (handle);
			if (existing != null && targetType != null && targetType.IsInstanceOfType (existing))
				return existing;

			return CreateObjectWrapper (handle, transfer, targetType);
		}

		protected virtual IJavaObject CreateObjectWrapper (JniReferenceSafeHandle handle, JniHandleOwnership transfer, Type targetType)
		{
			targetType  = targetType ?? typeof (JavaObject);
			if (!typeof (IJavaObject).IsAssignableFrom (targetType))
				throw new ArgumentException ("targetType must implement IJavaObject!", "targetType");

			var bestType = GetWrapperType (handle);
			if (targetType != null && targetType.IsAssignableFrom (bestType))
				targetType = bestType;

			return (IJavaObject)Activator.CreateInstance (targetType, handle, transfer);
		}

		Type GetWrapperType (JniReferenceSafeHandle handle)
		{
			var jniTypeName = handle.GetJniTypeName ();
			Type type = null;
			while (jniTypeName != null) {
				type = GetTypeForJniTypeRefererence (jniTypeName);

				if (type != null) {
					const BindingFlags bindingFlags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance;
					var ctors =
						from    c in type.GetConstructors (bindingFlags)
						let     p = c.GetParameters ()
						where   p.Length == 2
						where   p [0].ParameterType == typeof(JniReferenceSafeHandle) &&
						    p [1].ParameterType == typeof(JniHandleOwnership)
						select  c;
					if (ctors.Any ())
						return type;
				}

				using (var jniType  = new JniType (jniTypeName))
				using (var super    = jniType.GetSuperclass ()) {
					jniTypeName = super == null ? null : super.Name;
				}
			}
			return null;
		}

		public T GetObject<T> (JniReferenceSafeHandle jniHandle, JniHandleOwnership transfer)
			where T : IJavaObject
		{
			return (T) GetObject (jniHandle, transfer, typeof (T));
		}

		public IJavaObject GetObject (IntPtr jniHandle, Type targetType = null)
		{
			if (jniHandle == IntPtr.Zero)
				return null;
			using (var h = new JniInvocationHandle (jniHandle))
				return GetObject (h, JniHandleOwnership.DoNotTransfer, targetType);
		}

		public T GetObject<T> (IntPtr jniHandle)
			where T : IJavaObject
		{
			return (T) GetObject (jniHandle, typeof(T));
		}
	}

	partial class JavaVM {

		public JniTypeInfo GetJniTypeInfoForType (Type type)
		{
			if (type == null)
				throw new ArgumentNullException ("type");
			if (type.ContainsGenericParameters)
				throw new ArgumentException ("Generic type definitions are not supported.", "type");

			var originalType    = type;
			int rank            = 0;
			while (type.IsArray) {
				if (type.IsArray && type.GetArrayRank () > 1)
					throw new ArgumentException ("Multidimensional array '" + originalType.FullName + "' is not supported.", "type");
				rank++;
				type    = type.GetElementType ();
			}

			if (type.IsEnum)
				type = Enum.GetUnderlyingType (type);

			foreach (var mapping in JniBuiltinTypeNameMappings) {
				if (mapping.Key == type) {
					var r = mapping.Value;
					r.ArrayRank += rank;
					return r;
				}
			}

			foreach (var mapping in JniBuiltinArrayMappings) {
				if (mapping.Key == type) {
					var r = mapping.Value;
					r.ArrayRank += rank;
					return r;
				}
			}

			var names = (JniTypeInfoAttribute[]) type.GetCustomAttributes (typeof (JniTypeInfoAttribute), inherit:false);
			if (names.Length != 0)
				return new JniTypeInfo (names [0].JniTypeName, names [0].TypeIsKeyword, names [0].ArrayRank + rank);

			if (type.IsGenericType) {
				var def = type.GetGenericTypeDefinition ();
				if (def == typeof(JavaArray<>) || def == typeof(JavaObjectArray<>)) {
					var r = GetJniTypeInfoForType (type.GetGenericArguments () [0]);
					r.ArrayRank += rank + 1;
					return r;
				}
			}
			return new JniTypeInfo (GetJniSimplifiedTypeReferenceForType (type), false, rank);
		}

		// Should be protected, but how then would we test?
		public virtual string GetJniSimplifiedTypeReferenceForType (Type type)
		{
			if (type == null)
				throw new ArgumentNullException ("type");
			if (type.IsArray)
				throw new ArgumentException ("Array type '" + type.FullName + "' is not supported.", "type");
			return null;
		}

		public Type GetTypeForJniTypeRefererence (string jniTypeReference)
		{
			var info    = GetJniTypeInfoForJniTypeReference (jniTypeReference);
			if (info.JniTypeName == null)
				return null;
			var inner   = GetTypeForJniSimplifiedTypeReference (info.JniTypeName);
			if (inner == null)
				return null;
			var rank    = info.ArrayRank;
			var type    = inner;
			if (info.TypeIsKeyword && rank > 0) {
				type = typeof(JavaPrimitiveArray<>).MakeGenericType (type);
				if (--rank == 0)
					return type;
			}
			while (rank-- > 0) {
				type = typeof (JavaObjectArray<>).MakeGenericType (type);
			}
			return type;
		}

		public JniTypeInfo GetJniTypeInfoForJniTypeReference (string jniTypeReference)
		{
			if (jniTypeReference == null)
				throw new ArgumentNullException ("jniTypeReference");
			var info = new JniTypeInfo ();
			int i = 0;
			while (i < jniTypeReference.Length && jniTypeReference [i] == '[') {
				i++;
				info.ArrayRank++;
			}
			switch (jniTypeReference [i]) {
			case 'B':
			case 'C':
			case 'D':
			case 'I':
			case 'F':
			case 'J':
			case 'S':
			case 'Z':
				if (jniTypeReference.Length - i > 1)
					info.JniTypeName    = jniTypeReference.Substring (i);
				else {
					info.JniTypeName    = jniTypeReference [i].ToString ();
					info.TypeIsKeyword  = true;
				}
				break;
			case 'L':
				int s = jniTypeReference.IndexOf (';', i);
				if (s >= i && s != jniTypeReference.Length-1)
					throw new ArgumentException (
							string.Format ("Malformed JNI type reference: trailing text after ';' in '{0}'.", jniTypeReference),
							"jniTypeReference");
				if (i == 0) {
					info.JniTypeName = s > i
						? jniTypeReference.Substring (i + 1, s - i - 1)
						: jniTypeReference;
				} else {
					if (s < i)
						throw new ArgumentException (
								string.Format ("Malformed JNI type reference; no terminating ';' for type ref: '{0}'.", jniTypeReference.Substring (i)),
								"jniTypeReference");
					if (s != jniTypeReference.Length - 1)
						throw new ArgumentException (
								string.Format ("Malformed jNI type reference: invalid trailing text: '{0}'.", jniTypeReference.Substring (i)),
								"jniTypeReference");
					info.JniTypeName = jniTypeReference.Substring (i + 1, s - i - 1);
				}
				break;
			default:
				if (i != 0)
					throw new ArgumentException (
							string.Format ("Malformed JNI type reference: found unrecognized char '{0}' in '{1}'.",
								jniTypeReference [i], jniTypeReference),
							"jniTypeReference");
				info.JniTypeName = jniTypeReference;
				break;
			}
			int bad = info.JniTypeName.IndexOfAny (new[]{ '.', ';' });
			if (bad >= 0)
				throw new ArgumentException (
						string.Format ("Malformed JNI type reference: contains '{0}': {1}", info.JniTypeName [bad], jniTypeReference),
						"jniTypeReference");
			return info;
		}

		public virtual Type GetTypeForJniSimplifiedTypeReference (string jniTypeReference)
		{
			if (jniTypeReference == null)
				throw new ArgumentNullException ("jniTypeReference");
			if (jniTypeReference != null && jniTypeReference.Contains ("."))
				throw new ArgumentException ("JNI type names do not contain '.', they use '/'. Are you sure you're using a JNI type name?", "jniTypeReference");
			if (jniTypeReference != null && jniTypeReference.StartsWith ("[", StringComparison.Ordinal))
				throw new ArgumentException ("Only simplified type references are supported.", "jniTypeReference");
			if (jniTypeReference != null && jniTypeReference.StartsWith ("L", StringComparison.Ordinal) && jniTypeReference.EndsWith (";", StringComparison.Ordinal))
				throw new ArgumentException ("Only simplified type references are supported.", "jniTypeReference");

			foreach (var mapping in JniBuiltinTypeNameMappings) {
				if (mapping.Value.JniTypeName == jniTypeReference)
					return mapping.Key;
			}
			return null;
		}

		public virtual JniMarshalInfo GetJniMarshalInfoForType (Type type)
		{
			if (type == null)
				throw new ArgumentNullException ("type");
			if (type.ContainsGenericParameters)
				throw new ArgumentException ("Generic type definitions are not supported.", "type");

			if (typeof (IJavaObject) == type)
				return DefaultObjectMarshaler;

			foreach (var marshaler in JniBuiltinMarshalers) {
				if (marshaler.Key == type)
					return marshaler.Value;
			}

			var listType = type.GetInterfaces ()
				.FirstOrDefault (i => i.IsGenericType && i.GetGenericTypeDefinition () == typeof (IList<>));
			if (listType != null) {
				var elementType = listType.GetGenericArguments () [0];
				if (elementType.IsValueType) {
					foreach (var marshaler in JniPrimitiveArrayMarshalers) {
						if (marshaler.Key == type)
							return marshaler.Value;
					}
				}
				var arrayType   = typeof (JavaObjectArray<>).MakeGenericType (elementType);
				var getValue    = CreateMethodDelegate<Func<JniReferenceSafeHandle, JniHandleOwnership, Type, object>> (arrayType, "GetValue");
				var createLRef  = CreateMethodDelegate<Func<object, JniLocalReference>> (arrayType, "CreateLocalRef");
				var createObj   = CreateMethodDelegate<Func<object, IJavaObject>> (arrayType, "CreateMarshalCollection");
				var cleanup     = CreateMethodDelegate<Action<IJavaObject, object>> (arrayType, "CleanupMarshalCollection");

				return new JniMarshalInfo {
					GetValueFromJni             = getValue,
					CreateLocalRef              = createLRef,
					CreateMarshalCollection     = createObj,
					CleanupMarshalCollection    = cleanup,
				};
			}

			if (typeof (IJavaObject).IsAssignableFrom (type)) {
				return DefaultObjectMarshaler;
			}
			return new JniMarshalInfo ();
		}

		static TDelegate CreateMethodDelegate<TDelegate>(Type type, string methodName)
			where TDelegate : class
		{
			return (TDelegate) (object) Delegate.CreateDelegate (
					typeof (TDelegate),
					type.GetMethod (methodName, BindingFlags.Static | BindingFlags.NonPublic));
		}

		static readonly JniMarshalInfo DefaultObjectMarshaler = new JniMarshalInfo {
			GetValueFromJni         = JavaObjectExtensions.GetValue,
			CreateLocalRef          = JavaObjectExtensions.CreateLocalRef,
		};
	}

	partial class JavaVM {

		static IExportedMemberBuilder memberBuilder;
		public virtual IExportedMemberBuilder ExportedMemberBuilder {
			get {
				if (memberBuilder != null)
					return memberBuilder;
				var jie = Assembly.Load ("Java.Interop.Export");
				var t   = jie.GetType ("Java.Interop.ExportedMemberBuilder");
				var b   = (IExportedMemberBuilder) Activator.CreateInstance (t, this);
				if (Interlocked.CompareExchange (ref memberBuilder, b, null) != null) {
					// do nothing; GC will collect
				}
				return memberBuilder;
			}
		}
	}
}

