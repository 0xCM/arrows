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

    public abstract class BinaryPrimOpsTest<T> : PrimOpsTest<T>
        where T : struct, IEquatable<T>
    {
        protected IReadOnlyList<T> LeftSrc;
        
        protected IReadOnlyList<T> RightSrc;

        protected BinaryPrimOpsTest(T MinPrimVal, T MaxPrimVal, uint SampleSize = Pow2.T20)
            : base(MinPrimVal,MaxPrimVal)
        {
            this.LeftSrc = source(MinPrimVal,MaxPrimVal);
            this.RightSrc = source(MinPrimVal,MaxPrimVal);

        }

        protected BinaryPrimOpsTest(Interval<T> Bounds, uint SampleSize = Pow2.T20)
            : base(Bounds.left,Bounds.right)
        {
            this.LeftSrc = source(MinPrimVal,MaxPrimVal);
            this.RightSrc = source(MinPrimVal,MaxPrimVal);

        }


    }


}