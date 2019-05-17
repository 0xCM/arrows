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

    using static As;

    
    using static zfunc;

    
    public static class RandomX
    {
        static Interval<T> domain<T>()
            where T : struct
                => SampleDefaults.get<T>().SampleDomain;

        static Interval<T> Domain<T>(Interval<T>? domain)
            where T : struct
                => domain ?? SampleDefaults.get<T>().SampleDomain;

        public static IRandomizer<T> Random<T>(this IRandomizer random)
            where T : struct
                => (IRandomizer<T>)(random);

        public static IEnumerable<T> Stream<T>(this IRandomizer random, 
            Interval<T>? domain = null, Func<T,bool> filter = null)
                where T : struct
                     => filter != null 
                        ? random.Random<T>().stream(Domain(domain)).Where(filter) 
                        : random.Random<T>().stream(Domain(domain));

        public static unsafe void StreamTo<T>(this IRandomizer random, Interval<T> domain, 
            int count, void* pDst, Func<T,bool> filter = null)
                where T : struct
                    => random.Random<T>().StreamTo(domain, count, pDst, filter);


        public static T[] Array<T>(this IRandomizer random, int length, Func<T,bool> filter = null)
            where T : struct
                => random.Stream(domain<T>(), filter).TakeArray((int)length);

        public static T[] Array<T>(this IRandomizer random, Interval<T> domain, int length, 
            Func<T,bool> filter = null)
                where T : struct
                    => random.Stream(domain,filter).TakeArray(length);

        /// <summary>
        /// Produces a random array that occupies 128 bits = 16 bytes of memory
        /// </summary>
        public static T[] Array128<T>(this IRandomizer random, int blocks = 1, 
            Func<T,bool> filter = null)
                where T : struct
                    => random.Array<T>(Z0.Vec128<T>.Length*blocks, filter);

        /// <summary>
        /// Produces a random array that occupies 128 bits = 16 bytes of memory
        /// </summary>
        public static T[] Array256<T>(this IRandomizer random, int blocks = 1, 
            Func<T,bool> filter = null)
                where T : struct
                    => random.Array<T>(Z0.Vec256<T>.Length*blocks, filter);


        public static unsafe Span<T> Span<T>(this IRandomizer random, int samples, 
            Interval<T>? domain = null, Func<T,bool> filter = null)
                where T : struct
        {            
            var dst = span<T>(samples);
            var pDst = pvoid(ref dst[0]);
            random.StreamTo(Domain(domain), samples, pDst, filter);
            return dst;
        }

        public static unsafe Span128<T> Span128<T>(this IRandomizer random, int blocks, 
            Interval<T>? domain = null, Func<T,bool> filter = null)
                where T : struct
        {
            var dst = alloc<T>(Z0.Span128.blocklength<T>(blocks));
            var pDst = pvoid(ref dst[0]);
            random.StreamTo(domain ?? domain<T>(), blocks, pDst, filter);
            return Z0.Span128.load(dst);
        }

        public static unsafe Span256<T> Span256<T>(this IRandomizer random, int blocks, 
            Interval<T>? domain = null, Func<T,bool> filter = null)
                where T : struct
        {
            var dst = alloc<T>(Z0.Span256.blocklength<T>(blocks));            
            var pDst = pvoid(ref dst[0]);
            random.StreamTo(domain ?? domain<T>(), blocks, pDst, filter);
            return Z0.Span256.load(dst);
        }

        /// <summary>
        /// Produces a random 128-bit vector
        /// </summary>
        public static Vec128<T> Vec128<T>(this IRandomizer random)        
            where T : struct
                => Z0.Vec128.single<T>(random.Array128<T>(1));

        /// <summary>
        /// Produces a random 128-bit vector
        /// </summary>
        public static Vec256<T> Vec256<T>(this IRandomizer random, Func<T,bool> filter = null)        
            where T : struct
                => Z0.Vec256.single<T>(random.Array256<T>(1,filter));

        public static R[] Array<R>(this IRandomizer random, uint count, Func<R,bool> filter = null)
            where R : struct
                => random.Stream(domain<R>(),filter).TakeArray((int)count);

        public static IEnumerable<R[]> Arrays<R>(this IRandomizer random, Interval<R> domain, 
            int len, Func<R,bool> filter = null)
                where R : struct
        {
            while(true)
                yield return random.Array<R>(domain,len,filter);
        }
 
        public static IEnumerable<T> NonZeroStream<T>(this IRandomizer random, Interval<T>? domain = null)
                where T : struct
                    => random.Stream(domain, gmath.nonzero);

        public static T[] NonZeroArray<T>(this IRandomizer random, int length, Interval<T>? domain = null)
            where T : struct
                => random.Stream(domain, gmath.nonzero).TakeArray(length);

        public static T[] NonZeroArray128<T>(this IRandomizer random, int blocks = 1)
            where T : struct
                => random.Array128<T>(blocks, gmath.nonzero);

         public static T[] NonZeroArray256<T>(this IRandomizer random, int blocks = 1)
                where T : struct
                    => random.Array256<T>(blocks, gmath.nonzero);
       
        public static unsafe Span<T> NonZeroSpan<T>(this IRandomizer random, int samples, 
            Interval<T>? domain = null)
                where T : struct
                    => random.Span<T>(samples, domain, gmath.nonzero);

       public static unsafe Span128<T> NonZeroSpan128<T>(this IRandomizer random, int blocks, 
            Interval<T>? domain = null)        
                where T : struct  
                    => random.Span128(blocks, domain, gmath.nonzero);

        public static unsafe Span256<T> NonZeroSpan256<T>(this IRandomizer random, int blocks, 
            Interval<T>? domain = null)        
                where T : struct  
                    => random.Span256(blocks, domain, gmath.nonzero);
    }
}