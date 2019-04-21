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
    public class Int64GPow : IntGUnaryOpTest<Int64GPow,operand>
    {
        public const string Path = P.structures + P.int64g + P.pow;

        public Int64GPow()
            : base(Interval.closed(0L,100L))
        {
        }

        public override void Verify()
            => base.Verify();
        
        public override IReadOnlyList<operand> Baseline()
            => map(PrimSrc, x => RefCalc.pow(x,3));

        public override IReadOnlyList<intg<operand>> Applied()
            => map(IntSrc, x => x.pow(3));
        
        
    }

}