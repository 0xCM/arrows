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

    /// <summary>
    /// Defines operations for computing full 64-bit and 128-products of unsigned integers
    /// </summary>
    public static unsafe class UMul
    {
        /// <summary>
        /// Computes the 64-bit product of two unsigned 32-bit integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="lo">The low part of the product</param>
        /// <param name="hi">The hi part of the product</param>
        [MethodImpl(Inline)]
        public static void mul(uint lhs, uint rhs, out uint lo, out uint hi)
        {
            lo = 0;
            hi = Bmi2.MultiplyNoFlags(lhs, rhs, refptr(ref lo));
        }

        /// <summary>
        /// Computes the 128-bit product of two 64-bit unsigned integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">The 128 bit result</param>
        [MethodImpl(Inline)]
        public static void mul(ulong lhs, ulong rhs, out ulong lo, out ulong hi)
        {
            lo = 0;
            hi = Bmi2.X64.MultiplyNoFlags(lhs,rhs, refptr(ref lo));
        }

        /// <summary>
        /// Computes the unsigned 64-bit product of two unsigned 32-bit integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong mul(uint lhs, uint rhs)
        {
            var dst = 0u;
            return (((ulong)Bmi2.MultiplyNoFlags(lhs, rhs, refptr(ref dst))) << 32) | dst;
        }

        /// <summary>
        /// Computes the hi part of the 64-bit product of two unsigned 32-bit integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static uint mulHi(uint lhs, uint rhs)
        {
            var lo = 0u;
            return  Bmi2.MultiplyNoFlags(lhs,rhs, refptr(ref lo));
        }

        /// <summary>
        /// Effects multiplication of the form (lhs:ulong, rhs:ulong) -> result:ulong where
        /// the result is obtained from the hi 64 bits of the 128-bit product
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong mulHi(ulong lhs, ulong rhs)
        {
            UMul.mulHi(lhs,rhs, out ulong hi);
            return hi;
        }

        /// <summary>
        /// Computes the hi part of the 64-bit product of two unsigned 64-bit integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">The receiver</param>
        [MethodImpl(Inline)]
        public static void mulHi(ulong lhs, ulong rhs, out ulong dst)
            => mul(lhs,rhs, out ulong lo, out dst);

        /// <summary>
        /// Computes the lo part of the 64-bit product of two unsigned 64-bit integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">The receiver</param>
        [MethodImpl(Inline)]
        public static void mulLo(ulong lhs, ulong rhs, out ulong dst)
            => mul(lhs,rhs, out dst, out ulong hi);

        [MethodImpl(Inline)]
        public static ulong mulLo(ulong lhs, ulong rhs)
        {
            mulLo(lhs,rhs, out ulong lo);
            return lo;
        }

    }

}