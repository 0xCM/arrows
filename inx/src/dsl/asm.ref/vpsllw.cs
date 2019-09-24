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

    partial class AsmRef
    {

        [MethodImpl(Inline), AsmEncoding("vpsllw",
            Spec: "VEX.256.66.0F.WIG 72 /6 ib VPSLLD ymm, ymm, imm8",
            Call: "vpslld ymm0,ymm0,xmm1",
            Code: "c5 fd f2 c1"
            )]
        public static Vector256<uint> vpsllw(Vector256<uint> ymm0, byte imm8)
            => ShiftLeftLogical(ymm0, imm8);
    }

}