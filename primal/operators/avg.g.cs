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
        /// Computes average of unsigned integral operands, rounding toward zero
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static T avgz<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.avgz(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.avgz(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.avgz(uint32(lhs), uint32(rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.avgz(uint64(lhs), uint64(rhs)));
            else            
                throw unsupported<T>();
        }

        /// <summary>
        /// Takes the average of the operands, rounding toward zero and
        /// ovwriting the left operand with the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ref T avgz<T>(ref T lhs, in T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                math.avgz(ref uint8(ref lhs), in uint8(in rhs));
            else if(typeof(T) == typeof(ushort))
                math.avgz(ref uint16(ref lhs), in uint16(in rhs));
            else if(typeof(T) == typeof(uint))
                math.avgz(ref uint32(ref lhs), in uint32(in rhs));
            else if(typeof(T) == typeof(ulong))
                math.avgz(ref uint64(ref lhs), in uint64(in rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static T avg<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.avg(int8(src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.avg(uint8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.avg(int16(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.avg(uint16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.avg(int32(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.avg(uint32(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.avg(int64(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.avg(uint64(src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.avg(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.avg(float64(src)));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static T avg<T>(Span<T> src)
            where T : struct
            => avg(src.ReadOnly());
        

    }
}