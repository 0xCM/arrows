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
using static zfunc;


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

