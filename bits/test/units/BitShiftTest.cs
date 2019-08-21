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

    public class BitShiftTest : UnitTest<BitShiftTest>
    {
        void ShiftRight<T>()
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
            var y = gbits.shiftr(x10, 1);
            if(signed)
                Claim.eq(x11, y);
            else
                Claim.eq(x01, y);

            TypeCaseEnd<T>();
        }

        public void ShiftRight()
        {
            ShiftRight<sbyte>();
            ShiftRight<byte>();
            ShiftRight<short>();
            ShiftRight<ushort>();
            ShiftRight<int>();
            ShiftRight<uint>();
            ShiftRight<long>();
            ShiftRight<ulong>();
        }

        public void ShiftLeftv256x64u()
        {
            var src = Random.CpuVec256<ulong>();
            for(byte i=1; i<=5; i++)
            {
                var a = Bits.slli(in src, i).ToSpan256();
                var b = BitRef.ShiftL(src.ToReadOnlySpan(), i, a.Replicate(true));
                Claim.eq(a,b);
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

        public void VerifyIdentityMask()
        {
            var id = ShuffleIdentityMask();
            for(var i=0; i<DefaltCycleCount; i++)
            {
                var x = Random.CpuVec256<byte>();
                var y = dinx.shuffle(x, id);
                Claim.eq(x,y);
            }
        }

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

        public void VerifyTruncateMask()
        {
            var tr = ShuffleTruncateMask<byte>();
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

                var xt = xs.ToVec256();                

                Claim.eq(xt,y);
            }

        }

        //This doesn't work : - (
        Vec256<byte> ShiftL(Vec256<byte> src, byte offset, bool trace = false)
        {
            //Fan the hi/lo parts of the u8 source vector across 2 u16 vectors
            ref var srcX = ref dinx.convert(dinx.lo(src), out Vec256<ushort> _);
            ref var srcY = ref dinx.convert(dinx.hi(src), out Vec256<ushort> _);
            
            //Shift each part with a concrete intrinsic
            var dstA = Bits.slli(srcX, offset);
            var dstB = Bits.slli(srcY, offset);

            // Convert the result vectors back to uint8 and clear every other component
            // to produce a 'bb 00 bb 00...bb 00' pattern for each vector
            var trm = ShuffleTruncateMask<byte>();
            var trA = dinx.shuffle(dstA.As<byte>(), trm);
            var trB = dinx.shuffle(dstB.As<byte>(), trm);
            

            //Create a stagger between the two truncated vectors so that
            //they can be interleaved with blend
            var shB = Bits.bslli(trB.As<ushort>(), 1).As<byte>();
            var result = dinx.blend(trA, shB, BlendAltMask<byte>());



            if(trace)
            {
                var expect = Vec256.Load(BitRef.ShiftL(src.ToSpan(), offset));
                Trace(() => trA);
                Trace(() => trB);
            }
            return result;
            
        }
        
        public void ShiftLeftv256x8u()
        {
            //var src = Random.CpuVec256<byte>();
            var src = Vec256.FromBytes(
                0, 1, 2, 3, 4, 5, 6, 7, 
                8, 9, 10, 11, 12, 13, 14, 15, 
                16, 17, 18, 19, 20, 21, 22, 23, 
                24, 25, 26, 27, 28, 29, 30, 31 
                );
            byte j = 1;
            var b = ShiftL(src,j,true);
            var c =  Vec256.Load(BitRef.ShiftL(src.ToSpan(), j));
                

        }

        void Shift<T>(Orientation dir, ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs)
            where T : struct
        {            
            var x = lhs.Replicate();

            if(dir == Orientation.Left)
            {
                for(var i=0; i< Samples; i++)
                {
                    gbits.shiftl(ref x[i], rhs[i]);
                    Claim.eq(x[i], gbits.shiftl(lhs[i],rhs[i]));
                }
            }
            else
            {
                for(var i=0; i< Samples; i++)
                {
                    gbits.shiftr(ref x[i], rhs[i]);
                    Claim.eq(x[i], gbits.shiftr(lhs[i],rhs[i]));
                }
            }
        }

        public void ShiftI8()
        {
            var lhs = Random.Array<sbyte>(Samples);            
            var rhs = Random.Array<int>(Samples, closed(0, (int)SizeOf<sbyte>.BitSize));            

            Shift<sbyte>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq((sbyte)(lhs[i] << rhs[i]), gbits.shiftl(lhs[i], rhs[i])));
    
            Shift<sbyte>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq((sbyte)(lhs[i] >> rhs[i]), gbits.shiftr(lhs[i], rhs[i])));    
        }

        public void ShiftU8()
        {
            var lhs = Random.Array<byte>(Samples);            
            var rhs = Random.Array<int>(Samples, closed(0, (int)SizeOf<byte>.BitSize));            

            Shift<byte>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq((byte)(lhs[i] << rhs[i]), gbits.shiftl(lhs[i], rhs[i])));
    
            Shift<byte>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq((byte)(lhs[i] >> rhs[i]), gbits.shiftr(lhs[i], rhs[i])));    
        }

        public void ShiftI32()
        {
            var lhs = Random.Array<int>(Samples);            
            var rhs = Random.Array<int>(Samples, closed(0, (int)SizeOf<int>.BitSize));            

            Shift<int>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] << rhs[i], gbits.shiftl(lhs[i], rhs[i])));
    
            Shift<int>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] >> rhs[i], gbits.shiftr(lhs[i], rhs[i])));
        }

        public void ShiftU32()
        {
            var lhs = Random.Array<uint>(Samples);            
            var rhs = Random.Array<int>(Samples, closed(0, (int)SizeOf<uint>.BitSize));            

            Shift<uint>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] << rhs[i], gbits.shiftl(lhs[i], rhs[i])));
    
            Shift<uint>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] >> rhs[i], gbits.shiftr(lhs[i], rhs[i])));

        }
        public void ShiftI64()
        {
            var lhs = Random.Array<long>(Samples);            
            var rhs = Random.Array<int>(Samples, closed(0, (int)SizeOf<long>.BitSize));            

            Shift<long>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] << rhs[i], gbits.shiftl(lhs[i], rhs[i])));
    
            Shift<long>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] >> rhs[i], gbits.shiftr(lhs[i], rhs[i])));
        }

        public void ShiftU64()
        {
            var lhs = Random.Array<ulong>(Samples);            
            var rhs = Random.Array<int>(Samples, closed(0, (int)SizeOf<ulong>.BitSize));            

            Shift<ulong>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] << rhs[i], gbits.shiftl(lhs[i], rhs[i])));
    
            Shift<ulong>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] >> rhs[i], gbits.shiftr(lhs[i], rhs[i])));
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

        void gfmul (Vec128<ulong> a, Vec128<ulong> b, ref Vec128<ulong> dst)
        {
        
         var tmp3 = dinx.clmul(a, b, 0x00);
         var tmp4 = dinx.clmul(a, b, 0x10);
         var tmp5 = dinx.clmul(a, b, 0x01);
         var tmp6 = dinx.clmul(a, b, 0x11);
         tmp4 = dinx.xor(tmp4, tmp5);
         tmp5 = dinx.slli(tmp4, 8);
         tmp4 = dinx.srli(tmp4, 8);
        //  tmp3 = dinx.xor(tmp3, tmp5);
        //  tmp6 = dinx.xor(tmp6, tmp4);
        //  var tmp7 = dinx.srli(tmp3.As<uint>(), 31);
        //  var tmp8 = dinx.srli(tmp6.As<uint>(), 31);
        //  tmp3 = _mm_slli_epi32(tmp3, 1);
        //  tmp6 = _mm_slli_epi32(tmp6, 1);
        //  tmp9 = _mm_srli_si128(tmp7, 12);
        //  tmp8 = _mm_slli_si128(tmp8, 4);
        //  tmp7 = _mm_slli_si128(tmp7, 4);
        //  tmp3 = dinx.or(tmp3, tmp7);
        //  tmp6 = dinx.or(tmp6, tmp8);
        //  tmp6 = dinx.or(tmp6, tmp9);
        //  tmp7 = _mm_slli_epi32(tmp3, 31);
        //  tmp8 = _mm_slli_epi32(tmp3, 30);
        //  tmp9 = _mm_slli_epi32(tmp3, 25);
        //  tmp7 = _mm_xor_si128(tmp7, tmp8);
        //  tmp7 = _mm_xor_si128(tmp7, tmp9);
        //  tmp8 = _mm_srli_si128(tmp7, 4);
        //  tmp7 = _mm_slli_si128(tmp7, 12);
        //  tmp3 = _mm_xor_si128(tmp3, tmp7);        
        }
        public void TestGf()
        {
            var w = 8;
            BitVector8 bv0 = Pow2.T00;
            BitVector8 bv1 = Pow2.T01 - 1;
            BitVector8 bv2 = Pow2.T02 - 1;
            BitVector8 bv3 = Pow2.T03 - 1;
            BitVector8 bv4 = Pow2.T04 - 1;
            BitVector8 bv5 = Random.BitVector8();
            BitVector8 bv6 = Random.BitVector8();
            BitVector8 bv7 = Random.BitVector8();


            Trace($" {bv1} * {bv2} (gf) = {gfmul(bv1,bv2,w)}");
            Trace($" {bv1} * {bv2} (cl) = {dinx.clmul(bv1,bv2).ToBitVector()}");            

            Trace($" {bv2} * {bv3} (gf) = {gfmul(bv2,bv3,w)}");
            Trace($" {bv2} * {bv3} (cl) = {dinx.clmul(bv2,bv3).ToBitVector()}");            

            Trace($" {bv3} * {bv4} (gf) = {gfmul(bv3,bv4,w)}");
            Trace($" {bv3} * {bv4} (cl) = {dinx.clmul(bv3,bv4).ToBitVector()}");            

            Trace($" {bv4} * {bv4} (gf) = {gfmul(bv4,bv4,w)}");
            Trace($" {bv4} * {bv4} (cl) = {dinx.clmul(bv4,bv4).ToBitVector()}");            

            Trace($" {bv5} * {bv6} (gf) = {gfmul(bv5,bv6,w)}");
            Trace($" {bv5} * {bv6} (cl) = {dinx.clmul(bv5,bv6).ToBitVector()}");            

        }

    }

}