//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    
    
    using static zfunc;
    using static mfunc;

    public static class BytesX
    {
        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static Span<byte> ToBytes<T>(this T src)
            where T : struct
                => Bytes.bytes(in src);

        [MethodImpl(Inline)]   
        public static Span<byte> ToBytes<T>(this Span<T> src)
            where T : struct
            => MemoryMarshal.AsBytes(src);

        [MethodImpl(Inline)]   
        public static ReadOnlySpan<byte> ToBytes<T>(this ReadOnlySpan<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src);

        [MethodImpl(Inline)]   
        public static ref T FromBytes<T>(this Span<byte> src, out T dst, int offset = 0)
            where T : struct
        {
            dst = Bytes.read<T>(src, offset);
            return ref dst;
        }
                
        /// <summary>
        /// Converts a bit to a byte
        /// </summary>
        /// <param name="src">The source value to convert</param>
        [MethodImpl(Inline)]   
        public static byte ToByte(this Bit src)
            => src ? (byte)1 : (byte)0;

        [MethodImpl(Inline)]   
        public static ulong PopCount(this Span<byte> src)
            => Bytes.pop(src);

    }

}