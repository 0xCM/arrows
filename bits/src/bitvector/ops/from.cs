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

    partial class bitvector
    {
        /// <summary>
        /// Defines an 4-bit bitvector from a 4-bit unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 from(UInt4 src)
            => src;

        /// <summary>
        /// Defines an 8-bit bitvector from an 8-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 from(sbyte src)
            => (byte)src;

        /// <summary>
        /// Defines an 8-bit bitvector from an 8-bit unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 from(byte src)
            => src;

        /// <summary>
        /// Defines a 16-bit bitvector from a 16-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 from(short src)
            => (ushort)src;

        /// <summary>
        /// Defines a 16-bit bitvector from a 16-bit unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 from(ushort src)
            => src;

        /// <summary>
        /// Defines a 32-bit bitvector from a 32-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 from(int src)
            => (uint)src;

        /// <summary>
        /// Defines a 32-bit bitvector from a 32-bit unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 from(uint src)
            => src;

        /// <summary>
        /// Defines a 64-bit bitvector from a 64-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 from(long src)
            => (ulong)src;

        /// <summary>
        /// Defines a 64-bit bitvector from a 64-bit unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 from(ulong src)
            => src;

        /// <summary>
        /// Defines a 32-bit bitvector from a 32-bit floating point
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 from(float src)
            => (uint)src.ToBits();

        /// <summary>
        /// Defines a 64-bit bitvector from a 64-bit floating point
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 from(double src)
            => (ulong)src.ToBits();

        /// <summary>
        /// Creates a generic bitvector of natural length from a single cell
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="n">The bitvector length</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> from<N,T>(T src, N n = default)        
            where N : ITypeNat, new()
            where T : unmanaged
                => BitVector<N,T>.FromCell(src);

        /// <summary>
        /// Creates a generic bitvector from a single cell subject to an optionally-specified length
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="n">The bitvector length</param>
        [MethodImpl(Inline)]
        public static BitVector<T> from<T>(T src, BitSize? n = null)
            where T : unmanaged
                => BitVector<T>.FromCell(src,n);

    }

}