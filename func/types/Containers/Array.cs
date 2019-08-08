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

partial class zfunc
{
    /// <summary>
    /// Creates, but does not populate, a mutable array
    /// </summary>
    /// <param name="len">The length of the array</param>
    /// <typeparam name="T">The array element type</typeparam>
    [MethodImpl(Inline)]
    public static T[] array<T>(long len)
        => new T[len];

    /// <summary>
    /// Creates, but does not populate, a mutable array
    /// </summary>
    /// <param name="len">The length of the array</param>
    /// <typeparam name="T">The array element type</typeparam>
    [MethodImpl(Inline)]
    public static T[] alloc<T>(uint len)
        => new T[len];

    /// <summary>
    /// Creates, but does not populate, a mutable array
    /// </summary>
    /// <param name="len">The length of the array</param>
    /// <typeparam name="T">The array element type</typeparam>
    [MethodImpl(Inline)]
    public static T[] alloc<T>(int len)
        => new T[len];

    [MethodImpl(Inline)]   
    public static T[] array<T>(params T[] src)
        => src;

    [MethodImpl(Inline)]   
    public static T[] alloc<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
        where T : struct
            => alloc<T>(length(lhs,rhs));

    [MethodImpl(Inline)]   
    public static T[] alloc<T>(ReadOnlySpan<T> src)
        where T : struct
            => alloc<T>(src.Length);

    /// <summary>
    /// Constructs an array filled with a replicated value
    /// </summary>
    /// <param name="value">The value to replicate</param>
    /// <param name="count">The number of replicants</param>
    /// <typeparam name="T">The replicant type</typeparam>
    public static T[] repeat<T>(T value, ulong count)
    {
        var dst = alloc<T>((uint)count);
        for(var idx = 0U; idx < count; idx ++)
            dst[idx] = value;
        return dst;            
    }

    /// <summary>
    /// Reverses an array in-place
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The element type</typeparam>
    public static T[] reverse<T>(T[] src)
    {
        Array.Reverse(src);
        return src;        
    }

    [MethodImpl(Inline)]   
    public static T[] repeat<T>(T value, int count)
        => repeat(value, (ulong)count);

    [MethodImpl(Inline)]   
    public static T[] repeat<T>(T value, uint count)
        => repeat(value, (ulong)count);

    [MethodImpl(Inline)]   
    public static void copy<T>(T[] src, T[] dst)
        => Array.Copy(src,dst,length(src,dst));

    /// <summary>
    /// Constructs an array from a stream and a transformation function
    /// </summary>
    /// <param name="src">The source stream</param>
    /// <param name="f">The transfomer</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]
    public static T[] array<S,T>(IEnumerable<S> src, Func<S,T> f)
        => src.Select(f).ToArray();
    
    /// <summary>
    /// Computes the hash code of an array
    /// </summary>
    /// <param name="items">The source array</param>
    /// <typeparam name="T">The array element type</typeparam>
    /// <remarks>Derived from https://stackoverflow.com/questions/1646807/quick-and-simple-hash-code-combinations</remarks>
    public static int hash<T>(params T[] items)
    {
        var h = 17;
        unchecked
        {
            for(var i=0; i<items.Length; i++)
                h = h*31 + items[i].GetHashCode();                
        }
        return h;
    }

}