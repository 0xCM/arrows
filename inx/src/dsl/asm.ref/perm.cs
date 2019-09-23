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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static zfunc;
    using static IMM;


    partial class AsmRef
    {

        [MethodImpl(Inline), AsmEncoding("vpermd", 
            Spec: "VEX.256.66.0F38.W0 36 /r VPERMD ymm1, ymm2, ymm3/m256",
            Call: "vpermd ymm0,ymm0,[r8]",
            Code: "c4 c2 7d 36 00"
        )]
        public static Vector256<uint> vpermd(Vector256<uint> ymm0, Vector256<uint> ymm1)
            => PermuteVar8x32(ymm1, ymm1);

        
        [MethodImpl(Inline), AsmEncoding("vpermq", 
            Spec: "VEX.256.66.0F3A.W1 00 /r ib VPERMQ ymm1, ymm2/m256, imm8",
            Call: "NONE!"
        )]
        public static Vector256<ulong> vpermq(Vector256<ulong> value, byte imm8)
            => Permute4x64(value,imm8);



    }

}