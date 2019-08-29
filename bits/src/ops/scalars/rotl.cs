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

        public static Span<byte> rotl(ReadOnlySpan<byte> src, byte offset, Span<byte> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = rotl(src[i], offset);                            
            return dst;
        }

        public static Span<ushort> rotl(ReadOnlySpan<ushort> src, ushort offset, Span<ushort> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = rotl(src[i], offset);                            
            return dst;
        }

        public static Span<uint> rotl(ReadOnlySpan<uint> src, uint offset, Span<uint> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = rotl(src[i], offset);                            
            return dst;
        }

        public static Span<ulong> rotl(ReadOnlySpan<ulong> src, ulong offset, Span<ulong> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = rotl(src[i], offset);                            
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<byte> rotl(ReadOnlySpan<byte> src, byte offset)
            => rotl(src,offset,src.Replicate(true));

        [MethodImpl(Inline)]
        public static Span<ushort>  rotl(ReadOnlySpan<ushort> src, ushort offset)
            => rotl(src,offset,src.Replicate(true));

        [MethodImpl(Inline)]
        public static Span<uint>  rotl(ReadOnlySpan<uint> src, uint offset)
            => rotl(src,offset,src.Replicate(true));

        [MethodImpl(Inline)]
        public static Span<ulong>  rotl(ReadOnlySpan<ulong> src, ulong offset)
            => rotl(src,offset,src.Replicate(true));
    }
}