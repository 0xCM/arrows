//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using Z0;

partial class corefunc
{

    /// <summary>
    /// Determines whether a supplied value represents an infinite value
    /// </summary>
    /// <param name="x">The subject to test</param>
    /// <returns></returns>
    public static bool infinite(double x)
        => PositiveInfinity.test(x) || NegativeInfinity.test(x);

}


