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
        
    public class ts_digits : ScalarBitTest<ts_digits>
    {
        public void binary_digits_8u()
        {
            bd_match_check<byte>("0b00000100",0b00000100);
            bd_match_check<byte>("0b00000101",0b00000101);
            bd_match_check<byte>("0b01000101",0b01000101);
            binary_digits_check<byte>();

        }

        public void binary_digits_16u()
        {
            binary_digits_check<ushort>();
        }

        public void binary_digits_32u()
        {
            binary_digits_check<uint>();
        }

        public void binary_digits_64u()
        {
            binary_digits_check<ulong>();
        }

        public void binary_digits_64i()
        {
            binary_digits_check<long>();
        }

        public void decimal_digit_match_8u()
        {
            dd_match_check<byte>("0", 0);
            dd_match_check<byte>("25", 25);
            dd_match_check<byte>("101", 101);
            dd_match_check<byte>("255", 255);
        }

        void binary_digits_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();
                bd_match_check<T>(BitString.FromScalar(x).Format(false,true),x);
            }

        }

        static void bd_match_check<T>(string digits, num<T> value)
            where T : unmanaged
                => Claim.eq(digits, value.ToBinaryDigits().Format(true));

        static void dd_match_check<T>(string digits, num<T> value)
            where T : unmanaged
                => Claim.eq(digits, value.ToDecimalDigits().Format());

    }
}