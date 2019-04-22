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
    public class UInt64Fact : UnaryPrimOpsTest<UInt64Fact,operand>
    {        
        public const string Path = P.primops + P.uint64 + P.fact;

        static readonly PrimOps.Reify.Special Ops = PrimOps.Reify.Special.Inhabitant;
        
        public UInt64Fact()
            : base(Interval.closed(0ul,15ul))
            {}

        public override void Verify()
            => base.Verify();

        public override Index<operand> Baseline()
            => map(PrimSrc, x => RefCalc.fact(x));

        public override Index<operand> Compute()
            => map(PrimSrc, x => Ops.fact(x));
    } 
}