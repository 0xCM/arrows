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

    public class BitReaderTest : UnitTest<BitReaderTest>
    {
        const ulong U64_00 = 0b00001001_11110000_11001001_10011111_00010001_10111100_00111000_11110000;
        
        const uint U32_01 = 0b00001001_11110000_11001001_10011111;

        void GenTestData()
        {
            var src = Random.Array<ulong>(8);
            var j=(byte)0;
            for(byte i=0; i< src.Length; i++)
            {
                var u64 = src[i];
                var bs = u64.ToBitString().Format(false,true,8);
                Trace($"public const ulong U64_{i.FormatHex(true,false)} = {bs};");

                (var u32_0, var u32_1) = Bits.split(u64);
                var u32_0bs = u32_0.ToBitString().Format(false,true,8);
                var u32_1bs = u32_1.ToBitString().Format(false,true,8);
                Trace($"public const uint U32_{j++.FormatHex(true,false)} = {u32_0bs};");
                Trace($"public const uint U32_{j++.FormatHex(true,false)} = {u32_1bs};");
            }
        }

        public void Test00()
        {
            Span<byte> dst = stackalloc byte[8];
            
            BitPos pos1 = 0;
            BitPos pos7 = 7;
            var width = pos7 - pos1;
            Claim.eq(8,width);
            
            var r1 = Bits.range(U64_00, 0, 7);
            Claim.eq((byte)0b11110000, r1);

            gbits.range(U64_00, 0, 7, dst, 0);
            Claim.eq((byte)0b11110000, dst[0]);

            gbits.range(U64_00, 8, 15, dst, 0);
            Claim.eq((byte)0b00111000, dst[0]);

            gbits.range(U64_00, 4, 7, dst, 0);
            Claim.eq((byte)0b1111, dst[0]);

            gbits.range(U64_00, 4, 6, dst, 1);
            Claim.eq((byte)0b111, dst[1]);

            gbits.range(U32_01, 7, 8, dst, 2);
            Claim.eq((byte)0b11, dst[2]);                    
        }

        public void TestU64()
        {
            var src = Random.Stream<ulong>().TakeSpan(Pow2.T14);
            for(var i=0; i< src.Length; i++)
            {
                var x = src[i];
                (var x0, var x1) = Bits.split(x);
                var y0 = gbits.range(x, 0, 31);
                var y1 = gbits.range(x, 32, 63);

                Claim.eq(y0,x0);
                Claim.eq(y1,x1);
            }
        }

        public void TestU32()
        {
            var src = Random.Stream<uint>().TakeSpan(Pow2.T14);
            for(var i=0; i< src.Length; i++)
            {
                var x = src[i];
                (var x0, var x1) = Bits.split(x);

                var y0 = gbits.range(x, 0, 15);
                var y1 = gbits.range(x, 16, 31);

                Claim.eq(y0,x0);
                Claim.eq(y1,x1);
            }
        }

        public void TestU16()
        {
            var src = Random.Stream<ushort>().TakeSpan(Pow2.T14);            
            for(var i=0; i< src.Length; i++)
            {
                var x = src[i];
                var x0 = (ushort)x.ReadBits(0, 2)[0];
                var x1 = (ushort)(((ushort)x.ReadBits(3, 5)[0]) << 3);
                var x2 = (ushort)(((ushort)x.ReadBits(6, 8)[0]) << 6);
                var x3 = (ushort)(((ushort)x.ReadBits(9, 11)[0]) << 9);
                var x4 = (ushort)(((ushort)x.ReadBits(12, 14)[0]) << 12);
                var x5 = (ushort)(((ushort)x.ReadBits(15, 15)[0]) << 15);

                var y = x0;
                y |= x1;
                y |= x2;
                y |= x3;
                y |= x4;
                y |= x5;
                Claim.eq(x,y);
            }
        }
    }
}