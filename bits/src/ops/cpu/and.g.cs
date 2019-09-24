//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using static zfunc;
    using static As;
    using static AsIn;


    partial class gbits
    {
        /// <summary>
        /// Computes the bitwise and between two input vectors
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> vand<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.and(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.and(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.and(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.and(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.and(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.and(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.and(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.and(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.and(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.and(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vand256u<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.and(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.and(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.and(uint32(lhs), uint32(rhs)));
            else
                return generic<T>(Bits.and(uint64(lhs), uint64(rhs)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vand256i<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.and(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.and(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.and(int32(lhs), int32(rhs)));
            else
                return generic<T>(Bits.and(int64(lhs), int64(rhs)));
        }

        /// <summary>
        /// Computes the bitwise AND between two vectors
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vand<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || 
                typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
                    return vand256u(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) || typeof(T) == typeof(short) || 
                typeof(T) == typeof(int) || typeof(T) == typeof(long))
                    return vand256i(lhs,rhs);
            else
                throw unsupported<T>();
        }

    }
}