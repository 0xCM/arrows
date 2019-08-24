//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    
    
    partial class Bits
    {                
        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static byte rotr(byte src, byte offset)
            => (byte)((src >> offset) | (src << (8 - offset)));

        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static ushort rotr(ushort src, ushort offset)
            => (ushort)((src  >> offset) | (src << (16 - offset)));

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

        [MethodImpl(Inline)]
        public static ref byte rotr(ref byte src, in byte offset)
        {
            src = rotr(src,offset);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort rotr(ref ushort src, in ushort offset)
        {
            src = rotr(src,offset);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint rotr(ref uint src, in uint offset)
        {
            src = rotr(src,offset);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong rotr(ref ulong src, in ulong offset)
        {
            src = rotr(src,offset);
            return ref src;
        }

    }

}