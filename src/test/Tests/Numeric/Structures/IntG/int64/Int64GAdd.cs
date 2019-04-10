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

    using P = Paths;
    using operand = System.Int64;

    [DisplayName(Path)]
    public class Int64GAdd : IntGBinOpTest<operand>
    {
        public const string Path = P.generic + P.int64 + P.add;
        public Int64GAdd()
            : base(-250000,250000)
        {
        }

        public override void Verify()
            => base.Verify();

        public override IReadOnlyList<operand> Baseline()
            => fuse(LeftPrimSrc, RightPrimSrc, (x,y) => x + y);

        public override IReadOnlyList<intg<operand>> Applied()
            => fuse(LeftIntSrc,RightIntSrc, (x,y) => x + y );

    }

}