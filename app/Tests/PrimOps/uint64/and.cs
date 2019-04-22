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
            : base(Defaults.UInt64Domaim)
        {
            
        }

        public override void Verify()
            => base.Verify();

        public override Index<operand> Baseline()
        {
            var dst = target();
            iter((int)SampleSize, i =>
                dst[i] = LeftSrc[i] & RightSrc[i]);
            return dst;
        }

        public override Index<operand> Compute()
            => fuse(LeftSrc,RightSrc, Prim.and);
    
    
        public void Test1()
        {
            var x0 = 0b01011011ul;
            var y0 = 0b11001001ul;
            var z0 = x0 & y0;
            var z1 = primops.and(x0,y0);
            ClaimEq(z0,z1);
        }

        public void Test2()
        {
            var x0 = index(0b01011011ul,0b11001001ul);
            var y0 = index(0b11001001ul, 0b01011011ul);
            var z0 = index(x0[0] & y0[0], x0[1] & y0[1]);
            var z1 = primops.and(x0,y0);
            ClaimEq(z0,z1);

        }
    
    } 

}