//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static zfunc;

    public static class UMulX
    {
        /// <summary>
        /// Computes the lo part of the 64-bit product of two unsigned 64-bit integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong MulLo(this ulong lhs, ulong rhs)
        {
            UMul.mulLo(lhs, rhs, out ulong dst);
            return dst;
        }            

        /// <summary>
        /// Computes the hi part of the 64-bit product of two unsigned 64-bit integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong MulHi(this ulong lhs, ulong rhs)
        {
            UMul.mulHi(lhs, rhs, out ulong dst);
            return dst;
        }

        /// <summary>
        /// Computes the 64-bit product of two 32-bit integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong Mul64(this uint lhs, uint rhs)
        {
            return UMul.mul(lhs,rhs);
        }

        [MethodImpl(Inline)]
        public static ref UInt128 UMul128(this ulong lhs, ulong rhs, out UInt128 dst)
        {
            UMul.mul(lhs,rhs, out dst);
            return ref dst;
        }
    }
}