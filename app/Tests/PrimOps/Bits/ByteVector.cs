//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    using static BitVectorPatterns;
    using static BitPattern;
    using static BinaryDigit;

    using P = Paths;    


    [DisplayName(Path)]
    public class ByteVector : UnitTest<ByteVector>
    {
        public const string Path = P.primops + P.bits + "byte-vector/";
        
        static intg<T> toIntG<T>(bit b)
            where T : struct, IEquatable<T>
                => convert<int,T>((int)b); 

        public void Convert()
        {
            ClaimEq(intg<short>(1), toIntG<short>(bit.on())); 
            ClaimEq(intg<short>(0), toIntG<short>(bit.off())); 

            ClaimEq(intg<int>(1), toIntG<int>(bit.on())); 
            ClaimEq(intg<int>(0), toIntG<int>(bit.off())); 

            ClaimEq(intg<uint>(1), toIntG<uint>(bit.on())); 
            ClaimEq(intg<uint>(0), toIntG<uint>(bit.off())); 
        }
        public void Extract1()
        {
            var x0 = (byte)0b10100111;
            var x1 = BitVector.define<N8>(bits(1,1,1,0,0,1,0,1));
            var x2 = BitVector.define<N8>(x0.ToBits());
            ClaimEq(x1,x2);

        }

        public void Extract2()
        {
            var x = (byte)0b00010110;
            var expect = BitVector.define<N8>(x.ToBits());
            var actual= BitVector.define<N8>(bits(0,1,1,0,1,0,0,0));
            ClaimEq(expect,actual);
        }

        public void BitConstruction()
        {
            var xval = 0b10100111001110001110010110101000;
            var x0 = (byte)0b10101000;
            var x1 = (byte)0b11100101;
            var x2 = (byte)0b00111000;
            var x3 = (byte)0b10100111;
            ClaimEq(xval, Bits.pack(x0, x1, x2,x3));

            var xbsref = "10100111" + "00111000" + "11100101" + "10101000";
            ClaimEq(xbsref, xval.ToBitString().format());


            // var y2 = Bits.pack(x3,x2);
            // var y1 = Bits.pack(x1,x0);
            // var y0 = Bits.pack(y2,y1);
            // ClaimEq(xval, y0);

            // var bv1 = BitVector.define<N32>(primops.bits(xval));
            // var bv2 = BitVector.Parse<N32>(xbsref);
            // ClaimEq(bv2, bv1);

            // var bs1 = bv1.bitstring().format();
            // ClaimEq(xbsref,bs1);

            // var bs2 = primops.bitstring(xval).format();
            // ClaimEq(xbsref,bs2);
        }


    }
}
