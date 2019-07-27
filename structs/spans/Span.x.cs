//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    public static class SpanExtensions
    {
        /// <summary>
        /// Presents selected span content as a readonly span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The source offset</param>
        /// <param name="length">The source length</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> AsBytes<T>(this ReadOnlySpan<T> src, int offset = 0, int ? length = null)
            where T : struct
            =>   (offset == 0 && length == null) 
                ? MemoryMarshal.AsBytes(src)
                : length == null  
                ? MemoryMarshal.AsBytes(src.Slice(offset)) 
                : MemoryMarshal.AsBytes(src.Slice(offset, length.Value));

        /// <summary>
        /// Presents selected span content as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The source offset</param>
        /// <param name="length">The source length</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> AsBytes<T>(this Span<T> src, int offset = 0, int ? length = null)
            where T : struct
            =>   (offset == 0 && length == null) 
                ? MemoryMarshal.AsBytes(src)
                : length == null  
                ? MemoryMarshal.AsBytes(src.Slice(offset)) 
                : MemoryMarshal.AsBytes(src.Slice(offset, length.Value));

    }

}