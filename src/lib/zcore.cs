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

using Z0;
using static Z0.Credit;
using static zcore;
using static Z0.Traits;


partial class zcore
{
    public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;


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
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string typename<T>(bool full = false)
        => typeof(T).Name;

    /// <summary>
    /// Returns the System.Type of the supplied parametric type
    /// </summary>
    /// <typeparam name="T">The source type</typeparam>
    /// <returns></returns>
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
    /// Coreces the source value to the target type, if possible; otherwise
    /// raises an error
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<T>(object src)
        => (T)Convert.ChangeType(src, type<T>());

    /// <summary>
    /// Explicitly casts a source value to value of the indicated type, raising
    /// an exception if operation fails
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static T cast<T>(object src) 
        => (T) src;

 
    /// <summary>
    /// The univeral identity function that returns the source value
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="A">The source value type</typeparam>
    /// <returns>The source value</returns>
    [MethodImpl(Inline)]   
    public static A  identity<A>(A x) => x;

    /// <summary>
    /// Constructs a citation for a bibliographic resource
    /// </summary>
    /// <param name="resource">The referenced biblography resource</param>
    /// <param name="location">The location of interest within the referenced work</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Citation cite(Resource resource, int location)
        => Citation.define(resource,location);

    /// <summary>
    /// Returns a pair of System.Type 
    /// </summary>
    /// <typeparam name="T0">The first source type</typeparam>
    /// <typeparam name="T1">The second source type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (Type t0,Type t1) types<T0,T1>() 
        => (typeof(T0),typeof(T1));

    /// <summary>
    /// Returns a triple of System.Type 
    /// </summary>
    /// <typeparam name="T0">The first source type</typeparam>
    /// <typeparam name="T1">The second source type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (Type t0,Type t1, Type t2) types<T0,T1,T2>() 
        => (typeof(T0),typeof(T1),typeof(T2));

    /// <summary>
    /// Returns true if the input is false, false otherwise
    /// </summary>
    /// <param name="a">The value to test</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static bool not(bool a) 
        => a ? true : false;

    /// <summary>
    /// Raises a NotImplemented exception
    /// </summary>
    /// <returns></returns>
    public static T noimpl<T>() 
        => throw new NotImplementedException();

    /// <summary>
    /// Raises a NotImplemented exception
    /// </summary>
    /// <returns></returns>
    public static void noimpl() 
        => throw new NotImplementedException();

    /// <summary>
    /// Raises a NotSupportedException exception
    /// </summary>
    /// <returns></returns>
    public static T nosupport<T>()
        => throw new NotSupportedException();

    /// <summary>
    /// Constructs an arrow, based at a specified source, projecting
    /// onto a specified value
    /// </summary>
    /// <param name="a">The source point in the domain</param>
    /// <param name="b">The target point in the codomain</param>
    /// <typeparam name="A">The domain type</typeparam>
    /// <typeparam name="B">The codomain type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Z0.PointedArrow<A,B> arrow<A,B>(A a, B b, string label = null)
        => new Z0.PointedArrow<A,B>(a,b,label);

    [MethodImpl(Inline)]   
    public static Stopwatch stopwatch() 
        => Stopwatch.StartNew();

    [MethodImpl(Inline)]   
    public static long elapsed(Stopwatch sw) 
        => sw.ElapsedMilliseconds;

    /// <summary>
    /// Demands truth that is enforced with an exeption upon false
    /// </summary>
    /// <param name="x">The value to test</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static bool demand(bool x, string message = null)
        => x ? x : throw new ArgumentException(message ?? "demand failed");

    /// <summary>
    /// Constructs a value if boolean predondition is true; otherwise, raises an exception
    /// </summary>
    /// <param name="condition">The condition to test</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static T demand<T>(bool condition, string msg = null)
        where T : new()
        => condition ? new T() 
        : throw new ArgumentException(msg ?? $"Precondition for construction of {type<T>().Name} unmet");
}

