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
        public void Mul128()
        {
            //Test case comes from https://docs.microsoft.com/et-ee/cpp/intrinsics/umul128?view=vs-2019
            var lhs = 0x0ffffffffffffffful;
            var rhs = 0xf0000000ul;
            dinx.umul128(lhs, rhs, out UInt128 dst);
            Claim.eq("0xeffffffffffffff10000000", dst.ToHexString());

        }

        void Mul256u64(int blocks)
        {
            var domain = closed(0ul, UInt32.MaxValue);
            var lhs = Random.Span256<ulong>(blocks, domain);
            var rhs = Random.Span256<ulong>(blocks, domain);
            for(var block=0; block<blocks; block++)
            {
                var x = lhs.LoadVec256(block);
                var y = rhs.LoadVec256(block);
                var z = dinx.mul(x,y); 

                var a = x.Extract().Replicate();
                var b = y.Extract();
                var c = a.Mul(b).LoadVec256(0);
                Claim.eq(z,c);                                           
            }

        }
        public void Mul256u64()
        {
            Mul256u64(Pow2.T11);
        }

    }

}