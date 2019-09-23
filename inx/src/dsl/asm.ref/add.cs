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

        [MethodImpl(Inline), AsmEncoding("vpaddb", 
            Spec: "VEX.128.66.0F.WIG FC /r VPADDB xmm1, xmm2, xmm3/m128",
            Call: "vpaddb xmm0,xmm0,[r8]",
            Code: "c4 c1 79 fc 00"
        )]
        public static Vector128<byte> vpaddb(Vector128<byte> xmm0, Vector128<byte> xmm1)
            => Add(xmm0,xmm1);

        [MethodImpl(Inline), AsmEncoding("vpaddw",
            Spec: "VEX.128.66.0F.WIG FD /r VPADDW xmm1, xmm2, xmm3/m128",
            Call: "vpaddw xmm0,xmm0,[r8]",
            Code: "c4 c1 79 fd 00"
            )]
        public static Vector128<ushort> vpaddw(Vector128<ushort> xmm0, Vector128<ushort> xmm1)
            => Add(xmm0,xmm1);


        [MethodImpl(Inline), AsmEncoding("vpaddd",
            Spec: "VEX.128.66.0F.WIG FE /r VPADDD xmm1, xmm2, xmm3/m128",
            Call: "vpaddd xmm0,xmm0,[r8",
            Code: "c4 c1 79 fe 00"
            )]
        public static Vector128<uint> vpaddd(Vector128<uint> xmm0, Vector128<uint> xmm1)
            => Add(xmm0,xmm1);

        [MethodImpl(Inline), AsmEncoding("vpaddq",
            Spec: "VEX.128.66.0F.WIG D4 /r VPADDQ xmm1, xmm2, xmm3/m128",
            Call: "vpaddq xmm0,xmm0,[r8]",
            Code: "c4 c1 79 d4 00"
            )]
        public static Vector128<ulong> vpaddq(Vector128<ulong> xmm0, Vector128<ulong> xmm1)
            => Add(xmm0,xmm1);

        [MethodImpl(Inline), AsmEncoding("vpaddb",
            Spec: "VEX.256.66.0F.WIG FC /r VPADDB ymm1, ymm2, ymm3/m256 ",
            Call: "vpaddb ymm0,ymm0,[r8]",
            Code: "c4 c1 7d fc 00"
            )]
        public static Vector256<byte> vpaddb(Vector256<byte> ymm0, Vector256<byte> ymm1)
            => Add(ymm0,ymm1);


        [MethodImpl(Inline), AsmEncoding("vpaddw",
            Spec: "VEX.256.66.0F.WIG FD /r VPADDW ymm1, ymm2, ymm3/m256",
            Call: "vpaddw ymm0,ymm0,[r8]",
            Code: "c4 c1 7d fd 00"
            )]
        public static Vector256<ushort> vpaddw(Vector256<ushort> ymm0, Vector256<ushort> ymm1)
            => Add(ymm0,ymm1);


        [MethodImpl(Inline), AsmEncoding("vpaddd",
            Spec: "VEX.256.66.0F.WIG FE /r VPADDD ymm1, ymm2, ymm3/m256",
            Call: "vpaddd ymm0,ymm0,[r8]",
            Code: "c4 c1 7d fe 00"
            )]
        public static Vector256<uint> vpaddd(Vector256<uint> ymm0, Vector256<uint> ymm1)
            => Add(ymm0,ymm1);

        [MethodImpl(Inline), AsmEncoding("vpaddq",
            Spec: "VEX.256.66.0F.WIG D4 /r VPADDQ ymm1, ymm2, ymm3/m256",
            Call: "vpaddq ymm0,ymm0, [r8]",
            Code: "c4 c1 7d d4 00"
            )]
        public static Vector256<ulong> vpaddq(Vector256<ulong> ymm0, Vector256<ulong> ymm1)
            => Add(ymm0,ymm1);


    }

}