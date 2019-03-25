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


public static class ContainerX
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
    /// Constructs a sequence of singleton sequences from a sequence of elements
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The item type</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<IEnumerable<T>> Singletons<T>(this IEnumerable<T> src)
        => singletons(src);

    /// <summary>
    /// Constructs a slice from a supplied sequence
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The item type</typeparam>
    [MethodImpl(Inline)]
    public static Slice<T> ToSlice<T>(this IEnumerable<T> src)
        => Slice.define(src);

    /// <summary>
    /// Constructs a slice with natural length from a sequence of elements
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The item type</typeparam>
    /// <typeparam name="N">The natural type</typeparam>
    [MethodImpl(Inline)]
    public static Slice<N,T> ToSlice<N,T>(this IEnumerable<T> src)
        where N : TypeNat, new()
        => Slice.define<N,T>(src);

    /// <summary>
    /// Wraps an enumerable with a sequence structure
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The item type</typeparam>
    [MethodImpl(Inline)]
    public static Seq<T> ToSeq<T>(this IEnumerable<T> src)
        => Seq.define(src);

    /// <summary>
    /// Reifies an enumerable as a finite sequence
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The item type</typeparam>
    [MethodImpl(Inline)]
    public static FiniteSeq<T> ToFiniteSeq<T>(this IEnumerable<T> src)
        => Seq.finite(src);

}
