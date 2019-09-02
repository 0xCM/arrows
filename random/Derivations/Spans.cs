//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class RngX
    {
        [MethodImpl(Inline)]
        public static Span<T> Span<T>(this IRandomSource random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var stream = domain != null ? random.Stream<T>(domain.Value) : random.Stream<T>();
            return stream.TakeSpan(length);
        }

        [MethodImpl(Inline)]
        public static Span<T> Span<T>(this IRandomSource random, int length, Interval<T> domain)
            where T : struct
            => random.Stream<T>(domain).TakeSpan(length);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadOnlySpan<T>(this IRandomSource random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Span<T>(length, domain, filter);

        [MethodImpl(Inline)]
        public static Span128<T> Span128<T>(this IRandomSource random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Stream(domain,filter).TakeSpan(Z0.Span128.BlockLength<T>(blocks)).ToSpan128(); 

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> ReadOnlySpan128<T>(this IRandomSource random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Span128<T>(blocks, domain, filter);

        [MethodImpl(Inline)]
        public static Span256<T> Span256<T>(this IRandomSource random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct       
            => random.Stream(domain,filter).TakeSpan(Z0.Span256.BlockLength<T>(blocks)).ToSpan256();       

        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan256<T> ReadOnlySpan256<T>(this IRandomSource random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Span256<T>(blocks, domain, filter);
    }
}