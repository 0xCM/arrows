//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    
    partial class ginx
    {
        /// <summary>
        /// Compares the operands for equality
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<T> cmpeq<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.cmpeq(in int8(in lhs), in int8(in rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                return dinx.cmpeq(in uint8(in lhs), in uint8(in rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                return dinx.cmpeq(in int16(in lhs), in int16(in rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                return dinx.cmpeq(in uint16(in lhs), in uint16(in rhs)).As<T>();
            else if(typeof(T) == typeof(int))
                return dinx.cmpeq(in int32(in lhs), in int32(in rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                return dinx.cmpeq(in uint32(in lhs), in uint32(in rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return dinx.cmpeq(in int64(in lhs), in int64(in rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return dinx.cmpeq(in uint64(in lhs), in uint64(in rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                return dfp.cmpeq(in float32(in lhs), in float32(in rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                return dfp.cmpeq(in float64(in lhs), in float64(in rhs)).As<T>();
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Compares the operands for cmpequality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
       [MethodImpl(Inline)]
        public static Vec256<T> cmpeq<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.cmpeq(in int8(in lhs), in int8(in rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                return dinx.cmpeq(in uint8(in lhs), in uint8(in rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                return dinx.cmpeq(in int16(in lhs), in int16(in rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                return dinx.cmpeq(in uint16(in lhs), in uint16(in rhs)).As<T>();
            else if(typeof(T) == typeof(int))
                return dinx.cmpeq(in int32(in lhs), in int32(in rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                return dinx.cmpeq(in uint32(in lhs), in uint32(in rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return dinx.cmpeq(in int64(in lhs), in int64(in rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return dinx.cmpeq(in uint64(in lhs), in uint64(in rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                return dfp.cmpeq(in float32(in lhs), in float32(in rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                return dfp.cmpeq(in float64(in lhs), in float64(in rhs)).As<T>();
            else 
                throw unsupported<T>();
        }
    }
}