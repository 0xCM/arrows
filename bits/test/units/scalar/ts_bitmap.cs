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
        public void bitmap_32u()
        {
            var src = 0b1110101_10111_0011111u;
            var dst = 0b10110100u;
            var expect = 0b10111_010110100u;
            Bits.bitmap(src, srcOffset : 7, len:5, dstOffset:9, ref dst);
            Claim.eq(expect,dst);
        }

        public void bitmap_64u()
        {
            var src = 0b11111111_11111111_11111111_11111111_11111111_11111111_11111111_11111111ul;
            var dst = 0b11111111_11111111_11111111_11111111_11111111_00000000_11111111_11111111ul;
            var exp = 0b11111111_11111111_11111111_11111111_11111111_11111111_11111111_11111111ul;
            Bits.bitmap(src,srcOffset:16, len:8, dstOffset:16, ref dst);
            Claim.eq(exp, dst);

            src = 0b11111111_11111111_11111111_11111111_11111111_11111101_01011111_11111111ul;
            dst = 0;
            exp = 0b00000000_00000000_00000000_00000000_00000000_00000101_01000000_00000000ul;
            Bits.bitmap(src,srcOffset:13, len:6, dstOffset:13, ref dst);
            Claim.eq(exp, dst);

        }

    }

}