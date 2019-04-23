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
    static ArgumentException mismatched(params int[] counts)
        => new ArgumentException($"The counts do not mach:{string.Join(AsciSym.Pipe, counts)}");        
            
    [MethodImpl(Inline)]
    public static int matchedCount<T>(Index<T> lhs, Index<T> rhs)
        => lhs.Count != rhs.Count ? throw mismatched(lhs.Count,rhs.Count) : lhs.Count;

    [MethodImpl(Inline)]
    static int matchedCount<T>(Index<T> x0, Index<T> x1, Index<T> x2)
        => x0.Count != x1.Count || x0.Count != x2.Count 
            ? throw mismatched(x0.Count, x1.Count, x2.Count) 
            : x0.Count;

    [MethodImpl(Inline)]
    static int matchedCount<T>(Index<T> x0, Index<T> x1, Index<T> x2, Index<T> x3)
        => x0.Count != x1.Count || x0.Count != x2.Count  || x0.Count != x3.Count
            ? throw mismatched(x0.Count, x1.Count, x2.Count) 
            : x0.Count;

    [MethodImpl(Inline)]
    static int matchedCount<T>(T[] lhs, T[] rhs)
        => lhs.Length != rhs.Length ? throw mismatched(lhs.Length,rhs.Length) : lhs.Length;

    /// <summary>
    /// Zips two indexes via a binary operator into a target array
    /// </summary>
    /// <param name="lhs">The first index</param>
    /// <param name="rhs">The second index</param>
    /// <param name="f">The binary operator</param>
    /// <param name="dst">The target array</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static T[] fuse<T>(Index<T> lhs, Index<T> rhs, Func<T,T,T> f, out T[] dst)
    {
        var count = countmatch(lhs,rhs);
        dst = alloc<T>(count);
        for(var i = 0; i<count; i++)
            dst[i] = f(lhs[i], rhs[i]);            
        return dst;
    }

    /// <summary>
    /// Constructs an index of pairs from a pair of indexes of the same length
    /// </summary>
    /// <param name="left">The left index</param>
    /// <param name="right">The right index</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static Index<(T left, T right)> zip<T>(Index<T> lhs, Index<T> rhs)
        => zip(lhs.ToArray(),rhs.ToArray());

    
    /// <summary>
    /// Constructs an array of pairs from a pair of arrays of the same length
    /// </summary>
    /// <param name="left">The left index</param>
    /// <param name="right">The right index</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static Index<(T left, T right)> zip<T>(T[] lhs, T[] rhs)
    {
        var count = matchedCount(lhs,rhs);
        var dst = alloc<(T,T)>(count);
        for(var i=0; i<count; i++)
            dst[i] = (lhs[i],rhs[i]);
        return dst;
    }


    [MethodImpl(Inline)]   
    public static Index<Y> fuse<X,Y>(Index<X> lhs, Index<X> rhs, Func<X,X,Y> f)
    {
        var count = matchedCount(lhs,rhs);            
        var dst = alloc<Y>(count);
        for(var i = 0; i< count; i++)
            dst[i] = f(lhs[i], rhs[i]);
        return dst;
    }    

    [MethodImpl(Inline)]   
    public static Y[] fuse<X,Y>(X[] lhs, X[] rhs, Func<X,X,Y> f)
    {
        var count = matchedCount(lhs,rhs);
        var dst = alloc<Y>(count);
        for(var i = 0; i< count; i++)
            dst[i] = f(lhs[i], rhs[i]);
        return dst;
    }    

    [MethodImpl(Inline)]   
    public static Index<Y> fuse<X,Y>(Index<X> x0, Index<X> x1, Index<X> x2, Func<X,X,X,Y> f)
    {
        var count = matchedCount(x0,x1,x2);            
        var dst = alloc<Y>(count);
        for(var i = 0; i< count; i++)
            dst[i] = f(x0[i], x1[i], x2[i]);
        return dst;
    }    

    [MethodImpl(Inline)]   
    public static Index<Y> fuse<X,Y>(Index<X> x0, Index<X> x1, Index<X> x2, Index<X> x3, Func<X,X,X,X,Y> f)
    {
        var count = matchedCount(x0,x1,x2,x3);
        var dst = alloc<Y>(count);
        for(var i = 0; i< count; i++)
            dst[i] = f(x0[i], x1[i], x2[i], x3[i]);
        return dst;
    }    
}