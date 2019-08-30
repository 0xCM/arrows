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
        public static T div<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(lhs) / int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(lhs) / uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(lhs) / int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(lhs) / uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(lhs) / int32(rhs));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(lhs) / uint32(rhs));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(lhs) / int64(rhs));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(lhs) / uint64(rhs));
            else if(typeof(T) == typeof(float))
                return generic<T>(fmath.div(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.div(float64(lhs), float64(rhs)));
            else            
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes the integral quotient of the left and right operand and overwrites
        /// the left operand with the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal integral type</typeparam>
        [MethodImpl(Inline)]
        public static ref T idiv<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 math.div(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                 math.div(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                 math.div(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                 math.div(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                 math.div(ref int32(ref lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                 math.div(ref uint32(ref lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                 math.div(ref int64(ref lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                 math.div(ref uint64(ref lhs), uint64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

        public static Span<T> idiv<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.div(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.div(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.div(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.div(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.div(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.div(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.div(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.div(uint64(lhs), uint64(rhs), uint64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        /// <summary>
        /// Computes integer division between cells in the left and right operands,
        /// overwriting the left operand cell with the result, i.e., lhs[i] = lhs[i] / rhs[i]
        /// </summary>
        /// <param name="lhs">The left integer source</param>
        /// <param name="rhs">The right integer source</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline)]        
        public static Span<T> idiv<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.div(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.div(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.div(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.div(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.div(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.div(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.div(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.div(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }

    }
}
