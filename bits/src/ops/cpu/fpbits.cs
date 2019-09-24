//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
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
        public static Vec256<T> vand<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(Bits.and(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.and(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static Vec128<T> vxor<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(Bits.xor(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.xor(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> vxor<T>(Vec256<T> lhs, Vec256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(Bits.xor(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.xor(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

    }

}