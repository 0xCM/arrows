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
        static Interval<T> Domain<T>(Interval<T>? domain)
            where T : struct
                => domain ?? SampleDefaults.get<T>().SampleDomain;

        public static IRandomizer<T> Random<T>(this IRandomizer random)
            where T : struct
                => (IRandomizer<T>)(random);

        public static IEnumerable<T> Stream<T>(this IRandomizer random, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => filter != null 
                ? random.Random<T>().Stream(Domain(domain)).Where(filter) 
                : random.Random<T>().Stream(Domain(domain));

        static unsafe void StreamTo<T>(this IRandomizer random, int length, Interval<T>? domain, Func<T,bool> filter, void* pDst)
            where T : struct
                => random.Random<T>().StreamTo(Domain(domain), length, pDst, filter);

        public static T Single<T>(this IRandomizer src, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => src.Stream<T>(domain).Single();

        public static T[] Array<T>(this IRandomizer random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Stream(Domain(domain), filter).TakeArray((int)length);
        
        /// <summary>
        /// Produces a random array that occupies 128 bits = 16 bytes of memory
        /// </summary>
        public static T[] Array128<T>(this IRandomizer random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Array<T>(Z0.Vec128<T>.Length * blocks, domain, filter);

        /// <summary>
        /// Produces a random array that occupies 128 bits = 16 bytes of memory
        /// </summary>
        public static T[] Array256<T>(this IRandomizer random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Array<T>(Z0.Vec256<T>.Length * blocks, Domain(domain), filter);

        public static unsafe Span<T> Span<T>(this IRandomizer random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {            
            var dst = span<T>(length);
            random.StreamTo(length, Domain(domain), filter, pvoid(ref dst[0]));
            return dst;
        }
        
        public static unsafe Span128<T> Span128<T>(this IRandomizer random, int blocks, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var dst = span<T>(Z0.Span128.blocklength<T>(blocks));
            random.StreamTo(dst.Length, Domain(domain), filter, pvoid(ref dst[0]));
            return Z0.Span128.load(dst);
        }

        public static unsafe Span256<T> Span256<T>(this IRandomizer random, int blocks, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var dst = span<T>(Z0.Span256.blocklength<T>(blocks));            
            random.StreamTo(dst.Length, Domain(domain), filter, pvoid(ref dst[0]));
            return Z0.Span256.load(dst);
        }

        public static Vec128<T> Vec128<T>(this IRandomizer random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : struct
                => random.Span128<T>(1, domain, filter).Vector();

        public static Vec256<T> Vec256<T>(this IRandomizer random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : struct
                => random.Span256<T>(1, domain, filter).Vector();

        public static (Vec128<T> Left, Vec128<T> Right) Vec128Pair<T>(this IRandomizer random, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var left = random.Span128<T>(1, Domain(domain), filter);
            var right = random.Span128<T>(1, Domain(domain), filter);
            return (Z0.Vec128.single(left),Z0.Vec128.single(right));
        }

        public static (Vec256<T> Left, Vec256<T> Right) Vec256Pair<T>(this IRandomizer random, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var left = random.Span256<T>(1, Domain(domain), filter);
            var right = random.Span256<T>(1, Domain(domain), filter);
            return (Z0.Vec256.single(left),Z0.Vec256.single(right));
        }


        public static T[] Array<T>(this IRandomizer random, uint len, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Stream(Domain(domain), filter).TakeArray((int)len);

        public static IEnumerable<T> NonZeroStream<T>(this IRandomizer random, Interval<T>? domain = null)
                where T : struct
                    => random.Stream(domain, gmath.nonzero);
        public static T[] NonZeroArray<T>(this IRandomizer random, int length, Interval<T>? domain = null)
            where T : struct
                => random.Stream(domain, gmath.nonzero).TakeArray(length);

        public static T[] NonZeroArray128<T>(this IRandomizer random, int blocks = 1, Interval<T>? domain = null)
            where T : struct
                => random.Array128<T>(blocks, domain, gmath.nonzero);

        public static T[] NonZeroArray256<T>(this IRandomizer random, int blocks = 1, Interval<T>? domain = null)
            where T : struct
                => random.Array256<T>(blocks, domain, gmath.nonzero);       
        
        public static unsafe Span<T> NonZeroSpan<T>(this IRandomizer random, int samples, Interval<T>? domain = null)
                where T : struct
                    => random.Span<T>(samples, domain, gmath.nonzero);
        
        public static Span128<T> NonZeroSpan128<T>(this IRandomizer random, int blocks,  Interval<T>? domain = null)        
            where T : struct  
                => random.Span128(blocks, domain, gmath.nonzero);

        public static Span256<T> NonZeroSpan256<T>(this IRandomizer random, int blocks, Interval<T>? domain = null)        
            where T : struct  
                => random.Span256(blocks, domain, gmath.nonzero);

        public static T NonZeroSingle<T>(this IRandomizer src, Interval<T>? domain = null)
            where T : struct
                => src.NonZeroStream<T>(domain).Single();
    }
}