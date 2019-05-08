//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    
    using static mfunc;
    using static zfunc;


    sealed class BitVectorTest : UnitTest<BitVectorTest>
    {

        public void SetBits()
        {
            var bv = BitVectorU64.Zero;
            var it = It.Define(Pow2.MinExponent, Pow2.MaxExponent + 1);
            while(++it)
                bv[it] = 1;

            Claim.eq(UInt64.MaxValue, bv);

        }

        public void Split()
        {
            var bv = BitVectorU64.Define(UInt64.MaxValue);
            (var lo, var hi) = bv.Split();
            Claim.eq(UInt32.MaxValue, lo);
            Claim.eq(UInt32.MaxValue, hi);
        }
    }

}