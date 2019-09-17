//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static nfunc;

    public static class BitVector
    {   

        /// <summary>
        /// Allocates a generic bitvector of natural length
        /// </summary>
        /// <param name="len">The length</param>
        /// <param name="fill">The fill value</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        public static BitVector<N,T> Alloc<N,T>(N len = default, T? fill = null)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitVector<N,T>.Alloc(fill);

        /// <summary>
        /// Allocates a generic bitvector
        /// </summary>
        /// <param name="len">The length</param>
        /// <param name="fill">The fill value</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        public static BitVector<T> Alloc<T>(BitSize len, T? fill = null)
            where T : unmanaged
                => BitVector<T>.Alloc(len, fill);
            
        /// <summary>
        /// Loads a bitvector of natural length from a span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Load<N,T>(Span<T> src, N n = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitVector<N, T>.Load(src);

        /// <summary>
        /// Loads a bitvector of natural length from a primal span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Load<N,T>(ReadOnlySpan<T> src, N n = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitVector<N, T>.Load(src.ToSpan());

        /// <summary>
        /// Loads a bitvector of natural length from an array
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Load<N,T>(T[] src, N n = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitVector<N, T>.Load(src);

        /// <summary>
        /// Loads a generic bitvector from an array
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The vector length</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> Load<T>(T[] src, BitSize? n = null)
            where T : unmanaged
                => BitVector<T>.Load(src, n);

        /// <summary>
        /// Loads a generic bitvector from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The vector length</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> Load<T>(Span<T> src, BitSize? n = null)
            where T : unmanaged
                => BitVector<T>.Load(src, n);

        /// <summary>
        /// Defines a generic bitvector with a specified number of components and bitlength
        /// </summary>
        /// <param name="n">The number of components (bits) in the vector</param>
        /// <param name="src">The source from which the bits will be extracted</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> Load<T>(T[] src, BitSize n)
            where T : unmanaged
                => BitVector<T>.Load(src,n);


        /// <summary>
        /// Creates a generic bitvector defined by an arbitrary number of segments
        /// </summary>
        /// <param name="src">The source segment</param>
        [MethodImpl(Inline)]
        public static BitVector<T> Load<T>(params T[] src)
            where T : unmanaged
                => BitVector<T>.Load(src);

 
        /// <summary>
        /// Computes the number of cells required to hold a specified number of bits
        /// </summary>
        /// <param name="len">The number of bits to store</param>
        /// <typeparam name="T">The primal storage type</typeparam>
        [MethodImpl(Inline)]
        public static int CellCount<T>(BitSize len)
            where T : unmanaged
            => BitVector<T>.CellCount(len);

        /// <summary>
        /// Computes the number of cells required to hold a specified number of bits
        /// </summary>
        /// <param name="n">The number of bits to store</param>
        /// <typeparam name="T">The primal storage type</typeparam>
        [MethodImpl(Inline)]
        public static int CellCount<N,T>(N n = default)
            where T : unmanaged
            where N : ITypeNat, new()
                => BitVector<N,T>.CellCount;

    }
}