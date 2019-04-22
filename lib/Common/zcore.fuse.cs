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

partial class zcore
{

    /// <summary>
    /// Zips two lists via a binary operator into a target array
    /// </summary>
    /// <param name="lhs">The first list</param>
    /// <param name="rhs">The second list</param>
    /// <param name="f">The binary operator</param>
    /// <param name="dst">The target array</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static T[] fuse<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs, Func<T,T,T> f, out T[] dst)
    {
        var count = countmatch(lhs,rhs);
        dst = alloc<T>(count);
        for(var i = 0; i<count; i++)
            dst[i] = f(lhs[i], rhs[i]);            
        return dst;
    }

    /// <summary>
    /// Constructs a readonly list of pairs from a pair of readonly lists
    /// </summary>
    /// <param name="left">The left list</param>
    /// <param name="right">The right list</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static Index<(T left, T right)> zip<T>(Index<T> lhs, Index<T> rhs)
        => zip(lhs,rhs).ToArray();


    [MethodImpl(Inline)]   
    public static IReadOnlyList<Y> fuse<X,Y>(IReadOnlyList<X> lhs, IReadOnlyList<X> rhs, Func<X,X,Y> f)
    {
        if(lhs.Count != rhs.Count)
            throw new ArgumentException($"The left count {lhs.Count} does not match the right count {rhs.Count}");
            
        var dst = alloc<Y>(lhs.Count);
        for(var i = 0; i< dst.Length; i++)
            dst[i] = f(lhs[i], rhs[i]);
        return dst;
    }    

    [MethodImpl(Inline)]   
    public static Index<Y> fuse<X,Y>(Index<X> lhs, Index<X> rhs, Func<X,X,Y> f)
    {
        if(lhs.Count != rhs.Count)
            throw new ArgumentException($"The left count {lhs.Count} does not match the right count {rhs.Count}");
            
        var dst = alloc<Y>(lhs.Count);
        for(var i = 0; i< dst.Length; i++)
            dst[i] = f(lhs[i], rhs[i]);
        return dst;
    }    

    [MethodImpl(Inline)]   
    public static Y[] fuse<X,Y>(X[] lhs, X[] rhs, Func<X,X,Y> f)
    {
        if(lhs.Length != rhs.Length)
            throw new ArgumentException($"The left count {lhs.Length} does not match the right count {rhs.Length}");
            
        var dst = alloc<Y>(lhs.Length);
        for(var i = 0; i< dst.Length; i++)
            dst[i] = f(lhs[i], rhs[i]);
        return dst;
    }    

    [MethodImpl(Inline)]   
    public static Index<Y> fuse<X,Y>(Index<X> x0, Index<X> x1, Index<X> x2, Func<X,X,X,Y> f)
    {
        if(x0.Count != x1.Count || x0.Count != x2.Count)
            throw new ArgumentException($"The input list item counts do not match");
            
        var dst = alloc<Y>(x0.Count);
        for(var i = 0; i< dst.Length; i++)
            dst[i] = f(x0[i], x1[i], x2[i]);
        return dst;
    }    

    [MethodImpl(Inline)]   
    public static Index<Y> fuse<X,Y>(Index<X> x0, Index<X> x1, Index<X> x2, Index<X> x3, Func<X,X,X,X,Y> f)
    {
        if(x0.Count != x1.Count || x0.Count != x2.Count || x0.Count != x3.Count)
            throw new ArgumentException($"The input list item counts do not match");
            
        var dst = alloc<Y>(x0.Count);
        for(var i = 0; i< dst.Length; i++)
            dst[i] = f(x0[i], x1[i], x2[i], x3[i]);
        return dst;
    }    

}