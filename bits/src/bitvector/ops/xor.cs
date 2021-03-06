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
    using static As;

    partial class bitvector
    {
        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 xor(BitVector8 x, BitVector8 y)
            => math.xor(x.data,y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 xor(BitVector16 x, BitVector16 y)
            => math.xor(x.data, y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 xor(BitVector32 x, BitVector32 y)
            => math.xor(x.data, y.data);

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 xor(BitVector64 x, BitVector64 y)
            => math.xor(x.data, y.data);
 
        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector8 xor(BitVector8 x, BitVector8 y, ref BitVector8 z)
        {
            math.xor(x.data, y.data, ref z.data);
            return ref z;
        }

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector16 xor(BitVector16 x, BitVector16 y, ref BitVector16 z)
        {
            math.xor(x.data, y.data, ref z.data);
            return ref z;
        }

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector32 xor(BitVector32 x, BitVector32 y, ref BitVector32 z)
        {
            math.xor(x.data, y.data, ref z.data);
            return ref z;
        }

        /// <summary>
        /// Computes a new bitvector z = x & y from bitvectors x xor y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector64 xor(BitVector64 x, BitVector64 y, ref BitVector64 z)
        {
            math.xor(x.data, y.data, ref z.data);
            return ref z;
        }
    }
}