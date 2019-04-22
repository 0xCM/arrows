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
    public class UInt32Inc : UnaryPrimOpsTest<UInt32Inc,operand>
    {        
        public const string Path = P.primops + P.uint32 + P.inc;

        public UInt32Inc()
            : base(Defaults.UInt32Domain)
        {
            
        }

        public override void Verify()
            => base.Verify();

        public override Index<operand> Baseline()
        {
            var dst = target();
            iter((int)SampleSize, i =>
                dst[i] = PrimSrc[i] + 1);
            return dst;
        }


        public override Index<operand> Compute()
            => map(PrimSrc, Prim.inc);
            


    } 

}