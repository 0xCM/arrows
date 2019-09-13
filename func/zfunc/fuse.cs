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
using static zfunc;

partial class zfunc
{ 
    static ArgumentException mismatched(params int[] counts)
        => new ArgumentException($"The counts do not mach:{string.Join(AsciSym.Pipe, counts)}");        
            
    [MethodImpl(Inline)]
    public static int matchedLength<T>(T[] lhs, T[] rhs)
        => lhs.Length != rhs.Length ? throw mismatched(lhs.Length, rhs.Length) : lhs.Length;

    [MethodImpl(Inline)]
    static int matchedLength<T>(T[] x0, T[] x1, T[] x2)
        => x0.Length != x1.Length || x0.Length != x2.Length 
            ? throw mismatched(x0.Length, x1.Length, x2.Length) 
            : x0.Length;

    [MethodImpl(Inline)]
    static int matchedLength<T>(T[] x0, T[] x1, T[] x2, T[] x3)
        => x0.Length != x1.Length || x0.Length != x2.Length  || x0.Length != x3.Length
            ? throw mismatched(x0.Length, x1.Length, x2.Length) 
            : x0.Length;
    
    static ArgumentException mismatched<T>(Span<T> lhs, Span<T> rhs)
        => new ArgumentException($"The left item count {lhs.Length} does not match the right item count {rhs.Length}");

    [MethodImpl(Inline)]
    static int matchedCount<T>(Span<T> lhs, Span<T> rhs)
        => lhs.Length != rhs.Length? throw mismatched(lhs,rhs) : lhs.Length;

    [MethodImpl(Inline)]
    public static Span<T> fuse<T>(Span<T> lhs, Span<T> rhs, Func<T,T,T> f)
    {
        var len = matchedCount(lhs,rhs);
        for(var i = 0; i < len ; i++)
            lhs[i] = f(lhs[i], rhs[i]);
        return lhs;
    }

    /// <summary>
    /// Zips two indexes via a binary operator into a target array
    /// </summary>
    /// <param name="lhs">The first index</param>
    /// <param name="rhs">The second index</param>
    /// <param name="f">The binary operator</param>
    /// <param name="dst">The target array</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static T[] fuse<T>(T[] lhs, T[] rhs, Func<T,T,T> f, out T[] dst)
    {        
        var count = lhs.Length;
        dst = alloc<T>(count);
        for(var i = 0; i<count; i++)
            dst[i] = f(lhs[i], rhs[i]);            
        return dst;
    }
    
    /// <summary>
    /// Constructs an array of pairs from a pair of arrays of the same length
    /// </summary>
    /// <param name="left">The left index</param>
    /// <param name="right">The right index</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static (T left, T right)[] zip<T>(T[] lhs, T[] rhs)
    {
        var count = matchedLength(lhs,rhs);
        var dst = alloc<(T,T)>(count);
        for(var i=0; i<count; i++)
            dst[i] = (lhs[i],rhs[i]);
        return dst;
    }

    [MethodImpl(Inline)]   
    public static Y[] fuse<X,Y>(X[] lhs, X[] rhs, Func<X,X,Y> f)
    {
        var count = matchedLength(lhs,rhs);            
        var dst = alloc<Y>(count);
        for(var i = 0; i< count; i++)
            dst[i] = f(lhs[i], rhs[i]);
        return dst;
    }    

    [MethodImpl(Inline)]   
    public static Y[] fuse<X,Y>(X[] x0, X[] x1, X[] x2, Func<X,X,X,Y> f)
    {
        var count = matchedLength(x0,x1,x2);            
        var dst = alloc<Y>(count);
        for(var i = 0; i< count; i++)
            dst[i] = f(x0[i], x1[i], x2[i]);
        return dst;
    }    

    [MethodImpl(Inline)]   
    public static Y[] fuse<X,Y>(X[] x0, X[] x1, X[] x2, X[] x3, Func<X,X,X,X,Y> f)
    {
        var count = matchedLength(x0,x1,x2,x3);
        var dst = alloc<Y>(count);
        for(var i = 0; i< count; i++)
            dst[i] = f(x0[i], x1[i], x2[i], x3[i]);
        return dst;
    }    
}