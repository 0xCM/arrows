//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    
    partial class Bits
    {                
        /// <summary>
        /// Rotates bits in the source leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static byte rotl(byte src, byte offset)
            => (byte)((src << offset) | (src >> (8 - offset)));

        /// <summary>
        /// Rotates bits in the source leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static ushort rotl(ushort src, ushort offset)
            => (ushort)((src << offset) | (src >> (16 - offset)));

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
    
        /// <summary>
        /// Rotates source bits leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static ref byte rotl(ref byte src, in byte offset)
        {
            src = rotl(src,offset);
            return ref src;
        }

        /// <summary>
        /// Rotates source bits leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static ref ushort rotl(ref ushort src, in ushort offset)
        {
            src = rotl(src,offset);
            return ref src;
        }

        /// <summary>
        /// Rotates source bits leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static ref uint rotl(ref uint src, in uint offset)
        {
            src = rotl(src,offset);
            return ref src;
        }

        /// <summary>
        /// Rotates source bits leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static ref ulong rotl(ref ulong src, in ulong offset)
        {
            src = rotl(src,offset);
            return ref src;
        }    


    }
}