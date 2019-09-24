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
        /// Applies a logical left shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector8 sll(BitVector8 x, int offset)
            => Bits.sll(x.Scalar,offset);
            
        /// <summary>
        /// Applies a logical left shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector16 sll(BitVector16 x, int offset)
            => Bits.sll(x.Scalar,offset);

        /// <summary>
        /// Applies a logical left shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector32 sll(BitVector32 x, int offset)
            => Bits.sll(x.Scalar,offset);

        /// <summary>
        /// Applies a logical left shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector64 sll(BitVector64 x, int offset)
            => Bits.sll(x.Scalar,offset);
 
        /// <summary>
        /// Computes z = x << offset for a caller-supplied target bitvector z and source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The amount to shift leftwards</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector8 sll(BitVector8 x, int offset, ref BitVector8 z)
        {
            z.assign(Bits.sll(x.Scalar, offset));
            return ref z;
        }

        /// <summary>
        /// Computes z = x << offset for a caller-supplied target bitvector z and source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The amount to shift leftwards</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector16 sll(BitVector16 x, int offset, ref BitVector16 z)
        {
            z.assign(Bits.sll(x.Scalar, offset));
            return ref z;
        }

        /// <summary>
        /// Computes z = x << offset for a caller-supplied target bitvector z and source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The amount to shift leftwards</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector32 sll(BitVector32 x, int offset, ref BitVector32 z)
        {
            z.assign(Bits.sll(x.Scalar, offset));
            return ref z;
        }

        /// <summary>
        /// Computes z = x << offset for a caller-supplied target bitvector z and source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The amount to shift leftwards</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector64 sll(BitVector64 x, int offset, ref BitVector64 z)
        {
            z.assign(Bits.sll(x.Scalar, offset));
            return ref z;
        }

        /// <summary>
        /// Computes a leftwards shift in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The bit offset amount</param>
        [MethodImpl(Inline)]
        public static ref BitVector8 sll(ref BitVector8 x, int offset)
        {
            x.assign(Bits.sll(x.Scalar,offset));
            return ref x;
        }

        /// <summary>
        /// Computes a leftwards shift in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The bit offset amount</param>
        [MethodImpl(Inline)]
        public static ref BitVector16 sll(ref BitVector16 x, int offset)
        {
            x.assign(Bits.sll(x.Scalar,offset));
            return ref x;
        }

        /// <summary>
        /// Computes a leftwards shift in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The bit offset amount</param>
        [MethodImpl(Inline)]
        public static ref BitVector32 sll(ref BitVector32 x, int offset)
        {
            x.assign(Bits.sll(x.Scalar,offset));
            return ref x;
        }

        /// <summary>
        /// Computes a leftwards shift in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The bit offset amount</param>
        [MethodImpl(Inline)]
        public static ref BitVector64 sll(ref BitVector64 x, int offset)
        {
            x.assign(Bits.sll(x.Scalar,offset));
            return ref x;
        }


    }

}