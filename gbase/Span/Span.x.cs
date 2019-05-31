//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;
    
    using static zfunc;
    using static As;

    public static class SpanX
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

        /// <summary>
        /// Constructs a span from a sequence selection
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> ToSpan256<T>(this T[] src)
            where T : struct
            => Z0.Span256.load<T>(src);

        /// <summary>
        /// Constructs a span from a sequence selection
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> ToSpan128<T>(this T[] src)
            where T : struct
            => Z0.Span128.load(src);

        [MethodImpl(Inline)]
        public static Span128<T> ToSpan128<T>(this Span<T> src)
             where T : struct
                => Z0.Span128.load(src);

        [MethodImpl(Inline)]
        public static Span256<T> ToSpan256<T>(this Span<T> src)
             where T : struct
                => Z0.Span256.load(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpanPair<T> PairWith<T>(this ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)        
            => new ReadOnlySpanPair<T>(lhs,rhs);
    
        [MethodImpl(Inline)]
        public static Span256<T> Replicate<T>(this Span256<T> src)
            where T : struct
        {
            var dst = span<T>(src.Length);
            src.CopyTo(dst);
            return Z0.Span256.load<T>(dst);
        }

        [MethodImpl(Inline)]
        public static Span256<T> Replicate<T>(this ReadOnlySpan256<T> src)
            where T : struct
        {
            var dst = span<T>(src.Length);
            src.CopyTo(dst);
            return Z0.Span256.load<T>(dst);
        }

        [MethodImpl(Inline)]
        public static Span<N,T> Replicate<N,T>(this Span<N,T> src)
            where T : struct
            where N : ITypeNat, new()
                => Spans.replicate(src);

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

    
        public static string Format<T>(this ReadOnlySpan<T> src, char delimiter = ',', int offset = 0)
        {
            var sb = new StringBuilder();            
            for(var i = offset; i< src.Length; i++)
            {
                if(i != offset)
                    sb.Append(delimiter);
                sb.Append($"{src[i]}");
            }
            return sb.ToString();
        }

        [MethodImpl(Inline)]        
        public static string Format<T>(this Span<T> src, char delimiter = ',', int offset = 0)
            => src.ToReadOnlySpan().Format(delimiter, offset);

        [MethodImpl(Inline)]        
        public static string Format<T>(this ReadOnlySpan128<T> src, char delimiter = ',', int offset = 0)
            where T : struct
            => src.Unblock().Format(delimiter, offset);

        [MethodImpl(Inline)]        
        public static string Format<T>(this Span128<T> src, char delimiter = ',', int offset = 0)
            where T : struct
            => src.Unblock().Format(delimiter, offset);

        [MethodImpl(Inline)]        
        public static string Format<T>(this ReadOnlySpan256<T> src, char delimiter = ',', int offset = 0)
            where T : struct
            => src.UnBlock().Format(delimiter, offset);

        [MethodImpl(Inline)]        
        public static string Format<T>(this Span256<T> src, char delimiter = ',', int offset = 0)
            where T : struct
            => src.Unblock().Format(delimiter, offset);

    }
}