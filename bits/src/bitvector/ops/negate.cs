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
        /// Computes the two's complement bitvector -x from the source bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 negate(BitVector8 x)
            => math.negate(x.Scalar);
            
        /// <summary>
        /// Computes the two's complement bitvector -x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 negate(BitVector16 x)
            => math.negate(x.Scalar);

        /// <summary>
        /// Computes the two's complement bitvector -x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 negate(BitVector32 x)
            => math.negate(x.Scalar);

        /// <summary>
        /// Computes the two's complement bitvector -x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 negate(BitVector64 x)
            => math.negate(x.Scalar);
 
        /// <summary>
        /// Computes the two's complement bitvector z = -x from the source bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector8 negate(in BitVector8 x, ref BitVector8 z)
        {
            z = negate(x);
            return ref z;
        }

        /// <summary>
        /// Computes the two's complement bitvector z = -x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector16 negate(in BitVector16 x, ref BitVector16 z)
        {
            z = negate(x);
            return ref z;
        }

        /// <summary>
        /// Computes the two's complement bitvector z = -x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector32 negate(in BitVector32 x, ref BitVector32 z)
        {
            z = negate(x);
            return ref z;
        }

        /// <summary>
        /// Computes the two's complement bitvector z = -x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector64 negate(in BitVector64 x, ref BitVector64 z)
        {
            z = negate(x);
            return ref z;
        }

        /// <summary>
        /// Computes the two's complement bitvector in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector8 negate(ref BitVector8 x)
        {
            x = negate(x);
            return ref x;
        }

        /// <summary>
        /// Computes the two's complement bitvector in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector16 negate(ref BitVector16 x)
        {
            x = negate(x);
            return ref x;
        }

        /// <summary>
        /// Computes the two's complement bitvector in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector32 negate(ref BitVector32 x)
        {
            x = negate(x);
            return ref x;
        }

        /// <summary>
        /// Computes the two's complement bitvector in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector64 negate(ref BitVector64 x)
        {
            x = negate(x);
            return ref x;
        }


    }

}