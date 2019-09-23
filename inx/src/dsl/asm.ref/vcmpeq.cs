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
        [MethodImpl(Inline), AsmEncoding("vpcmpeqb",
            Spec: "VEX.128.66.0F.WIG 74 /r VPCMPEQB xmm1, xmm2, xmm3/m128",
            Call: "vpcmpeqb xmm0,xmm0,[r8]",
            Code: "c4 c1 79 74 00"
        )]        
        public static Vector128<byte> vpcmpeqb(Vector128<byte> xmm0, Vector128<byte> xmm1)        
            => CompareEqual(xmm0,xmm1);

        [MethodImpl(Inline), AsmEncoding("vpcmpeqb",
            Spec: "VEX.256.66.0F.WIG 74 /r VPCMPEQB ymm1, ymm2, ymm3 /m256",
            Call: "vpcmpeqb ymm0,ymm0,[r8]",
            Code: "c4 c1 7d 74 00"
        )]        
        public static Vector256<byte> vpcmpeqb(Vector256<byte> ymm0, Vector256<byte> ymm1)        
            => CompareEqual(ymm0,ymm1);

        [MethodImpl(Inline), AsmEncoding("vpcmpeqq",
            Spec: "",
            Call: "",
            Code: ""
        )]        
        public static Vector128<ulong> vcmpeqq(Vector128<ulong> xmm0, Vector128<ulong> xmm1)
            => CompareEqual(xmm0,xmm1);

        [MethodImpl(Inline), AsmEncoding("vpcmpeqq",
            Spec: "",
            Call: "",
            Code: ""
        )]        
        public static Vector256<ulong> vcmpeqq(Vector256<ulong> ymm0, Vector256<ulong> ymm1)
            => CompareEqual(ymm0,ymm1);

    }

}