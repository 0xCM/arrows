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
    using static IMM;


    partial class AsmRef
    {
        [MethodImpl(Inline), AsmEncoding("vpblendvb",
            Spec: "VEX.128.66.0F3A.W0 4C /r /is4 VPBLENDVB xmm1, xmm2, xmm3/m128, xmm4",
            Call: "vpblendvb xmm0,xmm0,[r8],xmm1",
            Code: "c4 c3 79 4c 00 10"
        )]        
        public static Vector128<byte> vpblendvb(Vector128<byte> xmm0, Vector128<byte> xmm1, Vector128<byte> xmm2)        
            => BlendVariable(xmm0, xmm1, xmm2);

        [MethodImpl(Inline), AsmEncoding("vpblendvb",
            Spec: "VEX.256.66.0F3A.W0 4C /r /is4 VPBLENDVB ymm1, ymm2, ymm3/m256, ymm4",
            Call: "vpblendvb ymm0,ymm0,[r8],ymm1",
            Code: "c4 c3 7d 4c 00 10"
        )]        
        public static Vector256<byte> vpblendvb(Vector256<byte> xmm0, Vector256<byte> xmm1, Vector256<byte> xmm2)        
            => BlendVariable(xmm0, xmm1, xmm2);


        [MethodImpl(Inline), AsmEncoding("vpblendw",
            Spec: "VEX.128.66.0F3A.WIG 0E /r ib VPBLENDW xmm1, xmm2, xmm3/m128, imm8",
            Call: "NONE!",
            Code: ""
        )]        
        public static Vector128<ushort> vpblendw(Vector128<ushort> xmm0, Vector128<ushort> xmm1, byte imm8)        
            => Blend(xmm0, xmm1, imm8);

        [MethodImpl(Inline), AsmEncoding("vpblendd",
            Spec: "VEX.128.66.0F3A.W0 02 /r ib VPBLENDD xmm1, xmm2, xmm3/m128, imm8",
            Call: "NONE!",
            Code: ""
        )]        
        public static Vector128<uint> vpblendd(Vector128<uint> xmm0, Vector128<uint> xmm1, byte imm8)        
            => Blend(xmm0, xmm1, imm8);

        [MethodImpl(Inline), AsmEncoding("vpblendw",
            Spec: "VEX.128.66.0F3A.WIG 0E /r ib VPBLENDW xmm1, xmm2, xmm3/m128, imm8",
            Call: "NONE!",
            Code: ""
        )]
        public static Vector256<ushort> vpblendw(Vector256<ushort> xmm0, Vector256<ushort> xmm1, byte imm8)        
            => Blend(xmm0, xmm1, imm8);

        [MethodImpl(Inline), AsmEncoding("vpblendd",
            Spec: "VEX.256.66.0F3A.W0 02 /r ib VPBLENDD ymm1, ymm2, ymm3/m256, imm8",
            Call: "",
            Code: ""
        )]        
        public static Vector256<uint> vpblendd(Vector256<uint> xmm0, Vector256<uint> xmm1, byte imm8)        
            => Blend(xmm0, xmm1, imm8);

        [MethodImpl(Inline)]
        public static Vector256<float> vpblendps(Vector256<float> xmm0, Vector256<float> xmm1, byte imm8)        
            => Blend(xmm0, xmm1, imm8);



    }

}