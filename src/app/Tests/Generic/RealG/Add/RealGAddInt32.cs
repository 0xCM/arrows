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
    using operand = System.Int64;

    [DisplayName("realg[int] add")]
    public class RealGAddInt32 : RealGBinaryOpTest<operand>
    {
        public RealGAddInt32()
            : base(-250000,250000)
        {
        }

        public override void Verify()
            => base.Verify();

        public override IReadOnlyList<operand> Baseline()
            => fuse(LeftPrimSrc, RightPrimSrc, (x,y) => x + y);

        public override IReadOnlyList<real<operand>> Applied()
            => fuse(LeftRealSrc,RightRealSrc, (x,y) => x + y );

    }

}