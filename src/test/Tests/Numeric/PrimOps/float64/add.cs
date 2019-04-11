//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;

    using static zcore;
    using static ztest;

    using operand = System.Double;
    using P = Paths;

    [DisplayName(Path)]
    public class Float64Add : BinaryPrimOpsTest<Float64Add,operand>
    {
        public const string Path = P.primops + P.float64 + P.add;

        public Float64Add()
            : base(Defaults.Float64Range)
        {

        }   

        public override void Verify()
            => base.Verify();

        public override IReadOnlyList<operand> Baseline()
        {
            var dst = target();
            iter((int)SampleSize, i =>
                dst[i] = LeftSrc[i] + RightSrc[i]);
            return dst;
        }

        public override IReadOnlyList<operand> Compute()
            => Prim.add(LeftSrc,RightSrc);
    } 
}