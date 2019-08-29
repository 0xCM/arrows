//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static Nats;
    using static x86;

    public class tv_slli : UnitTest<tv_slli>
    {

        public void slli256u8()
        {
            var src = Random.Stream<byte>();
            var offsets = Random.Stream(closed<byte>(2,6));

            for(var i=0; i< DefaltCycleCount; i++)
            {
                var x = Vec256.Load(src.TakeSpan(Vec256<byte>.Length));
                var offset = offsets.First();
                var actual = Bits.sll(x,offset);
                var expect = Vec256.Load(BitRef.ShiftL(x.ToSpan(), offset));                
                Claim.eq(expect,actual);             
            }

        }

        public void srli256u8()
        {
            var src = Random.Stream<byte>();
            var offsets = Random.Stream(closed<byte>(2,6));

            for(var i=0; i< DefaltCycleCount; i++)
            {
                var x = Vec256.Load(src.TakeSpan(Vec256<byte>.Length));
                var offset = offsets.First();
                var actual = Bits.srli(x,offset);
                var expect = Vec256.Load(BitRef.ShiftR(x.ToSpan(), offset));                
                Claim.eq(expect,actual);             
            }
        }

        public void slli256u64()
        {
            var src = Random.CpuVec256<ulong>();
            for(byte i=1; i<=5; i++)
            {
                var a = Bits.sll(in src, i).ToSpan256();
                var b = BitRef.ShiftL(src.ToReadOnlySpan(), i, a.Replicate(true));
                Claim.eq(a,b);
            }            
        }



        public void shuffleId()
        {
            var id = ShuffleIdentityMask();
            for(var i=0; i<DefaltCycleCount; i++)
            {
                var x = Random.CpuVec256<byte>();
                var y = dinx.shuffle(x, id);
                Claim.eq(x,y);
            }
        }

        public void shuffleTruncate()
        {
            var tr = Vec256Pattern.ClearAlt<byte>();
            for(var i=0; i<DefaltCycleCount; i++)
            {
                var x = Random.CpuVec256<byte>();
                var y = dinx.shuffle(x, tr);
                var xs = x.ToSpan256();
                for(var j =0; j< xs.Length; j++)
                {
                    if(j % 2 != 0)
                        xs[j] = 0;
                }

                var xt = xs.ToCpuVec256();                

                Claim.eq(xt,y);
            }
        }

        static Vec256<byte> ShuffleIdentityMask()
        {
            Span256<byte> mask = Span256.Alloc<byte>(1);

            //For the first 128-bit lane
            var half = mask.Length/2;
            for(byte i=0; i< half; i++)
                mask[i] = i;

            //For the second 128-bit lane
            for(byte i=0; i< half; i++)
                mask[i + half] = i;

            return Vec256.Load(mask);
        }


        // Truncates alternating source vector components
        static Vec256<T> ShuffleTruncateMask<T>()
            where T : struct

        {
            var mask = Span256.Alloc<T>(1);
            var chop = PrimalInfo.Get<T>().MaxVal;
            
            //For the first 128-bit lane
            var half = mask.Length/2;
            for(byte i=0; i< half; i++)
            {
                if(i % 2 != 0)
                    mask[i] = chop;
                else
                    mask[i] = convert<byte,T>(i);
            }

            //For the second 128-bit lane
            for(byte i=0; i< half; i++)
            {
                if(i % 2 != 0)
                    mask[i + half] = chop;
                else
                    mask[i + half] = convert<byte,T>(i);
            }

            return Vec256.Load(mask);
        }

        static Vec256<T> BlendAltMask<T>()
            where T : struct
        {
            Span256<T> mask = Span256.Alloc<T>(1);
            var no = PrimalInfo.Get<T>().MaxVal;
            var yes = PrimalInfo.Get<T>().Zero;
            for(byte i=0; i< mask.Length; i++)
            {
                                
                if(i % 2 == 0)
                    mask[i] = yes;
                else
                    mask[i] = no;
            }
            return Vec256.Load(mask);

        }


        OpTime slli256u16Bench(int blocks, int cycles)
        {
            var blocklen = Vec256<ushort>.Length;
            var opcount = blocks*cycles*blocklen;
            var shiftRange = closed<byte>(2,14);
            
            var sw = stopwatch(false);
            var src = Random.Stream<ushort>();
            var offsets = Random.Stream(shiftRange);
            for(var cycle=0; cycle<cycles; cycle++)
            for(var block = 0; block<blocks; block++)
            {
                var x = Vec256.Load(src.TakeSpan(blocklen));
                var offset = offsets.First();
                sw.Start();
                Bits.sll(x,offset);
                sw.Stop();
            
            }
            return OpTime.Define(opcount, snapshot(sw),"slli16u");
        }

        OpTime ShiftLeft256x16uRef(int blocks, int cycles)
        {
            var blocklen = Vec256<ushort>.Length;
            var opcount = blocks*cycles*blocklen;
            var shiftRange = closed<byte>(2,14);
            
            var sw = stopwatch(false);
            var src = Random.Stream<ushort>();
            var offsets = Random.Stream(shiftRange);

            for(var cycle=0; cycle<cycles; cycle++)
            for(var block = 0; block<blocks; block++)
            {
                var x = src.TakeSpan(blocklen);
                var offset = offsets.First();
                
                sw.Start();                
                BitRef.ShiftL(x,offset);
                sw.Stop();
            }
            return OpTime.Define(opcount, snapshot(sw),"slli16uRef");            
        }

        OpTime slli256u8Bench(int blocks, int cycles)
        {
            var blocklen = Vec256<byte>.Length;
            var opcount = blocks*cycles*blocklen;
            var shiftRange = closed<byte>(2,6);

            var sw = stopwatch(false);
            var src = Random.Stream<byte>();
            var offsets = Random.Stream(shiftRange);

            for(var cycle=0; cycle<cycles; cycle++)
            for(var block = 0; block<blocks; block++)
            {
                var offset = offsets.First();
                var x = Vec256.Load(src.TakeSpan(blocklen));
                sw.Start();
                var y = Bits.sll(x,offset);
                var z = Bits.srli(y,offset);
                sw.Stop();
            
            }
            return OpTime.Define(opcount, snapshot(sw),"slli8u");
        }

        OpTime slli2568uRefBench(int blocks, int cycles)
        {
            var blocklen = Vec256<byte>.Length;
            var opcount = blocks*cycles*blocklen;
            var shiftRange = closed<byte>(2,6);

            var sw = stopwatch(false);
            var src = Random.Stream<byte>();
            var offsets = Random.Stream(shiftRange);

            for(var cycle=0; cycle<cycles; cycle++)
            for(var block = 0; block<blocks; block++)
            {
                var x = src.TakeSpan(blocklen);
                var offset = offsets.First();
                
                sw.Start();                
                BitRef.ShiftL(x,offset);
                sw.Stop();
            }
            return OpTime.Define(opcount, snapshot(sw),"slli8uRef");            
        }

        OpTime ShiftLeft8uDirect(int opcount)
        {
            var shiftRange = closed<int>(2,6);
            var sw = stopwatch(false);
            var src = Random.Stream<byte>();
            var offsets = Random.Stream(shiftRange);
            byte y = 0;
            for(var i=0; i<opcount; i++)
            {
                var x = src.First();
                var offset = offsets.First();
                sw.Start();
                y = (byte)(x << offset);
                sw.Stop();
            }

            return OpTime.Define(opcount, snapshot(sw),"x << i");            
        }
        
        public void ShiftLeftBench()
        {
            GC.Collect();
            TracePerf(slli256u8Bench(Pow2.T10, Pow2.T05));   
            GC.Collect();
            TracePerf(slli2568uRefBench(Pow2.T10, Pow2.T05));   
            GC.Collect();
            TracePerf(slli256u16Bench(Pow2.T10, Pow2.T05));   
            GC.Collect();
            TracePerf(ShiftLeft256x16uRef(Pow2.T10, Pow2.T05));   
            GC.Collect();
            TracePerf(ShiftLeft8uDirect(1048576));
        }

        static BitVector32[]  GfPoly =
        {
            0b00000000000000000000000000000000,
            0b00000000000000000000000000000001,
            0b00000000000000000000000000000111,
            0b00000000000000000000000000001101,
            0b00000000000000000000000000010111,
            0b00000000000000000000000000101101,
            0b00000000000000000000000001100111,
            0b00000000000000000000000011010011,
            0b00000000000000000000000110110011,
            0b00000000000000000000001111111101,
            0b00000000000000000000011111011011,
            0b00000000000000000000111110100101,
            0b00000000000000000010011110001011,
            0b00000000000000000100111001000001,
            0b00000000000000001010010001110111,
            0b00000000000000011000011010100011,
            0b00000000000000110011010001011101,
            0b00000000000001100001101010001011,
            0b00000000000011110100001100001001,
            0b00000000000111101000010010101111,
            0b00000000001111010000100100001011,
            0b00000000100110001001011010000101,
            0b00000001001100010010110100000011,
            0b00000010011000100101101000101001,
            0b00000101111101011110000111001111,
            0b00001011111010111100001000001011,
            0b00010111110101111000010001101011,
            0b00111011100110101100101000101111,
            0b01110111001101011001010000001011,
            0b11101110011010110010100000000101,
        };

        BitVector32 gfmul(BitVector32 x, BitVector32 y, int w)
        {

            var result = 0u;
            BitVector32 ws1 = (1u << w) - 1u;
            BitVector32 ws2 = 1u << (w - 1);
            
            Span<BitVector32> dot = stackalloc BitVector32[w];
            for (var i = 0; i < w; i++) 
            {
                dot[i] = y;
                if ((y & ws2 ) != BitVector32.Zero)
                {
                    y <<= 1;
                    y = (y ^ GfPoly[w]) & ws1;
                } 
                else 
                    y <<= 1;
            }

            for (var i = 0; i < w; i++) 
            {
                var index = (1u << i);
                if ((index & x) != 0) 
                {
                    var j = 1u;
                    for (var k = 0; k < w; k++) 
                    {
                        result = result ^ (j & dot[i]);
                        j <<= 1;
                    }
                }
            }
            return result;
        }



        static __m128i reflect_xmm(__m128i X)
        {
            __m128i tmp1,tmp2;
            __m128i AND_MASK = _mm_set_epi32(0x0f0f0f0f, 0x0f0f0f0f, 0x0f0f0f0f, 0x0f0f0f0f);
            __m128i LOWER_MASK = _mm_set_epi32(0x0f070b03, 0x0d050901, 0x0e060a02, 0x0c040800);
            __m128i HIGHER_MASK = _mm_set_epi32(0xf070b030, 0xd0509010, 0xe060a020, 0xc0408000);
            __m128i BSWAP_MASK = _mm_set_epi8(0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15);
            tmp2 = _mm_srli_epi16(X, 4);
            tmp1 = _mm_and_si128(X, AND_MASK);
            tmp2 = _mm_and_si128(tmp2, AND_MASK);
            tmp1 = _mm_shuffle_epi8(HIGHER_MASK ,tmp1);
            tmp2 = _mm_shuffle_epi8(LOWER_MASK ,tmp2);
            tmp1 = _mm_xor_si128(tmp1, tmp2);
            return _mm_shuffle_epi8(tmp1, BSWAP_MASK);
        }


        public void TestReflect()
        {
            var bs = BitString.FromPattern((ushort)0b1001_0101_1010_0110, 8);
            var v1 = bs.ToCpuVec128<byte>();
            var v2 = (Vec128<byte>)reflect_xmm(v1);            
        
        }



        //Intel code sample from Carryless multiplication document
        public static Vec128<ulong> gfmul(Vec128<ulong> a, Vec128<ulong> b)
        {

            var tmp3 = dinx.clmul(a, b, ClMulMask.X00);            
            var tmp4 = dinx.clmul(a, b, ClMulMask.X10);            
            var tmp5 = dinx.clmul(a, b, ClMulMask.X01);
            var tmp6 = dinx.clmul(a, b, ClMulMask.X11);
            
            tmp4 = dinx.xor(tmp4, tmp5);            
            tmp5 = dinx.slli(tmp4, 8);
            tmp4 = dinx.srli(tmp4, 8);            
            tmp3 = dinx.xor(tmp3, tmp5);            
            tmp6 = dinx.xor(tmp6, tmp4);
            
            var tmp7 = dinx.srli(tmp3, 31);
            var tmp8 = dinx.srli(tmp6, 31);            
            tmp3 = dinx.slli(tmp3, 1);
            tmp6 = dinx.slli(tmp6, 1);

            var tmp9 = dinx.srli(tmp7, 12);            
            tmp8 = dinx.slli(tmp8, 4);
            tmp7 = dinx.slli(tmp7, 4);
            tmp3 = dinx.or(tmp3, tmp7);
            tmp6 = dinx.or(tmp6, tmp8);
            tmp6 = dinx.or(tmp6, tmp9);

            tmp7 = dinx.slli(tmp3, 31);
            tmp8 = dinx.slli(tmp3, 30);
            tmp9 = dinx.slli(tmp3, 25);

            tmp7 = dinx.xor(tmp7, tmp8);
            tmp7 = dinx.xor(tmp7, tmp9);            
            tmp8 = dinx.srli(tmp7, 4);
            tmp7 = dinx.slli(tmp7, 12);            
            tmp3 = dinx.xor(tmp3, tmp7);

            var tmp2 = dinx.srli(tmp3, 1);
            tmp4 = dinx.srli(tmp3, 2);
            tmp5 = dinx.slli(tmp3, 7);
            tmp2 = dinx.xor(tmp2, tmp4);
            tmp2 = dinx.xor(tmp2, tmp5);
            tmp2 = dinx.xor(tmp2, tmp8);
            tmp3 = dinx.xor(tmp3, tmp2);
            tmp6 = dinx.xor(tmp6, tmp3);

            return tmp6;            
        }

        
        public void VerifyIncrement()
        {            
            var bv = BitVector8.Zero;
            var counter = 0;
            do
                Claim.eq(counter++, (byte)bv);            
            while(++bv);
            Claim.eq(counter, Pow2.T08);

        }
 

    }

}