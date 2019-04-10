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
    public class UInt64Mod : BinaryPrimOpsTest<operand>
    {        
        public const string Path = P.primops + P.uint64 + P.mod;

        public UInt64Mod()
            : base(0,500000)
                {}

        public override void Verify()
            => base.Verify();

        public override IReadOnlyList<operand> Baseline()
        {
            var dst = target();
            iter((int)SampleSize, i =>
                dst[i] = LeftSrc[i] % RightSrc[i]);
            return dst;
        }

        public override IReadOnlyList<operand> Discretized()
            => fuse(LeftSrc,RightSrc, Prim.mod);

        public override IReadOnlyList<operand> Vectorized()
            => Prim.mod(LeftSrc,RightSrc);


    } 

}