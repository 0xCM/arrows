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
    
    partial class Bits
    {                
        /// <summary>
        /// Defines a reference implementation of caryless multiplication that follows
        /// Intel's published algirithm
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <returns></returns>
        public static BitVector128 clmul_ref(BitVector64 x, BitVector64 y)
        {
            var temp1 = x;
            var temp2 = y;

            var dst = BitVector128.Zero;            
            var tmp = BitVector128.Zero;

            for(var i=0; i<64; i++)
            {
                tmp[i] = temp1[0] & temp2[i];
                for(var j = 1; j <=i; j++)
                    tmp[i] = tmp[i] ^ (temp1[j] & temp2[i - j]);
                dst[i] = tmp[i];
            }

            for(var i=64; i<128; i++)
            {
                tmp[i] = 0;
                for(var j=(i - 63); j< 64; j++)
                    tmp[i] = tmp[i] ^(temp1[j] & temp2[i-j]);
                dst[i] = tmp[i];
            }
            dst[127] = 0;
            
            return dst;
        }

        /// <summary>
        /// Computes the carryless product of the operands reduced by a specified polynomial
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="poly">The reducing polynomial</param>
        [MethodImpl(Inline)]
        public static BitVector8 clmulr(BitVector8 a, BitVector8 b, BitVector16 poly)
        {
            var prod = dinx.clmul(a,b);
            prod ^= (ushort)dinx.clmul((ushort)(prod >> 8), poly);
            prod ^= (ushort)dinx.clmul((ushort)(prod >> 8), poly);
            return (byte)prod;
        }

        /// <summary>
        /// Computes the carryless product of the operands reduced by a specified polynomial
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="poly">The reducing polynomial</param>
        [MethodImpl(Inline)]
        public static byte clmulr(byte a, byte b, ushort poly)
        {
            var prod = dinx.clmul(a,b);
            prod ^= (ushort)dinx.clmul((ushort)(prod >> 8), poly);
            prod ^= (ushort)dinx.clmul((ushort)(prod >> 8), poly);
            return (byte)prod;
        }

        /// <summary>
        /// Computes the carryless product of the operands reduced by a specified polynomial
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="poly">The reducing polynomial</param>
        [MethodImpl(Inline)]
        public static ushort clmulr(ushort a, ushort b, uint poly)
        {
            var prod = dinx.clmul(a,b);
            prod ^= (uint)dinx.clmul(prod >> 16, poly);
            prod ^= (uint)dinx.clmul(prod >> 16, poly);
            return (ushort)prod;
        }

        /// <summary>
        /// Computes the carryless product of the operands reduced by a specified polynomial
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="poly">The reducing polynomial</param>
        [MethodImpl(Inline)]
        public static BitVector16 clmulr(BitVector16 a, BitVector16 b, BitVector32 poly)
        {
            var prod = dinx.clmul(a,b);
            prod ^= (uint)dinx.clmul(prod >> 16, poly);
            prod ^= (uint)dinx.clmul(prod >> 16, poly);
            return (ushort)prod;
        }

        /// <summary>
        /// Computes the carryless product of the operands reduced by a specified polynomial
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="poly">The reducing polynomial</param>
        [MethodImpl(Inline)]
        public static uint clmulr(uint a, uint b, ulong poly)
        {
            var prod = dinx.clmul(a,b);
            prod ^= dinx.clmul(prod >> 32, poly).lo;
            prod ^= dinx.clmul(prod >> 32, poly).lo;
            return (uint)prod;
        }

        /// <summary>
        /// __m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8) PCLMULQDQ xmm, xmm/m128, imm8
        /// Computes the caryless 128-bit product of two 64-bit operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        static BitVector128 clmul(BitVector64 lhs, BitVector64 rhs)
        {
            var a = Vec128.LoadScalar(lhs.Scalar);
            var b = Vec128.LoadScalar(rhs.Scalar);
            return dinx.clmul(a,b,ClMulMask.X00);
        }

        /// <summary>
        /// Computes the carryless product of two 64-bit operands reduced by a specified polynomial
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="poly">The reducing polynomial</param>
        [MethodImpl(Inline)]
        public static BitVector64 clmulr(BitVector64 a, BitVector64 b, BitVector128 poly)
        {
            var prod = clmul(a,b);
            prod = Bits.xor(prod, dinx.clmul(srl(prod, 64), poly, ClMulMask.X00));
            prod = Bits.xor(prod, dinx.clmul(srl(prod, 64), poly, ClMulMask.X00));
            return (BitVector64)prod;
        }

        /// <summary>
        /// Computes the carryless product of two 64-bit operands reduced by a specified polynomial
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="poly">The reducing polynomial</param>
        [MethodImpl(Inline)]
        public static Scalar128<ulong> clmulr(Scalar128<ulong> a, Scalar128<ulong> b, Vec128<ulong> poly)
        {
            var prod = dinx.clmul(a,b);
            prod = Bits.xor(prod, dinx.clmul(srl(prod, 64), poly, ClMulMask.X00));
            prod = Bits.xor(prod, dinx.clmul(srl(prod, 64), poly, ClMulMask.X00));
            return prod;
        }
    }
}