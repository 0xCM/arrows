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
            Claim.eq("100", BitStringConvert.FromValue(0b00000100, true).ToString());
            Claim.eq("101", BitStringConvert.FromValue(0b00000101,true).ToString());
            Claim.eq("1000101", BitStringConvert.FromValue(0b01000101,true).ToString());
            Claim.eq("11010101", BitStringConvert.FromValue(0b11010101,true).ToString());
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

    }
}