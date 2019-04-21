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

    using operand = System.UInt32;
    using P = Paths;


    [DisplayName(Path)]
    public class UInt32Mod : BinaryPrimOpsTest<UInt32Mod,operand>
    {        
        public const string Path = P.primops + P.uint32 + P.mod;

        public UInt32Mod()
            : base(Defaults.UInt32Domain, x => x != 0)
        {
            
        }

        public override void Verify()
            => base.Verify();

        public override IReadOnlyList<operand> Baseline()
        {
            var dst = target();
            iter((int)SampleSize, i =>
                dst[i] = LeftSrc[i] % RightSrc[i]);
            return dst;
        }


        public override IReadOnlyList<operand> Compute()
            => fuse(LeftSrc,RightSrc, Prim.mod);
            


    } 

}