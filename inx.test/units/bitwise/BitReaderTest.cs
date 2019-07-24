//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static BitReaderTestData;

    public class BitReaderTest : UnitTest<BitReaderTest>
    {

        void GenTestData()
        {
            var src = Random.Array<ulong>(8);
            var j=(byte)0;
            for(byte i=0; i< src.Length; i++)
            {
                var u64 = src[i];
                var bs = u64.ToBitString().Format(false,true,8);
                Trace($"public const ulong U64_{i.ToHexString(true,false)} = {bs};");

                (var u32_0, var u32_1) = Bits.split(u64);
                var u32_0bs = u32_0.ToBitString().Format(false,true,8);
                var u32_1bs = u32_1.ToBitString().Format(false,true,8);
                Trace($"public const uint U32_{j++.ToHexString(true,false)} = {u32_0bs};");
                Trace($"public const uint U32_{j++.ToHexString(true,false)} = {u32_1bs};");
            }

        }

        public void Test00()
        {
            Span<byte> dst = stackalloc byte[8];
            U64_00.ReadBits(0u, 7u, dst, 0);
            Claim.eq((byte)0b11110000, dst[0]);

            U64_00.ReadBits(8u, 15u, dst, 0);
            Claim.eq((byte)0b00111000, dst[0]);

            U64_00.ReadBits(4u, 7u, dst, 0);
            Claim.eq((byte)0b1111, dst[0]);

            U64_00.ReadBits(4u, 6u, dst, 1);
            Claim.eq((byte)0b111, dst[1]);


            U32_01.ReadBits(7u, 8u, dst, 2);
            Claim.eq((byte)0b11, dst[2]);
                    
        }

        public void TestU64()
        {
            var src = Random.Stream<ulong>().TakeSpan(Pow2.T14);
            for(var i=0; i< src.Length; i++)
            {
                var x = src[i];
                (var x0, var x1) = Bits.split(x);
                var y0 = x.ReadBits(0, 31).TakeUInt32();
                var y1 = x.ReadBits(32, 63).TakeUInt32();
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
                var y0 = x.ReadBits(0, 15).TakeUInt16();
                var y1 = x.ReadBits(16, 31).TakeUInt16();
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

    static class BitReaderTestData
    {
        public const ulong U64_00 = 0b00001001_11110000_11001001_10011111_00010001_10111100_00111000_11110000;
        public const uint U32_00 = 0b00010001_10111100_00111000_11110000;
        public const uint U32_01 = 0b00001001_11110000_11001001_10011111;
        public const ulong U64_01 = 0b00100000_10110101_10011000_01110010_01110001_10110111_10000000_11011010;
        public const uint U32_02 = 0b01110001_10110111_10000000_11011010;
        public const uint U32_03 = 0b00100000_10110101_10011000_01110010;
        public const ulong U64_02 = 0b00110000_11111101_01010111_00001101_11001000_10101010_10101110_10110011;
        public const uint U32_04 = 0b11001000_10101010_10101110_10110011;
        public const uint U32_05 = 0b00110000_11111101_01010111_00001101;
        public const ulong U64_03 = 0b10111101_11110100_00100010_01011011_01111100_00000101_11101010_11101000;
        public const uint U32_06 = 0b01111100_00000101_11101010_11101000;
        public const uint U32_07 = 0b10111101_11110100_00100010_01011011;
        public const ulong U64_04 = 0b11001001_10011110_11000111_01101101_00101010_11001111_11110001_01010110;
        public const uint U32_08 = 0b00101010_11001111_11110001_01010110;
        public const uint U32_09 = 0b11001001_10011110_11000111_01101101;
        public const ulong U64_05 = 0b11011101_11101001_01010011_01001111_10011100_00101000_10100010_10111010;
        public const uint U32_0a = 0b10011100_00101000_10100010_10111010;
        public const uint U32_0b = 0b11011101_11101001_01010011_01001111;
        public const ulong U64_06 = 0b11011001_00000100_10010011_10100111_10110110_10101010_00001011_00110101;
        public const uint U32_0c = 0b10110110_10101010_00001011_00110101;
        public const uint U32_0d = 0b11011001_00000100_10010011_10100111;
        public const ulong U64_07 = 0b10111100_00010111_11010101_00101101_10111001_00001000_11101100_01101111;
        public const uint U32_0e = 0b10111001_00001000_11101100_01101111;
        public const uint U32_0f = 0b10111100_00010111_11010101_00101101;    }

}