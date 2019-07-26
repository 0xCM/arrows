//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    public static partial class gbits
    {

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static T shiftr<T>(T src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(src) >> offset));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(src) >> offset));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(src) >> offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(src) >> offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src) >> offset);
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src) >> offset);
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src) >> offset);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src) >> offset);
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static T shiftr<T>(T src, T offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(src) >> (int)int8(offset)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(src) >> (int)uint8(offset)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(src) >> (int)int16(offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(src) >> (int)uint16(offset)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src) >> (int)int32(offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src) >> (int)uint32(offset));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src) >> (int)int64(offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src) >> (int)uint64(offset));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T shiftr<T>(ref T src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(ref int8(ref src), offset);
            else if(typeof(T) == typeof(byte))
                math.shiftr(ref uint8(ref src), offset);
            else if(typeof(T) == typeof(short))
                math.shiftr(ref int16(ref src), offset);
            else if(typeof(T) == typeof(ushort))
                math.shiftr(ref uint16(ref src), offset);
            else if(typeof(T) == typeof(int))
                math.shiftr(ref int32(ref src), offset);
            else if(typeof(T) == typeof(uint))
                math.shiftr(ref uint32(ref src), offset);
            else if(typeof(T) == typeof(long))
                math.shiftr(ref int64(ref src), offset);
            else if(typeof(T) == typeof(ulong))
                math.shiftr(ref uint64(ref src), offset);
            else
                throw unsupported<T>();
            return ref src;
        }           

        public static Span<T> shiftr<T>(ReadOnlySpan<T> src, ReadOnlySpan<int> offsets, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(int8(src), offsets, int8(dst));
            else if(typeof(T) == typeof(byte))
                math.shiftr(uint8(src), offsets, uint8(dst));
            else if(typeof(T) == typeof(short))
                math.shiftr(int16(src), offsets, int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.shiftr(uint16(src), offsets, uint16(dst));
            else if(typeof(T) == typeof(int))
                math.shiftr(int32(src), offsets, int32(dst));
            else if(typeof(T) == typeof(uint))
                math.shiftr(uint32(src), offsets, uint32(dst));
            else if(typeof(T) == typeof(long))
                math.shiftr(int64(src), offsets, int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.shiftr(uint64(src), offsets, uint64(dst));
            else
                throw unsupported<T>();
            return dst;

        }

        public static Span<T> shiftr<T>(ReadOnlySpan<T> src, int offset, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(int8(src), offset, int8(dst));
            else if(typeof(T) == typeof(byte))
                math.shiftr(uint8(src), offset, uint8(dst));
            else if(typeof(T) == typeof(short))
                math.shiftr(int16(src), offset, int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.shiftr(uint16(src), offset, uint16(dst));
            else if(typeof(T) == typeof(int))
                math.shiftr(int32(src), offset, int32(dst));
            else if(typeof(T) == typeof(uint))
                math.shiftr(uint32(src), offset, uint32(dst));
            else if(typeof(T) == typeof(long))
                math.shiftr(int64(src), offset, int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.shiftr(uint64(src), offset, uint64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        public static Span<T> shiftr<T>(ReadOnlySpan<T> src, int offset)
            where T : struct
            => shiftr(src, offset, span<T>(src.Length));
 
        [MethodImpl(Inline)]
        public static ref Span<T> shiftr<T>(ref Span<T> src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(int8(src), offset);
            else if(typeof(T) == typeof(byte))
                math.shiftr(uint8(src), offset);
            else if(typeof(T) == typeof(short))
                math.shiftr(int16(src), offset);
            else if(typeof(T) == typeof(ushort))
                math.shiftr(uint16(src), offset);
            else if(typeof(T) == typeof(int))
                math.shiftr(int32(src), offset);
            else if(typeof(T) == typeof(uint))
                math.shiftr(uint32(src), offset);
            else if(typeof(T) == typeof(long))
                math.shiftr(int64(src), offset);
            else if(typeof(T) == typeof(ulong))
                math.shiftr(uint64(src), offset);
            else
                throw unsupported<T>();
            return ref src;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref Span<T> shiftr<T>(ref Span<T> src, Span<int> offsets)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(int8(src), offsets);
            else if(typeof(T) == typeof(byte))
                math.shiftr(uint8(src), offsets);
            else if(typeof(T) == typeof(short))
                math.shiftr(int16(src), offsets);
            else if(typeof(T) == typeof(ushort))
                math.shiftr(uint16(src), offsets);
            else if(typeof(T) == typeof(int))
                math.shiftr(int32(src), offsets);
            else if(typeof(T) == typeof(uint))
                math.shiftr(uint32(src), offsets);
            else if(typeof(T) == typeof(long))
                math.shiftr(int64(src), offsets);
            else if(typeof(T) == typeof(ulong))
                math.shiftr(uint64(src), offsets);
            else
                throw unsupported<T>();
            return ref src;
        }

    }

}