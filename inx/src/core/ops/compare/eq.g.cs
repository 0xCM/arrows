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
        /// __m128i _mm_cmpeq_? (__m128i a, __m128i b) PCMPEQ? xmm, xmm/m128
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<T> eq<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.eq(in int8(in lhs), in int8(in rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                return dinx.eq(in uint8(in lhs), in uint8(in rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                return dinx.eq(in int16(in lhs), in int16(in rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                return dinx.eq(in uint16(in lhs), in uint16(in rhs)).As<T>();
            else if(typeof(T) == typeof(int))
                return dinx.eq(in int32(in lhs), in int32(in rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                return dinx.eq(in uint32(in lhs), in uint32(in rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return dinx.eq(in int64(in lhs), in int64(in rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return dinx.eq(in uint64(in lhs), in uint64(in rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                return dfp.eq(in float32(in lhs), in float32(in rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                return dfp.eq(in float64(in lhs), in float64(in rhs)).As<T>();
            else 
                throw unsupported<T>();
        }

        /// <summary>
        ///  __m256i _mm256_cmpeq_? (__m256i a, __m256i b) VPCMPEQ? ymm, ymm, ymm/m256
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
       [MethodImpl(Inline)]
        public static Vec256Cmp<T> eq<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.eq(in int8(in lhs), in int8(in rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                return dinx.eq(in uint8(in lhs), in uint8(in rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                return dinx.eq(in int16(in lhs), in int16(in rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                return dinx.eq(in uint16(in lhs), in uint16(in rhs)).As<T>();
            else if(typeof(T) == typeof(int))
                return dinx.eq(in int32(in lhs), in int32(in rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                return dinx.eq(in uint32(in lhs), in uint32(in rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return dinx.eq(in int64(in lhs), in int64(in rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return dinx.eq(in uint64(in lhs), in uint64(in rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                return dfp.eq(in float32(in lhs), in float32(in rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                return dfp.eq(in float64(in lhs), in float64(in rhs)).As<T>();
            else 
                throw unsupported<T>();
        }
    }
}