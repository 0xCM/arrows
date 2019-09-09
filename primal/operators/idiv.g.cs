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
        public static T idiv<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.idiv(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.idiv(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.idiv(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.idiv(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.idiv(int32(lhs), int32(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.idiv(uint32(lhs), uint32(rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.idiv(int64(lhs), int64(rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.idiv(uint64(lhs), uint64(rhs)));
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
        public static ref T idiv<T>(ref T lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 math.idiv(ref int8(ref lhs), in int8(in rhs));
            else if(typeof(T) == typeof(byte))
                 math.idiv(ref uint8(ref lhs), in uint8(in rhs));
            else if(typeof(T) == typeof(short))
                 math.idiv(ref int16(ref lhs), in int16(in rhs));
            else if(typeof(T) == typeof(ushort))
                 math.idiv(ref uint16(ref lhs), in uint16(in rhs));
            else if(typeof(T) == typeof(int))
                 math.idiv(ref int32(ref lhs), in int32(in rhs));
            else if(typeof(T) == typeof(uint))
                 math.idiv(ref uint32(ref lhs), in uint32(in rhs));
            else if(typeof(T) == typeof(long))
                 math.idiv(ref int64(ref lhs), in int64(in rhs));
            else if(typeof(T) == typeof(ulong))
                 math.idiv(ref uint64(ref lhs), in uint64(in rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

        public static Span<T> idiv<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.idiv(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.idiv(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.idiv(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.idiv(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.idiv(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.idiv(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.idiv(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.idiv(uint64(lhs), uint64(rhs), uint64(dst));
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
                math.idiv(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.idiv(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.idiv(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.idiv(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.idiv(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.idiv(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.idiv(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.idiv(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }

    }
}
