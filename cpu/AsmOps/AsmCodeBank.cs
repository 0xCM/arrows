//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;


    public static class AsmCodeBank
    {
        /// <summary>
        /// Specifies the code for uint8 addition
        /// </summary>
        public static AsmCode And8U
        {
            [MethodImpl(Inline)]
            get => AddUInt8Bytes;
        }

        /// <summary>
        /// Specifies the code for uint8 addition
        /// </summary>
        public static AsmCode And8I
        {
            [MethodImpl(Inline)]
            get => AddInt8Bytes;
        }

        /// <summary>
        /// Specifies the code for int32 addition
        /// </summary>
        public static AsmCode Add32I
        {
            [MethodImpl(Inline)]
            get => AddInt32Bytes;
        }

        /// <summary>
        /// Specifies the implementation for: 
        /// void divrem32i(int x, int y, byref Int32 q, byref Int32 r); 
        /// </summary>
        public static AsmCode DivRemI32
        {
            [MethodImpl(Inline)]
            get => DivRemI32Bytes;
        }

        static ReadOnlySpan<byte> AddInt32Bytes
            => new byte[]{0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8d, 0x04, 0x11, 0xc3};

        static ReadOnlySpan<byte> AddUInt8Bytes
            => new byte[]{0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xd2, 0x23, 0xc2, 0x0f, 0xb6, 0xc0, 0xc3};

        static ReadOnlySpan<byte> AddInt8Bytes
            => new byte[]{0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xd2, 0x23, 0xc2, 0x48, 0x0f, 0xbe, 0xc0, 0xc3};

        static ReadOnlySpan<byte> DivRemI32Bytes
            => new byte[]{0x0f,0x1f,0x44,0x00,0x00,0x44,0x8b,0xd2,0x8b,0xc1,0x99,0x41,0xf7,0xfa,0x41,0x89,0x00,0x41,0x89,0x11,0xc3};
    }

/*
    
void divrem32i(int x, int y, byref Int32 q, byref Int32 r); 
{0f,1f,44,00,00,44,8b,d2,8b,c1,99,41,f7,fa,41,89,00,41,89,11,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r10d,edx                  ; Mov | Mov_r32_rm32 | encoding() = 44 8b d2 (3 bytes)
0008h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
000ah cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000bh idiv r10d                     ; Idiv | Idiv_rm32 | encoding() = 41 f7 fa (3 bytes)
000eh mov [r8],eax                  ; Mov | Mov_rm32_r32 | encoding() = 41 89 00 (3 bytes)
0017h mov [r9],edx                  ; Mov | Mov_rm32_r32 | encoding() = 41 89 11 (3 bytes)
001ah ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

*/

}