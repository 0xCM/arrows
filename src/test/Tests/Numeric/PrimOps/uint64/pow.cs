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
    
    using operand = System.UInt64;
    using P = Paths;

    [DisplayName(Path)]
    public class UInt64Pow : UnaryPrimOpsTest<operand>
    {        
        public const string Path = P.primops + P.uint64 + P.pow;
        public UInt64Pow()
            : base(Defaults.UInt64Min,Defaults.UInt64Max)
            {}

        public override void Verify()
            => base.Verify();

        public override IReadOnlyList<operand> Baseline()
            => map(PrimSrc, x => RefCalc.pow(x,3));

        public override IReadOnlyList<operand> Vectorized()
            => map(PrimSrc, x => Prim.pow(x,3));

    } 

}