//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
        
    using static zfunc;

    /// <summary>
    /// Defines the blocked vector api surface
    /// </summary>
    public static class BlockVector
    {     
        /// <summary>
        /// Allocates a block vector of natural length
        /// </summary>
        /// <param name="n">The length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<N,T> Alloc<N,T>(N n = default)
            where N : ITypeNat, new()
            where T : struct
                =>  BlockVector<N,T>.LoadAligned(Span256.Alloc<N,T>());

        /// <summary>
        /// Allocates a block vector of natural length filled with a specified value
        /// </summary>
        /// <param name="n">The length</param>
        /// <param name="fill">The fill value</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<N,T> Alloc<N,T>(N n, T fill)
            where N : ITypeNat, new()
            where T : struct
                =>  BlockVector<N,T>.LoadAligned(Span256.Alloc<N,T>(fill));
        
        /// <summary>
        /// Allocates a block vector optionally filled with a specified value
        /// </summary>
        /// <param name="n">The (minimum) length</param>
        /// <param name="fill">The fill value, if any</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<T> Alloc<T>(int n, T? fill = null)               
            where T : struct
                => Span256.Alloc<T>(n, fill);

        /// <summary>
        /// Loads a vector of natural length from a span that may not be aligned (Allocating if unaligned)
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<N,T> Load<N,T>(Span<T> src, N n = default)
            where N : ITypeNat, new()
            where T : struct
                => BlockVector<N,T>.LoadAligned(Span256.Load(src));

        /// <summary>
        /// Loads a vector of natural length from a parameter array.
        /// This method allocates if the source array is not 256-bit aligned
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<N,T> Load<N,T>(N length, params T[] src)
            where N : ITypeNat, new()
            where T : struct
                => BlockVector<N,T>.LoadAligned(Span256.Load<T>(src));

        /// <summary>
        /// Loads a block vector from a source span, allocating if the span is not 256-bit aligned
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<T> Load<T>(Span<T> src)
            where T : struct
                => Span256.Load(src);

        [MethodImpl(Inline)]
        public static BlockVector<N,T> Load<N,T>(Span256<T> src)
            where N : ITypeNat, new()
            where T : struct
                => BlockVector<N, T>.LoadAligned(src);

        [MethodImpl(Inline)]
        public static BlockVector<N,T> Load<N,T>(Span<N,T> src)
            where N : ITypeNat, new()
            where T : struct
                => src;

        [MethodImpl(Inline)]
        public static BlockVector<T> Zero<T>(int minlen)
            where T : struct
                => Alloc<T>(minlen);

        /// <summary>
        /// Allocates a zero-filled block vector of natural dimension
        /// </summary>
        /// <typeparam name="N">The dimension type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<N,T> Zero<N,T>()
            where N : ITypeNat, new()
            where T : unmanaged
                => Alloc<N,T>();

    }
}