//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;
 
    using static zfunc;
    
    partial class Bits
    {                
        /// <summary>
        /// Creates a mask for specified powers of two
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exponents">The exponent values, each of which should be within the integral range [0,63] </param>
        public static ref ulong mask(ref ulong dst, params int[] exponents)
        {
            for(var i=0; i<exponents.Length; i++)
                dst |= Pow2.pow(exponents[i]);
            return ref dst;
        }

        /// <summary>
        /// Computes floor(log(src,2))
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte log2(byte src)
            => (byte)BitOperations.Log2(src);

        /// <summary>
        /// Computes floor(log(src,2))
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort log2(ushort src)
            => (ushort)BitOperations.Log2(src);

        /// <summary>
        /// Computes floor(log(src,2))
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint log2(uint src)
            => (uint)BitOperations.Log2(src);

        /// <summary>
        /// Computes floor(log(src,2))
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ulong log2(ulong src)
            => (ulong)BitOperations.Log2(src);
    }

}