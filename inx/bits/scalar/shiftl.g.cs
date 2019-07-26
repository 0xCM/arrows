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

    partial class gbits
    {

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static T shiftl<T>(T src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(src) << offset));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(src) << offset));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(src) << offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(src) << offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src) << offset);
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src) << offset);
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src) << offset);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src) << offset);
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static T shiftl<T>(T src, T offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(src) << (int)int8(offset)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(src) << (int)uint8(offset)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(src) << (int)int16(offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(src) << (int)uint16(offset)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src) << (int)int32(offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src) << (int)uint32(offset));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src) << (int)int64(offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src) << (int)uint64(offset));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref T shiftl<T>(ref T lhs, int rhs)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                math.shiftl(ref int8(ref lhs), rhs);
            else if (typeof(T) == typeof(byte))
                math.shiftl(ref uint8(ref lhs), rhs);
            else if (typeof(T) == typeof(short))
                math.shiftl(ref int16(ref lhs), rhs);
            else if (typeof(T) == typeof(ushort))
                math.shiftl(ref uint16(ref lhs), rhs);
            else if (typeof(T) == typeof(int))
                math.shiftl(ref int32(ref lhs), rhs);
            else if (typeof(T) == typeof(uint))
                math.shiftl(ref uint32(ref lhs), rhs);
            else if (typeof(T) == typeof(long))
                math.shiftl(ref int64(ref lhs), rhs);
            else if (typeof(T) == typeof(ulong))
                math.shiftl(ref uint64(ref lhs), rhs);
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static T shiftl<T>(in T lhs, in uint rhs)
            where T : struct
                => shiftl(lhs, (int)rhs);

        [MethodImpl(Inline)]
        public static T shiftl<T>(in T lhs, in ulong rhs)
            where T : struct
                => shiftl(lhs, (int)rhs);


         [MethodImpl(Inline)]
        public static Span<T> shiftl<T>(ReadOnlySpan<T> src, ReadOnlySpan<int> offsets, Span<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                math.shiftl(int8(src), offsets, int8(dst));
            else if (typeof(T) == typeof(byte))
                math.shiftl(uint8(src), offsets, uint8(dst));
            else if (typeof(T) == typeof(short))
                math.shiftl(int16(src), offsets, int16(dst));
            else if (typeof(T) == typeof(ushort))
                math.shiftl(uint16(src), offsets, uint16(dst));
            else if (typeof(T) == typeof(int))
                math.shiftl(int32(src), offsets, int32(dst));
            else if (typeof(T) == typeof(uint))
                math.shiftl(uint32(src), offsets, uint32(dst));
            else if (typeof(T) == typeof(long))
                math.shiftl(int64(src), offsets, int64(dst));
            else if (typeof(T) == typeof(ulong))
                math.shiftl(uint64(src), offsets, uint64(dst));
            else
                throw unsupported<T>();
            return dst;

        }

        [MethodImpl(Inline)]
        public static Span<T> shiftl<T>(ReadOnlySpan<T> src, int offset, Span<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                math.shiftl(int8(src), offset, int8(dst));
            else if (typeof(T) == typeof(byte))
                math.shiftl(uint8(src), offset, uint8(dst));
            else if (typeof(T) == typeof(short))
                math.shiftl(int16(src), offset, int16(dst));
            else if (typeof(T) == typeof(ushort))
                math.shiftl(uint16(src), offset, uint16(dst));
            else if (typeof(T) == typeof(int))
                math.shiftl(int32(src), offset, int32(dst));
            else if (typeof(T) == typeof(uint))
                math.shiftl(uint32(src), offset, uint32(dst));
            else if (typeof(T) == typeof(long))
                math.shiftl(int64(src), offset, int64(dst));
            else if (typeof(T) == typeof(ulong))
                math.shiftl(uint64(src), offset, uint64(dst));
            else
                throw unsupported<T>();
            return dst;

        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static Span<T> shiftl<T>(ReadOnlySpan<T> src, int offset)
            where T : struct
            => shiftl(src, offset, span<T>(src.Length));

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref Span<T> shiftl<T>(ref Span<T> src, int offset)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                math.shiftl(int8(src), offset);
            else if (typeof(T) == typeof(byte))
                math.shiftl(uint8(src), offset);
            else if (typeof(T) == typeof(short))
                math.shiftl(int16(src), offset);
            else if (typeof(T) == typeof(ushort))
                math.shiftl(uint16(src), offset);
            else if (typeof(T) == typeof(int))
                math.shiftl(int32(src), offset);
            else if (typeof(T) == typeof(uint))
                math.shiftl(uint32(src), offset);
            else if (typeof(T) == typeof(long))
                math.shiftl(int64(src), offset);
            else if (typeof(T) == typeof(ulong))
                math.shiftl(uint64(src), offset);
            else
                throw unsupported<T>();
            return ref src;

        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref Span<T> shiftl<T>(ref Span<T> src, Span<int> offsets)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                math.shiftl(int8(src), offsets);
            else if (typeof(T) == typeof(byte))
                math.shiftl(uint8(src), offsets);
            else if (typeof(T) == typeof(short))
                math.shiftl(int16(src), offsets);
            else if (typeof(T) == typeof(ushort))
                math.shiftl(uint16(src), offsets);
            else if (typeof(T) == typeof(int))
                math.shiftl(int32(src), offsets);
            else if (typeof(T) == typeof(uint))
                math.shiftl(uint32(src), offsets);
            else if (typeof(T) == typeof(long))
                math.shiftl(int64(src), offsets);
            else if (typeof(T) == typeof(ulong))
                math.shiftl(uint64(src), offsets);
            else
                throw unsupported<T>();
            return ref src;
        }
   }
}