//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Testing
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;

    using static zcore;

    public abstract class UnaryPrimOpsTest<S,T> : PrimOpsTest<S,T>
        where S : UnaryPrimOpsTest<S,T>
        where T : struct, IEquatable<T>
    {
        protected IReadOnlyList<T> PrimSrc;
        
        protected UnaryPrimOpsTest(Interval<T> bounds, Func<T,bool> filter = null, uint sampleSize = Pow2.T20)
            : base(bounds, filter, sampleSize)
        {
            this.PrimSrc = sample();

        }

    }


}