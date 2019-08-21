//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    
    using static zfunc;    
    using static As;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static bool eq<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return int8(lhs) == int8(rhs);
            else if(typeof(T) == typeof(byte))
                return uint8(lhs) == uint8(rhs);
            else if(typeof(T) == typeof(short))
                return int16(lhs) == int16(rhs);
            else if(typeof(T) == typeof(ushort))
                return uint16(lhs) == uint16(rhs);
            else if(typeof(T) == typeof(int))
                return int32(lhs) == int32(rhs);
            else if(typeof(T) == typeof(uint))
                return uint32(lhs) == uint32(rhs);
            else if(typeof(T) == typeof(long))
                return int64(lhs) == int64(rhs);
            else if(typeof(T) == typeof(ulong))
                return uint64(lhs) == uint64(rhs);
            else if(typeof(T) == typeof(float))
                return float32(lhs) == float32(rhs);
            else if(typeof(T) == typeof(double))
                return float64(lhs) == float64(rhs);
            else            
                throw unsupported<T>();
        }

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
    }
}