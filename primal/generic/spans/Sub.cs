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
        public static Span<T> sub<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T :  struct
        {
            if(typeof(T) == typeof(sbyte))
                math.sub(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.sub(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.sub(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.sub(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.sub(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.sub(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.sub(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.sub(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                math.sub(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                math.sub(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> sub<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.sub(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.sub(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.sub(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.sub(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.sub(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.sub(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.sub(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.sub(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                math.sub(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                math.sub(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static Span<T> sub<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T :  struct
                => sub(lhs,rhs, span<T>(length(lhs,rhs)));


    }

}