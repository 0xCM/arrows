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
        public static Span<T> or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => or(lhs,rhs, span<T>(length(lhs,rhs)));


        [MethodImpl(Inline)]
        public static ref Span<T> or<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.or(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.or(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.or(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.or(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.or(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.or(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.or(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.or(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> or<T>(ref Span<T> lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.or(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.or(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.or(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.or(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.or(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.or(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.or(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.or(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }


    }
}