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

    using static zcore;
    using static ztest;
    using operand = System.Double;


    [DisplayName("primitive *:(double, double) -> double")]
    public class ClrFloat64Mul : ClrBinaryPrimOpsTest<operand>
    {

        public ClrFloat64Mul()
            : base(-250000,250000)
                {}
        
        public override void Verify()
            => base.Verify();

        public override IReadOnlyList<operand> Baseline()
        {
            var dst = target();
            iter((int)VectorSize, i =>
                dst[i] = LeftSrc[i] * RightSrc[i]);
            return dst;
        }

        public override IReadOnlyList<operand> Discretized()
            => fuse(LeftSrc,RightSrc, Prim.mul);

        public override IReadOnlyList<operand> Vectorized()
            => Prim.mul(LeftSrc,RightSrc);


    } 

}