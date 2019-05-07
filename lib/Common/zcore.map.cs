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
using static Z0.Traits;
using static zfunc;

partial class zcore
{
    /// <summary>
    /// Applies a function f:S->T over an input sequence [S] to obtain 
    /// a target sequence [T]
    /// </summary>
    /// <param name="f">The function to be applied</param>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]   
    public static IEnumerable<T> map<S,T>(IEnumerable<S> src, Func<S,T> f)
        => src.Select(x => f(x));

    [MethodImpl(Inline)]
    public static T[] map<S,T>(S[] src, Func<int,S,T> f)
    {
        var len = src.Length;
        var dst = alloc<T>(len);
        for(var i =0; i< len; i++)
            dst[i] = f(i,src[i]);
        return dst;
    }

    /// <summary>
    /// Applies a function f:S->T over an input list [S] to obtain 
    /// a target list [T]
    /// </summary>
    /// <param name="f">The function to be applied</param>
    /// <param name="src">The source list</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]   
    public static T[] map<S,T>(IReadOnlyList<S> src, Func<S,T> f)
    {
        var dst = alloc<T>(src.Count);
        for(var i = 0; i<src.Count; i++)
            dst[i] = f(src[i]);
        return dst;
    }    


    [MethodImpl(Inline)]   
    public static Index<T> map<S,T>(Index<S> src, Func<S,T> f)
    {
        var dst = alloc<T>(src.Count);
        for(var i = 0; i<src.Count; i++)
            dst[i] = f(src[i]);
        return dst;
    }    


    [MethodImpl(Inline)]
    public static Index<T> map<T>(int len, Func<int,T> f)
        where T : struct, IEquatable<T>
    {
        var dst = alloc<T>(len);
        for(var i =0; i< len; i++)
            dst[i] = f(i);
        return dst;
    }

    [MethodImpl(Inline)]
    public static Index<T> map<T>(int offset, int max, Func<int,T> f)
        where T : struct, IEquatable<T>
    {
        var len = max - offset + 1;
        var dst = alloc<T>(len);
        for(var i = offset; i< len; i++)
            dst[i-offset] = f(i);
        return dst;
    }

    /// <summary>
    /// Produces an array that contains the results of the element-wise application
    /// of a unary operator
    /// </summary>
    /// <param name="src">The source list</param>
    /// <param name="f">The undar operator</param>
    /// <param name="dst"></param>
    /// <param name="dst">The target array</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static T[] mapto<S,T>(Index<S> src, Func<S,T> f, out T[] dst)
    {
        dst = alloc<T>(src.Count);
        for(var i = 0; i<src.Count; i++)
            dst[i] = f(src[i]);            
        return dst;
    }

}