//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;

using Z0;
using static Z0.ReflectionFlags;

partial class zfunc
{
    /// <summary>
    /// Gets the literal values for an enum type
    /// </summary>
    /// <typeparam name="T">The enum type</typeparam>
    public static IEnumerable<T> literals<T>()
        where T : Enum
            => type<T>().GetEnumValues().AsQueryable().Cast<T>();

    /// <summary>
    /// Gets the assembly in which the parametrized type is defined
    /// </summary>
    [MethodImpl(Inline)]
    public static Assembly assembly<T>()
        => typeof(T).Assembly;

    /// <summary>
    /// Specifies the generic type definition for a specified generic type
    /// </summary>
    /// <typeparam name="T">The generic type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Type typedef(Type t)
        => t.GetGenericTypeDefinition();

    /// <summary>
    /// Returns the name of the supplied type
    /// </summary>
    /// <param name="full">Whether the full name should be returned</param>
    /// <typeparam name="T">The type to examine</typeparam>
    [MethodImpl(Inline)]   
    public static string typename<T>(bool full = false)
        => full ? typeof(T).FullName : typeof(T).Name;

    [MethodImpl(Inline)]   
    public static string name<T>(bool full = false)
        => typeof(T).DisplayName();
    
    /// <summary>
    /// Returns the System.Type of the supplied parametric type
    /// </summary>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static Type type<T>() 
        => typeof(T);

    /// <summary>
    /// Determines whether a type is either a float or double
    /// </summary>
    /// <typeparam name="T">The type to test</typeparam>
    [MethodImpl(Inline)]
    public static bool isFloat<T>()
        where T : struct
            => typeof(T) == typeof(float) 
            || typeof(T) == typeof(double);

    /// <summary>
    /// Determines whether a type is a native integral type
    /// </summary>
    /// <typeparam name="T">The type to test</typeparam>
    [MethodImpl(Inline)]
    public static bool isIntegral<T>()
        where T : struct
            => typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(byte)
            || typeof(T) == typeof(short)
            || typeof(T) == typeof(ushort)
            || typeof(T) == typeof(int)
            || typeof(T) == typeof(uint)
            || typeof(T) == typeof(long)
            || typeof(T) == typeof(ulong);

    /// <summary>
    /// Determines whether a type is a native signed type
    /// </summary>
    /// <typeparam name="T">The type to test</typeparam>
    [MethodImpl(Inline)]
    public static bool isSigned<T>()
        where T : struct
            => typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short)
            || typeof(T) == typeof(int)
            || typeof(T) == typeof(long)
            || typeof(T) == typeof(float) 
            || typeof(T) == typeof(double);            

    /// <summary>
    /// Determines whether a type is a native unsigned type
    /// </summary>
    /// <typeparam name="T">The type to test</typeparam>
    [MethodImpl(Inline)]
    public static bool isUnsigned<T>()
        where T : struct
            => typeof(T) == typeof(byte)
            || typeof(T) == typeof(ushort)
            || typeof(T) == typeof(uint)
            || typeof(T) == typeof(ulong);

    /// <summary>
    /// Creates an instance of a specified type
    /// </summary>
    /// <param name="t">The type of the instance to create</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static T instance<T>(Type t, params object[] args)
        => (T)Activator.CreateInstance(t,args);

    /// <summary>
    /// Returns a pair of System.Type 
    /// </summary>
    /// <typeparam name="T0">The first source type</typeparam>
    /// <typeparam name="T1">The second source type</typeparam>
    [MethodImpl(Inline)]
    public static (Type t0,Type t1) types<T0,T1>() 
        => (typeof(T0),typeof(T1));

    /// <summary>
    /// Returns a triple of System.Type 
    /// </summary>
    /// <typeparam name="T0">The first source type</typeparam>
    /// <typeparam name="T1">The second source type</typeparam>
    [MethodImpl(Inline)]
    public static (Type t0,Type t1, Type t2) types<T0,T1,T2>() 
        => (typeof(T0),typeof(T1),typeof(T2));

    /// <summary>
    /// Returns the literals defined by an enumeration
    /// </summary>
    /// <typeparam name="T">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static T[] kinds<T>()
        where T : Enum
        => type<T>().GetEnumValues().AsQueryable().Cast<T>().ToArray();


    /// <summary>
    /// Constructs an object
    /// </summary>
    /// <typeparam name="O">The object type</typeparam>
    /// <param name="parms">The parameters passed to the oject's constructor</param>
    /// <returns></returns>
    public static Option<O> construct<O>(params object[] parms)
        => Try(parms, args => (O)Activator.CreateInstance(typeof(O), args));

    /// <summary>
    /// Gets the public constructors defined on the supplied type
    /// </summary>
    /// <typeparam name="T">The type to examine</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static IReadOnlyList<ConstructorInfo> constructors<T>()
        => _constructorCache.GetOrAdd(typeof(T), t => t.GetConstructors());

    /// <summary>
    /// If nullable non-enumeration type, returns the type on which the type is based
    /// If nullable or non-nullable enumeration type, returns the underlying type of the enumeration
    /// If non-nullable non-enumeration type, returns the incoming type
    /// </summary>
    /// <param name="t"></param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static Type underlying(Type t)
        => _ulTypeCache.GetOrAdd(t, _t => _t.GetUnderlyingType());

    /// <summary>
    /// If nullable non-enumeration type, returns the type on which the type is based
    /// If nullable or non-nullable enumeration type, returns the underlying type of the enumeration
    /// If non-nullable non-enumeration type, returns the incoming type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static Type underlying<T>()
        => _ulTypeCache.GetOrAdd(typeof(T), _t => _t.GetUnderlyingType());

    /// <summary>
    /// Gets the type's classification code
    /// </summary>
    /// <param name="t"></param>
    [MethodImpl(Inline)]
    public static TypeCode typecode(Type t)
        => Type.GetTypeCode(t);

    /// <summary>
    /// Gets the type's classification code
    /// </summary>
    [MethodImpl(Inline)]
    public static TypeCode typecode<T>()
        => Type.GetTypeCode(typeof(T));

    /// <summary>
    /// Retrieves any declared public/non-public,static or instance property with the given name
    /// </summary>
    /// <typeparam name="T">The type that defines the property</typeparam>
    /// <param name="name">The name of the property</param>
    /// <returns></returns>
    /// <remarks>
    /// This operation does not use the property cache, which only maintains lookups for public/instance properties
    /// </remarks>
    public static Option<PropertyInfo> prop<T>(string name)
        => typeof(T).GetProperties(BF_Declared).TryGetFirst(x => x.Name == name);

    /// <summary>
    /// Retrieves any declared public/non-public,static or instance field with the given name
    /// </summary>
    /// <typeparam name="T">The type that defines the field</typeparam>
    /// <param name="name">The name of the field</param>
    public static Option<FieldInfo> field<T>(string name)
        => typeof(T).GetFields(BF_Declared).TryGetFirst(x => x.Name == name);

    /// <summary>
    /// Attempts to retrieves the value of a static or instance property
    /// </summary>
    /// <typeparam name="V">The value type</typeparam>
    /// <param name="member">The property</param>
    /// <param name="instance">The object instance, if applicable</param>
    public static Option<V> value<V>(PropertyInfo member, object instance = null)
        => from o in member.TryGetValue(instance)
           from v in tryCast<V>(o)
           select v;

    /// <summary>
    /// Attempts to retrieves the value of a static or instance field
    /// </summary>
    /// <typeparam name="V">The value type</typeparam>
    /// <param name="member">The field</param>
    /// <param name="instance">The object instance, if applicable</param>
    /// <returns></returns>
    public static Option<V> value<V>(FieldInfo member, object instance = null)
        => from o in member.TryGetValue(instance)
           from v in tryCast<V>(o)
           select v;

    /// <summary>
    /// Gets the public constructors defined on the supplied type
    /// </summary>
    /// <param name="o">The type to examine</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static IReadOnlyList<ConstructorInfo> constructors(object o)
        => _constructorCache.GetOrAdd(o.GetType(), t => t.GetConstructors());

    /// <summary>
    /// Retrieves the identified <see cref="PropertyInfo"/>
    /// </summary>
    /// <param name="o">The object on which the property is defined</param>
    /// <param name="propname"></param>
    /// <returns></returns>
    static PropertyInfo GetProperty(object o, string propname)
        => o.GetType().GetProperty(propname, BF_Instance);

    /// <summary>
    /// Retrieves the public properties declared on an object's type
    /// </summary>
    /// <param name="o">The object</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static PropertyInfo[] props(object o)
        => o == null
         ? new PropertyInfo[]{}
         : _propsCache.GetOrAdd(o.GetType(),
             t => t.GetProperties(BF_AllPublicInstance));

    /// <summary>
    /// Retrieves the public properties declared on a type
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static PropertyInfo[] props(Type type)
        => _propsCache.GetOrAdd(type, t => t.GetProperties(BF_AllPublicInstance));

    /// <summary>
    /// Gets the public properties defined on, or inherited by, the supplied type
    /// </summary>
    /// <typeparam name="T">The type to examine</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static PropertyInfo[] props<T>()
        => _propsCache.GetOrAdd(typeof(T),
                t => t.GetProperties(BF_AllPublicInstance));

    /// <summary>
    /// Attempts the retrieve a named property declared on a type
    /// </summary>
    /// <param name="t">The type to examine</param>
    /// <param name="name">The name of the property</param>
    /// <returns></returns>
    public static Option<PropertyInfo> prop(Type t, string name)
        => props(t).FirstOrDefault(p => p.Name == name);

    /// <summary>
    /// Gets the value of the identified property
    /// </summary>
    /// <param name="o">The object on which the property is defined</param>
    /// <param name="propname">The name of the property</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static object propval(object o, string propname)
        => GetProperty(o,propname)?.GetValue(o);

    /// <summary>
    /// Gets the value of the identified property
    /// </summary>
    /// <typeparam name="T">The property value type</typeparam>
    /// <param name="o">The object on which the property is defined</param>
    /// <param name="propname">The name of the property</param>
    [MethodImpl(Inline)]
    public static T propval<T>(object o, string propname)
        => (T)propval(o, propname);


    /// <summary>
    /// Sets the identified property on the object to the supplied value
    /// </summary>
    /// <param name="o">The object whose property will be set</param>
    /// <param name="propname">The property that will be set</param>
    /// <param name="value">The value of the property</param>
    [MethodImpl(Inline)]
    public static void propval(object o, string propname, object value)
        => GetProperty(o,propname)?.SetValue(o, value);

    /// <summary>
    /// Gets the CLR runtime type of the identified property
    /// </summary>
    /// <param name="o">An instance of the type on which the property is defined</param>
    /// <param name="propname">The name of the property</param>
    [MethodImpl(Inline)]
    public static Type proptype(object o, string propname)
        => o.GetType().GetProperty(propname).PropertyType;

    static Func<T,T,T> EmitBinOp<T>(this MethodInfo target)
    {
        var operand = typeof(T);                        
        var method = new DynamicMethod($"{target.Name}", operand, new Type[] { operand, operand }, operand.Module);            
        var gen = method.GetILGenerator();
        gen.Emit(OpCodes.Ldarg_0);
        gen.Emit(OpCodes.Ldarg_1);
        gen.EmitCall(OpCodes.Call, target, null);
        gen.Emit(OpCodes.Ret);
        return (Func<T,T,T>) method.CreateDelegate(typeof(Func<T,T,T>));
    }

    [MethodImpl(Inline)]
    public static Func<T,T,T> binop<T>(MethodInfo target)
        => (Func<T,T,T>) Delegates.GetOrAdd(target, m => m.EmitBinOp<T>());

    /// <summary>
    /// Searches a type for an instance constructor that matches a specified signature
    /// </summary>
    /// <param name="declaringType">The type to search</param>
    /// <param name="argTypes">The method parameter types in ordinal position</param>
    [MethodImpl(Inline)]
    public static Option<ConstructorInfo> constructor(Type declaringType, params Type[] argTypes)
        => declaringType.GetConstructor(BF_Instance, null, argTypes, new ParameterModifier[]{});

    /// <summary>
    /// Searches a type for an instance constructor that matches a specified signature
    /// </summary>
    /// <param name="argTypes">The method parameter types in ordinal position</param>
    /// <typeparam name="T">The type to search</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static Option<ConstructorInfo> constructor<T>(params Type[] argTypes)
        => constructor(typeof(T), argTypes);

    [MethodImpl(Inline)]
    public static string callername([CallerMemberName] string name = null)
        => name ?? string.Empty;

    [MethodImpl(Inline)]
    public static string callerfile([CallerFilePath] string path = null)
        => path ?? string.Empty;

    [MethodImpl(Inline)]
    public static int callerline([CallerLineNumber] int? line = null)
        => line ?? 0;

    /// <summary>
    /// If non-nullable, returns the supplied type. If nullable, returns the underlying type
    /// </summary>
    /// <param name="t">The type to examine</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static Type nonNullable(Type t)
        => _nnTypeCache.GetOrAdd(t, x => x.IsNullableType() ? Nullable.GetUnderlyingType(x) : x);

    /// <summary>
    /// Retrieves the identified <see cref="MethodInfo"/>
    /// </summary>
    /// <param name="o">The object on which the method is defined</param>
    /// <param name="name"></param>
    static MethodInfo GetDelaredMethod(this object o, string name)
        => o.GetType().GetMethod(name, BF_DeclaredInstance);

    /// <summary>
    /// Dynamically invokes a named method on an object
    /// </summary>
    /// <param name="o">The object that defines the method</param>
    /// <param name="methodName">The method to invoke</param>
    /// <param name="parms">The parameters to pass to the method</param>
    [MethodImpl(Inline)]
    public static void invoke(object o, string methodName, params object[] parms)
        => o.GetDelaredMethod(methodName).Invoke(o, parms);

    /// <summary>
    /// Finds the first method declared by a type that matches a specified name
    /// </summary>
    /// <param name="name">The method name</param>
    /// <typeparam name="T">The declaring type</typeparam>
    [MethodImpl(Inline)]
    public static MethodInfo method<T>(string name)
        => typeof(T).Methods().First(m => m.Name == name);


    /// <summary>
    /// Finds the first method declared by a type that matches a specified name
    /// and returns a pointer to the method definition
    /// </summary>
    /// <param name="name">The method name</param>
    /// <typeparam name="T">The declaring type</typeparam>
    [MethodImpl(Inline)]
    public static IntPtr methodPtr<T>(string name)
        => method<T>(name).MethodHandle.GetFunctionPointer();


    [MethodImpl(Inline)]
    public static MethodInfo method<T>(string name, out IntPtr ptr)
    {
        var m = method<T>(name);
        ptr = m.MethodHandle.GetFunctionPointer();
        return m;
    }
        


}