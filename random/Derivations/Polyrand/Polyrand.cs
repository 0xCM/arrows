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
        /// Retrieves the next point from the source, bound within a specified interval domain
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The point type</typeparam>
        [MethodImpl(Inline)]
        public static T Next<T>(this IPolyrand src, Interval<T> domain)
            where T : struct
                => src.Next(domain.Left, domain.Right);

        /// <summary>
        /// Retrieves the next point from the source, optionally bound within a specified interval domain
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The point type</typeparam>
        [MethodImpl(Inline)]
        public static T Next<T>(this IPolyrand src, Interval<T>? domain = null)
            where T : struct
                => domain == null ? src.Next<T>() : src.Next<T>(gmath.minval<T>(), gmath.maxval<T>());

        /// <summary>
        /// Produces a random stream of points
        /// </summary>
        /// <param name="random">The point source</param>
        /// <typeparam name="T">The point type</typeparam>
        public static IEnumerable<T> Stream<T>(this IPolyrand random)
            where T : struct
        {
            while(true)
                yield return random.Next<T>();
        }

        /// <summary>
        /// Produces a stream of uniformly random values subject to an optional range and filter
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">If specified, the domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<T> Stream<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.UniformStream(domain,filter);

        /// <summary>
        /// Produces a stream of uniformly random values subject to a specified range and optional filter
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">If specified, the domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<T> Stream<T>(this IPolyrand random, T min, T max, Func<T,bool> filter = null)
            where T : struct
                => random.UniformStream(closed(min,max),filter);

        /// <summary>
        /// Produces a stream of values from the random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="filter">If specified, values that do not satisfy the predicate are excluded from the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<T> Stream<T>(this IPolyrand random, Interval<T> domain, Func<T,bool> filter = null)
            where T : struct
                => random.UniformStream(domain,filter);

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
        public static IEnumerable<T> NonZeroStream<T>(this IPolyrand random, Interval<T>? domain = null)
                where T : struct
                    => random.UniformStream(domain, gmath.nonzero);

        /// <summary>
        /// Produces a stream of nonzero uniformly random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<T> NonZeroStream<T>(this IPolyrand random, Interval<T> domain)
            where T : struct
                => random.UniformStream(domain, gmath.nonzero);

        /// <summary>
        /// Produces a stream of random bytes
        /// </summary>
        /// <param name="random">The random source</param>
        public static IEnumerable<byte> Bytes(this IPolyrand random)
        {
            while(true)
            {
                var bytes = BitConverter.GetBytes(random.Next<ulong>());
                for(var i = 0; i< bytes.Length; i++)
                    if(i == 0)
                        yield return bytes[i];
            }
        }

        /// <summary>
        /// Queries the source for the next value in the range [min,max)
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
         [MethodImpl(Inline)]
         public static float Next(this IPolyrand src, float min, float max, bool truncate = false)
            => truncate ?  MathF.Floor(src.Next(min,max)) :  src.Next(min,max);

        /// <summary>
        /// Queries the source for the next value in the range [min,max)
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
         [MethodImpl(Inline)]
         public static double Next(this IPolyrand src, double min, double max, bool truncate = false)
            => truncate ?  Math.Floor(src.Next(min,max)) :  src.Next(min,max);


        /// <summary>
        /// Samples a memory segment of specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The number of elements in the segment</param>
        /// <param name="domain">The sample domain, if specified</param>
        /// <param name="filter">The filter, if specified</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> Memory<T>(this IPolyrand random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var stream = domain != null ? random.Stream<T>(domain.Value) : random.Stream<T>();
            return stream.TakeMemory(length);
        }

        /// <summary>
        /// Samples a memory segment of specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The number of elements in the segment</param>
        /// <param name="domain">The sample domain</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> Memory<T>(this IPolyrand random, int length, Interval<T> domain)
            where T : struct
            => random.Stream<T>(domain).TakeMemory(length);

        /// <summary>
        /// Samples a memory segment of specified length, exluding 0-values from the sample irrespective of the domain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The number of elements in the segment</param>
        /// <param name="domain">The sample domain, if specified</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> NonZeroMemory<T>(this IPolyrand random, int samples, Interval<T>? domain = null)
                where T : struct
                    => random.Memory<T>(samples, domain, gmath.nonzero);        

        /// <summary>
        /// Takes a specified number of distinct points from a source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to take</param>
        /// <typeparam name="T">The element type</typeparam>
        public static HashSet<T> TakeSet<T>(this IPolyrand random, int count)
            where T : struct
        {
            var stream = random.Stream<T>();
            var set = stream.Take(count).ToHashSet();
            while(set.Count < count)
                set.AddRange(stream.Take(set.Count - count));
            return set;
        }

        [MethodImpl(Inline)]
        public static T[] Array<T>(this IPolyrand random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Stream(domain,filter).TakeArray(length);
         
        [MethodImpl(Inline)]
        public static T[] NonZeroArray<T>(this IPolyrand random, int length, Interval<T>? domain = null)
            where T : struct
                => random.Stream(domain, gmath.nonzero).TakeArray(length);        

        [MethodImpl(Inline)]
        public static Span<T> Span<T>(this IPolyrand random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var stream = domain != null ? random.Stream<T>(domain.Value) : random.Stream<T>();
            return stream.TakeSpan(length);
        }

        [MethodImpl(Inline)]
        public static Span<T> Span<T>(this IPolyrand random, int length, Interval<T> domain)
            where T : struct
            => random.Stream<T>(domain).TakeSpan(length);

        [MethodImpl(Inline)]
        public static Span<N,T> Span<N,T>(this IPolyrand random, N length = default, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct  
            where N : ITypeNat, new()
                => NatSpan.Load<N,T>(random.Span<T>((int)length.value, domain, filter));                                    

        [MethodImpl(Inline)]
        public static Span<M,N,T> Span<M,N,T>(this IPolyrand random, M rows = default, N cols = default)
            where T : struct  
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => NatSpan.Load<M,N,T>(random.Span<T>(nfunc.muli(rows,cols)), rows, cols);

        [MethodImpl(Inline)]
        public static Span<M,N,T> Span<M,N,T>(this IPolyrand random, M rows, N cols, Interval<T> domain)
            where T : struct  
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => NatSpan.Load<M,N,T>(random.Span<T>(nfunc.muli(rows,cols),domain), rows, cols);

        [MethodImpl(Inline)]
        public static Span128<T> Span128<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Stream(domain,filter).TakeSpan(Z0.Span128.BlockLength<T>(blocks)).ToSpan128(); 

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadOnlySpan<T>(this IPolyrand random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Span<T>(length, domain, filter);

        [MethodImpl(Inline)]
        public static Span<T> NonZeroSpan<T>(this IPolyrand random, int samples, Interval<T>? domain = null)
                where T : struct
                    => random.Span<T>(samples, domain, gmath.nonzero);        

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> ReadOnlySpan128<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Span128<T>(blocks, domain, filter);

        [MethodImpl(Inline)]
        public static Span128<T> NonZeroSpan128<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null)        
            where T : struct  
                => random.Span128(blocks, domain, gmath.nonzero);

        [MethodImpl(Inline)]
        public static Span256<T> Span256<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct       
            => random.Stream(domain,filter).TakeSpan(Z0.Span256.BlockLength<T>(blocks)).ToSpan256();       

        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan256<T> ReadOnlySpan256<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Span256<T>(blocks, domain, filter);

        [MethodImpl(Inline)]
        public static Span256<T> NonZeroSpan256<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null)        
            where T : struct  
                => random.Span256(blocks, domain, gmath.nonzero); 


        static IEnumerable<T> UnfilteredStream<T>(this IPolyrand src, Interval<T> domain)
            where T : struct
        {
            while(true)
                yield return src.Next<T>(domain.Left, domain.Right);
        }

        // static IEnumerable<T> FilteredStream<T>(this IPolyrand src, Interval<T> domain, Func<T,bool> filter)
        //     where T : struct
        // {
        //     var next = default(T);    
        //     var tries = 0;
        //     var tryMax = 10;
        //     while(true)
        //     {
        //         yield return src.Next<T>(domain.Left, domain.Right);

        //         if(filter(next))
        //         {
        //             tries = 0;
        //             yield return next;
        //         }
        //         else
        //         {
        //             ++tries;
        //             if(tries > tryMax)
        //                 throw new Exception($"Filter too rigid over {domain}; last failed value: {next}");
        //         }
        //     }
        // }

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