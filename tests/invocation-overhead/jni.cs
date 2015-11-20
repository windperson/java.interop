// Generated file; DO NOT EDIT!
//
// To make changes, edit monodroid/tools/jnienv-gen-interop and rerun

#if !FEATURE_JNIENVIRONMENT_SAFEHANDLES && !FEATURE_JNIENVIRONMENT_JI_INTPTRS && !FEATURE_JNIENVIRONMENT_JI_PINVOKES && !FEATURE_JNIENVIRONMENT_XA_INTPTRS
#define FEATURE_JNIENVIRONMENT_SAFEHANDLES
#endif  // !FEATURE_JNIENVIRONMENT_SAFEHANDLES && !FEATURE_JNIENVIRONMENT_JI_INTPTRS && !FEATURE_JNIENVIRONMENT_JI_PINVOKES && !FEATURE_JNIENVIRONMENT_XA_INTPTRS

#if FEATURE_JNIENVIRONMENT_SAFEHANDLES && FEATURE_JNIENVIRONMENT_JI_INTPTRS
#define _NAMESPACE_PER_HANDLE
#endif  // FEATURE_JNIENVIRONMENT_SAFEHANDLES && FEATURE_JNIENVIRONMENT_JI_INTPTRS
#if FEATURE_JNIENVIRONMENT_SAFEHANDLES && FEATURE_JNIENVIRONMENT_JI_PINVOKES
#define _NAMESPACE_PER_HANDLE
#endif  // FEATURE_JNIENVIRONMENT_SAFEHANDLES && FEATURE_JNIENVIRONMENT_JI_PINVOKES
#if FEATURE_JNIENVIRONMENT_SAFEHANDLES && FEATURE_JNIENVIRONMENT_XA_INTPTRS
#define _NAMESPACE_PER_HANDLE
#endif  // FEATURE_JNIENVIRONMENT_SAFEHANDLES && FEATURE_JNIENVIRONMENT_XA_INTPTRS

using System;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;

using Java.Interop;

using JNIEnvPtr          = System.IntPtr;

#if FEATURE_JNIENVIRONMENT_JI_INTPTRS || FEATURE_JNIENVIRONMENT_JI_PINVOKES
	using jinstanceFieldID   = System.IntPtr;
	using jstaticFieldID     = System.IntPtr;
	using jinstanceMethodID  = System.IntPtr;
	using jstaticMethodID    = System.IntPtr;
	using jobject            = System.IntPtr;
#endif  // FEATURE_JNIENVIRONMENT_JI_INTPTRS || FEATURE_JNIENVIRONMENT_JI_PINVOKES

namespace Java.Interop {
#if FEATURE_JNIENVIRONMENT_SAFEHANDLES || FEATURE_JNIENVIRONMENT_JI_INTPTRS || FEATURE_JNIENVIRONMENT_XA_INTPTRS
	[StructLayout (LayoutKind.Sequential)]
	partial struct JniNativeInterfaceStruct {

#pragma warning disable 0649	// Field is assigned to, and will always have its default value `null`; ignore as it'll be set in native code.
#pragma warning disable 0169	// Field never used; ignore since these fields make the structure have the right layout.
		private IntPtr  reserved0;                      // void*
		private IntPtr  reserved1;                      // void*
		private IntPtr  reserved2;                      // void*
		private IntPtr  reserved3;                      // void*
		public  IntPtr  GetVersion;                     // jint        (*GetVersion)(JNIEnv*);
		public  IntPtr  DefineClass;                    // jclass      (*DefineClass)(JNIEnv*, const char, jobject, const jbyte*, jsize);
		public  IntPtr  FindClass;                      // jclass      (*FindClass)(JNIEnv*, const char*);
		public  IntPtr  FromReflectedMethod;            // jmethodID   (*FromReflectedMethod)(JNIEnv*, jobject);
		public  IntPtr  FromReflectedField;             // jfieldID    (*FromReflectedField)(JNIEnv*, jobject);
		public  IntPtr  ToReflectedMethod;              // jobject     (*ToReflectedMethod)(JNIEnv*, jclass, jmethodID, jboolean);
		public  IntPtr  GetSuperclass;                  // jclass      (*GetSuperclass)(JNIEnv*, jclass);
		public  IntPtr  IsAssignableFrom;               // jboolean    (*IsAssignableFrom)(JNIEnv*, jclass, jclass);
		public  IntPtr  ToReflectedField;               // jobject     (*ToReflectedField)(JNIEnv*, jclass, jfieldID, jboolean);
		public  IntPtr  Throw;                          // jint        (*Throw)(JNIEnv*, jthrowable);
		public  IntPtr  ThrowNew;                       // jint        (*ThrowNew)(JNIEnv*, jclass, const char*);
		public  IntPtr  ExceptionOccurred;              // jthrowable  (*ExceptionOccurred)(JNIEnv*);
		public  IntPtr  ExceptionDescribe;              // void        (*ExceptionDescribe)(JNIEnv*);
		public  IntPtr  ExceptionClear;                 // void        (*ExceptionClear)(JNIEnv*);
		public  IntPtr  FatalError;                     // void        (*FatalError)(JNIEnv*, const char*);
		public  IntPtr  PushLocalFrame;                 // jint        (*PushLocalFrame)(JNIEnv*, jint);
		public  IntPtr  PopLocalFrame;                  // jobject     (*PopLocalFrame)(JNIEnv*, jobject);
		public  IntPtr  NewGlobalRef;                   // jobject     (*NewGlobalRef)(JNIEnv*, jobject);
		public  IntPtr  DeleteGlobalRef;                // void        (*DeleteGlobalRef)(JNIEnv*, jobject);
		public  IntPtr  DeleteLocalRef;                 // void        (*DeleteLocalRef)(JNIEnv*, jobject);
		public  IntPtr  IsSameObject;                   // jboolean    (*IsSameObject)(JNIEnv*, jobject, jobject);
		public  IntPtr  NewLocalRef;                    // jobject     (*NewLocalRef)(JNIEnv*, jobject);
		public  IntPtr  EnsureLocalCapacity;            // jint        (*EnsureLocalCapacity)(JNIEnv*, jint);
		public  IntPtr  AllocObject;                    // jobject     (*AllocObject)(JNIEnv*, jclass);
		public  IntPtr  NewObject;                      // jobject     (*NewObject)(JNIEnv*, jclass, jmethodID, ...);
		public  IntPtr  NewObjectV;                     // jobject     (*NewObjectV)(JNIEnv*, jclass, jmethodID, va_list);
		public  IntPtr  NewObjectA;                     // jobject     (*NewObjectA)(JNIEnv*, jclass, jmethodID, jvalue*);
		public  IntPtr  GetObjectClass;                 // jclass      (*GetObjectClass)(JNIEnv*, jobject);
		public  IntPtr  IsInstanceOf;                   // jboolean    (*IsInstanceOf)(JNIEnv*, jobject, jclass);
		public  IntPtr  GetMethodID;                    // jmethodID   (*GetMethodID)(JNIEnv*, jclass, const char*, const char*);
		public  IntPtr  CallObjectMethod;               // jobject     (*CallObjectMethod)(JNIEnv*, jobject, jmethodID, ...);
		public  IntPtr  CallObjectMethodV;              // jobject     (*CallObjectMethodV)(JNIEnv*, jobject, jmethodID, va_list);
		public  IntPtr  CallObjectMethodA;              // jobject     (*CallObjectMethodA)(JNIEnv*, jobject, jmethodID, jvalue*);
		public  IntPtr  CallBooleanMethod;              // jboolean    (*CallBooleanMethod)(JNIEnv*, jobject, jmethodID, ...);
		public  IntPtr  CallBooleanMethodV;             // jboolean    (*CallBooleanMethodV)(JNIEnv*, jobject, jmethodID, va_list);
		public  IntPtr  CallBooleanMethodA;             // jboolean    (*CallBooleanMethodA)(JNIEnv*, jobject, jmethodID, jvalue*);
		public  IntPtr  CallByteMethod;                 // jbyte       (*CallByteMethod)(JNIEnv*, jobject, jmethodID, ...);
		public  IntPtr  CallByteMethodV;                // jbyte       (*CallByteMethodV)(JNIEnv*, jobject, jmethodID, va_list);
		public  IntPtr  CallByteMethodA;                // jbyte       (*CallByteMethodA)(JNIEnv*, jobject, jmethodID, jvalue*);
		public  IntPtr  CallCharMethod;                 // jchar       (*CallCharMethod)(JNIEnv*, jobject, jmethodID, ...);
		public  IntPtr  CallCharMethodV;                // jchar       (*CallCharMethodV)(JNIEnv*, jobject, jmethodID, va_list);
		public  IntPtr  CallCharMethodA;                // jchar       (*CallCharMethodA)(JNIEnv*, jobject, jmethodID, jvalue*);
		public  IntPtr  CallShortMethod;                // jshort      (*CallShortMethod)(JNIEnv*, jobject, jmethodID, ...);
		public  IntPtr  CallShortMethodV;               // jshort      (*CallShortMethodV)(JNIEnv*, jobject, jmethodID, va_list);
		public  IntPtr  CallShortMethodA;               // jshort      (*CallShortMethodA)(JNIEnv*, jobject, jmethodID, jvalue*);
		public  IntPtr  CallIntMethod;                  // jint        (*CallIntMethod)(JNIEnv*, jobject, jmethodID, ...);
		public  IntPtr  CallIntMethodV;                 // jint        (*CallIntMethodV)(JNIEnv*, jobject, jmethodID, va_list);
		public  IntPtr  CallIntMethodA;                 // jint        (*CallIntMethodA)(JNIEnv*, jobject, jmethodID, jvalue*);
		public  IntPtr  CallLongMethod;                 // jlong       (*CallLongMethod)(JNIEnv*, jobject, jmethodID, ...);
		public  IntPtr  CallLongMethodV;                // jlong       (*CallLongMethodV)(JNIEnv*, jobject, jmethodID, va_list);
		public  IntPtr  CallLongMethodA;                // jlong       (*CallLongMethodA)(JNIEnv*, jobject, jmethodID, jvalue*);
		public  IntPtr  CallFloatMethod;                // jfloat      (*CallFloatMethod)(JNIEnv*, jobject, jmethodID, ...);
		public  IntPtr  CallFloatMethodV;               // jfloat      (*CallFloatMethodV)(JNIEnv*, jobject, jmethodID, va_list);
		public  IntPtr  CallFloatMethodA;               // jfloat      (*CallFloatMethodA)(JNIEnv*, jobject, jmethodID, jvalue*);
		public  IntPtr  CallDoubleMethod;               // jdouble     (*CallDoubleMethod)(JNIEnv*, jobject, jmethodID, ...);
		public  IntPtr  CallDoubleMethodV;              // jdouble     (*CallDoubleMethodV)(JNIEnv*, jobject, jmethodID, va_list);
		public  IntPtr  CallDoubleMethodA;              // jdouble     (*CallDoubleMethodA)(JNIEnv*, jobject, jmethodID, jvalue*);
		public  IntPtr  CallVoidMethod;                 // void        (*CallVoidMethod)(JNIEnv*, jobject, jmethodID, ...);
		public  IntPtr  CallVoidMethodV;                // void        (*CallVoidMethodV)(JNIEnv*, jobject, jmethodID, va_list);
		public  IntPtr  CallVoidMethodA;                // void        (*CallVoidMethodA)(JNIEnv*, jobject, jmethodID, jvalue*);
		public  IntPtr  CallNonvirtualObjectMethod;     // jobject     (*CallNonvirtualObjectMethod)(JNIEnv*, jobject, jclass, jmethodID, ...);
		public  IntPtr  CallNonvirtualObjectMethodV;    // jobject     (*CallNonvirtualObjectMethodV)(JNIEnv*, jobject, jclass, jmethodID, va_list);
		public  IntPtr  CallNonvirtualObjectMethodA;    // jobject     (*CallNonvirtualObjectMethodA)(JNIEnv*, jobject, jclass, jmethodID, jvalue*);
		public  IntPtr  CallNonvirtualBooleanMethod;    // jboolean    (*CallNonvirtualBooleanMethod)(JNIEnv*, jobject, jclass, jmethodID, ...);
		public  IntPtr  CallNonvirtualBooleanMethodV;   // jboolean    (*CallNonvirtualBooleanMethodV)(JNIEnv*, jobject, jclass, jmethodID, va_list);
		public  IntPtr  CallNonvirtualBooleanMethodA;   // jboolean    (*CallNonvirtualBooleanMethodA)(JNIEnv*, jobject, jclass, jmethodID, jvalue*);
		public  IntPtr  CallNonvirtualByteMethod;       // jbyte       (*CallNonvirtualByteMethod)(JNIEnv*, jobject, jclass, jmethodID, ...);
		public  IntPtr  CallNonvirtualByteMethodV;      // jbyte       (*CallNonvirtualByteMethodV)(JNIEnv*, jobject, jclass, jmethodID, va_list);
		public  IntPtr  CallNonvirtualByteMethodA;      // jbyte       (*CallNonvirtualByteMethodA)(JNIEnv*, jobject, jclass, jmethodID, jvalue*);
		public  IntPtr  CallNonvirtualCharMethod;       // jchar       (*CallNonvirtualCharMethod)(JNIEnv*, jobject, jclass, jmethodID, ...);
		public  IntPtr  CallNonvirtualCharMethodV;      // jchar       (*CallNonvirtualCharMethodV)(JNIEnv*, jobject, jclass, jmethodID, va_list);
		public  IntPtr  CallNonvirtualCharMethodA;      // jchar       (*CallNonvirtualCharMethodA)(JNIEnv*, jobject, jclass, jmethodID, jvalue*);
		public  IntPtr  CallNonvirtualShortMethod;      // jshort      (*CallNonvirtualShortMethod)(JNIEnv*, jobject, jclass, jmethodID, ...);
		public  IntPtr  CallNonvirtualShortMethodV;     // jshort      (*CallNonvirtualShortMethodV)(JNIEnv*, jobject, jclass, jmethodID, va_list);
		public  IntPtr  CallNonvirtualShortMethodA;     // jshort      (*CallNonvirtualShortMethodA)(JNIEnv*, jobject, jclass, jmethodID, jvalue*);
		public  IntPtr  CallNonvirtualIntMethod;        // jint        (*CallNonvirtualIntMethod)(JNIEnv*, jobject, jclass, jmethodID, ...);
		public  IntPtr  CallNonvirtualIntMethodV;       // jint        (*CallNonvirtualIntMethodV)(JNIEnv*, jobject, jclass, jmethodID, va_list);
		public  IntPtr  CallNonvirtualIntMethodA;       // jint        (*CallNonvirtualIntMethodA)(JNIEnv*, jobject, jclass, jmethodID, jvalue*);
		public  IntPtr  CallNonvirtualLongMethod;       // jlong       (*CallNonvirtualLongMethod)(JNIEnv*, jobject, jclass, jmethodID, ...);
		public  IntPtr  CallNonvirtualLongMethodV;      // jlong       (*CallNonvirtualLongMethodV)(JNIEnv*, jobject, jclass, jmethodID, va_list);
		public  IntPtr  CallNonvirtualLongMethodA;      // jlong       (*CallNonvirtualLongMethodA)(JNIEnv*, jobject, jclass, jmethodID, jvalue*);
		public  IntPtr  CallNonvirtualFloatMethod;      // jfloat      (*CallNonvirtualFloatMethod)(JNIEnv*, jobject, jclass, jmethodID, ...);
		public  IntPtr  CallNonvirtualFloatMethodV;     // jfloat      (*CallNonvirtualFloatMethodV)(JNIEnv*, jobject, jclass, jmethodID, va_list);
		public  IntPtr  CallNonvirtualFloatMethodA;     // jfloat      (*CallNonvirtualFloatMethodA)(JNIEnv*, jobject, jclass, jmethodID, jvalue*);
		public  IntPtr  CallNonvirtualDoubleMethod;     // jdouble     (*CallNonvirtualDoubleMethod)(JNIEnv*, jobject, jclass, jmethodID, ...);
		public  IntPtr  CallNonvirtualDoubleMethodV;    // jdouble     (*CallNonvirtualDoubleMethodV)(JNIEnv*, jobject, jclass, jmethodID, va_list);
		public  IntPtr  CallNonvirtualDoubleMethodA;    // jdouble     (*CallNonvirtualDoubleMethodA)(JNIEnv*, jobject, jclass, jmethodID, jvalue*);
		public  IntPtr  CallNonvirtualVoidMethod;       // void        (*CallNonvirtualVoidMethod)(JNIEnv*, jobject, jclass, jmethodID, ...);
		public  IntPtr  CallNonvirtualVoidMethodV;      // void        (*CallNonvirtualVoidMethodV)(JNIEnv*, jobject, jclass, jmethodID, va_list);
		public  IntPtr  CallNonvirtualVoidMethodA;      // void        (*CallNonvirtualVoidMethodA)(JNIEnv*, jobject, jclass, jmethodID, jvalue*);
		public  IntPtr  GetFieldID;                     // jfieldID    (*GetFieldID)(JNIEnv*, jclass, const char*, const char*);
		public  IntPtr  GetObjectField;                 // jobject     (*GetObjectField)(JNIEnv*, jobject, jfieldID);
		public  IntPtr  GetBooleanField;                // jboolean    (*GetBooleanField)(JNIEnv*, jobject, jfieldID);
		public  IntPtr  GetByteField;                   // jbyte       (*GetByteField)(JNIEnv*, jobject, jfieldID);
		public  IntPtr  GetCharField;                   // jchar       (*GetCharField)(JNIEnv*, jobject, jfieldID);
		public  IntPtr  GetShortField;                  // jshort      (*GetShortField)(JNIEnv*, jobject, jfieldID);
		public  IntPtr  GetIntField;                    // jint        (*GetIntField)(JNIEnv*, jobject, jfieldID);
		public  IntPtr  GetLongField;                   // jlong       (*GetLongField)(JNIEnv*, jobject, jfieldID);
		public  IntPtr  GetFloatField;                  // jfloat      (*GetFloatField)(JNIEnv*, jobject, jfieldID);
		public  IntPtr  GetDoubleField;                 // jdouble     (*GetDoubleField)(JNIEnv*, jobject, jfieldID);
		public  IntPtr  SetObjectField;                 // void        (*SetObjectField)(JNIEnv*, jobject, jfieldID, jobject);
		public  IntPtr  SetBooleanField;                // void        (*SetBooleanField)(JNIEnv*, jobject, jfieldID, jboolean);
		public  IntPtr  SetByteField;                   // void        (*SetByteField)(JNIEnv*, jobject, jfieldID, jbyte);
		public  IntPtr  SetCharField;                   // void        (*SetCharField)(JNIEnv*, jobject, jfieldID, jchar);
		public  IntPtr  SetShortField;                  // void        (*SetShortField)(JNIEnv*, jobject, jfieldID, jshort);
		public  IntPtr  SetIntField;                    // void        (*SetIntField)(JNIEnv*, jobject, jfieldID, jint);
		public  IntPtr  SetLongField;                   // void        (*SetLongField)(JNIEnv*, jobject, jfieldID, jlong);
		public  IntPtr  SetFloatField;                  // void        (*SetFloatField)(JNIEnv*, jobject, jfieldID, jfloat);
		public  IntPtr  SetDoubleField;                 // void        (*SetDoubleField)(JNIEnv*, jobject, jfieldID, jdouble);
		public  IntPtr  GetStaticMethodID;              // jmethodID   (*GetStaticMethodID)(JNIEnv*, jclass, const char*, const char*);
		public  IntPtr  CallStaticObjectMethod;         // jobject     (*CallStaticObjectMethod)(JNIEnv*, jclass, jmethodID, ...);
		public  IntPtr  CallStaticObjectMethodV;        // jobject     (*CallStaticObjectMethodV)(JNIEnv*, jclass, jmethodID, va_list);
		public  IntPtr  CallStaticObjectMethodA;        // jobject     (*CallStaticObjectMethodA)(JNIEnv*, jclass, jmethodID, jvalue*);
		public  IntPtr  CallStaticBooleanMethod;        // jboolean    (*CallStaticBooleanMethod)(JNIEnv*, jclass, jmethodID, ...);
		public  IntPtr  CallStaticBooleanMethodV;       // jboolean    (*CallStaticBooleanMethodV)(JNIEnv*, jclass, jmethodID, va_list);
		public  IntPtr  CallStaticBooleanMethodA;       // jboolean    (*CallStaticBooleanMethodA)(JNIEnv*, jclass, jmethodID, jvalue*);
		public  IntPtr  CallStaticByteMethod;           // jbyte       (*CallStaticByteMethod)(JNIEnv*, jclass, jmethodID, ...);
		public  IntPtr  CallStaticByteMethodV;          // jbyte       (*CallStaticByteMethodV)(JNIEnv*, jclass, jmethodID, va_list);
		public  IntPtr  CallStaticByteMethodA;          // jbyte       (*CallStaticByteMethodA)(JNIEnv*, jclass, jmethodID, jvalue*);
		public  IntPtr  CallStaticCharMethod;           // jchar       (*CallStaticCharMethod)(JNIEnv*, jclass, jmethodID, ...);
		public  IntPtr  CallStaticCharMethodV;          // jchar       (*CallStaticCharMethodV)(JNIEnv*, jclass, jmethodID, va_list);
		public  IntPtr  CallStaticCharMethodA;          // jchar       (*CallStaticCharMethodA)(JNIEnv*, jclass, jmethodID, jvalue*);
		public  IntPtr  CallStaticShortMethod;          // jshort      (*CallStaticShortMethod)(JNIEnv*, jclass, jmethodID, ...);
		public  IntPtr  CallStaticShortMethodV;         // jshort      (*CallStaticShortMethodV)(JNIEnv*, jclass, jmethodID, va_list);
		public  IntPtr  CallStaticShortMethodA;         // jshort      (*CallStaticShortMethodA)(JNIEnv*, jclass, jmethodID, jvalue*);
		public  IntPtr  CallStaticIntMethod;            // jint        (*CallStaticIntMethod)(JNIEnv*, jclass, jmethodID, ...);
		public  IntPtr  CallStaticIntMethodV;           // jint        (*CallStaticIntMethodV)(JNIEnv*, jclass, jmethodID, va_list);
		public  IntPtr  CallStaticIntMethodA;           // jint        (*CallStaticIntMethodA)(JNIEnv*, jclass, jmethodID, jvalue*);
		public  IntPtr  CallStaticLongMethod;           // jlong       (*CallStaticLongMethod)(JNIEnv*, jclass, jmethodID, ...);
		public  IntPtr  CallStaticLongMethodV;          // jlong       (*CallStaticLongMethodV)(JNIEnv*, jclass, jmethodID, va_list);
		public  IntPtr  CallStaticLongMethodA;          // jlong       (*CallStaticLongMethodA)(JNIEnv*, jclass, jmethodID, jvalue*);
		public  IntPtr  CallStaticFloatMethod;          // jfloat      (*CallStaticFloatMethod)(JNIEnv*, jclass, jmethodID, ...);
		public  IntPtr  CallStaticFloatMethodV;         // jfloat      (*CallStaticFloatMethodV)(JNIEnv*, jclass, jmethodID, va_list);
		public  IntPtr  CallStaticFloatMethodA;         // jfloat      (*CallStaticFloatMethodA)(JNIEnv*, jclass, jmethodID, jvalue*);
		public  IntPtr  CallStaticDoubleMethod;         // jdouble     (*CallStaticDoubleMethod)(JNIEnv*, jclass, jmethodID, ...);
		public  IntPtr  CallStaticDoubleMethodV;        // jdouble     (*CallStaticDoubleMethodV)(JNIEnv*, jclass, jmethodID, va_list);
		public  IntPtr  CallStaticDoubleMethodA;        // jdouble     (*CallStaticDoubleMethodA)(JNIEnv*, jclass, jmethodID, jvalue*);
		public  IntPtr  CallStaticVoidMethod;           // void        (*CallStaticVoidMethod)(JNIEnv*, jclass, jmethodID, ...);
		public  IntPtr  CallStaticVoidMethodV;          // void        (*CallStaticVoidMethodV)(JNIEnv*, jclass, jmethodID, va_list);
		public  IntPtr  CallStaticVoidMethodA;          // void        (*CallStaticVoidMethodA)(JNIEnv*, jclass, jmethodID, jvalue*);
		public  IntPtr  GetStaticFieldID;               // jstaticfieldID    (*GetStaticFieldID)(JNIEnv*, jclass, const char*, const char*);
		public  IntPtr  GetStaticObjectField;           // jobject     (*GetStaticObjectField)(JNIEnv*, jclass, jfieldID);
		public  IntPtr  GetStaticBooleanField;          // jboolean    (*GetStaticBooleanField)(JNIEnv*, jclass, jfieldID);
		public  IntPtr  GetStaticByteField;             // jbyte       (*GetStaticByteField)(JNIEnv*, jclass, jfieldID);
		public  IntPtr  GetStaticCharField;             // jchar       (*GetStaticCharField)(JNIEnv*, jclass, jfieldID);
		public  IntPtr  GetStaticShortField;            // jshort      (*GetStaticShortField)(JNIEnv*, jclass, jfieldID);
		public  IntPtr  GetStaticIntField;              // jint        (*GetStaticIntField)(JNIEnv*, jclass, jfieldID);
		public  IntPtr  GetStaticLongField;             // jlong       (*GetStaticLongField)(JNIEnv*, jclass, jfieldID);
		public  IntPtr  GetStaticFloatField;            // jfloat      (*GetStaticFloatField)(JNIEnv*, jclass, jfieldID);
		public  IntPtr  GetStaticDoubleField;           // jdouble     (*GetStaticDoubleField)(JNIEnv*, jclass, jfieldID);
		public  IntPtr  SetStaticObjectField;           // void        (*SetStaticObjectField)(JNIEnv*, jclass, jfieldID, jobject);
		public  IntPtr  SetStaticBooleanField;          // void        (*SetStaticBooleanField)(JNIEnv*, jclass, jfieldID, jboolean);
		public  IntPtr  SetStaticByteField;             // void        (*SetStaticByteField)(JNIEnv*, jclass, jfieldID, jbyte);
		public  IntPtr  SetStaticCharField;             // void        (*SetStaticCharField)(JNIEnv*, jclass, jfieldID, jchar);
		public  IntPtr  SetStaticShortField;            // void        (*SetStaticShortField)(JNIEnv*, jclass, jfieldID, jshort);
		public  IntPtr  SetStaticIntField;              // void        (*SetStaticIntField)(JNIEnv*, jclass, jfieldID, jint);
		public  IntPtr  SetStaticLongField;             // void        (*SetStaticLongField)(JNIEnv*, jclass, jfieldID, jlong);
		public  IntPtr  SetStaticFloatField;            // void        (*SetStaticFloatField)(JNIEnv*, jclass, jfieldID, jfloat);
		public  IntPtr  SetStaticDoubleField;           // void        (*SetStaticDoubleField)(JNIEnv*, jclass, jfieldID, jdouble);
		public  IntPtr  NewString;                      // jstring     (*NewString)(JNIEnv*, const jchar*, jsize);
		public  IntPtr  GetStringLength;                // jsize       (*GetStringLength)(JNIEnv*, jstring);
		public  IntPtr  GetStringChars;                 // const jchar* (*GetStringChars)(JNIEnv*, jstring, jboolean*);
		public  IntPtr  ReleaseStringChars;             // void        (*ReleaseStringChars)(JNIEnv*, jstring, const jchar*);
		public  IntPtr  NewStringUTF;                   // jstring     (*NewStringUTF)(JNIEnv*, const char*);
		public  IntPtr  GetStringUTFLength;             // jsize       (*GetStringUTFLength)(JNIEnv*, jstring);
		public  IntPtr  GetStringUTFChars;              // const char* (*GetStringUTFChars)(JNIEnv*, jstring, jboolean*);
		public  IntPtr  ReleaseStringUTFChars;          // void        (*ReleaseStringUTFChars)(JNIEnv*, jstring, const char*);
		public  IntPtr  GetArrayLength;                 // jsize       (*GetArrayLength)(JNIEnv*, jarray);
		public  IntPtr  NewObjectArray;                 // jobjectArray (*NewObjectArray)(JNIEnv*, jsize, jclass, jobject);
		public  IntPtr  GetObjectArrayElement;          // jobject     (*GetObjectArrayElement)(JNIEnv*, jobjectArray, jsize);
		public  IntPtr  SetObjectArrayElement;          // void        (*SetObjectArrayElement)(JNIEnv*, jobjectArray, jsize, jobject);
		public  IntPtr  NewBooleanArray;                // jbooleanArray (*NewBooleanArray)(JNIEnv*, jsize);
		public  IntPtr  NewByteArray;                   // jbyteArray  (*NewByteArray)(JNIEnv*, jsize);
		public  IntPtr  NewCharArray;                   // jcharArray  (*NewCharArray)(JNIEnv*, jsize);
		public  IntPtr  NewShortArray;                  // jshortArray (*NewShortArray)(JNIEnv*, jsize);
		public  IntPtr  NewIntArray;                    // jintArray   (*NewIntArray)(JNIEnv*, jsize);
		public  IntPtr  NewLongArray;                   // jlongArray  (*NewLongArray)(JNIEnv*, jsize);
		public  IntPtr  NewFloatArray;                  // jfloatArray (*NewFloatArray)(JNIEnv*, jsize);
		public  IntPtr  NewDoubleArray;                 // jdoubleArray (*NewDoubleArray)(JNIEnv*, jsize);
		public  IntPtr  GetBooleanArrayElements;        // jboolean*   (*GetBooleanArrayElements)(JNIEnv*, jbooleanArray, jboolean*);
		public  IntPtr  GetByteArrayElements;           // jbyte*      (*GetByteArrayElements)(JNIEnv*, jbyteArray, jboolean*);
		public  IntPtr  GetCharArrayElements;           // jchar*      (*GetCharArrayElements)(JNIEnv*, jcharArray, jboolean*);
		public  IntPtr  GetShortArrayElements;          // jshort*     (*GetShortArrayElements)(JNIEnv*, jshortArray, jboolean*);
		public  IntPtr  GetIntArrayElements;            // jint*       (*GetIntArrayElements)(JNIEnv*, jintArray, jboolean*);
		public  IntPtr  GetLongArrayElements;           // jlong*      (*GetLongArrayElements)(JNIEnv*, jlongArray, jboolean*);
		public  IntPtr  GetFloatArrayElements;          // jfloat*     (*GetFloatArrayElements)(JNIEnv*, jfloatArray, jboolean*);
		public  IntPtr  GetDoubleArrayElements;         // jdouble*    (*GetDoubleArrayElements)(JNIEnv*, jdoubleArray, jboolean*);
		public  IntPtr  ReleaseBooleanArrayElements;    // void        (*ReleaseBooleanArrayElements)(JNIEnv*, jbooleanArray, jboolean*, jint);
		public  IntPtr  ReleaseByteArrayElements;       // void        (*ReleaseByteArrayElements)(JNIEnv*, jbyteArray, jbyte*, jint);
		public  IntPtr  ReleaseCharArrayElements;       // void        (*ReleaseCharArrayElements)(JNIEnv*, jcharArray, jchar*, jint);
		public  IntPtr  ReleaseShortArrayElements;      // void        (*ReleaseShortArrayElements)(JNIEnv*, jshortArray, jshort*, jint);
		public  IntPtr  ReleaseIntArrayElements;        // void        (*ReleaseIntArrayElements)(JNIEnv*, jintArray, jint*, jint);
		public  IntPtr  ReleaseLongArrayElements;       // void        (*ReleaseLongArrayElements)(JNIEnv*, jlongArray, jlong*, jint);
		public  IntPtr  ReleaseFloatArrayElements;      // void        (*ReleaseFloatArrayElements)(JNIEnv*, jfloatArray, jfloat*, jint);
		public  IntPtr  ReleaseDoubleArrayElements;     // void        (*ReleaseDoubleArrayElements)(JNIEnv*, jdoubleArray, jdouble*, jint);
		public  IntPtr  GetBooleanArrayRegion;          // void        (*GetBooleanArrayRegion)(JNIEnv*, jbooleanArray, jsize, jsize, jboolean*);
		public  IntPtr  GetByteArrayRegion;             // void        (*GetByteArrayRegion)(JNIEnv*, jbyteArray, jsize, jsize, jbyte*);
		public  IntPtr  GetCharArrayRegion;             // void        (*GetCharArrayRegion)(JNIEnv*, jcharArray, jsize, jsize, jchar*);
		public  IntPtr  GetShortArrayRegion;            // void        (*GetShortArrayRegion)(JNIEnv*, jshortArray, jsize, jsize, jshort*);
		public  IntPtr  GetIntArrayRegion;              // void        (*GetIntArrayRegion)(JNIEnv*, jintArray, jsize, jsize, jint*);
		public  IntPtr  GetLongArrayRegion;             // void        (*GetLongArrayRegion)(JNIEnv*, jlongArray, jsize, jsize, jlong*);
		public  IntPtr  GetFloatArrayRegion;            // void        (*GetFloatArrayRegion)(JNIEnv*, jfloatArray, jsize, jsize, jfloat*);
		public  IntPtr  GetDoubleArrayRegion;           // void        (*GetDoubleArrayRegion)(JNIEnv*, jdoubleArray, jsize, jsize, jdouble*);
		public  IntPtr  SetBooleanArrayRegion;          // void        (*SetBooleanArrayRegion)(JNIEnv*, jbooleanArray, jsize, jsize, const jboolean*);
		public  IntPtr  SetByteArrayRegion;             // void        (*SetByteArrayRegion)(JNIEnv*, jbyteArray, jsize, jsize, const jbyte*);
		public  IntPtr  SetCharArrayRegion;             // void        (*SetCharArrayRegion)(JNIEnv*, jcharArray, jsize, jsize, const jchar*);
		public  IntPtr  SetShortArrayRegion;            // void        (*SetShortArrayRegion)(JNIEnv*, jshortArray, jsize, jsize, const jshort*);
		public  IntPtr  SetIntArrayRegion;              // void        (*SetIntArrayRegion)(JNIEnv*, jintArray, jsize, jsize, const jint*);
		public  IntPtr  SetLongArrayRegion;             // void        (*SetLongArrayRegion)(JNIEnv*, jlongArray, jsize, jsize, const jlong*);
		public  IntPtr  SetFloatArrayRegion;            // void        (*SetFloatArrayRegion)(JNIEnv*, jfloatArray, jsize, jsize, const jfloat*);
		public  IntPtr  SetDoubleArrayRegion;           // void        (*SetDoubleArrayRegion)(JNIEnv*, jdoubleArray, jsize, jsize, const jdouble*);
		public  IntPtr  RegisterNatives;                // jint        (*RegisterNatives)(JNIEnv*, jclass, const JNINativeMethod*, jint);
		public  IntPtr  UnregisterNatives;              // jint        (*UnregisterNatives)(JNIEnv*, jclass);
		public  IntPtr  MonitorEnter;                   // jint        (*MonitorEnter)(JNIEnv*, jobject);
		public  IntPtr  MonitorExit;                    // jint        (*MonitorExit)(JNIEnv*, jobject);
		public  IntPtr  GetJavaVM;                      // jint        (*GetJavaVM)(JNIEnv*, JavaVM**);
		public  IntPtr  GetStringRegion;                // void        (*GetStringRegion)(JNIEnv*, jstring, jsize, jsize, jchar*);
		public  IntPtr  GetStringUTFRegion;             // void        (*GetStringUTFRegion)(JNIEnv*, jstring, jsize, jsize, char*);
		public  IntPtr  GetPrimitiveArrayCritical;      // void*       (*GetPrimitiveArrayCritical)(JNIEnv*, jarray, jboolean*);
		public  IntPtr  ReleasePrimitiveArrayCritical;  // void        (*ReleasePrimitiveArrayCritical)(JNIEnv*, jarray, void*, jint);
		public  IntPtr  GetStringCritical;              // const jchar* (*GetStringCritical)(JNIEnv*, jstring, jboolean*);
		public  IntPtr  ReleaseStringCritical;          // void        (*ReleaseStringCritical)(JNIEnv*, jstring, const jchar*);
		public  IntPtr  NewWeakGlobalRef;               // jweak       (*NewWeakGlobalRef)(JNIEnv*, jobject);
		public  IntPtr  DeleteWeakGlobalRef;            // void        (*DeleteWeakGlobalRef)(JNIEnv*, jweak);
		public  IntPtr  ExceptionCheck;                 // jboolean    (*ExceptionCheck)(JNIEnv*);
		public  IntPtr  NewDirectByteBuffer;            // jobject     (*NewDirectByteBuffer)(JNIEnv*, void*, jlong);
		public  IntPtr  GetDirectBufferAddress;         // void*       (*GetDirectBufferAddress)(JNIEnv*, jobject);
		public  IntPtr  GetDirectBufferCapacity;        // jlong       (*GetDirectBufferCapacity)(JNIEnv*, jobject);
		public  IntPtr  GetObjectRefType;               // jobjectRefType (*GetObjectRefType)(JNIEnv*, jobject);
#pragma warning restore 0169
#pragma warning restore 0649
	}
#endif  // FEATURE_JNIENVIRONMENT_SAFEHANDLES || FEATURE_JNIENVIRONMENT_JI_INTPTRS || FEATURE_JNIENVIRONMENT_XA_INTPTRS
}
#if FEATURE_JNIENVIRONMENT_SAFEHANDLES
namespace
#if _NAMESPACE_PER_HANDLE
	Java.Interop.SafeHandles
#else
	Java.Interop
#endif
{

	unsafe delegate int JniFunc_JNIEnvPtr_int (JNIEnvPtr env);
	unsafe delegate JniLocalReference JniFunc_JNIEnvPtr_string_JniReferenceSafeHandle_IntPtr_int_JniLocalReference (JNIEnvPtr env, string name, JniReferenceSafeHandle loader, IntPtr buffer, int bufferLength);
	unsafe delegate JniLocalReference JniFunc_JNIEnvPtr_string_JniLocalReference (JNIEnvPtr env, string classname);
	unsafe delegate IntPtr JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr (JNIEnvPtr env, JniReferenceSafeHandle method);
	unsafe delegate JniLocalReference JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte_JniLocalReference (JNIEnvPtr env, JniReferenceSafeHandle type, IntPtr method, byte isStatic);
	unsafe delegate JniLocalReference JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference (JNIEnvPtr env, JniReferenceSafeHandle type);
	unsafe delegate byte JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_byte (JNIEnvPtr env, JniReferenceSafeHandle class1, JniReferenceSafeHandle class2);
	unsafe delegate int JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int (JNIEnvPtr env, JniReferenceSafeHandle toThrow);
	unsafe delegate int JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_int (JNIEnvPtr env, JniReferenceSafeHandle type, string message);
	unsafe delegate JniLocalReference JniFunc_JNIEnvPtr_JniLocalReference (JNIEnvPtr env);
	unsafe delegate void JniAction_JNIEnvPtr (JNIEnvPtr env);
	unsafe delegate void JniAction_JNIEnvPtr_string (JNIEnvPtr env, string message);
	unsafe delegate int JniFunc_JNIEnvPtr_int_int (JNIEnvPtr env, int capacity);
	unsafe delegate JniGlobalReference JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniGlobalReference (JNIEnvPtr env, JniReferenceSafeHandle instance);
	unsafe delegate void JniAction_JNIEnvPtr_IntPtr (JNIEnvPtr env, IntPtr instance);
	unsafe delegate JniLocalReference JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference (JNIEnvPtr env, JniReferenceSafeHandle type, IntPtr method);
	unsafe delegate JniLocalReference JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference (JNIEnvPtr env, JniReferenceSafeHandle type, IntPtr method, JniArgumentValue* args);
	unsafe delegate IntPtr JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_string_IntPtr (JNIEnvPtr env, JniReferenceSafeHandle type, string name, string signature);
	unsafe delegate byte JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method);
	unsafe delegate byte JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_byte (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate sbyte JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method);
	unsafe delegate sbyte JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_sbyte (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate char JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method);
	unsafe delegate char JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_char (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate short JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method);
	unsafe delegate short JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_short (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate int JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method);
	unsafe delegate int JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_int (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate long JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method);
	unsafe delegate long JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_long (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate float JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method);
	unsafe delegate float JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_float (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate double JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method);
	unsafe delegate double JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_double (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate void JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method);
	unsafe delegate void JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate JniLocalReference JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniLocalReference (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method);
	unsafe delegate JniLocalReference JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method, JniArgumentValue* args);
	unsafe delegate byte JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_byte (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method);
	unsafe delegate byte JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_byte (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method, JniArgumentValue* args);
	unsafe delegate sbyte JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_sbyte (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method);
	unsafe delegate sbyte JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_sbyte (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method, JniArgumentValue* args);
	unsafe delegate char JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_char (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method);
	unsafe delegate char JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_char (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method, JniArgumentValue* args);
	unsafe delegate short JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_short (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method);
	unsafe delegate short JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_short (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method, JniArgumentValue* args);
	unsafe delegate int JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_int (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method);
	unsafe delegate int JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_int (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method, JniArgumentValue* args);
	unsafe delegate long JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_long (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method);
	unsafe delegate long JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_long (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method, JniArgumentValue* args);
	unsafe delegate float JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_float (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method);
	unsafe delegate float JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_float (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method, JniArgumentValue* args);
	unsafe delegate double JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_double (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method);
	unsafe delegate double JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_double (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method, JniArgumentValue* args);
	unsafe delegate void JniAction_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method);
	unsafe delegate void JniAction_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef (JNIEnvPtr env, JniReferenceSafeHandle instance, JniReferenceSafeHandle type, IntPtr method, JniArgumentValue* args);
	unsafe delegate void JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniReferenceSafeHandle (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr field, JniReferenceSafeHandle value);
	unsafe delegate void JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr field, byte value);
	unsafe delegate void JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr field, sbyte value);
	unsafe delegate void JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr field, char value);
	unsafe delegate void JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr field, short value);
	unsafe delegate void JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr field, int value);
	unsafe delegate void JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr field, long value);
	unsafe delegate void JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr field, float value);
	unsafe delegate void JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double (JNIEnvPtr env, JniReferenceSafeHandle instance, IntPtr field, double value);
	[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl, CharSet=CharSet.Unicode)]
	unsafe delegate JniLocalReference JniFunc_JNIEnvPtr_IntPtr_int_JniLocalReference (JNIEnvPtr env, IntPtr unicodeChars, int length);
	unsafe delegate IntPtr JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr (JNIEnvPtr env, JniReferenceSafeHandle stringInstance, IntPtr isCopy);
	unsafe delegate string JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_string (JNIEnvPtr env, JniReferenceSafeHandle stringInstance, IntPtr isCopy);
	unsafe delegate void JniAction_JNIEnvPtr_JniReferenceSafeHandle_string (JNIEnvPtr env, JniReferenceSafeHandle stringInstance, string utf);
	unsafe delegate JniLocalReference JniFunc_JNIEnvPtr_int_JniReferenceSafeHandle_JniReferenceSafeHandle_JniLocalReference (JNIEnvPtr env, int length, JniReferenceSafeHandle elementClass, JniReferenceSafeHandle initialElement);
	unsafe delegate JniLocalReference JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int_JniLocalReference (JNIEnvPtr env, JniReferenceSafeHandle array, int index);
	unsafe delegate void JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_JniReferenceSafeHandle (JNIEnvPtr env, JniReferenceSafeHandle array, int index, JniReferenceSafeHandle value);
	unsafe delegate JniLocalReference JniFunc_JNIEnvPtr_int_JniLocalReference (JNIEnvPtr env, int length);
	unsafe delegate void JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr (JNIEnvPtr env, JniReferenceSafeHandle array, int start, int length, IntPtr buffer);
	unsafe delegate int JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniNativeMethodRegistrationArray_int_int (JNIEnvPtr env, JniReferenceSafeHandle type, JniNativeMethodRegistration [] methods, int numMethods);
	unsafe delegate int JniFunc_JNIEnvPtr_outIntPtr_int (JNIEnvPtr env, out IntPtr vm);
	unsafe delegate JniWeakGlobalReference JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniWeakGlobalReference (JNIEnvPtr env, JniReferenceSafeHandle instance);
	unsafe delegate byte JniFunc_JNIEnvPtr_byte (JNIEnvPtr env);
	unsafe delegate JniLocalReference JniFunc_JNIEnvPtr_IntPtr_long_JniLocalReference (JNIEnvPtr env, IntPtr address, long capacity);
	unsafe delegate long JniFunc_JNIEnvPtr_JniReferenceSafeHandle_long (JNIEnvPtr env, JniReferenceSafeHandle buffer);
	unsafe delegate JniObjectReferenceType JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniObjectReferenceType (JNIEnvPtr env, JniReferenceSafeHandle instance);

	partial class JniEnvironment {

	public static partial class Arrays {

		public static unsafe int GetArrayLength (JniObjectReference array)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetArrayLength (__info.EnvironmentPointer, array.SafeHandle);
			return tmp;
		}

		public static unsafe JniObjectReference NewObjectArray (int length, JniObjectReference elementClass, JniObjectReference initialElement)
		{
			if (elementClass.SafeHandle == null)
				throw new ArgumentNullException ("elementClass");
			if (elementClass.SafeHandle.IsInvalid)
				throw new ArgumentException ("elementClass");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewObjectArray (__info.EnvironmentPointer, length, elementClass.SafeHandle, initialElement.SafeHandle);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference GetObjectArrayElement (JniObjectReference array, int index)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetObjectArrayElement (__info.EnvironmentPointer, array.SafeHandle, index);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe void SetObjectArrayElement (JniObjectReference array, int index, JniObjectReference value)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetObjectArrayElement (__info.EnvironmentPointer, array.SafeHandle, index, value.SafeHandle);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe JniObjectReference NewBooleanArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewBooleanArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewByteArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewByteArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewCharArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewCharArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewShortArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewShortArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewIntArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewIntArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewLongArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewLongArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewFloatArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewFloatArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewDoubleArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewDoubleArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe IntPtr GetBooleanArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetBooleanArrayElements (__info.EnvironmentPointer, array.SafeHandle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetByteArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetByteArrayElements (__info.EnvironmentPointer, array.SafeHandle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetCharArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetCharArrayElements (__info.EnvironmentPointer, array.SafeHandle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetShortArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetShortArrayElements (__info.EnvironmentPointer, array.SafeHandle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetIntArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetIntArrayElements (__info.EnvironmentPointer, array.SafeHandle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetLongArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetLongArrayElements (__info.EnvironmentPointer, array.SafeHandle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetFloatArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetFloatArrayElements (__info.EnvironmentPointer, array.SafeHandle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetDoubleArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetDoubleArrayElements (__info.EnvironmentPointer, array.SafeHandle, isCopy);
			return tmp;
		}

		public static unsafe void ReleaseBooleanArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseBooleanArrayElements (__info.EnvironmentPointer, array.SafeHandle, elements, mode);
		}

		public static unsafe void ReleaseByteArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseByteArrayElements (__info.EnvironmentPointer, array.SafeHandle, elements, mode);
		}

		public static unsafe void ReleaseCharArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseCharArrayElements (__info.EnvironmentPointer, array.SafeHandle, elements, mode);
		}

		public static unsafe void ReleaseShortArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseShortArrayElements (__info.EnvironmentPointer, array.SafeHandle, elements, mode);
		}

		public static unsafe void ReleaseIntArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseIntArrayElements (__info.EnvironmentPointer, array.SafeHandle, elements, mode);
		}

		public static unsafe void ReleaseLongArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseLongArrayElements (__info.EnvironmentPointer, array.SafeHandle, elements, mode);
		}

		public static unsafe void ReleaseFloatArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseFloatArrayElements (__info.EnvironmentPointer, array.SafeHandle, elements, mode);
		}

		public static unsafe void ReleaseDoubleArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseDoubleArrayElements (__info.EnvironmentPointer, array.SafeHandle, elements, mode);
		}

		public static unsafe void GetBooleanArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetBooleanArrayRegion (__info.EnvironmentPointer, array.SafeHandle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetByteArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetByteArrayRegion (__info.EnvironmentPointer, array.SafeHandle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetCharArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetCharArrayRegion (__info.EnvironmentPointer, array.SafeHandle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetShortArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetShortArrayRegion (__info.EnvironmentPointer, array.SafeHandle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetIntArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetIntArrayRegion (__info.EnvironmentPointer, array.SafeHandle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetLongArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetLongArrayRegion (__info.EnvironmentPointer, array.SafeHandle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetFloatArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetFloatArrayRegion (__info.EnvironmentPointer, array.SafeHandle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetDoubleArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetDoubleArrayRegion (__info.EnvironmentPointer, array.SafeHandle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetBooleanArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetBooleanArrayRegion (__info.EnvironmentPointer, array.SafeHandle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetByteArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetByteArrayRegion (__info.EnvironmentPointer, array.SafeHandle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetCharArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetCharArrayRegion (__info.EnvironmentPointer, array.SafeHandle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetShortArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetShortArrayRegion (__info.EnvironmentPointer, array.SafeHandle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetIntArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetIntArrayRegion (__info.EnvironmentPointer, array.SafeHandle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetLongArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetLongArrayRegion (__info.EnvironmentPointer, array.SafeHandle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetFloatArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetFloatArrayRegion (__info.EnvironmentPointer, array.SafeHandle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetDoubleArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.SafeHandle == null)
				throw new ArgumentNullException ("array");
			if (array.SafeHandle.IsInvalid)
				throw new ArgumentException ("array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetDoubleArrayRegion (__info.EnvironmentPointer, array.SafeHandle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}
	}

	public static partial class Exceptions {

		internal static unsafe int _Throw (JniObjectReference toThrow)
		{
			if (toThrow.SafeHandle == null)
				throw new ArgumentNullException ("toThrow");
			if (toThrow.SafeHandle.IsInvalid)
				throw new ArgumentException ("toThrow");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.Throw (__info.EnvironmentPointer, toThrow.SafeHandle);
			return tmp;
		}

		internal static unsafe int _ThrowNew (JniObjectReference type, string message)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (message == null)
				throw new ArgumentNullException ("message");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.ThrowNew (__info.EnvironmentPointer, type.SafeHandle, message);
			return tmp;
		}

		public static unsafe JniObjectReference ExceptionOccurred ()
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.ExceptionOccurred (__info.EnvironmentPointer);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe void ExceptionDescribe ()
		{
			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ExceptionDescribe (__info.EnvironmentPointer);
		}

		public static unsafe void ExceptionClear ()
		{
			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ExceptionClear (__info.EnvironmentPointer);
		}

		public static unsafe void FatalError (string message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.FatalError (__info.EnvironmentPointer, message);
		}

		public static unsafe bool ExceptionCheck ()
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.ExceptionCheck (__info.EnvironmentPointer);
			return (tmp != 0) ? true : false;
		}
	}

	public static partial class InstanceFields {

		public static unsafe JniInstanceFieldInfo GetFieldID (JniObjectReference type, string name, string signature)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (signature == null)
				throw new ArgumentNullException ("signature");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetFieldID (__info.EnvironmentPointer, type.SafeHandle, name, signature);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			if (tmp == IntPtr.Zero)
				return null;
			return new JniInstanceFieldInfo (tmp);
		}

		public static unsafe JniObjectReference GetObjectField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetObjectField (__info.EnvironmentPointer, instance.SafeHandle, field.ID);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool GetBooleanField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetBooleanField (__info.EnvironmentPointer, instance.SafeHandle, field.ID);
			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte GetByteField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetByteField (__info.EnvironmentPointer, instance.SafeHandle, field.ID);
			return tmp;
		}

		public static unsafe char GetCharField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetCharField (__info.EnvironmentPointer, instance.SafeHandle, field.ID);
			return tmp;
		}

		public static unsafe short GetShortField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetShortField (__info.EnvironmentPointer, instance.SafeHandle, field.ID);
			return tmp;
		}

		public static unsafe int GetIntField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetIntField (__info.EnvironmentPointer, instance.SafeHandle, field.ID);
			return tmp;
		}

		public static unsafe long GetLongField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetLongField (__info.EnvironmentPointer, instance.SafeHandle, field.ID);
			return tmp;
		}

		public static unsafe float GetFloatField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetFloatField (__info.EnvironmentPointer, instance.SafeHandle, field.ID);
			return tmp;
		}

		public static unsafe double GetDoubleField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetDoubleField (__info.EnvironmentPointer, instance.SafeHandle, field.ID);
			return tmp;
		}

		public static unsafe void SetObjectField (JniObjectReference instance, JniInstanceFieldInfo field, JniObjectReference value)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetObjectField (__info.EnvironmentPointer, instance.SafeHandle, field.ID, value.SafeHandle);
		}

		public static unsafe void SetBooleanField (JniObjectReference instance, JniInstanceFieldInfo field, bool value)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetBooleanField (__info.EnvironmentPointer, instance.SafeHandle, field.ID, (value ? (byte) 1 : (byte) 0));
		}

		public static unsafe void SetByteField (JniObjectReference instance, JniInstanceFieldInfo field, sbyte value)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetByteField (__info.EnvironmentPointer, instance.SafeHandle, field.ID, value);
		}

		public static unsafe void SetCharField (JniObjectReference instance, JniInstanceFieldInfo field, char value)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetCharField (__info.EnvironmentPointer, instance.SafeHandle, field.ID, value);
		}

		public static unsafe void SetShortField (JniObjectReference instance, JniInstanceFieldInfo field, short value)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetShortField (__info.EnvironmentPointer, instance.SafeHandle, field.ID, value);
		}

		public static unsafe void SetIntField (JniObjectReference instance, JniInstanceFieldInfo field, int value)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetIntField (__info.EnvironmentPointer, instance.SafeHandle, field.ID, value);
		}

		public static unsafe void SetLongField (JniObjectReference instance, JniInstanceFieldInfo field, long value)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetLongField (__info.EnvironmentPointer, instance.SafeHandle, field.ID, value);
		}

		public static unsafe void SetFloatField (JniObjectReference instance, JniInstanceFieldInfo field, float value)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetFloatField (__info.EnvironmentPointer, instance.SafeHandle, field.ID, value);
		}

		public static unsafe void SetDoubleField (JniObjectReference instance, JniInstanceFieldInfo field, double value)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetDoubleField (__info.EnvironmentPointer, instance.SafeHandle, field.ID, value);
		}
	}

	public static partial class InstanceMethods {

		public static unsafe JniInstanceMethodInfo GetMethodID (JniObjectReference type, string name, string signature)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (signature == null)
				throw new ArgumentNullException ("signature");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetMethodID (__info.EnvironmentPointer, type.SafeHandle, name, signature);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			if (tmp == IntPtr.Zero)
				return null;
			return new JniInstanceMethodInfo (tmp);
		}

		public static unsafe JniObjectReference CallObjectMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallObjectMethod (__info.EnvironmentPointer, instance.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference CallObjectMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallObjectMethodA (__info.EnvironmentPointer, instance.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool CallBooleanMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallBooleanMethod (__info.EnvironmentPointer, instance.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe bool CallBooleanMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallBooleanMethodA (__info.EnvironmentPointer, instance.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte CallByteMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallByteMethod (__info.EnvironmentPointer, instance.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe sbyte CallByteMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallByteMethodA (__info.EnvironmentPointer, instance.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallCharMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallCharMethod (__info.EnvironmentPointer, instance.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallCharMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallCharMethodA (__info.EnvironmentPointer, instance.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallShortMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallShortMethod (__info.EnvironmentPointer, instance.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallShortMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallShortMethodA (__info.EnvironmentPointer, instance.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallIntMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallIntMethod (__info.EnvironmentPointer, instance.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallIntMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallIntMethodA (__info.EnvironmentPointer, instance.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallLongMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallLongMethod (__info.EnvironmentPointer, instance.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallLongMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallLongMethodA (__info.EnvironmentPointer, instance.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallFloatMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallFloatMethod (__info.EnvironmentPointer, instance.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallFloatMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallFloatMethodA (__info.EnvironmentPointer, instance.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallDoubleMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallDoubleMethod (__info.EnvironmentPointer, instance.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallDoubleMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallDoubleMethodA (__info.EnvironmentPointer, instance.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe void CallVoidMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallVoidMethod (__info.EnvironmentPointer, instance.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void CallVoidMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallVoidMethodA (__info.EnvironmentPointer, instance.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe JniObjectReference CallNonvirtualObjectMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualObjectMethod (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference CallNonvirtualObjectMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualObjectMethodA (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool CallNonvirtualBooleanMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualBooleanMethod (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe bool CallNonvirtualBooleanMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualBooleanMethodA (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte CallNonvirtualByteMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualByteMethod (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe sbyte CallNonvirtualByteMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualByteMethodA (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallNonvirtualCharMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualCharMethod (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallNonvirtualCharMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualCharMethodA (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallNonvirtualShortMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualShortMethod (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallNonvirtualShortMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualShortMethodA (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallNonvirtualIntMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualIntMethod (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallNonvirtualIntMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualIntMethodA (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallNonvirtualLongMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualLongMethod (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallNonvirtualLongMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualLongMethodA (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallNonvirtualFloatMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualFloatMethod (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallNonvirtualFloatMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualFloatMethodA (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallNonvirtualDoubleMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualDoubleMethod (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallNonvirtualDoubleMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualDoubleMethodA (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe void CallNonvirtualVoidMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallNonvirtualVoidMethod (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void CallNonvirtualVoidMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallNonvirtualVoidMethodA (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}
	}

	public static partial class IO {

		public static unsafe JniObjectReference NewDirectByteBuffer (IntPtr address, long capacity)
		{
			if (address == IntPtr.Zero)
				throw new ArgumentException ("'address' must not be IntPtr.Zero.", "address");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewDirectByteBuffer (__info.EnvironmentPointer, address, capacity);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe IntPtr GetDirectBufferAddress (JniObjectReference buffer)
		{
			if (buffer.SafeHandle == null)
				throw new ArgumentNullException ("buffer");
			if (buffer.SafeHandle.IsInvalid)
				throw new ArgumentException ("buffer");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetDirectBufferAddress (__info.EnvironmentPointer, buffer.SafeHandle);
			return tmp;
		}

		public static unsafe long GetDirectBufferCapacity (JniObjectReference buffer)
		{
			if (buffer.SafeHandle == null)
				throw new ArgumentNullException ("buffer");
			if (buffer.SafeHandle.IsInvalid)
				throw new ArgumentException ("buffer");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetDirectBufferCapacity (__info.EnvironmentPointer, buffer.SafeHandle);
			return tmp;
		}
	}

	public static partial class Monitors {

		internal static unsafe int _MonitorEnter (JniObjectReference instance)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.MonitorEnter (__info.EnvironmentPointer, instance.SafeHandle);
			return tmp;
		}

		internal static unsafe int _MonitorExit (JniObjectReference instance)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.MonitorExit (__info.EnvironmentPointer, instance.SafeHandle);
			return tmp;
		}
	}

	public static partial class Object {

		public static unsafe JniObjectReference AllocObject (JniObjectReference type)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.AllocObject (__info.EnvironmentPointer, type.SafeHandle);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewObject (JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewObject (__info.EnvironmentPointer, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewObject (JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewObjectA (__info.EnvironmentPointer, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}
	}

	public static partial class References {

		internal static unsafe int _PushLocalFrame (int capacity)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.PushLocalFrame (__info.EnvironmentPointer, capacity);
			return tmp;
		}

		public static unsafe JniObjectReference PopLocalFrame (JniObjectReference result)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.PopLocalFrame (__info.EnvironmentPointer, result.SafeHandle);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		internal static unsafe JniObjectReference NewGlobalRef (JniObjectReference instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewGlobalRef (__info.EnvironmentPointer, instance.SafeHandle);
			return new JniObjectReference (tmp, JniObjectReferenceType.Global);
		}

		internal static unsafe void DeleteGlobalRef (IntPtr instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.DeleteGlobalRef (__info.EnvironmentPointer, instance);
		}

		internal static unsafe void DeleteLocalRef (IntPtr instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.DeleteLocalRef (__info.EnvironmentPointer, instance);
		}

		internal static unsafe JniObjectReference NewLocalRef (JniObjectReference instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewLocalRef (__info.EnvironmentPointer, instance.SafeHandle);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		internal static unsafe int _EnsureLocalCapacity (int capacity)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.EnsureLocalCapacity (__info.EnvironmentPointer, capacity);
			return tmp;
		}

		internal static unsafe int _GetJavaVM (out IntPtr vm)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetJavaVM (__info.EnvironmentPointer, out vm);
			return tmp;
		}

		internal static unsafe JniObjectReference NewWeakGlobalRef (JniObjectReference instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewWeakGlobalRef (__info.EnvironmentPointer, instance.SafeHandle);
			return new JniObjectReference (tmp, JniObjectReferenceType.WeakGlobal);
		}

		internal static unsafe void DeleteWeakGlobalRef (IntPtr instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.DeleteWeakGlobalRef (__info.EnvironmentPointer, instance);
		}

		internal static unsafe JniObjectReferenceType GetObjectRefType (JniObjectReference instance)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetObjectRefType (__info.EnvironmentPointer, instance.SafeHandle);
			return tmp;
		}
	}

	internal static partial class Reflection {

		public static unsafe JniObjectReference ToReflectedMethod (JniObjectReference type, JniInstanceMethodInfo method, bool isStatic)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.ToReflectedMethod (__info.EnvironmentPointer, type.SafeHandle, method.ID, (isStatic ? (byte) 1 : (byte) 0));

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference ToReflectedField (JniObjectReference type, JniInstanceFieldInfo field, bool isStatic)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.ToReflectedField (__info.EnvironmentPointer, type.SafeHandle, field.ID, (isStatic ? (byte) 1 : (byte) 0));

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}
	}

	public static partial class StaticFields {

		public static unsafe JniStaticFieldInfo GetStaticFieldID (JniObjectReference type, string name, string signature)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (signature == null)
				throw new ArgumentNullException ("signature");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticFieldID (__info.EnvironmentPointer, type.SafeHandle, name, signature);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			if (tmp == IntPtr.Zero)
				return null;
			return new JniStaticFieldInfo (tmp);
		}

		public static unsafe JniObjectReference GetStaticObjectField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticObjectField (__info.EnvironmentPointer, type.SafeHandle, field.ID);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool GetStaticBooleanField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticBooleanField (__info.EnvironmentPointer, type.SafeHandle, field.ID);
			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte GetStaticByteField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticByteField (__info.EnvironmentPointer, type.SafeHandle, field.ID);
			return tmp;
		}

		public static unsafe char GetStaticCharField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticCharField (__info.EnvironmentPointer, type.SafeHandle, field.ID);
			return tmp;
		}

		public static unsafe short GetStaticShortField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticShortField (__info.EnvironmentPointer, type.SafeHandle, field.ID);
			return tmp;
		}

		public static unsafe int GetStaticIntField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticIntField (__info.EnvironmentPointer, type.SafeHandle, field.ID);
			return tmp;
		}

		public static unsafe long GetStaticLongField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticLongField (__info.EnvironmentPointer, type.SafeHandle, field.ID);
			return tmp;
		}

		public static unsafe float GetStaticFloatField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticFloatField (__info.EnvironmentPointer, type.SafeHandle, field.ID);
			return tmp;
		}

		public static unsafe double GetStaticDoubleField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticDoubleField (__info.EnvironmentPointer, type.SafeHandle, field.ID);
			return tmp;
		}

		public static unsafe void SetStaticObjectField (JniObjectReference type, JniStaticFieldInfo field, JniObjectReference value)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticObjectField (__info.EnvironmentPointer, type.SafeHandle, field.ID, value.SafeHandle);
		}

		public static unsafe void SetStaticBooleanField (JniObjectReference type, JniStaticFieldInfo field, bool value)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticBooleanField (__info.EnvironmentPointer, type.SafeHandle, field.ID, (value ? (byte) 1 : (byte) 0));
		}

		public static unsafe void SetStaticByteField (JniObjectReference type, JniStaticFieldInfo field, sbyte value)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticByteField (__info.EnvironmentPointer, type.SafeHandle, field.ID, value);
		}

		public static unsafe void SetStaticCharField (JniObjectReference type, JniStaticFieldInfo field, char value)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticCharField (__info.EnvironmentPointer, type.SafeHandle, field.ID, value);
		}

		public static unsafe void SetStaticShortField (JniObjectReference type, JniStaticFieldInfo field, short value)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticShortField (__info.EnvironmentPointer, type.SafeHandle, field.ID, value);
		}

		public static unsafe void SetStaticIntField (JniObjectReference type, JniStaticFieldInfo field, int value)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticIntField (__info.EnvironmentPointer, type.SafeHandle, field.ID, value);
		}

		public static unsafe void SetStaticLongField (JniObjectReference type, JniStaticFieldInfo field, long value)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticLongField (__info.EnvironmentPointer, type.SafeHandle, field.ID, value);
		}

		public static unsafe void SetStaticFloatField (JniObjectReference type, JniStaticFieldInfo field, float value)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticFloatField (__info.EnvironmentPointer, type.SafeHandle, field.ID, value);
		}

		public static unsafe void SetStaticDoubleField (JniObjectReference type, JniStaticFieldInfo field, double value)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticDoubleField (__info.EnvironmentPointer, type.SafeHandle, field.ID, value);
		}
	}

	public static partial class StaticMethods {

		public static unsafe JniStaticMethodInfo GetStaticMethodID (JniObjectReference type, string name, string signature)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (signature == null)
				throw new ArgumentNullException ("signature");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticMethodID (__info.EnvironmentPointer, type.SafeHandle, name, signature);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			if (tmp == IntPtr.Zero)
				return null;
			return new JniStaticMethodInfo (tmp);
		}

		public static unsafe JniObjectReference CallStaticObjectMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticObjectMethod (__info.EnvironmentPointer, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference CallStaticObjectMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticObjectMethodA (__info.EnvironmentPointer, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool CallStaticBooleanMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticBooleanMethod (__info.EnvironmentPointer, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe bool CallStaticBooleanMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticBooleanMethodA (__info.EnvironmentPointer, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte CallStaticByteMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticByteMethod (__info.EnvironmentPointer, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe sbyte CallStaticByteMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticByteMethodA (__info.EnvironmentPointer, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallStaticCharMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticCharMethod (__info.EnvironmentPointer, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallStaticCharMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticCharMethodA (__info.EnvironmentPointer, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallStaticShortMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticShortMethod (__info.EnvironmentPointer, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallStaticShortMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticShortMethodA (__info.EnvironmentPointer, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallStaticIntMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticIntMethod (__info.EnvironmentPointer, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallStaticIntMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticIntMethodA (__info.EnvironmentPointer, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallStaticLongMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticLongMethod (__info.EnvironmentPointer, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallStaticLongMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticLongMethodA (__info.EnvironmentPointer, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallStaticFloatMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticFloatMethod (__info.EnvironmentPointer, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallStaticFloatMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticFloatMethodA (__info.EnvironmentPointer, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallStaticDoubleMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticDoubleMethod (__info.EnvironmentPointer, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallStaticDoubleMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticDoubleMethodA (__info.EnvironmentPointer, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe void CallStaticVoidMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallStaticVoidMethod (__info.EnvironmentPointer, type.SafeHandle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void CallStaticVoidMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallStaticVoidMethodA (__info.EnvironmentPointer, type.SafeHandle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}
	}

	public static partial class Strings {

		public static unsafe JniObjectReference NewString (IntPtr unicodeChars, int length)
		{
			if (unicodeChars == IntPtr.Zero)
				throw new ArgumentException ("'unicodeChars' must not be IntPtr.Zero.", "unicodeChars");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewString (__info.EnvironmentPointer, unicodeChars, length);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe int GetStringLength (JniObjectReference stringInstance)
		{
			if (stringInstance.SafeHandle == null)
				throw new ArgumentNullException ("stringInstance");
			if (stringInstance.SafeHandle.IsInvalid)
				throw new ArgumentException ("stringInstance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStringLength (__info.EnvironmentPointer, stringInstance.SafeHandle);
			return tmp;
		}

		public static unsafe IntPtr GetStringChars (JniObjectReference stringInstance, IntPtr isCopy)
		{
			if (stringInstance.SafeHandle == null)
				throw new ArgumentNullException ("stringInstance");
			if (stringInstance.SafeHandle.IsInvalid)
				throw new ArgumentException ("stringInstance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStringChars (__info.EnvironmentPointer, stringInstance.SafeHandle, isCopy);
			return tmp;
		}

		public static unsafe void ReleaseStringChars (JniObjectReference stringInstance, IntPtr chars)
		{
			if (stringInstance.SafeHandle == null)
				throw new ArgumentNullException ("stringInstance");
			if (stringInstance.SafeHandle.IsInvalid)
				throw new ArgumentException ("stringInstance");
			if (chars == IntPtr.Zero)
				throw new ArgumentException ("'chars' must not be IntPtr.Zero.", "chars");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseStringChars (__info.EnvironmentPointer, stringInstance.SafeHandle, chars);
		}
	}

	public static partial class Types {

		public static unsafe JniObjectReference DefineClass (string name, JniObjectReference loader, IntPtr buffer, int bufferLength)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (loader.SafeHandle == null)
				throw new ArgumentNullException ("loader");
			if (loader.SafeHandle.IsInvalid)
				throw new ArgumentException ("loader");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.DefineClass (__info.EnvironmentPointer, name, loader.SafeHandle, buffer, bufferLength);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		internal static unsafe JniObjectReference _FindClass (string classname)
		{
			if (classname == null)
				throw new ArgumentNullException ("classname");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.FindClass (__info.EnvironmentPointer, classname);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference GetSuperclass (JniObjectReference type)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetSuperclass (__info.EnvironmentPointer, type.SafeHandle);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool IsAssignableFrom (JniObjectReference class1, JniObjectReference class2)
		{
			if (class1.SafeHandle == null)
				throw new ArgumentNullException ("class1");
			if (class1.SafeHandle.IsInvalid)
				throw new ArgumentException ("class1");
			if (class2.SafeHandle == null)
				throw new ArgumentNullException ("class2");
			if (class2.SafeHandle.IsInvalid)
				throw new ArgumentException ("class2");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.IsAssignableFrom (__info.EnvironmentPointer, class1.SafeHandle, class2.SafeHandle);
			return (tmp != 0) ? true : false;
		}

		public static unsafe bool IsSameObject (JniObjectReference object1, JniObjectReference object2)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.IsSameObject (__info.EnvironmentPointer, object1.SafeHandle, object2.SafeHandle);
			return (tmp != 0) ? true : false;
		}

		public static unsafe JniObjectReference GetObjectClass (JniObjectReference instance)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetObjectClass (__info.EnvironmentPointer, instance.SafeHandle);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool IsInstanceOf (JniObjectReference instance, JniObjectReference type)
		{
			if (instance.SafeHandle == null)
				throw new ArgumentNullException ("instance");
			if (instance.SafeHandle.IsInvalid)
				throw new ArgumentException ("instance");
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.IsInstanceOf (__info.EnvironmentPointer, instance.SafeHandle, type.SafeHandle);
			return (tmp != 0) ? true : false;
		}

		internal static unsafe int _RegisterNatives (JniObjectReference type, JniNativeMethodRegistration [] methods, int numMethods)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.RegisterNatives (__info.EnvironmentPointer, type.SafeHandle, methods, numMethods);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		internal static unsafe int _UnregisterNatives (JniObjectReference type)
		{
			if (type.SafeHandle == null)
				throw new ArgumentNullException ("type");
			if (type.SafeHandle.IsInvalid)
				throw new ArgumentException ("type");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.UnregisterNatives (__info.EnvironmentPointer, type.SafeHandle);
			return tmp;
		}
	}

	internal static partial class Versions {

		internal static unsafe int GetVersion ()
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetVersion (__info.EnvironmentPointer);
			return tmp;
		}
	}
	}

	partial class JniEnvironmentInvoker {

		internal JniNativeInterfaceStruct env;

		public unsafe JniEnvironmentInvoker (JniNativeInterfaceStruct* p)
		{
			env = *p;
		}


		JniFunc_JNIEnvPtr_int _GetVersion;
		public JniFunc_JNIEnvPtr_int GetVersion {
			get {
				if (_GetVersion == null)
					_GetVersion = (JniFunc_JNIEnvPtr_int) Marshal.GetDelegateForFunctionPointer (env.GetVersion, typeof (JniFunc_JNIEnvPtr_int));
				return _GetVersion;
			}
		}

		JniFunc_JNIEnvPtr_string_JniReferenceSafeHandle_IntPtr_int_JniLocalReference _DefineClass;
		public JniFunc_JNIEnvPtr_string_JniReferenceSafeHandle_IntPtr_int_JniLocalReference DefineClass {
			get {
				if (_DefineClass == null)
					_DefineClass = (JniFunc_JNIEnvPtr_string_JniReferenceSafeHandle_IntPtr_int_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.DefineClass, typeof (JniFunc_JNIEnvPtr_string_JniReferenceSafeHandle_IntPtr_int_JniLocalReference));
				return _DefineClass;
			}
		}

		JniFunc_JNIEnvPtr_string_JniLocalReference _FindClass;
		public JniFunc_JNIEnvPtr_string_JniLocalReference FindClass {
			get {
				if (_FindClass == null)
					_FindClass = (JniFunc_JNIEnvPtr_string_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.FindClass, typeof (JniFunc_JNIEnvPtr_string_JniLocalReference));
				return _FindClass;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr _FromReflectedMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr FromReflectedMethod {
			get {
				if (_FromReflectedMethod == null)
					_FromReflectedMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr) Marshal.GetDelegateForFunctionPointer (env.FromReflectedMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr));
				return _FromReflectedMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr _FromReflectedField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr FromReflectedField {
			get {
				if (_FromReflectedField == null)
					_FromReflectedField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr) Marshal.GetDelegateForFunctionPointer (env.FromReflectedField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr));
				return _FromReflectedField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte_JniLocalReference _ToReflectedMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte_JniLocalReference ToReflectedMethod {
			get {
				if (_ToReflectedMethod == null)
					_ToReflectedMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.ToReflectedMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte_JniLocalReference));
				return _ToReflectedMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference _GetSuperclass;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference GetSuperclass {
			get {
				if (_GetSuperclass == null)
					_GetSuperclass = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.GetSuperclass, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference));
				return _GetSuperclass;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_byte _IsAssignableFrom;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_byte IsAssignableFrom {
			get {
				if (_IsAssignableFrom == null)
					_IsAssignableFrom = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_byte) Marshal.GetDelegateForFunctionPointer (env.IsAssignableFrom, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_byte));
				return _IsAssignableFrom;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte_JniLocalReference _ToReflectedField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte_JniLocalReference ToReflectedField {
			get {
				if (_ToReflectedField == null)
					_ToReflectedField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.ToReflectedField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte_JniLocalReference));
				return _ToReflectedField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int _Throw;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int Throw {
			get {
				if (_Throw == null)
					_Throw = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int) Marshal.GetDelegateForFunctionPointer (env.Throw, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int));
				return _Throw;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_int _ThrowNew;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_int ThrowNew {
			get {
				if (_ThrowNew == null)
					_ThrowNew = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_int) Marshal.GetDelegateForFunctionPointer (env.ThrowNew, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_int));
				return _ThrowNew;
			}
		}

		JniFunc_JNIEnvPtr_JniLocalReference _ExceptionOccurred;
		public JniFunc_JNIEnvPtr_JniLocalReference ExceptionOccurred {
			get {
				if (_ExceptionOccurred == null)
					_ExceptionOccurred = (JniFunc_JNIEnvPtr_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.ExceptionOccurred, typeof (JniFunc_JNIEnvPtr_JniLocalReference));
				return _ExceptionOccurred;
			}
		}

		JniAction_JNIEnvPtr _ExceptionDescribe;
		public JniAction_JNIEnvPtr ExceptionDescribe {
			get {
				if (_ExceptionDescribe == null)
					_ExceptionDescribe = (JniAction_JNIEnvPtr) Marshal.GetDelegateForFunctionPointer (env.ExceptionDescribe, typeof (JniAction_JNIEnvPtr));
				return _ExceptionDescribe;
			}
		}

		JniAction_JNIEnvPtr _ExceptionClear;
		public JniAction_JNIEnvPtr ExceptionClear {
			get {
				if (_ExceptionClear == null)
					_ExceptionClear = (JniAction_JNIEnvPtr) Marshal.GetDelegateForFunctionPointer (env.ExceptionClear, typeof (JniAction_JNIEnvPtr));
				return _ExceptionClear;
			}
		}

		JniAction_JNIEnvPtr_string _FatalError;
		public JniAction_JNIEnvPtr_string FatalError {
			get {
				if (_FatalError == null)
					_FatalError = (JniAction_JNIEnvPtr_string) Marshal.GetDelegateForFunctionPointer (env.FatalError, typeof (JniAction_JNIEnvPtr_string));
				return _FatalError;
			}
		}

		JniFunc_JNIEnvPtr_int_int _PushLocalFrame;
		public JniFunc_JNIEnvPtr_int_int PushLocalFrame {
			get {
				if (_PushLocalFrame == null)
					_PushLocalFrame = (JniFunc_JNIEnvPtr_int_int) Marshal.GetDelegateForFunctionPointer (env.PushLocalFrame, typeof (JniFunc_JNIEnvPtr_int_int));
				return _PushLocalFrame;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference _PopLocalFrame;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference PopLocalFrame {
			get {
				if (_PopLocalFrame == null)
					_PopLocalFrame = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.PopLocalFrame, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference));
				return _PopLocalFrame;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniGlobalReference _NewGlobalRef;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniGlobalReference NewGlobalRef {
			get {
				if (_NewGlobalRef == null)
					_NewGlobalRef = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniGlobalReference) Marshal.GetDelegateForFunctionPointer (env.NewGlobalRef, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniGlobalReference));
				return _NewGlobalRef;
			}
		}

		JniAction_JNIEnvPtr_IntPtr _DeleteGlobalRef;
		public JniAction_JNIEnvPtr_IntPtr DeleteGlobalRef {
			get {
				if (_DeleteGlobalRef == null)
					_DeleteGlobalRef = (JniAction_JNIEnvPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.DeleteGlobalRef, typeof (JniAction_JNIEnvPtr_IntPtr));
				return _DeleteGlobalRef;
			}
		}

		JniAction_JNIEnvPtr_IntPtr _DeleteLocalRef;
		public JniAction_JNIEnvPtr_IntPtr DeleteLocalRef {
			get {
				if (_DeleteLocalRef == null)
					_DeleteLocalRef = (JniAction_JNIEnvPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.DeleteLocalRef, typeof (JniAction_JNIEnvPtr_IntPtr));
				return _DeleteLocalRef;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_byte _IsSameObject;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_byte IsSameObject {
			get {
				if (_IsSameObject == null)
					_IsSameObject = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_byte) Marshal.GetDelegateForFunctionPointer (env.IsSameObject, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_byte));
				return _IsSameObject;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference _NewLocalRef;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference NewLocalRef {
			get {
				if (_NewLocalRef == null)
					_NewLocalRef = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.NewLocalRef, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference));
				return _NewLocalRef;
			}
		}

		JniFunc_JNIEnvPtr_int_int _EnsureLocalCapacity;
		public JniFunc_JNIEnvPtr_int_int EnsureLocalCapacity {
			get {
				if (_EnsureLocalCapacity == null)
					_EnsureLocalCapacity = (JniFunc_JNIEnvPtr_int_int) Marshal.GetDelegateForFunctionPointer (env.EnsureLocalCapacity, typeof (JniFunc_JNIEnvPtr_int_int));
				return _EnsureLocalCapacity;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference _AllocObject;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference AllocObject {
			get {
				if (_AllocObject == null)
					_AllocObject = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.AllocObject, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference));
				return _AllocObject;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference _NewObject;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference NewObject {
			get {
				if (_NewObject == null)
					_NewObject = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.NewObject, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference));
				return _NewObject;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference _NewObjectA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference NewObjectA {
			get {
				if (_NewObjectA == null)
					_NewObjectA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.NewObjectA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference));
				return _NewObjectA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference _GetObjectClass;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference GetObjectClass {
			get {
				if (_GetObjectClass == null)
					_GetObjectClass = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.GetObjectClass, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniLocalReference));
				return _GetObjectClass;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_byte _IsInstanceOf;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_byte IsInstanceOf {
			get {
				if (_IsInstanceOf == null)
					_IsInstanceOf = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_byte) Marshal.GetDelegateForFunctionPointer (env.IsInstanceOf, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_byte));
				return _IsInstanceOf;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_string_IntPtr _GetMethodID;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_string_IntPtr GetMethodID {
			get {
				if (_GetMethodID == null)
					_GetMethodID = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_string_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetMethodID, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_string_IntPtr));
				return _GetMethodID;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference _CallObjectMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference CallObjectMethod {
			get {
				if (_CallObjectMethod == null)
					_CallObjectMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.CallObjectMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference));
				return _CallObjectMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference _CallObjectMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference CallObjectMethodA {
			get {
				if (_CallObjectMethodA == null)
					_CallObjectMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.CallObjectMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference));
				return _CallObjectMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte _CallBooleanMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte CallBooleanMethod {
			get {
				if (_CallBooleanMethod == null)
					_CallBooleanMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.CallBooleanMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte));
				return _CallBooleanMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_byte _CallBooleanMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_byte CallBooleanMethodA {
			get {
				if (_CallBooleanMethodA == null)
					_CallBooleanMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_byte) Marshal.GetDelegateForFunctionPointer (env.CallBooleanMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_byte));
				return _CallBooleanMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte _CallByteMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte CallByteMethod {
			get {
				if (_CallByteMethod == null)
					_CallByteMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallByteMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte));
				return _CallByteMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_sbyte _CallByteMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_sbyte CallByteMethodA {
			get {
				if (_CallByteMethodA == null)
					_CallByteMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallByteMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_sbyte));
				return _CallByteMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char _CallCharMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char CallCharMethod {
			get {
				if (_CallCharMethod == null)
					_CallCharMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.CallCharMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char));
				return _CallCharMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_char _CallCharMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_char CallCharMethodA {
			get {
				if (_CallCharMethodA == null)
					_CallCharMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_char) Marshal.GetDelegateForFunctionPointer (env.CallCharMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_char));
				return _CallCharMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short _CallShortMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short CallShortMethod {
			get {
				if (_CallShortMethod == null)
					_CallShortMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.CallShortMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short));
				return _CallShortMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_short _CallShortMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_short CallShortMethodA {
			get {
				if (_CallShortMethodA == null)
					_CallShortMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_short) Marshal.GetDelegateForFunctionPointer (env.CallShortMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_short));
				return _CallShortMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int _CallIntMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int CallIntMethod {
			get {
				if (_CallIntMethod == null)
					_CallIntMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.CallIntMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int));
				return _CallIntMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_int _CallIntMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_int CallIntMethodA {
			get {
				if (_CallIntMethodA == null)
					_CallIntMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_int) Marshal.GetDelegateForFunctionPointer (env.CallIntMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_int));
				return _CallIntMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long _CallLongMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long CallLongMethod {
			get {
				if (_CallLongMethod == null)
					_CallLongMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.CallLongMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long));
				return _CallLongMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_long _CallLongMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_long CallLongMethodA {
			get {
				if (_CallLongMethodA == null)
					_CallLongMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_long) Marshal.GetDelegateForFunctionPointer (env.CallLongMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_long));
				return _CallLongMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float _CallFloatMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float CallFloatMethod {
			get {
				if (_CallFloatMethod == null)
					_CallFloatMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.CallFloatMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float));
				return _CallFloatMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_float _CallFloatMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_float CallFloatMethodA {
			get {
				if (_CallFloatMethodA == null)
					_CallFloatMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_float) Marshal.GetDelegateForFunctionPointer (env.CallFloatMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_float));
				return _CallFloatMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double _CallDoubleMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double CallDoubleMethod {
			get {
				if (_CallDoubleMethod == null)
					_CallDoubleMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.CallDoubleMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double));
				return _CallDoubleMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_double _CallDoubleMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_double CallDoubleMethodA {
			get {
				if (_CallDoubleMethodA == null)
					_CallDoubleMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_double) Marshal.GetDelegateForFunctionPointer (env.CallDoubleMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_double));
				return _CallDoubleMethodA;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr _CallVoidMethod;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr CallVoidMethod {
			get {
				if (_CallVoidMethod == null)
					_CallVoidMethod = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr) Marshal.GetDelegateForFunctionPointer (env.CallVoidMethod, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr));
				return _CallVoidMethod;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef _CallVoidMethodA;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef CallVoidMethodA {
			get {
				if (_CallVoidMethodA == null)
					_CallVoidMethodA = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef) Marshal.GetDelegateForFunctionPointer (env.CallVoidMethodA, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef));
				return _CallVoidMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniLocalReference _CallNonvirtualObjectMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniLocalReference CallNonvirtualObjectMethod {
			get {
				if (_CallNonvirtualObjectMethod == null)
					_CallNonvirtualObjectMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualObjectMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniLocalReference));
				return _CallNonvirtualObjectMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference _CallNonvirtualObjectMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference CallNonvirtualObjectMethodA {
			get {
				if (_CallNonvirtualObjectMethodA == null)
					_CallNonvirtualObjectMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualObjectMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference));
				return _CallNonvirtualObjectMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_byte _CallNonvirtualBooleanMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_byte CallNonvirtualBooleanMethod {
			get {
				if (_CallNonvirtualBooleanMethod == null)
					_CallNonvirtualBooleanMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualBooleanMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_byte));
				return _CallNonvirtualBooleanMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_byte _CallNonvirtualBooleanMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_byte CallNonvirtualBooleanMethodA {
			get {
				if (_CallNonvirtualBooleanMethodA == null)
					_CallNonvirtualBooleanMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_byte) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualBooleanMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_byte));
				return _CallNonvirtualBooleanMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_sbyte _CallNonvirtualByteMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_sbyte CallNonvirtualByteMethod {
			get {
				if (_CallNonvirtualByteMethod == null)
					_CallNonvirtualByteMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualByteMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_sbyte));
				return _CallNonvirtualByteMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_sbyte _CallNonvirtualByteMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_sbyte CallNonvirtualByteMethodA {
			get {
				if (_CallNonvirtualByteMethodA == null)
					_CallNonvirtualByteMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualByteMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_sbyte));
				return _CallNonvirtualByteMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_char _CallNonvirtualCharMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_char CallNonvirtualCharMethod {
			get {
				if (_CallNonvirtualCharMethod == null)
					_CallNonvirtualCharMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualCharMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_char));
				return _CallNonvirtualCharMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_char _CallNonvirtualCharMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_char CallNonvirtualCharMethodA {
			get {
				if (_CallNonvirtualCharMethodA == null)
					_CallNonvirtualCharMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_char) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualCharMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_char));
				return _CallNonvirtualCharMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_short _CallNonvirtualShortMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_short CallNonvirtualShortMethod {
			get {
				if (_CallNonvirtualShortMethod == null)
					_CallNonvirtualShortMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualShortMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_short));
				return _CallNonvirtualShortMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_short _CallNonvirtualShortMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_short CallNonvirtualShortMethodA {
			get {
				if (_CallNonvirtualShortMethodA == null)
					_CallNonvirtualShortMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_short) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualShortMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_short));
				return _CallNonvirtualShortMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_int _CallNonvirtualIntMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_int CallNonvirtualIntMethod {
			get {
				if (_CallNonvirtualIntMethod == null)
					_CallNonvirtualIntMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualIntMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_int));
				return _CallNonvirtualIntMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_int _CallNonvirtualIntMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_int CallNonvirtualIntMethodA {
			get {
				if (_CallNonvirtualIntMethodA == null)
					_CallNonvirtualIntMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_int) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualIntMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_int));
				return _CallNonvirtualIntMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_long _CallNonvirtualLongMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_long CallNonvirtualLongMethod {
			get {
				if (_CallNonvirtualLongMethod == null)
					_CallNonvirtualLongMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualLongMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_long));
				return _CallNonvirtualLongMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_long _CallNonvirtualLongMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_long CallNonvirtualLongMethodA {
			get {
				if (_CallNonvirtualLongMethodA == null)
					_CallNonvirtualLongMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_long) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualLongMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_long));
				return _CallNonvirtualLongMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_float _CallNonvirtualFloatMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_float CallNonvirtualFloatMethod {
			get {
				if (_CallNonvirtualFloatMethod == null)
					_CallNonvirtualFloatMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualFloatMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_float));
				return _CallNonvirtualFloatMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_float _CallNonvirtualFloatMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_float CallNonvirtualFloatMethodA {
			get {
				if (_CallNonvirtualFloatMethodA == null)
					_CallNonvirtualFloatMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_float) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualFloatMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_float));
				return _CallNonvirtualFloatMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_double _CallNonvirtualDoubleMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_double CallNonvirtualDoubleMethod {
			get {
				if (_CallNonvirtualDoubleMethod == null)
					_CallNonvirtualDoubleMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualDoubleMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_double));
				return _CallNonvirtualDoubleMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_double _CallNonvirtualDoubleMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_double CallNonvirtualDoubleMethodA {
			get {
				if (_CallNonvirtualDoubleMethodA == null)
					_CallNonvirtualDoubleMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_double) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualDoubleMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_double));
				return _CallNonvirtualDoubleMethodA;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr _CallNonvirtualVoidMethod;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr CallNonvirtualVoidMethod {
			get {
				if (_CallNonvirtualVoidMethod == null)
					_CallNonvirtualVoidMethod = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualVoidMethod, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr));
				return _CallNonvirtualVoidMethod;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef _CallNonvirtualVoidMethodA;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef CallNonvirtualVoidMethodA {
			get {
				if (_CallNonvirtualVoidMethodA == null)
					_CallNonvirtualVoidMethodA = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualVoidMethodA, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef));
				return _CallNonvirtualVoidMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_string_IntPtr _GetFieldID;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_string_IntPtr GetFieldID {
			get {
				if (_GetFieldID == null)
					_GetFieldID = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_string_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetFieldID, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_string_IntPtr));
				return _GetFieldID;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference _GetObjectField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference GetObjectField {
			get {
				if (_GetObjectField == null)
					_GetObjectField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.GetObjectField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference));
				return _GetObjectField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte _GetBooleanField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte GetBooleanField {
			get {
				if (_GetBooleanField == null)
					_GetBooleanField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.GetBooleanField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte));
				return _GetBooleanField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte _GetByteField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte GetByteField {
			get {
				if (_GetByteField == null)
					_GetByteField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.GetByteField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte));
				return _GetByteField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char _GetCharField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char GetCharField {
			get {
				if (_GetCharField == null)
					_GetCharField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.GetCharField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char));
				return _GetCharField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short _GetShortField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short GetShortField {
			get {
				if (_GetShortField == null)
					_GetShortField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.GetShortField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short));
				return _GetShortField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int _GetIntField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int GetIntField {
			get {
				if (_GetIntField == null)
					_GetIntField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.GetIntField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int));
				return _GetIntField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long _GetLongField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long GetLongField {
			get {
				if (_GetLongField == null)
					_GetLongField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.GetLongField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long));
				return _GetLongField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float _GetFloatField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float GetFloatField {
			get {
				if (_GetFloatField == null)
					_GetFloatField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.GetFloatField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float));
				return _GetFloatField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double _GetDoubleField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double GetDoubleField {
			get {
				if (_GetDoubleField == null)
					_GetDoubleField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.GetDoubleField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double));
				return _GetDoubleField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniReferenceSafeHandle _SetObjectField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniReferenceSafeHandle SetObjectField {
			get {
				if (_SetObjectField == null)
					_SetObjectField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniReferenceSafeHandle) Marshal.GetDelegateForFunctionPointer (env.SetObjectField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniReferenceSafeHandle));
				return _SetObjectField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte _SetBooleanField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte SetBooleanField {
			get {
				if (_SetBooleanField == null)
					_SetBooleanField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.SetBooleanField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte));
				return _SetBooleanField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte _SetByteField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte SetByteField {
			get {
				if (_SetByteField == null)
					_SetByteField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.SetByteField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte));
				return _SetByteField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char _SetCharField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char SetCharField {
			get {
				if (_SetCharField == null)
					_SetCharField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.SetCharField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char));
				return _SetCharField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short _SetShortField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short SetShortField {
			get {
				if (_SetShortField == null)
					_SetShortField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.SetShortField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short));
				return _SetShortField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int _SetIntField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int SetIntField {
			get {
				if (_SetIntField == null)
					_SetIntField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.SetIntField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int));
				return _SetIntField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long _SetLongField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long SetLongField {
			get {
				if (_SetLongField == null)
					_SetLongField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.SetLongField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long));
				return _SetLongField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float _SetFloatField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float SetFloatField {
			get {
				if (_SetFloatField == null)
					_SetFloatField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.SetFloatField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float));
				return _SetFloatField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double _SetDoubleField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double SetDoubleField {
			get {
				if (_SetDoubleField == null)
					_SetDoubleField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.SetDoubleField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double));
				return _SetDoubleField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_string_IntPtr _GetStaticMethodID;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_string_IntPtr GetStaticMethodID {
			get {
				if (_GetStaticMethodID == null)
					_GetStaticMethodID = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_string_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetStaticMethodID, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_string_IntPtr));
				return _GetStaticMethodID;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference _CallStaticObjectMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference CallStaticObjectMethod {
			get {
				if (_CallStaticObjectMethod == null)
					_CallStaticObjectMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.CallStaticObjectMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference));
				return _CallStaticObjectMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference _CallStaticObjectMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference CallStaticObjectMethodA {
			get {
				if (_CallStaticObjectMethodA == null)
					_CallStaticObjectMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.CallStaticObjectMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_JniLocalReference));
				return _CallStaticObjectMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte _CallStaticBooleanMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte CallStaticBooleanMethod {
			get {
				if (_CallStaticBooleanMethod == null)
					_CallStaticBooleanMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.CallStaticBooleanMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte));
				return _CallStaticBooleanMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_byte _CallStaticBooleanMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_byte CallStaticBooleanMethodA {
			get {
				if (_CallStaticBooleanMethodA == null)
					_CallStaticBooleanMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_byte) Marshal.GetDelegateForFunctionPointer (env.CallStaticBooleanMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_byte));
				return _CallStaticBooleanMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte _CallStaticByteMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte CallStaticByteMethod {
			get {
				if (_CallStaticByteMethod == null)
					_CallStaticByteMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallStaticByteMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte));
				return _CallStaticByteMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_sbyte _CallStaticByteMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_sbyte CallStaticByteMethodA {
			get {
				if (_CallStaticByteMethodA == null)
					_CallStaticByteMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallStaticByteMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_sbyte));
				return _CallStaticByteMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char _CallStaticCharMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char CallStaticCharMethod {
			get {
				if (_CallStaticCharMethod == null)
					_CallStaticCharMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.CallStaticCharMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char));
				return _CallStaticCharMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_char _CallStaticCharMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_char CallStaticCharMethodA {
			get {
				if (_CallStaticCharMethodA == null)
					_CallStaticCharMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_char) Marshal.GetDelegateForFunctionPointer (env.CallStaticCharMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_char));
				return _CallStaticCharMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short _CallStaticShortMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short CallStaticShortMethod {
			get {
				if (_CallStaticShortMethod == null)
					_CallStaticShortMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.CallStaticShortMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short));
				return _CallStaticShortMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_short _CallStaticShortMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_short CallStaticShortMethodA {
			get {
				if (_CallStaticShortMethodA == null)
					_CallStaticShortMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_short) Marshal.GetDelegateForFunctionPointer (env.CallStaticShortMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_short));
				return _CallStaticShortMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int _CallStaticIntMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int CallStaticIntMethod {
			get {
				if (_CallStaticIntMethod == null)
					_CallStaticIntMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.CallStaticIntMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int));
				return _CallStaticIntMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_int _CallStaticIntMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_int CallStaticIntMethodA {
			get {
				if (_CallStaticIntMethodA == null)
					_CallStaticIntMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_int) Marshal.GetDelegateForFunctionPointer (env.CallStaticIntMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_int));
				return _CallStaticIntMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long _CallStaticLongMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long CallStaticLongMethod {
			get {
				if (_CallStaticLongMethod == null)
					_CallStaticLongMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.CallStaticLongMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long));
				return _CallStaticLongMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_long _CallStaticLongMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_long CallStaticLongMethodA {
			get {
				if (_CallStaticLongMethodA == null)
					_CallStaticLongMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_long) Marshal.GetDelegateForFunctionPointer (env.CallStaticLongMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_long));
				return _CallStaticLongMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float _CallStaticFloatMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float CallStaticFloatMethod {
			get {
				if (_CallStaticFloatMethod == null)
					_CallStaticFloatMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.CallStaticFloatMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float));
				return _CallStaticFloatMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_float _CallStaticFloatMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_float CallStaticFloatMethodA {
			get {
				if (_CallStaticFloatMethodA == null)
					_CallStaticFloatMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_float) Marshal.GetDelegateForFunctionPointer (env.CallStaticFloatMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_float));
				return _CallStaticFloatMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double _CallStaticDoubleMethod;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double CallStaticDoubleMethod {
			get {
				if (_CallStaticDoubleMethod == null)
					_CallStaticDoubleMethod = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.CallStaticDoubleMethod, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double));
				return _CallStaticDoubleMethod;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_double _CallStaticDoubleMethodA;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_double CallStaticDoubleMethodA {
			get {
				if (_CallStaticDoubleMethodA == null)
					_CallStaticDoubleMethodA = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_double) Marshal.GetDelegateForFunctionPointer (env.CallStaticDoubleMethodA, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef_double));
				return _CallStaticDoubleMethodA;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr _CallStaticVoidMethod;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr CallStaticVoidMethod {
			get {
				if (_CallStaticVoidMethod == null)
					_CallStaticVoidMethod = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr) Marshal.GetDelegateForFunctionPointer (env.CallStaticVoidMethod, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr));
				return _CallStaticVoidMethod;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef _CallStaticVoidMethodA;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef CallStaticVoidMethodA {
			get {
				if (_CallStaticVoidMethodA == null)
					_CallStaticVoidMethodA = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef) Marshal.GetDelegateForFunctionPointer (env.CallStaticVoidMethodA, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniArgumentValueRef));
				return _CallStaticVoidMethodA;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_string_IntPtr _GetStaticFieldID;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_string_IntPtr GetStaticFieldID {
			get {
				if (_GetStaticFieldID == null)
					_GetStaticFieldID = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_string_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetStaticFieldID, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_string_string_IntPtr));
				return _GetStaticFieldID;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference _GetStaticObjectField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference GetStaticObjectField {
			get {
				if (_GetStaticObjectField == null)
					_GetStaticObjectField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.GetStaticObjectField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniLocalReference));
				return _GetStaticObjectField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte _GetStaticBooleanField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte GetStaticBooleanField {
			get {
				if (_GetStaticBooleanField == null)
					_GetStaticBooleanField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.GetStaticBooleanField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte));
				return _GetStaticBooleanField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte _GetStaticByteField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte GetStaticByteField {
			get {
				if (_GetStaticByteField == null)
					_GetStaticByteField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.GetStaticByteField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte));
				return _GetStaticByteField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char _GetStaticCharField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char GetStaticCharField {
			get {
				if (_GetStaticCharField == null)
					_GetStaticCharField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.GetStaticCharField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char));
				return _GetStaticCharField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short _GetStaticShortField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short GetStaticShortField {
			get {
				if (_GetStaticShortField == null)
					_GetStaticShortField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.GetStaticShortField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short));
				return _GetStaticShortField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int _GetStaticIntField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int GetStaticIntField {
			get {
				if (_GetStaticIntField == null)
					_GetStaticIntField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.GetStaticIntField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int));
				return _GetStaticIntField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long _GetStaticLongField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long GetStaticLongField {
			get {
				if (_GetStaticLongField == null)
					_GetStaticLongField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.GetStaticLongField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long));
				return _GetStaticLongField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float _GetStaticFloatField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float GetStaticFloatField {
			get {
				if (_GetStaticFloatField == null)
					_GetStaticFloatField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.GetStaticFloatField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float));
				return _GetStaticFloatField;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double _GetStaticDoubleField;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double GetStaticDoubleField {
			get {
				if (_GetStaticDoubleField == null)
					_GetStaticDoubleField = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.GetStaticDoubleField, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double));
				return _GetStaticDoubleField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniReferenceSafeHandle _SetStaticObjectField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniReferenceSafeHandle SetStaticObjectField {
			get {
				if (_SetStaticObjectField == null)
					_SetStaticObjectField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniReferenceSafeHandle) Marshal.GetDelegateForFunctionPointer (env.SetStaticObjectField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_JniReferenceSafeHandle));
				return _SetStaticObjectField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte _SetStaticBooleanField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte SetStaticBooleanField {
			get {
				if (_SetStaticBooleanField == null)
					_SetStaticBooleanField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.SetStaticBooleanField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_byte));
				return _SetStaticBooleanField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte _SetStaticByteField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte SetStaticByteField {
			get {
				if (_SetStaticByteField == null)
					_SetStaticByteField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.SetStaticByteField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_sbyte));
				return _SetStaticByteField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char _SetStaticCharField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char SetStaticCharField {
			get {
				if (_SetStaticCharField == null)
					_SetStaticCharField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.SetStaticCharField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_char));
				return _SetStaticCharField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short _SetStaticShortField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short SetStaticShortField {
			get {
				if (_SetStaticShortField == null)
					_SetStaticShortField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.SetStaticShortField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_short));
				return _SetStaticShortField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int _SetStaticIntField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int SetStaticIntField {
			get {
				if (_SetStaticIntField == null)
					_SetStaticIntField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.SetStaticIntField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int));
				return _SetStaticIntField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long _SetStaticLongField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long SetStaticLongField {
			get {
				if (_SetStaticLongField == null)
					_SetStaticLongField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.SetStaticLongField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_long));
				return _SetStaticLongField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float _SetStaticFloatField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float SetStaticFloatField {
			get {
				if (_SetStaticFloatField == null)
					_SetStaticFloatField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.SetStaticFloatField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_float));
				return _SetStaticFloatField;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double _SetStaticDoubleField;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double SetStaticDoubleField {
			get {
				if (_SetStaticDoubleField == null)
					_SetStaticDoubleField = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.SetStaticDoubleField, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_double));
				return _SetStaticDoubleField;
			}
		}

		JniFunc_JNIEnvPtr_IntPtr_int_JniLocalReference _NewString;
		public JniFunc_JNIEnvPtr_IntPtr_int_JniLocalReference NewString {
			get {
				if (_NewString == null)
					_NewString = (JniFunc_JNIEnvPtr_IntPtr_int_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.NewString, typeof (JniFunc_JNIEnvPtr_IntPtr_int_JniLocalReference));
				return _NewString;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int _GetStringLength;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int GetStringLength {
			get {
				if (_GetStringLength == null)
					_GetStringLength = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int) Marshal.GetDelegateForFunctionPointer (env.GetStringLength, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int));
				return _GetStringLength;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr _GetStringChars;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr GetStringChars {
			get {
				if (_GetStringChars == null)
					_GetStringChars = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetStringChars, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr));
				return _GetStringChars;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr _ReleaseStringChars;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr ReleaseStringChars {
			get {
				if (_ReleaseStringChars == null)
					_ReleaseStringChars = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr) Marshal.GetDelegateForFunctionPointer (env.ReleaseStringChars, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr));
				return _ReleaseStringChars;
			}
		}

		JniFunc_JNIEnvPtr_string_JniLocalReference _NewStringUTF;
		public JniFunc_JNIEnvPtr_string_JniLocalReference NewStringUTF {
			get {
				if (_NewStringUTF == null)
					_NewStringUTF = (JniFunc_JNIEnvPtr_string_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.NewStringUTF, typeof (JniFunc_JNIEnvPtr_string_JniLocalReference));
				return _NewStringUTF;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int _GetStringUTFLength;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int GetStringUTFLength {
			get {
				if (_GetStringUTFLength == null)
					_GetStringUTFLength = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int) Marshal.GetDelegateForFunctionPointer (env.GetStringUTFLength, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int));
				return _GetStringUTFLength;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_string _GetStringUTFChars;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_string GetStringUTFChars {
			get {
				if (_GetStringUTFChars == null)
					_GetStringUTFChars = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_string) Marshal.GetDelegateForFunctionPointer (env.GetStringUTFChars, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_string));
				return _GetStringUTFChars;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_string _ReleaseStringUTFChars;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_string ReleaseStringUTFChars {
			get {
				if (_ReleaseStringUTFChars == null)
					_ReleaseStringUTFChars = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_string) Marshal.GetDelegateForFunctionPointer (env.ReleaseStringUTFChars, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_string));
				return _ReleaseStringUTFChars;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int _GetArrayLength;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int GetArrayLength {
			get {
				if (_GetArrayLength == null)
					_GetArrayLength = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int) Marshal.GetDelegateForFunctionPointer (env.GetArrayLength, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int));
				return _GetArrayLength;
			}
		}

		JniFunc_JNIEnvPtr_int_JniReferenceSafeHandle_JniReferenceSafeHandle_JniLocalReference _NewObjectArray;
		public JniFunc_JNIEnvPtr_int_JniReferenceSafeHandle_JniReferenceSafeHandle_JniLocalReference NewObjectArray {
			get {
				if (_NewObjectArray == null)
					_NewObjectArray = (JniFunc_JNIEnvPtr_int_JniReferenceSafeHandle_JniReferenceSafeHandle_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.NewObjectArray, typeof (JniFunc_JNIEnvPtr_int_JniReferenceSafeHandle_JniReferenceSafeHandle_JniLocalReference));
				return _NewObjectArray;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int_JniLocalReference _GetObjectArrayElement;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int_JniLocalReference GetObjectArrayElement {
			get {
				if (_GetObjectArrayElement == null)
					_GetObjectArrayElement = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.GetObjectArrayElement, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int_JniLocalReference));
				return _GetObjectArrayElement;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_JniReferenceSafeHandle _SetObjectArrayElement;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_JniReferenceSafeHandle SetObjectArrayElement {
			get {
				if (_SetObjectArrayElement == null)
					_SetObjectArrayElement = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_JniReferenceSafeHandle) Marshal.GetDelegateForFunctionPointer (env.SetObjectArrayElement, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_JniReferenceSafeHandle));
				return _SetObjectArrayElement;
			}
		}

		JniFunc_JNIEnvPtr_int_JniLocalReference _NewBooleanArray;
		public JniFunc_JNIEnvPtr_int_JniLocalReference NewBooleanArray {
			get {
				if (_NewBooleanArray == null)
					_NewBooleanArray = (JniFunc_JNIEnvPtr_int_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.NewBooleanArray, typeof (JniFunc_JNIEnvPtr_int_JniLocalReference));
				return _NewBooleanArray;
			}
		}

		JniFunc_JNIEnvPtr_int_JniLocalReference _NewByteArray;
		public JniFunc_JNIEnvPtr_int_JniLocalReference NewByteArray {
			get {
				if (_NewByteArray == null)
					_NewByteArray = (JniFunc_JNIEnvPtr_int_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.NewByteArray, typeof (JniFunc_JNIEnvPtr_int_JniLocalReference));
				return _NewByteArray;
			}
		}

		JniFunc_JNIEnvPtr_int_JniLocalReference _NewCharArray;
		public JniFunc_JNIEnvPtr_int_JniLocalReference NewCharArray {
			get {
				if (_NewCharArray == null)
					_NewCharArray = (JniFunc_JNIEnvPtr_int_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.NewCharArray, typeof (JniFunc_JNIEnvPtr_int_JniLocalReference));
				return _NewCharArray;
			}
		}

		JniFunc_JNIEnvPtr_int_JniLocalReference _NewShortArray;
		public JniFunc_JNIEnvPtr_int_JniLocalReference NewShortArray {
			get {
				if (_NewShortArray == null)
					_NewShortArray = (JniFunc_JNIEnvPtr_int_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.NewShortArray, typeof (JniFunc_JNIEnvPtr_int_JniLocalReference));
				return _NewShortArray;
			}
		}

		JniFunc_JNIEnvPtr_int_JniLocalReference _NewIntArray;
		public JniFunc_JNIEnvPtr_int_JniLocalReference NewIntArray {
			get {
				if (_NewIntArray == null)
					_NewIntArray = (JniFunc_JNIEnvPtr_int_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.NewIntArray, typeof (JniFunc_JNIEnvPtr_int_JniLocalReference));
				return _NewIntArray;
			}
		}

		JniFunc_JNIEnvPtr_int_JniLocalReference _NewLongArray;
		public JniFunc_JNIEnvPtr_int_JniLocalReference NewLongArray {
			get {
				if (_NewLongArray == null)
					_NewLongArray = (JniFunc_JNIEnvPtr_int_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.NewLongArray, typeof (JniFunc_JNIEnvPtr_int_JniLocalReference));
				return _NewLongArray;
			}
		}

		JniFunc_JNIEnvPtr_int_JniLocalReference _NewFloatArray;
		public JniFunc_JNIEnvPtr_int_JniLocalReference NewFloatArray {
			get {
				if (_NewFloatArray == null)
					_NewFloatArray = (JniFunc_JNIEnvPtr_int_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.NewFloatArray, typeof (JniFunc_JNIEnvPtr_int_JniLocalReference));
				return _NewFloatArray;
			}
		}

		JniFunc_JNIEnvPtr_int_JniLocalReference _NewDoubleArray;
		public JniFunc_JNIEnvPtr_int_JniLocalReference NewDoubleArray {
			get {
				if (_NewDoubleArray == null)
					_NewDoubleArray = (JniFunc_JNIEnvPtr_int_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.NewDoubleArray, typeof (JniFunc_JNIEnvPtr_int_JniLocalReference));
				return _NewDoubleArray;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr _GetBooleanArrayElements;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr GetBooleanArrayElements {
			get {
				if (_GetBooleanArrayElements == null)
					_GetBooleanArrayElements = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetBooleanArrayElements, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr));
				return _GetBooleanArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr _GetByteArrayElements;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr GetByteArrayElements {
			get {
				if (_GetByteArrayElements == null)
					_GetByteArrayElements = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetByteArrayElements, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr));
				return _GetByteArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr _GetCharArrayElements;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr GetCharArrayElements {
			get {
				if (_GetCharArrayElements == null)
					_GetCharArrayElements = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetCharArrayElements, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr));
				return _GetCharArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr _GetShortArrayElements;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr GetShortArrayElements {
			get {
				if (_GetShortArrayElements == null)
					_GetShortArrayElements = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetShortArrayElements, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr));
				return _GetShortArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr _GetIntArrayElements;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr GetIntArrayElements {
			get {
				if (_GetIntArrayElements == null)
					_GetIntArrayElements = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetIntArrayElements, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr));
				return _GetIntArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr _GetLongArrayElements;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr GetLongArrayElements {
			get {
				if (_GetLongArrayElements == null)
					_GetLongArrayElements = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetLongArrayElements, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr));
				return _GetLongArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr _GetFloatArrayElements;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr GetFloatArrayElements {
			get {
				if (_GetFloatArrayElements == null)
					_GetFloatArrayElements = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetFloatArrayElements, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr));
				return _GetFloatArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr _GetDoubleArrayElements;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr GetDoubleArrayElements {
			get {
				if (_GetDoubleArrayElements == null)
					_GetDoubleArrayElements = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetDoubleArrayElements, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr));
				return _GetDoubleArrayElements;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int _ReleaseBooleanArrayElements;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int ReleaseBooleanArrayElements {
			get {
				if (_ReleaseBooleanArrayElements == null)
					_ReleaseBooleanArrayElements = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseBooleanArrayElements, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int));
				return _ReleaseBooleanArrayElements;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int _ReleaseByteArrayElements;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int ReleaseByteArrayElements {
			get {
				if (_ReleaseByteArrayElements == null)
					_ReleaseByteArrayElements = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseByteArrayElements, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int));
				return _ReleaseByteArrayElements;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int _ReleaseCharArrayElements;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int ReleaseCharArrayElements {
			get {
				if (_ReleaseCharArrayElements == null)
					_ReleaseCharArrayElements = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseCharArrayElements, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int));
				return _ReleaseCharArrayElements;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int _ReleaseShortArrayElements;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int ReleaseShortArrayElements {
			get {
				if (_ReleaseShortArrayElements == null)
					_ReleaseShortArrayElements = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseShortArrayElements, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int));
				return _ReleaseShortArrayElements;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int _ReleaseIntArrayElements;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int ReleaseIntArrayElements {
			get {
				if (_ReleaseIntArrayElements == null)
					_ReleaseIntArrayElements = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseIntArrayElements, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int));
				return _ReleaseIntArrayElements;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int _ReleaseLongArrayElements;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int ReleaseLongArrayElements {
			get {
				if (_ReleaseLongArrayElements == null)
					_ReleaseLongArrayElements = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseLongArrayElements, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int));
				return _ReleaseLongArrayElements;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int _ReleaseFloatArrayElements;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int ReleaseFloatArrayElements {
			get {
				if (_ReleaseFloatArrayElements == null)
					_ReleaseFloatArrayElements = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseFloatArrayElements, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int));
				return _ReleaseFloatArrayElements;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int _ReleaseDoubleArrayElements;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int ReleaseDoubleArrayElements {
			get {
				if (_ReleaseDoubleArrayElements == null)
					_ReleaseDoubleArrayElements = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseDoubleArrayElements, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int));
				return _ReleaseDoubleArrayElements;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _GetBooleanArrayRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr GetBooleanArrayRegion {
			get {
				if (_GetBooleanArrayRegion == null)
					_GetBooleanArrayRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetBooleanArrayRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _GetBooleanArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _GetByteArrayRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr GetByteArrayRegion {
			get {
				if (_GetByteArrayRegion == null)
					_GetByteArrayRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetByteArrayRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _GetByteArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _GetCharArrayRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr GetCharArrayRegion {
			get {
				if (_GetCharArrayRegion == null)
					_GetCharArrayRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetCharArrayRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _GetCharArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _GetShortArrayRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr GetShortArrayRegion {
			get {
				if (_GetShortArrayRegion == null)
					_GetShortArrayRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetShortArrayRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _GetShortArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _GetIntArrayRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr GetIntArrayRegion {
			get {
				if (_GetIntArrayRegion == null)
					_GetIntArrayRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetIntArrayRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _GetIntArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _GetLongArrayRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr GetLongArrayRegion {
			get {
				if (_GetLongArrayRegion == null)
					_GetLongArrayRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetLongArrayRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _GetLongArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _GetFloatArrayRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr GetFloatArrayRegion {
			get {
				if (_GetFloatArrayRegion == null)
					_GetFloatArrayRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetFloatArrayRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _GetFloatArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _GetDoubleArrayRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr GetDoubleArrayRegion {
			get {
				if (_GetDoubleArrayRegion == null)
					_GetDoubleArrayRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetDoubleArrayRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _GetDoubleArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _SetBooleanArrayRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr SetBooleanArrayRegion {
			get {
				if (_SetBooleanArrayRegion == null)
					_SetBooleanArrayRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetBooleanArrayRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _SetBooleanArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _SetByteArrayRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr SetByteArrayRegion {
			get {
				if (_SetByteArrayRegion == null)
					_SetByteArrayRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetByteArrayRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _SetByteArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _SetCharArrayRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr SetCharArrayRegion {
			get {
				if (_SetCharArrayRegion == null)
					_SetCharArrayRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetCharArrayRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _SetCharArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _SetShortArrayRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr SetShortArrayRegion {
			get {
				if (_SetShortArrayRegion == null)
					_SetShortArrayRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetShortArrayRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _SetShortArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _SetIntArrayRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr SetIntArrayRegion {
			get {
				if (_SetIntArrayRegion == null)
					_SetIntArrayRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetIntArrayRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _SetIntArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _SetLongArrayRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr SetLongArrayRegion {
			get {
				if (_SetLongArrayRegion == null)
					_SetLongArrayRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetLongArrayRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _SetLongArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _SetFloatArrayRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr SetFloatArrayRegion {
			get {
				if (_SetFloatArrayRegion == null)
					_SetFloatArrayRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetFloatArrayRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _SetFloatArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _SetDoubleArrayRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr SetDoubleArrayRegion {
			get {
				if (_SetDoubleArrayRegion == null)
					_SetDoubleArrayRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetDoubleArrayRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _SetDoubleArrayRegion;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniNativeMethodRegistrationArray_int_int _RegisterNatives;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniNativeMethodRegistrationArray_int_int RegisterNatives {
			get {
				if (_RegisterNatives == null)
					_RegisterNatives = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniNativeMethodRegistrationArray_int_int) Marshal.GetDelegateForFunctionPointer (env.RegisterNatives, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniNativeMethodRegistrationArray_int_int));
				return _RegisterNatives;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int _UnregisterNatives;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int UnregisterNatives {
			get {
				if (_UnregisterNatives == null)
					_UnregisterNatives = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int) Marshal.GetDelegateForFunctionPointer (env.UnregisterNatives, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int));
				return _UnregisterNatives;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int _MonitorEnter;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int MonitorEnter {
			get {
				if (_MonitorEnter == null)
					_MonitorEnter = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int) Marshal.GetDelegateForFunctionPointer (env.MonitorEnter, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int));
				return _MonitorEnter;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int _MonitorExit;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int MonitorExit {
			get {
				if (_MonitorExit == null)
					_MonitorExit = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int) Marshal.GetDelegateForFunctionPointer (env.MonitorExit, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_int));
				return _MonitorExit;
			}
		}

		JniFunc_JNIEnvPtr_outIntPtr_int _GetJavaVM;
		public JniFunc_JNIEnvPtr_outIntPtr_int GetJavaVM {
			get {
				if (_GetJavaVM == null)
					_GetJavaVM = (JniFunc_JNIEnvPtr_outIntPtr_int) Marshal.GetDelegateForFunctionPointer (env.GetJavaVM, typeof (JniFunc_JNIEnvPtr_outIntPtr_int));
				return _GetJavaVM;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _GetStringRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr GetStringRegion {
			get {
				if (_GetStringRegion == null)
					_GetStringRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetStringRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _GetStringRegion;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr _GetStringUTFRegion;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr GetStringUTFRegion {
			get {
				if (_GetStringUTFRegion == null)
					_GetStringUTFRegion = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetStringUTFRegion, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_int_int_IntPtr));
				return _GetStringUTFRegion;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr _GetPrimitiveArrayCritical;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr GetPrimitiveArrayCritical {
			get {
				if (_GetPrimitiveArrayCritical == null)
					_GetPrimitiveArrayCritical = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetPrimitiveArrayCritical, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_IntPtr));
				return _GetPrimitiveArrayCritical;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int _ReleasePrimitiveArrayCritical;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int ReleasePrimitiveArrayCritical {
			get {
				if (_ReleasePrimitiveArrayCritical == null)
					_ReleasePrimitiveArrayCritical = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleasePrimitiveArrayCritical, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_int));
				return _ReleasePrimitiveArrayCritical;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_string _GetStringCritical;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_string GetStringCritical {
			get {
				if (_GetStringCritical == null)
					_GetStringCritical = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_string) Marshal.GetDelegateForFunctionPointer (env.GetStringCritical, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr_string));
				return _GetStringCritical;
			}
		}

		JniAction_JNIEnvPtr_JniReferenceSafeHandle_string _ReleaseStringCritical;
		public JniAction_JNIEnvPtr_JniReferenceSafeHandle_string ReleaseStringCritical {
			get {
				if (_ReleaseStringCritical == null)
					_ReleaseStringCritical = (JniAction_JNIEnvPtr_JniReferenceSafeHandle_string) Marshal.GetDelegateForFunctionPointer (env.ReleaseStringCritical, typeof (JniAction_JNIEnvPtr_JniReferenceSafeHandle_string));
				return _ReleaseStringCritical;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniWeakGlobalReference _NewWeakGlobalRef;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniWeakGlobalReference NewWeakGlobalRef {
			get {
				if (_NewWeakGlobalRef == null)
					_NewWeakGlobalRef = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniWeakGlobalReference) Marshal.GetDelegateForFunctionPointer (env.NewWeakGlobalRef, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniWeakGlobalReference));
				return _NewWeakGlobalRef;
			}
		}

		JniAction_JNIEnvPtr_IntPtr _DeleteWeakGlobalRef;
		public JniAction_JNIEnvPtr_IntPtr DeleteWeakGlobalRef {
			get {
				if (_DeleteWeakGlobalRef == null)
					_DeleteWeakGlobalRef = (JniAction_JNIEnvPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.DeleteWeakGlobalRef, typeof (JniAction_JNIEnvPtr_IntPtr));
				return _DeleteWeakGlobalRef;
			}
		}

		JniFunc_JNIEnvPtr_byte _ExceptionCheck;
		public JniFunc_JNIEnvPtr_byte ExceptionCheck {
			get {
				if (_ExceptionCheck == null)
					_ExceptionCheck = (JniFunc_JNIEnvPtr_byte) Marshal.GetDelegateForFunctionPointer (env.ExceptionCheck, typeof (JniFunc_JNIEnvPtr_byte));
				return _ExceptionCheck;
			}
		}

		JniFunc_JNIEnvPtr_IntPtr_long_JniLocalReference _NewDirectByteBuffer;
		public JniFunc_JNIEnvPtr_IntPtr_long_JniLocalReference NewDirectByteBuffer {
			get {
				if (_NewDirectByteBuffer == null)
					_NewDirectByteBuffer = (JniFunc_JNIEnvPtr_IntPtr_long_JniLocalReference) Marshal.GetDelegateForFunctionPointer (env.NewDirectByteBuffer, typeof (JniFunc_JNIEnvPtr_IntPtr_long_JniLocalReference));
				return _NewDirectByteBuffer;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr _GetDirectBufferAddress;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr GetDirectBufferAddress {
			get {
				if (_GetDirectBufferAddress == null)
					_GetDirectBufferAddress = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetDirectBufferAddress, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_IntPtr));
				return _GetDirectBufferAddress;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_long _GetDirectBufferCapacity;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_long GetDirectBufferCapacity {
			get {
				if (_GetDirectBufferCapacity == null)
					_GetDirectBufferCapacity = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_long) Marshal.GetDelegateForFunctionPointer (env.GetDirectBufferCapacity, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_long));
				return _GetDirectBufferCapacity;
			}
		}

		JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniObjectReferenceType _GetObjectRefType;
		public JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniObjectReferenceType GetObjectRefType {
			get {
				if (_GetObjectRefType == null)
					_GetObjectRefType = (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniObjectReferenceType) Marshal.GetDelegateForFunctionPointer (env.GetObjectRefType, typeof (JniFunc_JNIEnvPtr_JniReferenceSafeHandle_JniObjectReferenceType));
				return _GetObjectRefType;
			}
		}
	}
}
#endif  // FEATURE_JNIENVIRONMENT_SAFEHANDLES
#if FEATURE_JNIENVIRONMENT_JI_INTPTRS
namespace
#if _NAMESPACE_PER_HANDLE
	Java.Interop.JIIntPtrs
#else
	Java.Interop
#endif
{

	unsafe delegate int JniFunc_JNIEnvPtr_int (JNIEnvPtr env);
	unsafe delegate jobject JniFunc_JNIEnvPtr_string_jobject_IntPtr_int_jobject (JNIEnvPtr env, string name, jobject loader, IntPtr buffer, int bufferLength);
	unsafe delegate jobject JniFunc_JNIEnvPtr_string_jobject (JNIEnvPtr env, string classname);
	unsafe delegate IntPtr JniFunc_JNIEnvPtr_jobject_IntPtr (JNIEnvPtr env, jobject method);
	unsafe delegate jobject JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject (JNIEnvPtr env, jobject type, IntPtr method, byte isStatic);
	unsafe delegate jobject JniFunc_JNIEnvPtr_jobject_jobject (JNIEnvPtr env, jobject type);
	unsafe delegate byte JniFunc_JNIEnvPtr_jobject_jobject_byte (JNIEnvPtr env, jobject class1, jobject class2);
	unsafe delegate int JniFunc_JNIEnvPtr_jobject_int (JNIEnvPtr env, jobject toThrow);
	unsafe delegate int JniFunc_JNIEnvPtr_jobject_string_int (JNIEnvPtr env, jobject type, string message);
	unsafe delegate jobject JniFunc_JNIEnvPtr_jobject (JNIEnvPtr env);
	unsafe delegate void JniAction_JNIEnvPtr (JNIEnvPtr env);
	unsafe delegate void JniAction_JNIEnvPtr_string (JNIEnvPtr env, string message);
	unsafe delegate int JniFunc_JNIEnvPtr_int_int (JNIEnvPtr env, int capacity);
	unsafe delegate void JniAction_JNIEnvPtr_IntPtr (JNIEnvPtr env, IntPtr instance);
	unsafe delegate jobject JniFunc_JNIEnvPtr_jobject_IntPtr_jobject (JNIEnvPtr env, jobject type, IntPtr method);
	unsafe delegate jobject JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject (JNIEnvPtr env, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate IntPtr JniFunc_JNIEnvPtr_jobject_string_string_IntPtr (JNIEnvPtr env, jobject type, string name, string signature);
	unsafe delegate byte JniFunc_JNIEnvPtr_jobject_IntPtr_byte (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate byte JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate sbyte JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate sbyte JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate char JniFunc_JNIEnvPtr_jobject_IntPtr_char (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate char JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate short JniFunc_JNIEnvPtr_jobject_IntPtr_short (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate short JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate int JniFunc_JNIEnvPtr_jobject_IntPtr_int (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate int JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate long JniFunc_JNIEnvPtr_jobject_IntPtr_long (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate long JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate float JniFunc_JNIEnvPtr_jobject_IntPtr_float (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate float JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate double JniFunc_JNIEnvPtr_jobject_IntPtr_double (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate double JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate jobject JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_jobject (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate jobject JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_jobject (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate byte JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_byte (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate byte JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_byte (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate sbyte JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_sbyte (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate sbyte JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_sbyte (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate char JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_char (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate char JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_char (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate short JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_short (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate short JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_short (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate int JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_int (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate int JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_int (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate long JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_long (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate long JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_long (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate float JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_float (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate float JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_float (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate double JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_double (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate double JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_double (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_jobject_IntPtr (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_jobject (JNIEnvPtr env, jobject instance, IntPtr field, jobject value);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_byte (JNIEnvPtr env, jobject instance, IntPtr field, byte value);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_sbyte (JNIEnvPtr env, jobject instance, IntPtr field, sbyte value);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_char (JNIEnvPtr env, jobject instance, IntPtr field, char value);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_short (JNIEnvPtr env, jobject instance, IntPtr field, short value);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_int (JNIEnvPtr env, jobject instance, IntPtr field, int value);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_long (JNIEnvPtr env, jobject instance, IntPtr field, long value);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_float (JNIEnvPtr env, jobject instance, IntPtr field, float value);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_double (JNIEnvPtr env, jobject instance, IntPtr field, double value);
	[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl, CharSet=CharSet.Unicode)]
	unsafe delegate jobject JniFunc_JNIEnvPtr_IntPtr_int_jobject (JNIEnvPtr env, IntPtr unicodeChars, int length);
	unsafe delegate IntPtr JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr (JNIEnvPtr env, jobject stringInstance, IntPtr isCopy);
	unsafe delegate string JniFunc_JNIEnvPtr_jobject_IntPtr_string (JNIEnvPtr env, jobject stringInstance, IntPtr isCopy);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_string (JNIEnvPtr env, jobject stringInstance, string utf);
	unsafe delegate jobject JniFunc_JNIEnvPtr_int_jobject_jobject_jobject (JNIEnvPtr env, int length, jobject elementClass, jobject initialElement);
	unsafe delegate jobject JniFunc_JNIEnvPtr_jobject_int_jobject (JNIEnvPtr env, jobject array, int index);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_int_jobject (JNIEnvPtr env, jobject array, int index, jobject value);
	unsafe delegate jobject JniFunc_JNIEnvPtr_int_jobject (JNIEnvPtr env, int length);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_int_int_IntPtr (JNIEnvPtr env, jobject array, int start, int length, IntPtr buffer);
	unsafe delegate int JniFunc_JNIEnvPtr_jobject_JniNativeMethodRegistrationArray_int_int (JNIEnvPtr env, jobject type, JniNativeMethodRegistration [] methods, int numMethods);
	unsafe delegate int JniFunc_JNIEnvPtr_outIntPtr_int (JNIEnvPtr env, out IntPtr vm);
	unsafe delegate byte JniFunc_JNIEnvPtr_byte (JNIEnvPtr env);
	unsafe delegate jobject JniFunc_JNIEnvPtr_IntPtr_long_jobject (JNIEnvPtr env, IntPtr address, long capacity);
	unsafe delegate long JniFunc_JNIEnvPtr_jobject_long (JNIEnvPtr env, jobject buffer);
	unsafe delegate JniObjectReferenceType JniFunc_JNIEnvPtr_jobject_JniObjectReferenceType (JNIEnvPtr env, jobject instance);

	partial class JniEnvironment {

	public static partial class Arrays {

		public static unsafe int GetArrayLength (JniObjectReference array)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetArrayLength (__info.EnvironmentPointer, array.Handle);
			return tmp;
		}

		public static unsafe JniObjectReference NewObjectArray (int length, JniObjectReference elementClass, JniObjectReference initialElement)
		{
			if (elementClass.Handle == IntPtr.Zero)
				throw new ArgumentException ("`elementClass` must not be IntPtr.Zero.", "elementClass");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewObjectArray (__info.EnvironmentPointer, length, elementClass.Handle, initialElement.Handle);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference GetObjectArrayElement (JniObjectReference array, int index)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetObjectArrayElement (__info.EnvironmentPointer, array.Handle, index);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe void SetObjectArrayElement (JniObjectReference array, int index, JniObjectReference value)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetObjectArrayElement (__info.EnvironmentPointer, array.Handle, index, value.Handle);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe JniObjectReference NewBooleanArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewBooleanArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewByteArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewByteArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewCharArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewCharArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewShortArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewShortArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewIntArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewIntArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewLongArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewLongArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewFloatArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewFloatArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewDoubleArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewDoubleArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe IntPtr GetBooleanArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetBooleanArrayElements (__info.EnvironmentPointer, array.Handle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetByteArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetByteArrayElements (__info.EnvironmentPointer, array.Handle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetCharArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetCharArrayElements (__info.EnvironmentPointer, array.Handle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetShortArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetShortArrayElements (__info.EnvironmentPointer, array.Handle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetIntArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetIntArrayElements (__info.EnvironmentPointer, array.Handle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetLongArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetLongArrayElements (__info.EnvironmentPointer, array.Handle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetFloatArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetFloatArrayElements (__info.EnvironmentPointer, array.Handle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetDoubleArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetDoubleArrayElements (__info.EnvironmentPointer, array.Handle, isCopy);
			return tmp;
		}

		public static unsafe void ReleaseBooleanArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseBooleanArrayElements (__info.EnvironmentPointer, array.Handle, elements, mode);
		}

		public static unsafe void ReleaseByteArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseByteArrayElements (__info.EnvironmentPointer, array.Handle, elements, mode);
		}

		public static unsafe void ReleaseCharArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseCharArrayElements (__info.EnvironmentPointer, array.Handle, elements, mode);
		}

		public static unsafe void ReleaseShortArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseShortArrayElements (__info.EnvironmentPointer, array.Handle, elements, mode);
		}

		public static unsafe void ReleaseIntArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseIntArrayElements (__info.EnvironmentPointer, array.Handle, elements, mode);
		}

		public static unsafe void ReleaseLongArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseLongArrayElements (__info.EnvironmentPointer, array.Handle, elements, mode);
		}

		public static unsafe void ReleaseFloatArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseFloatArrayElements (__info.EnvironmentPointer, array.Handle, elements, mode);
		}

		public static unsafe void ReleaseDoubleArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseDoubleArrayElements (__info.EnvironmentPointer, array.Handle, elements, mode);
		}

		public static unsafe void GetBooleanArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetBooleanArrayRegion (__info.EnvironmentPointer, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetByteArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetByteArrayRegion (__info.EnvironmentPointer, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetCharArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetCharArrayRegion (__info.EnvironmentPointer, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetShortArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetShortArrayRegion (__info.EnvironmentPointer, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetIntArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetIntArrayRegion (__info.EnvironmentPointer, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetLongArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetLongArrayRegion (__info.EnvironmentPointer, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetFloatArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetFloatArrayRegion (__info.EnvironmentPointer, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetDoubleArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetDoubleArrayRegion (__info.EnvironmentPointer, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetBooleanArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetBooleanArrayRegion (__info.EnvironmentPointer, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetByteArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetByteArrayRegion (__info.EnvironmentPointer, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetCharArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetCharArrayRegion (__info.EnvironmentPointer, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetShortArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetShortArrayRegion (__info.EnvironmentPointer, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetIntArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetIntArrayRegion (__info.EnvironmentPointer, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetLongArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetLongArrayRegion (__info.EnvironmentPointer, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetFloatArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetFloatArrayRegion (__info.EnvironmentPointer, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetDoubleArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetDoubleArrayRegion (__info.EnvironmentPointer, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}
	}

	public static partial class Exceptions {

		internal static unsafe int _Throw (JniObjectReference toThrow)
		{
			if (toThrow.Handle == IntPtr.Zero)
				throw new ArgumentException ("`toThrow` must not be IntPtr.Zero.", "toThrow");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.Throw (__info.EnvironmentPointer, toThrow.Handle);
			return tmp;
		}

		internal static unsafe int _ThrowNew (JniObjectReference type, string message)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (message == null)
				throw new ArgumentNullException ("message");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.ThrowNew (__info.EnvironmentPointer, type.Handle, message);
			return tmp;
		}

		public static unsafe JniObjectReference ExceptionOccurred ()
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.ExceptionOccurred (__info.EnvironmentPointer);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe void ExceptionDescribe ()
		{
			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ExceptionDescribe (__info.EnvironmentPointer);
		}

		public static unsafe void ExceptionClear ()
		{
			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ExceptionClear (__info.EnvironmentPointer);
		}

		public static unsafe void FatalError (string message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.FatalError (__info.EnvironmentPointer, message);
		}

		public static unsafe bool ExceptionCheck ()
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.ExceptionCheck (__info.EnvironmentPointer);
			return (tmp != 0) ? true : false;
		}
	}

	public static partial class InstanceFields {

		public static unsafe JniInstanceFieldInfo GetFieldID (JniObjectReference type, string name, string signature)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (signature == null)
				throw new ArgumentNullException ("signature");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetFieldID (__info.EnvironmentPointer, type.Handle, name, signature);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			if (tmp == IntPtr.Zero)
				return null;
			return new JniInstanceFieldInfo (tmp);
		}

		public static unsafe JniObjectReference GetObjectField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetObjectField (__info.EnvironmentPointer, instance.Handle, field.ID);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool GetBooleanField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetBooleanField (__info.EnvironmentPointer, instance.Handle, field.ID);
			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte GetByteField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetByteField (__info.EnvironmentPointer, instance.Handle, field.ID);
			return tmp;
		}

		public static unsafe char GetCharField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetCharField (__info.EnvironmentPointer, instance.Handle, field.ID);
			return tmp;
		}

		public static unsafe short GetShortField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetShortField (__info.EnvironmentPointer, instance.Handle, field.ID);
			return tmp;
		}

		public static unsafe int GetIntField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetIntField (__info.EnvironmentPointer, instance.Handle, field.ID);
			return tmp;
		}

		public static unsafe long GetLongField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetLongField (__info.EnvironmentPointer, instance.Handle, field.ID);
			return tmp;
		}

		public static unsafe float GetFloatField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetFloatField (__info.EnvironmentPointer, instance.Handle, field.ID);
			return tmp;
		}

		public static unsafe double GetDoubleField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetDoubleField (__info.EnvironmentPointer, instance.Handle, field.ID);
			return tmp;
		}

		public static unsafe void SetObjectField (JniObjectReference instance, JniInstanceFieldInfo field, JniObjectReference value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetObjectField (__info.EnvironmentPointer, instance.Handle, field.ID, value.Handle);
		}

		public static unsafe void SetBooleanField (JniObjectReference instance, JniInstanceFieldInfo field, bool value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetBooleanField (__info.EnvironmentPointer, instance.Handle, field.ID, (value ? (byte) 1 : (byte) 0));
		}

		public static unsafe void SetByteField (JniObjectReference instance, JniInstanceFieldInfo field, sbyte value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetByteField (__info.EnvironmentPointer, instance.Handle, field.ID, value);
		}

		public static unsafe void SetCharField (JniObjectReference instance, JniInstanceFieldInfo field, char value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetCharField (__info.EnvironmentPointer, instance.Handle, field.ID, value);
		}

		public static unsafe void SetShortField (JniObjectReference instance, JniInstanceFieldInfo field, short value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetShortField (__info.EnvironmentPointer, instance.Handle, field.ID, value);
		}

		public static unsafe void SetIntField (JniObjectReference instance, JniInstanceFieldInfo field, int value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetIntField (__info.EnvironmentPointer, instance.Handle, field.ID, value);
		}

		public static unsafe void SetLongField (JniObjectReference instance, JniInstanceFieldInfo field, long value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetLongField (__info.EnvironmentPointer, instance.Handle, field.ID, value);
		}

		public static unsafe void SetFloatField (JniObjectReference instance, JniInstanceFieldInfo field, float value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetFloatField (__info.EnvironmentPointer, instance.Handle, field.ID, value);
		}

		public static unsafe void SetDoubleField (JniObjectReference instance, JniInstanceFieldInfo field, double value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetDoubleField (__info.EnvironmentPointer, instance.Handle, field.ID, value);
		}
	}

	public static partial class InstanceMethods {

		public static unsafe JniInstanceMethodInfo GetMethodID (JniObjectReference type, string name, string signature)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (signature == null)
				throw new ArgumentNullException ("signature");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetMethodID (__info.EnvironmentPointer, type.Handle, name, signature);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			if (tmp == IntPtr.Zero)
				return null;
			return new JniInstanceMethodInfo (tmp);
		}

		public static unsafe JniObjectReference CallObjectMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallObjectMethod (__info.EnvironmentPointer, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference CallObjectMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallObjectMethodA (__info.EnvironmentPointer, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool CallBooleanMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallBooleanMethod (__info.EnvironmentPointer, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe bool CallBooleanMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallBooleanMethodA (__info.EnvironmentPointer, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte CallByteMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallByteMethod (__info.EnvironmentPointer, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe sbyte CallByteMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallByteMethodA (__info.EnvironmentPointer, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallCharMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallCharMethod (__info.EnvironmentPointer, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallCharMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallCharMethodA (__info.EnvironmentPointer, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallShortMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallShortMethod (__info.EnvironmentPointer, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallShortMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallShortMethodA (__info.EnvironmentPointer, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallIntMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallIntMethod (__info.EnvironmentPointer, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallIntMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallIntMethodA (__info.EnvironmentPointer, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallLongMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallLongMethod (__info.EnvironmentPointer, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallLongMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallLongMethodA (__info.EnvironmentPointer, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallFloatMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallFloatMethod (__info.EnvironmentPointer, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallFloatMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallFloatMethodA (__info.EnvironmentPointer, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallDoubleMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallDoubleMethod (__info.EnvironmentPointer, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallDoubleMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallDoubleMethodA (__info.EnvironmentPointer, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe void CallVoidMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallVoidMethod (__info.EnvironmentPointer, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void CallVoidMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallVoidMethodA (__info.EnvironmentPointer, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe JniObjectReference CallNonvirtualObjectMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualObjectMethod (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference CallNonvirtualObjectMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualObjectMethodA (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool CallNonvirtualBooleanMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualBooleanMethod (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe bool CallNonvirtualBooleanMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualBooleanMethodA (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte CallNonvirtualByteMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualByteMethod (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe sbyte CallNonvirtualByteMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualByteMethodA (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallNonvirtualCharMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualCharMethod (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallNonvirtualCharMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualCharMethodA (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallNonvirtualShortMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualShortMethod (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallNonvirtualShortMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualShortMethodA (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallNonvirtualIntMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualIntMethod (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallNonvirtualIntMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualIntMethodA (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallNonvirtualLongMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualLongMethod (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallNonvirtualLongMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualLongMethodA (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallNonvirtualFloatMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualFloatMethod (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallNonvirtualFloatMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualFloatMethodA (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallNonvirtualDoubleMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualDoubleMethod (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallNonvirtualDoubleMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualDoubleMethodA (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe void CallNonvirtualVoidMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallNonvirtualVoidMethod (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void CallNonvirtualVoidMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallNonvirtualVoidMethodA (__info.EnvironmentPointer, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}
	}

	public static partial class IO {

		public static unsafe JniObjectReference NewDirectByteBuffer (IntPtr address, long capacity)
		{
			if (address == IntPtr.Zero)
				throw new ArgumentException ("'address' must not be IntPtr.Zero.", "address");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewDirectByteBuffer (__info.EnvironmentPointer, address, capacity);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe IntPtr GetDirectBufferAddress (JniObjectReference buffer)
		{
			if (buffer.Handle == IntPtr.Zero)
				throw new ArgumentException ("`buffer` must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetDirectBufferAddress (__info.EnvironmentPointer, buffer.Handle);
			return tmp;
		}

		public static unsafe long GetDirectBufferCapacity (JniObjectReference buffer)
		{
			if (buffer.Handle == IntPtr.Zero)
				throw new ArgumentException ("`buffer` must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetDirectBufferCapacity (__info.EnvironmentPointer, buffer.Handle);
			return tmp;
		}
	}

	public static partial class Monitors {

		internal static unsafe int _MonitorEnter (JniObjectReference instance)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.MonitorEnter (__info.EnvironmentPointer, instance.Handle);
			return tmp;
		}

		internal static unsafe int _MonitorExit (JniObjectReference instance)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.MonitorExit (__info.EnvironmentPointer, instance.Handle);
			return tmp;
		}
	}

	public static partial class Object {

		public static unsafe JniObjectReference AllocObject (JniObjectReference type)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.AllocObject (__info.EnvironmentPointer, type.Handle);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewObject (JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewObject (__info.EnvironmentPointer, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewObject (JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewObjectA (__info.EnvironmentPointer, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}
	}

	public static partial class References {

		internal static unsafe int _PushLocalFrame (int capacity)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.PushLocalFrame (__info.EnvironmentPointer, capacity);
			return tmp;
		}

		public static unsafe JniObjectReference PopLocalFrame (JniObjectReference result)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.PopLocalFrame (__info.EnvironmentPointer, result.Handle);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		internal static unsafe JniObjectReference NewGlobalRef (JniObjectReference instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewGlobalRef (__info.EnvironmentPointer, instance.Handle);
			return new JniObjectReference (tmp, JniObjectReferenceType.Global);
		}

		internal static unsafe void DeleteGlobalRef (IntPtr instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.DeleteGlobalRef (__info.EnvironmentPointer, instance);
		}

		internal static unsafe void DeleteLocalRef (IntPtr instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.DeleteLocalRef (__info.EnvironmentPointer, instance);
		}

		internal static unsafe JniObjectReference NewLocalRef (JniObjectReference instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewLocalRef (__info.EnvironmentPointer, instance.Handle);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		internal static unsafe int _EnsureLocalCapacity (int capacity)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.EnsureLocalCapacity (__info.EnvironmentPointer, capacity);
			return tmp;
		}

		internal static unsafe int _GetJavaVM (out IntPtr vm)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetJavaVM (__info.EnvironmentPointer, out vm);
			return tmp;
		}

		internal static unsafe JniObjectReference NewWeakGlobalRef (JniObjectReference instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewWeakGlobalRef (__info.EnvironmentPointer, instance.Handle);
			return new JniObjectReference (tmp, JniObjectReferenceType.WeakGlobal);
		}

		internal static unsafe void DeleteWeakGlobalRef (IntPtr instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.DeleteWeakGlobalRef (__info.EnvironmentPointer, instance);
		}

		internal static unsafe JniObjectReferenceType GetObjectRefType (JniObjectReference instance)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetObjectRefType (__info.EnvironmentPointer, instance.Handle);
			return tmp;
		}
	}

	internal static partial class Reflection {

		public static unsafe JniObjectReference ToReflectedMethod (JniObjectReference type, JniInstanceMethodInfo method, bool isStatic)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.ToReflectedMethod (__info.EnvironmentPointer, type.Handle, method.ID, (isStatic ? (byte) 1 : (byte) 0));

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference ToReflectedField (JniObjectReference type, JniInstanceFieldInfo field, bool isStatic)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.ToReflectedField (__info.EnvironmentPointer, type.Handle, field.ID, (isStatic ? (byte) 1 : (byte) 0));

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}
	}

	public static partial class StaticFields {

		public static unsafe JniStaticFieldInfo GetStaticFieldID (JniObjectReference type, string name, string signature)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (signature == null)
				throw new ArgumentNullException ("signature");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticFieldID (__info.EnvironmentPointer, type.Handle, name, signature);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			if (tmp == IntPtr.Zero)
				return null;
			return new JniStaticFieldInfo (tmp);
		}

		public static unsafe JniObjectReference GetStaticObjectField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticObjectField (__info.EnvironmentPointer, type.Handle, field.ID);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool GetStaticBooleanField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticBooleanField (__info.EnvironmentPointer, type.Handle, field.ID);
			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte GetStaticByteField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticByteField (__info.EnvironmentPointer, type.Handle, field.ID);
			return tmp;
		}

		public static unsafe char GetStaticCharField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticCharField (__info.EnvironmentPointer, type.Handle, field.ID);
			return tmp;
		}

		public static unsafe short GetStaticShortField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticShortField (__info.EnvironmentPointer, type.Handle, field.ID);
			return tmp;
		}

		public static unsafe int GetStaticIntField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticIntField (__info.EnvironmentPointer, type.Handle, field.ID);
			return tmp;
		}

		public static unsafe long GetStaticLongField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticLongField (__info.EnvironmentPointer, type.Handle, field.ID);
			return tmp;
		}

		public static unsafe float GetStaticFloatField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticFloatField (__info.EnvironmentPointer, type.Handle, field.ID);
			return tmp;
		}

		public static unsafe double GetStaticDoubleField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticDoubleField (__info.EnvironmentPointer, type.Handle, field.ID);
			return tmp;
		}

		public static unsafe void SetStaticObjectField (JniObjectReference type, JniStaticFieldInfo field, JniObjectReference value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticObjectField (__info.EnvironmentPointer, type.Handle, field.ID, value.Handle);
		}

		public static unsafe void SetStaticBooleanField (JniObjectReference type, JniStaticFieldInfo field, bool value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticBooleanField (__info.EnvironmentPointer, type.Handle, field.ID, (value ? (byte) 1 : (byte) 0));
		}

		public static unsafe void SetStaticByteField (JniObjectReference type, JniStaticFieldInfo field, sbyte value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticByteField (__info.EnvironmentPointer, type.Handle, field.ID, value);
		}

		public static unsafe void SetStaticCharField (JniObjectReference type, JniStaticFieldInfo field, char value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticCharField (__info.EnvironmentPointer, type.Handle, field.ID, value);
		}

		public static unsafe void SetStaticShortField (JniObjectReference type, JniStaticFieldInfo field, short value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticShortField (__info.EnvironmentPointer, type.Handle, field.ID, value);
		}

		public static unsafe void SetStaticIntField (JniObjectReference type, JniStaticFieldInfo field, int value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticIntField (__info.EnvironmentPointer, type.Handle, field.ID, value);
		}

		public static unsafe void SetStaticLongField (JniObjectReference type, JniStaticFieldInfo field, long value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticLongField (__info.EnvironmentPointer, type.Handle, field.ID, value);
		}

		public static unsafe void SetStaticFloatField (JniObjectReference type, JniStaticFieldInfo field, float value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticFloatField (__info.EnvironmentPointer, type.Handle, field.ID, value);
		}

		public static unsafe void SetStaticDoubleField (JniObjectReference type, JniStaticFieldInfo field, double value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticDoubleField (__info.EnvironmentPointer, type.Handle, field.ID, value);
		}
	}

	public static partial class StaticMethods {

		public static unsafe JniStaticMethodInfo GetStaticMethodID (JniObjectReference type, string name, string signature)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (signature == null)
				throw new ArgumentNullException ("signature");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticMethodID (__info.EnvironmentPointer, type.Handle, name, signature);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			if (tmp == IntPtr.Zero)
				return null;
			return new JniStaticMethodInfo (tmp);
		}

		public static unsafe JniObjectReference CallStaticObjectMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticObjectMethod (__info.EnvironmentPointer, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference CallStaticObjectMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticObjectMethodA (__info.EnvironmentPointer, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool CallStaticBooleanMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticBooleanMethod (__info.EnvironmentPointer, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe bool CallStaticBooleanMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticBooleanMethodA (__info.EnvironmentPointer, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte CallStaticByteMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticByteMethod (__info.EnvironmentPointer, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe sbyte CallStaticByteMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticByteMethodA (__info.EnvironmentPointer, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallStaticCharMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticCharMethod (__info.EnvironmentPointer, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallStaticCharMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticCharMethodA (__info.EnvironmentPointer, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallStaticShortMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticShortMethod (__info.EnvironmentPointer, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallStaticShortMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticShortMethodA (__info.EnvironmentPointer, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallStaticIntMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticIntMethod (__info.EnvironmentPointer, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallStaticIntMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticIntMethodA (__info.EnvironmentPointer, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallStaticLongMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticLongMethod (__info.EnvironmentPointer, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallStaticLongMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticLongMethodA (__info.EnvironmentPointer, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallStaticFloatMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticFloatMethod (__info.EnvironmentPointer, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallStaticFloatMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticFloatMethodA (__info.EnvironmentPointer, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallStaticDoubleMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticDoubleMethod (__info.EnvironmentPointer, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallStaticDoubleMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticDoubleMethodA (__info.EnvironmentPointer, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe void CallStaticVoidMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallStaticVoidMethod (__info.EnvironmentPointer, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void CallStaticVoidMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallStaticVoidMethodA (__info.EnvironmentPointer, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}
	}

	public static partial class Strings {

		public static unsafe JniObjectReference NewString (IntPtr unicodeChars, int length)
		{
			if (unicodeChars == IntPtr.Zero)
				throw new ArgumentException ("'unicodeChars' must not be IntPtr.Zero.", "unicodeChars");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewString (__info.EnvironmentPointer, unicodeChars, length);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe int GetStringLength (JniObjectReference stringInstance)
		{
			if (stringInstance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`stringInstance` must not be IntPtr.Zero.", "stringInstance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStringLength (__info.EnvironmentPointer, stringInstance.Handle);
			return tmp;
		}

		public static unsafe IntPtr GetStringChars (JniObjectReference stringInstance, IntPtr isCopy)
		{
			if (stringInstance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`stringInstance` must not be IntPtr.Zero.", "stringInstance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStringChars (__info.EnvironmentPointer, stringInstance.Handle, isCopy);
			return tmp;
		}

		public static unsafe void ReleaseStringChars (JniObjectReference stringInstance, IntPtr chars)
		{
			if (stringInstance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`stringInstance` must not be IntPtr.Zero.", "stringInstance");
			if (chars == IntPtr.Zero)
				throw new ArgumentException ("'chars' must not be IntPtr.Zero.", "chars");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseStringChars (__info.EnvironmentPointer, stringInstance.Handle, chars);
		}
	}

	public static partial class Types {

		public static unsafe JniObjectReference DefineClass (string name, JniObjectReference loader, IntPtr buffer, int bufferLength)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (loader.Handle == IntPtr.Zero)
				throw new ArgumentException ("`loader` must not be IntPtr.Zero.", "loader");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.DefineClass (__info.EnvironmentPointer, name, loader.Handle, buffer, bufferLength);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		internal static unsafe JniObjectReference _FindClass (string classname)
		{
			if (classname == null)
				throw new ArgumentNullException ("classname");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.FindClass (__info.EnvironmentPointer, classname);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference GetSuperclass (JniObjectReference type)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetSuperclass (__info.EnvironmentPointer, type.Handle);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool IsAssignableFrom (JniObjectReference class1, JniObjectReference class2)
		{
			if (class1.Handle == IntPtr.Zero)
				throw new ArgumentException ("`class1` must not be IntPtr.Zero.", "class1");
			if (class2.Handle == IntPtr.Zero)
				throw new ArgumentException ("`class2` must not be IntPtr.Zero.", "class2");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.IsAssignableFrom (__info.EnvironmentPointer, class1.Handle, class2.Handle);
			return (tmp != 0) ? true : false;
		}

		public static unsafe bool IsSameObject (JniObjectReference object1, JniObjectReference object2)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.IsSameObject (__info.EnvironmentPointer, object1.Handle, object2.Handle);
			return (tmp != 0) ? true : false;
		}

		public static unsafe JniObjectReference GetObjectClass (JniObjectReference instance)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetObjectClass (__info.EnvironmentPointer, instance.Handle);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool IsInstanceOf (JniObjectReference instance, JniObjectReference type)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.IsInstanceOf (__info.EnvironmentPointer, instance.Handle, type.Handle);
			return (tmp != 0) ? true : false;
		}

		internal static unsafe int _RegisterNatives (JniObjectReference type, JniNativeMethodRegistration [] methods, int numMethods)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.RegisterNatives (__info.EnvironmentPointer, type.Handle, methods, numMethods);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		internal static unsafe int _UnregisterNatives (JniObjectReference type)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.UnregisterNatives (__info.EnvironmentPointer, type.Handle);
			return tmp;
		}
	}

	internal static partial class Versions {

		internal static unsafe int GetVersion ()
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetVersion (__info.EnvironmentPointer);
			return tmp;
		}
	}
	}

	partial class JniEnvironmentInvoker {

		internal JniNativeInterfaceStruct env;

		public unsafe JniEnvironmentInvoker (JniNativeInterfaceStruct* p)
		{
			env = *p;
		}


		JniFunc_JNIEnvPtr_int _GetVersion;
		public JniFunc_JNIEnvPtr_int GetVersion {
			get {
				if (_GetVersion == null)
					_GetVersion = (JniFunc_JNIEnvPtr_int) Marshal.GetDelegateForFunctionPointer (env.GetVersion, typeof (JniFunc_JNIEnvPtr_int));
				return _GetVersion;
			}
		}

		JniFunc_JNIEnvPtr_string_jobject_IntPtr_int_jobject _DefineClass;
		public JniFunc_JNIEnvPtr_string_jobject_IntPtr_int_jobject DefineClass {
			get {
				if (_DefineClass == null)
					_DefineClass = (JniFunc_JNIEnvPtr_string_jobject_IntPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.DefineClass, typeof (JniFunc_JNIEnvPtr_string_jobject_IntPtr_int_jobject));
				return _DefineClass;
			}
		}

		JniFunc_JNIEnvPtr_string_jobject _FindClass;
		public JniFunc_JNIEnvPtr_string_jobject FindClass {
			get {
				if (_FindClass == null)
					_FindClass = (JniFunc_JNIEnvPtr_string_jobject) Marshal.GetDelegateForFunctionPointer (env.FindClass, typeof (JniFunc_JNIEnvPtr_string_jobject));
				return _FindClass;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr _FromReflectedMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr FromReflectedMethod {
			get {
				if (_FromReflectedMethod == null)
					_FromReflectedMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr) Marshal.GetDelegateForFunctionPointer (env.FromReflectedMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr));
				return _FromReflectedMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr _FromReflectedField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr FromReflectedField {
			get {
				if (_FromReflectedField == null)
					_FromReflectedField = (JniFunc_JNIEnvPtr_jobject_IntPtr) Marshal.GetDelegateForFunctionPointer (env.FromReflectedField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr));
				return _FromReflectedField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject _ToReflectedMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject ToReflectedMethod {
			get {
				if (_ToReflectedMethod == null)
					_ToReflectedMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject) Marshal.GetDelegateForFunctionPointer (env.ToReflectedMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject));
				return _ToReflectedMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject _GetSuperclass;
		public JniFunc_JNIEnvPtr_jobject_jobject GetSuperclass {
			get {
				if (_GetSuperclass == null)
					_GetSuperclass = (JniFunc_JNIEnvPtr_jobject_jobject) Marshal.GetDelegateForFunctionPointer (env.GetSuperclass, typeof (JniFunc_JNIEnvPtr_jobject_jobject));
				return _GetSuperclass;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_byte _IsAssignableFrom;
		public JniFunc_JNIEnvPtr_jobject_jobject_byte IsAssignableFrom {
			get {
				if (_IsAssignableFrom == null)
					_IsAssignableFrom = (JniFunc_JNIEnvPtr_jobject_jobject_byte) Marshal.GetDelegateForFunctionPointer (env.IsAssignableFrom, typeof (JniFunc_JNIEnvPtr_jobject_jobject_byte));
				return _IsAssignableFrom;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject _ToReflectedField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject ToReflectedField {
			get {
				if (_ToReflectedField == null)
					_ToReflectedField = (JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject) Marshal.GetDelegateForFunctionPointer (env.ToReflectedField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject));
				return _ToReflectedField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_int _Throw;
		public JniFunc_JNIEnvPtr_jobject_int Throw {
			get {
				if (_Throw == null)
					_Throw = (JniFunc_JNIEnvPtr_jobject_int) Marshal.GetDelegateForFunctionPointer (env.Throw, typeof (JniFunc_JNIEnvPtr_jobject_int));
				return _Throw;
			}
		}

		JniFunc_JNIEnvPtr_jobject_string_int _ThrowNew;
		public JniFunc_JNIEnvPtr_jobject_string_int ThrowNew {
			get {
				if (_ThrowNew == null)
					_ThrowNew = (JniFunc_JNIEnvPtr_jobject_string_int) Marshal.GetDelegateForFunctionPointer (env.ThrowNew, typeof (JniFunc_JNIEnvPtr_jobject_string_int));
				return _ThrowNew;
			}
		}

		JniFunc_JNIEnvPtr_jobject _ExceptionOccurred;
		public JniFunc_JNIEnvPtr_jobject ExceptionOccurred {
			get {
				if (_ExceptionOccurred == null)
					_ExceptionOccurred = (JniFunc_JNIEnvPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.ExceptionOccurred, typeof (JniFunc_JNIEnvPtr_jobject));
				return _ExceptionOccurred;
			}
		}

		JniAction_JNIEnvPtr _ExceptionDescribe;
		public JniAction_JNIEnvPtr ExceptionDescribe {
			get {
				if (_ExceptionDescribe == null)
					_ExceptionDescribe = (JniAction_JNIEnvPtr) Marshal.GetDelegateForFunctionPointer (env.ExceptionDescribe, typeof (JniAction_JNIEnvPtr));
				return _ExceptionDescribe;
			}
		}

		JniAction_JNIEnvPtr _ExceptionClear;
		public JniAction_JNIEnvPtr ExceptionClear {
			get {
				if (_ExceptionClear == null)
					_ExceptionClear = (JniAction_JNIEnvPtr) Marshal.GetDelegateForFunctionPointer (env.ExceptionClear, typeof (JniAction_JNIEnvPtr));
				return _ExceptionClear;
			}
		}

		JniAction_JNIEnvPtr_string _FatalError;
		public JniAction_JNIEnvPtr_string FatalError {
			get {
				if (_FatalError == null)
					_FatalError = (JniAction_JNIEnvPtr_string) Marshal.GetDelegateForFunctionPointer (env.FatalError, typeof (JniAction_JNIEnvPtr_string));
				return _FatalError;
			}
		}

		JniFunc_JNIEnvPtr_int_int _PushLocalFrame;
		public JniFunc_JNIEnvPtr_int_int PushLocalFrame {
			get {
				if (_PushLocalFrame == null)
					_PushLocalFrame = (JniFunc_JNIEnvPtr_int_int) Marshal.GetDelegateForFunctionPointer (env.PushLocalFrame, typeof (JniFunc_JNIEnvPtr_int_int));
				return _PushLocalFrame;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject _PopLocalFrame;
		public JniFunc_JNIEnvPtr_jobject_jobject PopLocalFrame {
			get {
				if (_PopLocalFrame == null)
					_PopLocalFrame = (JniFunc_JNIEnvPtr_jobject_jobject) Marshal.GetDelegateForFunctionPointer (env.PopLocalFrame, typeof (JniFunc_JNIEnvPtr_jobject_jobject));
				return _PopLocalFrame;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject _NewGlobalRef;
		public JniFunc_JNIEnvPtr_jobject_jobject NewGlobalRef {
			get {
				if (_NewGlobalRef == null)
					_NewGlobalRef = (JniFunc_JNIEnvPtr_jobject_jobject) Marshal.GetDelegateForFunctionPointer (env.NewGlobalRef, typeof (JniFunc_JNIEnvPtr_jobject_jobject));
				return _NewGlobalRef;
			}
		}

		JniAction_JNIEnvPtr_IntPtr _DeleteGlobalRef;
		public JniAction_JNIEnvPtr_IntPtr DeleteGlobalRef {
			get {
				if (_DeleteGlobalRef == null)
					_DeleteGlobalRef = (JniAction_JNIEnvPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.DeleteGlobalRef, typeof (JniAction_JNIEnvPtr_IntPtr));
				return _DeleteGlobalRef;
			}
		}

		JniAction_JNIEnvPtr_IntPtr _DeleteLocalRef;
		public JniAction_JNIEnvPtr_IntPtr DeleteLocalRef {
			get {
				if (_DeleteLocalRef == null)
					_DeleteLocalRef = (JniAction_JNIEnvPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.DeleteLocalRef, typeof (JniAction_JNIEnvPtr_IntPtr));
				return _DeleteLocalRef;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_byte _IsSameObject;
		public JniFunc_JNIEnvPtr_jobject_jobject_byte IsSameObject {
			get {
				if (_IsSameObject == null)
					_IsSameObject = (JniFunc_JNIEnvPtr_jobject_jobject_byte) Marshal.GetDelegateForFunctionPointer (env.IsSameObject, typeof (JniFunc_JNIEnvPtr_jobject_jobject_byte));
				return _IsSameObject;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject _NewLocalRef;
		public JniFunc_JNIEnvPtr_jobject_jobject NewLocalRef {
			get {
				if (_NewLocalRef == null)
					_NewLocalRef = (JniFunc_JNIEnvPtr_jobject_jobject) Marshal.GetDelegateForFunctionPointer (env.NewLocalRef, typeof (JniFunc_JNIEnvPtr_jobject_jobject));
				return _NewLocalRef;
			}
		}

		JniFunc_JNIEnvPtr_int_int _EnsureLocalCapacity;
		public JniFunc_JNIEnvPtr_int_int EnsureLocalCapacity {
			get {
				if (_EnsureLocalCapacity == null)
					_EnsureLocalCapacity = (JniFunc_JNIEnvPtr_int_int) Marshal.GetDelegateForFunctionPointer (env.EnsureLocalCapacity, typeof (JniFunc_JNIEnvPtr_int_int));
				return _EnsureLocalCapacity;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject _AllocObject;
		public JniFunc_JNIEnvPtr_jobject_jobject AllocObject {
			get {
				if (_AllocObject == null)
					_AllocObject = (JniFunc_JNIEnvPtr_jobject_jobject) Marshal.GetDelegateForFunctionPointer (env.AllocObject, typeof (JniFunc_JNIEnvPtr_jobject_jobject));
				return _AllocObject;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_jobject _NewObject;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_jobject NewObject {
			get {
				if (_NewObject == null)
					_NewObject = (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.NewObject, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject));
				return _NewObject;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject _NewObjectA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject NewObjectA {
			get {
				if (_NewObjectA == null)
					_NewObjectA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject) Marshal.GetDelegateForFunctionPointer (env.NewObjectA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject));
				return _NewObjectA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject _GetObjectClass;
		public JniFunc_JNIEnvPtr_jobject_jobject GetObjectClass {
			get {
				if (_GetObjectClass == null)
					_GetObjectClass = (JniFunc_JNIEnvPtr_jobject_jobject) Marshal.GetDelegateForFunctionPointer (env.GetObjectClass, typeof (JniFunc_JNIEnvPtr_jobject_jobject));
				return _GetObjectClass;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_byte _IsInstanceOf;
		public JniFunc_JNIEnvPtr_jobject_jobject_byte IsInstanceOf {
			get {
				if (_IsInstanceOf == null)
					_IsInstanceOf = (JniFunc_JNIEnvPtr_jobject_jobject_byte) Marshal.GetDelegateForFunctionPointer (env.IsInstanceOf, typeof (JniFunc_JNIEnvPtr_jobject_jobject_byte));
				return _IsInstanceOf;
			}
		}

		JniFunc_JNIEnvPtr_jobject_string_string_IntPtr _GetMethodID;
		public JniFunc_JNIEnvPtr_jobject_string_string_IntPtr GetMethodID {
			get {
				if (_GetMethodID == null)
					_GetMethodID = (JniFunc_JNIEnvPtr_jobject_string_string_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetMethodID, typeof (JniFunc_JNIEnvPtr_jobject_string_string_IntPtr));
				return _GetMethodID;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_jobject _CallObjectMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_jobject CallObjectMethod {
			get {
				if (_CallObjectMethod == null)
					_CallObjectMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.CallObjectMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject));
				return _CallObjectMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject _CallObjectMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject CallObjectMethodA {
			get {
				if (_CallObjectMethodA == null)
					_CallObjectMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject) Marshal.GetDelegateForFunctionPointer (env.CallObjectMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject));
				return _CallObjectMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_byte _CallBooleanMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_byte CallBooleanMethod {
			get {
				if (_CallBooleanMethod == null)
					_CallBooleanMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.CallBooleanMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_byte));
				return _CallBooleanMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte _CallBooleanMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte CallBooleanMethodA {
			get {
				if (_CallBooleanMethodA == null)
					_CallBooleanMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte) Marshal.GetDelegateForFunctionPointer (env.CallBooleanMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte));
				return _CallBooleanMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte _CallByteMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte CallByteMethod {
			get {
				if (_CallByteMethod == null)
					_CallByteMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallByteMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte));
				return _CallByteMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte _CallByteMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte CallByteMethodA {
			get {
				if (_CallByteMethodA == null)
					_CallByteMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallByteMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte));
				return _CallByteMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_char _CallCharMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_char CallCharMethod {
			get {
				if (_CallCharMethod == null)
					_CallCharMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.CallCharMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_char));
				return _CallCharMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char _CallCharMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char CallCharMethodA {
			get {
				if (_CallCharMethodA == null)
					_CallCharMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char) Marshal.GetDelegateForFunctionPointer (env.CallCharMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char));
				return _CallCharMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_short _CallShortMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_short CallShortMethod {
			get {
				if (_CallShortMethod == null)
					_CallShortMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.CallShortMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_short));
				return _CallShortMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short _CallShortMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short CallShortMethodA {
			get {
				if (_CallShortMethodA == null)
					_CallShortMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short) Marshal.GetDelegateForFunctionPointer (env.CallShortMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short));
				return _CallShortMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_int _CallIntMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_int CallIntMethod {
			get {
				if (_CallIntMethod == null)
					_CallIntMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.CallIntMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_int));
				return _CallIntMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int _CallIntMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int CallIntMethodA {
			get {
				if (_CallIntMethodA == null)
					_CallIntMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int) Marshal.GetDelegateForFunctionPointer (env.CallIntMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int));
				return _CallIntMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_long _CallLongMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_long CallLongMethod {
			get {
				if (_CallLongMethod == null)
					_CallLongMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.CallLongMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_long));
				return _CallLongMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long _CallLongMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long CallLongMethodA {
			get {
				if (_CallLongMethodA == null)
					_CallLongMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long) Marshal.GetDelegateForFunctionPointer (env.CallLongMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long));
				return _CallLongMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_float _CallFloatMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_float CallFloatMethod {
			get {
				if (_CallFloatMethod == null)
					_CallFloatMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.CallFloatMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_float));
				return _CallFloatMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float _CallFloatMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float CallFloatMethodA {
			get {
				if (_CallFloatMethodA == null)
					_CallFloatMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float) Marshal.GetDelegateForFunctionPointer (env.CallFloatMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float));
				return _CallFloatMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_double _CallDoubleMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_double CallDoubleMethod {
			get {
				if (_CallDoubleMethod == null)
					_CallDoubleMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.CallDoubleMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_double));
				return _CallDoubleMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double _CallDoubleMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double CallDoubleMethodA {
			get {
				if (_CallDoubleMethodA == null)
					_CallDoubleMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double) Marshal.GetDelegateForFunctionPointer (env.CallDoubleMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double));
				return _CallDoubleMethodA;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr _CallVoidMethod;
		public JniAction_JNIEnvPtr_jobject_IntPtr CallVoidMethod {
			get {
				if (_CallVoidMethod == null)
					_CallVoidMethod = (JniAction_JNIEnvPtr_jobject_IntPtr) Marshal.GetDelegateForFunctionPointer (env.CallVoidMethod, typeof (JniAction_JNIEnvPtr_jobject_IntPtr));
				return _CallVoidMethod;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef _CallVoidMethodA;
		public JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef CallVoidMethodA {
			get {
				if (_CallVoidMethodA == null)
					_CallVoidMethodA = (JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef) Marshal.GetDelegateForFunctionPointer (env.CallVoidMethodA, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef));
				return _CallVoidMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_jobject _CallNonvirtualObjectMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_jobject CallNonvirtualObjectMethod {
			get {
				if (_CallNonvirtualObjectMethod == null)
					_CallNonvirtualObjectMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualObjectMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_jobject));
				return _CallNonvirtualObjectMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_jobject _CallNonvirtualObjectMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_jobject CallNonvirtualObjectMethodA {
			get {
				if (_CallNonvirtualObjectMethodA == null)
					_CallNonvirtualObjectMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_jobject) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualObjectMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_jobject));
				return _CallNonvirtualObjectMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_byte _CallNonvirtualBooleanMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_byte CallNonvirtualBooleanMethod {
			get {
				if (_CallNonvirtualBooleanMethod == null)
					_CallNonvirtualBooleanMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualBooleanMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_byte));
				return _CallNonvirtualBooleanMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_byte _CallNonvirtualBooleanMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_byte CallNonvirtualBooleanMethodA {
			get {
				if (_CallNonvirtualBooleanMethodA == null)
					_CallNonvirtualBooleanMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_byte) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualBooleanMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_byte));
				return _CallNonvirtualBooleanMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_sbyte _CallNonvirtualByteMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_sbyte CallNonvirtualByteMethod {
			get {
				if (_CallNonvirtualByteMethod == null)
					_CallNonvirtualByteMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualByteMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_sbyte));
				return _CallNonvirtualByteMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_sbyte _CallNonvirtualByteMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_sbyte CallNonvirtualByteMethodA {
			get {
				if (_CallNonvirtualByteMethodA == null)
					_CallNonvirtualByteMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualByteMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_sbyte));
				return _CallNonvirtualByteMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_char _CallNonvirtualCharMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_char CallNonvirtualCharMethod {
			get {
				if (_CallNonvirtualCharMethod == null)
					_CallNonvirtualCharMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualCharMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_char));
				return _CallNonvirtualCharMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_char _CallNonvirtualCharMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_char CallNonvirtualCharMethodA {
			get {
				if (_CallNonvirtualCharMethodA == null)
					_CallNonvirtualCharMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_char) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualCharMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_char));
				return _CallNonvirtualCharMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_short _CallNonvirtualShortMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_short CallNonvirtualShortMethod {
			get {
				if (_CallNonvirtualShortMethod == null)
					_CallNonvirtualShortMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualShortMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_short));
				return _CallNonvirtualShortMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_short _CallNonvirtualShortMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_short CallNonvirtualShortMethodA {
			get {
				if (_CallNonvirtualShortMethodA == null)
					_CallNonvirtualShortMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_short) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualShortMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_short));
				return _CallNonvirtualShortMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_int _CallNonvirtualIntMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_int CallNonvirtualIntMethod {
			get {
				if (_CallNonvirtualIntMethod == null)
					_CallNonvirtualIntMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualIntMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_int));
				return _CallNonvirtualIntMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_int _CallNonvirtualIntMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_int CallNonvirtualIntMethodA {
			get {
				if (_CallNonvirtualIntMethodA == null)
					_CallNonvirtualIntMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_int) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualIntMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_int));
				return _CallNonvirtualIntMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_long _CallNonvirtualLongMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_long CallNonvirtualLongMethod {
			get {
				if (_CallNonvirtualLongMethod == null)
					_CallNonvirtualLongMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualLongMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_long));
				return _CallNonvirtualLongMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_long _CallNonvirtualLongMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_long CallNonvirtualLongMethodA {
			get {
				if (_CallNonvirtualLongMethodA == null)
					_CallNonvirtualLongMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_long) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualLongMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_long));
				return _CallNonvirtualLongMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_float _CallNonvirtualFloatMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_float CallNonvirtualFloatMethod {
			get {
				if (_CallNonvirtualFloatMethod == null)
					_CallNonvirtualFloatMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualFloatMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_float));
				return _CallNonvirtualFloatMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_float _CallNonvirtualFloatMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_float CallNonvirtualFloatMethodA {
			get {
				if (_CallNonvirtualFloatMethodA == null)
					_CallNonvirtualFloatMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_float) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualFloatMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_float));
				return _CallNonvirtualFloatMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_double _CallNonvirtualDoubleMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_double CallNonvirtualDoubleMethod {
			get {
				if (_CallNonvirtualDoubleMethod == null)
					_CallNonvirtualDoubleMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualDoubleMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_double));
				return _CallNonvirtualDoubleMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_double _CallNonvirtualDoubleMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_double CallNonvirtualDoubleMethodA {
			get {
				if (_CallNonvirtualDoubleMethodA == null)
					_CallNonvirtualDoubleMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_double) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualDoubleMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_double));
				return _CallNonvirtualDoubleMethodA;
			}
		}

		JniAction_JNIEnvPtr_jobject_jobject_IntPtr _CallNonvirtualVoidMethod;
		public JniAction_JNIEnvPtr_jobject_jobject_IntPtr CallNonvirtualVoidMethod {
			get {
				if (_CallNonvirtualVoidMethod == null)
					_CallNonvirtualVoidMethod = (JniAction_JNIEnvPtr_jobject_jobject_IntPtr) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualVoidMethod, typeof (JniAction_JNIEnvPtr_jobject_jobject_IntPtr));
				return _CallNonvirtualVoidMethod;
			}
		}

		JniAction_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef _CallNonvirtualVoidMethodA;
		public JniAction_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef CallNonvirtualVoidMethodA {
			get {
				if (_CallNonvirtualVoidMethodA == null)
					_CallNonvirtualVoidMethodA = (JniAction_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualVoidMethodA, typeof (JniAction_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef));
				return _CallNonvirtualVoidMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_string_string_IntPtr _GetFieldID;
		public JniFunc_JNIEnvPtr_jobject_string_string_IntPtr GetFieldID {
			get {
				if (_GetFieldID == null)
					_GetFieldID = (JniFunc_JNIEnvPtr_jobject_string_string_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetFieldID, typeof (JniFunc_JNIEnvPtr_jobject_string_string_IntPtr));
				return _GetFieldID;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_jobject _GetObjectField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_jobject GetObjectField {
			get {
				if (_GetObjectField == null)
					_GetObjectField = (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.GetObjectField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject));
				return _GetObjectField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_byte _GetBooleanField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_byte GetBooleanField {
			get {
				if (_GetBooleanField == null)
					_GetBooleanField = (JniFunc_JNIEnvPtr_jobject_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.GetBooleanField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_byte));
				return _GetBooleanField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte _GetByteField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte GetByteField {
			get {
				if (_GetByteField == null)
					_GetByteField = (JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.GetByteField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte));
				return _GetByteField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_char _GetCharField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_char GetCharField {
			get {
				if (_GetCharField == null)
					_GetCharField = (JniFunc_JNIEnvPtr_jobject_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.GetCharField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_char));
				return _GetCharField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_short _GetShortField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_short GetShortField {
			get {
				if (_GetShortField == null)
					_GetShortField = (JniFunc_JNIEnvPtr_jobject_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.GetShortField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_short));
				return _GetShortField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_int _GetIntField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_int GetIntField {
			get {
				if (_GetIntField == null)
					_GetIntField = (JniFunc_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.GetIntField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_int));
				return _GetIntField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_long _GetLongField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_long GetLongField {
			get {
				if (_GetLongField == null)
					_GetLongField = (JniFunc_JNIEnvPtr_jobject_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.GetLongField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_long));
				return _GetLongField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_float _GetFloatField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_float GetFloatField {
			get {
				if (_GetFloatField == null)
					_GetFloatField = (JniFunc_JNIEnvPtr_jobject_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.GetFloatField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_float));
				return _GetFloatField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_double _GetDoubleField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_double GetDoubleField {
			get {
				if (_GetDoubleField == null)
					_GetDoubleField = (JniFunc_JNIEnvPtr_jobject_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.GetDoubleField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_double));
				return _GetDoubleField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_jobject _SetObjectField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_jobject SetObjectField {
			get {
				if (_SetObjectField == null)
					_SetObjectField = (JniAction_JNIEnvPtr_jobject_IntPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.SetObjectField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_jobject));
				return _SetObjectField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_byte _SetBooleanField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_byte SetBooleanField {
			get {
				if (_SetBooleanField == null)
					_SetBooleanField = (JniAction_JNIEnvPtr_jobject_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.SetBooleanField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_byte));
				return _SetBooleanField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_sbyte _SetByteField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_sbyte SetByteField {
			get {
				if (_SetByteField == null)
					_SetByteField = (JniAction_JNIEnvPtr_jobject_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.SetByteField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_sbyte));
				return _SetByteField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_char _SetCharField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_char SetCharField {
			get {
				if (_SetCharField == null)
					_SetCharField = (JniAction_JNIEnvPtr_jobject_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.SetCharField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_char));
				return _SetCharField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_short _SetShortField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_short SetShortField {
			get {
				if (_SetShortField == null)
					_SetShortField = (JniAction_JNIEnvPtr_jobject_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.SetShortField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_short));
				return _SetShortField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _SetIntField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int SetIntField {
			get {
				if (_SetIntField == null)
					_SetIntField = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.SetIntField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _SetIntField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_long _SetLongField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_long SetLongField {
			get {
				if (_SetLongField == null)
					_SetLongField = (JniAction_JNIEnvPtr_jobject_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.SetLongField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_long));
				return _SetLongField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_float _SetFloatField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_float SetFloatField {
			get {
				if (_SetFloatField == null)
					_SetFloatField = (JniAction_JNIEnvPtr_jobject_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.SetFloatField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_float));
				return _SetFloatField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_double _SetDoubleField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_double SetDoubleField {
			get {
				if (_SetDoubleField == null)
					_SetDoubleField = (JniAction_JNIEnvPtr_jobject_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.SetDoubleField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_double));
				return _SetDoubleField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_string_string_IntPtr _GetStaticMethodID;
		public JniFunc_JNIEnvPtr_jobject_string_string_IntPtr GetStaticMethodID {
			get {
				if (_GetStaticMethodID == null)
					_GetStaticMethodID = (JniFunc_JNIEnvPtr_jobject_string_string_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetStaticMethodID, typeof (JniFunc_JNIEnvPtr_jobject_string_string_IntPtr));
				return _GetStaticMethodID;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_jobject _CallStaticObjectMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_jobject CallStaticObjectMethod {
			get {
				if (_CallStaticObjectMethod == null)
					_CallStaticObjectMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.CallStaticObjectMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject));
				return _CallStaticObjectMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject _CallStaticObjectMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject CallStaticObjectMethodA {
			get {
				if (_CallStaticObjectMethodA == null)
					_CallStaticObjectMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject) Marshal.GetDelegateForFunctionPointer (env.CallStaticObjectMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject));
				return _CallStaticObjectMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_byte _CallStaticBooleanMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_byte CallStaticBooleanMethod {
			get {
				if (_CallStaticBooleanMethod == null)
					_CallStaticBooleanMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.CallStaticBooleanMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_byte));
				return _CallStaticBooleanMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte _CallStaticBooleanMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte CallStaticBooleanMethodA {
			get {
				if (_CallStaticBooleanMethodA == null)
					_CallStaticBooleanMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte) Marshal.GetDelegateForFunctionPointer (env.CallStaticBooleanMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte));
				return _CallStaticBooleanMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte _CallStaticByteMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte CallStaticByteMethod {
			get {
				if (_CallStaticByteMethod == null)
					_CallStaticByteMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallStaticByteMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte));
				return _CallStaticByteMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte _CallStaticByteMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte CallStaticByteMethodA {
			get {
				if (_CallStaticByteMethodA == null)
					_CallStaticByteMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallStaticByteMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte));
				return _CallStaticByteMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_char _CallStaticCharMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_char CallStaticCharMethod {
			get {
				if (_CallStaticCharMethod == null)
					_CallStaticCharMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.CallStaticCharMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_char));
				return _CallStaticCharMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char _CallStaticCharMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char CallStaticCharMethodA {
			get {
				if (_CallStaticCharMethodA == null)
					_CallStaticCharMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char) Marshal.GetDelegateForFunctionPointer (env.CallStaticCharMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char));
				return _CallStaticCharMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_short _CallStaticShortMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_short CallStaticShortMethod {
			get {
				if (_CallStaticShortMethod == null)
					_CallStaticShortMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.CallStaticShortMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_short));
				return _CallStaticShortMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short _CallStaticShortMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short CallStaticShortMethodA {
			get {
				if (_CallStaticShortMethodA == null)
					_CallStaticShortMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short) Marshal.GetDelegateForFunctionPointer (env.CallStaticShortMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short));
				return _CallStaticShortMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_int _CallStaticIntMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_int CallStaticIntMethod {
			get {
				if (_CallStaticIntMethod == null)
					_CallStaticIntMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.CallStaticIntMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_int));
				return _CallStaticIntMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int _CallStaticIntMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int CallStaticIntMethodA {
			get {
				if (_CallStaticIntMethodA == null)
					_CallStaticIntMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int) Marshal.GetDelegateForFunctionPointer (env.CallStaticIntMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int));
				return _CallStaticIntMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_long _CallStaticLongMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_long CallStaticLongMethod {
			get {
				if (_CallStaticLongMethod == null)
					_CallStaticLongMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.CallStaticLongMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_long));
				return _CallStaticLongMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long _CallStaticLongMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long CallStaticLongMethodA {
			get {
				if (_CallStaticLongMethodA == null)
					_CallStaticLongMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long) Marshal.GetDelegateForFunctionPointer (env.CallStaticLongMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long));
				return _CallStaticLongMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_float _CallStaticFloatMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_float CallStaticFloatMethod {
			get {
				if (_CallStaticFloatMethod == null)
					_CallStaticFloatMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.CallStaticFloatMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_float));
				return _CallStaticFloatMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float _CallStaticFloatMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float CallStaticFloatMethodA {
			get {
				if (_CallStaticFloatMethodA == null)
					_CallStaticFloatMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float) Marshal.GetDelegateForFunctionPointer (env.CallStaticFloatMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float));
				return _CallStaticFloatMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_double _CallStaticDoubleMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_double CallStaticDoubleMethod {
			get {
				if (_CallStaticDoubleMethod == null)
					_CallStaticDoubleMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.CallStaticDoubleMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_double));
				return _CallStaticDoubleMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double _CallStaticDoubleMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double CallStaticDoubleMethodA {
			get {
				if (_CallStaticDoubleMethodA == null)
					_CallStaticDoubleMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double) Marshal.GetDelegateForFunctionPointer (env.CallStaticDoubleMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double));
				return _CallStaticDoubleMethodA;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr _CallStaticVoidMethod;
		public JniAction_JNIEnvPtr_jobject_IntPtr CallStaticVoidMethod {
			get {
				if (_CallStaticVoidMethod == null)
					_CallStaticVoidMethod = (JniAction_JNIEnvPtr_jobject_IntPtr) Marshal.GetDelegateForFunctionPointer (env.CallStaticVoidMethod, typeof (JniAction_JNIEnvPtr_jobject_IntPtr));
				return _CallStaticVoidMethod;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef _CallStaticVoidMethodA;
		public JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef CallStaticVoidMethodA {
			get {
				if (_CallStaticVoidMethodA == null)
					_CallStaticVoidMethodA = (JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef) Marshal.GetDelegateForFunctionPointer (env.CallStaticVoidMethodA, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef));
				return _CallStaticVoidMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_string_string_IntPtr _GetStaticFieldID;
		public JniFunc_JNIEnvPtr_jobject_string_string_IntPtr GetStaticFieldID {
			get {
				if (_GetStaticFieldID == null)
					_GetStaticFieldID = (JniFunc_JNIEnvPtr_jobject_string_string_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetStaticFieldID, typeof (JniFunc_JNIEnvPtr_jobject_string_string_IntPtr));
				return _GetStaticFieldID;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_jobject _GetStaticObjectField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_jobject GetStaticObjectField {
			get {
				if (_GetStaticObjectField == null)
					_GetStaticObjectField = (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.GetStaticObjectField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject));
				return _GetStaticObjectField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_byte _GetStaticBooleanField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_byte GetStaticBooleanField {
			get {
				if (_GetStaticBooleanField == null)
					_GetStaticBooleanField = (JniFunc_JNIEnvPtr_jobject_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.GetStaticBooleanField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_byte));
				return _GetStaticBooleanField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte _GetStaticByteField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte GetStaticByteField {
			get {
				if (_GetStaticByteField == null)
					_GetStaticByteField = (JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.GetStaticByteField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte));
				return _GetStaticByteField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_char _GetStaticCharField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_char GetStaticCharField {
			get {
				if (_GetStaticCharField == null)
					_GetStaticCharField = (JniFunc_JNIEnvPtr_jobject_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.GetStaticCharField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_char));
				return _GetStaticCharField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_short _GetStaticShortField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_short GetStaticShortField {
			get {
				if (_GetStaticShortField == null)
					_GetStaticShortField = (JniFunc_JNIEnvPtr_jobject_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.GetStaticShortField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_short));
				return _GetStaticShortField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_int _GetStaticIntField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_int GetStaticIntField {
			get {
				if (_GetStaticIntField == null)
					_GetStaticIntField = (JniFunc_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.GetStaticIntField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_int));
				return _GetStaticIntField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_long _GetStaticLongField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_long GetStaticLongField {
			get {
				if (_GetStaticLongField == null)
					_GetStaticLongField = (JniFunc_JNIEnvPtr_jobject_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.GetStaticLongField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_long));
				return _GetStaticLongField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_float _GetStaticFloatField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_float GetStaticFloatField {
			get {
				if (_GetStaticFloatField == null)
					_GetStaticFloatField = (JniFunc_JNIEnvPtr_jobject_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.GetStaticFloatField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_float));
				return _GetStaticFloatField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_double _GetStaticDoubleField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_double GetStaticDoubleField {
			get {
				if (_GetStaticDoubleField == null)
					_GetStaticDoubleField = (JniFunc_JNIEnvPtr_jobject_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.GetStaticDoubleField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_double));
				return _GetStaticDoubleField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_jobject _SetStaticObjectField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_jobject SetStaticObjectField {
			get {
				if (_SetStaticObjectField == null)
					_SetStaticObjectField = (JniAction_JNIEnvPtr_jobject_IntPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.SetStaticObjectField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_jobject));
				return _SetStaticObjectField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_byte _SetStaticBooleanField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_byte SetStaticBooleanField {
			get {
				if (_SetStaticBooleanField == null)
					_SetStaticBooleanField = (JniAction_JNIEnvPtr_jobject_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.SetStaticBooleanField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_byte));
				return _SetStaticBooleanField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_sbyte _SetStaticByteField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_sbyte SetStaticByteField {
			get {
				if (_SetStaticByteField == null)
					_SetStaticByteField = (JniAction_JNIEnvPtr_jobject_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.SetStaticByteField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_sbyte));
				return _SetStaticByteField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_char _SetStaticCharField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_char SetStaticCharField {
			get {
				if (_SetStaticCharField == null)
					_SetStaticCharField = (JniAction_JNIEnvPtr_jobject_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.SetStaticCharField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_char));
				return _SetStaticCharField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_short _SetStaticShortField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_short SetStaticShortField {
			get {
				if (_SetStaticShortField == null)
					_SetStaticShortField = (JniAction_JNIEnvPtr_jobject_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.SetStaticShortField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_short));
				return _SetStaticShortField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _SetStaticIntField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int SetStaticIntField {
			get {
				if (_SetStaticIntField == null)
					_SetStaticIntField = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.SetStaticIntField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _SetStaticIntField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_long _SetStaticLongField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_long SetStaticLongField {
			get {
				if (_SetStaticLongField == null)
					_SetStaticLongField = (JniAction_JNIEnvPtr_jobject_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.SetStaticLongField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_long));
				return _SetStaticLongField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_float _SetStaticFloatField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_float SetStaticFloatField {
			get {
				if (_SetStaticFloatField == null)
					_SetStaticFloatField = (JniAction_JNIEnvPtr_jobject_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.SetStaticFloatField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_float));
				return _SetStaticFloatField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_double _SetStaticDoubleField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_double SetStaticDoubleField {
			get {
				if (_SetStaticDoubleField == null)
					_SetStaticDoubleField = (JniAction_JNIEnvPtr_jobject_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.SetStaticDoubleField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_double));
				return _SetStaticDoubleField;
			}
		}

		JniFunc_JNIEnvPtr_IntPtr_int_jobject _NewString;
		public JniFunc_JNIEnvPtr_IntPtr_int_jobject NewString {
			get {
				if (_NewString == null)
					_NewString = (JniFunc_JNIEnvPtr_IntPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewString, typeof (JniFunc_JNIEnvPtr_IntPtr_int_jobject));
				return _NewString;
			}
		}

		JniFunc_JNIEnvPtr_jobject_int _GetStringLength;
		public JniFunc_JNIEnvPtr_jobject_int GetStringLength {
			get {
				if (_GetStringLength == null)
					_GetStringLength = (JniFunc_JNIEnvPtr_jobject_int) Marshal.GetDelegateForFunctionPointer (env.GetStringLength, typeof (JniFunc_JNIEnvPtr_jobject_int));
				return _GetStringLength;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetStringChars;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetStringChars {
			get {
				if (_GetStringChars == null)
					_GetStringChars = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetStringChars, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetStringChars;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr _ReleaseStringChars;
		public JniAction_JNIEnvPtr_jobject_IntPtr ReleaseStringChars {
			get {
				if (_ReleaseStringChars == null)
					_ReleaseStringChars = (JniAction_JNIEnvPtr_jobject_IntPtr) Marshal.GetDelegateForFunctionPointer (env.ReleaseStringChars, typeof (JniAction_JNIEnvPtr_jobject_IntPtr));
				return _ReleaseStringChars;
			}
		}

		JniFunc_JNIEnvPtr_string_jobject _NewStringUTF;
		public JniFunc_JNIEnvPtr_string_jobject NewStringUTF {
			get {
				if (_NewStringUTF == null)
					_NewStringUTF = (JniFunc_JNIEnvPtr_string_jobject) Marshal.GetDelegateForFunctionPointer (env.NewStringUTF, typeof (JniFunc_JNIEnvPtr_string_jobject));
				return _NewStringUTF;
			}
		}

		JniFunc_JNIEnvPtr_jobject_int _GetStringUTFLength;
		public JniFunc_JNIEnvPtr_jobject_int GetStringUTFLength {
			get {
				if (_GetStringUTFLength == null)
					_GetStringUTFLength = (JniFunc_JNIEnvPtr_jobject_int) Marshal.GetDelegateForFunctionPointer (env.GetStringUTFLength, typeof (JniFunc_JNIEnvPtr_jobject_int));
				return _GetStringUTFLength;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_string _GetStringUTFChars;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_string GetStringUTFChars {
			get {
				if (_GetStringUTFChars == null)
					_GetStringUTFChars = (JniFunc_JNIEnvPtr_jobject_IntPtr_string) Marshal.GetDelegateForFunctionPointer (env.GetStringUTFChars, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_string));
				return _GetStringUTFChars;
			}
		}

		JniAction_JNIEnvPtr_jobject_string _ReleaseStringUTFChars;
		public JniAction_JNIEnvPtr_jobject_string ReleaseStringUTFChars {
			get {
				if (_ReleaseStringUTFChars == null)
					_ReleaseStringUTFChars = (JniAction_JNIEnvPtr_jobject_string) Marshal.GetDelegateForFunctionPointer (env.ReleaseStringUTFChars, typeof (JniAction_JNIEnvPtr_jobject_string));
				return _ReleaseStringUTFChars;
			}
		}

		JniFunc_JNIEnvPtr_jobject_int _GetArrayLength;
		public JniFunc_JNIEnvPtr_jobject_int GetArrayLength {
			get {
				if (_GetArrayLength == null)
					_GetArrayLength = (JniFunc_JNIEnvPtr_jobject_int) Marshal.GetDelegateForFunctionPointer (env.GetArrayLength, typeof (JniFunc_JNIEnvPtr_jobject_int));
				return _GetArrayLength;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject_jobject_jobject _NewObjectArray;
		public JniFunc_JNIEnvPtr_int_jobject_jobject_jobject NewObjectArray {
			get {
				if (_NewObjectArray == null)
					_NewObjectArray = (JniFunc_JNIEnvPtr_int_jobject_jobject_jobject) Marshal.GetDelegateForFunctionPointer (env.NewObjectArray, typeof (JniFunc_JNIEnvPtr_int_jobject_jobject_jobject));
				return _NewObjectArray;
			}
		}

		JniFunc_JNIEnvPtr_jobject_int_jobject _GetObjectArrayElement;
		public JniFunc_JNIEnvPtr_jobject_int_jobject GetObjectArrayElement {
			get {
				if (_GetObjectArrayElement == null)
					_GetObjectArrayElement = (JniFunc_JNIEnvPtr_jobject_int_jobject) Marshal.GetDelegateForFunctionPointer (env.GetObjectArrayElement, typeof (JniFunc_JNIEnvPtr_jobject_int_jobject));
				return _GetObjectArrayElement;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_jobject _SetObjectArrayElement;
		public JniAction_JNIEnvPtr_jobject_int_jobject SetObjectArrayElement {
			get {
				if (_SetObjectArrayElement == null)
					_SetObjectArrayElement = (JniAction_JNIEnvPtr_jobject_int_jobject) Marshal.GetDelegateForFunctionPointer (env.SetObjectArrayElement, typeof (JniAction_JNIEnvPtr_jobject_int_jobject));
				return _SetObjectArrayElement;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject _NewBooleanArray;
		public JniFunc_JNIEnvPtr_int_jobject NewBooleanArray {
			get {
				if (_NewBooleanArray == null)
					_NewBooleanArray = (JniFunc_JNIEnvPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewBooleanArray, typeof (JniFunc_JNIEnvPtr_int_jobject));
				return _NewBooleanArray;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject _NewByteArray;
		public JniFunc_JNIEnvPtr_int_jobject NewByteArray {
			get {
				if (_NewByteArray == null)
					_NewByteArray = (JniFunc_JNIEnvPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewByteArray, typeof (JniFunc_JNIEnvPtr_int_jobject));
				return _NewByteArray;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject _NewCharArray;
		public JniFunc_JNIEnvPtr_int_jobject NewCharArray {
			get {
				if (_NewCharArray == null)
					_NewCharArray = (JniFunc_JNIEnvPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewCharArray, typeof (JniFunc_JNIEnvPtr_int_jobject));
				return _NewCharArray;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject _NewShortArray;
		public JniFunc_JNIEnvPtr_int_jobject NewShortArray {
			get {
				if (_NewShortArray == null)
					_NewShortArray = (JniFunc_JNIEnvPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewShortArray, typeof (JniFunc_JNIEnvPtr_int_jobject));
				return _NewShortArray;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject _NewIntArray;
		public JniFunc_JNIEnvPtr_int_jobject NewIntArray {
			get {
				if (_NewIntArray == null)
					_NewIntArray = (JniFunc_JNIEnvPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewIntArray, typeof (JniFunc_JNIEnvPtr_int_jobject));
				return _NewIntArray;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject _NewLongArray;
		public JniFunc_JNIEnvPtr_int_jobject NewLongArray {
			get {
				if (_NewLongArray == null)
					_NewLongArray = (JniFunc_JNIEnvPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewLongArray, typeof (JniFunc_JNIEnvPtr_int_jobject));
				return _NewLongArray;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject _NewFloatArray;
		public JniFunc_JNIEnvPtr_int_jobject NewFloatArray {
			get {
				if (_NewFloatArray == null)
					_NewFloatArray = (JniFunc_JNIEnvPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewFloatArray, typeof (JniFunc_JNIEnvPtr_int_jobject));
				return _NewFloatArray;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject _NewDoubleArray;
		public JniFunc_JNIEnvPtr_int_jobject NewDoubleArray {
			get {
				if (_NewDoubleArray == null)
					_NewDoubleArray = (JniFunc_JNIEnvPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewDoubleArray, typeof (JniFunc_JNIEnvPtr_int_jobject));
				return _NewDoubleArray;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetBooleanArrayElements;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetBooleanArrayElements {
			get {
				if (_GetBooleanArrayElements == null)
					_GetBooleanArrayElements = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetBooleanArrayElements, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetBooleanArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetByteArrayElements;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetByteArrayElements {
			get {
				if (_GetByteArrayElements == null)
					_GetByteArrayElements = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetByteArrayElements, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetByteArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetCharArrayElements;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetCharArrayElements {
			get {
				if (_GetCharArrayElements == null)
					_GetCharArrayElements = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetCharArrayElements, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetCharArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetShortArrayElements;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetShortArrayElements {
			get {
				if (_GetShortArrayElements == null)
					_GetShortArrayElements = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetShortArrayElements, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetShortArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetIntArrayElements;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetIntArrayElements {
			get {
				if (_GetIntArrayElements == null)
					_GetIntArrayElements = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetIntArrayElements, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetIntArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetLongArrayElements;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetLongArrayElements {
			get {
				if (_GetLongArrayElements == null)
					_GetLongArrayElements = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetLongArrayElements, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetLongArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetFloatArrayElements;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetFloatArrayElements {
			get {
				if (_GetFloatArrayElements == null)
					_GetFloatArrayElements = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetFloatArrayElements, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetFloatArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetDoubleArrayElements;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetDoubleArrayElements {
			get {
				if (_GetDoubleArrayElements == null)
					_GetDoubleArrayElements = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetDoubleArrayElements, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetDoubleArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleaseBooleanArrayElements;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleaseBooleanArrayElements {
			get {
				if (_ReleaseBooleanArrayElements == null)
					_ReleaseBooleanArrayElements = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseBooleanArrayElements, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleaseBooleanArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleaseByteArrayElements;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleaseByteArrayElements {
			get {
				if (_ReleaseByteArrayElements == null)
					_ReleaseByteArrayElements = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseByteArrayElements, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleaseByteArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleaseCharArrayElements;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleaseCharArrayElements {
			get {
				if (_ReleaseCharArrayElements == null)
					_ReleaseCharArrayElements = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseCharArrayElements, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleaseCharArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleaseShortArrayElements;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleaseShortArrayElements {
			get {
				if (_ReleaseShortArrayElements == null)
					_ReleaseShortArrayElements = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseShortArrayElements, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleaseShortArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleaseIntArrayElements;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleaseIntArrayElements {
			get {
				if (_ReleaseIntArrayElements == null)
					_ReleaseIntArrayElements = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseIntArrayElements, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleaseIntArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleaseLongArrayElements;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleaseLongArrayElements {
			get {
				if (_ReleaseLongArrayElements == null)
					_ReleaseLongArrayElements = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseLongArrayElements, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleaseLongArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleaseFloatArrayElements;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleaseFloatArrayElements {
			get {
				if (_ReleaseFloatArrayElements == null)
					_ReleaseFloatArrayElements = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseFloatArrayElements, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleaseFloatArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleaseDoubleArrayElements;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleaseDoubleArrayElements {
			get {
				if (_ReleaseDoubleArrayElements == null)
					_ReleaseDoubleArrayElements = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseDoubleArrayElements, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleaseDoubleArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetBooleanArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetBooleanArrayRegion {
			get {
				if (_GetBooleanArrayRegion == null)
					_GetBooleanArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetBooleanArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetBooleanArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetByteArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetByteArrayRegion {
			get {
				if (_GetByteArrayRegion == null)
					_GetByteArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetByteArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetByteArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetCharArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetCharArrayRegion {
			get {
				if (_GetCharArrayRegion == null)
					_GetCharArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetCharArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetCharArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetShortArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetShortArrayRegion {
			get {
				if (_GetShortArrayRegion == null)
					_GetShortArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetShortArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetShortArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetIntArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetIntArrayRegion {
			get {
				if (_GetIntArrayRegion == null)
					_GetIntArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetIntArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetIntArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetLongArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetLongArrayRegion {
			get {
				if (_GetLongArrayRegion == null)
					_GetLongArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetLongArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetLongArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetFloatArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetFloatArrayRegion {
			get {
				if (_GetFloatArrayRegion == null)
					_GetFloatArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetFloatArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetFloatArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetDoubleArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetDoubleArrayRegion {
			get {
				if (_GetDoubleArrayRegion == null)
					_GetDoubleArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetDoubleArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetDoubleArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _SetBooleanArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr SetBooleanArrayRegion {
			get {
				if (_SetBooleanArrayRegion == null)
					_SetBooleanArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetBooleanArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _SetBooleanArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _SetByteArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr SetByteArrayRegion {
			get {
				if (_SetByteArrayRegion == null)
					_SetByteArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetByteArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _SetByteArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _SetCharArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr SetCharArrayRegion {
			get {
				if (_SetCharArrayRegion == null)
					_SetCharArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetCharArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _SetCharArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _SetShortArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr SetShortArrayRegion {
			get {
				if (_SetShortArrayRegion == null)
					_SetShortArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetShortArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _SetShortArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _SetIntArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr SetIntArrayRegion {
			get {
				if (_SetIntArrayRegion == null)
					_SetIntArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetIntArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _SetIntArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _SetLongArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr SetLongArrayRegion {
			get {
				if (_SetLongArrayRegion == null)
					_SetLongArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetLongArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _SetLongArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _SetFloatArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr SetFloatArrayRegion {
			get {
				if (_SetFloatArrayRegion == null)
					_SetFloatArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetFloatArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _SetFloatArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _SetDoubleArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr SetDoubleArrayRegion {
			get {
				if (_SetDoubleArrayRegion == null)
					_SetDoubleArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetDoubleArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _SetDoubleArrayRegion;
			}
		}

		JniFunc_JNIEnvPtr_jobject_JniNativeMethodRegistrationArray_int_int _RegisterNatives;
		public JniFunc_JNIEnvPtr_jobject_JniNativeMethodRegistrationArray_int_int RegisterNatives {
			get {
				if (_RegisterNatives == null)
					_RegisterNatives = (JniFunc_JNIEnvPtr_jobject_JniNativeMethodRegistrationArray_int_int) Marshal.GetDelegateForFunctionPointer (env.RegisterNatives, typeof (JniFunc_JNIEnvPtr_jobject_JniNativeMethodRegistrationArray_int_int));
				return _RegisterNatives;
			}
		}

		JniFunc_JNIEnvPtr_jobject_int _UnregisterNatives;
		public JniFunc_JNIEnvPtr_jobject_int UnregisterNatives {
			get {
				if (_UnregisterNatives == null)
					_UnregisterNatives = (JniFunc_JNIEnvPtr_jobject_int) Marshal.GetDelegateForFunctionPointer (env.UnregisterNatives, typeof (JniFunc_JNIEnvPtr_jobject_int));
				return _UnregisterNatives;
			}
		}

		JniFunc_JNIEnvPtr_jobject_int _MonitorEnter;
		public JniFunc_JNIEnvPtr_jobject_int MonitorEnter {
			get {
				if (_MonitorEnter == null)
					_MonitorEnter = (JniFunc_JNIEnvPtr_jobject_int) Marshal.GetDelegateForFunctionPointer (env.MonitorEnter, typeof (JniFunc_JNIEnvPtr_jobject_int));
				return _MonitorEnter;
			}
		}

		JniFunc_JNIEnvPtr_jobject_int _MonitorExit;
		public JniFunc_JNIEnvPtr_jobject_int MonitorExit {
			get {
				if (_MonitorExit == null)
					_MonitorExit = (JniFunc_JNIEnvPtr_jobject_int) Marshal.GetDelegateForFunctionPointer (env.MonitorExit, typeof (JniFunc_JNIEnvPtr_jobject_int));
				return _MonitorExit;
			}
		}

		JniFunc_JNIEnvPtr_outIntPtr_int _GetJavaVM;
		public JniFunc_JNIEnvPtr_outIntPtr_int GetJavaVM {
			get {
				if (_GetJavaVM == null)
					_GetJavaVM = (JniFunc_JNIEnvPtr_outIntPtr_int) Marshal.GetDelegateForFunctionPointer (env.GetJavaVM, typeof (JniFunc_JNIEnvPtr_outIntPtr_int));
				return _GetJavaVM;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetStringRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetStringRegion {
			get {
				if (_GetStringRegion == null)
					_GetStringRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetStringRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetStringRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetStringUTFRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetStringUTFRegion {
			get {
				if (_GetStringUTFRegion == null)
					_GetStringUTFRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetStringUTFRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetStringUTFRegion;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetPrimitiveArrayCritical;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetPrimitiveArrayCritical {
			get {
				if (_GetPrimitiveArrayCritical == null)
					_GetPrimitiveArrayCritical = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetPrimitiveArrayCritical, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetPrimitiveArrayCritical;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleasePrimitiveArrayCritical;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleasePrimitiveArrayCritical {
			get {
				if (_ReleasePrimitiveArrayCritical == null)
					_ReleasePrimitiveArrayCritical = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleasePrimitiveArrayCritical, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleasePrimitiveArrayCritical;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_string _GetStringCritical;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_string GetStringCritical {
			get {
				if (_GetStringCritical == null)
					_GetStringCritical = (JniFunc_JNIEnvPtr_jobject_IntPtr_string) Marshal.GetDelegateForFunctionPointer (env.GetStringCritical, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_string));
				return _GetStringCritical;
			}
		}

		JniAction_JNIEnvPtr_jobject_string _ReleaseStringCritical;
		public JniAction_JNIEnvPtr_jobject_string ReleaseStringCritical {
			get {
				if (_ReleaseStringCritical == null)
					_ReleaseStringCritical = (JniAction_JNIEnvPtr_jobject_string) Marshal.GetDelegateForFunctionPointer (env.ReleaseStringCritical, typeof (JniAction_JNIEnvPtr_jobject_string));
				return _ReleaseStringCritical;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject _NewWeakGlobalRef;
		public JniFunc_JNIEnvPtr_jobject_jobject NewWeakGlobalRef {
			get {
				if (_NewWeakGlobalRef == null)
					_NewWeakGlobalRef = (JniFunc_JNIEnvPtr_jobject_jobject) Marshal.GetDelegateForFunctionPointer (env.NewWeakGlobalRef, typeof (JniFunc_JNIEnvPtr_jobject_jobject));
				return _NewWeakGlobalRef;
			}
		}

		JniAction_JNIEnvPtr_IntPtr _DeleteWeakGlobalRef;
		public JniAction_JNIEnvPtr_IntPtr DeleteWeakGlobalRef {
			get {
				if (_DeleteWeakGlobalRef == null)
					_DeleteWeakGlobalRef = (JniAction_JNIEnvPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.DeleteWeakGlobalRef, typeof (JniAction_JNIEnvPtr_IntPtr));
				return _DeleteWeakGlobalRef;
			}
		}

		JniFunc_JNIEnvPtr_byte _ExceptionCheck;
		public JniFunc_JNIEnvPtr_byte ExceptionCheck {
			get {
				if (_ExceptionCheck == null)
					_ExceptionCheck = (JniFunc_JNIEnvPtr_byte) Marshal.GetDelegateForFunctionPointer (env.ExceptionCheck, typeof (JniFunc_JNIEnvPtr_byte));
				return _ExceptionCheck;
			}
		}

		JniFunc_JNIEnvPtr_IntPtr_long_jobject _NewDirectByteBuffer;
		public JniFunc_JNIEnvPtr_IntPtr_long_jobject NewDirectByteBuffer {
			get {
				if (_NewDirectByteBuffer == null)
					_NewDirectByteBuffer = (JniFunc_JNIEnvPtr_IntPtr_long_jobject) Marshal.GetDelegateForFunctionPointer (env.NewDirectByteBuffer, typeof (JniFunc_JNIEnvPtr_IntPtr_long_jobject));
				return _NewDirectByteBuffer;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr _GetDirectBufferAddress;
		public JniFunc_JNIEnvPtr_jobject_IntPtr GetDirectBufferAddress {
			get {
				if (_GetDirectBufferAddress == null)
					_GetDirectBufferAddress = (JniFunc_JNIEnvPtr_jobject_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetDirectBufferAddress, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr));
				return _GetDirectBufferAddress;
			}
		}

		JniFunc_JNIEnvPtr_jobject_long _GetDirectBufferCapacity;
		public JniFunc_JNIEnvPtr_jobject_long GetDirectBufferCapacity {
			get {
				if (_GetDirectBufferCapacity == null)
					_GetDirectBufferCapacity = (JniFunc_JNIEnvPtr_jobject_long) Marshal.GetDelegateForFunctionPointer (env.GetDirectBufferCapacity, typeof (JniFunc_JNIEnvPtr_jobject_long));
				return _GetDirectBufferCapacity;
			}
		}

		JniFunc_JNIEnvPtr_jobject_JniObjectReferenceType _GetObjectRefType;
		public JniFunc_JNIEnvPtr_jobject_JniObjectReferenceType GetObjectRefType {
			get {
				if (_GetObjectRefType == null)
					_GetObjectRefType = (JniFunc_JNIEnvPtr_jobject_JniObjectReferenceType) Marshal.GetDelegateForFunctionPointer (env.GetObjectRefType, typeof (JniFunc_JNIEnvPtr_jobject_JniObjectReferenceType));
				return _GetObjectRefType;
			}
		}
	}
}
#endif  // FEATURE_JNIENVIRONMENT_JI_INTPTRS
#if FEATURE_JNIENVIRONMENT_JI_PINVOKES
namespace
#if _NAMESPACE_PER_HANDLE
	Java.Interop.JIPinvokes
#else
	Java.Interop
#endif
{

	static class NativeMethods {

		const string JavaInteropLib = "JavaInterop";

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_GetVersion (IntPtr jnienv);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_DefineClass (IntPtr jnienv, out IntPtr thrown, string name, jobject loader, IntPtr buffer, int bufferLength);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_FindClass (IntPtr jnienv, out IntPtr thrown, string classname);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_ToReflectedMethod (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method, byte isStatic);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_GetSuperclass (IntPtr jnienv, jobject type);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe byte JavaInterop_IsAssignableFrom (IntPtr jnienv, jobject class1, jobject class2);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_ToReflectedField (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr field, byte isStatic);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_Throw (IntPtr jnienv, jobject toThrow);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_ThrowNew (IntPtr jnienv, jobject type, string message);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_ExceptionOccurred (IntPtr jnienv);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_ExceptionDescribe (IntPtr jnienv);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_ExceptionClear (IntPtr jnienv);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_FatalError (IntPtr jnienv, string message);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_PushLocalFrame (IntPtr jnienv, int capacity);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_PopLocalFrame (IntPtr jnienv, jobject result);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_NewGlobalRef (IntPtr jnienv, jobject instance);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_DeleteGlobalRef (IntPtr jnienv, IntPtr instance);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_DeleteLocalRef (IntPtr jnienv, IntPtr instance);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe byte JavaInterop_IsSameObject (IntPtr jnienv, jobject object1, jobject object2);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_NewLocalRef (IntPtr jnienv, jobject instance);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_EnsureLocalCapacity (IntPtr jnienv, int capacity);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_AllocObject (IntPtr jnienv, out IntPtr thrown, jobject type);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_NewObject (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_NewObjectA (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_GetObjectClass (IntPtr jnienv, jobject instance);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe byte JavaInterop_IsInstanceOf (IntPtr jnienv, jobject instance, jobject type);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe IntPtr JavaInterop_GetMethodID (IntPtr jnienv, out IntPtr thrown, jobject type, string name, string signature);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_CallObjectMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_CallObjectMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe byte JavaInterop_CallBooleanMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe byte JavaInterop_CallBooleanMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe sbyte JavaInterop_CallByteMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe sbyte JavaInterop_CallByteMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe char JavaInterop_CallCharMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe char JavaInterop_CallCharMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe short JavaInterop_CallShortMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe short JavaInterop_CallShortMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_CallIntMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_CallIntMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe long JavaInterop_CallLongMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe long JavaInterop_CallLongMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe float JavaInterop_CallFloatMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe float JavaInterop_CallFloatMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe double JavaInterop_CallDoubleMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe double JavaInterop_CallDoubleMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_CallVoidMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_CallVoidMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_CallNonvirtualObjectMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_CallNonvirtualObjectMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe byte JavaInterop_CallNonvirtualBooleanMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe byte JavaInterop_CallNonvirtualBooleanMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe sbyte JavaInterop_CallNonvirtualByteMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe sbyte JavaInterop_CallNonvirtualByteMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe char JavaInterop_CallNonvirtualCharMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe char JavaInterop_CallNonvirtualCharMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe short JavaInterop_CallNonvirtualShortMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe short JavaInterop_CallNonvirtualShortMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_CallNonvirtualIntMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_CallNonvirtualIntMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe long JavaInterop_CallNonvirtualLongMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe long JavaInterop_CallNonvirtualLongMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe float JavaInterop_CallNonvirtualFloatMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe float JavaInterop_CallNonvirtualFloatMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe double JavaInterop_CallNonvirtualDoubleMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe double JavaInterop_CallNonvirtualDoubleMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_CallNonvirtualVoidMethod (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_CallNonvirtualVoidMethodA (IntPtr jnienv, out IntPtr thrown, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe IntPtr JavaInterop_GetFieldID (IntPtr jnienv, out IntPtr thrown, jobject type, string name, string signature);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_GetObjectField (IntPtr jnienv, jobject instance, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe byte JavaInterop_GetBooleanField (IntPtr jnienv, jobject instance, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe sbyte JavaInterop_GetByteField (IntPtr jnienv, jobject instance, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe char JavaInterop_GetCharField (IntPtr jnienv, jobject instance, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe short JavaInterop_GetShortField (IntPtr jnienv, jobject instance, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_GetIntField (IntPtr jnienv, jobject instance, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe long JavaInterop_GetLongField (IntPtr jnienv, jobject instance, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe float JavaInterop_GetFloatField (IntPtr jnienv, jobject instance, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe double JavaInterop_GetDoubleField (IntPtr jnienv, jobject instance, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetObjectField (IntPtr jnienv, jobject instance, IntPtr field, jobject value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetBooleanField (IntPtr jnienv, jobject instance, IntPtr field, byte value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetByteField (IntPtr jnienv, jobject instance, IntPtr field, sbyte value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetCharField (IntPtr jnienv, jobject instance, IntPtr field, char value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetShortField (IntPtr jnienv, jobject instance, IntPtr field, short value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetIntField (IntPtr jnienv, jobject instance, IntPtr field, int value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetLongField (IntPtr jnienv, jobject instance, IntPtr field, long value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetFloatField (IntPtr jnienv, jobject instance, IntPtr field, float value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetDoubleField (IntPtr jnienv, jobject instance, IntPtr field, double value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe IntPtr JavaInterop_GetStaticMethodID (IntPtr jnienv, out IntPtr thrown, jobject type, string name, string signature);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_CallStaticObjectMethod (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_CallStaticObjectMethodA (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe byte JavaInterop_CallStaticBooleanMethod (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe byte JavaInterop_CallStaticBooleanMethodA (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe sbyte JavaInterop_CallStaticByteMethod (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe sbyte JavaInterop_CallStaticByteMethodA (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe char JavaInterop_CallStaticCharMethod (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe char JavaInterop_CallStaticCharMethodA (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe short JavaInterop_CallStaticShortMethod (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe short JavaInterop_CallStaticShortMethodA (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_CallStaticIntMethod (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_CallStaticIntMethodA (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe long JavaInterop_CallStaticLongMethod (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe long JavaInterop_CallStaticLongMethodA (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe float JavaInterop_CallStaticFloatMethod (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe float JavaInterop_CallStaticFloatMethodA (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe double JavaInterop_CallStaticDoubleMethod (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe double JavaInterop_CallStaticDoubleMethodA (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_CallStaticVoidMethod (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_CallStaticVoidMethodA (IntPtr jnienv, out IntPtr thrown, jobject type, IntPtr method, JniArgumentValue* args);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe IntPtr JavaInterop_GetStaticFieldID (IntPtr jnienv, out IntPtr thrown, jobject type, string name, string signature);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_GetStaticObjectField (IntPtr jnienv, jobject type, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe byte JavaInterop_GetStaticBooleanField (IntPtr jnienv, jobject type, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe sbyte JavaInterop_GetStaticByteField (IntPtr jnienv, jobject type, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe char JavaInterop_GetStaticCharField (IntPtr jnienv, jobject type, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe short JavaInterop_GetStaticShortField (IntPtr jnienv, jobject type, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_GetStaticIntField (IntPtr jnienv, jobject type, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe long JavaInterop_GetStaticLongField (IntPtr jnienv, jobject type, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe float JavaInterop_GetStaticFloatField (IntPtr jnienv, jobject type, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe double JavaInterop_GetStaticDoubleField (IntPtr jnienv, jobject type, IntPtr field);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetStaticObjectField (IntPtr jnienv, jobject type, IntPtr field, jobject value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetStaticBooleanField (IntPtr jnienv, jobject type, IntPtr field, byte value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetStaticByteField (IntPtr jnienv, jobject type, IntPtr field, sbyte value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetStaticCharField (IntPtr jnienv, jobject type, IntPtr field, char value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetStaticShortField (IntPtr jnienv, jobject type, IntPtr field, short value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetStaticIntField (IntPtr jnienv, jobject type, IntPtr field, int value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetStaticLongField (IntPtr jnienv, jobject type, IntPtr field, long value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetStaticFloatField (IntPtr jnienv, jobject type, IntPtr field, float value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetStaticDoubleField (IntPtr jnienv, jobject type, IntPtr field, double value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_NewString (IntPtr jnienv, out IntPtr thrown, IntPtr unicodeChars, int length);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_GetStringLength (IntPtr jnienv, jobject stringInstance);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe IntPtr JavaInterop_GetStringChars (IntPtr jnienv, jobject stringInstance, IntPtr isCopy);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_ReleaseStringChars (IntPtr jnienv, jobject stringInstance, IntPtr chars);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_GetArrayLength (IntPtr jnienv, jobject array);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_NewObjectArray (IntPtr jnienv, out IntPtr thrown, int length, jobject elementClass, jobject initialElement);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_GetObjectArrayElement (IntPtr jnienv, out IntPtr thrown, jobject array, int index);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetObjectArrayElement (IntPtr jnienv, out IntPtr thrown, jobject array, int index, jobject value);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_NewBooleanArray (IntPtr jnienv, int length);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_NewByteArray (IntPtr jnienv, int length);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_NewCharArray (IntPtr jnienv, int length);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_NewShortArray (IntPtr jnienv, int length);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_NewIntArray (IntPtr jnienv, int length);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_NewLongArray (IntPtr jnienv, int length);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_NewFloatArray (IntPtr jnienv, int length);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_NewDoubleArray (IntPtr jnienv, int length);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe IntPtr JavaInterop_GetBooleanArrayElements (IntPtr jnienv, jobject array, IntPtr isCopy);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe IntPtr JavaInterop_GetByteArrayElements (IntPtr jnienv, jobject array, IntPtr isCopy);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe IntPtr JavaInterop_GetCharArrayElements (IntPtr jnienv, jobject array, IntPtr isCopy);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe IntPtr JavaInterop_GetShortArrayElements (IntPtr jnienv, jobject array, IntPtr isCopy);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe IntPtr JavaInterop_GetIntArrayElements (IntPtr jnienv, jobject array, IntPtr isCopy);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe IntPtr JavaInterop_GetLongArrayElements (IntPtr jnienv, jobject array, IntPtr isCopy);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe IntPtr JavaInterop_GetFloatArrayElements (IntPtr jnienv, jobject array, IntPtr isCopy);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe IntPtr JavaInterop_GetDoubleArrayElements (IntPtr jnienv, jobject array, IntPtr isCopy);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_ReleaseBooleanArrayElements (IntPtr jnienv, jobject array, IntPtr elements, int mode);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_ReleaseByteArrayElements (IntPtr jnienv, jobject array, IntPtr elements, int mode);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_ReleaseCharArrayElements (IntPtr jnienv, jobject array, IntPtr elements, int mode);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_ReleaseShortArrayElements (IntPtr jnienv, jobject array, IntPtr elements, int mode);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_ReleaseIntArrayElements (IntPtr jnienv, jobject array, IntPtr elements, int mode);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_ReleaseLongArrayElements (IntPtr jnienv, jobject array, IntPtr elements, int mode);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_ReleaseFloatArrayElements (IntPtr jnienv, jobject array, IntPtr elements, int mode);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_ReleaseDoubleArrayElements (IntPtr jnienv, jobject array, IntPtr elements, int mode);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_GetBooleanArrayRegion (IntPtr jnienv, out IntPtr thrown, jobject array, int start, int length, IntPtr buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_GetByteArrayRegion (IntPtr jnienv, out IntPtr thrown, jobject array, int start, int length, IntPtr buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_GetCharArrayRegion (IntPtr jnienv, out IntPtr thrown, jobject array, int start, int length, IntPtr buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_GetShortArrayRegion (IntPtr jnienv, out IntPtr thrown, jobject array, int start, int length, IntPtr buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_GetIntArrayRegion (IntPtr jnienv, out IntPtr thrown, jobject array, int start, int length, IntPtr buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_GetLongArrayRegion (IntPtr jnienv, out IntPtr thrown, jobject array, int start, int length, IntPtr buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_GetFloatArrayRegion (IntPtr jnienv, out IntPtr thrown, jobject array, int start, int length, IntPtr buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_GetDoubleArrayRegion (IntPtr jnienv, out IntPtr thrown, jobject array, int start, int length, IntPtr buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetBooleanArrayRegion (IntPtr jnienv, out IntPtr thrown, jobject array, int start, int length, IntPtr buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetByteArrayRegion (IntPtr jnienv, out IntPtr thrown, jobject array, int start, int length, IntPtr buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetCharArrayRegion (IntPtr jnienv, out IntPtr thrown, jobject array, int start, int length, IntPtr buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetShortArrayRegion (IntPtr jnienv, out IntPtr thrown, jobject array, int start, int length, IntPtr buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetIntArrayRegion (IntPtr jnienv, out IntPtr thrown, jobject array, int start, int length, IntPtr buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetLongArrayRegion (IntPtr jnienv, out IntPtr thrown, jobject array, int start, int length, IntPtr buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetFloatArrayRegion (IntPtr jnienv, out IntPtr thrown, jobject array, int start, int length, IntPtr buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_SetDoubleArrayRegion (IntPtr jnienv, out IntPtr thrown, jobject array, int start, int length, IntPtr buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_RegisterNatives (IntPtr jnienv, out IntPtr thrown, jobject type, JniNativeMethodRegistration [] methods, int numMethods);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_UnregisterNatives (IntPtr jnienv, jobject type);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_MonitorEnter (IntPtr jnienv, jobject instance);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_MonitorExit (IntPtr jnienv, jobject instance);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe int JavaInterop_GetJavaVM (IntPtr jnienv, out IntPtr vm);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_NewWeakGlobalRef (IntPtr jnienv, jobject instance);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe void JavaInterop_DeleteWeakGlobalRef (IntPtr jnienv, IntPtr instance);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe byte JavaInterop_ExceptionCheck (IntPtr jnienv);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe jobject JavaInterop_NewDirectByteBuffer (IntPtr jnienv, out IntPtr thrown, IntPtr address, long capacity);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe IntPtr JavaInterop_GetDirectBufferAddress (IntPtr jnienv, jobject buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe long JavaInterop_GetDirectBufferCapacity (IntPtr jnienv, jobject buffer);

		[DllImport (JavaInteropLib, CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		internal static extern unsafe JniObjectReferenceType JavaInterop_GetObjectRefType (IntPtr jnienv, jobject instance);
	}

	partial class JniEnvironment {

	public static partial class Arrays {

		public static unsafe int GetArrayLength (JniObjectReference array)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var tmp = NativeMethods.JavaInterop_GetArrayLength (JniEnvironment.EnvironmentPointer, array.Handle);
			return tmp;
		}

		public static unsafe JniObjectReference NewObjectArray (int length, JniObjectReference elementClass, JniObjectReference initialElement)
		{
			if (elementClass.Handle == IntPtr.Zero)
				throw new ArgumentException ("`elementClass` must not be IntPtr.Zero.", "elementClass");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_NewObjectArray (JniEnvironment.EnvironmentPointer, out thrown, length, elementClass.Handle, initialElement.Handle);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference GetObjectArrayElement (JniObjectReference array, int index)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_GetObjectArrayElement (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, index);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe void SetObjectArrayElement (JniObjectReference array, int index, JniObjectReference value)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			IntPtr thrown;
			NativeMethods.JavaInterop_SetObjectArrayElement (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, index, value.Handle);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe JniObjectReference NewBooleanArray (int length)
		{
			var tmp = NativeMethods.JavaInterop_NewBooleanArray (JniEnvironment.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewByteArray (int length)
		{
			var tmp = NativeMethods.JavaInterop_NewByteArray (JniEnvironment.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewCharArray (int length)
		{
			var tmp = NativeMethods.JavaInterop_NewCharArray (JniEnvironment.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewShortArray (int length)
		{
			var tmp = NativeMethods.JavaInterop_NewShortArray (JniEnvironment.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewIntArray (int length)
		{
			var tmp = NativeMethods.JavaInterop_NewIntArray (JniEnvironment.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewLongArray (int length)
		{
			var tmp = NativeMethods.JavaInterop_NewLongArray (JniEnvironment.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewFloatArray (int length)
		{
			var tmp = NativeMethods.JavaInterop_NewFloatArray (JniEnvironment.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewDoubleArray (int length)
		{
			var tmp = NativeMethods.JavaInterop_NewDoubleArray (JniEnvironment.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe IntPtr GetBooleanArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var tmp = NativeMethods.JavaInterop_GetBooleanArrayElements (JniEnvironment.EnvironmentPointer, array.Handle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetByteArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var tmp = NativeMethods.JavaInterop_GetByteArrayElements (JniEnvironment.EnvironmentPointer, array.Handle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetCharArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var tmp = NativeMethods.JavaInterop_GetCharArrayElements (JniEnvironment.EnvironmentPointer, array.Handle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetShortArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var tmp = NativeMethods.JavaInterop_GetShortArrayElements (JniEnvironment.EnvironmentPointer, array.Handle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetIntArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var tmp = NativeMethods.JavaInterop_GetIntArrayElements (JniEnvironment.EnvironmentPointer, array.Handle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetLongArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var tmp = NativeMethods.JavaInterop_GetLongArrayElements (JniEnvironment.EnvironmentPointer, array.Handle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetFloatArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var tmp = NativeMethods.JavaInterop_GetFloatArrayElements (JniEnvironment.EnvironmentPointer, array.Handle, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetDoubleArrayElements (JniObjectReference array, IntPtr isCopy)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var tmp = NativeMethods.JavaInterop_GetDoubleArrayElements (JniEnvironment.EnvironmentPointer, array.Handle, isCopy);
			return tmp;
		}

		public static unsafe void ReleaseBooleanArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			NativeMethods.JavaInterop_ReleaseBooleanArrayElements (JniEnvironment.EnvironmentPointer, array.Handle, elements, mode);
		}

		public static unsafe void ReleaseByteArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			NativeMethods.JavaInterop_ReleaseByteArrayElements (JniEnvironment.EnvironmentPointer, array.Handle, elements, mode);
		}

		public static unsafe void ReleaseCharArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			NativeMethods.JavaInterop_ReleaseCharArrayElements (JniEnvironment.EnvironmentPointer, array.Handle, elements, mode);
		}

		public static unsafe void ReleaseShortArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			NativeMethods.JavaInterop_ReleaseShortArrayElements (JniEnvironment.EnvironmentPointer, array.Handle, elements, mode);
		}

		public static unsafe void ReleaseIntArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			NativeMethods.JavaInterop_ReleaseIntArrayElements (JniEnvironment.EnvironmentPointer, array.Handle, elements, mode);
		}

		public static unsafe void ReleaseLongArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			NativeMethods.JavaInterop_ReleaseLongArrayElements (JniEnvironment.EnvironmentPointer, array.Handle, elements, mode);
		}

		public static unsafe void ReleaseFloatArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			NativeMethods.JavaInterop_ReleaseFloatArrayElements (JniEnvironment.EnvironmentPointer, array.Handle, elements, mode);
		}

		public static unsafe void ReleaseDoubleArrayElements (JniObjectReference array, IntPtr elements, int mode)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			NativeMethods.JavaInterop_ReleaseDoubleArrayElements (JniEnvironment.EnvironmentPointer, array.Handle, elements, mode);
		}

		public static unsafe void GetBooleanArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			IntPtr thrown;
			NativeMethods.JavaInterop_GetBooleanArrayRegion (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetByteArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			IntPtr thrown;
			NativeMethods.JavaInterop_GetByteArrayRegion (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetCharArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			IntPtr thrown;
			NativeMethods.JavaInterop_GetCharArrayRegion (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetShortArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			IntPtr thrown;
			NativeMethods.JavaInterop_GetShortArrayRegion (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetIntArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			IntPtr thrown;
			NativeMethods.JavaInterop_GetIntArrayRegion (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetLongArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			IntPtr thrown;
			NativeMethods.JavaInterop_GetLongArrayRegion (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetFloatArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			IntPtr thrown;
			NativeMethods.JavaInterop_GetFloatArrayRegion (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetDoubleArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			IntPtr thrown;
			NativeMethods.JavaInterop_GetDoubleArrayRegion (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetBooleanArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			IntPtr thrown;
			NativeMethods.JavaInterop_SetBooleanArrayRegion (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetByteArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			IntPtr thrown;
			NativeMethods.JavaInterop_SetByteArrayRegion (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetCharArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			IntPtr thrown;
			NativeMethods.JavaInterop_SetCharArrayRegion (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetShortArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			IntPtr thrown;
			NativeMethods.JavaInterop_SetShortArrayRegion (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetIntArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			IntPtr thrown;
			NativeMethods.JavaInterop_SetIntArrayRegion (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetLongArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			IntPtr thrown;
			NativeMethods.JavaInterop_SetLongArrayRegion (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetFloatArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			IntPtr thrown;
			NativeMethods.JavaInterop_SetFloatArrayRegion (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetDoubleArrayRegion (JniObjectReference array, int start, int length, IntPtr buffer)
		{
			if (array.Handle == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			IntPtr thrown;
			NativeMethods.JavaInterop_SetDoubleArrayRegion (JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}
	}

	public static partial class Exceptions {

		internal static unsafe int _Throw (JniObjectReference toThrow)
		{
			if (toThrow.Handle == IntPtr.Zero)
				throw new ArgumentException ("`toThrow` must not be IntPtr.Zero.", "toThrow");

			var tmp = NativeMethods.JavaInterop_Throw (JniEnvironment.EnvironmentPointer, toThrow.Handle);
			return tmp;
		}

		internal static unsafe int _ThrowNew (JniObjectReference type, string message)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (message == null)
				throw new ArgumentNullException ("message");

			var tmp = NativeMethods.JavaInterop_ThrowNew (JniEnvironment.EnvironmentPointer, type.Handle, message);
			return tmp;
		}

		public static unsafe JniObjectReference ExceptionOccurred ()
		{
			var tmp = NativeMethods.JavaInterop_ExceptionOccurred (JniEnvironment.EnvironmentPointer);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe void ExceptionDescribe ()
		{
			NativeMethods.JavaInterop_ExceptionDescribe (JniEnvironment.EnvironmentPointer);
		}

		public static unsafe void ExceptionClear ()
		{
			NativeMethods.JavaInterop_ExceptionClear (JniEnvironment.EnvironmentPointer);
		}

		public static unsafe void FatalError (string message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");

			NativeMethods.JavaInterop_FatalError (JniEnvironment.EnvironmentPointer, message);
		}

		public static unsafe bool ExceptionCheck ()
		{
			var tmp = NativeMethods.JavaInterop_ExceptionCheck (JniEnvironment.EnvironmentPointer);
			return (tmp != 0) ? true : false;
		}
	}

	public static partial class InstanceFields {

		public static unsafe JniInstanceFieldInfo GetFieldID (JniObjectReference type, string name, string signature)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (signature == null)
				throw new ArgumentNullException ("signature");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_GetFieldID (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, name, signature);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			if (tmp == IntPtr.Zero)
				return null;
			return new JniInstanceFieldInfo (tmp);
		}

		public static unsafe JniObjectReference GetObjectField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetObjectField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool GetBooleanField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetBooleanField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID);
			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte GetByteField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetByteField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID);
			return tmp;
		}

		public static unsafe char GetCharField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetCharField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID);
			return tmp;
		}

		public static unsafe short GetShortField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetShortField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID);
			return tmp;
		}

		public static unsafe int GetIntField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetIntField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID);
			return tmp;
		}

		public static unsafe long GetLongField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetLongField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID);
			return tmp;
		}

		public static unsafe float GetFloatField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetFloatField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID);
			return tmp;
		}

		public static unsafe double GetDoubleField (JniObjectReference instance, JniInstanceFieldInfo field)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetDoubleField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID);
			return tmp;
		}

		public static unsafe void SetObjectField (JniObjectReference instance, JniInstanceFieldInfo field, JniObjectReference value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetObjectField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, value.Handle);
		}

		public static unsafe void SetBooleanField (JniObjectReference instance, JniInstanceFieldInfo field, bool value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetBooleanField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, (value ? (byte) 1 : (byte) 0));
		}

		public static unsafe void SetByteField (JniObjectReference instance, JniInstanceFieldInfo field, sbyte value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetByteField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, value);
		}

		public static unsafe void SetCharField (JniObjectReference instance, JniInstanceFieldInfo field, char value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetCharField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, value);
		}

		public static unsafe void SetShortField (JniObjectReference instance, JniInstanceFieldInfo field, short value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetShortField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, value);
		}

		public static unsafe void SetIntField (JniObjectReference instance, JniInstanceFieldInfo field, int value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetIntField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, value);
		}

		public static unsafe void SetLongField (JniObjectReference instance, JniInstanceFieldInfo field, long value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetLongField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, value);
		}

		public static unsafe void SetFloatField (JniObjectReference instance, JniInstanceFieldInfo field, float value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetFloatField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, value);
		}

		public static unsafe void SetDoubleField (JniObjectReference instance, JniInstanceFieldInfo field, double value)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetDoubleField (JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, value);
		}
	}

	public static partial class InstanceMethods {

		public static unsafe JniInstanceMethodInfo GetMethodID (JniObjectReference type, string name, string signature)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (signature == null)
				throw new ArgumentNullException ("signature");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_GetMethodID (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, name, signature);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			if (tmp == IntPtr.Zero)
				return null;
			return new JniInstanceMethodInfo (tmp);
		}

		public static unsafe JniObjectReference CallObjectMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallObjectMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference CallObjectMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallObjectMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool CallBooleanMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallBooleanMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe bool CallBooleanMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallBooleanMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte CallByteMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallByteMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe sbyte CallByteMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallByteMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallCharMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallCharMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallCharMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallCharMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallShortMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallShortMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallShortMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallShortMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallIntMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallIntMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallIntMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallIntMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallLongMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallLongMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallLongMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallLongMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallFloatMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallFloatMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallFloatMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallFloatMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallDoubleMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallDoubleMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallDoubleMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallDoubleMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe void CallVoidMethod (JniObjectReference instance, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			NativeMethods.JavaInterop_CallVoidMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void CallVoidMethod (JniObjectReference instance, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			NativeMethods.JavaInterop_CallVoidMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe JniObjectReference CallNonvirtualObjectMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualObjectMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference CallNonvirtualObjectMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualObjectMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool CallNonvirtualBooleanMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualBooleanMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe bool CallNonvirtualBooleanMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualBooleanMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte CallNonvirtualByteMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualByteMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe sbyte CallNonvirtualByteMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualByteMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallNonvirtualCharMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualCharMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallNonvirtualCharMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualCharMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallNonvirtualShortMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualShortMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallNonvirtualShortMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualShortMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallNonvirtualIntMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualIntMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallNonvirtualIntMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualIntMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallNonvirtualLongMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualLongMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallNonvirtualLongMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualLongMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallNonvirtualFloatMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualFloatMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallNonvirtualFloatMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualFloatMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallNonvirtualDoubleMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualDoubleMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallNonvirtualDoubleMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallNonvirtualDoubleMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe void CallNonvirtualVoidMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			NativeMethods.JavaInterop_CallNonvirtualVoidMethod (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void CallNonvirtualVoidMethod (JniObjectReference instance, JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			NativeMethods.JavaInterop_CallNonvirtualVoidMethodA (JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}
	}

	public static partial class IO {

		public static unsafe JniObjectReference NewDirectByteBuffer (IntPtr address, long capacity)
		{
			if (address == IntPtr.Zero)
				throw new ArgumentException ("'address' must not be IntPtr.Zero.", "address");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_NewDirectByteBuffer (JniEnvironment.EnvironmentPointer, out thrown, address, capacity);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe IntPtr GetDirectBufferAddress (JniObjectReference buffer)
		{
			if (buffer.Handle == IntPtr.Zero)
				throw new ArgumentException ("`buffer` must not be IntPtr.Zero.", "buffer");

			var tmp = NativeMethods.JavaInterop_GetDirectBufferAddress (JniEnvironment.EnvironmentPointer, buffer.Handle);
			return tmp;
		}

		public static unsafe long GetDirectBufferCapacity (JniObjectReference buffer)
		{
			if (buffer.Handle == IntPtr.Zero)
				throw new ArgumentException ("`buffer` must not be IntPtr.Zero.", "buffer");

			var tmp = NativeMethods.JavaInterop_GetDirectBufferCapacity (JniEnvironment.EnvironmentPointer, buffer.Handle);
			return tmp;
		}
	}

	public static partial class Monitors {

		internal static unsafe int _MonitorEnter (JniObjectReference instance)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");

			var tmp = NativeMethods.JavaInterop_MonitorEnter (JniEnvironment.EnvironmentPointer, instance.Handle);
			return tmp;
		}

		internal static unsafe int _MonitorExit (JniObjectReference instance)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");

			var tmp = NativeMethods.JavaInterop_MonitorExit (JniEnvironment.EnvironmentPointer, instance.Handle);
			return tmp;
		}
	}

	public static partial class Object {

		public static unsafe JniObjectReference AllocObject (JniObjectReference type)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_AllocObject (JniEnvironment.EnvironmentPointer, out thrown, type.Handle);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewObject (JniObjectReference type, JniInstanceMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_NewObject (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference NewObject (JniObjectReference type, JniInstanceMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_NewObjectA (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}
	}

	public static partial class References {

		internal static unsafe int _PushLocalFrame (int capacity)
		{
			var tmp = NativeMethods.JavaInterop_PushLocalFrame (JniEnvironment.EnvironmentPointer, capacity);
			return tmp;
		}

		public static unsafe JniObjectReference PopLocalFrame (JniObjectReference result)
		{
			var tmp = NativeMethods.JavaInterop_PopLocalFrame (JniEnvironment.EnvironmentPointer, result.Handle);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		internal static unsafe JniObjectReference NewGlobalRef (JniObjectReference instance)
		{
			var tmp = NativeMethods.JavaInterop_NewGlobalRef (JniEnvironment.EnvironmentPointer, instance.Handle);
			return new JniObjectReference (tmp, JniObjectReferenceType.Global);
		}

		internal static unsafe void DeleteGlobalRef (IntPtr instance)
		{
			NativeMethods.JavaInterop_DeleteGlobalRef (JniEnvironment.EnvironmentPointer, instance);
		}

		internal static unsafe void DeleteLocalRef (IntPtr instance)
		{
			NativeMethods.JavaInterop_DeleteLocalRef (JniEnvironment.EnvironmentPointer, instance);
		}

		internal static unsafe JniObjectReference NewLocalRef (JniObjectReference instance)
		{
			var tmp = NativeMethods.JavaInterop_NewLocalRef (JniEnvironment.EnvironmentPointer, instance.Handle);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		internal static unsafe int _EnsureLocalCapacity (int capacity)
		{
			var tmp = NativeMethods.JavaInterop_EnsureLocalCapacity (JniEnvironment.EnvironmentPointer, capacity);
			return tmp;
		}

		internal static unsafe int _GetJavaVM (out IntPtr vm)
		{
			var tmp = NativeMethods.JavaInterop_GetJavaVM (JniEnvironment.EnvironmentPointer, out vm);
			return tmp;
		}

		internal static unsafe JniObjectReference NewWeakGlobalRef (JniObjectReference instance)
		{
			var tmp = NativeMethods.JavaInterop_NewWeakGlobalRef (JniEnvironment.EnvironmentPointer, instance.Handle);
			return new JniObjectReference (tmp, JniObjectReferenceType.WeakGlobal);
		}

		internal static unsafe void DeleteWeakGlobalRef (IntPtr instance)
		{
			NativeMethods.JavaInterop_DeleteWeakGlobalRef (JniEnvironment.EnvironmentPointer, instance);
		}

		internal static unsafe JniObjectReferenceType GetObjectRefType (JniObjectReference instance)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");

			var tmp = NativeMethods.JavaInterop_GetObjectRefType (JniEnvironment.EnvironmentPointer, instance.Handle);
			return tmp;
		}
	}

	internal static partial class Reflection {

		public static unsafe JniObjectReference ToReflectedMethod (JniObjectReference type, JniInstanceMethodInfo method, bool isStatic)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_ToReflectedMethod (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, (isStatic ? (byte) 1 : (byte) 0));

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference ToReflectedField (JniObjectReference type, JniInstanceFieldInfo field, bool isStatic)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_ToReflectedField (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, field.ID, (isStatic ? (byte) 1 : (byte) 0));

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}
	}

	public static partial class StaticFields {

		public static unsafe JniStaticFieldInfo GetStaticFieldID (JniObjectReference type, string name, string signature)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (signature == null)
				throw new ArgumentNullException ("signature");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_GetStaticFieldID (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, name, signature);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			if (tmp == IntPtr.Zero)
				return null;
			return new JniStaticFieldInfo (tmp);
		}

		public static unsafe JniObjectReference GetStaticObjectField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetStaticObjectField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool GetStaticBooleanField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetStaticBooleanField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID);
			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte GetStaticByteField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetStaticByteField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID);
			return tmp;
		}

		public static unsafe char GetStaticCharField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetStaticCharField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID);
			return tmp;
		}

		public static unsafe short GetStaticShortField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetStaticShortField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID);
			return tmp;
		}

		public static unsafe int GetStaticIntField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetStaticIntField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID);
			return tmp;
		}

		public static unsafe long GetStaticLongField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetStaticLongField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID);
			return tmp;
		}

		public static unsafe float GetStaticFloatField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetStaticFloatField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID);
			return tmp;
		}

		public static unsafe double GetStaticDoubleField (JniObjectReference type, JniStaticFieldInfo field)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var tmp = NativeMethods.JavaInterop_GetStaticDoubleField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID);
			return tmp;
		}

		public static unsafe void SetStaticObjectField (JniObjectReference type, JniStaticFieldInfo field, JniObjectReference value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetStaticObjectField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID, value.Handle);
		}

		public static unsafe void SetStaticBooleanField (JniObjectReference type, JniStaticFieldInfo field, bool value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetStaticBooleanField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID, (value ? (byte) 1 : (byte) 0));
		}

		public static unsafe void SetStaticByteField (JniObjectReference type, JniStaticFieldInfo field, sbyte value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetStaticByteField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID, value);
		}

		public static unsafe void SetStaticCharField (JniObjectReference type, JniStaticFieldInfo field, char value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetStaticCharField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID, value);
		}

		public static unsafe void SetStaticShortField (JniObjectReference type, JniStaticFieldInfo field, short value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetStaticShortField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID, value);
		}

		public static unsafe void SetStaticIntField (JniObjectReference type, JniStaticFieldInfo field, int value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetStaticIntField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID, value);
		}

		public static unsafe void SetStaticLongField (JniObjectReference type, JniStaticFieldInfo field, long value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetStaticLongField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID, value);
		}

		public static unsafe void SetStaticFloatField (JniObjectReference type, JniStaticFieldInfo field, float value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetStaticFloatField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID, value);
		}

		public static unsafe void SetStaticDoubleField (JniObjectReference type, JniStaticFieldInfo field, double value)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == null)
				throw new ArgumentNullException ("field");
			if (field.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			NativeMethods.JavaInterop_SetStaticDoubleField (JniEnvironment.EnvironmentPointer, type.Handle, field.ID, value);
		}
	}

	public static partial class StaticMethods {

		public static unsafe JniStaticMethodInfo GetStaticMethodID (JniObjectReference type, string name, string signature)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (signature == null)
				throw new ArgumentNullException ("signature");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_GetStaticMethodID (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, name, signature);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			if (tmp == IntPtr.Zero)
				return null;
			return new JniStaticMethodInfo (tmp);
		}

		public static unsafe JniObjectReference CallStaticObjectMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticObjectMethod (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference CallStaticObjectMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticObjectMethodA (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool CallStaticBooleanMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticBooleanMethod (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe bool CallStaticBooleanMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticBooleanMethodA (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte CallStaticByteMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticByteMethod (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe sbyte CallStaticByteMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticByteMethodA (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallStaticCharMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticCharMethod (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallStaticCharMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticCharMethodA (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallStaticShortMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticShortMethod (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallStaticShortMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticShortMethodA (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallStaticIntMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticIntMethod (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallStaticIntMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticIntMethodA (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallStaticLongMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticLongMethod (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallStaticLongMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticLongMethodA (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallStaticFloatMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticFloatMethod (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallStaticFloatMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticFloatMethodA (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallStaticDoubleMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticDoubleMethod (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallStaticDoubleMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_CallStaticDoubleMethodA (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe void CallStaticVoidMethod (JniObjectReference type, JniStaticMethodInfo method)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			NativeMethods.JavaInterop_CallStaticVoidMethod (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void CallStaticVoidMethod (JniObjectReference type, JniStaticMethodInfo method, JniArgumentValue* args)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (method.ID == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			IntPtr thrown;
			NativeMethods.JavaInterop_CallStaticVoidMethodA (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}
	}

	public static partial class Strings {

		public static unsafe JniObjectReference NewString (IntPtr unicodeChars, int length)
		{
			if (unicodeChars == IntPtr.Zero)
				throw new ArgumentException ("'unicodeChars' must not be IntPtr.Zero.", "unicodeChars");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_NewString (JniEnvironment.EnvironmentPointer, out thrown, unicodeChars, length);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe int GetStringLength (JniObjectReference stringInstance)
		{
			if (stringInstance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`stringInstance` must not be IntPtr.Zero.", "stringInstance");

			var tmp = NativeMethods.JavaInterop_GetStringLength (JniEnvironment.EnvironmentPointer, stringInstance.Handle);
			return tmp;
		}

		public static unsafe IntPtr GetStringChars (JniObjectReference stringInstance, IntPtr isCopy)
		{
			if (stringInstance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`stringInstance` must not be IntPtr.Zero.", "stringInstance");

			var tmp = NativeMethods.JavaInterop_GetStringChars (JniEnvironment.EnvironmentPointer, stringInstance.Handle, isCopy);
			return tmp;
		}

		public static unsafe void ReleaseStringChars (JniObjectReference stringInstance, IntPtr chars)
		{
			if (stringInstance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`stringInstance` must not be IntPtr.Zero.", "stringInstance");
			if (chars == IntPtr.Zero)
				throw new ArgumentException ("'chars' must not be IntPtr.Zero.", "chars");

			NativeMethods.JavaInterop_ReleaseStringChars (JniEnvironment.EnvironmentPointer, stringInstance.Handle, chars);
		}
	}

	public static partial class Types {

		public static unsafe JniObjectReference DefineClass (string name, JniObjectReference loader, IntPtr buffer, int bufferLength)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (loader.Handle == IntPtr.Zero)
				throw new ArgumentException ("`loader` must not be IntPtr.Zero.", "loader");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_DefineClass (JniEnvironment.EnvironmentPointer, out thrown, name, loader.Handle, buffer, bufferLength);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		internal static unsafe JniObjectReference _FindClass (string classname)
		{
			if (classname == null)
				throw new ArgumentNullException ("classname");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_FindClass (JniEnvironment.EnvironmentPointer, out thrown, classname);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe JniObjectReference GetSuperclass (JniObjectReference type)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");

			var tmp = NativeMethods.JavaInterop_GetSuperclass (JniEnvironment.EnvironmentPointer, type.Handle);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool IsAssignableFrom (JniObjectReference class1, JniObjectReference class2)
		{
			if (class1.Handle == IntPtr.Zero)
				throw new ArgumentException ("`class1` must not be IntPtr.Zero.", "class1");
			if (class2.Handle == IntPtr.Zero)
				throw new ArgumentException ("`class2` must not be IntPtr.Zero.", "class2");

			var tmp = NativeMethods.JavaInterop_IsAssignableFrom (JniEnvironment.EnvironmentPointer, class1.Handle, class2.Handle);
			return (tmp != 0) ? true : false;
		}

		public static unsafe bool IsSameObject (JniObjectReference object1, JniObjectReference object2)
		{
			var tmp = NativeMethods.JavaInterop_IsSameObject (JniEnvironment.EnvironmentPointer, object1.Handle, object2.Handle);
			return (tmp != 0) ? true : false;
		}

		public static unsafe JniObjectReference GetObjectClass (JniObjectReference instance)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");

			var tmp = NativeMethods.JavaInterop_GetObjectClass (JniEnvironment.EnvironmentPointer, instance.Handle);
			JniEnvironment.LogCreateLocalRef (tmp);
			return new JniObjectReference (tmp, JniObjectReferenceType.Local);
		}

		public static unsafe bool IsInstanceOf (JniObjectReference instance, JniObjectReference type)
		{
			if (instance.Handle == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");

			var tmp = NativeMethods.JavaInterop_IsInstanceOf (JniEnvironment.EnvironmentPointer, instance.Handle, type.Handle);
			return (tmp != 0) ? true : false;
		}

		internal static unsafe int _RegisterNatives (JniObjectReference type, JniNativeMethodRegistration [] methods, int numMethods)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");

			IntPtr thrown;
			var tmp = NativeMethods.JavaInterop_RegisterNatives (JniEnvironment.EnvironmentPointer, out thrown, type.Handle, methods, numMethods);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable (thrown);
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		internal static unsafe int _UnregisterNatives (JniObjectReference type)
		{
			if (type.Handle == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");

			var tmp = NativeMethods.JavaInterop_UnregisterNatives (JniEnvironment.EnvironmentPointer, type.Handle);
			return tmp;
		}
	}

	internal static partial class Versions {

		internal static unsafe int GetVersion ()
		{
			var tmp = NativeMethods.JavaInterop_GetVersion (JniEnvironment.EnvironmentPointer);
			return tmp;
		}
	}
	}

}
#endif  // FEATURE_JNIENVIRONMENT_JI_PINVOKES
#if FEATURE_JNIENVIRONMENT_XA_INTPTRS
namespace
#if _NAMESPACE_PER_HANDLE
	Java.Interop.XAIntPtrs
#else
	Java.Interop
#endif
{

	unsafe delegate int JniFunc_JNIEnvPtr_int (JNIEnvPtr env);
	unsafe delegate jobject JniFunc_JNIEnvPtr_string_jobject_IntPtr_int_jobject (JNIEnvPtr env, string name, jobject loader, IntPtr buffer, int bufferLength);
	unsafe delegate jobject JniFunc_JNIEnvPtr_string_jobject (JNIEnvPtr env, string classname);
	unsafe delegate IntPtr JniFunc_JNIEnvPtr_jobject_IntPtr (JNIEnvPtr env, jobject method);
	unsafe delegate jobject JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject (JNIEnvPtr env, jobject type, IntPtr method, byte isStatic);
	unsafe delegate jobject JniFunc_JNIEnvPtr_jobject_jobject (JNIEnvPtr env, jobject type);
	unsafe delegate byte JniFunc_JNIEnvPtr_jobject_jobject_byte (JNIEnvPtr env, jobject class1, jobject class2);
	unsafe delegate int JniFunc_JNIEnvPtr_jobject_int (JNIEnvPtr env, jobject toThrow);
	unsafe delegate int JniFunc_JNIEnvPtr_jobject_string_int (JNIEnvPtr env, jobject type, string message);
	unsafe delegate jobject JniFunc_JNIEnvPtr_jobject (JNIEnvPtr env);
	unsafe delegate void JniAction_JNIEnvPtr (JNIEnvPtr env);
	unsafe delegate void JniAction_JNIEnvPtr_string (JNIEnvPtr env, string message);
	unsafe delegate int JniFunc_JNIEnvPtr_int_int (JNIEnvPtr env, int capacity);
	unsafe delegate void JniAction_JNIEnvPtr_IntPtr (JNIEnvPtr env, IntPtr instance);
	unsafe delegate jobject JniFunc_JNIEnvPtr_jobject_IntPtr_jobject (JNIEnvPtr env, jobject type, IntPtr method);
	unsafe delegate jobject JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject (JNIEnvPtr env, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate IntPtr JniFunc_JNIEnvPtr_jobject_string_string_IntPtr (JNIEnvPtr env, jobject type, string name, string signature);
	unsafe delegate byte JniFunc_JNIEnvPtr_jobject_IntPtr_byte (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate byte JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate sbyte JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate sbyte JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate char JniFunc_JNIEnvPtr_jobject_IntPtr_char (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate char JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate short JniFunc_JNIEnvPtr_jobject_IntPtr_short (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate short JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate int JniFunc_JNIEnvPtr_jobject_IntPtr_int (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate int JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate long JniFunc_JNIEnvPtr_jobject_IntPtr_long (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate long JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate float JniFunc_JNIEnvPtr_jobject_IntPtr_float (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate float JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate double JniFunc_JNIEnvPtr_jobject_IntPtr_double (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate double JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr (JNIEnvPtr env, jobject instance, IntPtr method);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef (JNIEnvPtr env, jobject instance, IntPtr method, JniArgumentValue* args);
	unsafe delegate jobject JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_jobject (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate jobject JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_jobject (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate byte JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_byte (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate byte JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_byte (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate sbyte JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_sbyte (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate sbyte JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_sbyte (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate char JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_char (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate char JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_char (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate short JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_short (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate short JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_short (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate int JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_int (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate int JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_int (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate long JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_long (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate long JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_long (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate float JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_float (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate float JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_float (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate double JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_double (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate double JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_double (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_jobject_IntPtr (JNIEnvPtr env, jobject instance, jobject type, IntPtr method);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef (JNIEnvPtr env, jobject instance, jobject type, IntPtr method, JniArgumentValue* args);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_jobject (JNIEnvPtr env, jobject instance, IntPtr field, jobject value);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_byte (JNIEnvPtr env, jobject instance, IntPtr field, byte value);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_sbyte (JNIEnvPtr env, jobject instance, IntPtr field, sbyte value);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_char (JNIEnvPtr env, jobject instance, IntPtr field, char value);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_short (JNIEnvPtr env, jobject instance, IntPtr field, short value);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_int (JNIEnvPtr env, jobject instance, IntPtr field, int value);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_long (JNIEnvPtr env, jobject instance, IntPtr field, long value);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_float (JNIEnvPtr env, jobject instance, IntPtr field, float value);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_IntPtr_double (JNIEnvPtr env, jobject instance, IntPtr field, double value);
	[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl, CharSet=CharSet.Unicode)]
	unsafe delegate jobject JniFunc_JNIEnvPtr_IntPtr_int_jobject (JNIEnvPtr env, IntPtr unicodeChars, int length);
	unsafe delegate IntPtr JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr (JNIEnvPtr env, jobject stringInstance, IntPtr isCopy);
	unsafe delegate string JniFunc_JNIEnvPtr_jobject_IntPtr_string (JNIEnvPtr env, jobject stringInstance, IntPtr isCopy);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_string (JNIEnvPtr env, jobject stringInstance, string utf);
	unsafe delegate jobject JniFunc_JNIEnvPtr_int_jobject_jobject_jobject (JNIEnvPtr env, int length, jobject elementClass, jobject initialElement);
	unsafe delegate jobject JniFunc_JNIEnvPtr_jobject_int_jobject (JNIEnvPtr env, jobject array, int index);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_int_jobject (JNIEnvPtr env, jobject array, int index, jobject value);
	unsafe delegate jobject JniFunc_JNIEnvPtr_int_jobject (JNIEnvPtr env, int length);
	unsafe delegate void JniAction_JNIEnvPtr_jobject_int_int_IntPtr (JNIEnvPtr env, jobject array, int start, int length, IntPtr buffer);
	unsafe delegate int JniFunc_JNIEnvPtr_jobject_JniNativeMethodRegistrationArray_int_int (JNIEnvPtr env, jobject type, JniNativeMethodRegistration [] methods, int numMethods);
	unsafe delegate int JniFunc_JNIEnvPtr_outIntPtr_int (JNIEnvPtr env, out IntPtr vm);
	unsafe delegate byte JniFunc_JNIEnvPtr_byte (JNIEnvPtr env);
	unsafe delegate jobject JniFunc_JNIEnvPtr_IntPtr_long_jobject (JNIEnvPtr env, IntPtr address, long capacity);
	unsafe delegate long JniFunc_JNIEnvPtr_jobject_long (JNIEnvPtr env, jobject buffer);
	unsafe delegate JniObjectReferenceType JniFunc_JNIEnvPtr_jobject_JniObjectReferenceType (JNIEnvPtr env, jobject instance);

	partial class JniEnvironment {

	public static partial class Arrays {

		public static unsafe int GetArrayLength (IntPtr array)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetArrayLength (__info.EnvironmentPointer, array);
			return tmp;
		}

		public static unsafe IntPtr NewObjectArray (int length, IntPtr elementClass, IntPtr initialElement)
		{
			if (elementClass == IntPtr.Zero)
				throw new ArgumentException ("`elementClass` must not be IntPtr.Zero.", "elementClass");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewObjectArray (__info.EnvironmentPointer, length, elementClass, initialElement);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe IntPtr GetObjectArrayElement (IntPtr array, int index)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetObjectArrayElement (__info.EnvironmentPointer, array, index);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe void SetObjectArrayElement (IntPtr array, int index, IntPtr value)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetObjectArrayElement (__info.EnvironmentPointer, array, index, value);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe IntPtr NewBooleanArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewBooleanArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe IntPtr NewByteArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewByteArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe IntPtr NewCharArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewCharArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe IntPtr NewShortArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewShortArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe IntPtr NewIntArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewIntArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe IntPtr NewLongArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewLongArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe IntPtr NewFloatArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewFloatArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe IntPtr NewDoubleArray (int length)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewDoubleArray (__info.EnvironmentPointer, length);
			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe IntPtr GetBooleanArrayElements (IntPtr array, IntPtr isCopy)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetBooleanArrayElements (__info.EnvironmentPointer, array, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetByteArrayElements (IntPtr array, IntPtr isCopy)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetByteArrayElements (__info.EnvironmentPointer, array, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetCharArrayElements (IntPtr array, IntPtr isCopy)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetCharArrayElements (__info.EnvironmentPointer, array, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetShortArrayElements (IntPtr array, IntPtr isCopy)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetShortArrayElements (__info.EnvironmentPointer, array, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetIntArrayElements (IntPtr array, IntPtr isCopy)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetIntArrayElements (__info.EnvironmentPointer, array, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetLongArrayElements (IntPtr array, IntPtr isCopy)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetLongArrayElements (__info.EnvironmentPointer, array, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetFloatArrayElements (IntPtr array, IntPtr isCopy)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetFloatArrayElements (__info.EnvironmentPointer, array, isCopy);
			return tmp;
		}

		public static unsafe IntPtr GetDoubleArrayElements (IntPtr array, IntPtr isCopy)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetDoubleArrayElements (__info.EnvironmentPointer, array, isCopy);
			return tmp;
		}

		public static unsafe void ReleaseBooleanArrayElements (IntPtr array, IntPtr elements, int mode)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseBooleanArrayElements (__info.EnvironmentPointer, array, elements, mode);
		}

		public static unsafe void ReleaseByteArrayElements (IntPtr array, IntPtr elements, int mode)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseByteArrayElements (__info.EnvironmentPointer, array, elements, mode);
		}

		public static unsafe void ReleaseCharArrayElements (IntPtr array, IntPtr elements, int mode)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseCharArrayElements (__info.EnvironmentPointer, array, elements, mode);
		}

		public static unsafe void ReleaseShortArrayElements (IntPtr array, IntPtr elements, int mode)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseShortArrayElements (__info.EnvironmentPointer, array, elements, mode);
		}

		public static unsafe void ReleaseIntArrayElements (IntPtr array, IntPtr elements, int mode)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseIntArrayElements (__info.EnvironmentPointer, array, elements, mode);
		}

		public static unsafe void ReleaseLongArrayElements (IntPtr array, IntPtr elements, int mode)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseLongArrayElements (__info.EnvironmentPointer, array, elements, mode);
		}

		public static unsafe void ReleaseFloatArrayElements (IntPtr array, IntPtr elements, int mode)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseFloatArrayElements (__info.EnvironmentPointer, array, elements, mode);
		}

		public static unsafe void ReleaseDoubleArrayElements (IntPtr array, IntPtr elements, int mode)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (elements == IntPtr.Zero)
				throw new ArgumentException ("'elements' must not be IntPtr.Zero.", "elements");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseDoubleArrayElements (__info.EnvironmentPointer, array, elements, mode);
		}

		public static unsafe void GetBooleanArrayRegion (IntPtr array, int start, int length, IntPtr buffer)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetBooleanArrayRegion (__info.EnvironmentPointer, array, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetByteArrayRegion (IntPtr array, int start, int length, IntPtr buffer)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetByteArrayRegion (__info.EnvironmentPointer, array, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetCharArrayRegion (IntPtr array, int start, int length, IntPtr buffer)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetCharArrayRegion (__info.EnvironmentPointer, array, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetShortArrayRegion (IntPtr array, int start, int length, IntPtr buffer)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetShortArrayRegion (__info.EnvironmentPointer, array, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetIntArrayRegion (IntPtr array, int start, int length, IntPtr buffer)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetIntArrayRegion (__info.EnvironmentPointer, array, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetLongArrayRegion (IntPtr array, int start, int length, IntPtr buffer)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetLongArrayRegion (__info.EnvironmentPointer, array, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetFloatArrayRegion (IntPtr array, int start, int length, IntPtr buffer)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetFloatArrayRegion (__info.EnvironmentPointer, array, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void GetDoubleArrayRegion (IntPtr array, int start, int length, IntPtr buffer)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.GetDoubleArrayRegion (__info.EnvironmentPointer, array, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetBooleanArrayRegion (IntPtr array, int start, int length, IntPtr buffer)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetBooleanArrayRegion (__info.EnvironmentPointer, array, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetByteArrayRegion (IntPtr array, int start, int length, IntPtr buffer)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetByteArrayRegion (__info.EnvironmentPointer, array, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetCharArrayRegion (IntPtr array, int start, int length, IntPtr buffer)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetCharArrayRegion (__info.EnvironmentPointer, array, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetShortArrayRegion (IntPtr array, int start, int length, IntPtr buffer)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetShortArrayRegion (__info.EnvironmentPointer, array, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetIntArrayRegion (IntPtr array, int start, int length, IntPtr buffer)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetIntArrayRegion (__info.EnvironmentPointer, array, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetLongArrayRegion (IntPtr array, int start, int length, IntPtr buffer)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetLongArrayRegion (__info.EnvironmentPointer, array, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetFloatArrayRegion (IntPtr array, int start, int length, IntPtr buffer)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetFloatArrayRegion (__info.EnvironmentPointer, array, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void SetDoubleArrayRegion (IntPtr array, int start, int length, IntPtr buffer)
		{
			if (array == IntPtr.Zero)
				throw new ArgumentException ("`array` must not be IntPtr.Zero.", "array");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetDoubleArrayRegion (__info.EnvironmentPointer, array, start, length, buffer);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}
	}

	public static partial class Exceptions {

		internal static unsafe int _Throw (IntPtr toThrow)
		{
			if (toThrow == IntPtr.Zero)
				throw new ArgumentException ("`toThrow` must not be IntPtr.Zero.", "toThrow");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.Throw (__info.EnvironmentPointer, toThrow);
			return tmp;
		}

		internal static unsafe int _ThrowNew (IntPtr type, string message)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (message == null)
				throw new ArgumentNullException ("message");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.ThrowNew (__info.EnvironmentPointer, type, message);
			return tmp;
		}

		public static unsafe IntPtr ExceptionOccurred ()
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.ExceptionOccurred (__info.EnvironmentPointer);
			return tmp;
		}

		public static unsafe void ExceptionDescribe ()
		{
			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ExceptionDescribe (__info.EnvironmentPointer);
		}

		public static unsafe void ExceptionClear ()
		{
			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ExceptionClear (__info.EnvironmentPointer);
		}

		public static unsafe void FatalError (string message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.FatalError (__info.EnvironmentPointer, message);
		}

		public static unsafe bool ExceptionCheck ()
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.ExceptionCheck (__info.EnvironmentPointer);
			return (tmp != 0) ? true : false;
		}
	}

	public static partial class InstanceFields {

		public static unsafe IntPtr GetFieldID (IntPtr type, string name, string signature)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (signature == null)
				throw new ArgumentNullException ("signature");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetFieldID (__info.EnvironmentPointer, type, name, signature);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe IntPtr GetObjectField (IntPtr instance, IntPtr field)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetObjectField (__info.EnvironmentPointer, instance, field);
			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe bool GetBooleanField (IntPtr instance, IntPtr field)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetBooleanField (__info.EnvironmentPointer, instance, field);
			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte GetByteField (IntPtr instance, IntPtr field)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetByteField (__info.EnvironmentPointer, instance, field);
			return tmp;
		}

		public static unsafe char GetCharField (IntPtr instance, IntPtr field)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetCharField (__info.EnvironmentPointer, instance, field);
			return tmp;
		}

		public static unsafe short GetShortField (IntPtr instance, IntPtr field)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetShortField (__info.EnvironmentPointer, instance, field);
			return tmp;
		}

		public static unsafe int GetIntField (IntPtr instance, IntPtr field)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetIntField (__info.EnvironmentPointer, instance, field);
			return tmp;
		}

		public static unsafe long GetLongField (IntPtr instance, IntPtr field)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetLongField (__info.EnvironmentPointer, instance, field);
			return tmp;
		}

		public static unsafe float GetFloatField (IntPtr instance, IntPtr field)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetFloatField (__info.EnvironmentPointer, instance, field);
			return tmp;
		}

		public static unsafe double GetDoubleField (IntPtr instance, IntPtr field)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetDoubleField (__info.EnvironmentPointer, instance, field);
			return tmp;
		}

		public static unsafe void SetObjectField (IntPtr instance, IntPtr field, IntPtr value)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetObjectField (__info.EnvironmentPointer, instance, field, value);
		}

		public static unsafe void SetBooleanField (IntPtr instance, IntPtr field, bool value)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetBooleanField (__info.EnvironmentPointer, instance, field, (value ? (byte) 1 : (byte) 0));
		}

		public static unsafe void SetByteField (IntPtr instance, IntPtr field, sbyte value)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetByteField (__info.EnvironmentPointer, instance, field, value);
		}

		public static unsafe void SetCharField (IntPtr instance, IntPtr field, char value)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetCharField (__info.EnvironmentPointer, instance, field, value);
		}

		public static unsafe void SetShortField (IntPtr instance, IntPtr field, short value)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetShortField (__info.EnvironmentPointer, instance, field, value);
		}

		public static unsafe void SetIntField (IntPtr instance, IntPtr field, int value)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetIntField (__info.EnvironmentPointer, instance, field, value);
		}

		public static unsafe void SetLongField (IntPtr instance, IntPtr field, long value)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetLongField (__info.EnvironmentPointer, instance, field, value);
		}

		public static unsafe void SetFloatField (IntPtr instance, IntPtr field, float value)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetFloatField (__info.EnvironmentPointer, instance, field, value);
		}

		public static unsafe void SetDoubleField (IntPtr instance, IntPtr field, double value)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetDoubleField (__info.EnvironmentPointer, instance, field, value);
		}
	}

	public static partial class InstanceMethods {

		public static unsafe IntPtr GetMethodID (IntPtr type, string name, string signature)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (signature == null)
				throw new ArgumentNullException ("signature");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetMethodID (__info.EnvironmentPointer, type, name, signature);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe IntPtr CallObjectMethod (IntPtr instance, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallObjectMethod (__info.EnvironmentPointer, instance, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe IntPtr CallObjectMethod (IntPtr instance, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallObjectMethodA (__info.EnvironmentPointer, instance, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe bool CallBooleanMethod (IntPtr instance, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallBooleanMethod (__info.EnvironmentPointer, instance, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe bool CallBooleanMethod (IntPtr instance, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallBooleanMethodA (__info.EnvironmentPointer, instance, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte CallByteMethod (IntPtr instance, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallByteMethod (__info.EnvironmentPointer, instance, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe sbyte CallByteMethod (IntPtr instance, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallByteMethodA (__info.EnvironmentPointer, instance, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallCharMethod (IntPtr instance, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallCharMethod (__info.EnvironmentPointer, instance, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallCharMethod (IntPtr instance, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallCharMethodA (__info.EnvironmentPointer, instance, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallShortMethod (IntPtr instance, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallShortMethod (__info.EnvironmentPointer, instance, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallShortMethod (IntPtr instance, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallShortMethodA (__info.EnvironmentPointer, instance, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallIntMethod (IntPtr instance, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallIntMethod (__info.EnvironmentPointer, instance, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallIntMethod (IntPtr instance, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallIntMethodA (__info.EnvironmentPointer, instance, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallLongMethod (IntPtr instance, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallLongMethod (__info.EnvironmentPointer, instance, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallLongMethod (IntPtr instance, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallLongMethodA (__info.EnvironmentPointer, instance, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallFloatMethod (IntPtr instance, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallFloatMethod (__info.EnvironmentPointer, instance, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallFloatMethod (IntPtr instance, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallFloatMethodA (__info.EnvironmentPointer, instance, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallDoubleMethod (IntPtr instance, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallDoubleMethod (__info.EnvironmentPointer, instance, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallDoubleMethod (IntPtr instance, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallDoubleMethodA (__info.EnvironmentPointer, instance, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe void CallVoidMethod (IntPtr instance, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallVoidMethod (__info.EnvironmentPointer, instance, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void CallVoidMethod (IntPtr instance, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallVoidMethodA (__info.EnvironmentPointer, instance, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe IntPtr CallNonvirtualObjectMethod (IntPtr instance, IntPtr type, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualObjectMethod (__info.EnvironmentPointer, instance, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe IntPtr CallNonvirtualObjectMethod (IntPtr instance, IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualObjectMethodA (__info.EnvironmentPointer, instance, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe bool CallNonvirtualBooleanMethod (IntPtr instance, IntPtr type, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualBooleanMethod (__info.EnvironmentPointer, instance, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe bool CallNonvirtualBooleanMethod (IntPtr instance, IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualBooleanMethodA (__info.EnvironmentPointer, instance, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte CallNonvirtualByteMethod (IntPtr instance, IntPtr type, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualByteMethod (__info.EnvironmentPointer, instance, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe sbyte CallNonvirtualByteMethod (IntPtr instance, IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualByteMethodA (__info.EnvironmentPointer, instance, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallNonvirtualCharMethod (IntPtr instance, IntPtr type, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualCharMethod (__info.EnvironmentPointer, instance, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallNonvirtualCharMethod (IntPtr instance, IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualCharMethodA (__info.EnvironmentPointer, instance, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallNonvirtualShortMethod (IntPtr instance, IntPtr type, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualShortMethod (__info.EnvironmentPointer, instance, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallNonvirtualShortMethod (IntPtr instance, IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualShortMethodA (__info.EnvironmentPointer, instance, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallNonvirtualIntMethod (IntPtr instance, IntPtr type, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualIntMethod (__info.EnvironmentPointer, instance, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallNonvirtualIntMethod (IntPtr instance, IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualIntMethodA (__info.EnvironmentPointer, instance, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallNonvirtualLongMethod (IntPtr instance, IntPtr type, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualLongMethod (__info.EnvironmentPointer, instance, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallNonvirtualLongMethod (IntPtr instance, IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualLongMethodA (__info.EnvironmentPointer, instance, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallNonvirtualFloatMethod (IntPtr instance, IntPtr type, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualFloatMethod (__info.EnvironmentPointer, instance, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallNonvirtualFloatMethod (IntPtr instance, IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualFloatMethodA (__info.EnvironmentPointer, instance, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallNonvirtualDoubleMethod (IntPtr instance, IntPtr type, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualDoubleMethod (__info.EnvironmentPointer, instance, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallNonvirtualDoubleMethod (IntPtr instance, IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallNonvirtualDoubleMethodA (__info.EnvironmentPointer, instance, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe void CallNonvirtualVoidMethod (IntPtr instance, IntPtr type, IntPtr method)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallNonvirtualVoidMethod (__info.EnvironmentPointer, instance, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void CallNonvirtualVoidMethod (IntPtr instance, IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallNonvirtualVoidMethodA (__info.EnvironmentPointer, instance, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}
	}

	public static partial class IO {

		public static unsafe IntPtr NewDirectByteBuffer (IntPtr address, long capacity)
		{
			if (address == IntPtr.Zero)
				throw new ArgumentException ("'address' must not be IntPtr.Zero.", "address");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewDirectByteBuffer (__info.EnvironmentPointer, address, capacity);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe IntPtr GetDirectBufferAddress (IntPtr buffer)
		{
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("`buffer` must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetDirectBufferAddress (__info.EnvironmentPointer, buffer);
			return tmp;
		}

		public static unsafe long GetDirectBufferCapacity (IntPtr buffer)
		{
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("`buffer` must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetDirectBufferCapacity (__info.EnvironmentPointer, buffer);
			return tmp;
		}
	}

	public static partial class Monitors {

		internal static unsafe int _MonitorEnter (IntPtr instance)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.MonitorEnter (__info.EnvironmentPointer, instance);
			return tmp;
		}

		internal static unsafe int _MonitorExit (IntPtr instance)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.MonitorExit (__info.EnvironmentPointer, instance);
			return tmp;
		}
	}

	public static partial class Object {

		public static unsafe IntPtr AllocObject (IntPtr type)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.AllocObject (__info.EnvironmentPointer, type);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe IntPtr NewObject (IntPtr type, IntPtr method)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewObject (__info.EnvironmentPointer, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe IntPtr NewObject (IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewObjectA (__info.EnvironmentPointer, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}
	}

	public static partial class References {

		internal static unsafe int _PushLocalFrame (int capacity)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.PushLocalFrame (__info.EnvironmentPointer, capacity);
			return tmp;
		}

		public static unsafe IntPtr PopLocalFrame (IntPtr result)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.PopLocalFrame (__info.EnvironmentPointer, result);
			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		internal static unsafe IntPtr NewGlobalRef (IntPtr instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewGlobalRef (__info.EnvironmentPointer, instance);
			return tmp;
		}

		internal static unsafe void DeleteGlobalRef (IntPtr instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.DeleteGlobalRef (__info.EnvironmentPointer, instance);
		}

		internal static unsafe void DeleteLocalRef (IntPtr instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.DeleteLocalRef (__info.EnvironmentPointer, instance);
		}

		internal static unsafe IntPtr NewLocalRef (IntPtr instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewLocalRef (__info.EnvironmentPointer, instance);
			return tmp;
		}

		internal static unsafe int _EnsureLocalCapacity (int capacity)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.EnsureLocalCapacity (__info.EnvironmentPointer, capacity);
			return tmp;
		}

		internal static unsafe int _GetJavaVM (out IntPtr vm)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetJavaVM (__info.EnvironmentPointer, out vm);
			return tmp;
		}

		internal static unsafe IntPtr NewWeakGlobalRef (IntPtr instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewWeakGlobalRef (__info.EnvironmentPointer, instance);
			return tmp;
		}

		internal static unsafe void DeleteWeakGlobalRef (IntPtr instance)
		{
			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.DeleteWeakGlobalRef (__info.EnvironmentPointer, instance);
		}

		internal static unsafe JniObjectReferenceType GetObjectRefType (IntPtr instance)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetObjectRefType (__info.EnvironmentPointer, instance);
			return tmp;
		}
	}

	internal static partial class Reflection {

		public static unsafe IntPtr ToReflectedMethod (IntPtr type, IntPtr method, bool isStatic)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.ToReflectedMethod (__info.EnvironmentPointer, type, method, (isStatic ? (byte) 1 : (byte) 0));

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe IntPtr ToReflectedField (IntPtr type, IntPtr field, bool isStatic)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.ToReflectedField (__info.EnvironmentPointer, type, field, (isStatic ? (byte) 1 : (byte) 0));

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}
	}

	public static partial class StaticFields {

		public static unsafe IntPtr GetStaticFieldID (IntPtr type, string name, string signature)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (signature == null)
				throw new ArgumentNullException ("signature");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticFieldID (__info.EnvironmentPointer, type, name, signature);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe IntPtr GetStaticObjectField (IntPtr type, IntPtr field)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticObjectField (__info.EnvironmentPointer, type, field);
			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe bool GetStaticBooleanField (IntPtr type, IntPtr field)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticBooleanField (__info.EnvironmentPointer, type, field);
			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte GetStaticByteField (IntPtr type, IntPtr field)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticByteField (__info.EnvironmentPointer, type, field);
			return tmp;
		}

		public static unsafe char GetStaticCharField (IntPtr type, IntPtr field)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticCharField (__info.EnvironmentPointer, type, field);
			return tmp;
		}

		public static unsafe short GetStaticShortField (IntPtr type, IntPtr field)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticShortField (__info.EnvironmentPointer, type, field);
			return tmp;
		}

		public static unsafe int GetStaticIntField (IntPtr type, IntPtr field)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticIntField (__info.EnvironmentPointer, type, field);
			return tmp;
		}

		public static unsafe long GetStaticLongField (IntPtr type, IntPtr field)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticLongField (__info.EnvironmentPointer, type, field);
			return tmp;
		}

		public static unsafe float GetStaticFloatField (IntPtr type, IntPtr field)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticFloatField (__info.EnvironmentPointer, type, field);
			return tmp;
		}

		public static unsafe double GetStaticDoubleField (IntPtr type, IntPtr field)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticDoubleField (__info.EnvironmentPointer, type, field);
			return tmp;
		}

		public static unsafe void SetStaticObjectField (IntPtr type, IntPtr field, IntPtr value)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticObjectField (__info.EnvironmentPointer, type, field, value);
		}

		public static unsafe void SetStaticBooleanField (IntPtr type, IntPtr field, bool value)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticBooleanField (__info.EnvironmentPointer, type, field, (value ? (byte) 1 : (byte) 0));
		}

		public static unsafe void SetStaticByteField (IntPtr type, IntPtr field, sbyte value)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticByteField (__info.EnvironmentPointer, type, field, value);
		}

		public static unsafe void SetStaticCharField (IntPtr type, IntPtr field, char value)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticCharField (__info.EnvironmentPointer, type, field, value);
		}

		public static unsafe void SetStaticShortField (IntPtr type, IntPtr field, short value)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticShortField (__info.EnvironmentPointer, type, field, value);
		}

		public static unsafe void SetStaticIntField (IntPtr type, IntPtr field, int value)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticIntField (__info.EnvironmentPointer, type, field, value);
		}

		public static unsafe void SetStaticLongField (IntPtr type, IntPtr field, long value)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticLongField (__info.EnvironmentPointer, type, field, value);
		}

		public static unsafe void SetStaticFloatField (IntPtr type, IntPtr field, float value)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticFloatField (__info.EnvironmentPointer, type, field, value);
		}

		public static unsafe void SetStaticDoubleField (IntPtr type, IntPtr field, double value)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (field == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "field");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.SetStaticDoubleField (__info.EnvironmentPointer, type, field, value);
		}
	}

	public static partial class StaticMethods {

		public static unsafe IntPtr GetStaticMethodID (IntPtr type, string name, string signature)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (signature == null)
				throw new ArgumentNullException ("signature");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStaticMethodID (__info.EnvironmentPointer, type, name, signature);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe IntPtr CallStaticObjectMethod (IntPtr type, IntPtr method)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticObjectMethod (__info.EnvironmentPointer, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe IntPtr CallStaticObjectMethod (IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticObjectMethodA (__info.EnvironmentPointer, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe bool CallStaticBooleanMethod (IntPtr type, IntPtr method)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticBooleanMethod (__info.EnvironmentPointer, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe bool CallStaticBooleanMethod (IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticBooleanMethodA (__info.EnvironmentPointer, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return (tmp != 0) ? true : false;
		}

		public static unsafe sbyte CallStaticByteMethod (IntPtr type, IntPtr method)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticByteMethod (__info.EnvironmentPointer, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe sbyte CallStaticByteMethod (IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticByteMethodA (__info.EnvironmentPointer, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallStaticCharMethod (IntPtr type, IntPtr method)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticCharMethod (__info.EnvironmentPointer, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe char CallStaticCharMethod (IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticCharMethodA (__info.EnvironmentPointer, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallStaticShortMethod (IntPtr type, IntPtr method)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticShortMethod (__info.EnvironmentPointer, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe short CallStaticShortMethod (IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticShortMethodA (__info.EnvironmentPointer, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallStaticIntMethod (IntPtr type, IntPtr method)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticIntMethod (__info.EnvironmentPointer, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe int CallStaticIntMethod (IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticIntMethodA (__info.EnvironmentPointer, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallStaticLongMethod (IntPtr type, IntPtr method)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticLongMethod (__info.EnvironmentPointer, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe long CallStaticLongMethod (IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticLongMethodA (__info.EnvironmentPointer, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallStaticFloatMethod (IntPtr type, IntPtr method)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticFloatMethod (__info.EnvironmentPointer, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe float CallStaticFloatMethod (IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticFloatMethodA (__info.EnvironmentPointer, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallStaticDoubleMethod (IntPtr type, IntPtr method)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticDoubleMethod (__info.EnvironmentPointer, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe double CallStaticDoubleMethod (IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.CallStaticDoubleMethodA (__info.EnvironmentPointer, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		public static unsafe void CallStaticVoidMethod (IntPtr type, IntPtr method)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallStaticVoidMethod (__info.EnvironmentPointer, type, method);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}

		public static unsafe void CallStaticVoidMethod (IntPtr type, IntPtr method, JniArgumentValue* args)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");
			if (method == IntPtr.Zero)
				throw new ArgumentException ("Handle value cannot be null.", "method");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.CallStaticVoidMethodA (__info.EnvironmentPointer, type, method, args);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

		}
	}

	public static partial class Strings {

		public static unsafe IntPtr NewString (IntPtr unicodeChars, int length)
		{
			if (unicodeChars == IntPtr.Zero)
				throw new ArgumentException ("'unicodeChars' must not be IntPtr.Zero.", "unicodeChars");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.NewString (__info.EnvironmentPointer, unicodeChars, length);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe int GetStringLength (IntPtr stringInstance)
		{
			if (stringInstance == IntPtr.Zero)
				throw new ArgumentException ("`stringInstance` must not be IntPtr.Zero.", "stringInstance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStringLength (__info.EnvironmentPointer, stringInstance);
			return tmp;
		}

		public static unsafe IntPtr GetStringChars (IntPtr stringInstance, IntPtr isCopy)
		{
			if (stringInstance == IntPtr.Zero)
				throw new ArgumentException ("`stringInstance` must not be IntPtr.Zero.", "stringInstance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetStringChars (__info.EnvironmentPointer, stringInstance, isCopy);
			return tmp;
		}

		public static unsafe void ReleaseStringChars (IntPtr stringInstance, IntPtr chars)
		{
			if (stringInstance == IntPtr.Zero)
				throw new ArgumentException ("`stringInstance` must not be IntPtr.Zero.", "stringInstance");
			if (chars == IntPtr.Zero)
				throw new ArgumentException ("'chars' must not be IntPtr.Zero.", "chars");

			var __info = JniEnvironment.CurrentInfo;
			__info.Invoker.ReleaseStringChars (__info.EnvironmentPointer, stringInstance, chars);
		}
	}

	public static partial class Types {

		public static unsafe IntPtr DefineClass (string name, IntPtr loader, IntPtr buffer, int bufferLength)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (loader == IntPtr.Zero)
				throw new ArgumentException ("`loader` must not be IntPtr.Zero.", "loader");
			if (buffer == IntPtr.Zero)
				throw new ArgumentException ("'buffer' must not be IntPtr.Zero.", "buffer");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.DefineClass (__info.EnvironmentPointer, name, loader, buffer, bufferLength);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		internal static unsafe IntPtr _FindClass (string classname)
		{
			if (classname == null)
				throw new ArgumentNullException ("classname");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.FindClass (__info.EnvironmentPointer, classname);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe IntPtr GetSuperclass (IntPtr type)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetSuperclass (__info.EnvironmentPointer, type);
			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe bool IsAssignableFrom (IntPtr class1, IntPtr class2)
		{
			if (class1 == IntPtr.Zero)
				throw new ArgumentException ("`class1` must not be IntPtr.Zero.", "class1");
			if (class2 == IntPtr.Zero)
				throw new ArgumentException ("`class2` must not be IntPtr.Zero.", "class2");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.IsAssignableFrom (__info.EnvironmentPointer, class1, class2);
			return (tmp != 0) ? true : false;
		}

		public static unsafe bool IsSameObject (IntPtr object1, IntPtr object2)
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.IsSameObject (__info.EnvironmentPointer, object1, object2);
			return (tmp != 0) ? true : false;
		}

		public static unsafe IntPtr GetObjectClass (IntPtr instance)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetObjectClass (__info.EnvironmentPointer, instance);
			JniEnvironment.LogCreateLocalRef (tmp);
			return tmp;
		}

		public static unsafe bool IsInstanceOf (IntPtr instance, IntPtr type)
		{
			if (instance == IntPtr.Zero)
				throw new ArgumentException ("`instance` must not be IntPtr.Zero.", "instance");
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.IsInstanceOf (__info.EnvironmentPointer, instance, type);
			return (tmp != 0) ? true : false;
		}

		internal static unsafe int _RegisterNatives (IntPtr type, JniNativeMethodRegistration [] methods, int numMethods)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.RegisterNatives (__info.EnvironmentPointer, type, methods, numMethods);

			Exception __e = JniEnvironment.GetExceptionForLastThrowable ();
			if (__e != null)
				ExceptionDispatchInfo.Capture (__e).Throw ();

			return tmp;
		}

		internal static unsafe int _UnregisterNatives (IntPtr type)
		{
			if (type == IntPtr.Zero)
				throw new ArgumentException ("`type` must not be IntPtr.Zero.", "type");

			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.UnregisterNatives (__info.EnvironmentPointer, type);
			return tmp;
		}
	}

	internal static partial class Versions {

		internal static unsafe int GetVersion ()
		{
			var __info = JniEnvironment.CurrentInfo;
			var tmp = __info.Invoker.GetVersion (__info.EnvironmentPointer);
			return tmp;
		}
	}
	}

	partial class JniEnvironmentInvoker {

		internal JniNativeInterfaceStruct env;

		public unsafe JniEnvironmentInvoker (JniNativeInterfaceStruct* p)
		{
			env = *p;
		}


		JniFunc_JNIEnvPtr_int _GetVersion;
		public JniFunc_JNIEnvPtr_int GetVersion {
			get {
				if (_GetVersion == null)
					_GetVersion = (JniFunc_JNIEnvPtr_int) Marshal.GetDelegateForFunctionPointer (env.GetVersion, typeof (JniFunc_JNIEnvPtr_int));
				return _GetVersion;
			}
		}

		JniFunc_JNIEnvPtr_string_jobject_IntPtr_int_jobject _DefineClass;
		public JniFunc_JNIEnvPtr_string_jobject_IntPtr_int_jobject DefineClass {
			get {
				if (_DefineClass == null)
					_DefineClass = (JniFunc_JNIEnvPtr_string_jobject_IntPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.DefineClass, typeof (JniFunc_JNIEnvPtr_string_jobject_IntPtr_int_jobject));
				return _DefineClass;
			}
		}

		JniFunc_JNIEnvPtr_string_jobject _FindClass;
		public JniFunc_JNIEnvPtr_string_jobject FindClass {
			get {
				if (_FindClass == null)
					_FindClass = (JniFunc_JNIEnvPtr_string_jobject) Marshal.GetDelegateForFunctionPointer (env.FindClass, typeof (JniFunc_JNIEnvPtr_string_jobject));
				return _FindClass;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr _FromReflectedMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr FromReflectedMethod {
			get {
				if (_FromReflectedMethod == null)
					_FromReflectedMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr) Marshal.GetDelegateForFunctionPointer (env.FromReflectedMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr));
				return _FromReflectedMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr _FromReflectedField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr FromReflectedField {
			get {
				if (_FromReflectedField == null)
					_FromReflectedField = (JniFunc_JNIEnvPtr_jobject_IntPtr) Marshal.GetDelegateForFunctionPointer (env.FromReflectedField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr));
				return _FromReflectedField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject _ToReflectedMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject ToReflectedMethod {
			get {
				if (_ToReflectedMethod == null)
					_ToReflectedMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject) Marshal.GetDelegateForFunctionPointer (env.ToReflectedMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject));
				return _ToReflectedMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject _GetSuperclass;
		public JniFunc_JNIEnvPtr_jobject_jobject GetSuperclass {
			get {
				if (_GetSuperclass == null)
					_GetSuperclass = (JniFunc_JNIEnvPtr_jobject_jobject) Marshal.GetDelegateForFunctionPointer (env.GetSuperclass, typeof (JniFunc_JNIEnvPtr_jobject_jobject));
				return _GetSuperclass;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_byte _IsAssignableFrom;
		public JniFunc_JNIEnvPtr_jobject_jobject_byte IsAssignableFrom {
			get {
				if (_IsAssignableFrom == null)
					_IsAssignableFrom = (JniFunc_JNIEnvPtr_jobject_jobject_byte) Marshal.GetDelegateForFunctionPointer (env.IsAssignableFrom, typeof (JniFunc_JNIEnvPtr_jobject_jobject_byte));
				return _IsAssignableFrom;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject _ToReflectedField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject ToReflectedField {
			get {
				if (_ToReflectedField == null)
					_ToReflectedField = (JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject) Marshal.GetDelegateForFunctionPointer (env.ToReflectedField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_byte_jobject));
				return _ToReflectedField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_int _Throw;
		public JniFunc_JNIEnvPtr_jobject_int Throw {
			get {
				if (_Throw == null)
					_Throw = (JniFunc_JNIEnvPtr_jobject_int) Marshal.GetDelegateForFunctionPointer (env.Throw, typeof (JniFunc_JNIEnvPtr_jobject_int));
				return _Throw;
			}
		}

		JniFunc_JNIEnvPtr_jobject_string_int _ThrowNew;
		public JniFunc_JNIEnvPtr_jobject_string_int ThrowNew {
			get {
				if (_ThrowNew == null)
					_ThrowNew = (JniFunc_JNIEnvPtr_jobject_string_int) Marshal.GetDelegateForFunctionPointer (env.ThrowNew, typeof (JniFunc_JNIEnvPtr_jobject_string_int));
				return _ThrowNew;
			}
		}

		JniFunc_JNIEnvPtr_jobject _ExceptionOccurred;
		public JniFunc_JNIEnvPtr_jobject ExceptionOccurred {
			get {
				if (_ExceptionOccurred == null)
					_ExceptionOccurred = (JniFunc_JNIEnvPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.ExceptionOccurred, typeof (JniFunc_JNIEnvPtr_jobject));
				return _ExceptionOccurred;
			}
		}

		JniAction_JNIEnvPtr _ExceptionDescribe;
		public JniAction_JNIEnvPtr ExceptionDescribe {
			get {
				if (_ExceptionDescribe == null)
					_ExceptionDescribe = (JniAction_JNIEnvPtr) Marshal.GetDelegateForFunctionPointer (env.ExceptionDescribe, typeof (JniAction_JNIEnvPtr));
				return _ExceptionDescribe;
			}
		}

		JniAction_JNIEnvPtr _ExceptionClear;
		public JniAction_JNIEnvPtr ExceptionClear {
			get {
				if (_ExceptionClear == null)
					_ExceptionClear = (JniAction_JNIEnvPtr) Marshal.GetDelegateForFunctionPointer (env.ExceptionClear, typeof (JniAction_JNIEnvPtr));
				return _ExceptionClear;
			}
		}

		JniAction_JNIEnvPtr_string _FatalError;
		public JniAction_JNIEnvPtr_string FatalError {
			get {
				if (_FatalError == null)
					_FatalError = (JniAction_JNIEnvPtr_string) Marshal.GetDelegateForFunctionPointer (env.FatalError, typeof (JniAction_JNIEnvPtr_string));
				return _FatalError;
			}
		}

		JniFunc_JNIEnvPtr_int_int _PushLocalFrame;
		public JniFunc_JNIEnvPtr_int_int PushLocalFrame {
			get {
				if (_PushLocalFrame == null)
					_PushLocalFrame = (JniFunc_JNIEnvPtr_int_int) Marshal.GetDelegateForFunctionPointer (env.PushLocalFrame, typeof (JniFunc_JNIEnvPtr_int_int));
				return _PushLocalFrame;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject _PopLocalFrame;
		public JniFunc_JNIEnvPtr_jobject_jobject PopLocalFrame {
			get {
				if (_PopLocalFrame == null)
					_PopLocalFrame = (JniFunc_JNIEnvPtr_jobject_jobject) Marshal.GetDelegateForFunctionPointer (env.PopLocalFrame, typeof (JniFunc_JNIEnvPtr_jobject_jobject));
				return _PopLocalFrame;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject _NewGlobalRef;
		public JniFunc_JNIEnvPtr_jobject_jobject NewGlobalRef {
			get {
				if (_NewGlobalRef == null)
					_NewGlobalRef = (JniFunc_JNIEnvPtr_jobject_jobject) Marshal.GetDelegateForFunctionPointer (env.NewGlobalRef, typeof (JniFunc_JNIEnvPtr_jobject_jobject));
				return _NewGlobalRef;
			}
		}

		JniAction_JNIEnvPtr_IntPtr _DeleteGlobalRef;
		public JniAction_JNIEnvPtr_IntPtr DeleteGlobalRef {
			get {
				if (_DeleteGlobalRef == null)
					_DeleteGlobalRef = (JniAction_JNIEnvPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.DeleteGlobalRef, typeof (JniAction_JNIEnvPtr_IntPtr));
				return _DeleteGlobalRef;
			}
		}

		JniAction_JNIEnvPtr_IntPtr _DeleteLocalRef;
		public JniAction_JNIEnvPtr_IntPtr DeleteLocalRef {
			get {
				if (_DeleteLocalRef == null)
					_DeleteLocalRef = (JniAction_JNIEnvPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.DeleteLocalRef, typeof (JniAction_JNIEnvPtr_IntPtr));
				return _DeleteLocalRef;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_byte _IsSameObject;
		public JniFunc_JNIEnvPtr_jobject_jobject_byte IsSameObject {
			get {
				if (_IsSameObject == null)
					_IsSameObject = (JniFunc_JNIEnvPtr_jobject_jobject_byte) Marshal.GetDelegateForFunctionPointer (env.IsSameObject, typeof (JniFunc_JNIEnvPtr_jobject_jobject_byte));
				return _IsSameObject;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject _NewLocalRef;
		public JniFunc_JNIEnvPtr_jobject_jobject NewLocalRef {
			get {
				if (_NewLocalRef == null)
					_NewLocalRef = (JniFunc_JNIEnvPtr_jobject_jobject) Marshal.GetDelegateForFunctionPointer (env.NewLocalRef, typeof (JniFunc_JNIEnvPtr_jobject_jobject));
				return _NewLocalRef;
			}
		}

		JniFunc_JNIEnvPtr_int_int _EnsureLocalCapacity;
		public JniFunc_JNIEnvPtr_int_int EnsureLocalCapacity {
			get {
				if (_EnsureLocalCapacity == null)
					_EnsureLocalCapacity = (JniFunc_JNIEnvPtr_int_int) Marshal.GetDelegateForFunctionPointer (env.EnsureLocalCapacity, typeof (JniFunc_JNIEnvPtr_int_int));
				return _EnsureLocalCapacity;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject _AllocObject;
		public JniFunc_JNIEnvPtr_jobject_jobject AllocObject {
			get {
				if (_AllocObject == null)
					_AllocObject = (JniFunc_JNIEnvPtr_jobject_jobject) Marshal.GetDelegateForFunctionPointer (env.AllocObject, typeof (JniFunc_JNIEnvPtr_jobject_jobject));
				return _AllocObject;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_jobject _NewObject;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_jobject NewObject {
			get {
				if (_NewObject == null)
					_NewObject = (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.NewObject, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject));
				return _NewObject;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject _NewObjectA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject NewObjectA {
			get {
				if (_NewObjectA == null)
					_NewObjectA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject) Marshal.GetDelegateForFunctionPointer (env.NewObjectA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject));
				return _NewObjectA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject _GetObjectClass;
		public JniFunc_JNIEnvPtr_jobject_jobject GetObjectClass {
			get {
				if (_GetObjectClass == null)
					_GetObjectClass = (JniFunc_JNIEnvPtr_jobject_jobject) Marshal.GetDelegateForFunctionPointer (env.GetObjectClass, typeof (JniFunc_JNIEnvPtr_jobject_jobject));
				return _GetObjectClass;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_byte _IsInstanceOf;
		public JniFunc_JNIEnvPtr_jobject_jobject_byte IsInstanceOf {
			get {
				if (_IsInstanceOf == null)
					_IsInstanceOf = (JniFunc_JNIEnvPtr_jobject_jobject_byte) Marshal.GetDelegateForFunctionPointer (env.IsInstanceOf, typeof (JniFunc_JNIEnvPtr_jobject_jobject_byte));
				return _IsInstanceOf;
			}
		}

		JniFunc_JNIEnvPtr_jobject_string_string_IntPtr _GetMethodID;
		public JniFunc_JNIEnvPtr_jobject_string_string_IntPtr GetMethodID {
			get {
				if (_GetMethodID == null)
					_GetMethodID = (JniFunc_JNIEnvPtr_jobject_string_string_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetMethodID, typeof (JniFunc_JNIEnvPtr_jobject_string_string_IntPtr));
				return _GetMethodID;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_jobject _CallObjectMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_jobject CallObjectMethod {
			get {
				if (_CallObjectMethod == null)
					_CallObjectMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.CallObjectMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject));
				return _CallObjectMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject _CallObjectMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject CallObjectMethodA {
			get {
				if (_CallObjectMethodA == null)
					_CallObjectMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject) Marshal.GetDelegateForFunctionPointer (env.CallObjectMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject));
				return _CallObjectMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_byte _CallBooleanMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_byte CallBooleanMethod {
			get {
				if (_CallBooleanMethod == null)
					_CallBooleanMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.CallBooleanMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_byte));
				return _CallBooleanMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte _CallBooleanMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte CallBooleanMethodA {
			get {
				if (_CallBooleanMethodA == null)
					_CallBooleanMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte) Marshal.GetDelegateForFunctionPointer (env.CallBooleanMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte));
				return _CallBooleanMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte _CallByteMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte CallByteMethod {
			get {
				if (_CallByteMethod == null)
					_CallByteMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallByteMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte));
				return _CallByteMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte _CallByteMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte CallByteMethodA {
			get {
				if (_CallByteMethodA == null)
					_CallByteMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallByteMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte));
				return _CallByteMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_char _CallCharMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_char CallCharMethod {
			get {
				if (_CallCharMethod == null)
					_CallCharMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.CallCharMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_char));
				return _CallCharMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char _CallCharMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char CallCharMethodA {
			get {
				if (_CallCharMethodA == null)
					_CallCharMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char) Marshal.GetDelegateForFunctionPointer (env.CallCharMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char));
				return _CallCharMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_short _CallShortMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_short CallShortMethod {
			get {
				if (_CallShortMethod == null)
					_CallShortMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.CallShortMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_short));
				return _CallShortMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short _CallShortMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short CallShortMethodA {
			get {
				if (_CallShortMethodA == null)
					_CallShortMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short) Marshal.GetDelegateForFunctionPointer (env.CallShortMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short));
				return _CallShortMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_int _CallIntMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_int CallIntMethod {
			get {
				if (_CallIntMethod == null)
					_CallIntMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.CallIntMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_int));
				return _CallIntMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int _CallIntMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int CallIntMethodA {
			get {
				if (_CallIntMethodA == null)
					_CallIntMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int) Marshal.GetDelegateForFunctionPointer (env.CallIntMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int));
				return _CallIntMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_long _CallLongMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_long CallLongMethod {
			get {
				if (_CallLongMethod == null)
					_CallLongMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.CallLongMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_long));
				return _CallLongMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long _CallLongMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long CallLongMethodA {
			get {
				if (_CallLongMethodA == null)
					_CallLongMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long) Marshal.GetDelegateForFunctionPointer (env.CallLongMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long));
				return _CallLongMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_float _CallFloatMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_float CallFloatMethod {
			get {
				if (_CallFloatMethod == null)
					_CallFloatMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.CallFloatMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_float));
				return _CallFloatMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float _CallFloatMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float CallFloatMethodA {
			get {
				if (_CallFloatMethodA == null)
					_CallFloatMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float) Marshal.GetDelegateForFunctionPointer (env.CallFloatMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float));
				return _CallFloatMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_double _CallDoubleMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_double CallDoubleMethod {
			get {
				if (_CallDoubleMethod == null)
					_CallDoubleMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.CallDoubleMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_double));
				return _CallDoubleMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double _CallDoubleMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double CallDoubleMethodA {
			get {
				if (_CallDoubleMethodA == null)
					_CallDoubleMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double) Marshal.GetDelegateForFunctionPointer (env.CallDoubleMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double));
				return _CallDoubleMethodA;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr _CallVoidMethod;
		public JniAction_JNIEnvPtr_jobject_IntPtr CallVoidMethod {
			get {
				if (_CallVoidMethod == null)
					_CallVoidMethod = (JniAction_JNIEnvPtr_jobject_IntPtr) Marshal.GetDelegateForFunctionPointer (env.CallVoidMethod, typeof (JniAction_JNIEnvPtr_jobject_IntPtr));
				return _CallVoidMethod;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef _CallVoidMethodA;
		public JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef CallVoidMethodA {
			get {
				if (_CallVoidMethodA == null)
					_CallVoidMethodA = (JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef) Marshal.GetDelegateForFunctionPointer (env.CallVoidMethodA, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef));
				return _CallVoidMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_jobject _CallNonvirtualObjectMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_jobject CallNonvirtualObjectMethod {
			get {
				if (_CallNonvirtualObjectMethod == null)
					_CallNonvirtualObjectMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualObjectMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_jobject));
				return _CallNonvirtualObjectMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_jobject _CallNonvirtualObjectMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_jobject CallNonvirtualObjectMethodA {
			get {
				if (_CallNonvirtualObjectMethodA == null)
					_CallNonvirtualObjectMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_jobject) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualObjectMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_jobject));
				return _CallNonvirtualObjectMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_byte _CallNonvirtualBooleanMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_byte CallNonvirtualBooleanMethod {
			get {
				if (_CallNonvirtualBooleanMethod == null)
					_CallNonvirtualBooleanMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualBooleanMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_byte));
				return _CallNonvirtualBooleanMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_byte _CallNonvirtualBooleanMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_byte CallNonvirtualBooleanMethodA {
			get {
				if (_CallNonvirtualBooleanMethodA == null)
					_CallNonvirtualBooleanMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_byte) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualBooleanMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_byte));
				return _CallNonvirtualBooleanMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_sbyte _CallNonvirtualByteMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_sbyte CallNonvirtualByteMethod {
			get {
				if (_CallNonvirtualByteMethod == null)
					_CallNonvirtualByteMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualByteMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_sbyte));
				return _CallNonvirtualByteMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_sbyte _CallNonvirtualByteMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_sbyte CallNonvirtualByteMethodA {
			get {
				if (_CallNonvirtualByteMethodA == null)
					_CallNonvirtualByteMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualByteMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_sbyte));
				return _CallNonvirtualByteMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_char _CallNonvirtualCharMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_char CallNonvirtualCharMethod {
			get {
				if (_CallNonvirtualCharMethod == null)
					_CallNonvirtualCharMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualCharMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_char));
				return _CallNonvirtualCharMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_char _CallNonvirtualCharMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_char CallNonvirtualCharMethodA {
			get {
				if (_CallNonvirtualCharMethodA == null)
					_CallNonvirtualCharMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_char) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualCharMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_char));
				return _CallNonvirtualCharMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_short _CallNonvirtualShortMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_short CallNonvirtualShortMethod {
			get {
				if (_CallNonvirtualShortMethod == null)
					_CallNonvirtualShortMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualShortMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_short));
				return _CallNonvirtualShortMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_short _CallNonvirtualShortMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_short CallNonvirtualShortMethodA {
			get {
				if (_CallNonvirtualShortMethodA == null)
					_CallNonvirtualShortMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_short) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualShortMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_short));
				return _CallNonvirtualShortMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_int _CallNonvirtualIntMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_int CallNonvirtualIntMethod {
			get {
				if (_CallNonvirtualIntMethod == null)
					_CallNonvirtualIntMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualIntMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_int));
				return _CallNonvirtualIntMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_int _CallNonvirtualIntMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_int CallNonvirtualIntMethodA {
			get {
				if (_CallNonvirtualIntMethodA == null)
					_CallNonvirtualIntMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_int) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualIntMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_int));
				return _CallNonvirtualIntMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_long _CallNonvirtualLongMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_long CallNonvirtualLongMethod {
			get {
				if (_CallNonvirtualLongMethod == null)
					_CallNonvirtualLongMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualLongMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_long));
				return _CallNonvirtualLongMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_long _CallNonvirtualLongMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_long CallNonvirtualLongMethodA {
			get {
				if (_CallNonvirtualLongMethodA == null)
					_CallNonvirtualLongMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_long) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualLongMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_long));
				return _CallNonvirtualLongMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_float _CallNonvirtualFloatMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_float CallNonvirtualFloatMethod {
			get {
				if (_CallNonvirtualFloatMethod == null)
					_CallNonvirtualFloatMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualFloatMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_float));
				return _CallNonvirtualFloatMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_float _CallNonvirtualFloatMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_float CallNonvirtualFloatMethodA {
			get {
				if (_CallNonvirtualFloatMethodA == null)
					_CallNonvirtualFloatMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_float) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualFloatMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_float));
				return _CallNonvirtualFloatMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_double _CallNonvirtualDoubleMethod;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_double CallNonvirtualDoubleMethod {
			get {
				if (_CallNonvirtualDoubleMethod == null)
					_CallNonvirtualDoubleMethod = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualDoubleMethod, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_double));
				return _CallNonvirtualDoubleMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_double _CallNonvirtualDoubleMethodA;
		public JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_double CallNonvirtualDoubleMethodA {
			get {
				if (_CallNonvirtualDoubleMethodA == null)
					_CallNonvirtualDoubleMethodA = (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_double) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualDoubleMethodA, typeof (JniFunc_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef_double));
				return _CallNonvirtualDoubleMethodA;
			}
		}

		JniAction_JNIEnvPtr_jobject_jobject_IntPtr _CallNonvirtualVoidMethod;
		public JniAction_JNIEnvPtr_jobject_jobject_IntPtr CallNonvirtualVoidMethod {
			get {
				if (_CallNonvirtualVoidMethod == null)
					_CallNonvirtualVoidMethod = (JniAction_JNIEnvPtr_jobject_jobject_IntPtr) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualVoidMethod, typeof (JniAction_JNIEnvPtr_jobject_jobject_IntPtr));
				return _CallNonvirtualVoidMethod;
			}
		}

		JniAction_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef _CallNonvirtualVoidMethodA;
		public JniAction_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef CallNonvirtualVoidMethodA {
			get {
				if (_CallNonvirtualVoidMethodA == null)
					_CallNonvirtualVoidMethodA = (JniAction_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef) Marshal.GetDelegateForFunctionPointer (env.CallNonvirtualVoidMethodA, typeof (JniAction_JNIEnvPtr_jobject_jobject_IntPtr_JniArgumentValueRef));
				return _CallNonvirtualVoidMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_string_string_IntPtr _GetFieldID;
		public JniFunc_JNIEnvPtr_jobject_string_string_IntPtr GetFieldID {
			get {
				if (_GetFieldID == null)
					_GetFieldID = (JniFunc_JNIEnvPtr_jobject_string_string_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetFieldID, typeof (JniFunc_JNIEnvPtr_jobject_string_string_IntPtr));
				return _GetFieldID;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_jobject _GetObjectField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_jobject GetObjectField {
			get {
				if (_GetObjectField == null)
					_GetObjectField = (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.GetObjectField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject));
				return _GetObjectField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_byte _GetBooleanField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_byte GetBooleanField {
			get {
				if (_GetBooleanField == null)
					_GetBooleanField = (JniFunc_JNIEnvPtr_jobject_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.GetBooleanField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_byte));
				return _GetBooleanField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte _GetByteField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte GetByteField {
			get {
				if (_GetByteField == null)
					_GetByteField = (JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.GetByteField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte));
				return _GetByteField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_char _GetCharField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_char GetCharField {
			get {
				if (_GetCharField == null)
					_GetCharField = (JniFunc_JNIEnvPtr_jobject_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.GetCharField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_char));
				return _GetCharField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_short _GetShortField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_short GetShortField {
			get {
				if (_GetShortField == null)
					_GetShortField = (JniFunc_JNIEnvPtr_jobject_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.GetShortField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_short));
				return _GetShortField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_int _GetIntField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_int GetIntField {
			get {
				if (_GetIntField == null)
					_GetIntField = (JniFunc_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.GetIntField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_int));
				return _GetIntField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_long _GetLongField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_long GetLongField {
			get {
				if (_GetLongField == null)
					_GetLongField = (JniFunc_JNIEnvPtr_jobject_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.GetLongField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_long));
				return _GetLongField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_float _GetFloatField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_float GetFloatField {
			get {
				if (_GetFloatField == null)
					_GetFloatField = (JniFunc_JNIEnvPtr_jobject_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.GetFloatField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_float));
				return _GetFloatField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_double _GetDoubleField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_double GetDoubleField {
			get {
				if (_GetDoubleField == null)
					_GetDoubleField = (JniFunc_JNIEnvPtr_jobject_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.GetDoubleField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_double));
				return _GetDoubleField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_jobject _SetObjectField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_jobject SetObjectField {
			get {
				if (_SetObjectField == null)
					_SetObjectField = (JniAction_JNIEnvPtr_jobject_IntPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.SetObjectField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_jobject));
				return _SetObjectField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_byte _SetBooleanField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_byte SetBooleanField {
			get {
				if (_SetBooleanField == null)
					_SetBooleanField = (JniAction_JNIEnvPtr_jobject_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.SetBooleanField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_byte));
				return _SetBooleanField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_sbyte _SetByteField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_sbyte SetByteField {
			get {
				if (_SetByteField == null)
					_SetByteField = (JniAction_JNIEnvPtr_jobject_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.SetByteField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_sbyte));
				return _SetByteField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_char _SetCharField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_char SetCharField {
			get {
				if (_SetCharField == null)
					_SetCharField = (JniAction_JNIEnvPtr_jobject_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.SetCharField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_char));
				return _SetCharField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_short _SetShortField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_short SetShortField {
			get {
				if (_SetShortField == null)
					_SetShortField = (JniAction_JNIEnvPtr_jobject_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.SetShortField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_short));
				return _SetShortField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _SetIntField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int SetIntField {
			get {
				if (_SetIntField == null)
					_SetIntField = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.SetIntField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _SetIntField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_long _SetLongField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_long SetLongField {
			get {
				if (_SetLongField == null)
					_SetLongField = (JniAction_JNIEnvPtr_jobject_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.SetLongField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_long));
				return _SetLongField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_float _SetFloatField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_float SetFloatField {
			get {
				if (_SetFloatField == null)
					_SetFloatField = (JniAction_JNIEnvPtr_jobject_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.SetFloatField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_float));
				return _SetFloatField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_double _SetDoubleField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_double SetDoubleField {
			get {
				if (_SetDoubleField == null)
					_SetDoubleField = (JniAction_JNIEnvPtr_jobject_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.SetDoubleField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_double));
				return _SetDoubleField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_string_string_IntPtr _GetStaticMethodID;
		public JniFunc_JNIEnvPtr_jobject_string_string_IntPtr GetStaticMethodID {
			get {
				if (_GetStaticMethodID == null)
					_GetStaticMethodID = (JniFunc_JNIEnvPtr_jobject_string_string_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetStaticMethodID, typeof (JniFunc_JNIEnvPtr_jobject_string_string_IntPtr));
				return _GetStaticMethodID;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_jobject _CallStaticObjectMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_jobject CallStaticObjectMethod {
			get {
				if (_CallStaticObjectMethod == null)
					_CallStaticObjectMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.CallStaticObjectMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject));
				return _CallStaticObjectMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject _CallStaticObjectMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject CallStaticObjectMethodA {
			get {
				if (_CallStaticObjectMethodA == null)
					_CallStaticObjectMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject) Marshal.GetDelegateForFunctionPointer (env.CallStaticObjectMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_jobject));
				return _CallStaticObjectMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_byte _CallStaticBooleanMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_byte CallStaticBooleanMethod {
			get {
				if (_CallStaticBooleanMethod == null)
					_CallStaticBooleanMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.CallStaticBooleanMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_byte));
				return _CallStaticBooleanMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte _CallStaticBooleanMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte CallStaticBooleanMethodA {
			get {
				if (_CallStaticBooleanMethodA == null)
					_CallStaticBooleanMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte) Marshal.GetDelegateForFunctionPointer (env.CallStaticBooleanMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_byte));
				return _CallStaticBooleanMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte _CallStaticByteMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte CallStaticByteMethod {
			get {
				if (_CallStaticByteMethod == null)
					_CallStaticByteMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallStaticByteMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte));
				return _CallStaticByteMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte _CallStaticByteMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte CallStaticByteMethodA {
			get {
				if (_CallStaticByteMethodA == null)
					_CallStaticByteMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte) Marshal.GetDelegateForFunctionPointer (env.CallStaticByteMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_sbyte));
				return _CallStaticByteMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_char _CallStaticCharMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_char CallStaticCharMethod {
			get {
				if (_CallStaticCharMethod == null)
					_CallStaticCharMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.CallStaticCharMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_char));
				return _CallStaticCharMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char _CallStaticCharMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char CallStaticCharMethodA {
			get {
				if (_CallStaticCharMethodA == null)
					_CallStaticCharMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char) Marshal.GetDelegateForFunctionPointer (env.CallStaticCharMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_char));
				return _CallStaticCharMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_short _CallStaticShortMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_short CallStaticShortMethod {
			get {
				if (_CallStaticShortMethod == null)
					_CallStaticShortMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.CallStaticShortMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_short));
				return _CallStaticShortMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short _CallStaticShortMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short CallStaticShortMethodA {
			get {
				if (_CallStaticShortMethodA == null)
					_CallStaticShortMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short) Marshal.GetDelegateForFunctionPointer (env.CallStaticShortMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_short));
				return _CallStaticShortMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_int _CallStaticIntMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_int CallStaticIntMethod {
			get {
				if (_CallStaticIntMethod == null)
					_CallStaticIntMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.CallStaticIntMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_int));
				return _CallStaticIntMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int _CallStaticIntMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int CallStaticIntMethodA {
			get {
				if (_CallStaticIntMethodA == null)
					_CallStaticIntMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int) Marshal.GetDelegateForFunctionPointer (env.CallStaticIntMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_int));
				return _CallStaticIntMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_long _CallStaticLongMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_long CallStaticLongMethod {
			get {
				if (_CallStaticLongMethod == null)
					_CallStaticLongMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.CallStaticLongMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_long));
				return _CallStaticLongMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long _CallStaticLongMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long CallStaticLongMethodA {
			get {
				if (_CallStaticLongMethodA == null)
					_CallStaticLongMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long) Marshal.GetDelegateForFunctionPointer (env.CallStaticLongMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_long));
				return _CallStaticLongMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_float _CallStaticFloatMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_float CallStaticFloatMethod {
			get {
				if (_CallStaticFloatMethod == null)
					_CallStaticFloatMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.CallStaticFloatMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_float));
				return _CallStaticFloatMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float _CallStaticFloatMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float CallStaticFloatMethodA {
			get {
				if (_CallStaticFloatMethodA == null)
					_CallStaticFloatMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float) Marshal.GetDelegateForFunctionPointer (env.CallStaticFloatMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_float));
				return _CallStaticFloatMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_double _CallStaticDoubleMethod;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_double CallStaticDoubleMethod {
			get {
				if (_CallStaticDoubleMethod == null)
					_CallStaticDoubleMethod = (JniFunc_JNIEnvPtr_jobject_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.CallStaticDoubleMethod, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_double));
				return _CallStaticDoubleMethod;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double _CallStaticDoubleMethodA;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double CallStaticDoubleMethodA {
			get {
				if (_CallStaticDoubleMethodA == null)
					_CallStaticDoubleMethodA = (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double) Marshal.GetDelegateForFunctionPointer (env.CallStaticDoubleMethodA, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef_double));
				return _CallStaticDoubleMethodA;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr _CallStaticVoidMethod;
		public JniAction_JNIEnvPtr_jobject_IntPtr CallStaticVoidMethod {
			get {
				if (_CallStaticVoidMethod == null)
					_CallStaticVoidMethod = (JniAction_JNIEnvPtr_jobject_IntPtr) Marshal.GetDelegateForFunctionPointer (env.CallStaticVoidMethod, typeof (JniAction_JNIEnvPtr_jobject_IntPtr));
				return _CallStaticVoidMethod;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef _CallStaticVoidMethodA;
		public JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef CallStaticVoidMethodA {
			get {
				if (_CallStaticVoidMethodA == null)
					_CallStaticVoidMethodA = (JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef) Marshal.GetDelegateForFunctionPointer (env.CallStaticVoidMethodA, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_JniArgumentValueRef));
				return _CallStaticVoidMethodA;
			}
		}

		JniFunc_JNIEnvPtr_jobject_string_string_IntPtr _GetStaticFieldID;
		public JniFunc_JNIEnvPtr_jobject_string_string_IntPtr GetStaticFieldID {
			get {
				if (_GetStaticFieldID == null)
					_GetStaticFieldID = (JniFunc_JNIEnvPtr_jobject_string_string_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetStaticFieldID, typeof (JniFunc_JNIEnvPtr_jobject_string_string_IntPtr));
				return _GetStaticFieldID;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_jobject _GetStaticObjectField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_jobject GetStaticObjectField {
			get {
				if (_GetStaticObjectField == null)
					_GetStaticObjectField = (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.GetStaticObjectField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_jobject));
				return _GetStaticObjectField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_byte _GetStaticBooleanField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_byte GetStaticBooleanField {
			get {
				if (_GetStaticBooleanField == null)
					_GetStaticBooleanField = (JniFunc_JNIEnvPtr_jobject_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.GetStaticBooleanField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_byte));
				return _GetStaticBooleanField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte _GetStaticByteField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte GetStaticByteField {
			get {
				if (_GetStaticByteField == null)
					_GetStaticByteField = (JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.GetStaticByteField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_sbyte));
				return _GetStaticByteField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_char _GetStaticCharField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_char GetStaticCharField {
			get {
				if (_GetStaticCharField == null)
					_GetStaticCharField = (JniFunc_JNIEnvPtr_jobject_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.GetStaticCharField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_char));
				return _GetStaticCharField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_short _GetStaticShortField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_short GetStaticShortField {
			get {
				if (_GetStaticShortField == null)
					_GetStaticShortField = (JniFunc_JNIEnvPtr_jobject_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.GetStaticShortField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_short));
				return _GetStaticShortField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_int _GetStaticIntField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_int GetStaticIntField {
			get {
				if (_GetStaticIntField == null)
					_GetStaticIntField = (JniFunc_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.GetStaticIntField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_int));
				return _GetStaticIntField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_long _GetStaticLongField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_long GetStaticLongField {
			get {
				if (_GetStaticLongField == null)
					_GetStaticLongField = (JniFunc_JNIEnvPtr_jobject_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.GetStaticLongField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_long));
				return _GetStaticLongField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_float _GetStaticFloatField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_float GetStaticFloatField {
			get {
				if (_GetStaticFloatField == null)
					_GetStaticFloatField = (JniFunc_JNIEnvPtr_jobject_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.GetStaticFloatField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_float));
				return _GetStaticFloatField;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_double _GetStaticDoubleField;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_double GetStaticDoubleField {
			get {
				if (_GetStaticDoubleField == null)
					_GetStaticDoubleField = (JniFunc_JNIEnvPtr_jobject_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.GetStaticDoubleField, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_double));
				return _GetStaticDoubleField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_jobject _SetStaticObjectField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_jobject SetStaticObjectField {
			get {
				if (_SetStaticObjectField == null)
					_SetStaticObjectField = (JniAction_JNIEnvPtr_jobject_IntPtr_jobject) Marshal.GetDelegateForFunctionPointer (env.SetStaticObjectField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_jobject));
				return _SetStaticObjectField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_byte _SetStaticBooleanField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_byte SetStaticBooleanField {
			get {
				if (_SetStaticBooleanField == null)
					_SetStaticBooleanField = (JniAction_JNIEnvPtr_jobject_IntPtr_byte) Marshal.GetDelegateForFunctionPointer (env.SetStaticBooleanField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_byte));
				return _SetStaticBooleanField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_sbyte _SetStaticByteField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_sbyte SetStaticByteField {
			get {
				if (_SetStaticByteField == null)
					_SetStaticByteField = (JniAction_JNIEnvPtr_jobject_IntPtr_sbyte) Marshal.GetDelegateForFunctionPointer (env.SetStaticByteField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_sbyte));
				return _SetStaticByteField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_char _SetStaticCharField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_char SetStaticCharField {
			get {
				if (_SetStaticCharField == null)
					_SetStaticCharField = (JniAction_JNIEnvPtr_jobject_IntPtr_char) Marshal.GetDelegateForFunctionPointer (env.SetStaticCharField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_char));
				return _SetStaticCharField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_short _SetStaticShortField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_short SetStaticShortField {
			get {
				if (_SetStaticShortField == null)
					_SetStaticShortField = (JniAction_JNIEnvPtr_jobject_IntPtr_short) Marshal.GetDelegateForFunctionPointer (env.SetStaticShortField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_short));
				return _SetStaticShortField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _SetStaticIntField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int SetStaticIntField {
			get {
				if (_SetStaticIntField == null)
					_SetStaticIntField = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.SetStaticIntField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _SetStaticIntField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_long _SetStaticLongField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_long SetStaticLongField {
			get {
				if (_SetStaticLongField == null)
					_SetStaticLongField = (JniAction_JNIEnvPtr_jobject_IntPtr_long) Marshal.GetDelegateForFunctionPointer (env.SetStaticLongField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_long));
				return _SetStaticLongField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_float _SetStaticFloatField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_float SetStaticFloatField {
			get {
				if (_SetStaticFloatField == null)
					_SetStaticFloatField = (JniAction_JNIEnvPtr_jobject_IntPtr_float) Marshal.GetDelegateForFunctionPointer (env.SetStaticFloatField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_float));
				return _SetStaticFloatField;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_double _SetStaticDoubleField;
		public JniAction_JNIEnvPtr_jobject_IntPtr_double SetStaticDoubleField {
			get {
				if (_SetStaticDoubleField == null)
					_SetStaticDoubleField = (JniAction_JNIEnvPtr_jobject_IntPtr_double) Marshal.GetDelegateForFunctionPointer (env.SetStaticDoubleField, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_double));
				return _SetStaticDoubleField;
			}
		}

		JniFunc_JNIEnvPtr_IntPtr_int_jobject _NewString;
		public JniFunc_JNIEnvPtr_IntPtr_int_jobject NewString {
			get {
				if (_NewString == null)
					_NewString = (JniFunc_JNIEnvPtr_IntPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewString, typeof (JniFunc_JNIEnvPtr_IntPtr_int_jobject));
				return _NewString;
			}
		}

		JniFunc_JNIEnvPtr_jobject_int _GetStringLength;
		public JniFunc_JNIEnvPtr_jobject_int GetStringLength {
			get {
				if (_GetStringLength == null)
					_GetStringLength = (JniFunc_JNIEnvPtr_jobject_int) Marshal.GetDelegateForFunctionPointer (env.GetStringLength, typeof (JniFunc_JNIEnvPtr_jobject_int));
				return _GetStringLength;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetStringChars;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetStringChars {
			get {
				if (_GetStringChars == null)
					_GetStringChars = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetStringChars, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetStringChars;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr _ReleaseStringChars;
		public JniAction_JNIEnvPtr_jobject_IntPtr ReleaseStringChars {
			get {
				if (_ReleaseStringChars == null)
					_ReleaseStringChars = (JniAction_JNIEnvPtr_jobject_IntPtr) Marshal.GetDelegateForFunctionPointer (env.ReleaseStringChars, typeof (JniAction_JNIEnvPtr_jobject_IntPtr));
				return _ReleaseStringChars;
			}
		}

		JniFunc_JNIEnvPtr_string_jobject _NewStringUTF;
		public JniFunc_JNIEnvPtr_string_jobject NewStringUTF {
			get {
				if (_NewStringUTF == null)
					_NewStringUTF = (JniFunc_JNIEnvPtr_string_jobject) Marshal.GetDelegateForFunctionPointer (env.NewStringUTF, typeof (JniFunc_JNIEnvPtr_string_jobject));
				return _NewStringUTF;
			}
		}

		JniFunc_JNIEnvPtr_jobject_int _GetStringUTFLength;
		public JniFunc_JNIEnvPtr_jobject_int GetStringUTFLength {
			get {
				if (_GetStringUTFLength == null)
					_GetStringUTFLength = (JniFunc_JNIEnvPtr_jobject_int) Marshal.GetDelegateForFunctionPointer (env.GetStringUTFLength, typeof (JniFunc_JNIEnvPtr_jobject_int));
				return _GetStringUTFLength;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_string _GetStringUTFChars;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_string GetStringUTFChars {
			get {
				if (_GetStringUTFChars == null)
					_GetStringUTFChars = (JniFunc_JNIEnvPtr_jobject_IntPtr_string) Marshal.GetDelegateForFunctionPointer (env.GetStringUTFChars, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_string));
				return _GetStringUTFChars;
			}
		}

		JniAction_JNIEnvPtr_jobject_string _ReleaseStringUTFChars;
		public JniAction_JNIEnvPtr_jobject_string ReleaseStringUTFChars {
			get {
				if (_ReleaseStringUTFChars == null)
					_ReleaseStringUTFChars = (JniAction_JNIEnvPtr_jobject_string) Marshal.GetDelegateForFunctionPointer (env.ReleaseStringUTFChars, typeof (JniAction_JNIEnvPtr_jobject_string));
				return _ReleaseStringUTFChars;
			}
		}

		JniFunc_JNIEnvPtr_jobject_int _GetArrayLength;
		public JniFunc_JNIEnvPtr_jobject_int GetArrayLength {
			get {
				if (_GetArrayLength == null)
					_GetArrayLength = (JniFunc_JNIEnvPtr_jobject_int) Marshal.GetDelegateForFunctionPointer (env.GetArrayLength, typeof (JniFunc_JNIEnvPtr_jobject_int));
				return _GetArrayLength;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject_jobject_jobject _NewObjectArray;
		public JniFunc_JNIEnvPtr_int_jobject_jobject_jobject NewObjectArray {
			get {
				if (_NewObjectArray == null)
					_NewObjectArray = (JniFunc_JNIEnvPtr_int_jobject_jobject_jobject) Marshal.GetDelegateForFunctionPointer (env.NewObjectArray, typeof (JniFunc_JNIEnvPtr_int_jobject_jobject_jobject));
				return _NewObjectArray;
			}
		}

		JniFunc_JNIEnvPtr_jobject_int_jobject _GetObjectArrayElement;
		public JniFunc_JNIEnvPtr_jobject_int_jobject GetObjectArrayElement {
			get {
				if (_GetObjectArrayElement == null)
					_GetObjectArrayElement = (JniFunc_JNIEnvPtr_jobject_int_jobject) Marshal.GetDelegateForFunctionPointer (env.GetObjectArrayElement, typeof (JniFunc_JNIEnvPtr_jobject_int_jobject));
				return _GetObjectArrayElement;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_jobject _SetObjectArrayElement;
		public JniAction_JNIEnvPtr_jobject_int_jobject SetObjectArrayElement {
			get {
				if (_SetObjectArrayElement == null)
					_SetObjectArrayElement = (JniAction_JNIEnvPtr_jobject_int_jobject) Marshal.GetDelegateForFunctionPointer (env.SetObjectArrayElement, typeof (JniAction_JNIEnvPtr_jobject_int_jobject));
				return _SetObjectArrayElement;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject _NewBooleanArray;
		public JniFunc_JNIEnvPtr_int_jobject NewBooleanArray {
			get {
				if (_NewBooleanArray == null)
					_NewBooleanArray = (JniFunc_JNIEnvPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewBooleanArray, typeof (JniFunc_JNIEnvPtr_int_jobject));
				return _NewBooleanArray;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject _NewByteArray;
		public JniFunc_JNIEnvPtr_int_jobject NewByteArray {
			get {
				if (_NewByteArray == null)
					_NewByteArray = (JniFunc_JNIEnvPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewByteArray, typeof (JniFunc_JNIEnvPtr_int_jobject));
				return _NewByteArray;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject _NewCharArray;
		public JniFunc_JNIEnvPtr_int_jobject NewCharArray {
			get {
				if (_NewCharArray == null)
					_NewCharArray = (JniFunc_JNIEnvPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewCharArray, typeof (JniFunc_JNIEnvPtr_int_jobject));
				return _NewCharArray;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject _NewShortArray;
		public JniFunc_JNIEnvPtr_int_jobject NewShortArray {
			get {
				if (_NewShortArray == null)
					_NewShortArray = (JniFunc_JNIEnvPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewShortArray, typeof (JniFunc_JNIEnvPtr_int_jobject));
				return _NewShortArray;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject _NewIntArray;
		public JniFunc_JNIEnvPtr_int_jobject NewIntArray {
			get {
				if (_NewIntArray == null)
					_NewIntArray = (JniFunc_JNIEnvPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewIntArray, typeof (JniFunc_JNIEnvPtr_int_jobject));
				return _NewIntArray;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject _NewLongArray;
		public JniFunc_JNIEnvPtr_int_jobject NewLongArray {
			get {
				if (_NewLongArray == null)
					_NewLongArray = (JniFunc_JNIEnvPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewLongArray, typeof (JniFunc_JNIEnvPtr_int_jobject));
				return _NewLongArray;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject _NewFloatArray;
		public JniFunc_JNIEnvPtr_int_jobject NewFloatArray {
			get {
				if (_NewFloatArray == null)
					_NewFloatArray = (JniFunc_JNIEnvPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewFloatArray, typeof (JniFunc_JNIEnvPtr_int_jobject));
				return _NewFloatArray;
			}
		}

		JniFunc_JNIEnvPtr_int_jobject _NewDoubleArray;
		public JniFunc_JNIEnvPtr_int_jobject NewDoubleArray {
			get {
				if (_NewDoubleArray == null)
					_NewDoubleArray = (JniFunc_JNIEnvPtr_int_jobject) Marshal.GetDelegateForFunctionPointer (env.NewDoubleArray, typeof (JniFunc_JNIEnvPtr_int_jobject));
				return _NewDoubleArray;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetBooleanArrayElements;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetBooleanArrayElements {
			get {
				if (_GetBooleanArrayElements == null)
					_GetBooleanArrayElements = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetBooleanArrayElements, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetBooleanArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetByteArrayElements;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetByteArrayElements {
			get {
				if (_GetByteArrayElements == null)
					_GetByteArrayElements = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetByteArrayElements, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetByteArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetCharArrayElements;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetCharArrayElements {
			get {
				if (_GetCharArrayElements == null)
					_GetCharArrayElements = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetCharArrayElements, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetCharArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetShortArrayElements;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetShortArrayElements {
			get {
				if (_GetShortArrayElements == null)
					_GetShortArrayElements = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetShortArrayElements, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetShortArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetIntArrayElements;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetIntArrayElements {
			get {
				if (_GetIntArrayElements == null)
					_GetIntArrayElements = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetIntArrayElements, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetIntArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetLongArrayElements;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetLongArrayElements {
			get {
				if (_GetLongArrayElements == null)
					_GetLongArrayElements = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetLongArrayElements, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetLongArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetFloatArrayElements;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetFloatArrayElements {
			get {
				if (_GetFloatArrayElements == null)
					_GetFloatArrayElements = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetFloatArrayElements, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetFloatArrayElements;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetDoubleArrayElements;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetDoubleArrayElements {
			get {
				if (_GetDoubleArrayElements == null)
					_GetDoubleArrayElements = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetDoubleArrayElements, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetDoubleArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleaseBooleanArrayElements;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleaseBooleanArrayElements {
			get {
				if (_ReleaseBooleanArrayElements == null)
					_ReleaseBooleanArrayElements = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseBooleanArrayElements, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleaseBooleanArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleaseByteArrayElements;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleaseByteArrayElements {
			get {
				if (_ReleaseByteArrayElements == null)
					_ReleaseByteArrayElements = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseByteArrayElements, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleaseByteArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleaseCharArrayElements;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleaseCharArrayElements {
			get {
				if (_ReleaseCharArrayElements == null)
					_ReleaseCharArrayElements = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseCharArrayElements, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleaseCharArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleaseShortArrayElements;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleaseShortArrayElements {
			get {
				if (_ReleaseShortArrayElements == null)
					_ReleaseShortArrayElements = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseShortArrayElements, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleaseShortArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleaseIntArrayElements;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleaseIntArrayElements {
			get {
				if (_ReleaseIntArrayElements == null)
					_ReleaseIntArrayElements = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseIntArrayElements, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleaseIntArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleaseLongArrayElements;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleaseLongArrayElements {
			get {
				if (_ReleaseLongArrayElements == null)
					_ReleaseLongArrayElements = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseLongArrayElements, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleaseLongArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleaseFloatArrayElements;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleaseFloatArrayElements {
			get {
				if (_ReleaseFloatArrayElements == null)
					_ReleaseFloatArrayElements = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseFloatArrayElements, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleaseFloatArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleaseDoubleArrayElements;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleaseDoubleArrayElements {
			get {
				if (_ReleaseDoubleArrayElements == null)
					_ReleaseDoubleArrayElements = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleaseDoubleArrayElements, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleaseDoubleArrayElements;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetBooleanArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetBooleanArrayRegion {
			get {
				if (_GetBooleanArrayRegion == null)
					_GetBooleanArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetBooleanArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetBooleanArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetByteArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetByteArrayRegion {
			get {
				if (_GetByteArrayRegion == null)
					_GetByteArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetByteArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetByteArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetCharArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetCharArrayRegion {
			get {
				if (_GetCharArrayRegion == null)
					_GetCharArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetCharArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetCharArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetShortArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetShortArrayRegion {
			get {
				if (_GetShortArrayRegion == null)
					_GetShortArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetShortArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetShortArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetIntArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetIntArrayRegion {
			get {
				if (_GetIntArrayRegion == null)
					_GetIntArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetIntArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetIntArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetLongArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetLongArrayRegion {
			get {
				if (_GetLongArrayRegion == null)
					_GetLongArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetLongArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetLongArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetFloatArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetFloatArrayRegion {
			get {
				if (_GetFloatArrayRegion == null)
					_GetFloatArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetFloatArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetFloatArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetDoubleArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetDoubleArrayRegion {
			get {
				if (_GetDoubleArrayRegion == null)
					_GetDoubleArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetDoubleArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetDoubleArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _SetBooleanArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr SetBooleanArrayRegion {
			get {
				if (_SetBooleanArrayRegion == null)
					_SetBooleanArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetBooleanArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _SetBooleanArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _SetByteArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr SetByteArrayRegion {
			get {
				if (_SetByteArrayRegion == null)
					_SetByteArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetByteArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _SetByteArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _SetCharArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr SetCharArrayRegion {
			get {
				if (_SetCharArrayRegion == null)
					_SetCharArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetCharArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _SetCharArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _SetShortArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr SetShortArrayRegion {
			get {
				if (_SetShortArrayRegion == null)
					_SetShortArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetShortArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _SetShortArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _SetIntArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr SetIntArrayRegion {
			get {
				if (_SetIntArrayRegion == null)
					_SetIntArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetIntArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _SetIntArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _SetLongArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr SetLongArrayRegion {
			get {
				if (_SetLongArrayRegion == null)
					_SetLongArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetLongArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _SetLongArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _SetFloatArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr SetFloatArrayRegion {
			get {
				if (_SetFloatArrayRegion == null)
					_SetFloatArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetFloatArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _SetFloatArrayRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _SetDoubleArrayRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr SetDoubleArrayRegion {
			get {
				if (_SetDoubleArrayRegion == null)
					_SetDoubleArrayRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.SetDoubleArrayRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _SetDoubleArrayRegion;
			}
		}

		JniFunc_JNIEnvPtr_jobject_JniNativeMethodRegistrationArray_int_int _RegisterNatives;
		public JniFunc_JNIEnvPtr_jobject_JniNativeMethodRegistrationArray_int_int RegisterNatives {
			get {
				if (_RegisterNatives == null)
					_RegisterNatives = (JniFunc_JNIEnvPtr_jobject_JniNativeMethodRegistrationArray_int_int) Marshal.GetDelegateForFunctionPointer (env.RegisterNatives, typeof (JniFunc_JNIEnvPtr_jobject_JniNativeMethodRegistrationArray_int_int));
				return _RegisterNatives;
			}
		}

		JniFunc_JNIEnvPtr_jobject_int _UnregisterNatives;
		public JniFunc_JNIEnvPtr_jobject_int UnregisterNatives {
			get {
				if (_UnregisterNatives == null)
					_UnregisterNatives = (JniFunc_JNIEnvPtr_jobject_int) Marshal.GetDelegateForFunctionPointer (env.UnregisterNatives, typeof (JniFunc_JNIEnvPtr_jobject_int));
				return _UnregisterNatives;
			}
		}

		JniFunc_JNIEnvPtr_jobject_int _MonitorEnter;
		public JniFunc_JNIEnvPtr_jobject_int MonitorEnter {
			get {
				if (_MonitorEnter == null)
					_MonitorEnter = (JniFunc_JNIEnvPtr_jobject_int) Marshal.GetDelegateForFunctionPointer (env.MonitorEnter, typeof (JniFunc_JNIEnvPtr_jobject_int));
				return _MonitorEnter;
			}
		}

		JniFunc_JNIEnvPtr_jobject_int _MonitorExit;
		public JniFunc_JNIEnvPtr_jobject_int MonitorExit {
			get {
				if (_MonitorExit == null)
					_MonitorExit = (JniFunc_JNIEnvPtr_jobject_int) Marshal.GetDelegateForFunctionPointer (env.MonitorExit, typeof (JniFunc_JNIEnvPtr_jobject_int));
				return _MonitorExit;
			}
		}

		JniFunc_JNIEnvPtr_outIntPtr_int _GetJavaVM;
		public JniFunc_JNIEnvPtr_outIntPtr_int GetJavaVM {
			get {
				if (_GetJavaVM == null)
					_GetJavaVM = (JniFunc_JNIEnvPtr_outIntPtr_int) Marshal.GetDelegateForFunctionPointer (env.GetJavaVM, typeof (JniFunc_JNIEnvPtr_outIntPtr_int));
				return _GetJavaVM;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetStringRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetStringRegion {
			get {
				if (_GetStringRegion == null)
					_GetStringRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetStringRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetStringRegion;
			}
		}

		JniAction_JNIEnvPtr_jobject_int_int_IntPtr _GetStringUTFRegion;
		public JniAction_JNIEnvPtr_jobject_int_int_IntPtr GetStringUTFRegion {
			get {
				if (_GetStringUTFRegion == null)
					_GetStringUTFRegion = (JniAction_JNIEnvPtr_jobject_int_int_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetStringUTFRegion, typeof (JniAction_JNIEnvPtr_jobject_int_int_IntPtr));
				return _GetStringUTFRegion;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr _GetPrimitiveArrayCritical;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr GetPrimitiveArrayCritical {
			get {
				if (_GetPrimitiveArrayCritical == null)
					_GetPrimitiveArrayCritical = (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetPrimitiveArrayCritical, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_IntPtr));
				return _GetPrimitiveArrayCritical;
			}
		}

		JniAction_JNIEnvPtr_jobject_IntPtr_int _ReleasePrimitiveArrayCritical;
		public JniAction_JNIEnvPtr_jobject_IntPtr_int ReleasePrimitiveArrayCritical {
			get {
				if (_ReleasePrimitiveArrayCritical == null)
					_ReleasePrimitiveArrayCritical = (JniAction_JNIEnvPtr_jobject_IntPtr_int) Marshal.GetDelegateForFunctionPointer (env.ReleasePrimitiveArrayCritical, typeof (JniAction_JNIEnvPtr_jobject_IntPtr_int));
				return _ReleasePrimitiveArrayCritical;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr_string _GetStringCritical;
		public JniFunc_JNIEnvPtr_jobject_IntPtr_string GetStringCritical {
			get {
				if (_GetStringCritical == null)
					_GetStringCritical = (JniFunc_JNIEnvPtr_jobject_IntPtr_string) Marshal.GetDelegateForFunctionPointer (env.GetStringCritical, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr_string));
				return _GetStringCritical;
			}
		}

		JniAction_JNIEnvPtr_jobject_string _ReleaseStringCritical;
		public JniAction_JNIEnvPtr_jobject_string ReleaseStringCritical {
			get {
				if (_ReleaseStringCritical == null)
					_ReleaseStringCritical = (JniAction_JNIEnvPtr_jobject_string) Marshal.GetDelegateForFunctionPointer (env.ReleaseStringCritical, typeof (JniAction_JNIEnvPtr_jobject_string));
				return _ReleaseStringCritical;
			}
		}

		JniFunc_JNIEnvPtr_jobject_jobject _NewWeakGlobalRef;
		public JniFunc_JNIEnvPtr_jobject_jobject NewWeakGlobalRef {
			get {
				if (_NewWeakGlobalRef == null)
					_NewWeakGlobalRef = (JniFunc_JNIEnvPtr_jobject_jobject) Marshal.GetDelegateForFunctionPointer (env.NewWeakGlobalRef, typeof (JniFunc_JNIEnvPtr_jobject_jobject));
				return _NewWeakGlobalRef;
			}
		}

		JniAction_JNIEnvPtr_IntPtr _DeleteWeakGlobalRef;
		public JniAction_JNIEnvPtr_IntPtr DeleteWeakGlobalRef {
			get {
				if (_DeleteWeakGlobalRef == null)
					_DeleteWeakGlobalRef = (JniAction_JNIEnvPtr_IntPtr) Marshal.GetDelegateForFunctionPointer (env.DeleteWeakGlobalRef, typeof (JniAction_JNIEnvPtr_IntPtr));
				return _DeleteWeakGlobalRef;
			}
		}

		JniFunc_JNIEnvPtr_byte _ExceptionCheck;
		public JniFunc_JNIEnvPtr_byte ExceptionCheck {
			get {
				if (_ExceptionCheck == null)
					_ExceptionCheck = (JniFunc_JNIEnvPtr_byte) Marshal.GetDelegateForFunctionPointer (env.ExceptionCheck, typeof (JniFunc_JNIEnvPtr_byte));
				return _ExceptionCheck;
			}
		}

		JniFunc_JNIEnvPtr_IntPtr_long_jobject _NewDirectByteBuffer;
		public JniFunc_JNIEnvPtr_IntPtr_long_jobject NewDirectByteBuffer {
			get {
				if (_NewDirectByteBuffer == null)
					_NewDirectByteBuffer = (JniFunc_JNIEnvPtr_IntPtr_long_jobject) Marshal.GetDelegateForFunctionPointer (env.NewDirectByteBuffer, typeof (JniFunc_JNIEnvPtr_IntPtr_long_jobject));
				return _NewDirectByteBuffer;
			}
		}

		JniFunc_JNIEnvPtr_jobject_IntPtr _GetDirectBufferAddress;
		public JniFunc_JNIEnvPtr_jobject_IntPtr GetDirectBufferAddress {
			get {
				if (_GetDirectBufferAddress == null)
					_GetDirectBufferAddress = (JniFunc_JNIEnvPtr_jobject_IntPtr) Marshal.GetDelegateForFunctionPointer (env.GetDirectBufferAddress, typeof (JniFunc_JNIEnvPtr_jobject_IntPtr));
				return _GetDirectBufferAddress;
			}
		}

		JniFunc_JNIEnvPtr_jobject_long _GetDirectBufferCapacity;
		public JniFunc_JNIEnvPtr_jobject_long GetDirectBufferCapacity {
			get {
				if (_GetDirectBufferCapacity == null)
					_GetDirectBufferCapacity = (JniFunc_JNIEnvPtr_jobject_long) Marshal.GetDelegateForFunctionPointer (env.GetDirectBufferCapacity, typeof (JniFunc_JNIEnvPtr_jobject_long));
				return _GetDirectBufferCapacity;
			}
		}

		JniFunc_JNIEnvPtr_jobject_JniObjectReferenceType _GetObjectRefType;
		public JniFunc_JNIEnvPtr_jobject_JniObjectReferenceType GetObjectRefType {
			get {
				if (_GetObjectRefType == null)
					_GetObjectRefType = (JniFunc_JNIEnvPtr_jobject_JniObjectReferenceType) Marshal.GetDelegateForFunctionPointer (env.GetObjectRefType, typeof (JniFunc_JNIEnvPtr_jobject_JniObjectReferenceType));
				return _GetObjectRefType;
			}
		}
	}
}
#endif  // FEATURE_JNIENVIRONMENT_XA_INTPTRS
