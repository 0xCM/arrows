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

        /// <summary>
        /// Allocates a natural bitvector and, optionally, populates all components 
        /// with a specified value
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
            Span<T> components = new T[count];
            if(gmath.nonzero(fill))
                components.Fill(fill);
            return new BitVector<N,T>(components);
        }

        /// <summary>
        /// Allocates a generic bitvector and, optionally, populates all components 
        /// with a specified value
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
            Span<T> components = new T[count];
            if(gmath.nonzero(fill))
                components.Fill(fill);
            return new BitVector<T>(components);
        }

        /// <summary>
        /// Defines an 4-bit bitvector from a scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 Load(UInt4 src)
            => src;

        /// <summary>
        /// Defines an 8-bit bitvector from a scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 Load(sbyte src)
            => (byte)src;

        /// <summary>
        /// Defines an 8-bit bitvector from a scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 Load(byte src)
            => src;

        /// <summary>
        /// Defines a 16-bit bitvector from a scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 Load(short src)
            => (ushort)src;

        /// <summary>
        /// Defines a 16-bit bitvector from a scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 Define(ushort src)
            => src;

        /// <summary>
        /// Defines a 32-bit bitvector from a scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 Load(int src)
            => (uint)src;

        /// <summary>
        /// Defines a 32-bit bitvector from a scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 Load(uint src)
            => src;

        /// <summary>
        /// Defines a 32-bit bitvector from a scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 Load(long src)
            => (ulong)src;

        /// <summary>
        /// Defines a 64-bit bitvector from a scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 Load(ulong src)
            => src;

        /// <summary>
        /// Defines a 32-bit bitvector from a scalar float
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 Load(float src)
            => (uint)BitConverter.SingleToInt32Bits(src);

        /// <summary>
        /// Defines a 64-bit bitvector from a scalar double
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 Load(double src)
            => (ulong)BitConverter.DoubleToInt64Bits(src);

        /// <summary>
        /// Creates a generic bitvector of natural length
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Load<N,T>(in T src, N len = default)        
            where N : ITypeNat, new()
            where T : struct
                => new BitVector<N,T>(src);

        /// <summary>
        /// Constructs a bitvector of natural length from a source span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Load<N,T>(Span<T> src, N n = default)
            where N : ITypeNat, new()
            where T : struct
                => new BitVector<N, T>(src);

        /// <summary>
        /// Constructs a bitvector of natural length from a source span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Load<N,T>(ReadOnlySpan<T> src, N n = default)
            where N : ITypeNat, new()
            where T : struct
                => new BitVector<N, T>(src);

        /// <summary>
        /// Constructs a bitvector where the length is determined by the capacity
        /// of the source span if unspecified
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> Load<T>(Span<T> src, BitSize? bitcount = null)
            where T : struct
                => new BitVector<T>(src, bitcount);

        /// <summary>
        /// Constructs a bitvector where the length is determined by the capacity
        /// of the source span if unspecified
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> Load<T>(ReadOnlySpan<T> src, BitSize? bitcount = null)
            where T : struct
                => new BitVector<T>(src,bitcount);

        /// <summary>
        /// Creates a generic bitvector over an arbitrary number of elements
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> FromSegments<T>(params T[] src)
            where T : struct
                => BitVector<T>.Define(src);

        /// <summary>
        /// Defines a generic bitvector with a specified number of components
        /// </summary>
        /// <param name="bitcount">The number of components (bits) in the vector</param>
        /// <param name="src">The source from which the bits will be extracted</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> FromSegments<T>(BitSize bitcount, params T[] src)
            where T : struct
                => BitVector<T>.Define(bitcount, src);
    }
}