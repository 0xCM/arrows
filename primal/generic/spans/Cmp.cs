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

        public static Span<bool> eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.eq(int8(lhs), int8(rhs), dst);
            else if(typeof(T) == typeof(byte))
                return math.eq(uint8(lhs), uint8(rhs), dst);
            else if(typeof(T) == typeof(short))
                return math.eq(int16(lhs), int16(rhs), dst);
            else if(typeof(T) == typeof(ushort))
                return math.eq(uint16(lhs), uint16(rhs), dst);
            else if(typeof(T) == typeof(int))
                return math.eq(int32(lhs), int32(rhs), dst);
            else if(typeof(T) == typeof(uint))
                return math.eq(uint32(lhs), uint32(rhs), dst);
            else if(typeof(T) == typeof(long))
                return math.eq(int64(lhs), int64(rhs), dst);
            else if(typeof(T) == typeof(ulong))
                return math.eq(uint64(lhs), uint64(rhs), dst);
            else if(typeof(T) == typeof(float))
                return math.eq(float32(lhs), float32(rhs), dst);
            else if(typeof(T) == typeof(double))
                return math.eq(float64(lhs), float64(rhs), dst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Span<bool> eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => eq(lhs,rhs,span<bool>(length(lhs,rhs)));


        public static Span<bool> lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.lt(int8(lhs), int8(rhs), dst);
            else if(typeof(T) == typeof(byte))
                return math.lt(uint8(lhs), uint8(rhs), dst);
            else if(typeof(T) == typeof(short))
                return math.lt(int16(lhs), int16(rhs), dst);
            else if(typeof(T) == typeof(ushort))
                return math.lt(uint16(lhs), uint16(rhs), dst);
            else if(typeof(T) == typeof(int))
                return math.lt(int32(lhs), int32(rhs), dst);
            else if(typeof(T) == typeof(uint))
                return math.lt(uint32(lhs), uint32(rhs), dst);
            else if(typeof(T) == typeof(long))
                return math.lt(int64(lhs), int64(rhs), dst);
            else if(typeof(T) == typeof(ulong))
                return math.lt(uint64(lhs), uint64(rhs), dst);
            else if(typeof(T) == typeof(float))
                return math.lt(float32(lhs), float32(rhs), dst);
            else if(typeof(T) == typeof(double))
                return math.lt(float64(lhs), float64(rhs), dst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Span<bool> lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => lt(lhs,rhs,span<bool>(length(lhs,rhs)));


        public static Span<bool> lteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.lteq(int8(lhs), int8(rhs), dst);
            else if(typeof(T) == typeof(byte))
                return math.lteq(uint8(lhs), uint8(rhs), dst);
            else if(typeof(T) == typeof(short))
                return math.lteq(int16(lhs), int16(rhs), dst);
            else if(typeof(T) == typeof(ushort))
                return math.lteq(uint16(lhs), uint16(rhs), dst);
            else if(typeof(T) == typeof(int))
                return math.lteq(int32(lhs), int32(rhs), dst);
            else if(typeof(T) == typeof(uint))
                return math.lteq(uint32(lhs), uint32(rhs), dst);
            else if(typeof(T) == typeof(long))
                return math.lteq(int64(lhs), int64(rhs), dst);
            else if(typeof(T) == typeof(ulong))
                return math.lteq(uint64(lhs), uint64(rhs), dst);
            else if(typeof(T) == typeof(float))
                return math.lteq(float32(lhs), float32(rhs), dst);
            else if(typeof(T) == typeof(double))
                return math.lteq(float64(lhs), float64(rhs), dst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Span<bool> lteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => lteq(lhs,rhs,span<bool>(length(lhs,rhs)));

 
         [MethodImpl(Inline)]
        public static Span<bool> gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.gt(int8(lhs), int8(rhs), dst);
            else if(typeof(T) == typeof(byte))
                return math.gt(uint8(lhs), uint8(rhs), dst);
            else if(typeof(T) == typeof(short))
                return math.gt(int16(lhs), int16(rhs), dst);
            else if(typeof(T) == typeof(ushort))
                return math.gt(uint16(lhs), uint16(rhs), dst);
            else if(typeof(T) == typeof(int))
                return math.gt(int32(lhs), int32(rhs), dst);
            else if(typeof(T) == typeof(uint))
                return math.gt(uint32(lhs), uint32(rhs), dst);
            else if(typeof(T) == typeof(long))
                return math.gt(int64(lhs), int64(rhs), dst);
            else if(typeof(T) == typeof(ulong))
                return math.gt(uint64(lhs), uint64(rhs), dst);
            else if(typeof(T) == typeof(float))
                return math.gt(float32(lhs), float32(rhs), dst);
            else if(typeof(T) == typeof(double))
                return math.gt(float64(lhs), float64(rhs), dst);
            else
                throw unsupported(PrimalKinds.kind<T>());                
        }

        [MethodImpl(Inline)]
        public static Span<bool> gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => gt(lhs,rhs,span<bool>(length(lhs,rhs)));


        public static Span<bool> gteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.gteq(int8(lhs), int8(rhs), dst);
            else if(typeof(T) == typeof(byte))
                return math.gteq(uint8(lhs), uint8(rhs), dst);
            else if(typeof(T) == typeof(short))
                return math.gteq(int16(lhs), int16(rhs), dst);
            else if(typeof(T) == typeof(ushort))
                return math.gteq(uint16(lhs), uint16(rhs), dst);
            else if(typeof(T) == typeof(int))
                return math.gteq(int32(lhs), int32(rhs), dst);
            else if(typeof(T) == typeof(uint))
                return math.gteq(uint32(lhs), uint32(rhs), dst);
            else if(typeof(T) == typeof(long))
                return math.gteq(int64(lhs), int64(rhs), dst);
            else if(typeof(T) == typeof(ulong))
                return math.gteq(uint64(lhs), uint64(rhs), dst);
            else if(typeof(T) == typeof(float))
                return math.gteq(float32(lhs), float32(rhs), dst);
            else if(typeof(T) == typeof(double))
                return math.gteq(float64(lhs), float64(rhs), dst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => gteq(lhs,rhs,span<bool>(length(lhs,rhs)));


        [MethodImpl(Inline)]
        public static Span<bool> neq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => neq(lhs,rhs,span<bool>(length(lhs,rhs)));

        public static Span<bool> neq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.neq(int8(lhs), int8(rhs), dst);
            else if(typeof(T) == typeof(byte))
                return math.neq(uint8(lhs), uint8(rhs), dst);
            else if(typeof(T) == typeof(short))
                return math.neq(int16(lhs), int16(rhs), dst);
            else if(typeof(T) == typeof(ushort))
                return math.neq(uint16(lhs), uint16(rhs), dst);
            else if(typeof(T) == typeof(int))
                return math.neq(int32(lhs), int32(rhs), dst);
            else if(typeof(T) == typeof(uint))
                return math.neq(uint32(lhs), uint32(rhs), dst);
            else if(typeof(T) == typeof(long))
                return math.neq(int64(lhs), int64(rhs), dst);
            else if(typeof(T) == typeof(ulong))
                return math.neq(uint64(lhs), uint64(rhs), dst);
            else if(typeof(T) == typeof(float))
                return math.neq(float32(lhs), float32(rhs), dst);
            else if(typeof(T) == typeof(double))
                return math.neq(float64(lhs), float64(rhs), dst);
            else
                throw unsupported<T>();
       }

    }

}