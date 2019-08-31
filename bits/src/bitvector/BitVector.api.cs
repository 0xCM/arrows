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
        public static BitVector<N,T> Alloc<N,T>(N len = default, in T fill = default)
            where N : ITypeNat, new()
            where T : struct
        {
            var bitcount = nati<N>();
            var count = CellCount<T>(bitcount);        
            var components = new T[count];
            if(gmath.nonzero(fill))
                components.Fill(fill);
            return new BitVector<N,T>(components);
        }

        /// <summary>
        /// Allocates a generic bitvector
        /// </summary>
        /// <param name="len">The length</param>
        /// <param name="fill">The fill value</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        public static BitVector<T> Alloc<T>(BitSize len, in T fill = default)
            where T : struct
        {
            var capacity = BitVector<T>.SegmentCapacity;
            var q = Math.DivRem(len, capacity, out int r);    
            var count = CellCount<T>(len);        
            var components = new T[count];
            if(gmath.nonzero(fill))
                components.Fill(fill);
            return new BitVector<T>(components);
        }

        /// <summary>
        /// Defines an 4-bit bitvector from a scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 FromNibble(UInt4 src)
            => src;

        /// <summary>
        /// Defines a 32-bit bitvector from a scalar float
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 FromFloat(float src)
            => (uint)BitConverter.SingleToInt32Bits(src);

        /// <summary>
        /// Defines a 64-bit bitvector from a scalar double
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 FromFloat(double src)
            => (ulong)BitConverter.DoubleToInt64Bits(src);

        /// <summary>
        /// Creates a generic bitvector of natural length
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="n">The bitvector length</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> FromCell<N,T>(in T src, N n = default)        
            where N : ITypeNat, new()
            where T : struct
                => new BitVector<N,T>(src);

        /// <summary>
        /// Creates a generic bitvector defined by a single segment subject to a specified length, if any
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="n">The bitvector length</param>
        [MethodImpl(Inline)]
        public static BitVector<T> FromCell<T>(T src, BitSize? n = null)
            where T : struct
                => BitVector<T>.FromCell(src,n);

        /// <summary>
        /// Loads a bitvector of natural length from a span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> FromCells<N,T>(Span<T> src, N n = default)
            where N : ITypeNat, new()
            where T : struct
                => new BitVector<N, T>(src);

        /// <summary>
        /// Loads a bitvector of natural length from an array
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> FromCells<N,T>(T[] src, N n = default)
            where N : ITypeNat, new()
            where T : struct
                => new BitVector<N, T>(src);

        /// <summary>
        /// Loads a bitvector of natural length from a primal segment
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> FromCells<N,T>(Memory<T> src, N n = default)
            where N : ITypeNat, new()
            where T : struct
                => new BitVector<N, T>(src);

        /// <summary>
        /// Loads a bitvector of natural length from a primal span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> FromCells<N,T>(ReadOnlySpan<T> src, N n = default)
            where N : ITypeNat, new()
            where T : struct
                => new BitVector<N, T>(src);

        /// <summary>
        /// Loads a generic bitvector from a primal span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The vector length</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> FromCells<T>(Span<T> src, BitSize? n = null)
            where T : struct
                => BitVector<T>.FromCells(src,n);

        /// <summary>
        /// Loads a generic bitvector from a primal memory block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The vector length</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> FromCells<T>(Memory<T> src, BitSize? n = null)
            where T : struct
                => BitVector<T>.FromCells(src,n);

        /// <summary>
        /// Loads a generic bitvector from a primal span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The vector length</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> FromCells<T>(ReadOnlySpan<T> src, BitSize? n = null)
            where T : struct
                => BitVector<T>.FromCells(src,n);

        /// <summary>
        /// Creates a generic bitvector defined by an arbitrary number of segments
        /// </summary>
        /// <param name="src">The source segment</param>
        [MethodImpl(Inline)]
        public static BitVector<T> FromCells<T>(params T[] src)
            where T : struct
                => BitVector<T>.FromCells(src);

        /// <summary>
        /// Defines a generic bitvector with a specified number of components
        /// </summary>
        /// <param name="n">The number of components (bits) in the vector</param>
        /// <param name="src">The source from which the bits will be extracted</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> FromCells<T>(BitSize n, params T[] src)
            where T : struct
                => BitVector<T>.FromCells(n, src);
 
        /// <summary>
        /// Computes the number of cells required to hold a specified number of bits
        /// </summary>
        /// <param name="len">The number of bits to store</param>
        /// <typeparam name="T">The primal storage type</typeparam>
        [MethodImpl(Inline)]
        public static int CellCount<T>(BitSize len)
            where T : struct
        {
            var capacity = BitVector<T>.SegmentCapacity;
            var q = Math.DivRem(len, capacity, out int r);            
            return r == 0 ? q : q + 1;
        }
    }
}