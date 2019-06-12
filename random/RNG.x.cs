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

    public static partial class RNGx
    {

        public static IRandomizer<T> Random<T>(this IRandomizer random)
            where T : struct
                => (IRandomizer<T>)(random);

        public static IEnumerable<T> Stream<T>(this IRandomizer random, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => filter != null 
                ? random.Random<T>().UniformStream(XOrStarStar256.Domain(domain)).Where(filter) 
                : random.Random<T>().UniformStream(XOrStarStar256.Domain(domain));
                
        public static IEnumerable<(T Left, T Right)> Pairs<T>(this IRandomizer random, int count, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var lhs = random.Array<T>(count, domain, filter);
            var rhs = random.Array<T>(count, domain, filter);
            return zip(lhs,rhs);
        }

        public static T Single<T>(this IRandomizer src, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => src.Stream<T>(domain).First();

        public static Span<T> Span<T>(this IRandomizer random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {            
            var dst = span<T>(length);
            random.StreamTo(XOrStarStar256.Domain(domain), length, ref dst[0], filter);
            return dst;
        }

        public static unsafe ReadOnlySpan<T> ReadOnlySpan<T>(this IRandomizer random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Span<T>(length, domain, filter);

        public static T[] Array<T>(this IRandomizer random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Stream(XOrStarStar256.Domain(domain), filter).TakeArray((int)length);

        public static Span128<T> Span128<T>(this IRandomizer random, int blocks, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var dst = span<T>(Z0.Span128.blocklength<T>(blocks));
            random.StreamTo(XOrStarStar256.Domain(domain), dst.Length, ref dst[0], filter);
            return Z0.Span128.load(dst);
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> ReadOnlySpan128<T>(this IRandomizer random, int blocks, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Span128<T>(blocks, domain, filter);

        public static unsafe Span256<T> Span256<T>(this IRandomizer random, int blocks, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var dst = span<T>(Z0.Span256.blocklength<T>(blocks));            
            random.StreamTo(XOrStarStar256.Domain(domain), dst.Length, ref dst[0], filter);
            return Z0.Span256.load(dst);
        }

        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan256<T> ReadOnlySpan256<T>(this IRandomizer random, int blocks, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Span256<T>(blocks, domain, filter);
 
        [MethodImpl(Inline)]
        public static IEnumerable<T> NonZeroStream<T>(this IRandomizer random, Interval<T>? domain = null)
                where T : struct
                    => random.Stream(domain, gmath.nonzero);

        [MethodImpl(Inline)]
        public static T NonZeroSingle<T>(this IRandomizer src, Interval<T>? domain = null)
            where T : struct
                => src.NonZeroStream<T>(domain).Single();
         
        [MethodImpl(Inline)]
        public static T[] NonZeroArray<T>(this IRandomizer random, int length, Interval<T>? domain = null)
            where T : struct
                => random.Stream(domain, gmath.nonzero).TakeArray(length);        

        [MethodImpl(Inline)]
        public static Span<T> NonZeroSpan<T>(this IRandomizer random, int samples, Interval<T>? domain = null)
                where T : struct
                    => random.Span<T>(samples, domain, gmath.nonzero);        

        [MethodImpl(Inline)]
        public static Span128<T> NonZeroSpan128<T>(this IRandomizer random, int blocks, Interval<T>? domain = null)        
            where T : struct  
                => random.Span128(blocks, domain, gmath.nonzero);

        [MethodImpl(Inline)]
        public static Span128<T> Span128<T>(this IRandomizer random, int blocks, Interval<T>? domain,  bool notZero = false)
            where T : struct
        {
            Func<T,bool> filter = notZero ? new Func<T,bool>(gmath.nonzero) : null; 
            return random.Span128<T>(blocks, domain, filter);
        }

        [MethodImpl(Inline)]
        public static Span256<T> NonZeroSpan256<T>(this IRandomizer random, int blocks, Interval<T>? domain = null)        
            where T : struct  
                => random.Span256(blocks, domain, gmath.nonzero);

        [MethodImpl(Inline)]
        public static Span<N,T> Span<N,T>(this IRandomizer random, N length = default, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct  
            where N : ITypeNat, new()
                => NatSpan.adapt<N,T>(random.Span<T>((int)length.value, domain, filter));                                    


        [MethodImpl(Inline)]
        public static Span<M,N,T> Span<M,N,T>(this IRandomizer random, M rows = default, N cols = default)
            where T : struct  
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => NatSpan.adapt<M,N,T>(random.Span<T>(nfunc.muli(rows,cols)), rows, cols);

        [MethodImpl(Inline)]
        public static Span<M,N,T> Span<M,N,T>(this IRandomizer random, M rows, N cols, Interval<T> domain)
            where T : struct  
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => NatSpan.adapt<M,N,T>(random.Span<T>(nfunc.muli(rows,cols),domain), rows, cols);

        /// <summary>
        /// Samples a gaussian distribution
        /// </summary>
        /// <param name="rng"></param>
        /// <param name="mean"></param>
        /// <param name="stdDev"></param>
        /// <remarks>See https://en.wikipedia.org/wiki/Marsaglia_polar_method</remarks>
        public static IEnumerable<double> Gaussian(this IRandomSource rng, double mean, double stdDev) 
        {            
            while(true)
            {
                double u, v, s;
                do 
                {
                    u = rng.NextDouble() * 2 - 1;
                    v = rng.NextDouble() * 2 - 1;
                    s = u * u + v * v;                
                } while (s >= 1 || s == 0);
                var x = math.sqrt(-2.0 * math.ln(s) / s);
                yield return v * x;
                yield return mean + stdDev * u * x;
           }
        }

        
        public static System.Random SystemRandom(this IRandomSource rng)
            => new SysRand(rng);
    }   
    
 
}