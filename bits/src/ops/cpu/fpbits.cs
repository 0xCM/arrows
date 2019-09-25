//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.Intrinsics;
    using Z0;
 
    using static zfunc;
    using static As;
    using static AsIn;

    public static class fpbits
    {
        /// <summary>
        /// Computes the bitwise and between two input vectors
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vand<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(Bits.and(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.and(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static Vector128<T> vxor<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(Bits.xor(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.xor(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vxor<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(Bits.xor(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.xor(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
        }

    }

}