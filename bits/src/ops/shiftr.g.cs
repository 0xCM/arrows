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
    using static AsInX;

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
                Bits.shiftr(ref int8(ref src), offset);
            else if(typeof(T) == typeof(byte))
                Bits.shiftr(ref uint8(ref src), offset);
            else if(typeof(T) == typeof(short))
                Bits.shiftr(ref int16(ref src), offset);
            else if(typeof(T) == typeof(ushort))
                Bits.shiftr(ref uint16(ref src), offset);
            else if(typeof(T) == typeof(int))
                Bits.shiftr(ref int32(ref src), offset);
            else if(typeof(T) == typeof(uint))
                Bits.shiftr(ref uint32(ref src), offset);
            else if(typeof(T) == typeof(long))
                Bits.shiftr(ref int64(ref src), offset);
            else if(typeof(T) == typeof(ulong))
                Bits.shiftr(ref uint64(ref src), offset);
            else
                throw unsupported<T>();
            return ref src;
        }           

        [MethodImpl(Inline)]
        public static Vec128<S> shiftr<S,T>(in Vec128<S> lhs, in Vec128<T> shifts)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                return generic<S>(Bits.shiftr(in int32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(uint)) 
                return generic<S>(Bits.shiftr(in uint32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(long))
                return generic<S>(Bits.shiftr(in int64(lhs), in uint64(in shifts)));
            else if(typeof(S) == typeof(ulong))
                return generic<S>(Bits.shiftr(in uint64(lhs), in uint64(in shifts)));
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static Vec256<S> shiftr<S,T>(in Vec256<S> lhs, in Vec256<T> shifts)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                return generic<S>(Bits.shiftr(in int32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(uint)) 
                return generic<S>(Bits.shiftr(in uint32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(long))
                return generic<S>(Bits.shiftr(in int64(lhs), in uint64(in shifts)));
            else if(typeof(S) == typeof(ulong))
                return generic<S>(Bits.shiftr(in uint64(lhs), in uint64(in shifts)));
            else
                throw unsupported<S>();
        }

        public static Span<T> shiftr<T>(ReadOnlySpan<T> src, ReadOnlySpan<int> offsets, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(src).ShiftR(offsets, int8(dst));
            else if(typeof(T) == typeof(byte))
                uint8(src).ShiftR(offsets, uint8(dst));
            else if(typeof(T) == typeof(short))
                int16(src).ShiftR(offsets, int16(dst));
            else if(typeof(T) == typeof(ushort))
                uint16(src).ShiftR(offsets, uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(src).ShiftR(offsets, int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(src).ShiftR(offsets, uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(src).ShiftR(offsets, int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(src).ShiftR(offsets, uint64(dst));
            else
                throw unsupported<T>();
            return dst;

        }

        public static Span<T> shiftr<T>(ReadOnlySpan<T> src, int offset, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(src).ShiftR(offset, int8(dst));
            else if(typeof(T) == typeof(byte))
                uint8(src).ShiftR(offset, uint8(dst));
            else if(typeof(T) == typeof(short))
                int16(src).ShiftR(offset, int16(dst));
            else if(typeof(T) == typeof(ushort))
                uint16(src).ShiftR(offset, uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(src).ShiftR(offset, int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(src).ShiftR(offset, uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(src).ShiftR(offset, int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(src).ShiftR(offset, uint64(dst));
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
                int8(src).ShiftR(offset);
            else if(typeof(T) == typeof(byte))
                uint8(src).ShiftR(offset);
            else if(typeof(T) == typeof(short))
                int16(src).ShiftR(offset);
            else if(typeof(T) == typeof(ushort))
                uint16(src).ShiftR(offset);
            else if(typeof(T) == typeof(int))
                int32(src).ShiftR(offset);
            else if(typeof(T) == typeof(uint))
                uint32(src).ShiftR(offset);
            else if(typeof(T) == typeof(long))
                int64(src).ShiftR(offset);
            else if(typeof(T) == typeof(ulong))
                uint64(src).ShiftR(offset);
            else
                throw unsupported<T>();
            return ref src;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref Span<T> shiftr<T>(ref Span<T> src, Span<int> offsets)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(src).ShiftR(offsets);
            else if(typeof(T) == typeof(byte))
                uint8(src).ShiftR(offsets);
            else if(typeof(T) == typeof(short))
                int16(src).ShiftR(offsets);
            else if(typeof(T) == typeof(ushort))
                uint16(src).ShiftR(offsets);
            else if(typeof(T) == typeof(int))
                int32(src).ShiftR(offsets);
            else if(typeof(T) == typeof(uint))
                uint32(src).ShiftR(offsets);
            else if(typeof(T) == typeof(long))
                int64(src).ShiftR(offsets);
            else if(typeof(T) == typeof(ulong))
                uint64(src).ShiftR(offsets);
            else
                throw unsupported<T>();
            return ref src;
        }

    }

}