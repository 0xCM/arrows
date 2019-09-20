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

    public class ts_trunc : ScalarBitTest<ts_trunc>
    {
        public void trunc8u()
        {
            trunc8(2);
            trunc8(3);
            trunc8(4);
            trunc8(5);
        }

        public void trunc16u()
        {
            trunc16u(3);
            trunc16u(5);
            trunc16u(8);
            trunc16u(9);
            trunc16u(13);

        }

        public void trunc64u()
        {
            trunc64u(10);
            trunc64u(12);
            trunc64u(21);
            trunc64u(33);
            trunc64u(50);
        }

        void trunc64u(byte maxlen)
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

            var bv1 = Bits.trunc(bv0.Scalar, maxlen).ToBitVector();
            Claim.eq(maxlen, bv1.Pop());

            var bs2 = bs1.Pad(srclen);
            Claim.eq(srclen, bs2.Length);
            Claim.eq(maxlen, bs2.PopCount());
        }

        void trunc16u(byte maxlen)
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

            var bv1 = Bits.trunc(bv0.Scalar, maxlen).ToBitVector();
            Claim.eq(maxlen, bv1.Pop());

            var bs2 = bs1.Pad(srclen);
            Claim.eq(srclen, bs2.Length);
            Claim.eq(maxlen, bs2.PopCount());
        }

        void trunc8(byte maxlen)
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

            var bv1 = Bits.trunc(bv0.Scalar, maxlen).ToBitVector();
            Claim.eq(maxlen, bv1.Pop());

            var bs2 = bs1.Pad(srclen);
            Claim.eq(srclen, bs2.Length);
            Claim.eq(maxlen, bs2.PopCount());
        }

    }
}