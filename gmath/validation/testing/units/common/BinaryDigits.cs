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
    
    using static BitPatterns;
    
    public class BinaryDigitTest : UnitTest<BinaryDigitTest>
    {
        static void BinaryMatch<T>(string digits, num<T> value)
            where T : struct 
                => Claim.eq(digits, value.ToBinaryDigits().Format());

        static void DecimalMatch<T>(string digits, num<T> value)
            where T : struct 
                => Claim.eq(digits, value.ToDecimalDigits().Format());

        public void ByteToBinaryDigits()
        {
            BinaryMatch<byte>("0b00000100", 0b00000100);
            BinaryMatch<byte>("0b00000101",0b00000101);
            BinaryMatch<byte>("0b01000101",0b01000101);
            BinaryMatch<byte>("0b11010101",0b11010101);
        }

        public void SByteToBinaryDigits()
        {
            BinaryMatch<sbyte>("0b00000100",0b00000100);
            BinaryMatch<sbyte>("0b00000101",0b00000101);
            BinaryMatch<sbyte>("0b01000101",0b01000101);
        }

        public void ByteToDecimalDigits()
        {
            DecimalMatch<byte>("0", 0);
            DecimalMatch<byte>("25", 25);
            DecimalMatch<byte>("101", 101);
            DecimalMatch<byte>("255", 255);
        }

        public void UInt64ToDecimalDigits()
        {
            for(var i = 0UL; i< Pow2.T20; i++)
                DecimalMatch<ulong>(i.ToString(), i);
        }
        
        public void IntToDecimalDigits()
        {
            DecimalMatch<int>("0", 0);
            DecimalMatch<int>("25", -25);
            DecimalMatch<int>("101", 101);
            DecimalMatch<int>("255", -255);
        }

        public void UInt16ToBinaryDigits()
        {
            BinaryMatch<ushort>("0b0000010000000100",0b0000010000000100);
            BinaryMatch<ushort>("0b0000010100000101",0b0000010100000101);
            BinaryMatch<ushort>("0b0100010101000101",0b0100010101000101);
            BinaryMatch<ushort>("0b1101010111010101",0b1101010111010101);
        }
    }
}