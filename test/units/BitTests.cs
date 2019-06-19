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
    using Z0.Diagnostics;
    
    using static zfunc;

    using static Bit;
    using static Constants;
    
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

            Claim.eq(U8Zero, (byte)Off);
            Claim.eq(U8One, (byte)On);

            Claim.eq(U16Zero, (ushort)Off);
            Claim.eq(U16One, (ushort)On);

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
            Claim.yea(gbits.test(0b00000101, 0));
            Claim.nea(gbits.test(0b00000101, 1));
            Claim.yea(gbits.test(0b00000101, 2));
            
            Claim.yea(gbits.test(0b00000111, 0));
            Claim.yea(gbits.test(0b00000111, 1));
            Claim.yea(gbits.test(0b00000111, 2));
        }


        public void BitSize()
        {
            Claim.eq(8, gmath.bitsize<byte>());
            Claim.eq(8, gmath.bitsize<sbyte>());
            Claim.eq(16, gmath.bitsize<short>());
            Claim.eq(16, gmath.bitsize<ushort>());
            Claim.eq(32, gmath.bitsize<int>());
            Claim.eq(32, gmath.bitsize<uint>());
            Claim.eq(64, gmath.bitsize<long>());
            Claim.eq(64, gmath.bitsize<ulong>());
            Claim.eq(32, gmath.bitsize<float>());
            Claim.eq(64, gmath.bitsize<double>());
        }

        public void EnableBits()
        {
            var x1 = (sbyte)0;
            var y1 = Bits.enable(ref x1, 7);
            Claim.eq(SByte.MinValue, y1);
            Claim.eq("10000000", y1.ToBitString());


            var x2 = (byte)0;
            var y2 = Bits.enable(ref x2, 7);
            Claim.eq(SByte.MinValue, (sbyte)y1);
            Claim.eq("10000000", y1.ToBitString());

            var x3 = -1;
            Claim.eq(x3 >> 10, -1);
            
        }

    }
}
