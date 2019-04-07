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
    using operand = System.UInt64;


    [DisplayName("x:ulong * y:ulong = z:ulong")]
    public class ClrMulUInt64 : ClrBinaryPrimOpsTest<operand>
    {        
        public ClrMulUInt64()
            : base(0,500000)
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