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

    public readonly struct Ratio<T>
        where T : struct
    {
        public Ratio(in T a, in T b)
        {
            this.A = a;
            this.B = b;
            this.Quotient = gmath.div(a,b);
        }

        public readonly T A;

        public readonly T B;

        public readonly T Quotient;

    }

}