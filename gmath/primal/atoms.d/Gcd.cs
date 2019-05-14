namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Numerics;
    
    using static mfunc;

    partial class math
    {
        [MethodImpl(NotInline)]
        public static sbyte gcd(sbyte lhs, sbyte rhs)
        {
            var x = abs(lhs);
            var y = abs(rhs);
            while (y != 0)
            {
                var rem = (sbyte)(x % y);
                x = y;
                y = rem;
            }
            return x;
        }

        [MethodImpl(NotInline)]
        public static byte gcd(byte lhs, byte rhs)
        {
            while (rhs != 0)
            {
                var rem = mod(lhs,rhs);
                lhs = rhs;
                rhs = rem;
            }
            return lhs;
        }

        [MethodImpl(NotInline)]
        public static short gcd(short lhs, short rhs)
        {
            var x = abs(lhs);
            var y = abs(rhs);
            while (y != 0)
            {
                var rem = (short)(x % y);
                x = y;
                y = rem;
            }
            return x;
        }

        [MethodImpl(NotInline)]
        public static ushort gcd(ushort lhs, ushort rhs)
        {
            while (rhs != 0)
            {
                var rem = mod(lhs,rhs);
                lhs = rhs;
                rhs = rem;
            }
            return lhs;
        }

        [MethodImpl(NotInline)]
        public static int gcd(int lhs, int rhs)
        {
            var x = abs(lhs);
            var y = abs(rhs);
            while (y != 0)
            {
                var rem = (x % y);
                x = y;
                y = rem;
            }

            return x;
        }

        [MethodImpl(NotInline)]
        public static uint gcd(uint lhs, uint rhs)
        {
            while (rhs != 0)
            {
                var rem = mod(lhs,rhs);
                lhs = rhs;
                rhs = rem;
            }

            return lhs;
        }

        [MethodImpl(NotInline)]
        public static long gcd(long lhs, long rhs)
        {
            var x = abs(lhs);
            var y = abs(rhs);
            while (y != 0)
            {
                var rem = (x % y);
                x = y;
                y = rem;
            }

            return x;
        }

        [MethodImpl(NotInline)]
        public static ulong gcd(ulong lhs, ulong rhs)
        {
            while (rhs != 0)
            {
                var rem = mod(lhs,rhs);
                lhs = rhs;
                rhs = rem;
            }

            return lhs;
        }

        [MethodImpl(NotInline)]
        public static double gcd(double lhs, double rhs)
        {
            var x = abs(lhs);
            var y = abs(rhs);
            while (y != 0)
            {
                var rem = x % y;
                x = y;
                y = rem;
            }

            return x;
        }

        [MethodImpl(NotInline)]
        public static float gcd(float lhs, float rhs)
        {
            var x = abs(lhs);
            var y = abs(rhs);
            while (y != 0)
            {
                var rem = (x % y);
                x = y;
                y = rem;
            }

            return x;
        }

        [MethodImpl(NotInline)]
        public static decimal gcd(decimal lhs, decimal rhs)
        {
            var x = abs(lhs);
            var y = abs(rhs);
            while (y != 0)
            {
                var rem = x % y;
                x = y;
                y = rem;
            }
            return x;
        }

        [MethodImpl(NotInline)]
        public static BigInteger gcd(BigInteger lhs, BigInteger rhs)
            => BigInteger.GreatestCommonDivisor(lhs,rhs);
    }
}