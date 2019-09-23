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
        public static XMM vpcmpeqb(XMM xmm0, XMM xmm1)        
            => CompareEqual(vload<byte>(ref xmm0), vload<byte>(ref xmm1));



        [MethodImpl(Inline)]
        public static YMM vcmpeqq(YMM ymm0, YMM ymm1)
        {
            return CompareEqual(vload<ulong>(ref ymm0), vload<ulong>(ref ymm1));
        }

        [MethodImpl(Inline)]
        public static ref Vector256<ulong> vcmpeqq(YMM ymm0, YMM ymm1, ref Vector256<ulong> dst)
        {
            dst = CompareEqual(vload<ulong>(ref ymm0), vload<ulong>(ref ymm1));
            return ref dst;
        }

        /// <summary>
        /// VPCMPEQB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="ymm1">The destination register</param>
        /// <param name="ymm2">The first source register</param>
        /// <param name="ymm3">The second source register</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<byte> vpcmpeqb(YMM ymm0, YMM ymm1)        
        {
            return CompareEqual(vload<byte>(ref ymm0), vload<byte>(ref ymm1));
            
        }


    }

}