//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class tbv_xor : BitVectorTest<tbv_xor>
    {
        public void bv_xor8()
        {
            bv_xor_check<BitVector8,byte>();
        }

        public void bv_xor16()
        {
            bv_xor_check<BitVector16,ushort>();
        }

        public void bv_xor32()
        {
            bv_xor_check<BitVector32,uint>();
        }


        public void bv_xor64()
        {
            bv_xor_check<BitVector64,ulong>();
        }

        public void bv_xor128()
        {
            bv_xor128_check();
        }

        void bv_xor_check<V,S>()
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {
            for(var i = 0; i< SampleSize; i++)
            {
                var x = Random.Next<S>();
                var y = Random.Next<S>();
                var z = gmath.xor(x, y);

                var v1 = gbits.fixedbits<V,S>(x);
                var v2 = gbits.fixedbits<V,S>(y);
                var v3 = v1 ^ v2;
                Claim.eq(v3.Scalar, z);
            }

        }

        void bv_xor128_check()
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

    }

}