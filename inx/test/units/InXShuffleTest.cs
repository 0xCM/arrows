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
    using static Constants;
    using static Shuffle256;
    
    public enum Shuffle256
    {
        X0 = 0X0,   Y0 = 0x10,
        X1 = 0X1,   Y1 = 0x11,
        X2 = 0X2,   Y2 = 0x12,
        X3 = 0X3,   Y3 = 0x13, 
        X4 = 0X4,   Y4 = 0x14,
        X5 = 0X5,   Y5 = 0x15,
        X6 = 0X6,   Y6 = 0x16,
        X7 = 0X7,   Y7 = 0x17, 
        X8 = 0X8,   Y8 = 0x18,
        X9 = 0X9,   Y9 = 0x19,
        XA = 0XA,   YA = 0x1A,
        XB = 0XB,   YB = 0x1B,
        XC = 0XA,   YC = 0x1C,
        XD = 0XD,   YD = 0x1D,
        XE = 0XE,   YE = 0x1E,
        XF = 0XF,   YF = 0x1F,

    }


    public class InXShuffleTest : UnitTest<InXShuffleTest>
    {
        const byte Mask255 = 0b00000011;
        
        const byte Mask128 = 0b10000000;

        const byte Mask64 = 0b01000000;
        
        public void Shuffle1()
        {
            var mask = Vec128.Fill(Mask128);
            var src = Random.CpuVec128<byte>();
            var dst = dinx.shuffle(in src, in mask);
            var zed = Vec128.Fill((byte)0);
            
            Claim.eq(dst,zed);
                            
        }

        public void Shuffle2()
        {
            var mask = Vec128.Fill((byte)0b00001111);
            var src = Random.CpuVec128<byte>();
            var dst = dinx.shuffle(in src, in mask);
            //mask = 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111
            //src =  11110110 | 10000110 | 01010010 | 11111000 | 00010100 | 01101011 | 10000001 | 01011000 | 01000111 | 10010100 | 11101100 | 10101100 | 01000011 | 00101000 | 11011010 | 00100110
            //dst =  11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110
            var bsMask = mask.ToBitString().Format(false, false, 8,' ');

        }


        public void Shuffle256u8()
        {
            var v1 = Vec256.FromParts(
                0x00,0x01,0x02,0x03,0x04,0x05,0x06,0x07,
                0x08,0x09,0x0A,0x0B,0x0C,0x0D,0x0E,0x0F,
                0x10,0x11,0x12,0x13,0x14,0x15,0x16,0x17,
                0x18,0x19,0x1A,0x1B,0x1C,0x1D,0x1E,0x1F                
                );
            
            var m1 = Vec256.FromParts(
                0x08,0x09,0x0A,0x0B,0x0C,0x0D,0x0E,0x0F,
                0x00,0x01,0x02,0x03,0x04,0x05,0x06,0x07,
                0x18,0x19,0x1A,0x1B,0x1C,0x1D,0x1E,0x1F,
                0x10,0x11,0x12,0x13,0x14,0x15,0x16,0x17);

            var m2 = Vec256.FromParts(
                0x01,0x02,0x03,0x04,0x05,0x06,0x07,0x08,
                0x09,0x0A,0x0B,0x0C,0x0D,0x0E,0x0F,0x00,
                
                0x11,0x12,0x13,0x14,0x15,0x16,0x17,
                0x18,0x19,0x1A,0x1B,0x1C,0x1D,0x1E,0x1F,0x10
                );


            var s1 = dinx.shuffle(v1,m2);
            Trace(s1.FormatHex());
        }


        public void Shufle128i32()
        {
            var v1 = Vec128.FromParts(0, 1, 2, 3);
            
            //Produces the identity permutation
            var m1 = (byte)0b11_10_01_00;
            
            //Reversal
            var m2 = (byte)0b00_01_10_11;

            //RotL(1)
            var m3 = (byte)0b10_01_00_11;

            var s1 = dinx.shuffle(v1,m1);
            var s2 = dinx.shuffle(v1,m2);
            var s3 = dinx.shuffle(v1,m3);

            

        }

    }

}
