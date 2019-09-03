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
    using static AsIn;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T mod<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.mod(int8(lhs),int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.mod(uint8(lhs),uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.mod(int16(lhs),int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.mod(uint16(lhs),uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.mod(int32(lhs),int32(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.mod(uint32(lhs),uint32(rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.mod(int64(lhs),int64(rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.mod(uint64(lhs),uint64(rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.mod(float32(lhs),float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.mod(float64(lhs),float64(rhs)));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T mod<T>(ref T lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.mod(ref int8(ref lhs), in int8(in rhs));
            else if(typeof(T) == typeof(byte))
                math.mod(ref uint8(ref lhs), in uint8(in rhs));
            else if(typeof(T) == typeof(short))
                math.mod(ref int16(ref lhs), in int16(in rhs));
            else if(typeof(T) == typeof(ushort))
                math.mod(ref uint16(ref lhs), in uint16(in rhs));
            else if(typeof(T) == typeof(int))
                math.mod(ref int32(ref lhs), in int32(in rhs));
            else if(typeof(T) == typeof(uint))
                math.mod(ref uint32(ref lhs), in uint32(in rhs));
            else if(typeof(T) == typeof(long))
                math.mod(ref int64(ref lhs), in int64(in rhs));
            else if(typeof(T) == typeof(ulong))
                math.mod(ref uint64(ref lhs), in uint64(in rhs));
            else if(typeof(T) == typeof(float))
                math.mod(ref float32(ref lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                math.mod(ref float64(ref lhs), in float64(in rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

        public static Span<T> mod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.mod(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.mod(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.mod(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.mod(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.mod(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.mod(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.mod(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.mod(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                math.mod(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                math.mod(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> mod<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.mod(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.mod(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.mod(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.mod(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.mod(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.mod(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.mod(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.mod(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                math.mod(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(float))
                math.mod(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> mod<T>(ref Span<T> lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.mod(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.mod(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.mod(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.mod(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.mod(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.mod(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.mod(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.mod(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                math.mod(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(float))
                math.mod(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }
    }
}
