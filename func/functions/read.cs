//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
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
        public static T ReadPrimalValue<T>(this ReadOnlySpan<byte> src, int offset = 0)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(src.ReadInt8(offset));
            else if(typeof(T) == typeof(byte))
                return generic<T>(src.ReadUInt8(offset));
            else if(typeof(T) == typeof(short))
                return generic<T>(src.ReadInt16(offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(src.ReadUInt16(offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(src.ReadInt32(offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(src.ReadUInt32(offset));
            else if(typeof(T) == typeof(long))
                return generic<T>(src.ReadInt64(offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(src.ReadUInt64(offset));
            else if(typeof(T) == typeof(float))
                return generic<T>(src.ReadFloat32(offset));
            else if(typeof(T) == typeof(double))
                return generic<T>(src.ReadFloat64(offset));
            else
                throw unsupported<T>();
            
        }

        [MethodImpl(Inline)]
        public static T ReadPrimalValue<T>(this Span<byte> src, int offset = 0)
            where T : struct
                => src.ReadOnly().ReadPrimalValue<T>(offset);


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

        [MethodImpl(Inline)]
        public static Span<byte> ToBytes<T>(this T src)
            where T : struct
        {
            Span<T> s = new T[1]{src};
            return MemoryMarshal.AsBytes(s);
        }        

        [MethodImpl(Inline)]
        public static T FromBytes<T>(this Span<byte> src)
            where T : struct
        {
            if(MemoryMarshal.TryRead(src, out T value))
                return value;
            else
                throw unsupported<T>();
        }

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

        [MethodImpl(Inline)]
        static sbyte ReadInt8(this ReadOnlySpan<byte> src, int offset)
            => (sbyte)src[offset];    

        [MethodImpl(Inline)]
        static byte ReadUInt8(this ReadOnlySpan<byte> src, int offset)
            => src[offset];    

        [MethodImpl(Inline)]
        static short ReadInt16(this ReadOnlySpan<byte> src, int offset)
            => BitConverter.ToInt16(src.Slice(offset, 2));

        [MethodImpl(Inline)]
        static ushort ReadUInt16(this ReadOnlySpan<byte> src, int offset)
            => BitConverter.ToUInt16(src.Slice(offset, 2));        

        [MethodImpl(Inline)]
        static int ReadInt32(this ReadOnlySpan<byte> src, int offset)
            => BitConverter.ToInt32(src.Slice(offset, 4));

        [MethodImpl(Inline)]
        static uint ReadUInt32(this ReadOnlySpan<byte> src, int offset)
            => BitConverter.ToUInt32(src.Slice(offset, 4));

        [MethodImpl(Inline)]
        static ulong ReadUInt64(this ReadOnlySpan<byte> src, int offset)
            => BitConverter.ToUInt64(src.Slice(offset, 8));

        [MethodImpl(Inline)]
        static long ReadInt64(this ReadOnlySpan<byte> src, int offset)
            => BitConverter.ToInt64(src.Slice(offset, 8));

        [MethodImpl(Inline)]
        static float ReadFloat32(this ReadOnlySpan<byte> src, int offset)
            => BitConverter.ToSingle(src.Slice(offset, 4));

        [MethodImpl(Inline)]
        static double ReadFloat64(this ReadOnlySpan<byte> src, int offset)
            => BitConverter.ToDouble(src.Slice(offset, 8));

    }

}