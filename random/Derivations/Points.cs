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

    using static zfunc;
    using static As;

    partial class RngX
    {
        /// <summary>
        /// Retrieves the next point from a random source over a range
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The range of potential values</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static T Next<T>(this IRandomSource src, Interval<T> domain)
            where T : struct
                => src.NextPoint(domain);

        /// <summary>
        /// Retrieves the next point from a random source over an optionally-specified domain
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The range of potential values</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static T Next<T>(this IRandomSource src, Interval<T>? domain)
            where T : struct
                => domain.HasValue ? Next(src, domain.Value) : src.Next<T>();

        /// <summary>
        /// Retrieves the next point from a random source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The range of potential values</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static T Next<T>(this IRandomSource src)
            where T : struct
                => src.NextPoint<T>(); 

        /// <summary>
        /// Queries the source for the next value in the range [min,max)
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
         [MethodImpl(Inline)]
         public static byte Next(this IRandomSource src, byte min, byte max)
            => src.Next(closed(min,max));

        /// <summary>
        /// Queries the source for the next value in the range [min,max)
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
         [MethodImpl(Inline)]
         public static sbyte Next(this IRandomSource src, sbyte min, sbyte max)
            => src.Next(closed(min,max));

        /// <summary>
        /// Queries the source for the next value in the range [min,max)
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
         [MethodImpl(Inline)]
         public static short Next(this IRandomSource src, short min, short max)
            => src.Next(closed(min,max));

        /// <summary>
        /// Queries the source for the next value in the range [min,max)
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
         [MethodImpl(Inline)]
         public static ushort Next(this IRandomSource src, ushort min, ushort max)
            => src.Next(closed(min,max));

        /// <summary>
        /// Queries the source for the next value in the range [min,max)
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
         [MethodImpl(Inline)]
         public static uint Next(this IRandomSource src, uint min, uint max)
            => src.Next(closed(min,max));
         
        /// <summary>
        /// Queries the source for the next value in the range [min,max)
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
         [MethodImpl(Inline)]
         public static int Next(this IRandomSource src, int min, int max)
            => src.Next(closed(min,max));

        /// <summary>
        /// Queries the source for the next value in the range [min,max)
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
         [MethodImpl(Inline)]
         public static long Next(this IRandomSource src, long min, long max)
            => src.Next(closed(min,max));

        /// <summary>
        /// Queries the source for the next value in the range [min,max)
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
         [MethodImpl(Inline)]
         public static ulong Next(this IRandomSource src, ulong min, ulong max)
            => src.Next(closed(min,max));

        /// <summary>
        /// Queries the source for the next value in the range [min,max)
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
         [MethodImpl(Inline)]
         public static float Next(this IRandomSource src, float min, float max, bool truncate = false)
            => truncate ?  MathF.Floor(src.Next(closed(min,max))) :  src.Next(closed(min,max));

        /// <summary>
        /// Queries the source for the next value in the range [min,max)
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
         [MethodImpl(Inline)]
         public static double Next(this IRandomSource src, double min, double max, bool truncate = false)
            => truncate ?  Math.Floor(src.Next(closed(min,max))) :  src.Next(closed(min,max));

        /// <summary>
        /// Yields the next random value from the source that conforms to a specified upper bound
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="max">The exclusive upper bound</param>
        [MethodImpl(Inline)]
        public static byte Next(this IRandomSource<byte> src, byte max)
            => src.Next().Contract(max);

        /// <summary>
        /// Yields the next random value from the source that conforms to a specified upper bound
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="max">The exclusive upper bound</param>
        [MethodImpl(Inline)]
        public static ushort Next(this IRandomSource<ushort> src, ushort max)
            => src.Next().Contract(max);

        /// <summary>
        /// Yields the next random value from the source that conforms to a specified upper bound
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="max">The exclusive upper bound</param>
        [MethodImpl(Inline)]
        public static uint Next(this IRandomSource<uint> src, uint max)
            => src.Next().Contract(max);

        /// <summary>
        /// Yields the next random value from the source that conforms to a specified upper bound
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="max">The exclusive upper bound</param>
        [MethodImpl(Inline)]
        public static ushort Next(this IRandomSource<ulong> src, ushort max) 
            => (ushort)src.Next().Contract(max);

        /// <summary>
        /// Yields the next random value from the source that conforms to a specified upper bound
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="max">The exclusive upper bound</param>
        [MethodImpl(Inline)]
        public static ulong Next(this IRandomSource<ulong> src, ulong max) 
            => src.Next().Contract(max);

        /// <summary>
        /// Queries the source for the next value in the interval [0, max) if max >= 0
        /// </summary>
        /// <param name="random">The stateful source on which the generation is predicated</param>
        /// <param name="max">The exclusive maximum</param>
        [MethodImpl(Inline)]
        internal static int Next(this IRandomSource<ulong> random, int max)
            => max >= 0 ? (int)random.Next((ulong)max) 
                : - (int)random.Next((ulong) (Int32.MaxValue + max));        

        [MethodImpl(Inline)]
        public static ulong Next(this IPointSource<ulong> src, ulong max)
            => src.Next().Contract(max);

        /// <summary>
        /// Retrieves the next unsigned 4-bit value from the source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The selection domain</param>
        [MethodImpl(Inline)]
        public static UInt4 NextUInt4(this IRandomSource src, Interval<byte>? domain = null)
            => (UInt4)src.Next(domain);

        /// <summary>
        /// Retrieves the next signed 8-bit value from the source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The selection domain</param>
        [MethodImpl(Inline)]
        public static sbyte NextInt8(this IRandomSource src, Interval<sbyte>? domain = null)
            => src.Next(domain);
 
        /// <summary>
        /// Retrieves the next usigned 8-bit value from the source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The selection domain</param>
         [MethodImpl(Inline)]
         public static byte NextUInt8(this IRandomSource src, Interval<byte>? domain = null)
            => src.Next(domain);
 
        /// <summary>
        /// Retrieves the next unsigned 16-bit value from the source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The selection domain</param>
         [MethodImpl(Inline)]
         public static ushort NextUInt16(this IRandomSource src, Interval<ushort>? domain = null)
            => src.Next(domain);
 
        /// <summary>
        /// Retrieves the next signed 16-bit value from the source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The selection domain</param>
         [MethodImpl(Inline)]
         public static short NextInt16(this IRandomSource src, Interval<short>? domain = null)
            => src.Next(domain);

         [MethodImpl(Inline)]
         public static uint NextUInt32(this IRandomSource src, Interval<uint>? domain = null)
            => src.Next(domain);

         [MethodImpl(Inline)]
         public static long NextInt32(this IRandomSource src, Interval<int>? domain = null)
            => src.Next(domain);

         [MethodImpl(Inline)]
         public static long NextInt64(this IRandomSource src, Interval<long>? domain = null)
            => src.Next(domain);

         [MethodImpl(Inline)]
         static ulong Next(this IRandomSource src, ulong max)
             => src.NextUInt64(max);

         [MethodImpl(Inline)]
         static ulong Next(this IPointSource<ulong> src)
            => src.Next();


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
        static byte Next(this IRandomSource src, Interval<byte> domain)
            => math.add(domain.Left, (byte)src.Next((ulong)domain.Width()));

        [MethodImpl(Inline)]
        static ushort Next(this IRandomSource src, Interval<ushort> domain)
            => math.add(domain.Left, (ushort)src.Next((ulong)domain.Width()));

        [MethodImpl(Inline)]
        static uint Next(this IRandomSource src, Interval<uint> domain)
            => math.add(domain.Left, (uint)src.Next((ulong)domain.Width()));

        [MethodImpl(Inline)]
        static ulong Next(this IRandomSource src, Interval<ulong> domain)
            => domain.Left + src.Next(domain.Width());

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
        static int Next(this IRandomSource src, Interval<int> domain)
        {
            var delta = math.sub(domain.Right, domain.Left);
            return delta > 0 
                ? domain.Left + (int)src.Next((ulong)delta) 
                : domain.Left + (int)src.Next((ulong)delta.Negate());
        }

        [MethodImpl(Inline)]
        static long Next(this IRandomSource src, Interval<long> domain)            
        {
            var delta = math.sub(domain.Right, domain.Left);
            return delta >= 0 
                ? domain.Left + (long)src.Next((ulong)delta) 
                : domain.Left + (long)src.Next((ulong)delta.Negate());
        }

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