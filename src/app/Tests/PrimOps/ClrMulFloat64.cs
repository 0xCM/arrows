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


    [DisplayName("mul => x:double * y:double = z:double")]
    public class ClrMulFloat64 : ClrBinaryPrimOpsTest<operand>
    {

        public ClrMulFloat64()
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
            => fuse(LeftSrc,RightSrc, Ops.mul);

        public override IReadOnlyList<operand> Vectorized()
            => Ops.mul(LeftSrc,RightSrc);


    } 

}