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
    /// Constructs the closed interval [left,right]
    /// </summary>
    /// <param name="left">The left end point</param>
    /// <param name="right">The right endpoint</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]
    public static ClosedInterval<T> closed<T>(T left, T right)
        where T : struct
            => Interval.closed(left,right);

    /// <summary>
    /// Constructs the left-open(or right-closed interval) interval (left,right]
    /// </summary>
    /// <param name="left">The left end point</param>
    /// <param name="right">The right endpoint</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]
    public static LeftOpenInterval<T> leftopen<T>(T left, T right)
        where T : struct
            => Interval.leftopen(left,right);

    /// <summary>
    /// Constructs the left-closed (or right-open interval) interval [left,right)
    /// </summary>
    /// <param name="left">The left end point</param>
    /// <param name="right">The right endpoint</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]
    public static LeftClosedInterval<T> leftclosed<T>(T left, T right)
        where T : struct
            => Interval.leftclosed(left,right);

    /// <summary>
    /// Constructs the open interval (left,right)
    /// </summary>
    /// <param name="left">The left end point</param>
    /// <param name="right">The right endpoint</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]
    public static OpenInterval<T> open<T>(T left, T right)
        where T : struct
            => Interval.open(left,right);
}