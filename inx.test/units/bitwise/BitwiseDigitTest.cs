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
        
    public class BitwiseDigitTest : UnitTest<BitwiseDigitTest>
    {
        static void BinaryMatch<T>(string digits, num<T> value)
            where T : struct 
                => Claim.eq(digits, value.ToBinaryDigits().Format());

        static void DecimalMatch<T>(string digits, num<T> value)
            where T : struct 
                => Claim.eq(digits, value.ToDecimalDigits().Format());

        public void ByteToBinaryDigits()
        {
            Claim.eq("100", BitString.From(0b00000100).Format2(true));
            Claim.eq("101", BitString.From(0b00000101).Format2(true));
            Claim.eq("1000101", BitString.From(0b01000101).Format2(true));
            Claim.eq("11010101", BitString.From(0b11010101).Format2(true));
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