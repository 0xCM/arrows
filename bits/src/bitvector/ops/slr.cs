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
        /// Applies a logical right shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector8 srl(BitVector8 x, int offset)
            => math.srl(x.Scalar,offset);
            
        /// <summary>
        /// Applies a logical right shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector16 srl(BitVector16 x, int offset)
            => math.srl(x.Scalar,offset);

        /// <summary>
        /// Applies a logical right shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector32 srl(BitVector32 x, int offset)
            => math.srl(x.Scalar,offset);

        /// <summary>
        /// Applies a logical right shift to the source vector
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift offset</param>
        [MethodImpl(Inline)]
        public static BitVector64 srl(BitVector64 x, int offset)
            => math.srl(x.Scalar,offset);
 
        /// <summary>
        /// Computes z = x >> offset for a caller-supplied target bitvector z and source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The amount to shift rightwards</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector8 srl(in BitVector8 x, int offset, ref BitVector8 z)
        {
            z.assign(math.srl(x.Scalar, offset));
            return ref z;
        }

        /// <summary>
        /// Computes z = x >> offset for a caller-supplied target bitvector z and source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The amount to shift rightwards</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector16 srl(in BitVector16 x, int offset, ref BitVector16 z)
        {
            z.assign(math.srl(x.Scalar, offset));
            return ref z;
        }

        /// <summary>
        /// Computes z = x >> offset for a caller-supplied target bitvector z and source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The amount to shift rightwards</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector32 srl(in BitVector32 x, int offset, ref BitVector32 z)
        {
            z.assign(math.srl(x.Scalar, offset));
            return ref z;
        }

        /// <summary>
        /// Computes z = x >> offset for a caller-supplied target bitvector z and source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The amount to shift rightwards</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector64 srl(in BitVector64 x, int offset, ref BitVector64 z)
        {
            z.assign(math.srl(x.Scalar, offset));
            return ref z;
        }

        /// <summary>
        /// Computes a righwards shift in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The bit offset amount</param>
        [MethodImpl(Inline)]
        public static ref BitVector8 srl(ref BitVector8 x, int offset)
        {
            x.assign(math.srl(x.Scalar,offset));
            return ref x;
        }

        /// <summary>
        /// Computes a righwards shift in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The bit offset amount</param>
        [MethodImpl(Inline)]
        public static ref BitVector16 srl(ref BitVector16 x, int offset)
        {
            x.assign(math.srl(x.Scalar,offset));
            return ref x;
        }

        /// <summary>
        /// Computes a righwards shift in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The bit offset amount</param>
        [MethodImpl(Inline)]
        public static ref BitVector32 srl(ref BitVector32 x, int offset)
        {
            x.assign(math.srl(x.Scalar,offset));
            return ref x;
        }

        /// <summary>
        /// Computes a righwards shift in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The bit offset amount</param>
        [MethodImpl(Inline)]
        public static ref BitVector64 srl(ref BitVector64 x, int offset)
        {
            x.assign(math.srl(x.Scalar,offset));
            return ref x;
        }

    }

}