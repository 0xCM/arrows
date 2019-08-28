//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class t_bitstring : UnitTest<t_bitstring>
    {

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

        public void ScalarConversion()
        {
            ScalarConvert<byte>(Pow2.T08);
            ScalarConvert<ushort>(Pow2.T08);
            ScalarConvert<uint>(Pow2.T08);
            ScalarConvert<ulong>(Pow2.T08);

        }

        public void VerifyBitParse()
        {
            ParseBits1<byte>();
            ParseBits1<sbyte>();
            ParseBits1<ushort>();
            ParseBits1<short>();
            ParseBits1<uint>();
            ParseBits1<int>();
            ParseBits1<ulong>();
            ParseBits1<long>();


            ParseBits3(13, 61);

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

        public void VerifyRepresentations()
        {
            BitStringToValue<byte>();
            BitStringToValue<ushort>();
            BitStringToValue<uint>();
            BitStringToValue<ulong>();

        }

        public void VerifyPow2()
        {
            for(var i=0; i<=231; i++)
            {
                var bs = BitString.FromPow2(i);
                Claim.eq((int)bs.Length, i + 1);
                for(var j=0; j<bs.Length; j++)
                {
                    if(j != bs.Length - 1)
                        Claim.eq(bs[j], Bit.Off);
                    else
                        Claim.eq(bs[j], Bit.On);
                }
                
                if(i <= 63)
                {
                    var val1 = Pow2.pow((byte)i);
                    var val2 = bs.TakeValue<ulong>();
                    Claim.eq(val1,val2);
                }    
            }
        }

        public void ConvertU32()
        {
            var x0 = 0b_01011000_00001000_11111010_01100101u;
            var x1 = x0.ToBitString();
            var x2 = x1.TakeValue<uint>();
            Claim.eq(x0,x2);            

            var x = 0b10100001100101010001u;
            var bsSrc = "0000010100001100101010001";
            var bs1 = BitString.Parse(bsSrc);
            Claim.eq((int)bs1.Length, bsSrc.Length);

            var bs2 = BitString.FromScalar(x);
            var y = bs1.TakeValue<uint>();
            Claim.eq(x,y);
            Claim.yea(bs1.Equals(bs2));

        }

        public void ConvertU8()
        {
            var x = (byte)0b10110110;
            var y = x.ToBitString();
            Claim.eq("10110110", y);
            Claim.eq(5, y.PopCount());
            
            var z = y.Pack();
            Claim.eq(1,z.Length);            
            Claim.eq(x, z[0]);
        }


        public void VerifyNlz()
        {
            var src = Random.BitStrings(5, 60).Take(Pow2.T14);
            foreach(var bs in src)
            {
                var bvX = bs.TakeValue<ulong>().ToBitString();
                var nlzX = bvX.PopCount();
                var bv = bs.ToBitVector64();
                var nlzY = bv.Pop();
                Claim.eq(nlzX, nlzY);
            }

        }

        public void Equality()
        {
            var srcA = Random.Stream<uint>().Take(Pow2.T14);
            var srcB = Random.Stream<uint>().Take(Pow2.T14);
            var pairs = srcA.Zip(srcB);

            foreach(var aVal in srcA)
                Claim.eq(aVal.ToBitString(), aVal.ToBitString());
            
            foreach(var pair in pairs)
                Claim.neq(pair.First.ToBitString(), pair.Second.ToBitString());
        }

        public void BitViewBitString()
        {
            var x = Random.CpuVec256<int>();
            var y = BitView.ViewBits(ref x);
            var ys = y.ToSpan().ToBitString();
            var xs = x.ToBitString();
            Claim.eq(ys,xs);
        }

        public void VerifyWordGen()
        {            
            var wordLen = 8;
            var wordCount = Pow2<int>.pow(wordLen);
            var words = BinaryLanguage.Get().Words(wordLen).ToArray();
            Claim.eq(wordCount, words.Length);
            
            iter(words, w => Claim.eq(wordLen, w.Format().Length));
            
            for(var i=0u; i<wordCount; i++)
            {
                var w = words[i];
                var value = w.TakeValue<byte>();
                Claim.eq(i, value);
            }
        }    

        public void TestBlockage()
        {
            var src = "0000010100001100101010001";
            var bs = BitString.Parse(src);
            Claim.eq(bs.Length, 25);
            
            var b1 = bs.Blocks(1);
            Claim.eq(src.Length, b1.Length);
            
            var b5 = bs.Blocks(5);
            Claim.eq(5,b5.Length);

            var b3 = bs.Blocks(3);
            Claim.eq(9,b3.Length);
        }

        public void VerifyPatternCreate()
        {
            var p1 = (byte)0b11001110;
            var s1 = BitString.FromPattern(p1, 4);
            Claim.eq(s1.Length,32);
            Claim.eq(p1.ToBitString(), s1[8..15]);

            var p2 = (ushort)0b1111111100010001;
            var s2 = BitString.FromPattern(p2, 2);
            Claim.eq(s2.Length,32);
            Claim.eq(p2.ToBitString(), s2[0..15]);
        }


        public void ParseLiterals()
        {
            var a = BitString.Parse("01010111");
            var b = a.TakeValue<byte>();
            Claim.eq((byte)0b01010111, b);

            var x =  0b111010010110011010111001110000100001101ul;
            var xbs = BitString.Parse("111010010110011010111001110000100001101");
            var ybs = x.ToBitString();
            Claim.eq(xbs, ybs);                

            var y = xbs.TakeValue<ulong>();
            Claim.eq(x, y);

            var z = ybs.TakeValue<ulong>();
            Claim.eq(x, z);

            var byx = BitConverter.GetBytes(x).ToSpan();
            Bytes.write(x, out Span<byte> byy);
            Claim.eq(byx,byy);
        }

        public void BlockBitString()
        {
            var src = Random.Span<ulong>(Pow2.T08);

            foreach(var x in src)
            {
                var bsX = x.ToBitString();
                Claim.eq(64, bsX.Length);
                var blocks = bsX.Blocks(8);
                Claim.eq(8, blocks.Length);   

                var bsY = BitString.Assemble(blocks.Select(x => x.Format()).ToArray());
                Claim.eq(bsX, bsY);
                
                var bytes = span<byte>(8);
                for(var i=0; i<8; i++)         
                    bytes[i] = blocks[i].TakeValue<byte>();
                
                var j = 0;
                var y = Bits.pack(bytes[j++], bytes[j++], bytes[j++], bytes[j++], 
                    bytes[j++], bytes[j++], bytes[j++], bytes[j++]);
                Claim.eq(x,y);                
            }

        }

        void BitStringToValue<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Span<T>(Pow2.T08);
            for(var i=0; i<src.Length; i++)
            {
                var x = src[i];
                var bs = BitString.FromScalar(src[i]);
                var y = bs.TakeValue<T>();
                Claim.eq(x,y);
                Claim.eq(bs.Format(), BitString.FromScalar(y).Format());
            }

            TypeCaseEnd<T>();                
        }


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

        void ParseBits1<T>()
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
 
         void ScalarConvert<T>(int count)
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Span<T>(count);
            foreach(var x in src)
            {
                var y = BitString.FromScalar(x);
                var z = y.TakeValue<T>();
                Claim.eq(x,z);
            }
            TypeCaseEnd<T>();            
        }

        void ParseBits3(int minlen, int maxlen, int cycles = DefaltCycleCount)
        {
            var src = Random.BitStrings(minlen, maxlen);
            for(var cycle=0; cycle< cycles; cycle++)
            {            
                var x = src.First();
                var y = BitString.Parse(x).Format();
                var z = BitString.Parse(y);

                Claim.eq(x.Length, y.Length);
                Claim.eq(z.Length, y.Length);                
                Claim.yea(x.Equals(z));
            }
        }


    }

}