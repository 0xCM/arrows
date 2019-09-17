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
        /// Computes the complememt bitvector ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 flip(BitVector8 x)
            => math.flip(x.Scalar);
            
        /// <summary>
        /// Computes the complememt bitvector ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 flip(BitVector16 x)
            => math.flip(x.Scalar);

        /// <summary>
        /// Computes the complememt bitvector ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 flip(BitVector32 x)
            => math.flip(x.Scalar);

        /// <summary>
        /// Computes the complememt bitvector ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 flip(BitVector64 x)
            => math.flip(x.Scalar);
 
        /// <summary>
        /// Computes the complement bitvector z = ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector8 flip(in BitVector8 x, ref BitVector8 z)
        {
            z = flip(x);
            return ref z;
        }

        /// <summary>
        /// Computes the complement bitvector z = ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector16 flip(in BitVector16 x, ref BitVector16 z)
        {
            z = flip(x);
            return ref z;
        }

        /// <summary>
        /// Computes the complement bitvector z = ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector32 flip(in BitVector32 x, ref BitVector32 z)
        {
            z = flip(x);
            return ref z;
        }

        /// <summary>
        /// Computes the complement bitvector z = ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector64 flip(in BitVector64 x, ref BitVector64 z)
        {
            z = flip(x);
            return ref z;
        }

        /// <summary>
        /// Computes the complement of the source vector in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector8 flip(ref BitVector8 x)
        {
            x = flip(x);
            return ref x;
        }

        /// <summary>
        /// Computes the complement of the source vector in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector16 flip(ref BitVector16 x)
        {
            x = flip(x);
            return ref x;
        }

        /// <summary>
        /// Computes the complement of the source vector in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector32 flip(ref BitVector32 x)
        {
            x = flip(x);
            return ref x;
        }

        /// <summary>
        /// Computes the complement of the source vector in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector64 flip(ref BitVector64 x)
        {
            x = flip(x);
            return ref x;
        }


    }

}