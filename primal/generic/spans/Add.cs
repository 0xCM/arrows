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
        public static Span<T> add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.add(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.add(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.add(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.add(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.add(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.add(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.add(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.add(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                math.add(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                math.add(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => add(lhs,rhs, span<T>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static ref Span<T> add<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.add(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.add(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.add(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.add(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.add(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.add(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.add(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.add(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                math.add(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                math.add(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> add<T>(ref Span<T> lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.add(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.add(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.add(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.add(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.add(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.add(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.add(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.add(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                math.add(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                math.add(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }



    }

}