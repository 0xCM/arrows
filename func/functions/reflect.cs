//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Reflection;

using Z0;

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

}