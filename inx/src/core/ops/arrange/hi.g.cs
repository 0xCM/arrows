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
        /// Extracts the hi 128-bit lane from the source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> hi<T>(in Vec256<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.hi(in int8(in src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.hi(in uint8(in src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.hi(in int16(in src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.hi(in uint16(in src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.hi(in int32(in src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.hi(in uint32(in src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.hi(in int64(in src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.hi(in uint64(in src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dinx.hi(in float32(in src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.hi(in float64(in src)));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Extracts the hi 64 bits from each operand and forms a new 128-bit vector
        /// from the extracted data
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> hi<T>(in Vec128<T> lhs, in Vec128<T> rhs)        
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.hi(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.hi(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.hi(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.hi(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.hi(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.hi(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.hi(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.hi(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dinx.hi(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.hi(in float64(in lhs), in float64(in rhs)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> hi<T>(in Vec256<T> lhs, in Vec256<T> rhs)        
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.hi(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.hi(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.hi(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.hi(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.hi(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.hi(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.hi(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.hi(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dinx.hi(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.hi(in float64(in lhs), in float64(in rhs)));
            else
                throw unsupported<T>();
        }


    }

}