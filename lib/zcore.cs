//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Globalization;

using Z0;
using static Z0.Bibliography;
using static zcore;
using static Z0.Traits;


partial class zcore
{
    public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    public static int countmatch<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
    {
        if(lhs.Count == rhs.Count)
            return lhs.Count;
        throw new Exception($"List count mismatch: lhs.Count= {lhs.Count}, rhs.Count = {rhs.Count}");
    }

    [MethodImpl(Inline)]
    public static unsafe ref T memref<T>(ReadOnlySpan<T> x)    
        => ref MemoryMarshal.GetReference(x);

    [MethodImpl(Inline)]
    public static unsafe void* pointer<T>(ref T src)
        => Unsafe.AsPointer(ref src);

    /// <summary>
    /// Calculates the time required to execute a specified action
    /// </summary>
    /// <param name="f">The action for which a running time will be calculated</param>
    /// <returns>The number of milliseconds elaplsed during execution</returns>
    [MethodImpl(Inline)]
    public static long measure(Action f, string name, int reps = 1, bool announce = true)
    {
        if(announce)
             print($"Measuring {name} execution time", SeverityLevel.HiliteML);
        
        var sw = stopwatch();
        for(var i = 0; i<reps; i++)
            f();

        var duration = sw.ElapsedMilliseconds;
        
        if(announce)
             print($"Measured {name} execution time" +
                    (reps != 1 ? $" over {reps} repetitions" : string.Empty) +
                    $": {duration}ms", SeverityLevel.HiliteML);

        return duration;
    }

    [MethodImpl(Inline)]
    public static void iter(int start, int limit, int step, Action<int> f)
    {
        for(var i = start; i < limit; i += step)   
            f(i);             
    }

    [MethodImpl(Inline)]
    public static IEnumerable<int> range(int start, int limit, int step)
    {
        for(var i = start; i< limit; i += step)
            yield return i;
    }

    /// <summary>
    /// Calculates the time required to execute a specified function
    /// </summary>
    /// <param name="f">The function for which a running time will be calculated</param>
    /// <returns>The number of milliseconds elaplsed during execution</returns>
    public static T duration<T>(Func<T> f, out long ms)
    {
        var sw = stopwatch();
        var result = f();
        ms = sw.ElapsedMilliseconds;
        return result;
    }


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
    /// Explicitly casts a source value to value of the indicated type, raising
    /// an exception if operation fails
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
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
    [MethodImpl(Inline)]   
    public static bool not(bool a) 
        => !a;

    /// <summary>
    /// Raises a NotImplemented exception
    /// </summary>
    public static T noimpl<T>() 
        => throw new NotImplementedException();

    /// <summary>
    /// Raises a NotImplemented exception
    /// </summary>
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
        => sw.ElapsedTicks;

    [MethodImpl(Inline)]   
    public static Duration snapshot(Stopwatch sw)     
        => Duration.Define(sw.ElapsedTicks);        

    /// <summary>
    /// Demands truth that is enforced with an exeption upon false
    /// </summary>
    /// <param name="x">The value to test</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static bool demand(bool x, string message = null)
        => x ? x : throw new Exception(message ?? "demand failed");

    /// <summary>
    /// Constructs a value if boolean predondition is true; otherwise, raises an exception
    /// </summary>
    /// <param name="condition">The condition to test</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static T demand<T>(bool condition, string msg = null)
        where T : new()
        => condition ? new T() : throw new Exception(msg ?? $"Precondition for construction of {type<T>().Name} unmet");    

    /// <summary>
    /// Constructs a date from an integer in the form YYYYMMDD
    /// </summary>
    /// <param name="d">The integer representing the date</param>
    /// <returns></returns>
    public static Date date(int d) 
        => DateTime.ParseExact(d.ToString(), "yyyyMMdd", CultureInfo.CurrentCulture);

}

