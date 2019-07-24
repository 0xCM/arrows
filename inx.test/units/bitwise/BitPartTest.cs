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

    public class BitPartTest : UnitTest<BitPartTest>
    {
        void VerifyBitChars<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Span<T>(Pow2.T08);
            for(var i=0; i<src.Length; i++)
            {
                Span<char> bc1 = gbits.bitchars(src[i]).ToSpan();
                Span<char> bc2 = new char[SizeOf<T>.BitSize];
                for(byte j=0; j<bc2.Length; j++)
                    bc2[j] = gbits.test(src[i], j) ? '1' : '0';
                Claim.yea(bc1.SequenceEqual(bc2));
            }

            TypeCaseEnd<T>();
        }

        void VerifyBitStrings<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Span<T>(Pow2.T08);
            for(var i=0; i<src.Length; i++)
            {
                var bc1 =  BitString.FromScalar(src[i]).Format();
                var bc2 = gbits.bstext(src[i]);
                var bc3 = BitString.FromScalar(src[i]);
                Claim.eq(bc1,bc2);
                Claim.eq(bc1,bc3);
            }

            TypeCaseEnd<T>();
        }

        void VerifyBitSeq1<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Span<T>(Pow2.T08);
            for(var i=0; i<src.Length; i++)
            {
                var x0 = src[i];
                var x1 =  gbits.bitseq(x0);                
                gbits.packseq(x1, out T x2);
                Claim.eq(x0, x2);
            }
            TypeCaseEnd<T>();
        }

        void VerifyBitSeq2<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Span<T>(Pow2.T08);
            for(var i=0; i<src.Length; i++)
            {
                var x0 = src[i];
                var x1 = gbits.bitseq(x0);
                var seqlen = x1.Length;
                Claim.eq(seqlen, SizeOf<T>.BitSize);

                for(byte j = 0; j < seqlen; j++)
                    Claim.eq(gbits.test(x0, j), x1[j] == 1);
            }

            TypeCaseEnd<T>();
        }

        void VerifyBitParse<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Span<T>(Pow2.T08);
            for(var i=0; i<src.Length; i++)
            {
                var x = gbits.bitchars(src[i]);
                gbits.parse(x, 0, out T y);
                Claim.eq(src[i], y);                
            }

            TypeCaseEnd<T>();
        }

        public void VerifyBitChars()
        {
            VerifyBitChars<byte>();
            VerifyBitChars<sbyte>();
            VerifyBitChars<ushort>();
            VerifyBitChars<short>();
            VerifyBitChars<uint>();
            VerifyBitChars<int>();
            VerifyBitChars<ulong>();
            VerifyBitChars<long>();
        }

        public void VerifyBitStrings()
        {
            VerifyBitStrings<byte>();
            VerifyBitStrings<sbyte>();
            VerifyBitStrings<ushort>();
            VerifyBitStrings<short>();
            VerifyBitStrings<uint>();
            VerifyBitStrings<int>();
            VerifyBitStrings<ulong>();
            VerifyBitStrings<long>();
        }

        public void VerifyBitParse()
        {
            VerifyBitParse<byte>();
            VerifyBitParse<sbyte>();
            VerifyBitParse<ushort>();
            VerifyBitParse<short>();
            VerifyBitParse<uint>();
            VerifyBitParse<int>();
            VerifyBitParse<ulong>();
            VerifyBitParse<long>();
        }

        public void VerifyBitSeq()
        {
            
            VerifyBitSeq1<byte>();
            VerifyBitSeq1<ushort>();
            VerifyBitSeq1<uint>();
            VerifyBitSeq1<ulong>();

            VerifyBitSeq2<byte>();
            VerifyBitSeq2<ushort>();
            VerifyBitSeq2<uint>();
            VerifyBitSeq2<ulong>();
        }
    }

}
