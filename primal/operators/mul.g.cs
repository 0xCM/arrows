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
        public static T mul<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.mul(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.mul(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.mul(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.mul(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.mul(int32(lhs), int32(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.mul(uint32(lhs), uint32(rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.mul(int64(lhs), int64(rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.mul(uint64(lhs), uint64(rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.mul(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.mul(float64(lhs), float64(rhs)));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static ref T mul<T>(ref T lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.mul(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.mul(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.mul(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.mul(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.mul(ref int32(ref lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.mul(ref uint32(ref lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.mul(ref int64(ref lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.mul(ref uint64(ref lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                math.mul(ref float32(ref lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                math.mul(ref float64(ref lhs), float64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

        /// <summary>
        /// Multiplies corresponding elements in left/right primal source spans and writes
        /// the result to a caller-supplied target span
        /// </summary>
        /// <param name="lhs">The left primal span</param>
        /// <param name="rhs">The right primal span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The span element type</typeparam>
        public static Span<T> mul<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(lhs).Mul(int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                uint8(lhs).Mul(uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                int16(lhs).Mul(int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                uint16(lhs).Mul(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Mul(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Mul(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Mul(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Mul(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Mul(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).Mul(float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        public static Span<T> mul<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(lhs).Mul(int8(rhs));
            else if(typeof(T) == typeof(byte))
                uint8(lhs).Mul(uint8(rhs));
            else if(typeof(T) == typeof(short))
                int16(lhs).Mul(int16(rhs));
            else if(typeof(T) == typeof(ushort))
                uint16(lhs).Mul(uint16(rhs));
            else if(typeof(T) == typeof(int))
                int32(lhs).Mul(int32(rhs));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Mul(uint32(rhs));
            else if(typeof(T) == typeof(long))
                int64(lhs).Mul(int64(rhs));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Mul(uint64(rhs));
            else if(typeof(T) == typeof(float))
                float32(lhs).Mul(float32(rhs));
            else if(typeof(T) == typeof(double))
                float64(lhs).Mul(float64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }

    }
}
