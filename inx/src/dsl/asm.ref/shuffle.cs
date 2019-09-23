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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static zfunc;

    partial class AsmRef
    {

        [MethodImpl(Inline), AsmEncoding("vpshufb",
            Spec: "",
            Call: "vpshufb ymm0,ymm0,ymm1",
            Code: "c4 e2 7d 00 c1"
        )]        
        public static Vector256<byte> vpshufb(Vector256<byte> xmm0, Vector256<byte> xmm1)
            => Shuffle(xmm0,xmm1);



        [MethodImpl(Inline), AsmEncoding("vpshufd",
            Spec: "",
            Call: "NONE!",
            Code: ""
        )]        
        public static Vector256<int> vpshufd(Vector256<int> xmm0, byte imm8)
            => Shuffle(xmm0,imm8);

        [MethodImpl(Inline), AsmEncoding("vpshufhw",
            Spec: "",
            Call: "NONE!",
            Code: ""
        )]        
        public static Vector256<short> vpshufhw(Vector256<short> ymm0, byte imm8)
            => ShuffleHigh(ymm0, imm8);

    }

}