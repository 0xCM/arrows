//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;
        
    public class t_digits : UnitTest<t_digits>
    {
        static void BinaryMatch<T>(string digits, num<T> value)
            where T : struct 
                => Claim.eq(digits, value.ToBinaryDigits().Format(true));

        static void DecimalMatch<T>(string digits, num<T> value)
            where T : struct 
                => Claim.eq(digits, value.ToDecimalDigits().Format());

        public void Test0()
        {
            Claim.eq("100", BitString.FromScalar(0b00000100).Format(true));
            Claim.eq("101", BitString.FromScalar(0b00000101).Format(true));
            Claim.eq("1000101", BitString.FromScalar(0b01000101).Format(true));
            Claim.eq("11010101", BitString.FromScalar(0b11010101).Format(true));
        }

        public void ByteToBinaryDigits()
        {
            BinaryMatch<byte>("0b00000100",0b00000100);
            BinaryMatch<byte>("0b00000101",0b00000101);
            BinaryMatch<byte>("0b01000101",0b01000101);
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