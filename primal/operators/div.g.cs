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

        /// <summary>
        /// Computes the quotient of two values of primal type
        /// </summary>
        /// <param name="lhs">The quantity divided by the right operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T div<T>(T lhs, T rhs)
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
            else if(typeof(T) == typeof(float))
                return generic<T>(fmath.fdiv(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.fdiv(float64(lhs), float64(rhs)));
            else            
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes the quotient in-place of two values of primal type
        /// </summary>
        /// <param name="lhs">The quantity divided by the right operand and which is replaced by the result</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T div<T>(ref T lhs, in T rhs)
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
            else if(typeof(T) == typeof(float))
                fmath.fdiv(ref float32(ref lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                fmath.fdiv(ref float64(ref lhs), in float64(in rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }


    }

}