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
    using static Bit;

    public class BitTruncateTest : UnitTest<BitTruncateTest>
    {

        void Truncate64(byte maxlen)
        {
            var source = UInt64.MaxValue; 
            var srclen = 64;

            var bs0 = source.ToBitString();
            Claim.eq(srclen, bs0.PopCount());
            Claim.eq(srclen, bs0.Length);

            var bv0 = bs0.ToBitVector64();
            Claim.eq(srclen, bv0.Pop());
            
            var bs1 = bs0.Truncate(maxlen);
            Claim.eq(maxlen, bs1.PopCount());
            Claim.eq(maxlen, bs1.Length);

            var bv1 = Bits.truncate(bv0.ToScalar(), maxlen).ToBitVector();
            Claim.eq(maxlen, bv1.Pop());

            var bs2 = bs1.Pad(srclen);
            Claim.eq(srclen, bs2.Length);
            Claim.eq(maxlen, bs2.PopCount());
        }

        void Truncate16(byte maxlen)
        {
            var source = UInt16.MaxValue; 
            var srclen = 16;

            var bs0 = source.ToBitString();
            var bv0 = bs0.ToBitVector16();

            Claim.eq(srclen, bs0.PopCount());
            Claim.eq(srclen, bs0.Length);

            Claim.eq(srclen, bv0.Pop());
            
            var bs1 = bs0.Truncate(maxlen);
            Claim.eq(maxlen, bs1.PopCount());
            Claim.eq(maxlen, bs1.Length);

            var bv1 = Bits.truncate(bv0.ToScalar(), maxlen).ToBitVector();
            Claim.eq(maxlen, bv1.Pop());

            var bs2 = bs1.Pad(srclen);
            Claim.eq(srclen, bs2.Length);
            Claim.eq(maxlen, bs2.PopCount());
        }

        void Truncate8(byte maxlen)
        {
            byte source = 0xFF;
            var srclen = 8;

            var bs0 = source.ToBitString();
            var bv0 = bs0.ToBitVector8();

            Claim.eq(srclen, bs0.PopCount());
            Claim.eq(srclen, bs0.Length);

            Claim.eq(srclen, bv0.Pop());
            
            var bs1 = bs0.Truncate(maxlen);
            Claim.eq(maxlen, bs1.PopCount());
            Claim.eq(maxlen, bs1.Length);

            var bv1 = Bits.truncate(bv0.ToScalar(), maxlen).ToBitVector();
            Claim.eq(maxlen, bv1.Pop());

            var bs2 = bs1.Pad(srclen);
            Claim.eq(srclen, bs2.Length);
            Claim.eq(maxlen, bs2.PopCount());
        }

        public void Truncate64()
        {
            Truncate64(10);
            Truncate64(12);
            Truncate64(21);
            Truncate64(33);
            Truncate64(50);

        }

        public void Truncate16()
        {
            Truncate16(3);
            Truncate16(5);
            Truncate16(8);
            Truncate16(9);
            Truncate16(13);

        }

        public void Truncate8()
        {
            Truncate8(2);
            Truncate8(3);
            Truncate8(4);
            Truncate8(5);

        }


    }
}