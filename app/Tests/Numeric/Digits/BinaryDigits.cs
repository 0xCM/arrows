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
    using static zfunc;
    
    using static BitPatterns;
    
    using P = Paths;


    [DisplayName(Path)]
    public class BinaryDigits : UnitTest<BinaryDigits>
    {
        public const string Path = P.digits + P.binary;
        static IEnumerable<Digit<N2,BinaryDigit>> bindigits<T>(intg<T> src)
            where T : struct, IEquatable<T> 
                => src.ToBinaryDigitsG();

        static IEnumerable<Digit<N10,DecimalDigit>> decidigits<T>(intg<T> src)
            where T : struct, IEquatable<T> 
                => src.ToDecimalDigitsG();

        static void samebin<T>(string digits, intg<T> value)
            where T : struct, IEquatable<T> 
                => Claim.eq(digits, append(bindigits(value)));

        static void samedec<T>(string digits, intg<T> value)
            where T : struct, IEquatable<T> 
                => Claim.eq(digits, append(decidigits(value)));

        public void ByteToBinaryDigits()
        {
            samebin<byte>("00000100",0b00000100);
            samebin<byte>("00000101",0b00000101);
            samebin<byte>("01000101",0b01000101);
            samebin<byte>("11010101",0b11010101);

        }

        public void SByteToBinaryDigits()
        {
            samebin<sbyte>("00000100",0b00000100);
            samebin<sbyte>("00000101",0b00000101);
            samebin<sbyte>("01000101",0b01000101);
        }

        public void ByteToDecimalDigits()
        {
            samedec<byte>("0", 0);
            samedec<byte>("25", 25);
            samedec<byte>("101", 101);
            samedec<byte>("255", 255);
        }

        public void UInt64ToDecimalDigits()
        {
            for(var i = 0UL; i< Pow2.T20; i++)
                samedec<ulong>(i.ToString(), i);
        }
        

        public void IntToDecimalDigits()
        {
            samedec<int>("0", 0);
            samedec<int>("25", -25);
            samedec<int>("101", 101);
            samedec<int>("255", -255);
        }

        public void UInt16ToBinaryDigits()
        {
            samebin<ushort>("0000010000000100",0b0000010000000100);
            samebin<ushort>("0000010100000101",0b0000010100000101);
            samebin<ushort>("0100010101000101",0b0100010101000101);
            samebin<ushort>("1101010111010101",0b1101010111010101);

        }

    }

}