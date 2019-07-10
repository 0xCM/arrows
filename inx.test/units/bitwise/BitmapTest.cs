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

    public class BitmapTest : UnitTest<BitmapTest>
    {

        public void Bitmap1()
        {
            var src = 0b1110101_10111_0011111u;
            var srcOffset = (byte)7;
            var srcLen = (byte)5;
            var dst = 0b10110100u;
            var dstOffset = (byte)9;
            var expect = 0b10111_010110100u;
            var actual = Bits.bitmap(src,srcOffset, srcLen, dst, dstOffset);
            Claim.eq(expect,actual);
        }


    }

}