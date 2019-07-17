//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Text;

    using static zfunc;
    using static As;

    partial class RngX
    {
        /// <summary>
        /// Retrieves the next value from a random source over an optionally-specified domain
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The range of potential values</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static T Next<T>(this IRandomSource src, Interval<T>? domain = null)
            where T : struct
                => domain.MapValueOrElse(d => src.NextPoint<T>(d), () => src.NextPoint<T>());

        [MethodImpl(Inline)]
        static T NextPoint<T>(this IRandomSource src, Interval<T> domain)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(src.Next(domain.As<sbyte>()));
            else if(typeof(T) == typeof(byte))
                return generic<T>(src.Next(domain.As<byte>()));                    
            else if(typeof(T) == typeof(short))
                return generic<T>(src.Next(domain.As<short>()));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(src.Next(domain.As<ushort>()));
            else if(typeof(T) == typeof(int))
                return generic<T>(src.Next(domain.As<int>()));
            else if(typeof(T) == typeof(uint))
                return generic<T>(src.Next(domain.As<uint>()));
            else if(typeof(T) == typeof(long))
                return generic<T>(src.Next(domain.As<long>()));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(src.Next(domain.As<ulong>()));
            else if(typeof(T) == typeof(float))
                return generic<T>(src.Next(domain.As<float>()));
            else if(typeof(T) == typeof(double))
                return generic<T>(src.Next(domain.As<double>()));
            else throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static T NextPoint<T>(this IRandomSource src)
            where T : struct
        {
            var domain = RNG.TypeDomain<T>();
            if(typeof(T) == typeof(sbyte))
                return generic<T>(src.Next(domain.As<sbyte>()));
            else if(typeof(T) == typeof(byte))
                return generic<T>(src.Next(domain.As<byte>()));                    
            else if(typeof(T) == typeof(short))
                return generic<T>(src.Next(domain.As<short>()));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(src.Next(domain.As<ushort>()));
            else if(typeof(T) == typeof(int))
                return generic<T>(src.Next(domain.As<int>()));
            else if(typeof(T) == typeof(uint))
                return generic<T>(src.Next(domain.As<uint>()));
            else if(typeof(T) == typeof(long))
                return generic<T>(src.Next(domain.As<long>()));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(src.Next(domain.As<ulong>()));
            else if(typeof(T) == typeof(float))
                return generic<T>(src.Next(domain.As<float>()));
            else if(typeof(T) == typeof(double))
                return generic<T>(src.Next(domain.As<double>()));
            else throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static ulong Next(this IRandomSource src, ulong max)
            => src.NextUInt64(max);

                
        [MethodImpl(Inline)]
        static sbyte Next(this IRandomSource src, Interval<sbyte> domain)
        {
            var delta = math.sub(domain.Right,domain.Left);
            var next = 
                delta > 0 
                ? math.add(domain.Left, (sbyte)src.Next((ulong)delta)) 
                : math.add(domain.Left, (sbyte)src.Next((ulong)delta.Negate()));
            return next;
        }

        [MethodImpl(Inline)]
        static byte Next(this IRandomSource src, Interval<byte> domain)
            => math.add(domain.Left, (byte)src.Next((ulong)domain.Width()));

        [MethodImpl(Inline)]
        static short Next(this IRandomSource src, Interval<short> domain)
        {
            var delta = math.sub(domain.Right,domain.Left);
            var next = 
                delta > 0 
                ? math.add(domain.Left, (short)src.Next((ulong)delta)) 
                : math.add(domain.Left, (short)src.Next((ulong)delta.Negate()));
            return next;
        }

        [MethodImpl(Inline)]
        static ushort Next(this IRandomSource src, Interval<ushort> domain)
            => math.add(domain.Left, (ushort)src.Next((ulong)domain.Width()));

        [MethodImpl(Inline)]
        static int Next(this IRandomSource src, Interval<int> domain)
        {
            var delta = math.sub(domain.Right, domain.Left);
            return delta > 0 
                ? domain.Left + (int)src.Next((ulong)delta) 
                : domain.Left + (int)src.Next((ulong)delta.Negate());
        }


        [MethodImpl(Inline)]
        static uint Next(this IRandomSource src, Interval<uint> domain)
            => math.add(domain.Left, (uint)src.Next((ulong)domain.Width()));

        [MethodImpl(Inline)]
        static long Next(this IRandomSource src, Interval<long> domain)
        {
            var delta = math.sub(domain.Right,domain.Left);
            var next = delta > 0 
                ? domain.Left + (long)src.Next((ulong)delta) 
                : domain.Left + (long)src.Next((ulong)delta.Negate());
            return next;
        }

        [MethodImpl(Inline)]
        static ulong Next(this IRandomSource src, Interval<ulong> domain)
            => domain.Left + src.Next(domain.Width());

        [MethodImpl(Inline)]
        static float Next(this IRandomSource src, Interval<float> domain)
        {
            var whole = (float)src.Next(domain.Convert<int>());
            return whole + (float)src.NextDouble();
        }

        [MethodImpl(Inline)]
        static double Next(this IRandomSource src, Interval<double> domain)
        {
            var whole = (double)src.Next(domain.Convert<long>());
            return whole + src.NextDouble();            
        }
    }
}