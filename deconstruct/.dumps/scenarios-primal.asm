# 2019-07-29 03:15:51:289
7FFC79830DA0h sbyte add8i(sbyte x, sbyte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79830DB3h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79830DD0h sbyte add8i_In(in sbyte x, in sbyte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rcx]      ; MOVSX(Movsx_r64_rm8) [RAX,Memory]          encoding(4 bytes) = 48 0f be 01
0009h movsx rdx,byte ptr [rdx]      ; MOVSX(Movsx_r64_rm8) [RDX,Memory]          encoding(4 bytes) = 48 0f be 12
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79830DE3h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x01,0x48,0x0F,0xBE,0x12,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79830E00h ref sbyte add8i_Ref(ref sbyte x, in sbyte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rdx]      ; MOVSX(Movsx_r64_rm8) [RAX,Memory]          encoding(4 bytes) = 48 0f be 02
0009h add [rcx],al                  ; ADD(Add_rm8_r8) [Memory,AL]                encoding(2 bytes) = 00 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79830E0Eh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x02,0x00,0x01,0x48,0x8B,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79830E20h byte add8u(byte x, byte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79830E30h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x03,0xC2,0x0F,0xB6,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79830E50h byte add8u_In(in byte x, in byte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,Memory]          encoding(3 bytes) = 0f b6 01
0008h movzx edx,byte ptr [rdx]      ; MOVZX(Movzx_r32_rm8) [EDX,Memory]          encoding(3 bytes) = 0f b6 12
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79830E60h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x0F,0xB6,0x12,0x03,0xC2,0x0F,0xB6,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79830E80h ref byte add8u_Ref(ref byte x, in byte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rdx]      ; MOVZX(Movzx_r32_rm8) [EAX,Memory]          encoding(3 bytes) = 0f b6 02
0008h add [rcx],al                  ; ADD(Add_rm8_r8) [Memory,AL]                encoding(2 bytes) = 00 01
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000dh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79830E8Dh ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x02,0x00,0x01,0x48,0x8B,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79830EA0h short add16i(short x, short y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79830EB3h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79830ED0h short add16i_In(in short x, in short y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rcx]      ; MOVSX(Movsx_r64_rm16) [RAX,Memory]         encoding(4 bytes) = 48 0f bf 01
0009h movsx rdx,word ptr [rdx]      ; MOVSX(Movsx_r64_rm16) [RDX,Memory]         encoding(4 bytes) = 48 0f bf 12
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79830EE3h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x01,0x48,0x0F,0xBF,0x12,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79830F00h ref short add16i_Ref(ref short x, in short y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rdx]      ; MOVSX(Movsx_r64_rm16) [RAX,Memory]         encoding(4 bytes) = 48 0f bf 02
0009h add [rcx],ax                  ; ADD(Add_rm16_r16) [Memory,AX]              encoding(3 bytes) = 66 01 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79830F0Fh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x02,0x66,0x01,0x01,0x48,0x8B,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79830F20h ushort add16u(ushort x, ushort y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79830F30h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x03,0xC2,0x0F,0xB7,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79830F50h ushort add16u_In(in ushort x, in ushort y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,Memory]         encoding(3 bytes) = 0f b7 01
0008h movzx edx,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [EDX,Memory]         encoding(3 bytes) = 0f b7 12
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79830F60h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0x0F,0xB7,0x12,0x03,0xC2,0x0F,0xB7,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79830F80h ref ushort add16u_Ref(ref ushort x, in ushort y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [EAX,Memory]         encoding(3 bytes) = 0f b7 02
0008h add [rcx],ax                  ; ADD(Add_rm16_r16) [Memory,AX]              encoding(3 bytes) = 66 01 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79830F8Eh ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x02,0x66,0x01,0x01,0x48,0x8B,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79830FA0h int add32i(int x, int y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,Memory]                encoding(3 bytes) = 8d 04 11
0008h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79830FA8h ;{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79830FC0h int add32i_In(in int x, in int y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,Memory]             encoding(2 bytes) = 8b 01
0007h add eax,[rdx]                 ; ADD(Add_r32_rm32) [EAX,Memory]             encoding(2 bytes) = 03 02
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79830FC9h ;{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x03,0x02,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79830FE0h ref int add32i_Ref(ref int x, in int y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rdx]                 ; MOV(Mov_r32_rm32) [EAX,Memory]             encoding(2 bytes) = 8b 02
0007h add [rcx],eax                 ; ADD(Add_rm32_r32) [Memory,EAX]             encoding(2 bytes) = 01 01
0009h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000ch ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79830FECh ;{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x02,0x01,0x01,0x48,0x8B,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831000h uint add32u(uint x, uint y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,Memory]                encoding(3 bytes) = 8d 04 11
0008h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831008h ;{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831020h uint add32u_In(in uint x, in uint y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,Memory]             encoding(2 bytes) = 8b 01
0007h add eax,[rdx]                 ; ADD(Add_r32_rm32) [EAX,Memory]             encoding(2 bytes) = 03 02
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831029h ;{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x03,0x02,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831040h ref uint add32u_Ref(ref uint x, in uint y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rdx]                 ; MOV(Mov_r32_rm32) [EAX,Memory]             encoding(2 bytes) = 8b 02
0007h add [rcx],eax                 ; ADD(Add_rm32_r32) [Memory,EAX]             encoding(2 bytes) = 01 01
0009h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000ch ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC7983104Ch ;{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x02,0x01,0x01,0x48,0x8B,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831060h long add64i(long x, long y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,Memory]                encoding(4 bytes) = 48 8d 04 11
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831069h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831080h long add64i_In(in long x, in long y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,Memory]             encoding(3 bytes) = 48 8b 01
0008h add rax,[rdx]                 ; ADD(Add_r64_rm64) [RAX,Memory]             encoding(3 bytes) = 48 03 02
000bh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC7983108Bh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x03,0x02,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798310A0h ref long add64i_Ref(ref long x, in long y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,Memory]             encoding(3 bytes) = 48 8b 02
0008h add [rcx],rax                 ; ADD(Add_rm64_r64) [Memory,RAX]             encoding(3 bytes) = 48 01 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798310AEh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x01,0x01,0x48,0x8B,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798310C0h ulong add64u(ulong x, ulong y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,Memory]                encoding(4 bytes) = 48 8d 04 11
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798310C9h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798310E0h ulong add64u_In(in ulong x, in ulong y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,Memory]             encoding(3 bytes) = 48 8b 01
0008h add rax,[rdx]                 ; ADD(Add_r64_rm64) [RAX,Memory]             encoding(3 bytes) = 48 03 02
000bh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798310EBh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x03,0x02,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831100h ref ulong add64u_Ref(ref ulong x, in ulong y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,Memory]             encoding(3 bytes) = 48 8b 02
0008h add [rcx],rax                 ; ADD(Add_rm64_r64) [Memory,RAX]             encoding(3 bytes) = 48 01 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC7983110Eh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x01,0x01,0x48,0x8B,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831120h float add32f(float x, float y)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vaddss xmm0,xmm0,xmm1         ; VADDSS(VEX_Vaddss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fa 58 c1
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831129h ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x58,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831140h double add64f(double x, double y)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vaddsd xmm0,xmm0,xmm1         ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fb 58 c1
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831149h ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x58,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831160h double add64f_In(in double x, in double y)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,Memory]   encoding(VEX, 4 bytes) = c5 fb 10 01
0009h vaddsd xmm0,xmm0,qword ptr [rdx]; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,Memory] encoding(VEX, 4 bytes) = c5 fb 58 02
000dh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC7983116Dh ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x01,0xC5,0xFB,0x58,0x02,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831180h ref double add64f_Ref(ref double x, in double y)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,Memory]   encoding(VEX, 4 bytes) = c5 fb 10 01
0009h vaddsd xmm0,xmm0,qword ptr [rdx]; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,Memory] encoding(VEX, 4 bytes) = c5 fb 58 02
000dh vmovsd qword ptr [rcx],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [Memory,XMM0]   encoding(VEX, 4 bytes) = c5 fb 11 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831194h ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x01,0xC5,0xFB,0x58,0x02,0xC5,0xFB,0x11,0x01,0x48,0x8B,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798311B0h float add32f_In(in float x, in float y)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,Memory]   encoding(VEX, 4 bytes) = c5 fa 10 01
0009h vaddss xmm0,xmm0,dword ptr [rdx]; VADDSS(VEX_Vaddss_xmm_xmm_xmmm32) [XMM0,XMM0,Memory] encoding(VEX, 4 bytes) = c5 fa 58 02
000dh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798311BDh ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x01,0xC5,0xFA,0x58,0x02,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798311D0h ref float add32f_Ref(ref float x, in float y)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,Memory]   encoding(VEX, 4 bytes) = c5 fa 10 01
0009h vaddss xmm0,xmm0,dword ptr [rdx]; VADDSS(VEX_Vaddss_xmm_xmm_xmmm32) [XMM0,XMM0,Memory] encoding(VEX, 4 bytes) = c5 fa 58 02
000dh vmovss dword ptr [rcx],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [Memory,XMM0]   encoding(VEX, 4 bytes) = c5 fa 11 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798311E4h ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x01,0xC5,0xFA,0x58,0x02,0xC5,0xFA,0x11,0x01,0x48,0x8B,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831200h sbyte add8ix3(sbyte x, sbyte y, sbyte z)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000fh movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]             encoding(4 bytes) = 49 0f be d0
0013h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
0015h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0019h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831219h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x03,0xC2,0x49,0x0F,0xBE,0xD0,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831230h byte add8ux3(byte x, byte y, byte z)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000dh movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]             encoding(4 bytes) = 41 0f b6 d0
0011h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831246h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x03,0xC2,0x41,0x0F,0xB6,0xD0,0x03,0xC2,0x0F,0xB6,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831260h short add16ix3(short x, short y, short z)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000fh movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]            encoding(4 bytes) = 49 0f bf d0
0013h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
0015h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0019h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831279h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x03,0xC2,0x49,0x0F,0xBF,0xD0,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831290h ushort add16ux3(ushort x, ushort y, ushort z)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000dh movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]            encoding(4 bytes) = 41 0f b7 d0
0011h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
0013h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0016h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798312A6h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x03,0xC2,0x41,0x0F,0xB7,0xD0,0x03,0xC2,0x0F,0xB7,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798312C0h int add32ix3(int x, int y, int z)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,Memory]                encoding(3 bytes) = 8d 04 11
0008h add eax,r8d                   ; ADD(Add_r32_rm32) [EAX,R8D]                encoding(3 bytes) = 41 03 c0
000bh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798312CBh ;{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0x41,0x03,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798312E0h uint add32ux3(uint x, uint y, uint z)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,Memory]                encoding(3 bytes) = 8d 04 11
0008h add eax,r8d                   ; ADD(Add_r32_rm32) [EAX,R8D]                encoding(3 bytes) = 41 03 c0
000bh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798312EBh ;{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0x41,0x03,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831300h long add64ix3(long x, long y, long z)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,Memory]                encoding(4 bytes) = 48 8d 04 11
0009h add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                 encoding(3 bytes) = 49 03 c0
000ch ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC7983130Ch ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0x49,0x03,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831320h ulong add64ux3(ulong x, ulong y, ulong z)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,Memory]                encoding(4 bytes) = 48 8d 04 11
0009h add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                 encoding(3 bytes) = 49 03 c0
000ch ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC7983132Ch ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0x49,0x03,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831340h float add32fx3(float x, float y, float z)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vaddss xmm0,xmm0,xmm1         ; VADDSS(VEX_Vaddss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fa 58 c1
0009h vaddss xmm0,xmm0,xmm2         ; VADDSS(VEX_Vaddss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM2] encoding(VEX, 4 bytes) = c5 fa 58 c2
000dh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC7983134Dh ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x58,0xC1,0xC5,0xFA,0x58,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831360h double add64fx3(double x, double y, double z)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vaddsd xmm0,xmm0,xmm1         ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fb 58 c1
0009h vaddsd xmm0,xmm0,xmm2         ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM2] encoding(VEX, 4 bytes) = c5 fb 58 c2
000dh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC7983136Dh ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x58,0xC1,0xC5,0xFB,0x58,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831380h byte and8u(byte x, byte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831390h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798313B0h sbyte and8i(sbyte x, sbyte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798313C3h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x23,0xC2,0x48,0x0F,0xBE,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798313E0h short and16i(short x, short y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798313F3h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x23,0xC2,0x48,0x0F,0xBF,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831410h ushort and16u(ushort x, ushort y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831420h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x23,0xC2,0x0F,0xB7,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831440h int and32i(int x, int y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831449h ;{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831460h uint and32u(uint x, uint y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831469h ;{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831480h long and64i(long x, long y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 23 c2
000bh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC7983148Bh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798314A0h ulong and64u(ulong x, ulong y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 23 c2
000bh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798314ABh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798314C0h sbyte div8i(sbyte x, sbyte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rcx,dl                  ; MOVSX(Movsx_r64_rm8) [RCX,DL]              encoding(4 bytes) = 48 0f be ca
000dh cdq                           ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0010h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0014h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798314D4h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798314F0h byte div8u(byte x, byte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh cdq                           ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831501h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x99,0xF7,0xF9,0x0F,0xB6,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831520h short div16i(short x, short y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rcx,dx                  ; MOVSX(Movsx_r64_rm16) [RCX,DX]             encoding(4 bytes) = 48 0f bf ca
000dh cdq                           ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0010h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0014h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831534h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBF,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831550h ushort div16u(ushort x, ushort y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]             encoding(3 bytes) = 0f b7 ca
000bh cdq                           ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
000eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0011h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831561h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0x99,0xF7,0xF9,0x0F,0xB7,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831580h int div32i(int x, int y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
000ah cdq                           ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000bh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                      encoding(3 bytes) = 41 f7 f8
000eh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC7983158Eh ;{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798315A0h uint div32u(uint x, uint y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
000ch div r8d                       ; DIV(Div_rm32) [R8D]                        encoding(3 bytes) = 41 f7 f0
000fh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798315AFh ;{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798315C0h long div64i(long x, long y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                 encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh cqo                           ; CQO(Cqo)                                   encoding(2 bytes) = 48 99
000dh idiv r8                       ; IDIV(Idiv_rm64) [R8]                       encoding(3 bytes) = 49 f7 f8
0010h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798315D0h ;{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798315F0h ulong div64u(ulong x, ulong y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                 encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
000dh div r8                        ; DIV(Div_rm64) [R8]                         encoding(3 bytes) = 49 f7 f0
0010h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831600h ;{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831620h float div32f(float x, float y)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vdivss xmm0,xmm0,xmm1         ; VDIVSS(VEX_Vdivss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fa 5e c1
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831629h ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x5E,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831640h double div64f(double x, double y)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vdivsd xmm0,xmm0,xmm1         ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fb 5e c1
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831649h ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x5E,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831660h sbyte mul8i(sbyte x, sbyte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
0010h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0014h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831674h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0F,0xAF,0xC2,0x48,0x0F,0xBE,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831690h byte mul8u(byte x, byte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798316A1h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798316C0h short mul16i(short x, short y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
0010h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0014h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798316D4h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0F,0xAF,0xC2,0x48,0x0F,0xBF,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798316F0h ushort mul16u(ushort x, ushort y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0011h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831701h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xAF,0xC2,0x0F,0xB7,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831720h int mul32i(int x, int y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000ah ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC7983172Ah ;{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831740h uint mul32u(uint x, uint y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000ah ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC7983174Ah ;{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831760h long mul64i(long x, long y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]              encoding(4 bytes) = 48 0f af c2
000ch ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC7983176Ch ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831780h ulong mul64u(ulong x, ulong y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]              encoding(4 bytes) = 48 0f af c2
000ch ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC7983178Ch ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798317A0h float mul32f(float x, float y)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmulss xmm0,xmm0,xmm1         ; VMULSS(VEX_Vmulss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fa 59 c1
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798317A9h ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x59,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798317C0h double mul64f(double x, double y)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmulsd xmm0,xmm0,xmm1         ; VMULSD(VEX_Vmulsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fb 59 c1
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798317C9h ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x59,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798317E0h sbyte mod8i(sbyte x, sbyte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rcx,dl                  ; MOVSX(Movsx_r64_rm8) [RCX,DL]              encoding(4 bytes) = 48 0f be ca
000dh cdq                           ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0010h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]              encoding(4 bytes) = 48 0f be c2
0014h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798317F4h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831810h byte mod8u(byte x, byte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh cdq                           ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
000eh movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0011h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831821h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x99,0xF7,0xF9,0x0F,0xB6,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831840h short mod16i(short x, short y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rcx,dx                  ; MOVSX(Movsx_r64_rm16) [RCX,DX]             encoding(4 bytes) = 48 0f bf ca
000dh cdq                           ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0010h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]             encoding(4 bytes) = 48 0f bf c2
0014h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831854h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBF,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831870h ushort mod16u(ushort x, ushort y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]             encoding(3 bytes) = 0f b7 ca
000bh cdq                           ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
000eh movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]             encoding(3 bytes) = 0f b7 c2
0011h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831881h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0x99,0xF7,0xF9,0x0F,0xB7,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798318A0h int mod32i(int x, int y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
000ah cdq                           ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000bh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                      encoding(3 bytes) = 41 f7 f8
000eh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0010h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798318B0h ;{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0x8B,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798318D0h uint mod32u(uint x, uint y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
000ch div r8d                       ; DIV(Div_rm32) [R8D]                        encoding(3 bytes) = 41 f7 f0
000fh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0011h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798318E1h ;{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0x8B,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831900h long mod64i(long x, long y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                 encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh cqo                           ; CQO(Cqo)                                   encoding(2 bytes) = 48 99
000dh idiv r8                       ; IDIV(Idiv_rm64) [R8]                       encoding(3 bytes) = 49 f7 f8
0010h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0013h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831913h ;{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0x48,0x8B,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831930h ulong mod64u(ulong x, ulong y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                 encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
000dh div r8                        ; DIV(Div_rm64) [R8]                         encoding(3 bytes) = 49 f7 f0
0010h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0013h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831943h ;{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0x48,0x8B,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831960h float mod32f(float x, float y)
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FFCD8EF3690h            ; CALL(Call_rel32_64) [NearBranch64]         encoding(5 bytes) = e8 24 1d 6c 5f
000ch nop                           ; NOP(Nopd)                                  encoding(1 byte ) = 90
000dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0011h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831971h ;{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0x24,0x1D,0x6C,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831990h double mod64f(double x, double y)
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FFCD8EF3600h            ; CALL(Call_rel32_64) [NearBranch64]         encoding(5 bytes) = e8 64 1c 6c 5f
000ch nop                           ; NOP(Nopd)                                  encoding(1 byte ) = 90
000dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0011h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798319A1h ;{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0x64,0x1C,0x6C,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798319C0h byte or8u(byte x, byte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798319D0h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798319F0h sbyte or8i(sbyte x, sbyte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831A03h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831A20h short or16i(short x, short y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831A33h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831A50h ushort or16u(ushort x, ushort y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831A60h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831A80h int or32i(int x, int y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831A89h ;{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831AA0h uint or32u(uint x, uint y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831AA9h ;{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831AC0h long or64i(long x, long y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                  encoding(3 bytes) = 48 0b c2
000bh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831ACBh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831AE0h ulong or64u(ulong x, ulong y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                  encoding(3 bytes) = 48 0b c2
000bh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831AEBh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831B00h sbyte sub8i(sbyte x, sbyte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 2b c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831B13h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x2B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831B30h byte sub8u(byte x, byte y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 2b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831B40h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x2B,0xC2,0x0F,0xB6,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831B60h short sub16i(short x, short y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 2b c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831B73h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x2B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831B90h ushort sub16u(ushort x, ushort y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 2b c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831BA0h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x2B,0xC2,0x0F,0xB7,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831BC0h int sub32i(int x, int y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 2b c2
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831BC9h ;{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x2B,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831BE0h uint sub32u(uint x, uint y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 2b c2
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831BE9h ;{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x2B,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831C00h long sub64i(long x, long y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 2b c2
000bh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831C0Bh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831C20h ulong sub64u(ulong x, ulong y)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 2b c2
000bh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831C2Bh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831C40h float sub32f(float x, float y)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vsubss xmm0,xmm0,xmm1         ; VSUBSS(VEX_Vsubss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fa 5c c1
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831C49h ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x5C,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831C60h double sub64f(double x, double y)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vsubsd xmm0,xmm0,xmm1         ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fb 5c c1
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831C69h ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x5C,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831C80h sbyte negate(sbyte src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                        encoding(2 bytes) = f7 d8
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831C8Fh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD8,0x48,0x0F,0xBE,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831CA0h byte negate(byte src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831CAFh ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831CC0h short negate(short src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                        encoding(2 bytes) = f7 d8
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831CCFh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD8,0x48,0x0F,0xBF,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831CE0h ushort negate(ushort src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831CEFh ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831D00h int negate(int src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h neg eax                       ; NEG(Neg_rm32) [EAX]                        encoding(2 bytes) = f7 d8
0009h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831D09h ;{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD8,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831D20h uint negate(uint src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831D2Bh ;{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831D40h long negate(long src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h neg rax                       ; NEG(Neg_rm64) [RAX]                        encoding(3 bytes) = 48 f7 d8
000bh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831D4Bh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD8,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831D60h ulong negate(ulong src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                        encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                        encoding(3 bytes) = 48 ff c0
000eh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831D6Eh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831D80h float negate(float src)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovss xmm1,dword ptr [7FFC79831D98h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,Memory] encoding(VEX, 8 bytes) = c5 fa 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831D91h ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831DB0h double negate(double src)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovsd xmm1,qword ptr [7FFC79831DC8h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,Memory] encoding(VEX, 8 bytes) = c5 fb 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831DC1h ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831DE0h sbyte inc(sbyte src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
000dh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831DEDh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831E00h byte inc(byte src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000bh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831E0Bh ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831E20h short inc(short src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
000dh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831E2Dh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831E40h ushort inc(ushort src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000bh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831E4Bh ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xC0,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831E60h int inc(int src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831E67h ;{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831E80h uint inc(uint src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831E87h ;{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831EA0h long inc(long src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831EA8h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831EC0h ulong inc(ulong src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831EC8h ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831EE0h float inc(float src)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831EE5h ;{0xC5,0xF8,0x77,0x66,0x90,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79831F00h double inc(double src)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79831F05h ;{0xC5,0xF8,0x77,0x66,0x90,0xC3}
------------------------------------------------------------------------------------------------------------------------
