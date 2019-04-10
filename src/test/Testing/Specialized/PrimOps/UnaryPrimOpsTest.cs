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

    public abstract class UnaryPrimOpsTest<T> : PrimOpsTest<T>
        where T : struct, IEquatable<T>
    {
        protected IReadOnlyList<T> PrimSrc;
        

        protected UnaryPrimOpsTest(T MinPrimVal, T MaxPrimVal, uint SampleSize = Pow2.T20)
            : base(MinPrimVal,MaxPrimVal)
        {
            this.PrimSrc = source(MinPrimVal,MaxPrimVal);

        }

        protected UnaryPrimOpsTest(Interval<T> Bounds, uint SampleSize = Pow2.T20)
            : base(Bounds.left,Bounds.right)
        {
            this.PrimSrc = source(MinPrimVal,MaxPrimVal);

        }

    }


}