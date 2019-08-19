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
    using static Nats;


    public class BitVectorPermTest : UnitTest<BitVectorPermTest>
    {

        public void Permute()
        {
        
            var p1 = Perm.Define<N8,byte>((2,3), (6,7));
            var bsx1 = ((byte)0b10001101).ToBitString();
            var bsy1 = BitString.Parse("01001101");
            var bsz1 = bsx1.Permute(p1);
            Claim.eq(bsy1, bsz1);
            
            var p2 = Perm.Define<N16,byte>((1,10), (2,11), (3, 8));
            var bsx2 = ((ushort)0b1000110111000100).ToBitString();
            var bsy2 =  BitString.FromBitSeq(bsx2.BitSeq.Permute(p2));
            var bsz2 = bsx2.Permute(p2);            
            Claim.eq(bsy2, bsz2);

            var bsx3 = BitString.Parse("01001101");
            // 0 ->  0 
            // 1 ->  1 
            // 2 ->  2 
            // 3 ->  3
            // 4 ->  4
            // 5 ->  5
            // 6 ->  6
            // 7 ->  7


            // 0 ->  0 | 0
            // 2 ->  2 | 1
            // 3 ->  3 | 2
            // 6 ->  6 | 3



            // The on bits define an unambiguous subset of the identity permutation on 8 symbols

        }

    }

}