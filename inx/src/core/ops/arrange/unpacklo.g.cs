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
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// lower 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<T> unpacklo<T>(in Vec128<T> lhs, in Vec128<T> rhs)        
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.unpacklo(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.unpacklo(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.unpacklo(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.unpacklo(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.unpacklo(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.unpacklo(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.unpacklo(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.unpacklo(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dfp.unpacklo(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.unpacklo(in float64(in lhs), in float64(in rhs)));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// lower 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<T> unpacklo<T>(in Vec256<T> lhs, in Vec256<T> rhs)        
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.unpacklo(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.unpacklo(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.unpacklo(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.unpacklo(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.unpacklo(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.unpacklo(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.unpacklo(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.unpacklo(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dfp.unpacklo(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.unpacklo(in float64(in lhs), in float64(in rhs)));
            else
                throw unsupported<T>();
        }


    }

}