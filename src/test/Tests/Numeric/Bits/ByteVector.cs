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
        public const string Path = P.numeric + P.bits + "byte-vector/";
        
        static intg<T> toIntG<T>(bit b)
            where T : struct, IEquatable<T>
                => convert<int,T>((int)b); 

        public void BitConversion()
        {
            Claim.eq(intg<short>(1), toIntG<short>(bit.on())); 
            Claim.eq(intg<short>(0), toIntG<short>(bit.off())); 

            Claim.eq(intg<int>(1), toIntG<int>(bit.on())); 
            Claim.eq(intg<int>(0), toIntG<int>(bit.off())); 

            Claim.eq(intg<uint>(1), toIntG<uint>(bit.on())); 
            Claim.eq(intg<uint>(0), toIntG<uint>(bit.off())); 
        }
        public void BitExtraction1()
        {
            var x0 = (byte)0b10100111;
            var x1 = BitVector.define<N8>(bits(1,0,1,0,0,1,1,1));
            var x2 = BitVector.define<N8>(x0.ToBits());
            Claim.equals(x1,x2);

        }

        public void BitExtraction2()
        {
            var x = (byte)0b00010110;
            var expect = BitVector.define<N8>(x.ToBits());
            var actual= BitVector.define<N8>(bits(0,0,0,1,0,1,1,0));
            Claim.equals(expect,actual);
        }

        public void BitConstruction()
        {
            var bsref = "10100111001110001110010110101000";
            var hihi = (byte)0b10100111;
            var hilo = (byte)0b00111000;
            var lohi = (byte)0b11100101;
            var lolo = (byte)0b10101000;
            var intval = Bits.concat(hihi,hilo,lohi,lolo);

            var y2 = Bits.concat(hihi,hilo);
            var y1 = Bits.concat(lohi,lolo);
            var y0 = Bits.concat(y2,y1);
            Claim.equals(intval, y0);

            var bv1 = BitVector.define<N32>(intval.ToBits());
            var bv2 = BitVector.Parse<N32>(bsref);
            Claim.eq(bv2, bv1);

            var bs1 = bv1.bitstring().format();
            Claim.equals(bsref,bs1);

            var bs2 = intval.ToBitString().format();
            Claim.equals(bsref,bs2);
        }


    }
}
