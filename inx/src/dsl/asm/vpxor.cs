//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static zfunc;
    using static Reg;

    partial class Asm
    {
        /// <summary>
        /// PXOR xmm, xmm/m128
        /// Computes XOR between the operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static XMM pxor(in XMM a, in XMM b)        
            => Xor(vec<ulong>(in a), vec<ulong>(in b));        
        
        /// <summary>
        /// VPXOR ymm, ymm, ymm/m256
        /// Computes XOR between the operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static YMM vpxor(in YMM a, in YMM b)        
            => Xor(vec<ulong>(in a), vec<ulong>(in b));        
    }
}