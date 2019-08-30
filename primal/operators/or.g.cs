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
        /// <summary>
        /// Computes the bitwise or of two primal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T or<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.or(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.or(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.or(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.or(uint16(lhs),  uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.or(int32(lhs), int32(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.or(uint32(lhs),  uint32(rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.or(int64(lhs), int64(rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.or(uint64(lhs),  uint64(rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.or(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.or(float64(lhs), float64(rhs)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Computes the bitwise or of two primal operands, overwriting the first 
        /// operand with the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T or<T>(ref T lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 math.or(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                 math.or(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                 math.or(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                 math.or(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                 math.or(ref int32(ref lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                 math.or(ref uint32(ref lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                 math.or(ref int64(ref lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                 math.or(ref uint64(ref lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                 math.or(ref float32(ref lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 math.or(ref float64(ref lhs), float64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

   }
}