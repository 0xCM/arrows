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


    public class tbv_perm : UnitTest<tbv_perm>
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