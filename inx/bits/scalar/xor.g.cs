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
    using static As;
    using static AsIn;

    partial class gbits
    {
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Span<T> xor<T>(in ReadOnlySpan<T> lhs, in ReadOnlySpan<T> rhs, in Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.xor(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.xor(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.xor(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.xor(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.xor(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.xor(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.xor(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.xor(uint64(lhs), uint64(rhs), uint64(dst));
            else
                throw unsupported<T>();
            return ref dst;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static Span<T> xor<T>(in ReadOnlySpan<T> lhs, in ReadOnlySpan<T> rhs)
            where T : struct
                => xor(in lhs,in rhs, span<T>(length(lhs,rhs)));
        

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Span<T> xor<T>(in Span<T> lhs, in ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.xor(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.xor(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.xor(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.xor(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.xor(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.xor(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.xor(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.xor(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Span<T> xor<T>(in Span<T> lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.xor(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.xor(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.xor(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.xor(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.xor(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.xor(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.xor(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.xor(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }
    }
}