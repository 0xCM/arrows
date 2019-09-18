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

    public class ts_bitstring : UnitTest<ts_bitstring>
    {

        public void bsshiftr()
        {
            bsshiftr_check<sbyte>();
            bsshiftr_check<byte>();
            bsshiftr_check<short>();
            bsshiftr_check<ushort>();
            bsshiftr_check<int>();
            bsshiftr_check<uint>();
            bsshiftr_check<long>();
            bsshiftr_check<ulong>();
        }

        public void bschars()
        {
            bschars_check<byte>();
            bschars_check<sbyte>();
            bschars_check<ushort>();
            bschars_check<short>();
            bschars_check<uint>();
            bschars_check<int>();
            bschars_check<ulong>();
            bschars_check<long>();
        }

        public void bsfromscalar()
        {
            bsfromscalar_check<byte>();
            bsfromscalar_check<sbyte>();
            bsfromscalar_check<ushort>();
            bsfromscalar_check<short>();
            bsfromscalar_check<uint>();
            bsfromscalar_check<int>();
            bsfromscalar_check<ulong>();
            bsfromscalar_check<long>();
        }

        public void bsconvert()
        {
            bsconvert_check<byte>(Pow2.T08);
            bsconvert_check<ushort>(Pow2.T08);
            bsconvert_check<uint>(Pow2.T08);
            bsconvert_check<ulong>(Pow2.T08);


            var n1 = Random.Next<uint>();
            var n1bs = n1.ToBitString();
            var bs1Num = n1bs.TakeUInt64();
            Claim.eq((ulong)n1, bs1Num);

        }

        public void bsparse()
        {
            bsparse_check1<byte>();
            bsparse_check1<sbyte>();
            bsparse_check1<ushort>();
            bsparse_check1<short>();
            bsparse_check1<uint>();
            bsparse_check1<int>();
            bsparse_check1<ulong>();
            bsparse_check1<long>();


            bsparse_check2(13, 61);
            bsparse_check2(2, 9);

        }

        public void bsseq()
        {
            
            bsseq_check1<byte>();
            bsseq_check1<ushort>();
            bsseq_check1<uint>();
            bsseq_check1<ulong>();

            bsseq_check2<byte>();
            bsseq_check2<ushort>();
            bsseq_check2<uint>();
            bsseq_check2<ulong>();
        }

        public void bsrep()
        {
            bsrep_check<byte>();
            bsrep_check<ushort>();
            bsrep_check<uint>();
            bsrep_check<ulong>();

        }

        public void bspow2()
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

        public void bs_to_u32()
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

        public void bs_to_u8()
        {
            var x = (byte)0b10110110;
            var y = x.ToBitString();
            Claim.eq("10110110", y);
            Claim.eq(5, y.PopCount());
            
            var z = y.Pack();
            Claim.eq(1,z.Length);            
            Claim.eq(x, z[0]);
        }


        public void bs_nlz()
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

        public void bs_seq()
        {
            var srcA = Random.Stream<uint>().Take(SampleSize);
            var srcB = Random.Stream<uint>().Take(SampleSize);
            var pairs = srcA.Zip(srcB);

            foreach(var aVal in srcA)
                Claim.eq(aVal.ToBitString(), aVal.ToBitString());
            
            foreach(var pair in pairs)
                Claim.neq(pair.First.ToBitString(), pair.Second.ToBitString());
        }

        public void bs_truncate()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.BitString(SampleSize);
                Claim.eq(src.Length, SampleSize);

                var len = Random.Next<int>(2, SampleSize - 2);
                var dst = src.Truncate(len);
                Claim.eq(len, dst.Length);
                for(var j=0; j<len; j++)
                    Claim.eq(src[j], dst[j]);
            }
        }

        public void bs_bitview()
        {
            var x = Random.CpuVec256<int>();
            var y = BitView.ViewBits(ref x);
            var ys = y.Bytes.ToBitString();
            var xs = x.ToBitString();
            Claim.eq(ys,xs);
        }

        public void bs_wordgen()
        {            
            var wordLen = 8;
            var wordCount = Pow2.pow(wordLen);
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

        public void bsblocks()
        {
            var src = "0000010100001100101010001";
            var bs = BitString.Parse(src);
            Claim.eq(bs.Length, 25);
            
            var b1 = bs.Partition(1);
            Claim.eq(src.Length, b1.Length);
            
            var b5 = bs.Partition(5);
            Claim.eq(5,b5.Length);

            var b3 = bs.Partition(3);
            Claim.eq(9,b3.Length);
        }

        public void bs_patterns()
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


        public void bs_tlz()
        {
            Claim.eq("100", BitString.FromScalar(0b00000100).Format(true));
            Claim.eq("101", BitString.FromScalar(0b00000101).Format(true));
            Claim.eq("1000101", BitString.FromScalar(0b01000101).Format(true));
            Claim.eq("11010101", BitString.FromScalar(0b11010101).Format(true));
        }

        public void bs_parselit()
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

        public void bs_assemble()
        {
            var src = Random.Span<ulong>(Pow2.T08);

            foreach(var x in src)
            {
                var bsX = x.ToBitString();
                Claim.eq(64, bsX.Length);
                var blocks = bsX.Partition(8);
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

         void bsshiftr_check<T>()
            where T : struct
        {
            TypeCaseStart<T>();

            var signed = gmath.signed<T>();
            var bitsize = BitSize.Size<T>();
            var bs10 = BitString.Parse("1" + repeat('0', bitsize - 1).Concat());
            var x10 = bs10.TakeValue<T>();
            var bs11 = BitString.Parse("11" + repeat('0', bitsize - 2).Concat());
            var x11 = bs11.TakeValue<T>();
            var bs01 = BitString.Parse("01" + repeat('0', bitsize - 2).Concat());
            var x01 = bs01.TakeValue<T>();
            var y = gbits.sar(x10, 1);
            if(signed)
                Claim.eq(x11, y);
            else
                Claim.eq(x01, y);

            TypeCaseEnd<T>();
        }


        void bsrep_check<T>()
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


        void bschars_check<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Span<T>(Pow2.T08);
            for(var i=0; i<src.Length; i++)
            {
                Span<char> bc1 = gbits.bitchars(src[i]).ToSpan();
                Span<char> bc2 = new char[bitsize<T>()];
                for(byte j=0; j<bc2.Length; j++)
                    bc2[j] = gbits.test(src[i], j) ? '1' : '0';
                Claim.yea(bc1.SequenceEqual(bc2));
            }

            TypeCaseEnd<T>();
        }

        void bsfromscalar_check<T>()
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

        void bsseq_check1<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Span<T>(Pow2.T08);
            for(var i=0; i<src.Length; i++)
            {
                var x0 = src[i];
                var x1 = gbits.bitseq(x0);                
                gbits.packseq(x1, out T x2);
                Claim.eq(x0, x2);
            }
            TypeCaseEnd<T>();
        }

        void bsseq_check2<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Span<T>(Pow2.T08);
            for(var i=0; i<src.Length; i++)
            {
                var x0 = src[i];
                var x1 = gbits.bitseq(x0);
                var seqlen = x1.Length;
                Claim.eq(seqlen, bitsize<T>());

                for(byte j = 0; j < seqlen; j++)
                    Claim.eq(gbits.test(x0, j), x1[j] == 1);
            }

            TypeCaseEnd<T>();
        }

 
         void bsconvert_check<T>(int count)
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

        void bsparse_check1<T>()
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

        protected void TraceError(string msg)
            => Trace(errorMsg(msg));

        void bsparse_check2(int minlen, int maxlen)
        {
            for(var cycle=0; cycle< CycleCount; cycle++)
            {            
                var x = Random.BitString(minlen, maxlen);
                var y = BitString.Parse(x).Format();
                var z = BitString.Parse(y);

                Claim.eq(x.Length, y.Length);
                Claim.eq(z.Length, y.Length);                
                for(var i=0; i< x.Length; i++)
                    Claim.eq(x[i], z[i]);
                
                Claim.yea(x.Equals(z, TraceError));
                Claim.eq(x,z);
            }
        }


    }

}