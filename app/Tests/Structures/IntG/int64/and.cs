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
    public class Int64GAnd : IntGBinOpTest<Int64GAnd,operand>
    {
        public const string Path = P.structures + P.int64g + P.and;
        
        public Int64GAnd()
            : base(Defaults.Int64Domain)
        {
        }

        public override void Verify()
            => base.Verify();

        public override IReadOnlyList<operand> Baseline()
            => fuse(LeftPrimSrc, RightPrimSrc, (x,y) => x & y);

        public override IReadOnlyList<intg<operand>> Applied()
            => fuse(LeftIntSrc,RightIntSrc, (x,y) => x & y );
        
        
    }

}