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

    public static class RNGx
    {
        [MethodImpl(Inline)]
        static bool nonzero<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return int8(src) != 0;
            else if(typeof(T) == typeof(byte))
                return uint8(src) != 0;
            else if(typeof(T) == typeof(short))
                return int16(src) != 0;
            else if(typeof(T) == typeof(ushort))
                return uint16(src) != 0;
            else if(typeof(T) == typeof(int))
                return int32(src) != 0;
            else if(typeof(T) == typeof(uint))
                return uint32(src) != 0;
            else if(typeof(T) == typeof(long))
                return int64(src) != 0;
            else if(typeof(T) == typeof(ulong))
                return uint64(src) != 0;
            else if(typeof(T) == typeof(float))
                return float32(src) != 0;
            else if(typeof(T) == typeof(double))
                return float64(src) != 0;
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }


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

        public static unsafe Span<T> Span<T>(this IRandomizer random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
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
                    => random.Stream(domain, nonzero);

        [MethodImpl(Inline)]
        public static T NonZeroSingle<T>(this IRandomizer src, Interval<T>? domain = null)
            where T : struct
                => src.NonZeroStream<T>(domain).Single();
         
        [MethodImpl(Inline)]
        public static T[] NonZeroArray<T>(this IRandomizer random, int length, Interval<T>? domain = null)
            where T : struct
                => random.Stream(domain, nonzero).TakeArray(length);        

        [MethodImpl(Inline)]
        public static Span<T> NonZeroSpan<T>(this IRandomizer random, int samples, Interval<T>? domain = null)
                where T : struct
                    => random.Span<T>(samples, domain, nonzero);        

        [MethodImpl(Inline)]
        public static Span128<T> NonZeroSpan128<T>(this IRandomizer random, int blocks, Interval<T>? domain = null)        
            where T : struct  
                => random.Span128(blocks, domain, nonzero);

        [MethodImpl(Inline)]
        public static Span128<T> Span128<T>(this IRandomizer random, int blocks, Interval<T>? domain,  bool notZero = false)
            where T : struct
        {
            Func<T,bool> filter = notZero ? new Func<T,bool>(nonzero) : null; 
            return random.Span128<T>(blocks, domain, filter);
        }

        [MethodImpl(Inline)]
        public static Span256<T> NonZeroSpan256<T>(this IRandomizer random, int blocks, Interval<T>? domain = null)        
            where T : struct  
                => random.Span256(blocks, domain, nonzero);


     // file:///J:/lang/areas/numerics/Lemire%20-%20Fast%20Random%20Integer%20Generation%20in%20an%20Interval.pdf        
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
   
    }

}