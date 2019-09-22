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

        /// <summary>
        /// Binary gcd, Wikipedia version
        /// </summary>
        /// <param name="u"></param>
        /// <param name="v"></param>
        /// <remarks>See https://en.wikipedia.org/wiki/Binary_GCD_algorithm</remarks>
        public static uint gcdbin(uint u, uint v)
        {
            // simple cases (termination)
            if (u == v)
                return u;

            if (u == 0)
                return v;

            if (v == 0)
                return u;

            // look for factors of 2
            if ( (~u & 1) != 0) // u is even
            {
                if ( (v & 1) != 0) // v is odd
                    return gcdbin(u >> 1, v);
                else // both u and v are even
                    return gcdbin(u >> 1, v >> 1) << 1;
            }

            if ( (~v & 1) != 0) // u is odd, v is even
                return gcdbin(u, v >> 1);

            // reduce larger argument
            if (u > v)
                return gcdbin((u - v) >> 1, v);

            return gcdbin((v - u) >> 1, u);
        }


        /// <summary>
        /// Binary gcd, Wikipedia version
        /// </summary>
        /// <param name="u"></param>
        /// <param name="v"></param>
        /// <remarks>See https://en.wikipedia.org/wiki/Binary_GCD_algorithm</remarks>
        public static ulong gcdbin(ulong u, ulong v)
        {
            // simple cases (termination)
            if (u == v)
                return u;

            if (u == 0)
                return v;

            if (v == 0)
                return u;

            // look for factors of 2
            if ( (~u & 1) != 0) // u is even
            {
                if ( (v & 1) != 0) // v is odd
                    return gcdbin(u >> 1, v);
                else // both u and v are even
                    return gcdbin(u >> 1, v >> 1) << 1;
            }

            if ( (~v & 1) != 0) // u is odd, v is even
                return gcdbin(u, v >> 1);

            // reduce larger argument
            if (u > v)
                return gcdbin((u - v) >> 1, v);

            return gcdbin((v - u) >> 1, u);
        }

        [MethodImpl(Inline)]
        public static byte gcdbin(byte u, byte v)            
            => (byte)gcdbin((uint)u, (uint)v);

        [MethodImpl(Inline)]
        public static ushort gcdbin(ushort u, ushort v)            
            => (ushort)gcdbin((uint)u, (uint)v);

    }

}