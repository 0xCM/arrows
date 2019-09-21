//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.IO;

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static zfunc;
    using static BitParts;

    static class Util
    {


        /// <summary>
        /// Presents a source register as a 256-bit cpu vector
        /// </summary>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vec<T>(YMM src)
            where T : unmanaged
                => YMM.Vec256<T>(src);
    }

    public struct PseudoByte
    {
        uint data;

        [MethodImpl(Inline)]
        public static implicit operator uint(PseudoByte src)        
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator PseudoByte(byte src)        
            => new PseudoByte(src);

        [MethodImpl(Inline)]
        public static implicit operator PseudoByte(uint src)        
            => new PseudoByte((byte)src);

        [MethodImpl(Inline)]
        public PseudoByte(byte src)
            => data = src;

    }

    class IntrinsicScenarios : Deconstructable<IntrinsicScenarios>
    {
        public IntrinsicScenarios()
            : base(callerfile())
        {

        }

        /*
        0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
        0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
        0009h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
        000ch movzx edx,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 08
        0011h pdep eax,edx,eax              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EDX,EAX]            encoding(VEX, 5 bytes) = c4 e2 6b f5 c0
        0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
        0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
        */
        [MethodImpl(Inline)]
        public static byte project1(byte src, Part6x3 part)
            => (byte)Bits.scatter(src, (byte)part);

        /*
        0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
        0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
        0008h pdep eax,ecx,eax              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EAX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c0
        000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
        0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3                    
         */
        [MethodImpl(Inline)]
        public static byte project2(uint src, Part6x3 part)
            => (byte)Bits.scatter(src, (uint)part);

        /*
        0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
        0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
        0008h pdep eax,ecx,eax              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EAX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c0
        000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3                
         */
        [MethodImpl(Inline)]
        public static uint project3(uint src, Part6x3 part)
            => Bits.scatter(src, (uint)part);

        /*
        0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
        0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
        000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3                
         */
        [MethodImpl(Inline)]
        public static uint project4(uint src, uint part)
            => Bits.scatter(src, part);
        /*
        0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
        0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
        000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
        000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
         */
        [MethodImpl(Inline)]
        public static PseudoByte project5(PseudoByte src, Part32x2 part)
            => Bits.scatter(src,(uint)part);

        /*
        0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
        0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
        0008h pdep eax,ecx,eax              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EAX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c0
        000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
        0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
         */
        [MethodImpl(Inline)]
        public static PseudoByte project6(PseudoByte src, Part6x3 part)
            => Bits.scatter(src,(uint)part);

        public static Vector256<byte> vpxor(in byte ymm0, in byte ymm1, in byte ymm2, in byte ymm3)
        {
            dinx.load256(in ymm0, in ymm1, out Vector256<byte> v0, out Vector256<byte> v1);
            dinx.load256(in ymm2, in ymm3, out Vector256<byte> v2, out Vector256<byte> v3);
                        
            var a0 = Xor(v0, v1);
            var a1 = Xor(v2, v3);

            var b0 = Xor(a0, a1);
        
            return b0;
        }



        public static Vector256<int> blend_256x32i(in int ymm0, int ymm1, byte imm8)        
        {
            var v0 = dinx.load256(in ymm0);
            var v1 = dinx.load256(in ymm1);
            var ymm2 = Blend(v0,v1,imm8);
            return ymm2;
        }

        public static Vector128<byte> vpaddb(Span<byte> src)
        {
            var v0 = dinx.load128(in src[0]);
            var v1 = dinx.load128(in src[16]);
            var v2 = dinx.load128(in src[2*16]);
            var v3 = dinx.load128(in src[3*16]);
            var v4 = dinx.load128(in src[4*16]);
            var v5 = dinx.load128(in src[5*16]);
            var v6 = dinx.load128(in src[6*16]);
            var v7 = dinx.load128(in src[7*16]);
            var v8 = dinx.load128(in src[8*16]);
            var v9 = dinx.load128(in src[9*16]);
            var v10 = dinx.load128(in src[10*16]);
            var v11 = dinx.load128(in src[11*16]);
            var v12 = dinx.load128(in src[12*16]);
            var v13 = dinx.load128(in src[13*16]);
            var v14 = dinx.load128(in src[14*16]);
            var v15 = dinx.load128(in src[15*16]);

            var a0 = Add(v0, v1);
            var a1 = Add(v2, v3);
            var a2 = Add(v4, v5);
            var a3 = Add(v6, v7);
            var a4 = Add(v8, v9);
            var a5 = Add(v10, v11);
            var a6 = Add(v12, v13);
            var a7 = Add(v14, v15);

            var b0 = Add(a0, a1);
            var b1 = Add(a2, a3);
            var b2 = Add(a3, a4);
            var b3 = Add(a4, a5);
            var b4 = Add(a6, a7);
        
            var c0 = Add(b0, b1);
            var c1 = Add(b2, b3);

            var d0 = Add(c0, c1);
            var d1 = Add(d0, b4);

            return d1;
            
        }

        public static Vector128<byte> vpaddb(
            in byte xmm0, in byte xmm1, in byte xmm2, in byte xmm3, 
            in byte xmm4, in byte xmm5, in byte xmm6, in byte xmm7,
            in byte xmm8, in byte xmm9, in byte xmm10, in byte xmm11,
            in byte xmm12, in byte xmm13, in byte xmm14, in byte xmm15            
            )
        {
            var v0 = dinx.load128(in xmm0);
            var v1 = dinx.load128(in xmm1);
            var v2 = dinx.load128(in xmm2);
            var v3 = dinx.load128(in xmm3);
            var v4 = dinx.load128(in xmm4);
            var v5 = dinx.load128(in xmm5);
            var v6 = dinx.load128(in xmm6);
            var v7 = dinx.load128(in xmm7);
            var v8 = dinx.load128(in xmm8);
            var v9 = dinx.load128(in xmm9);
            var v10 = dinx.load128(in xmm10);
            var v11 = dinx.load128(in xmm11);
            var v12 = dinx.load128(in xmm12);
            var v13 = dinx.load128(in xmm13);
            var v14 = dinx.load128(in xmm14);
            var v15 = dinx.load128(in xmm15);
            
            var a0 = Add(v0, v1);
            var a1 = Add(v2, v3);
            var a2 = Add(v4, v5);
            var a3 = Add(v6, v7);
            var a4 = Add(v8, v9);
            var a5 = Add(v10, v11);
            var a6 = Add(v12, v13);
            var a7 = Add(v14, v15);

            var b0 = Add(a0, a1);
            var b1 = Add(a2, a3);
            var b2 = Add(a3, a4);
            var b3 = Add(a4, a5);
            var b4 = Add(a6, a7);
        
            var c0 = Add(b0, b1);
            var c1 = Add(b2, b3);

            var d0 = Add(c0, c1);
            var d1 = Add(d0, b4);

            return d1;
        }

        #if No

        public static Vector256<byte> vpaddq(
            in byte ymm0, in byte ymm1, in byte ymm2, in byte ymm3, 
            in byte ymm4, in byte ymm5, in byte ymm6, in byte ymm7,
            in byte ymm8, in byte ymm9, in byte ymm10, in byte ymm11,
            in byte ymm12, in byte ymm13, in byte ymm14, in byte ymm15            
            )
        {
            var v0 = dinx.lddqu256(in ymm0);
            var v1 = dinx.lddqu256(in ymm1);
            var v2 = dinx.lddqu256(in ymm2);
            var v3 = dinx.lddqu256(in ymm3);
            var v4 = dinx.lddqu256(in ymm4);
            var v5 = dinx.lddqu256(in ymm5);
            var v6 = dinx.lddqu256(in ymm6);
            var v7 = dinx.lddqu256(in ymm7);
            var v8 = dinx.lddqu256(in ymm8);
            var v9 = dinx.lddqu256(in ymm9);
            var v10 = dinx.lddqu256(in ymm10);
            var v11 = dinx.lddqu256(in ymm11);
            var v12 = dinx.lddqu256(in ymm12);
            var v13 = dinx.lddqu256(in ymm13);
            var v14 = dinx.lddqu256(in ymm14);
            var v15 = dinx.lddqu256(in ymm15);
            
            var a0 = Add(v0, v1);
            var a1 = Add(v2, v3);
            var a2 = Add(v4, v5);
            var a3 = Add(v6, v7);
            var a4 = Add(v8, v9);
            var a5 = Add(v10, v11);
            var a6 = Add(v12, v13);
            var a7 = Add(v14, v15);

            var b0 = Add(a0, a1);
            var b1 = Add(a2, a3);
            var b2 = Add(a3, a4);
            var b3 = Add(a4, a5);
            var b4 = Add(a6, a7);
        
            var c0 = Add(b0, b1);
            var c1 = Add(b2, b3);

            var d0 = Add(c0, c1);
            var d1 = Add(d0, b4);

            return d1;
        }


        public static Vector256<ulong> vpaddq(
            in ulong ymm0, in ulong ymm1, in ulong ymm2, in ulong ymm3, 
            in ulong ymm4, in ulong ymm5, in ulong ymm6, in ulong ymm7,
            in ulong ymm8, in ulong ymm9, in ulong ymm10, in ulong ymm11,
            in ulong ymm12, in ulong ymm13, in ulong ymm14, in ulong ymm15            
            )
        {
            var v0 = dinx.lddqu256(in ymm0);
            var v1 = dinx.lddqu256(in ymm1);
            var v2 = dinx.lddqu256(in ymm2);
            var v3 = dinx.lddqu256(in ymm3);
            var v4 = dinx.lddqu256(in ymm4);
            var v5 = dinx.lddqu256(in ymm5);
            var v6 = dinx.lddqu256(in ymm6);
            var v7 = dinx.lddqu256(in ymm7);
            var v8 = dinx.lddqu256(in ymm8);
            var v9 = dinx.lddqu256(in ymm9);
            var v10 = dinx.lddqu256(in ymm10);
            var v11 = dinx.lddqu256(in ymm11);
            var v12 = dinx.lddqu256(in ymm12);
            var v13 = dinx.lddqu256(in ymm13);
            var v14 = dinx.lddqu256(in ymm14);
            var v15 = dinx.lddqu256(in ymm15);
            
            var a0 = Add(v0, v1);
            var a1 = Add(v2, v3);
            var a2 = Add(v4, v5);
            var a3 = Add(v6, v7);
            var a4 = Add(v8, v9);
            var a5 = Add(v10, v11);
            var a6 = Add(v12, v13);
            var a7 = Add(v14, v15);

            var b0 = Add(a0, a1);
            var b1 = Add(a2, a3);
            var b2 = Add(a3, a4);
            var b3 = Add(a4, a5);
            var b4 = Add(a6, a7);
        
            var c0 = Add(b0, b1);
            var c1 = Add(b2, b3);

            var d0 = Add(c0, c1);
            var d1 = Add(d0, b4);

            return d1;
        }
        #endif

        // public static Vector128<byte> add_128x8u_a(Vector128<byte> lhs, Vector128<byte> rhs)
        //     => Add(lhs, rhs);

        // public static Vec128<byte> add_128x8u_b(Vec128<byte> lhs, Vec128<byte> rhs)
        //     => Add(lhs.data, rhs.data);

        // public static bool testz_256x64u_a(Vector256<ulong> lhs, Vector256<ulong> rhs)
        //     => TestZ(lhs,rhs);        

        // public static bool testz_256x64u_b(Vec256<ulong> lhs, Vec256<ulong> rhs)
        //     => TestZ(lhs.data,rhs.data);        

        // public static Vector256<int> blend_256x32i(Vector256<int> ymm2, Vector256<int> ymm3, byte imm8)        
        //     => Blend(ymm2,ymm3,imm8);

        // public Vector256<long> bslli_256x64i(Vector256<long> src, byte count)
        //     => ShiftLeftLogical128BitLane(src, count);

        // public Vector256<ulong> bslli_256x64u(Vector256<ulong> src, byte count)
        //     => ShiftLeftLogical128BitLane(src, count); 

        // public Vector256<long> perm_256x64i(Vector256<long> value, byte control)
        //     => Permute4x64(value,control);

        // public Vector256<ulong> perm_256x64u(Vector256<ulong> value, byte control)
        //     => Permute4x64(value,control);

        // public Vector128<float> perm_128x32f(Vector128<float> value, byte control)
        //     => Permute(value, control);

        // public Vector128<double> perm_128x64f(Vector128<double> value, byte control)
        //     => Permute(value, control);

        // public Vector128<float> permvar_128x32f(Vector128<float> lhs, Vector128<int> control)
        //     => PermuteVar(lhs, control);


    //     [MethodImpl(NotInline)]
    //     public static Vector128<double> permvar_128x64f(Vector128<double> lhs, Vector128<long> control)
    //         => PermuteVar(lhs, control);

    //     [MethodImpl(NotInline)]
    //     public static Vector256<float> permvar_256x32f(Vector256<float> lhs, Vector256<int> control)
    //         => PermuteVar(lhs, control);

    //     [MethodImpl(NotInline)]
    //     public static Vector256<double> permvar_256x64f(Vector256<double> lhs, Vector256<long> control)
    //         => PermuteVar(lhs, control);

    //     [MethodImpl(NotInline)]
    //     public static Vector256<sbyte> permute2x128_8i(Vector256<sbyte> lhs, Vector256<sbyte> rhs, byte spec)
    //         => Permute2x128(lhs,rhs,spec);

    //     [MethodImpl(NotInline)]
    //     public static Vector256<byte> permute2x128_8u(Vector256<byte> lhs, Vector256<byte> rhs, byte spec)
    //         => Permute2x128(lhs,rhs,spec);

    //     [MethodImpl(NotInline)]
    //     public static Vector256<short> permute2x128_16i(Vector256<short> lhs, Vector256<short> rhs, byte spec)
    //         => Permute2x128(lhs,rhs,spec);

    //     [MethodImpl(NotInline)]
    //     public static Vector256<ushort> permute2x128_16u(Vector256<ushort> lhs, Vector256<ushort> rhs, byte spec)
    //         => Permute2x128(lhs,rhs,spec);

    //     [MethodImpl(NotInline)]
    //     public static Vector256<int> permute2x128_32i(Vector256<int> lhs, Vector256<int> rhs, byte spec)
    //         => Permute2x128(lhs,rhs,spec);

    //     [MethodImpl(NotInline)]
    //     public static Vector256<uint> permute2x128_32u(Vector256<uint> lhs, Vector256<uint> rhs, byte spec)
    //         => Permute2x128(lhs,rhs,spec);

    //     [MethodImpl(NotInline)]
    //     public static Vector256<long> permute2x128_64i(Vector256<long> lhs, Vector256<long> rhs, byte spec)
    //         => Permute2x128(lhs,rhs,spec);

    //     [MethodImpl(NotInline)]
    //     public static Vector256<ulong> permute2x128_64u(Vector256<ulong> lhs, Vector256<ulong> rhs, byte spec)
    //         => Permute2x128(lhs,rhs,spec);

    //     [MethodImpl(NotInline)]
    //     public static Vector256<float> permute2x128_32f(Vector256<float> lhs, Vector256<float> rhs, byte spec)
    //         => Permute2x128(lhs,rhs,spec);

    //     [MethodImpl(NotInline)]
    //     public static Vector256<double> perm_256x128_64f(Vector256<double> lhs, Vector256<double> rhs, byte spec)
    //         => Permute2x128(lhs,rhs,spec); 

    //     [MethodImpl(NotInline)]
    //     public static Vector256<int> permvar_256x8_32i(Vector256<int> src, Vector256<int> control)
    //         => PermuteVar8x32(src,control);

    //     [MethodImpl(NotInline)]
    //     public static Vector256<uint> permvar_256x8_32u(Vector256<uint> src, Vector256<uint> control)
    //         => PermuteVar8x32(src,control);

    //     [MethodImpl(NotInline)]
    //     public static Vector256<float> permvar_256x8_32f(Vector256<float> src, Vector256<int> control)
    //         => PermuteVar8x32(src,control);

    
    
    //     [MethodImpl(NotInline)]
    //     public static Vector256<double> perm_256x4_64d(Vector256<double> value, byte control)
    //         => Permute4x64(value,control);
 
    //     [MethodImpl(NotInline)]
    //     public static bool testz_128x8u(Vector128<byte> lhs, Vector128<byte> rhs)
    //         => TestZ(lhs,rhs);        

    //     [MethodImpl(NotInline)]
    //     public static bool testz_128x64i(Vector128<long> lhs, Vector128<long> rhs)
    //         => TestZ(lhs,rhs);        

    //     [MethodImpl(NotInline)]
    //     public static bool testz_128x64u(Vector128<ulong> lhs, Vector128<ulong> rhs)
    //         => TestZ(lhs,rhs);        

    //     [MethodImpl(NotInline)]
    //     public static bool testz_128x32f(Vector128<float> lhs, Vector128<float> rhs)
    //         => TestZ(lhs,rhs);        

    //     [MethodImpl(NotInline)]
    //     public static bool testz_128x64f(Vector128<double> lhs, Vector128<double> rhs)
    //         => TestZ(lhs,rhs);        

    //     [MethodImpl(NotInline)]
    //     public static bool testz_256x64i(Vector256<long> lhs, Vector256<long> rhs)
    //         => TestZ(lhs,rhs);        

    //     [MethodImpl(NotInline)]
    //     public static bool testz_256x64u(Vector256<ulong> lhs, Vector256<ulong> rhs)
    //         => TestZ(lhs,rhs);        

    //     [MethodImpl(NotInline)]
    //     public static bool testz_256x32f(Vector256<float> lhs, Vector256<float> rhs)
    //         => TestZ(lhs,rhs);        

    //    [MethodImpl(NotInline)]
    //    public static bool testz_256x64f(Vector256<double> lhs, Vector256<double> rhs)
    //         => TestZ(lhs,rhs);        

    }
}