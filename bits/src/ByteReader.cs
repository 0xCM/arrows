//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public static class ByteReader
    {
        /// <summary>
        /// Copies the source to the target span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read1(byte src, Span<byte> dst, int offset)
            => dst[offset] = (byte)src;

        /// <summary>
        /// Copies the source to the target span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read1(sbyte src, Span<byte> dst, int offset)
            => dst[offset] = (byte)src;

        /// <summary>
        /// Reads the first byte from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read1(short src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,1, dst,offset);

        /// <summary>
        /// Reads all bytes from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read2(short src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,2, dst,offset);

        /// <summary>
        /// Reads the lo byte from the source and writes it to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read1(ushort src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,1, dst,offset);

        /// <summary>
        /// Reads all bytes from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read2(ushort src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,2, dst,offset);

        /// <summary>
        /// Reads the first byte from the source and writes it to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read1(int src, Span<byte> dst, int offset)        
            => BitConverter.GetBytes(src).CopyTo(0,1, dst,offset);

        /// <summary>
        /// Reads the first two bytes from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read2(int src, Span<byte> dst, int offset)        
            => BitConverter.GetBytes(src).CopyTo(0,2, dst,offset);

        /// <summary>
        /// Reads the first three bytes from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read3(int src, Span<byte> dst, int offset)        
            => BitConverter.GetBytes(src).CopyTo(0,3, dst,offset);

        /// <summary>
        /// Reads the first byte from the source and writes it to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read1(uint src, Span<byte> dst, int offset)        
            => BitConverter.GetBytes(src).CopyTo(0,1, dst,offset);

        /// <summary>
        /// Reads the lower 2 bytes  from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read2(uint src, Span<byte> dst, int offset)
            => BitConverter.GetBytes((ushort)src).CopyTo(0, 2, dst,offset);        

        /// <summary>
        /// Reads bytes 0 - 2 (inclusive) from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read3(uint src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,3, dst, offset);
        
        /// <summary>
        /// Reads all source bytes and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read4(uint src, Span<byte> dst, int offset)
            => BitConverter.GetBytes((uint)src).CopyTo(0,4,dst,offset);
        
        /// <summary>
        /// Reads the first byte from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read1(ulong src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,1,dst,offset);

        /// <summary>
        /// Reads the first two bytes from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read2(ulong src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,2,dst,offset);

        /// <summary>
        /// Reads the first three bytes from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read3(ulong src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,3,dst,offset);

        /// <summary>
        /// Reads the first four bytes from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read4(ulong src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,4,dst,offset);

        /// <summary>
        /// Reads the first 5 bytes from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read5(ulong src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,5,dst,offset);

        /// <summary>
        /// Reads the first 6 bytes from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read6(ulong src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,6,dst,offset);

        /// <summary>
        /// Reads the first seven bytes from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read7(ulong src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,7,dst,offset);

        /// <summary>
        /// Reads all source bytes and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read8(ulong src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,8,dst,offset);

        /// <summary>
        /// Reads the first byte from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read1(long src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,1,dst,offset);

        /// <summary>
        /// Reads the first two bytes from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read2(long src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,2,dst,offset);

        /// <summary>
        /// Reads the first three bytes from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read3(long src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,3,dst,offset);

        /// <summary>
        /// Reads the first four bytes from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read4(long src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,4,dst,offset);

        /// <summary>
        /// Reads the first 5 bytes from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read5(long src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,5,dst,offset);

        /// <summary>
        /// Reads the first 6 bytes from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read6(long src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,6,dst,offset);

        /// <summary>
        /// Reads the first seven bytes from the source and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read7(long src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,7,dst,offset);

        /// <summary>
        /// Reads all source bytes and writes the data to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void Read8(long src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,8,dst,offset);

        [MethodImpl(Inline)]
        static void CopyTo<T>(this T[] src, int srcOffset, int srcCount, Span<T> dst, int dstOffset)        
            => src.AsSpan().Slice(srcOffset, srcCount).CopyTo(dst, dstOffset);

    }


}