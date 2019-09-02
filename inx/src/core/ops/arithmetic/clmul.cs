//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Pclmulqdq;
 
    using static zfunc;
        
    partial class dinx
    {                
        /// <summary>
        /// __m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8) PCLMULQDQ xmm, xmm/m128, imm8
        /// Computes the caryless 128-bit product of two 64-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static UInt128 clmul(ulong lhs, ulong rhs)
        {
            var a = Vec128.LoadScalar(lhs);
            var b = Vec128.LoadScalar(rhs);
            return CarrylessMultiply(a,b,0x00);
        }

        /// <summary>
        /// __m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8) PCLMULQDQ xmm, xmm/m128, imm8
        /// Computes the caryless 128-bit product of two 64-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> clmul(Scalar128<ulong> a, Scalar128<ulong> b)
            => CarrylessMultiply(a,b,0x00);

        /// <summary>
        /// __m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8) PCLMULQDQ xmm, xmm/m128, imm8
        /// Computes the caryless 128-bit product of two 64-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="mask">Specifies the components of the source vectors to multiply</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> clmul(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ClMulMask mask)
            =>  CarrylessMultiply(lhs, rhs, (byte)mask);

        /// <summary>
        /// Computes the caryless 16-bit product of two 8-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ushort clmul(byte lhs, byte rhs)
            => (ushort)clmul((uint)lhs, (uint)rhs);

        /// <summary>
        /// Returns the caryless 32 bit product of two 16-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static uint clmul(ushort lhs, ushort rhs)
            => (uint)clmul((uint)lhs, (uint)rhs);

        /// <summary>
        /// Returns the caryless 64 bit product from two 32-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong clmul(uint lhs, uint rhs)
            => clmul((ulong)lhs, (ulong)rhs).lo;

        /// <summary>
        /// Computes carry-less product variations for two source vectors
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">Receives the results</param>
        [MethodImpl(Inline)]
        public static ref Vec512<ulong> clmul(in Vec128<ulong> lhs, in Vec128<ulong> rhs, out Vec512<ulong> dst)
        {
            dst = Vec512.FromParts(
                clmul(lhs, rhs, ClMulMask.X00), 
                clmul(lhs, rhs, ClMulMask.X01), 
                clmul(lhs, rhs, ClMulMask.X10), 
                clmul(lhs, rhs, ClMulMask.X11)
                );
            return ref dst;
        }
    }

    /// <summary>
    /// Defines a mask that specifies the left/right vector components from which
    /// a carry-less product will be formed
    /// </summary>
    public enum ClMulMask : byte
    {
        /// <summary>
        /// For a product P = XY, multiply the lo(X) and lo(Y)
        /// </summary>
        X00 = 0x00,

        /// <summary>
        /// For a product P = XY, multiply the lo(X) and hi(Y)
        /// </summary>
        X01 = 0x01,

        /// <summary>
        /// For a product P = XY, multiply the hi(X) and lo(Y)
        /// </summary>
        X10 = 0x10,

        /// <summary>
        /// For a product P = XY, multiply the hi(X) and hi(Y)
        /// </summary>
        X11 = 0x11,
    }
}