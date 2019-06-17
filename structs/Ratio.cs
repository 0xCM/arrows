//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    using static zfunc;

    /// <summary>
    /// Defines a relationship between two numbers a and b that specifies how many
    /// times a contains b
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Ratio</remarks>
    public readonly struct Ratio<T>
        where T : struct
    {
        public Ratio(in T a, in T b)
        {
            this.A = a;
            this.B = b;
        }

        public readonly T A;

        public readonly T B;

    }

}