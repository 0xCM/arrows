//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;
    using D = BitwiseDelegates;

    public class ts_bitmap : UnitTest<ts_bitmap>
    {
        void bitmap_assorted()
        {
            var x1 = 0b1110101_10111_0011111u;
            var y1 = 0b10110100u;
            var z1 = 0b10111_010110100u;
            Bits.bitmap(x1, srcOffset : 7, len:5, dstOffset:9, ref y1);
            Claim.eq(z1,y1);

            var x2 = 0b11111111_11111111_11111111_11111111_11111111_11111111_11111111_11111111ul;
            var y2 = 0b11111111_11111111_11111111_11111111_11111111_00000000_11111111_11111111ul;
            var z2 = 0b11111111_11111111_11111111_11111111_11111111_11111111_11111111_11111111ul;
            Bits.bitmap(x2,srcOffset:16, len:8, dstOffset:16, ref y2);
            Claim.eq(z2, y2);

            var x3 = 0b11111111_11111111_11111111_11111111_11111111_11111101_01011111_11111111ul;
            var y3 = 0ul;
            var z3 = 0b00000000_00000000_00000000_00000000_00000000_00000101_01000000_00000000ul;
            Bits.bitmap(x3,srcOffset:13, len:6, dstOffset:13, ref y3);
            Claim.eq(z3, y3);

        }

        public void bitmap_8x64()
        {
            var dst = 0ul;
            byte srclen = 8;
            byte srcOffset = 0;
            BitVector64 src = 0b11110000110011001010101011111111ul;
            
            Bits.bitmap(src.Byte(0), srcOffset, srclen, 0, ref dst);
            Bits.bitmap(src.Byte(1), srcOffset, srclen, 8, ref dst);
            Bits.bitmap(src.Byte(2), srcOffset, srclen, 8, ref dst);
            Bits.bitmap(src.Byte(3), srcOffset, srclen, 8, ref dst);

            BitVector64 expect = 0b11111111101010101100110011110000ul;
            BitVector64 actual = dst;

            Claim.eq(expect, actual);

        
        }



    }

}