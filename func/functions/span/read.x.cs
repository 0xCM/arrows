//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;
    using static As;

    partial class xfunc
    {
       [MethodImpl(Inline)]
        public static T ReadValue<T>(this ReadOnlySpan<byte> src, int offset = 0)
            where T : struct
        {
            if(MemoryMarshal.TryRead(src.Slice(offset), out T value))                
                return value;
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T ReadValue<T>(this Span<byte> src, int offset = 0)
            where T : struct
                => src.ReadOnly().ReadValue<T>(offset);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadValues<T>(this ReadOnlySpan<byte> src, int offset, int count)
            where T : struct
                => MemoryMarshal.Cast<byte,T>(src.Slice(offset, count * Unsafe.SizeOf<T>()));

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadValues<T>(this Span<byte> src, int offset, int count)
            where T : struct
                => src.ReadOnly().ReadValues<T>(offset,count);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadValues<T>(this ReadOnlySpan<byte> src)
            where T : struct
                => src.ReadValues<T>(0, src.Length/Unsafe.SizeOf<T>());

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadValues<T>(this Span<byte> src)
            where T : struct        
                => src.ReadOnly().ReadValues<T>();

        /// <summary>
        /// Reads a readonly span of bytes from a span of value types
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of source elements to skip from the head</param>
        /// <param name="length">Tne number of source elements to read</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> ReadBytes<T>(this ReadOnlySpan<T> src, int? offset = null, int? length = null)
            where T : struct
        {
            if(offset == null && length == null)
                return MemoryMarshal.AsBytes(src);
            else if(offset != null && length == null)
                return MemoryMarshal.AsBytes(src.Slice(offset.Value));
            else
                return MemoryMarshal.AsBytes(src.Slice(offset.Value,length.Value));
        }
                
        /// <summary>
        /// Reads a span of bytes from a span of value types
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of source elements to skip from the head</param>
        /// <param name="length">Tne number of source elements to read</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> ReadBytes<T>(this Span<T> src, int? offset = null, int? length = null)
            where T : struct
        {
            if(offset == null && length == null)
                return MemoryMarshal.AsBytes(src);
            else if(offset != null && length == null)
                return MemoryMarshal.AsBytes(src.Slice(offset.Value));
            else
                return MemoryMarshal.AsBytes(src.Slice(offset.Value,length.Value));
        }


    }

}