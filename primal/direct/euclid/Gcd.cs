namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Numerics;
    
    using static zfunc;    
    using static As;
    
    public static partial class euclid
    {
        [MethodImpl(Inline)]
        public static T gcd<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((gcd(int8(lhs), int8(rhs))));
            else if(typeof(T) == typeof(byte))
                return generic<T>((gcd(uint8(lhs), uint8(rhs))));
            else if(typeof(T) == typeof(short))
                return generic<T>((gcd(int16(lhs), int16(rhs))));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((gcd(uint16(lhs), uint16(rhs))));
            else if(typeof(T) == typeof(int))
                return generic<T>((gcd(int32(lhs), int32(rhs))));
            else if(typeof(T) == typeof(uint))
                return generic<T>((gcd(uint32(lhs), uint32(rhs))));
            else if(typeof(T) == typeof(long))
                return generic<T>((gcd(int64(lhs), int64(rhs))));
            else if(typeof(T) == typeof(ulong))
                return generic<T>((gcd(uint64(lhs), uint64(rhs))));
            else if(typeof(T) == typeof(float))
                return generic<T>((gcd(float32(lhs), float32(rhs))));
            else if(typeof(T) == typeof(double))
                return generic<T>((gcd(float64(lhs), float64(rhs))));
            else            
                throw unsupported<T>();
        }           

        static sbyte gcd(sbyte lhs, sbyte rhs)
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

        static byte gcd(byte lhs, byte rhs)
        {
            while (rhs != 0)
            {
                var rem = math.mod(lhs,rhs);
                lhs = rhs;
                rhs = rem;
            }
            return lhs;
        }

        static short gcd(short lhs, short rhs)
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

        static ushort gcd(ushort lhs, ushort rhs)
        {
            while (rhs != 0)
            {
                var rem = math.mod(lhs,rhs);
                lhs = rhs;
                rhs = rem;
            }
            return lhs;
        }

        static int gcd(int lhs, int rhs)
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

        static uint gcd(uint lhs, uint rhs)
        {
            while (rhs != 0)
            {
                var rem = math.mod(lhs,rhs);
                lhs = rhs;
                rhs = rem;
            }

            return lhs;
        }

        static long gcd(long lhs, long rhs)
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

        static ulong gcd(ulong lhs, ulong rhs)
        {
            while (rhs != 0)
            {
                var rem = math.mod(lhs,rhs);
                lhs = rhs;
                rhs = rem;
            }

            return lhs;
        }

        static float gcd(float lhs, float rhs)
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

        static double gcd(double lhs, double rhs)
        {
            var x = math.abs(lhs);
            var y = math.abs(rhs);
            while (y != 0)
            {
                var rem = x % y;
                x = y;
                y = rem;
            }

            return x;
        } 
    }

}