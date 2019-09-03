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
        
    public class ts_digits : UnitTest<ts_digits>
    {
        public void bindigits8u()
        {
            BinaryMatch<byte>("0b00000100",0b00000100);
            BinaryMatch<byte>("0b00000101",0b00000101);
            BinaryMatch<byte>("0b01000101",0b01000101);

        }

        public void bindigits16u()
        {
            check_bindigits<ushort>();
        }

        public void bindigits32u()
        {
            check_bindigits<uint>();
        }

        public void bindigits64u()
        {
            check_bindigits<ulong>();
        }

        public void bindigits64i()
        {
            check_bindigits<long>();
        }

        void check_bindigits<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Polyrand.Next<T>();
                BinaryMatch<T>(BitString.FromScalar(x).Format(false,true),x);
            }

        }
        public void decimal_digits8u()
        {
            DecimalMatch<byte>("0", 0);
            DecimalMatch<byte>("25", 25);
            DecimalMatch<byte>("101", 101);
            DecimalMatch<byte>("255", 255);
        }

        static void BinaryMatch<T>(string digits, num<T> value)
            where T : unmanaged
                => Claim.eq(digits, value.ToBinaryDigits().Format(true));

        static void DecimalMatch<T>(string digits, num<T> value)
            where T : unmanaged
                => Claim.eq(digits, value.ToDecimalDigits().Format());

    }
}