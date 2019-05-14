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

    using static BitPatterns;
    using static BitPattern;
    using static BinaryDigit;
    using static Bit;
    public class BitTests : UnitTest<BitTests>
    {
        
        public void COnvert()
        {
            static T toInt<T>(Bit b)
                where T : struct, IEquatable<T>
                    => convert<int,T>((int)b); 

            Claim.eq(1, toInt<int>(Bit.On)); 
            Claim.eq(0, toInt<int>(Bit.Off)); 
            Claim.eq(1u, toInt<uint>(Bit.On)); 
            Claim.eq(0u, toInt<uint>(Bit.Off)); 
        }

        public void BitCOnvert()
        {
            Claim.eq<bool>(false, Off);
            Claim.eq<bool>(true, On);

            Claim.eq<byte>(0, (byte)Off);
            Claim.eq<byte>(1, (byte)On);

            Claim.eq<ushort>(0, (ushort)Off);
            Claim.eq<ushort>(1, (ushort)On);

            Claim.eq<uint>(0, (uint)Off);
            Claim.eq<uint>(1, (uint)On);

            Claim.eq<ulong>(0, (ulong)Off);
            Claim.eq<ulong>(1, (ulong)On);

            Claim.enumeq<BinaryDigit>(BinaryDigit.Zed, Off);
            Claim.enumeq<BinaryDigit>(BinaryDigit.One, On);

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


        public void Pack1()
        {
            var xval = 0b10100111001110001110010110101000;
            var x0 = (byte)0b10101000;
            var x1 = (byte)0b11100101;
            var x2 = (byte)0b00111000;
            var x3 = (byte)0b10100111;
            Claim.eq(xval, Z0.Bits.pack(x0, x1, x2,x3));

            var xbsref = "10100111" + "00111000" + "11100101" + "10101000";
            Claim.eq(xbsref, xval.ToBitString());
        }

        public void Pack2()
        {
            Claim.eq((byte)0b01110011, Bits.bitpack(1,1,0,0,1,1,1,0));

            Claim.eq((byte)0b00000001, Bits.bitpack(1,0,0,0,0,0,0,0));

            Claim.eq((byte)0b00000010, Bits.bitpack(0,1,0,0,0,0,0,0));

            Claim.eq((byte)0b11111111, Bits.bitpack(1,1,1,1,1,1,1,1));

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

    }
}
