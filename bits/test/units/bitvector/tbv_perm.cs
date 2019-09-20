//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;


    public class tbv_perm : BitVectorTest<tbv_perm>
    {

        public void perm8_example()
        {        
            var perm = Perm.Define<N8>((2,3), (6,7));
            var bs1 = ((byte)0b10001101).ToBitString();
            var bs2 = BitString.Parse("01001101");
            var bs3 = bs1.Permute(perm);
            Claim.eq(bs2, bs3);            

        }


        public void Experiment()
        {
            //Create an explicit bit pattern
            var pattern = Random.Bits().Select(x => (byte)x).TakeArray(32);

            //Push pattern into a 256-bit vector
            var vPattern = Vec256.Load(pattern);

            //Define permutation
            var perm = Perm.Define<N32>((1,10), (2,11), (3, 8));

            var vPerm = Vec256.Load(perm.Terms);

            //var result = dinx.permute(vPattern, vPerm)

            

        }

        public void perm32()
        {
            var p1 = Perm.Define(n32, (31,0), (30,1), (29,2));
            Claim.eq(p1[0],31);
            Claim.eq(p1[1],30);
            Claim.eq(p1[2],29);
            Claim.eq(p1[3], 3);

            var bm = p1.ToBitMatrix();
            Claim.eq(bm[0,31], Bit.On);
            Claim.eq(bm[1,30], Bit.On);
            Claim.eq(bm[2,29], Bit.On);


            var v1 = BitVector32.Zero;
            var v2 = v1.Replicate(p1);

            Claim.eq(v1[31],v2[0]);
            Claim.eq(v1[30],v2[1]);
            Claim.eq(v1[29],v2[2]);
        }

        public void perm64()
        {
            for(var j=0; j<SampleSize; j++)
            {
                var p1 = Random.Perm(n64);
                var v1 = Random.BitVector64();
                var v2 = v1.Replicate(p1);
                for(var i=0; i<v1.Length; i++)
                    Claim.eq(v1[p1[i]], v2[i]);
            }
        }

        public void perm16()
        {        
            var p2 = Perm.Define<N16>((1,10), (2,11), (3, 8));
            var bsx2 = ((ushort)0b1000110111000100).ToBitString();
            var bsy2 =  BitString.FromBitSeq(bsx2.BitSeq.Permute(p2));
            var bsz2 = bsx2.Permute(p2);            
            Claim.eq(bsy2, bsz2);

        }
    }

}