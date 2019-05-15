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
    /// Reduces a stream to a single value via an additive monoid
    /// </summary>
    /// <param name="src">The source stream</param>
    /// <typeparam name="T">The stream element type</typeparam>
    [MethodImpl(Inline)]
    public static T foldA<T>(IEnumerable<T> src)
        where T : struct, IMonoidA<T>
    {
        
        var cumulant = default(T).zero;
        foreach(var item in src)
            cumulant = cumulant.add(item);            
        return cumulant;
    }
                
    /// <summary>
    /// Reduces a stream to a single value via a multiplicative monoid
    /// </summary>
    /// <param name="src">The source stream</param>
    /// <typeparam name="T">The stream element type</typeparam>
    [MethodImpl(Inline)]
    public static T foldM<T>(IEnumerable<T> src)
        where T : struct, IMonoidM<T>
    {        
        var cumulant = default(T).one;
        foreach(var item in src)
            cumulant = cumulant.mul(item);            
        return cumulant;
    }
                
    /// <summary>
    /// Reduces a stream to a single value via a specified monoid
    /// </summary>
    /// <param name="src">The source stream</param>
    /// <typeparam name="T">The stream element type</typeparam>
    [MethodImpl(Inline)]
    public static T fold<T>(IEnumerable<T> src, IMonoidalOps<T> monoid)
        where T : struct
    {
        
        var cumulant = monoid.identity;
        foreach(var item in src)
            cumulant = monoid.compose(cumulant, item);            
        return cumulant;
    }

}