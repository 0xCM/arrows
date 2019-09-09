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

    using static System.Runtime.Intrinsics.X86.Pclmulqdq;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;

    using static zfunc;
    using static As;

    partial class dinx
    {
        /// <summary>
        /// _mm_mul_epi32
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<long> mul(in Vec128<int> lhs, in Vec128<int> rhs)
            => Multiply(lhs, rhs);
            
        /// <summary>
        /// _mm_mul_epu32
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        static Vec128<ulong> mul(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Multiply(lhs, rhs);

        /// <summary>
        /// _mm256_mul_epi32
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        static Vec256<long> mul(in Vec256<int> lhs,in Vec256<int> rhs)
            => Multiply(lhs, rhs);
        
        /// <summary>
        /// _mm256_mul_epu32
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        static Vec256<ulong> mul(in Vec256<uint> lhs,in Vec256<uint> rhs)
            => Multiply(lhs, rhs);
            
        const ulong LoMask64 = 0x00000000fffffffful;
        
        /// <summary>
        /// Multiplies two two 256-bit/u64 vectors to yield a 256-bit/u64 vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> mul(in Vec256<ulong> x, in Vec256<ulong> y)    
        {
            var loMask = Vec256.Fill(LoMask64);    
            ref var xl = ref dinx.and(x, loMask).As(out Vec256<uint> _);
            ref var xh = ref dinx.srli(x, 32).As(out Vec256<uint> _);
            ref var yl = ref dinx.and(y, loMask).As(out Vec256<uint> _);
            ref var yh = ref dinx.srli(y, 32).As(out Vec256<uint> _);

            var xh_yl = dinx.mul(in xh, in yl);
            var hl = dinx.slli(in xh_yl, 32);

            var xh_mh = dinx.mul(in xh, yh);
            var lh = dinx.slli(in xh_mh, 32);

            var xl_yl = dinx.mul(in xl, in yl);

            var hl_lh = dinx.add(in hl, in lh);
            var z = dinx.add(in xl_yl, in hl_lh);
            return z;
        }
    }
}