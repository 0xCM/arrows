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
    public class Float64Mul : BinaryPrimOpsTest<Float64Mul,operand>
    {
        public const string Path = P.primops + P.float64 + P.mul;

        public Float64Mul()
            : base(Defaults.Float64Domain)
        {

        }   

        public override void Verify()
            => base.Verify();

        public override IReadOnlyList<operand> Baseline()
        {
            var dst = target();
            iter((int)SampleSize, i =>
                dst[i] = LeftSrc[i] * RightSrc[i]);
            return dst;
        }

        public override IReadOnlyList<operand> Compute()
            => Prim.mul(LeftSrc,RightSrc);
    } 
}