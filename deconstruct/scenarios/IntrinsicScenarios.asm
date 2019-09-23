; 2019-09-22 20:42:17:667
; function: Vector256<long> perm_256x64i(Vector256<long> ymm0, byte imm8)
; location: [7FFC89B945C0h, 7FFC89B945F1h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,50h                   ; SUB(Sub_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 ec 50
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0012h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0018h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h call 7FFC8958A120h            ; CALL(Call_rel32_64) [FFFFFFFFFF9F5B60h:jmp64]        encoding(5 bytes) = e8 3a 5b 9f ff
0026h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0029h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002ch add rsp,50h                   ; ADD(Add_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 c4 50
0030h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> perm_256x64iBytes => new byte[50]{0x56,0x48,0x83,0xEC,0x50,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0x3A,0x5B,0x9F,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x50,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte project1(byte src, uint part)
; location: [7FFC89B96170h, 7FFC89B96189h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
000ch movzx edx,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 08
0011h pdep eax,edx,eax              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EDX,EAX]            encoding(VEX, 5 bytes) = c4 e2 6b f5 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> project1Bytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x0F,0xB6,0xC2,0x0F,0xB6,0x54,0x24,0x08,0xC4,0xE2,0x6B,0xF5,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte project2(uint src, uint part)
; location: [7FFC89B961A0h, 7FFC89B961ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> project2Bytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project3(uint src, uint part)
; location: [7FFC89B961C0h, 7FFC89B961CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> project3Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project4(uint src, uint part)
; location: [7FFC89B961E0h, 7FFC89B961EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> project4Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: PseudoByte project5(PseudoByte src, uint part)
; location: [7FFC89B96200h, 7FFC89B9620Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> project5Bytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: PseudoByte project6(PseudoByte src, uint part)
; location: [7FFC89B96220h, 7FFC89B9622Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> project6Bytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project7(uint src, uint part)
; location: [7FFC89B96240h, 7FFC89B9624Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> project7Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vpxor(in byte ymm0, in byte ymm1, in byte ymm2, in byte ymm3)
; location: [7FFC89B96260h, 7FFC89B96292h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovdqa ymm0,ymmword ptr [rdx]; VMOVDQA(VEX_Vmovdqa_ymm_ymmm256) [YMM0,mem(Packed256_Int32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 6f 02
0009h vmovdqa ymm1,ymmword ptr [r8] ; VMOVDQA(VEX_Vmovdqa_ymm_ymmm256) [YMM1,mem(Packed256_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 6f 08
000eh vmovdqa ymm2,ymmword ptr [r9] ; VMOVDQA(VEX_Vmovdqa_ymm_ymmm256) [YMM2,mem(Packed256_Int32,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 6f 11
0013h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
0018h vmovdqa ymm3,ymmword ptr [rax]; VMOVDQA(VEX_Vmovdqa_ymm_ymmm256) [YMM3,mem(Packed256_Int32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 6f 18
001ch vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0020h vpxor ymm1,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef cb
0024h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0028h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpxorBytes => new byte[51]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x6F,0x02,0xC4,0xC1,0x7D,0x6F,0x08,0xC4,0xC1,0x7D,0x6F,0x11,0x48,0x8B,0x44,0x24,0x28,0xC5,0xFD,0x6F,0x18,0xC5,0xFD,0xEF,0xC1,0xC5,0xED,0xEF,0xCB,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<int> blend_256x32i(in int ymm0, int ymm1, byte imm8)
; location: [7FFC89B962B0h, 7FFC89B96325h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,90h                   ; SUB(Sub_rm64_imm32) [RSP,90h:imm64]                  encoding(7 bytes) = 48 81 ec 90 00 00 00
0008h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000bh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000dh mov [rsp+60h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 60
0012h mov [rsp+68h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 68
0017h mov [rsp+70h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 70
001ch mov [rsp+78h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 78
0021h mov [rsp+0B0h],r8d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(8 bytes) = 44 89 84 24 b0 00 00 00
0029h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
002ch vmovdqa ymm0,ymmword ptr [rdx]; VMOVDQA(VEX_Vmovdqa_ymm_ymmm256) [YMM0,mem(Packed256_Int32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 6f 02
0030h vmovdqa ymm1,ymmword ptr [rsp+0B0h]; VMOVDQA(VEX_Vmovdqa_ymm_ymmm256) [YMM1,mem(Packed256_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 6f 8c 24 b0 00 00 00
0039h lea rcx,[rsp+60h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 60
003eh vmovupd [rsp+40h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 40
0044h vmovupd [rsp+20h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 20
004ah lea rdx,[rsp+40h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 40
004fh lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
0054h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0058h call 7FFC8958AA00h            ; CALL(Call_rel32_64) [FFFFFFFFFF9F4750h:jmp64]        encoding(5 bytes) = e8 f3 46 9f ff
005dh vmovupd ymm0,[rsp+60h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 60
0063h vmovupd [rsi],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSI:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 06
0067h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
006ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
006dh add rsp,90h                   ; ADD(Add_rm64_imm32) [RSP,90h:imm64]                  encoding(7 bytes) = 48 81 c4 90 00 00 00
0074h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0075h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blend_256x32iBytes => new byte[118]{0x56,0x48,0x81,0xEC,0x90,0x00,0x00,0x00,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x60,0x48,0x89,0x44,0x24,0x68,0x48,0x89,0x44,0x24,0x70,0x48,0x89,0x44,0x24,0x78,0x44,0x89,0x84,0x24,0xB0,0x00,0x00,0x00,0x48,0x8B,0xF1,0xC5,0xFD,0x6F,0x02,0xC5,0xFD,0x6F,0x8C,0x24,0xB0,0x00,0x00,0x00,0x48,0x8D,0x4C,0x24,0x60,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0xF3,0x46,0x9F,0xFF,0xC5,0xFD,0x10,0x44,0x24,0x60,0xC5,0xFD,0x11,0x06,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x81,0xC4,0x90,0x00,0x00,0x00,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vpaddb(Span<byte> src)
; location: [7FFC89B96350h, 7FFC89B96599h]
0000h sub rsp,0C8h                  ; SUB(Sub_rm64_imm32) [RSP,c8h:imm64]                  encoding(7 bytes) = 48 81 ec c8 00 00 00
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah vmovaps [rsp+0B0h],xmm6       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM6] encoding(VEX, 9 bytes) = c5 f8 29 b4 24 b0 00 00 00
0013h vmovaps [rsp+0A0h],xmm7       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM7] encoding(VEX, 9 bytes) = c5 f8 29 bc 24 a0 00 00 00
001ch vmovaps [rsp+90h],xmm8        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM8] encoding(VEX, 9 bytes) = c5 78 29 84 24 90 00 00 00
0025h vmovaps [rsp+80h],xmm9        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM9] encoding(VEX, 9 bytes) = c5 78 29 8c 24 80 00 00 00
002eh vmovaps [rsp+70h],xmm10       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM10] encoding(VEX, 6 bytes) = c5 78 29 54 24 70
0034h vmovaps [rsp+60h],xmm11       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM11] encoding(VEX, 6 bytes) = c5 78 29 5c 24 60
003ah vmovaps [rsp+50h],xmm12       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM12] encoding(VEX, 6 bytes) = c5 78 29 64 24 50
0040h vmovaps [rsp+40h],xmm13       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM13] encoding(VEX, 6 bytes) = c5 78 29 6c 24 40
0046h vmovaps [rsp+30h],xmm14       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM14] encoding(VEX, 6 bytes) = c5 78 29 74 24 30
004ch vmovaps [rsp+20h],xmm15       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM15] encoding(VEX, 6 bytes) = c5 78 29 7c 24 20
0052h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0055h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0058h cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
005bh jbe near ptr 0244h            ; JBE(Jbe_rel32_64) [244h:jmp64]                       encoding(6 bytes) = 0f 86 e3 01 00 00
0061h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0064h vmovdqa xmm0,xmmword ptr [r8] ; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM0,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 6f 00
0069h cmp edx,10h                   ; CMP(Cmp_rm32_imm8) [EDX,10h:imm32]                   encoding(3 bytes) = 83 fa 10
006ch jbe near ptr 0244h            ; JBE(Jbe_rel32_64) [244h:jmp64]                       encoding(6 bytes) = 0f 86 d2 01 00 00
0072h lea r8,[rax+10h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 10
0076h vmovdqa xmm1,xmmword ptr [r8] ; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM1,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 6f 08
007bh cmp edx,20h                   ; CMP(Cmp_rm32_imm8) [EDX,20h:imm32]                   encoding(3 bytes) = 83 fa 20
007eh jbe near ptr 0244h            ; JBE(Jbe_rel32_64) [244h:jmp64]                       encoding(6 bytes) = 0f 86 c0 01 00 00
0084h lea r8,[rax+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 20
0088h vmovdqa xmm2,xmmword ptr [r8] ; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM2,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 6f 10
008dh cmp edx,30h                   ; CMP(Cmp_rm32_imm8) [EDX,30h:imm32]                   encoding(3 bytes) = 83 fa 30
0090h jbe near ptr 0244h            ; JBE(Jbe_rel32_64) [244h:jmp64]                       encoding(6 bytes) = 0f 86 ae 01 00 00
0096h lea r8,[rax+30h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 30
009ah vmovdqa xmm3,xmmword ptr [r8] ; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM3,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 6f 18
009fh cmp edx,40h                   ; CMP(Cmp_rm32_imm8) [EDX,40h:imm32]                   encoding(3 bytes) = 83 fa 40
00a2h jbe near ptr 0244h            ; JBE(Jbe_rel32_64) [244h:jmp64]                       encoding(6 bytes) = 0f 86 9c 01 00 00
00a8h lea r8,[rax+40h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 40
00ach vmovdqa xmm4,xmmword ptr [r8] ; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM4,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 6f 20
00b1h cmp edx,50h                   ; CMP(Cmp_rm32_imm8) [EDX,50h:imm32]                   encoding(3 bytes) = 83 fa 50
00b4h jbe near ptr 0244h            ; JBE(Jbe_rel32_64) [244h:jmp64]                       encoding(6 bytes) = 0f 86 8a 01 00 00
00bah lea r8,[rax+50h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 50
00beh vmovdqa xmm5,xmmword ptr [r8] ; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM5,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 6f 28
00c3h cmp edx,60h                   ; CMP(Cmp_rm32_imm8) [EDX,60h:imm32]                   encoding(3 bytes) = 83 fa 60
00c6h jbe near ptr 0244h            ; JBE(Jbe_rel32_64) [244h:jmp64]                       encoding(6 bytes) = 0f 86 78 01 00 00
00cch lea r8,[rax+60h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 60
00d0h vmovdqa xmm6,xmmword ptr [r8] ; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM6,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 6f 30
00d5h cmp edx,70h                   ; CMP(Cmp_rm32_imm8) [EDX,70h:imm32]                   encoding(3 bytes) = 83 fa 70
00d8h jbe near ptr 0244h            ; JBE(Jbe_rel32_64) [244h:jmp64]                       encoding(6 bytes) = 0f 86 66 01 00 00
00deh lea r8,[rax+70h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 70
00e2h vmovdqa xmm7,xmmword ptr [r8] ; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM7,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 6f 38
00e7h cmp edx,80h                   ; CMP(Cmp_rm32_imm32) [EDX,80h:imm32]                  encoding(6 bytes) = 81 fa 80 00 00 00
00edh jbe near ptr 0244h            ; JBE(Jbe_rel32_64) [244h:jmp64]                       encoding(6 bytes) = 0f 86 51 01 00 00
00f3h lea r8,[rax+80h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(7 bytes) = 4c 8d 80 80 00 00 00
00fah vmovdqa xmm8,xmmword ptr [r8] ; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM8,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 41 79 6f 00
00ffh cmp edx,90h                   ; CMP(Cmp_rm32_imm32) [EDX,90h:imm32]                  encoding(6 bytes) = 81 fa 90 00 00 00
0105h jbe near ptr 0244h            ; JBE(Jbe_rel32_64) [244h:jmp64]                       encoding(6 bytes) = 0f 86 39 01 00 00
010bh lea r8,[rax+90h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(7 bytes) = 4c 8d 80 90 00 00 00
0112h vmovdqa xmm9,xmmword ptr [r8] ; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM9,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 41 79 6f 08
0117h cmp edx,0A0h                  ; CMP(Cmp_rm32_imm32) [EDX,a0h:imm32]                  encoding(6 bytes) = 81 fa a0 00 00 00
011dh jbe near ptr 0244h            ; JBE(Jbe_rel32_64) [244h:jmp64]                       encoding(6 bytes) = 0f 86 21 01 00 00
0123h lea r8,[rax+0A0h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(7 bytes) = 4c 8d 80 a0 00 00 00
012ah vmovdqa xmm10,xmmword ptr [r8]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM10,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 41 79 6f 10
012fh cmp edx,0B0h                  ; CMP(Cmp_rm32_imm32) [EDX,b0h:imm32]                  encoding(6 bytes) = 81 fa b0 00 00 00
0135h jbe near ptr 0244h            ; JBE(Jbe_rel32_64) [244h:jmp64]                       encoding(6 bytes) = 0f 86 09 01 00 00
013bh lea r8,[rax+0B0h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(7 bytes) = 4c 8d 80 b0 00 00 00
0142h vmovdqa xmm11,xmmword ptr [r8]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM11,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 41 79 6f 18
0147h cmp edx,0C0h                  ; CMP(Cmp_rm32_imm32) [EDX,c0h:imm32]                  encoding(6 bytes) = 81 fa c0 00 00 00
014dh jbe near ptr 0244h            ; JBE(Jbe_rel32_64) [244h:jmp64]                       encoding(6 bytes) = 0f 86 f1 00 00 00
0153h lea r8,[rax+0C0h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(7 bytes) = 4c 8d 80 c0 00 00 00
015ah vmovdqa xmm12,xmmword ptr [r8]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM12,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 41 79 6f 20
015fh cmp edx,0D0h                  ; CMP(Cmp_rm32_imm32) [EDX,d0h:imm32]                  encoding(6 bytes) = 81 fa d0 00 00 00
0165h jbe near ptr 0244h            ; JBE(Jbe_rel32_64) [244h:jmp64]                       encoding(6 bytes) = 0f 86 d9 00 00 00
016bh lea r8,[rax+0D0h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(7 bytes) = 4c 8d 80 d0 00 00 00
0172h vmovdqa xmm13,xmmword ptr [r8]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM13,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 41 79 6f 28
0177h cmp edx,0E0h                  ; CMP(Cmp_rm32_imm32) [EDX,e0h:imm32]                  encoding(6 bytes) = 81 fa e0 00 00 00
017dh jbe near ptr 0244h            ; JBE(Jbe_rel32_64) [244h:jmp64]                       encoding(6 bytes) = 0f 86 c1 00 00 00
0183h lea r8,[rax+0E0h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(7 bytes) = 4c 8d 80 e0 00 00 00
018ah vmovdqa xmm14,xmmword ptr [r8]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM14,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 41 79 6f 30
018fh cmp edx,0F0h                  ; CMP(Cmp_rm32_imm32) [EDX,f0h:imm32]                  encoding(6 bytes) = 81 fa f0 00 00 00
0195h jbe near ptr 0244h            ; JBE(Jbe_rel32_64) [244h:jmp64]                       encoding(6 bytes) = 0f 86 a9 00 00 00
019bh add rax,0F0h                  ; ADD(Add_RAX_imm32) [RAX,f0h:imm64]                   encoding(6 bytes) = 48 05 f0 00 00 00
01a1h vmovdqa xmm15,xmmword ptr [rax]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM15,mem(Packed128_Int32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 79 6f 38
01a5h vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
01a9h vpaddb xmm1,xmm2,xmm3         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM1,XMM2,XMM3]  encoding(VEX, 4 bytes) = c5 e9 fc cb
01adh vpaddb xmm2,xmm4,xmm5         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM2,XMM4,XMM5]  encoding(VEX, 4 bytes) = c5 d9 fc d5
01b1h vpaddb xmm3,xmm6,xmm7         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM3,XMM6,XMM7]  encoding(VEX, 4 bytes) = c5 c9 fc df
01b5h vpaddb xmm4,xmm8,xmm9         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM4,XMM8,XMM9]  encoding(VEX, 5 bytes) = c4 c1 39 fc e1
01bah vpaddb xmm5,xmm10,xmm11       ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM5,XMM10,XMM11] encoding(VEX, 5 bytes) = c4 c1 29 fc eb
01bfh vpaddb xmm6,xmm12,xmm13       ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM6,XMM12,XMM13] encoding(VEX, 5 bytes) = c4 c1 19 fc f5
01c4h vpaddb xmm7,xmm14,xmm15       ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM7,XMM14,XMM15] encoding(VEX, 5 bytes) = c4 c1 09 fc ff
01c9h vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
01cdh vpaddb xmm1,xmm2,xmm3         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM1,XMM2,XMM3]  encoding(VEX, 4 bytes) = c5 e9 fc cb
01d1h vpaddb xmm2,xmm3,xmm4         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM2,XMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e1 fc d4
01d5h vpaddb xmm3,xmm4,xmm5         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM3,XMM4,XMM5]  encoding(VEX, 4 bytes) = c5 d9 fc dd
01d9h vpaddb xmm4,xmm6,xmm7         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM4,XMM6,XMM7]  encoding(VEX, 4 bytes) = c5 c9 fc e7
01ddh vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
01e1h vpaddb xmm1,xmm2,xmm3         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM1,XMM2,XMM3]  encoding(VEX, 4 bytes) = c5 e9 fc cb
01e5h vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
01e9h vpaddb xmm0,xmm0,xmm4         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM4]  encoding(VEX, 4 bytes) = c5 f9 fc c4
01edh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
01f1h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
01f4h vmovaps xmm6,[rsp+0B0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f8 28 b4 24 b0 00 00 00
01fdh vmovaps xmm7,[rsp+0A0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f8 28 bc 24 a0 00 00 00
0206h vmovaps xmm8,[rsp+90h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM8,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 78 28 84 24 90 00 00 00
020fh vmovaps xmm9,[rsp+80h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM9,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 78 28 8c 24 80 00 00 00
0218h vmovaps xmm10,[rsp+70h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM10,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 78 28 54 24 70
021eh vmovaps xmm11,[rsp+60h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM11,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 78 28 5c 24 60
0224h vmovaps xmm12,[rsp+50h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM12,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 78 28 64 24 50
022ah vmovaps xmm13,[rsp+40h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM13,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 78 28 6c 24 40
0230h vmovaps xmm14,[rsp+30h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM14,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 78 28 74 24 30
0236h vmovaps xmm15,[rsp+20h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM15,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 78 28 7c 24 20
023ch add rsp,0C8h                  ; ADD(Add_rm64_imm32) [RSP,c8h:imm64]                  encoding(7 bytes) = 48 81 c4 c8 00 00 00
0243h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0244h call 7FFCE91D4DB0h            ; CALL(Call_rel32_64) [5F63EA60h:jmp64]                encoding(5 bytes) = e8 17 e8 63 5f
0249h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> vpaddbBytes => new byte[586]{0x48,0x81,0xEC,0xC8,0x00,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0xB4,0x24,0xB0,0x00,0x00,0x00,0xC5,0xF8,0x29,0xBC,0x24,0xA0,0x00,0x00,0x00,0xC5,0x78,0x29,0x84,0x24,0x90,0x00,0x00,0x00,0xC5,0x78,0x29,0x8C,0x24,0x80,0x00,0x00,0x00,0xC5,0x78,0x29,0x54,0x24,0x70,0xC5,0x78,0x29,0x5C,0x24,0x60,0xC5,0x78,0x29,0x64,0x24,0x50,0xC5,0x78,0x29,0x6C,0x24,0x40,0xC5,0x78,0x29,0x74,0x24,0x30,0xC5,0x78,0x29,0x7C,0x24,0x20,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0xE3,0x01,0x00,0x00,0x4C,0x8B,0xC0,0xC4,0xC1,0x79,0x6F,0x00,0x83,0xFA,0x10,0x0F,0x86,0xD2,0x01,0x00,0x00,0x4C,0x8D,0x40,0x10,0xC4,0xC1,0x79,0x6F,0x08,0x83,0xFA,0x20,0x0F,0x86,0xC0,0x01,0x00,0x00,0x4C,0x8D,0x40,0x20,0xC4,0xC1,0x79,0x6F,0x10,0x83,0xFA,0x30,0x0F,0x86,0xAE,0x01,0x00,0x00,0x4C,0x8D,0x40,0x30,0xC4,0xC1,0x79,0x6F,0x18,0x83,0xFA,0x40,0x0F,0x86,0x9C,0x01,0x00,0x00,0x4C,0x8D,0x40,0x40,0xC4,0xC1,0x79,0x6F,0x20,0x83,0xFA,0x50,0x0F,0x86,0x8A,0x01,0x00,0x00,0x4C,0x8D,0x40,0x50,0xC4,0xC1,0x79,0x6F,0x28,0x83,0xFA,0x60,0x0F,0x86,0x78,0x01,0x00,0x00,0x4C,0x8D,0x40,0x60,0xC4,0xC1,0x79,0x6F,0x30,0x83,0xFA,0x70,0x0F,0x86,0x66,0x01,0x00,0x00,0x4C,0x8D,0x40,0x70,0xC4,0xC1,0x79,0x6F,0x38,0x81,0xFA,0x80,0x00,0x00,0x00,0x0F,0x86,0x51,0x01,0x00,0x00,0x4C,0x8D,0x80,0x80,0x00,0x00,0x00,0xC4,0x41,0x79,0x6F,0x00,0x81,0xFA,0x90,0x00,0x00,0x00,0x0F,0x86,0x39,0x01,0x00,0x00,0x4C,0x8D,0x80,0x90,0x00,0x00,0x00,0xC4,0x41,0x79,0x6F,0x08,0x81,0xFA,0xA0,0x00,0x00,0x00,0x0F,0x86,0x21,0x01,0x00,0x00,0x4C,0x8D,0x80,0xA0,0x00,0x00,0x00,0xC4,0x41,0x79,0x6F,0x10,0x81,0xFA,0xB0,0x00,0x00,0x00,0x0F,0x86,0x09,0x01,0x00,0x00,0x4C,0x8D,0x80,0xB0,0x00,0x00,0x00,0xC4,0x41,0x79,0x6F,0x18,0x81,0xFA,0xC0,0x00,0x00,0x00,0x0F,0x86,0xF1,0x00,0x00,0x00,0x4C,0x8D,0x80,0xC0,0x00,0x00,0x00,0xC4,0x41,0x79,0x6F,0x20,0x81,0xFA,0xD0,0x00,0x00,0x00,0x0F,0x86,0xD9,0x00,0x00,0x00,0x4C,0x8D,0x80,0xD0,0x00,0x00,0x00,0xC4,0x41,0x79,0x6F,0x28,0x81,0xFA,0xE0,0x00,0x00,0x00,0x0F,0x86,0xC1,0x00,0x00,0x00,0x4C,0x8D,0x80,0xE0,0x00,0x00,0x00,0xC4,0x41,0x79,0x6F,0x30,0x81,0xFA,0xF0,0x00,0x00,0x00,0x0F,0x86,0xA9,0x00,0x00,0x00,0x48,0x05,0xF0,0x00,0x00,0x00,0xC5,0x79,0x6F,0x38,0xC5,0xF9,0xFC,0xC1,0xC5,0xE9,0xFC,0xCB,0xC5,0xD9,0xFC,0xD5,0xC5,0xC9,0xFC,0xDF,0xC4,0xC1,0x39,0xFC,0xE1,0xC4,0xC1,0x29,0xFC,0xEB,0xC4,0xC1,0x19,0xFC,0xF5,0xC4,0xC1,0x09,0xFC,0xFF,0xC5,0xF9,0xFC,0xC1,0xC5,0xE9,0xFC,0xCB,0xC5,0xE1,0xFC,0xD4,0xC5,0xD9,0xFC,0xDD,0xC5,0xC9,0xFC,0xE7,0xC5,0xF9,0xFC,0xC1,0xC5,0xE9,0xFC,0xCB,0xC5,0xF9,0xFC,0xC1,0xC5,0xF9,0xFC,0xC4,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x28,0xB4,0x24,0xB0,0x00,0x00,0x00,0xC5,0xF8,0x28,0xBC,0x24,0xA0,0x00,0x00,0x00,0xC5,0x78,0x28,0x84,0x24,0x90,0x00,0x00,0x00,0xC5,0x78,0x28,0x8C,0x24,0x80,0x00,0x00,0x00,0xC5,0x78,0x28,0x54,0x24,0x70,0xC5,0x78,0x28,0x5C,0x24,0x60,0xC5,0x78,0x28,0x64,0x24,0x50,0xC5,0x78,0x28,0x6C,0x24,0x40,0xC5,0x78,0x28,0x74,0x24,0x30,0xC5,0x78,0x28,0x7C,0x24,0x20,0x48,0x81,0xC4,0xC8,0x00,0x00,0x00,0xC3,0xE8,0x17,0xE8,0x63,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vpaddb(in byte xmm0, in byte xmm1, in byte xmm2, in byte xmm3, in byte xmm4, in byte xmm5, in byte xmm6, in byte xmm7, in byte xmm8, in byte xmm9, in byte xmm10, in byte xmm11, in byte xmm12, in byte xmm13, in byte xmm14, in byte xmm15)
; location: [7FFC89B96600h, 7FFC89B9678Ch]
0000h sub rsp,0A8h                  ; SUB(Sub_rm64_imm32) [RSP,a8h:imm64]                  encoding(7 bytes) = 48 81 ec a8 00 00 00
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah vmovaps [rsp+90h],xmm6        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM6] encoding(VEX, 9 bytes) = c5 f8 29 b4 24 90 00 00 00
0013h vmovaps [rsp+80h],xmm7        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM7] encoding(VEX, 9 bytes) = c5 f8 29 bc 24 80 00 00 00
001ch vmovaps [rsp+70h],xmm8        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM8] encoding(VEX, 6 bytes) = c5 78 29 44 24 70
0022h vmovaps [rsp+60h],xmm9        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM9] encoding(VEX, 6 bytes) = c5 78 29 4c 24 60
0028h vmovaps [rsp+50h],xmm10       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM10] encoding(VEX, 6 bytes) = c5 78 29 54 24 50
002eh vmovaps [rsp+40h],xmm11       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM11] encoding(VEX, 6 bytes) = c5 78 29 5c 24 40
0034h vmovaps [rsp+30h],xmm12       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM12] encoding(VEX, 6 bytes) = c5 78 29 64 24 30
003ah vmovaps [rsp+20h],xmm13       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM13] encoding(VEX, 6 bytes) = c5 78 29 6c 24 20
0040h vmovaps [rsp+10h],xmm14       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM14] encoding(VEX, 6 bytes) = c5 78 29 74 24 10
0046h vmovaps [rsp],xmm15           ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM15] encoding(VEX, 5 bytes) = c5 78 29 3c 24
004bh vmovdqa xmm0,xmmword ptr [rdx]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 6f 02
004fh vmovdqa xmm1,xmmword ptr [r8] ; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM1,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 6f 08
0054h vmovdqa xmm2,xmmword ptr [r9] ; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM2,mem(Packed128_Int32,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 6f 11
0059h mov rax,[rsp+0D0h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 d0 00 00 00
0061h vmovdqa xmm3,xmmword ptr [rax]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM3,mem(Packed128_Int32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 6f 18
0065h mov rax,[rsp+0D8h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 d8 00 00 00
006dh vmovdqa xmm4,xmmword ptr [rax]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM4,mem(Packed128_Int32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 6f 20
0071h mov rax,[rsp+0E0h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 e0 00 00 00
0079h vmovdqa xmm5,xmmword ptr [rax]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM5,mem(Packed128_Int32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 6f 28
007dh mov rax,[rsp+0E8h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 e8 00 00 00
0085h vmovdqa xmm6,xmmword ptr [rax]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM6,mem(Packed128_Int32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 6f 30
0089h mov rax,[rsp+0F0h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 f0 00 00 00
0091h vmovdqa xmm7,xmmword ptr [rax]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM7,mem(Packed128_Int32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 6f 38
0095h mov rax,[rsp+0F8h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 f8 00 00 00
009dh vmovdqa xmm8,xmmword ptr [rax]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM8,mem(Packed128_Int32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 79 6f 00
00a1h mov rax,[rsp+100h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 00 01 00 00
00a9h vmovdqa xmm9,xmmword ptr [rax]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM9,mem(Packed128_Int32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 79 6f 08
00adh mov rax,[rsp+108h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 08 01 00 00
00b5h vmovdqa xmm10,xmmword ptr [rax]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM10,mem(Packed128_Int32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 79 6f 10
00b9h mov rax,[rsp+110h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 10 01 00 00
00c1h vmovdqa xmm11,xmmword ptr [rax]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM11,mem(Packed128_Int32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 79 6f 18
00c5h mov rax,[rsp+118h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 18 01 00 00
00cdh vmovdqa xmm12,xmmword ptr [rax]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM12,mem(Packed128_Int32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 79 6f 20
00d1h mov rax,[rsp+120h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 20 01 00 00
00d9h vmovdqa xmm13,xmmword ptr [rax]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM13,mem(Packed128_Int32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 79 6f 28
00ddh mov rax,[rsp+128h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 28 01 00 00
00e5h vmovdqa xmm14,xmmword ptr [rax]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM14,mem(Packed128_Int32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 79 6f 30
00e9h mov rax,[rsp+130h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 30 01 00 00
00f1h vmovdqa xmm15,xmmword ptr [rax]; VMOVDQA(VEX_Vmovdqa_xmm_xmmm128) [XMM15,mem(Packed128_Int32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 79 6f 38
00f5h vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
00f9h vpaddb xmm1,xmm2,xmm3         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM1,XMM2,XMM3]  encoding(VEX, 4 bytes) = c5 e9 fc cb
00fdh vpaddb xmm2,xmm4,xmm5         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM2,XMM4,XMM5]  encoding(VEX, 4 bytes) = c5 d9 fc d5
0101h vpaddb xmm3,xmm6,xmm7         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM3,XMM6,XMM7]  encoding(VEX, 4 bytes) = c5 c9 fc df
0105h vpaddb xmm4,xmm8,xmm9         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM4,XMM8,XMM9]  encoding(VEX, 5 bytes) = c4 c1 39 fc e1
010ah vpaddb xmm5,xmm10,xmm11       ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM5,XMM10,XMM11] encoding(VEX, 5 bytes) = c4 c1 29 fc eb
010fh vpaddb xmm6,xmm12,xmm13       ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM6,XMM12,XMM13] encoding(VEX, 5 bytes) = c4 c1 19 fc f5
0114h vpaddb xmm7,xmm14,xmm15       ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM7,XMM14,XMM15] encoding(VEX, 5 bytes) = c4 c1 09 fc ff
0119h vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
011dh vpaddb xmm1,xmm2,xmm3         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM1,XMM2,XMM3]  encoding(VEX, 4 bytes) = c5 e9 fc cb
0121h vpaddb xmm2,xmm3,xmm4         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM2,XMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e1 fc d4
0125h vpaddb xmm3,xmm4,xmm5         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM3,XMM4,XMM5]  encoding(VEX, 4 bytes) = c5 d9 fc dd
0129h vpaddb xmm4,xmm6,xmm7         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM4,XMM6,XMM7]  encoding(VEX, 4 bytes) = c5 c9 fc e7
012dh vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
0131h vpaddb xmm1,xmm2,xmm3         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM1,XMM2,XMM3]  encoding(VEX, 4 bytes) = c5 e9 fc cb
0135h vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
0139h vpaddb xmm0,xmm0,xmm4         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM4]  encoding(VEX, 4 bytes) = c5 f9 fc c4
013dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0141h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0144h vmovaps xmm6,[rsp+90h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f8 28 b4 24 90 00 00 00
014dh vmovaps xmm7,[rsp+80h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f8 28 bc 24 80 00 00 00
0156h vmovaps xmm8,[rsp+70h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM8,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 78 28 44 24 70
015ch vmovaps xmm9,[rsp+60h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM9,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 78 28 4c 24 60
0162h vmovaps xmm10,[rsp+50h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM10,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 78 28 54 24 50
0168h vmovaps xmm11,[rsp+40h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM11,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 78 28 5c 24 40
016eh vmovaps xmm12,[rsp+30h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM12,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 78 28 64 24 30
0174h vmovaps xmm13,[rsp+20h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM13,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 78 28 6c 24 20
017ah vmovaps xmm14,[rsp+10h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM14,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 78 28 74 24 10
0180h vmovaps xmm15,[rsp]           ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM15,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 78 28 3c 24
0185h add rsp,0A8h                  ; ADD(Add_rm64_imm32) [RSP,a8h:imm64]                  encoding(7 bytes) = 48 81 c4 a8 00 00 00
018ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpaddbBytes => new byte[397]{0x48,0x81,0xEC,0xA8,0x00,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0xB4,0x24,0x90,0x00,0x00,0x00,0xC5,0xF8,0x29,0xBC,0x24,0x80,0x00,0x00,0x00,0xC5,0x78,0x29,0x44,0x24,0x70,0xC5,0x78,0x29,0x4C,0x24,0x60,0xC5,0x78,0x29,0x54,0x24,0x50,0xC5,0x78,0x29,0x5C,0x24,0x40,0xC5,0x78,0x29,0x64,0x24,0x30,0xC5,0x78,0x29,0x6C,0x24,0x20,0xC5,0x78,0x29,0x74,0x24,0x10,0xC5,0x78,0x29,0x3C,0x24,0xC5,0xF9,0x6F,0x02,0xC4,0xC1,0x79,0x6F,0x08,0xC4,0xC1,0x79,0x6F,0x11,0x48,0x8B,0x84,0x24,0xD0,0x00,0x00,0x00,0xC5,0xF9,0x6F,0x18,0x48,0x8B,0x84,0x24,0xD8,0x00,0x00,0x00,0xC5,0xF9,0x6F,0x20,0x48,0x8B,0x84,0x24,0xE0,0x00,0x00,0x00,0xC5,0xF9,0x6F,0x28,0x48,0x8B,0x84,0x24,0xE8,0x00,0x00,0x00,0xC5,0xF9,0x6F,0x30,0x48,0x8B,0x84,0x24,0xF0,0x00,0x00,0x00,0xC5,0xF9,0x6F,0x38,0x48,0x8B,0x84,0x24,0xF8,0x00,0x00,0x00,0xC5,0x79,0x6F,0x00,0x48,0x8B,0x84,0x24,0x00,0x01,0x00,0x00,0xC5,0x79,0x6F,0x08,0x48,0x8B,0x84,0x24,0x08,0x01,0x00,0x00,0xC5,0x79,0x6F,0x10,0x48,0x8B,0x84,0x24,0x10,0x01,0x00,0x00,0xC5,0x79,0x6F,0x18,0x48,0x8B,0x84,0x24,0x18,0x01,0x00,0x00,0xC5,0x79,0x6F,0x20,0x48,0x8B,0x84,0x24,0x20,0x01,0x00,0x00,0xC5,0x79,0x6F,0x28,0x48,0x8B,0x84,0x24,0x28,0x01,0x00,0x00,0xC5,0x79,0x6F,0x30,0x48,0x8B,0x84,0x24,0x30,0x01,0x00,0x00,0xC5,0x79,0x6F,0x38,0xC5,0xF9,0xFC,0xC1,0xC5,0xE9,0xFC,0xCB,0xC5,0xD9,0xFC,0xD5,0xC5,0xC9,0xFC,0xDF,0xC4,0xC1,0x39,0xFC,0xE1,0xC4,0xC1,0x29,0xFC,0xEB,0xC4,0xC1,0x19,0xFC,0xF5,0xC4,0xC1,0x09,0xFC,0xFF,0xC5,0xF9,0xFC,0xC1,0xC5,0xE9,0xFC,0xCB,0xC5,0xE1,0xFC,0xD4,0xC5,0xD9,0xFC,0xDD,0xC5,0xC9,0xFC,0xE7,0xC5,0xF9,0xFC,0xC1,0xC5,0xE9,0xFC,0xCB,0xC5,0xF9,0xFC,0xC1,0xC5,0xF9,0xFC,0xC4,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x28,0xB4,0x24,0x90,0x00,0x00,0x00,0xC5,0xF8,0x28,0xBC,0x24,0x80,0x00,0x00,0x00,0xC5,0x78,0x28,0x44,0x24,0x70,0xC5,0x78,0x28,0x4C,0x24,0x60,0xC5,0x78,0x28,0x54,0x24,0x50,0xC5,0x78,0x28,0x5C,0x24,0x40,0xC5,0x78,0x28,0x64,0x24,0x30,0xC5,0x78,0x28,0x6C,0x24,0x20,0xC5,0x78,0x28,0x74,0x24,0x10,0xC5,0x78,0x28,0x3C,0x24,0x48,0x81,0xC4,0xA8,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
