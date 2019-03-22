//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Core;

using static Core.Credit;
using static corefunc;


public static partial class corext
{
    /// <summary>
    /// Defines a window over a 1-d array beginning at a specified index 
    /// for a specified length
    /// </summary>
    /// <param name="src">The source array</param>
    /// <param name="start">The 0-based starting index</param>
    /// <param name="len">The length of the segment</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static IReadOnlyList<T> Segment<T>(this T[] src, uint start, uint len)
        => new ArraySegment<T>(src, (int)start, (int)len);

    /// <summary>
    /// Lifts a function to a unary operator
    /// </summary>
    /// <param name="f">The function to lift</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static Core.UnaryOp<T> ToUnaryOp<T>(this Func<T,T> f)
        => new UnaryOp<T>(f);

    /// <summary>
    /// Lifts a function to a binary opeator operator
    /// </summary>
    /// <param name="f">The function to lift</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static BinaryOp<T> ToBinaryOp<T>(this Func<T,T,T> f, bool commutative = false)
            => commutative 
            ?  cast<BinaryOp<T>>(new CommutativeOp<T>(f)) 
            : new BinaryOp<T>(f);

    /// <summary>
    /// Attaches a 0-based integer sequence to the input value sequence and
    /// yield the paired sequence elements
    /// </summary>
    /// <param name="i">The index of the paired value</param>
    /// <param name="value">The indexed value</param>
    /// <typeparam name="T">The item type</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<(int i, T value)> Iteri<T>(this IEnumerable<T> items)
        => iteri(items);


    /// <summary>
    /// Partitions the source sequence into segments of natural length
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The element type</typeparam>
    /// <typeparam name="N">The segment length</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<IReadOnlyList<T>> Partition<N,T>(this IEnumerable<T> src)
        where N : TypeNat, new()
            => partition<N,T>(src);    

    /// <summary>
    /// Formats the source as a braced list
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The element type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string Embrace<T>(this IEnumerable<T> src)
        => embrace(string.Join(',',src));

    /// <summary>
    /// Defines an unsigned alterantive to the intrinsic Count property
    /// </summary>
    /// <param name="src">The source list</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static uint length<T>(this IReadOnlyList<T> src)
        => (uint)src.Count;
}