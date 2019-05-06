//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Numerics;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    using static ztest;
    using static zfunc;
    

    using operand = System.UInt64;
    using P = Paths;


    [DisplayName(Path)]
    public class UInt64Gcd : BinaryPrimOpsTest<UInt64Gcd,operand>
    {        
        public const string Path = P.primops + P.uint64 + P.gcd;
        
        public override void Verify()
            => base.Verify();

        [Repeat(1)]
        public override Index<operand> Baseline()
        {
            var dst = target();
            iter((int)SampleSize, i =>
                dst[i] = (operand)BigInteger.GreatestCommonDivisor(LeftSrc[i],RightSrc[i]));
            return dst;
        }

        [Repeat(1)]
        public override Index<operand> Compute()
            => fuse(LeftSrc,RightSrc, Prim.gcd);


    } 

}