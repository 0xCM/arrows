//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    
    using static zfunc;
    using static mfunc;

    using static BinaryDigit;
    using static Bit;
    
    public class BitTests : UnitTest<BitTests>
    {
        
        public void Convert()
        {
            static T toInt<T>(Bit b)
                where T : struct
                    => convert<int,T>((int)b); 

            Claim.eq(1, toInt<int>(Bit.On)); 
            Claim.eq(0, toInt<int>(Bit.Off)); 
            Claim.eq(1u, toInt<uint>(Bit.On)); 
            Claim.eq(0u, toInt<uint>(Bit.Off)); 
        }

        public void BitConvert()
        {

            Claim.eq(ZeroU8, (byte)Off);
            Claim.eq(OneU8, (byte)On);

            Claim.eq(ZeroU16, (ushort)Off);
            Claim.eq(OneU16, (ushort)On);

            Claim.eq(0u, (uint)Off);
            Claim.eq(1u, (uint)On);

            Claim.eq(0ul, (ulong)Off);
            Claim.eq(1ul, (ulong)On);

            Claim.eq(BinaryDigit.Zed, Off);
            Claim.eq(BinaryDigit.One, On);

        }


        public void BitOps()
        {

            //parse
            Claim.eq(Off, Z0.Bit.Parse('0'));
            Claim.eq(On, Z0.Bit.Parse('1'));

            //flip
            Claim.eq(On, ~ Off);
            Claim.eq(Off, ~ On);

            //and
            Claim.eq(On, On & On);
            Claim.eq(Off, On & Off);
            Claim.eq(Off, Off & On);
            Claim.eq(Off, Off & Off);

            //or
            Claim.eq(On, Off | On);
            Claim.eq(On, On | Off);
            Claim.eq(Off, Off | Off);
            Claim.eq(On, On | On);
            
            
            //xor
            Claim.eq(On, Off ^ On);
            Claim.eq(On, On ^ Off);
            Claim.eq(Off, Off ^ Off);
            Claim.eq(Off, On ^ On);
        }

        public void BitLayoutTest()
        {
            var l1 = new U32(8u);
            Claim.eq(l1.src,8u);
            Claim.eq(l1.x00,8u);
            Claim.eq(l1.x000,(byte)8);

            l1[1] |= 0b101;
            Claim.eq(l1[1], (byte)0b101);
        }

        public void BitTest()
        {
            Claim.@true(gbits.test(0b00000101, 0));
            Claim.@false(gbits.test(0b00000101, 1));
            Claim.@true(gbits.test(0b00000101, 2));
            
            Claim.@true(gbits.test(0b00000111, 0));
            Claim.@true(gbits.test(0b00000111, 1));
            Claim.@true(gbits.test(0b00000111, 2));
        }

        public void BitParse()
        {
            
            var bs1 = "10001000111";
            var value = gbits.parse<ulong>(bs1).ToBitVector();
            Claim.eq(value,0b10001000111);

            var x1 = 0b10100111001110001110010110101000;
            var y1 = "0b10100111001110001110010110101000";
            var z1 = gbits.parse<uint>(y1).ToBitVector();
            Claim.eq(x1, z1);
        }

        public void Pack1()
        {
            var xval = 0b10100111001110001110010110101000;
            var x0 = (byte)0b10101000;
            var x1 = (byte)0b11100101;
            var x2 = (byte)0b00111000;
            var x3 = (byte)0b10100111;
            Claim.eq(xval, Bits.pack32(x0, x1, x2,x3));

            var xbsref = "10100111" + "00111000" + "11100101" + "10101000";
            Claim.eq(xbsref, xval.ToBitString());
        }

        public void Pack2()
        {
            Claim.eq((byte)0b01110011, Bits.pack8(1,1,0,0,1,1,1,0));

            Claim.eq((byte)0b00000001, Bits.pack8(1,0,0,0,0,0,0,0));

            Claim.eq((byte)0b00000010, Bits.pack8(0,1,0,0,0,0,0,0));

            Claim.eq((byte)0b11111111, Bits.pack8(1,1,1,1,1,1,1,1));

        }

        public void Pack3()
        {                
            var r1 = Bits.pack(false,true, true, false);
            var e1 = (byte)0b0110;
            Claim.eq(1,r1.Length);
            Claim.eq(e1, r1[0]);

            var r2 = Bits.pack(false, true, true, true);
            var e2 = (byte)0b1110;
            Claim.eq(1,r2.Length);
            Claim.eq(e2, r2[0]);

            var r3 = Bits.pack(false, true, true, true, true, false);
            var e3 = (byte)0b011110;
            Claim.eq(1,r3.Length);
            Claim.eq(e3, r3[0]);
        }

        public void Pack4()
        {
            var bv1 = BitVectorU8.Define(0b10110111);   
            var bs1 = Bits.many(
                    Bit.On, Bit.On,Bit.On, Bit.Off,
                    Bit.On, Bit.On, Bit.Off, Bit.On
                    );
            var bv2 = BitVectorU8.Define(bs1);
            Claim.eq(bv1,bv2);
            
        }

        public void BitConversionTest()
        {
            var x =  0b111010010110011010111001110000100001101ul;
            var xbs = "111010010110011010111001110000100001101";
            var ybs = x.ToBitString(true);
            Claim.eq(xbs, ybs);                

            var y = gbits.parse<ulong>(xbs);
            Claim.eq(x, y);

            var z = gbits.parse<ulong>(ybs);
            Claim.eq(x, z);

            var byx = BitConverter.GetBytes(x).ToSpan();
            Bytes.write(x, out Span<byte> byy);
            Claim.eq(byx,byy);


        }

        public void PopCount1()
        {
            var src = (ushort)3209;
            var bits = src.ToBits();
            var bitsPC = bits.PopCount();
            var bytes = src.ToBytes();
            var bytesPC = bytes.PopCount();
            Claim.eq(bitsPC, bytesPC);

        }

        public void PopCount2()
        {
            var src = 32093283484328432ul;
            var bits = src.ToBits();
            var bitsPC = bits.PopCount();
            var bytes = src.ToBytes();
            var bytesPC = bytes.PopCount();
            Claim.eq(bitsPC, bytesPC);

        }

        public void PopCount3()
        {
            var src = 39238923;
            var bits = src.ToBits();
            var bitsPC = bits.PopCount();
            var bytes = src.ToBytes();
            var bytesPC = bytes.PopCount();
            Claim.eq(bitsPC, bytesPC);

        }

        public void PopCount4()
        {
            var x =  0b111010010110011010111001110000100001101ul;
            var xbs = "111010010110011010111001110000100001101";
            var y = gbits.parse<ulong>(xbs);
            Claim.eq(x, y);

            var pcx = Bits.pop(x);
            Claim.eq(pcx, 20);

            Claim.eq(Bits.pop(x), Bits.pop(y));
        }

        public void PopCount5()
        {
            var xBytes = BitConverter.GetBytes(0b111010010110011010111001110000100001101ul).ToSpan();
            var xBits = xBytes.ToBits();
            var xBitsPC = xBits.PopCount();
            var xBytesPC = xBytes.PopCount();

            Claim.eq(xBitsPC, xBytesPC);

        }

        public void PopCount6()
        {
            var xBytes = Randomizer.Span<byte>(5);
            var x = Bytes.read<ulong>(xBytes);
            var xPC = Bits.pop(x);
            var xBits = xBytes.ToBits();
            var xBitsPC = xBits.PopCount();
            var xBytesPC = xBytes.PopCount();
            var xBitsBS = xBits.ToBitString();
            var xBytesBS = xBytes.ToBitString();

            Claim.eq(xBitsBS, xBytesBS);
            Claim.eq(xPC, xBitsPC);
            Claim.eq(xPC, xBytesPC);
        }

        public void PopCount7()
        {
            var xBytes = Randomizer.Span<byte>(Pow2.T10 - 3);
            var xBytesPC = xBytes.PopCount();
            var xBitsPC = xBytes.ToBits().PopCount();
            Claim.eq(xBitsPC, xBytesPC);

        }

    }
}
