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

    public class BitTests : UnitTest<BitTests>
    {
        
        public void Convert()
        {
            static T toInt<T>(Bit b)
                where T : struct, IEquatable<T>
                    => convert<int,T>((int)b); 

            Claim.eq(1, toInt<int>(Bit.On)); 
            Claim.eq(0, toInt<int>(Bit.Off)); 
            Claim.eq(1u, toInt<uint>(Bit.On)); 
            Claim.eq(0u, toInt<uint>(Bit.Off)); 
        }
        // public void Extract1()
        // {
        //     var x0 = (byte)0b10100111;
        //     var x1 = BitVector.define<N8>(Bits.pack(1,1,1,0,0,1,0,1));
        //     var x2 = BitVector.define<N8>(x0.ToBits());
        //     Claim.eq(x1,x2);
        // }

        // public void Extract2()
        // {
        //     var x = (byte)0b00010110;
        //     var expect = BitVector.define<N8>(x.ToBits());
        //     var actual= BitVector.define<N8>(Z0.Bits.pack(0,1,1,0,1,0,0,0));
        //     Claim.eq(expect,actual);
        // }

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
            var r1 = pack(false,true, true, false);
            var e1 = (byte)0b0110;
            Claim.eq(1,r1.Length);
            Claim.eq(e1, r1[0]);

            var r2 = pack(false, true, true, true);
            var e2 = (byte)0b1110;
            Claim.eq(1,r2.Length);
            Claim.eq(e2, r2[0]);

            var r3 = pack(false, true, true, true, true, false);
            var e3 = (byte)0b011110;
            Claim.eq(1,r3.Length);
            Claim.eq(e3, r3[0]);
        }

    }
}
