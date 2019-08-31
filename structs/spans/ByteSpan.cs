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

    public static class ByteSpan
    {
        /// <summary>
        /// Reimagines a 256-bit bloocked span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<byte> From<T>(Span256<T> src)
            where T : struct
                => Span256.Load(MemoryMarshal.AsBytes(src.Unblocked));

        /// <summary>
        /// Reimagines a 256-bit bloocked span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<byte> From<T>(Span128<T> src)
            where T : struct
                => Span128.Load(MemoryMarshal.AsBytes(src.Unblock()));
        
        
        [MethodImpl(Inline)]
        public static Span<byte> FromValue<T>(T src)
            where T : struct
        {
            Span<T> s = new T[1]{src};
            return MemoryMarshal.AsBytes(s);
        }        

        [MethodImpl(Inline)]
        public static T ReadValue<T>(ReadOnlySpan<byte> src, int offset = 0)
            where T : struct
        {
            if(MemoryMarshal.TryRead(src.Slice(offset), out T value))                
                return value;
            else 
                throw new Exception();
        }

        [MethodImpl(Inline)]
        public static T ReadValue<T>(Span<byte> src, int offset)
            where T : struct
                => ReadValue<T>(src.ReadOnly(),offset);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadValues<T>(ReadOnlySpan<byte> src, int offset, int count)
            where T : struct
                => MemoryMarshal.Cast<byte,T>(src.Slice(offset, count * Unsafe.SizeOf<T>()));

        [MethodImpl(Inline)]
        public static Span<T> ReadValues<T>(Span<byte> src, int offset, int count)
            where T : struct
                => MemoryMarshal.Cast<byte,T>(src.Slice(offset, count * Unsafe.SizeOf<T>()));
        
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadValues<T>(ReadOnlySpan<byte> src)
            where T : struct
                => ReadValues<T>(src, 0, src.Length/Unsafe.SizeOf<T>());

        /// <summary>
        /// Reads a readonly span of bytes from a span of value types
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of source elements to skip from the head</param>
        /// <param name="length">Tne number of source elements to read</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> ReadBytes<T>(ReadOnlySpan<T> src, int? offset = null, int? length = null)
            where T : struct
        {
            if(offset == null && length == null)
                return MemoryMarshal.AsBytes(src);
            else if(offset != null && length == null)
                return MemoryMarshal.AsBytes(src.Slice(offset.Value));
            else
                return MemoryMarshal.AsBytes(src.Slice(offset.Value,length.Value));
        }

        [MethodImpl(Inline)]
        public static Span<T> ReadValues<T>(Span<byte> src)
            where T : struct        
                => ByteSpan.ReadValues<T>(src, 0, src.Length/Unsafe.SizeOf<T>());

        public static Span<T> ReadValues<T>(Span<byte> src, out Span<byte> rem)
            where T : struct        
        {
            rem = Span<byte>.Empty;
            var tSize = Unsafe.SizeOf<T>();
            var dst = ByteSpan.ReadValues<T>(src);
            var q = Math.DivRem(dst.Length, tSize, out int r);
            if(r != 0)
                rem = src.Slice(dst.Length*tSize);
            return dst;
        }



    }

}