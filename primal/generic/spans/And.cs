//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {

        public static Span<T> and<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.and(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.and(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.and(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.and(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.and(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.and(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.and(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.and(uint64(lhs), uint64(rhs), uint64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> and<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => and(lhs,rhs, span<T>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static ref Span<T> and<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.and(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.and(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.and(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.and(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.and(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.and(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.and(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.and(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> and<T>(ref Span<T> lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.and(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.and(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.and(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.and(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.and(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.and(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.and(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.and(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }

    }


}