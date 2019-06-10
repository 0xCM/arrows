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
                ? random.Random<T>().Stream(Randomizer.Domain(domain)).Where(filter) 
                : random.Random<T>().Stream(Randomizer.Domain(domain));

        public static IEnumerable<T> Stream<T>(this IRandomizer random)
            where T : struct
                => random.Random<T>().Stream();
                
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
            random.StreamTo(Randomizer.Domain(domain), length, ref dst[0], filter);
            return dst;
        }

        public static unsafe ReadOnlySpan<T> ReadOnlySpan<T>(this IRandomizer random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Span<T>(length, domain, filter);

        public static T[] Array<T>(this IRandomizer random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Stream(Randomizer.Domain(domain), filter).TakeArray((int)length);

        public static Span128<T> Span128<T>(this IRandomizer random, int blocks, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var dst = span<T>(Z0.Span128.blocklength<T>(blocks));
            random.StreamTo(Randomizer.Domain(domain), dst.Length, ref dst[0], filter);
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
            random.StreamTo(Randomizer.Domain(domain), dst.Length, ref dst[0], filter);
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

        public static Span<N,T> NatSpan<N,T>(this IRandomizer random, N length = default)
            where T : struct  
            where N : ITypeNat, new()
            {
                var src = random.Span<T>((int)length.value);
                return Z0.NatSpan.Adapt<N,T>(src);                                    
            }        

        /// <summary>
        /// Implements Leimire's algorithm for sampling a uniformly distribute random number
        /// in an interval [0,..,max)
        /// </summary>
        /// <param name="rng">A random source</param>
        /// <param name="max">The upper bound for the sample</param>
        /// <remarks>Reference: Fast Random Integer Generation in an Interval, Daniel Lemire 2018</remarks>
        public static ulong NextInteger(this IRandomSource rng, ulong max) 
        {
            var x = rng.NextInteger();
            dinx.mul(x, max, out UInt128 m);
            ulong l = m.lo;
            if (l < max) 
            {
                ulong t = ~max % max;
                while (l < t) 
                {
                    x = rng.NextInteger();
                    m = dinx.mul(x, max, out UInt128 z);
                    l = m.lo;                    
                }
            }
        
            var vec = dinx.shiftrw(m.ToVec128(), 8);
            return vec.ToUInt128().lo;
        }

        public static IEnumerable<ulong> Integers(this IRandomSource rng, ulong max)
        {
            while(true)
                yield return rng.NextInteger(max);
        }
   
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
            => new SystemRandom(rng);
    }   
    
    class SystemRandom : System.Random
    {
        public SystemRandom(IRandomSource Source)
        {
            this.Source = Source;
        }

        IRandomSource Source {get;}

        public override int Next()
            => (int)Source.NextInteger((ulong)Int32.MaxValue);

        public override int Next(int maxValue)
            => (int)Source.NextInteger((ulong)maxValue);

        public override int Next(int minValue, int maxValue)
        {
            var delta = maxValue - minValue;
            if(delta > 0)
                return minValue + Next(delta);
            else
                return minValue + Next(-delta);
        }

        public override void NextBytes(byte[] buffer)
        {
            var src = Source.Bytes().Take(buffer.Length);
            var i = 0;
            var it = src.GetEnumerator();
            while(it.MoveNext())
                buffer[i++] = it.Current;
        }

        public override void NextBytes(Span<byte> buffer)
        {
            var src = Source.Bytes().Take(buffer.Length);
            var i = 0;
            var it = src.GetEnumerator();
            while(it.MoveNext())
                buffer[i++] = it.Current;

        }
        public override double NextDouble()
            => Source.NextDouble();

    }
}