//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    static class Bits
    {

        /// <summary>
        /// Computes the XOR of the source value and the result of left-shifting 
        /// the source by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static ulong xorsl(ulong src, int offset)
            => src^(src << offset);

        /// <summary>
        /// Computes the XOR of the source value and the result of right-shifting 
        /// the source by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift the source value rightwards</param>
        [MethodImpl(Inline)]
        public static uint xorsr(uint src, int offset)
            => src^(src >> offset);

        /// <summary>
        /// Computes the XOR of the source value and the result of left-shifting 
        /// the source by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static uint xorsl(uint src, int offset)
            => src^(src << offset);

        /// <summary>
        /// Computes the XOR of the source value and the result of right-shifting 
        /// the source by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift the source value rightwards</param>
        [MethodImpl(Inline)]
        public static ulong xorsr(ulong src, int offset)
            => src^(src >> offset);

        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static uint rotr(uint src, uint offset)
            => (src >> (int)offset) | (src << (32 - (int)offset));

        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static ulong rotr(ulong src, ulong offset)
            => (src >> (int)offset) | (src << (64 - (int)offset));


        /// <summary>
        /// Rotates bits in the source leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static uint rotl(uint src, uint offset)
            => (src << (int)offset) | (src >> (32 - (int)offset));

        /// <summary>
        /// Rotates bits in the source leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static ulong rotl(ulong src, ulong offset)
            => (src << (int)offset) | (src >> (64 - (int)offset));

    }

}
