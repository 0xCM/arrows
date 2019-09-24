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

    /// <summary>
    /// Defines asm endoding utilities
    /// </summary>
    /// <remarks>Much of this was derived or taken directly from Microsoft's Core CLR project</remarks>
    public static class AsmCodes
    {
        // 0x0000ff00 - modrm byte position
        // 0x000000ff - last byte of opcode (before modrm)
        // 0x00ff0000 - first byte of opcode
        // 0xff000000 - middle byte of opcode, if needed (after first, before last)
        //
        // So a 1-byte opcode is:      and with modrm:
        //             0x00000011          0x0000RM11
        //
        // So a 2-byte opcode is:      and with modrm:
        //             0x00002211          0x0011RM22
        //
        // So a 3-byte opcode is:      and with modrm:
        //             0x00113322          0x2211RM33
        //
        // So a 4-byte opcode would be something like this:
        //             0x22114433

        
        [MethodImpl(Inline)]
        public static uint PACK2(uint b0, uint b1)
            => (b0 << 16) |  b1;

        [MethodImpl(Inline)]
        public static uint PACK3(uint b0, uint b1, uint b2)
            => (b0 << 16) | (b1 << 24) | b2;

        [MethodImpl(Inline)]
        public static uint PACK4(uint b0, uint b1,uint b2, uint b3) 
            => ((b0 << 16) | (b1 << 24) | b2 | (b3 << 8));

        [MethodImpl(Inline)]
        public static uint SSE38(uint c)
            => PACK4(0x66, 0x0f, 0x38, c);

        [MethodImpl(Inline)]
        public static uint SSE3A(uint c) 
            => PACK4(0x66, 0x0f, 0x3A, c);
        
        [MethodImpl(Inline)]
        public static uint SSEFLT(uint c)
            => PACK3(0xf3, 0x0f, c);

        [MethodImpl(Inline)]
        public static uint SSEDBL(uint c)
            => PACK3(0xf2, 0x0f, c);

        [MethodImpl(Inline)]
        public static uint PCKDBL(uint c)
            => PACK3(0x66, 0x0f, c);

        [MethodImpl(Inline)]
        public static uint PACKFLT(uint c)
            => PACK2(0x0f, c);

        /*
            VEX* encodes the implied leading opcode bytes in c1:
            1: implied 0f, 2: implied 0f 38, 3: implied 0f 3a            
         */

        [MethodImpl(Inline)]
        public static uint VEX2INT(uint c1,uint c2)   
            => PACK3(c1, 0xc5, c2);

        [MethodImpl(Inline)]
        public static uint VEX3INT(uint c1,uint c2)   
            => PACK4(c1, 0xc5, 0x02, c2);

        [MethodImpl(Inline)]
        public static uint VEX3FLT(uint c1,uint c2)   
            => PACK4(c1, 0xc5, 0x02, c2);


    }

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