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
    
    using operand = System.Int64;
    using P = Paths;

    [DisplayName(Path)]
    public class RealGInt64Add : RealGBinOpTest<RealGInt64Add,operand>
    {
        public const string Path = P.structures + P.reali64 + P.add;

        public RealGInt64Add()
            : base(Defaults.Int64Domain)
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