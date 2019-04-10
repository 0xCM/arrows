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
    public class ByteVector : NumericTest
    {
        public const string Path = P.numeric + P.bits + "byte-vector";
        
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


        public void IntegerConversion()
        {

            
            Claim.eq(8u, BV000.length);                        
            Claim.eq(8u, BV001.length);                        
            Claim.eq(8u, BV002.length);            

            
            print($"B002 = {B002.ToByteVector()}");
            print($"B003 = {B003.ToByteVector()}");
            print($"B004 = {B004.ToByteVector()}");
            
            // Claim.eq(digits(B1,B0).ToByteVector(), B002.ToByteVector());
            // Claim.eq(digits(B1,B1).ToByteVector(), B003.ToByteVector());


            // Claim.eq(8u, BV003.length);            
            // Claim.eq(intg(B003), BV003.ToIntG<byte>());                

            // Claim.eq(8u, BV004.length);            
            // Claim.eq(intg(B004), BV004.ToIntG<byte>());                

            // Claim.eq(8u, BV005.length);            
            // Claim.eq(intg(B005), BV005.ToIntG<byte>());                

            // Claim.eq(8u, BV006.length);            
            // Claim.eq(intg(B006), BV006.ToIntG<byte>());                

            // Claim.eq(8u, BV007.length);            
            // Claim.eq(intg(B007), BV007.ToIntG<byte>());                


        }

    }
}
