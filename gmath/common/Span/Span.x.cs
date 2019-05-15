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

    
    using static mfunc;
    using static zfunc;

    public static class SpanX
    {

        [MethodImpl(NotInline)]
        public static bool Any<T>(this Span128<T> src, Func<T,bool> f)
             where T : struct
            => src.ToReadOnlySpan().Any(f);

        /// <summary>
        /// Constructs a span from a sequence selection
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> ToSpan256<T>(this T[] src)
            where T : struct
            => (Span256<T>)src;

        /// <summary>
        /// Constructs a span from a sequence selection
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> ToSpan128<T>(this T[] src)
            where T : struct
            => (Span128<T>)src;


        [MethodImpl(Inline)]
        public static Span128<T> ToSpan128<T>(this Span<T> src)
             where T : struct
                => (Span128<T>)src;

        [MethodImpl(Inline)]
        public static Span256<T> ToSpan256<T>(this Span<T> src)
             where T : struct
                => (Span256<T>)src; 
    }

}