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
    public static T[] alloc<T>(long len)
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


}