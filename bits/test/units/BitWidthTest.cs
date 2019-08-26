//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;

    using static zfunc;
        
    public class BitWidthTest : UnitTest<BitWidthTest>
    {

        public void BitWidth8()
        {
            var x = (byte)0b0;
            var w = Bits.width(in x);
            Claim.eq(w,0);
            
            x = (byte)0b00010000;
            w = Bits.width(in x);
            Claim.eq(w,5);

            x = (byte)0b00000001;
            w = Bits.width(in x);
            Claim.eq(w,1);

            x = (byte)0b10000000;
            w = Bits.width(in x);
            Claim.eq(w,8);

        }

        public void BitWidth32()
        {
            var x = 0xFFu + 1u;
            var w = Bits.width(in x);
            Claim.eq(w,9);

            x = UInt32.MaxValue;
            w = Bits.width(in x);
            Claim.eq(w,32);

        }



    }

}