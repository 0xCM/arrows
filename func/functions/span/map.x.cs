//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class xfunc
    {

        /// <summary>
        /// Projects a source span to target span via a supplied transformation
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="f">The transformation</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> Map<S,T>(this ReadOnlySpan<S> src, Func<S, T> f)
        {
            var dst = span<T>(src.Length);
            for(var i= 0; i<src.Length; i++)
                dst[i] = f(src[i]);
            return dst;
        }

        /// <summary>
        /// Projects a source span to target span via a supplied transformation
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="f">The transformation</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Map<S,T>(this Span<S> src, Func<S, T> f)
            => src.ReadOnly().Map(f);

        public static Span<T> MapRange<S,T>(this ReadOnlySpan<S> src, int offset, int length, Func<S, T> f)
        {
            var dst = span<T>(length);
            for (int i = offset; i < length; i++)
                dst[i] = f(src[i]);
            return dst;
        }

        public static Span<T> Map<M,N,S,T>(this Span<M,N,S> src, Func<S, T> f)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var dst = NatSpan.alloc<M,N,T>();
            var m = nfunc.nati<M>();
            var n = nfunc.nati<N>();
            for(var i=0; i < m; i++)
            for(var j=0; j < n; j++)
                dst[i,j] = f(src[i,j]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> MapRange<S,T>(this Span<S> src, int offset, int length, Func<S, T> f)
            => src.ReadOnly().MapRange(offset,length, f);

    }

}