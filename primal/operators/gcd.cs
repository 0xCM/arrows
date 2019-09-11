//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static zfunc;        

    partial class math
    {

        public static sbyte gcd(sbyte lhs, sbyte rhs)
        {
            var x = math.abs(lhs);
            var y = math.abs(rhs);
            while (y != 0)
            {
                var rem = (sbyte)(x % y);
                x = y;
                y = rem;
            }
            return x;
        }

        public static byte gcd(byte lhs, byte rhs)
        {
            while (rhs != 0)
            {
                var rem = math.mod(lhs,rhs);
                lhs = rhs;
                rhs = rem;
            }
            return lhs;
        }

        public static short gcd(short lhs, short rhs)
        {
            var x = math.abs(lhs);
            var y = math.abs(rhs);
            while (y != 0)
            {
                var rem = (short)(x % y);
                x = y;
                y = rem;
            }
            return x;
        }

        public static ushort gcd(ushort lhs, ushort rhs)
        {
            while (rhs != 0)
            {
                var rem = math.mod(lhs,rhs);
                lhs = rhs;
                rhs = rem;
            }
            return lhs;
        }

        public static int gcd(int lhs, int rhs)
        {
            var x = math.abs(lhs);
            var y = math.abs(rhs);
            while (y != 0)
            {
                var rem = (x % y);
                x = y;
                y = rem;
            }

            return x;
        }

        public static uint gcd(uint lhs, uint rhs)
        {
            while (rhs != 0)
            {
                var rem = lhs % rhs;
                lhs = rhs;
                rhs = rem;
            }

            return lhs;
        }

        public static long gcd(long lhs, long rhs)
        {
            var x = math.abs(lhs);
            var y = math.abs(rhs);
            while (y != 0)
            {
                var rem = (x % y);
                x = y;
                y = rem;
            }

            return x;
        }

        public static ulong gcd(ulong lhs, ulong rhs)
        {
            while (rhs != 0)
            {
                var rem = lhs % rhs;
                lhs = rhs;
                rhs = rem;
            }

            return lhs;
        }
    }

}