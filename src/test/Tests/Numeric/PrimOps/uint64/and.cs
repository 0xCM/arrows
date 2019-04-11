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
    public class UInt64And : BinaryPrimOpsTest<UInt64And,operand>
    {        
        public const string Path = P.primops + P.uint64 + P.and;

        public UInt64And()
            : base(Defaults.UInt64Range)
        {
            
        }

        public override void Verify()
            => base.Verify();

        public override IReadOnlyList<operand> Baseline()
        {
            var dst = target();
            iter((int)SampleSize, i =>
                dst[i] = LeftSrc[i] & RightSrc[i]);
            return dst;
        }

        public override IReadOnlyList<operand> Compute()
            => fuse(LeftSrc,RightSrc, Prim.and);
    } 

}