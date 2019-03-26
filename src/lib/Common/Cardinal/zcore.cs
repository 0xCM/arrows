//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using Z0;

partial class zcore
{

    /// <summary>
    /// Determines whether a value represents negative infinity
    /// </summary>
    /// <param name="x">The value to test</param>
    public static bool neginf(double x)
        => NegativeInfinity.test(x);

    /// <summary>
    /// Determines whether a value represents positive infinity
    /// </summary>
    /// <param name="x">The value to test</param>
    public static bool posinf(double x)
        => PositiveInfinity.test(x);

    /// <summary>
    /// Determines whether a value represents an infinity
    /// </summary>
    /// <param name="x">The subject to test</param>
    /// <returns></returns>
    public static bool infinite(double x)
        => neginf(x) || posinf(x);

}


