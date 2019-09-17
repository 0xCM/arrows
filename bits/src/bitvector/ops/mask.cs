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
        /// Creates a permutation-defined bitvector mask 
        /// </summary>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public static ref BitVector8 mask(Perm spec, out BitVector8 mask)
        {
            mask = BitVector8.Mask(spec);
            return ref mask;
        }

        /// <summary>
        /// Creates a permutation-defined bitvector mask 
        /// </summary>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public static ref BitVector16 mask(Perm spec, out BitVector16 mask)
        {
            mask = BitVector16.Mask(spec);
            return ref mask;
        }

        /// <summary>
        /// Creates a permutation-defined bitvector mask 
        /// </summary>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public static ref BitVector32 mask(Perm spec, out BitVector32 mask)
        {
            mask = BitVector32.Mask(spec);
            return ref mask;
        }

        /// <summary>
        /// Creates a permutation-defined bitvector mask 
        /// </summary>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public static ref BitVector64 mask(Perm spec, out BitVector64 mask)
        {
            mask = BitVector64.Mask(spec);
            return ref mask;
        }
        
    }

}