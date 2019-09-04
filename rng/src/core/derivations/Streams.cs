//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;
    
    partial class RngX
    {
        [MethodImpl(Inline)]
        static IRandomStream<T> stream<T>(IEnumerable<T> src)
            where T : struct
                => RngStream.Define(src);

        /// <summary>
        /// Produces a stream of random bytes
        /// </summary>
        /// <param name="random">The random source</param>
        public static IRandomStream<byte> Bytes(this IPolyrand random)
        {
            IEnumerable<byte> produce()
            {
                while(true)
                {
                    var bytes = BitConverter.GetBytes(random.Next<ulong>());
                    for(var i = 0; i< bytes.Length; i++)
                        if(i == 0)
                            yield return bytes[i];
                }
            }
            return stream(produce());
        }

        /// <summary>
        /// Produces a random stream of points
        /// </summary>
        /// <param name="random">The point source</param>
        /// <typeparam name="T">The point type</typeparam>
        public static IRandomStream<T> Stream<T>(this IPolyrand random)
            where T : struct
        {
            IEnumerable<T> produce()
            {
                while(true)
                    yield return random.Next<T>();
            }
            return stream(produce());
        }

        /// <summary>
        /// Produces a stream of uniformly random values subject to an optional range and filter
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">If specified, the domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IRandomStream<T> Stream<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => stream(random.UniformStream(domain,filter));

        /// <summary>
        /// Produces a stream values from the source subject to a specified maximum value and optional filter
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="max">The random variable's upper bound</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IRandomStream<T> Stream<T>(this IPolyrand random, T max, Func<T,bool> filter = null)
            where T : struct
                => stream(random.UniformStream(closed(gmath.minval<T>(), max),filter));

        /// <summary>
        /// Produces a stream values from the source subject to a specified range and optional filter
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">If specified, the domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IRandomStream<T> Stream<T>(this IPolyrand random, T min, T max, Func<T,bool> filter = null)
            where T : struct
                => stream(random.UniformStream(closed(min,max),filter));

        /// <summary>
        /// Produces a stream of values from the random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IRandomStream<T> Stream<T>(this IPolyrand random, Interval<T> domain, Func<T,bool> filter = null)
            where T : struct
                => stream(random.UniformStream(domain,filter));

        /// <summary>
        /// Fills a caller-allocated target with a specified number of values from the source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="count">The number of values to send to the target</param>
        /// <param name="dst">A reference to the target location</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void StreamTo<T>(this IPolyrand random, Interval<T> domain, int count, ref T dst, Func<T,bool> filter = null)
            where T : struct
        {
            var it = random.Stream<T>(domain,filter).Take(count).GetEnumerator();
            var counter = 0;
            while(it.MoveNext())
                Unsafe.Add(ref dst, counter++) = it.Current;
        }

        /// <summary>
        /// Fills a caller-allocated target with a specified number of values from the source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of values to send to the target</param>
        /// <param name="dst">A reference to the target location</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void StreamTo<T>(this IPolyrand random, int count, ref T dst)
            where T : struct
        {
            var it = random.Stream<T>().Take(count).GetEnumerator();
            var counter = 0;
            while(it.MoveNext())
                Unsafe.Add(ref dst, counter++) = it.Current;
        }
        
        /// <summary>
        /// Produces a stream of nonzero uniformly random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">If specified, the domain of the random variable</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IRandomStream<T> NonZeroStream<T>(this IPolyrand random, Interval<T>? domain = null)
                where T : struct
                    => stream(random.UniformStream(domain, gmath.nonzero));

        /// <summary>
        /// Produces a stream of nonzero uniformly random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IRandomStream<T> NonZeroStream<T>(this IPolyrand random, Interval<T> domain)
            where T : struct
                => stream(random.UniformStream(domain, gmath.nonzero));

        static IEnumerable<T> UnfilteredStream<T>(this IPolyrand src, Interval<T> domain)
            where T : struct
        {
            while(true)
                yield return src.Next<T>(domain.Left, domain.Right);
        }

        static IEnumerable<T> FilteredStream<T>(this IPolyrand src, Interval<T> domain, Func<T,bool> filter)
            where T : struct
        {
            var next = default(T);    
            var tries = 0;
            var tryMax = 10;
            while(true)            
            {
                if(typeof(T) == typeof(sbyte))
                    next = generic<T>(src.Next<sbyte>(domain.As<sbyte>()));                    
                else if(typeof(T) == typeof(byte))
                    next = generic<T>(src.Next<byte>(domain.As<byte>()));                    
                else if(typeof(T) == typeof(short))
                    next = generic<T>(src.Next<short>(domain.As<short>()));                    
                else if(typeof(T) == typeof(ushort))
                    next = generic<T>(src.Next<ushort>(domain.As<ushort>()));                    
                else if(typeof(T) == typeof(int))
                    next = generic<T>(src.Next<int>(domain.As<int>()));                    
                else if(typeof(T) == typeof(uint))
                    next = generic<T>(src.Next<uint>(domain.As<uint>()));                    
                else if(typeof(T) == typeof(long))
                    next = generic<T>(src.Next<long>(domain.As<long>()));                    
                else if(typeof(T) == typeof(ulong))
                    next = generic<T>(src.Next<ulong>(domain.As<ulong>()));                    
                else if(typeof(T) == typeof(float))
                    next = generic<T>(src.Next<float>(domain.As<float>()));                    
                else if(typeof(T) == typeof(double))
                    next = generic<T>(src.Next<double>(domain.As<double>()));                    
                else 
                    throw unsupported<T>();

                if(filter(next))
                {
                    tries = 0;
                    yield return next;
                }
                else
                {
                    ++tries;
                    if(tries > tryMax)
                        throw new Exception($"Filter too rigid over {domain}; last failed value: {next}");
                }
            }
        }

        static IEnumerable<T> UniformStream<T>(this IPolyrand src, Interval<T> domain, Func<T,bool> filter = null)
            where T : struct
        {

            if(filter != null)
                return src.FilteredStream(domain,filter);
            else
                return src.UnfilteredStream(domain);
        }

        static IEnumerable<T> UniformStream<T>(this IPolyrand src, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var configured = domain.Configure();
            if(filter != null)
                return src.FilteredStream(configured, filter);
            else
                return src.UnfilteredStream(configured);
        }


    }

}