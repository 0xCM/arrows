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

    using static zfunc;
    using static As;

    public static class SourceFactory
    {
        /// <summary>
        /// Derives an int8 random source from a uint8 random source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="target">The range of the target generator</param>
        [MethodImpl(Inline)]
        public static IBoundRandomSource<sbyte> DeriveSource(this IRandomSource<byte> src, Interval<sbyte>? target = null) 
            => new PolyRandI8(src,target);

        /// <summary>
        /// Derives an uint8 random source from a uint64 random source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="target">The range of the target generator</param>
        [MethodImpl(Inline)]
        public static IBoundRandomSource<byte> DeriveSource(this IRandomSource<ulong> src, Interval<byte>? target = null) 
            => new PolyRandU8(src,target);

        /// <summary>
        /// Queries a non-specified source for a point-source
        /// </summary>
        /// <param name="src">The source to query</param>
        /// <typeparam name="T">The point type</typeparam>
        [MethodImpl(Inline)]
        public static Option<IRandomSource<T>> PointSource<T>(this IRandomSource src)
            where T : struct
                => src is IRandomSource<T> x ? some(x) : null;

    }


}