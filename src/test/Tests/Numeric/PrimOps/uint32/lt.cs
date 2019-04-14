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
    public class UInt32Lt : BinaryPrimOpsTest<UInt32Lt,operand>
    {        
        public const string Path = P.primops + P.uint32 + P.lt;

        public UInt32Lt()
            : base(Defaults.UInt32Domain)
        {
            
        }

        public override void Verify()
            => base.Verify();

        public override IReadOnlyList<operand> Baseline()
        {
            var dst = target();
            iter((int)SampleSize, i =>
                dst[i] = LeftSrc[i] < RightSrc[i] ? 1u : 0u);
            return dst;
        }


        public override IReadOnlyList<operand> Compute()
        {
            var dst = target();
            iter((int)SampleSize, i =>
                dst[i] = Prim.lt(LeftSrc[i],RightSrc[i]) ? 1u : 0u);
            return dst;
        }
            


    } 

}