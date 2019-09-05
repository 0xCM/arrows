//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class tbv_128 : UnitTest<tbv_128>
    {

        public void bv_xor()
        {
            var vectors = Random.BitVectors(n128);
            for(var i=0; i< SampleSize; i++)
            {
                var x = vectors.First();
                var y = vectors.First();
                var z = x ^ y;

                var xbs = x.ToBitString();
                var ybs = y.ToBitString();
                var zbs = xbs ^ ybs;

                Claim.eq(zbs, z.ToBitString());
            }

        }

        public void bv_sll()
        {
            var v1 = BitVector128.Ones;
            var n = 128;
            
            var offset = 5;

            var v2 = v1 << offset;
            var totalOffset = offset;

            Trace(() => v2.FormatBits(false,false,8));
            Claim.eq(totalOffset, v2.Ntz());
            Claim.eq(n - totalOffset, v2.Pop());

            v2 <<= offset;
            totalOffset += offset;

            Claim.eq(totalOffset, v2.Ntz());
            Claim.eq(n - totalOffset, v2.Pop());
            

        }


    }

}