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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static zfunc;
    using static Reg;
    using static IMM;

    partial class Asm
    {

        [MethodImpl(Inline)]
        public static ref XMM vpcmpeqb(ref XMM xmm1, in XMM xmm2, in XMM xmm3)        
        {
            xmm1 = CompareEqual(vec<byte>(xmm2), vec<byte>(xmm3));
            return ref xmm1;
        }

        /// <summary>
        /// VPCMPEQB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="ymm1">The destination register</param>
        /// <param name="ymm2">The first source register</param>
        /// <param name="ymm3">The second source register</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ref YMM vpcmpeqb(ref YMM ymm1, in YMM ymm2, in YMM ymm3)        
        {
            ymm1 = CompareEqual(vec<byte>(ymm2), vec<byte>(ymm3));
            return ref ymm1;
        }


    }

}