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
            var x10 = bs10.TakePrimalValue<T>();
            var bs11 = BitString.Parse("11" + repeat('0', bitsize - 2).Concat());
            var x11 = bs11.TakePrimalValue<T>();
            var bs01 = BitString.Parse("01" + repeat('0', bitsize - 2).Concat());
            var x01 = bs01.TakePrimalValue<T>();
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
                var a = Bits.shiftl(in src, i).ToSpan256();
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
            var clear = PrimalInfo.Get<T>().MaxVal;
            var zero = PrimalInfo.Get<T>().Zero;
            for(byte i=0; i< mask.Length; i++)
            {
                                
                if(i % 2 == 0)
                    mask[i] = zero;
                else
                    mask[i] = clear;
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
            var dstA = Bits.shiftl(srcX, offset);
            var dstB = Bits.shiftl(srcY, offset);

            // Convert the result vectors back to uint8 and clear every other component
            // to produce a 'bb 00 bb 00...bb 00' pattern for each vector
            var trm = ShuffleTruncateMask<byte>();
            var trA = dinx.shuffle(dstA.As<byte>(), trm);
            var trB = dinx.shuffle(dstB.As<byte>(), trm);
            
            //Create a stagger between the two truncated vectors so that
            //they can be interleaved with blend
            var shB = Bits.shiftlw(trB.As<ushort>(), 1).As<byte>();
            var result = dinx.blend(trA, shB, BlendAltMask<byte>());

            if(trace)
            {
                Trace(() => src);
                Trace(nameof(srcX), srcX.ToString());
                Trace(nameof(srcY), srcY.ToString());
                Trace(() => dstA);
                Trace(() => dstB);
                Trace(() => trA);
                Trace(() => trB);
                Trace(() => shB);
                Trace(() => result);
            }
            return result;
            
        }
        
        public void ShiftLeftv256x8u()
        {
            var src = Random.CpuVec256<byte>();
            byte j = 1;
            var b = ShiftL(src,j);
            var c =  Vec256.Load(BitRef.ShiftL(src.ToSpan(), j));
                

        }

    }

}