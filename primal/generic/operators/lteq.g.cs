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
        public static bool lteq<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return int8(lhs) <= int8(rhs);
            else if(typeof(T) == typeof(byte))
                return uint8(lhs) <= uint8(rhs);
            else if(typeof(T) == typeof(short))
                return int16(lhs) <= int16(rhs);
            else if(typeof(T) == typeof(ushort))
                return uint16(lhs) <= uint16(rhs);
            else if(typeof(T) == typeof(int))
                return int32(lhs) <= int32(rhs);
            else if(typeof(T) == typeof(uint))
                return uint32(lhs) <= uint32(rhs);
            else if(typeof(T) == typeof(long))
                return int64(lhs) <= int64(rhs);
            else if(typeof(T) == typeof(ulong))
                return uint64(lhs) <= uint64(rhs);
            else if(typeof(T) == typeof(float))
                return float32(lhs) <= float32(rhs);
            else if(typeof(T) == typeof(double))
                return float64(lhs) <= float64(rhs);
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
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


    }

}