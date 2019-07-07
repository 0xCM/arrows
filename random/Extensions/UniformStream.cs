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

    partial class UniformRandom
    {
        /// <summary>
        /// Produces a stream of uniformly random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">If specified, the domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<T> Stream<T>(this IRandomSource random, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.UniformStream(domain,filter);

        /// <summary>
        /// Produces a stream of uniformly random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<T> Stream<T>(this IRandomSource random, Interval<T> domain, Func<T,bool> filter = null)
            where T : struct
                => random.UniformStream(domain,filter);

        /// <summary>
        /// Produces a stream of nonzero uniformly random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">If specified, the domain of the random variable</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<T> NonZeroStream<T>(this IRandomSource random, Interval<T>? domain = null)
                where T : struct
                    => random.UniformStream(domain, gmath.nonzero);

        /// <summary>
        /// Produces a stream of nonzero uniformly random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<T> NonZeroStream<T>(this IRandomSource random, Interval<T> domain)
                where T : struct
                    => random.UniformStream(domain, gmath.nonzero);

        /// <summary>
        /// Fills a client-allocated target with a specified number of uniformly random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="count">The number of values to send to the target</param>
        /// <param name="dst">A reference to the target location</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void StreamTo<T>(this IRandomSource random, Interval<T> domain, int count, ref T dst, Func<T,bool> filter = null)
            where T : struct
        {
            var it = random.Stream<T>(domain,filter).Take(count).GetEnumerator();
            var counter = 0;
            while(it.MoveNext())
                Unsafe.Add(ref dst, counter++) = it.Current;
        }

        static IEnumerable<T> UniformStream<T>(this IRandomSource src, Interval<T> domain, Func<T,bool> filter = null)
            where T : struct
        {

            if(filter != null)
                return src.FilteredStream(domain,filter);
            else
                return src.UnfilteredStream(domain);

        }
        static IEnumerable<T> UniformStream<T>(this IRandomSource src, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var configured = domain.Configure();
            if(filter != null)
                return src.FilteredStream(configured, filter);
            else
                return src.UnfilteredStream(configured);
        }
 
       [MethodImpl(Inline)]
       static Interval<T> Configure<T>(this Interval<T>? domain)        
            where T : struct
                => domain.ValueOrElse(() => TypeBoundDomain<T>());
                
        static IEnumerable<T> FilteredStream<T>(this IRandomSource src, Interval<T> domain, Func<T,bool> filter)
            where T : struct
        {
            var next = default(T);    
            var tries = 0;
            var tryMax = 10;
            while(true)            
            {
                if(typeof(T) == typeof(sbyte))
                    next = generic<T>(src.Next(domain.As<sbyte>()));                    
                else if(typeof(T) == typeof(byte))
                    next = generic<T>(src.Next(domain.As<byte>()));                    
                else if(typeof(T) == typeof(short))
                    next = generic<T>(src.Next(domain.As<short>()));                    
                else if(typeof(T) == typeof(ushort))
                    next = generic<T>(src.Next(domain.As<ushort>()));                    
                else if(typeof(T) == typeof(int))
                    next = generic<T>(src.Next(domain.As<int>()));                    
                else if(typeof(T) == typeof(uint))
                    next = generic<T>(src.Next(domain.As<uint>()));                    
                else if(typeof(T) == typeof(long))
                    next = generic<T>(src.Next(domain.As<long>()));                    
                else if(typeof(T) == typeof(ulong))
                    next = generic<T>(src.Next(domain.As<ulong>()));                    
                else if(typeof(T) == typeof(float))
                    next = generic<T>(src.Next(domain.As<float>()));                    
                else if(typeof(T) == typeof(double))
                    next = generic<T>(src.Next(domain.As<double>()));                    
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

        static IEnumerable<T> UnfilteredStream<T>(this IRandomSource src, Interval<T> domain)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
            {
                var range = domain.As<sbyte>();
                while(true)
                    yield return generic<T>(src.Next(range));                    
            }
            else if(typeof(T) == typeof(byte))
            {
                var range = domain.As<byte>();
                while(true)
                    yield return generic<T>(src.Next(range));                    
            }
            else if(typeof(T) == typeof(short))
            {
                var range = domain.As<short>();
                while(true)
                    yield return generic<T>(src.Next(range));
            }
            else if(typeof(T) == typeof(ushort))
            {
                var range = domain.As<ushort>();
                while(true)
                    yield return generic<T>(src.Next(range));
            }
            else if(typeof(T) == typeof(int))
            {
                var range = domain.As<int>();
                while(true)
                    yield return generic<T>(src.Next(range));
            }
            else if(typeof(T) == typeof(uint))
            {
                var range = domain.As<uint>();
                while(true)
                    yield return generic<T>(src.Next(range));
            }
            else if(typeof(T) == typeof(long))
            {
                var range = domain.As<long>();
                while(true)
                    yield return generic<T>(src.Next(range));
            }
            else if(typeof(T) == typeof(ulong))
            {
                var range = domain.As<ulong>();
                while(true)
                    yield return generic<T>(src.Next(range));
            }
            else if(typeof(T) == typeof(float))
            {
                var range = domain.As<float>();
                while(true)
                    yield return generic<T>(src.Next(range));
            }
            else if(typeof(T) == typeof(double))
            {
                var range = domain.As<double>();
                while(true)
                    yield return generic<T>(src.Next(range));
            }
            else throw unsupported<T>();
        }
 
    }
}