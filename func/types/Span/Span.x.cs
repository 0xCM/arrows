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
        /// <summary>
        /// Constructs a span from a sequence selection
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> ToSpan256<T>(this T[] src)
            where T : struct
            => Z0.Span256.load<T>(src);


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

    }
}