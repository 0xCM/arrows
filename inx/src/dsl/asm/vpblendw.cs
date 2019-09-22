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
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static zfunc;
    using static IMM;

    partial class Asm
    {


        /// <summary>
        /// Selects words from xmm2 and xmm3/m128 according to a control mask imm8 
        /// and populates xmm1 with the result, xmm1[i] = testbit(imm8,i) ? xmm3[i] : xmm2[i]
        /// </summary>
        /// <param name="xmm1">The destination register</param>
        /// <param name="xmm2">The first source register</param>
        /// <param name="xmm3">The second source register</param>
        /// <param name="imm8">The controlling mask</param>
        /// <remarks>
        /// xmm2                : [1       2       3       4       5       6       7       8]
        /// xmm3                : [9       10      11      12      13      14      15      16]
        /// imm8                : [1       0       1       0       1       0       1       0]
        /// xmm1                : [9       2       11      4       13      6       15      8]
        /// </remarks>
        [MethodImpl(Inline)]
        public static XMM vpblendw(XMM xmm2, XMM xmm3, Imm8 imm8)        
        {
            return Blend(vload<ushort>(ref xmm2), vload<ushort>(ref xmm3), imm8);
        }
            
        [MethodImpl(Inline)]
        static Vector128<ushort> vpblendw_ref(Vector128<ushort> xmm0, Vector128<ushort> xmm1, byte imm8)        
        {
            return Blend(xmm0, xmm1, imm8);
        }

        [MethodImpl(Inline)]
        static Vector256<ushort> vpblendw_ref(Vector256<ushort> xmm0, Vector256<ushort> xmm1, byte imm8)        
        {
            return Blend(xmm0, xmm1, imm8);
        }

        [MethodImpl(Inline)]
        static Vector256<uint> vpblendd_ref(Vector256<uint> xmm0, Vector256<uint> xmm1, byte imm8)        
        {
            return Blend(xmm0, xmm1, imm8);
        }

        [MethodImpl(Inline)]
        static Vector256<float> vpblendps_ref(Vector256<float> xmm0, Vector256<float> xmm1, byte imm8)        
        {
            return Blend(xmm0, xmm1, imm8);
        }

    }



}