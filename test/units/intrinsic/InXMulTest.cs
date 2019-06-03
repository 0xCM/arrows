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
    
    using static zfunc;


    public class InXMulTest : UnitTest<InXMulTest>
    {

// static inline uint32_t fastrange32(uint32_t word, uint32_t p) {
// 	return (uint32_t)(((uint64_t)word * (uint64_t)p) >> 32);
// }

        /**
        * Fair maps to intervals without division.
        * Reference : http://lemire.me/blog/2016/06/27/a-fast-alternative-to-the-modulo-reduction/
        *
        * (c) Daniel Lemire
        * Apache License 2.0
        *
        *
        * Given a value "word", produces an integer in [0,p) without division.
        * The function is as fair as possible in the sense that if you iterate
        * through all possible values of "word", then you will generate all
        * possible outputs as uniformly as possible.
        */        
        static ulong fastrange(ulong w, ulong p)
        {
            dinx.mul(w,p, out UInt128 dst);
            return dst.x1;
        }

        static uint fastrange(uint w, uint p)
        {
            dinx.mul(w,p, out uint lo, out uint hi);
            return hi;
        }
        

        public void Mul128()
        {
            //Test case comes from https://docs.microsoft.com/et-ee/cpp/intrinsics/umul128?view=vs-2019
            var lhs = 0x0ffffffffffffffful;
            var rhs = 0xf0000000ul;
            dinx.mul(lhs,rhs, out UInt128 dst);
            Claim.eq("0xeffffffffffffff10000000", dst.ToHexString());

            for(var x = 0u; x < 25u; ++x) 
                Claim.lt(fastrange(x,5), 5);        
                
            for(var x = 0ul; x < 1000000ul; ++x) 
                Claim.lt(fastrange(x,5ul),  5ul);
        }

    }

}