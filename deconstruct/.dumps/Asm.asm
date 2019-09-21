; 2019-09-21 00:21:45:562
; function: XMM pmovzxbw(in XMM a)
; location: [7FFC7C08D0C0h, 7FFC7C08D10Bh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,3D27705840B5h         ; MOV(Mov_r64_imm64) [RAX,3d27705840b5h:imm64]         encoding(10 bytes) = 48 b8 b5 40 58 70 27 3d 00 00
0011h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 10
0016h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
001ah vpmovzxbw xmm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 30 c0
001fh vmovupd [rsp],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 11 04 24
0024h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0029h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h mov rcx,3D27705840B5h         ; MOV(Mov_r64_imm64) [RCX,3d27705840b5h:imm64]         encoding(10 bytes) = 48 b9 b5 40 58 70 27 3d 00 00
003ah cmp [rsp+10h],rcx             ; CMP(Cmp_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 39 4c 24 10
003fh je short 0046h                ; JE(Je_rel8_64) [46h:jmp64]                           encoding(2 bytes) = 74 05
0041h call 7FFCDBCD4EC0h            ; CALL(Call_rel32_64) [5FC47E00h:jmp64]                encoding(5 bytes) = e8 ba 7d c4 5f
0046h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0047h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
004bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pmovzxbwBytes => new byte[76]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0xB8,0xB5,0x40,0x58,0x70,0x27,0x3D,0x00,0x00,0x48,0x89,0x44,0x24,0x10,0xC5,0xF9,0x10,0x02,0xC4,0xE2,0x79,0x30,0xC0,0xC5,0xF9,0x11,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0xB9,0xB5,0x40,0x58,0x70,0x27,0x3D,0x00,0x00,0x48,0x39,0x4C,0x24,0x10,0x74,0x05,0xE8,0xBA,0x7D,0xC4,0x5F,0x90,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: XMM pmovzxdq(in XMM a)
; location: [7FFC7C08D2F0h, 7FFC7C08D33Bh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,3D27705840B5h         ; MOV(Mov_r64_imm64) [RAX,3d27705840b5h:imm64]         encoding(10 bytes) = 48 b8 b5 40 58 70 27 3d 00 00
0011h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 10
0016h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
001ah vpmovzxdq xmm0,xmm0           ; VPMOVZXDQ(VEX_Vpmovzxdq_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 35 c0
001fh vmovupd [rsp],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 11 04 24
0024h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0029h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h mov rcx,3D27705840B5h         ; MOV(Mov_r64_imm64) [RCX,3d27705840b5h:imm64]         encoding(10 bytes) = 48 b9 b5 40 58 70 27 3d 00 00
003ah cmp [rsp+10h],rcx             ; CMP(Cmp_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 39 4c 24 10
003fh je short 0046h                ; JE(Je_rel8_64) [46h:jmp64]                           encoding(2 bytes) = 74 05
0041h call 7FFCDBCD4EC0h            ; CALL(Call_rel32_64) [5FC47BD0h:jmp64]                encoding(5 bytes) = e8 8a 7b c4 5f
0046h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0047h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
004bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pmovzxdqBytes => new byte[76]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0xB8,0xB5,0x40,0x58,0x70,0x27,0x3D,0x00,0x00,0x48,0x89,0x44,0x24,0x10,0xC5,0xF9,0x10,0x02,0xC4,0xE2,0x79,0x35,0xC0,0xC5,0xF9,0x11,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0xB9,0xB5,0x40,0x58,0x70,0x27,0x3D,0x00,0x00,0x48,0x39,0x4C,0x24,0x10,0x74,0x05,0xE8,0x8A,0x7B,0xC4,0x5F,0x90,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref XMM pmovzxbd(in XMM a, ref XMM b)
; location: [7FFC7C08D360h, 7FFC7C08D3ABh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,3D27705840B5h         ; MOV(Mov_r64_imm64) [RAX,3d27705840b5h:imm64]         encoding(10 bytes) = 48 b8 b5 40 58 70 27 3d 00 00
0011h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 10
0016h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
001ah vpmovzxbd xmm0,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 31 c0
001fh vmovupd [rsp],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 11 04 24
0024h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0029h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
002dh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0030h mov rcx,3D27705840B5h         ; MOV(Mov_r64_imm64) [RCX,3d27705840b5h:imm64]         encoding(10 bytes) = 48 b9 b5 40 58 70 27 3d 00 00
003ah cmp [rsp+10h],rcx             ; CMP(Cmp_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 39 4c 24 10
003fh je short 0046h                ; JE(Je_rel8_64) [46h:jmp64]                           encoding(2 bytes) = 74 05
0041h call 7FFCDBCD4EC0h            ; CALL(Call_rel32_64) [5FC47B60h:jmp64]                encoding(5 bytes) = e8 1a 7b c4 5f
0046h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0047h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
004bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pmovzxbdBytes => new byte[76]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0xB8,0xB5,0x40,0x58,0x70,0x27,0x3D,0x00,0x00,0x48,0x89,0x44,0x24,0x10,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x31,0xC0,0xC5,0xF9,0x11,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x02,0x48,0x8B,0xC2,0x48,0xB9,0xB5,0x40,0x58,0x70,0x27,0x3D,0x00,0x00,0x48,0x39,0x4C,0x24,0x10,0x74,0x05,0xE8,0x1A,0x7B,0xC4,0x5F,0x90,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<int> vpblendd(Vector256<int> ymm2, Vector256<int> ymm3, byte imm8)
; location: [7FFC7C08F080h, 7FFC7C08F0C1h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,70h                   ; SUB(Sub_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 ec 70
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000fh vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
0014h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0017h vmovupd [rsp+40h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 40
001dh vmovupd [rsp+20h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 20
0023h lea rdx,[rsp+40h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 40
0028h lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
002dh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0031h call 7FFC7C07AA00h            ; CALL(Call_rel32_64) [FFFFFFFFFFFEB980h:jmp64]        encoding(5 bytes) = e8 4a b9 fe ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpblenddBytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0x4A,0xB9,0xFE,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref XMM vpcmpeqb(ref XMM xmm1, in XMM xmm2, in XMM xmm3)
; location: [7FFC7C08F110h, 7FFC7C08F15Fh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,3D27705840B5h         ; MOV(Mov_r64_imm64) [RAX,3d27705840b5h:imm64]         encoding(10 bytes) = 48 b8 b5 40 58 70 27 3d 00 00
0011h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 10
0016h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
001ah vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
001fh vpcmpeqb xmm0,xmm0,xmm1       ; VPCMPEQB(VEX_Vpcmpeqb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 74 c1
0023h vmovupd [rsp],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 11 04 24
0028h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
002dh vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0031h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0034h mov rcx,3D27705840B5h         ; MOV(Mov_r64_imm64) [RCX,3d27705840b5h:imm64]         encoding(10 bytes) = 48 b9 b5 40 58 70 27 3d 00 00
003eh cmp [rsp+10h],rcx             ; CMP(Cmp_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 39 4c 24 10
0043h je short 004ah                ; JE(Je_rel8_64) [4Ah:jmp64]                           encoding(2 bytes) = 74 05
0045h call 7FFCDBCD4EC0h            ; CALL(Call_rel32_64) [5FC45DB0h:jmp64]                encoding(5 bytes) = e8 66 5d c4 5f
004ah nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
004bh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
004fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpcmpeqbBytes => new byte[80]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0xB8,0xB5,0x40,0x58,0x70,0x27,0x3D,0x00,0x00,0x48,0x89,0x44,0x24,0x10,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0x74,0xC1,0xC5,0xF9,0x11,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0xB9,0xB5,0x40,0x58,0x70,0x27,0x3D,0x00,0x00,0x48,0x39,0x4C,0x24,0x10,0x74,0x05,0xE8,0x66,0x5D,0xC4,0x5F,0x90,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: YMM vperm2i128(in YMM a, in YMM b, byte control)
; location: [7FFC7C08F380h, 7FFC7C08F40Ch]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,0C0h                  ; SUB(Sub_rm64_imm32) [RSP,c0h:imm64]                  encoding(7 bytes) = 48 81 ec c0 00 00 00
000ah mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000dh mov rdi,r8                    ; MOV(Mov_r64_rm64) [RDI,R8]                           encoding(3 bytes) = 49 8b f8
0010h mov ebx,r9d                   ; MOV(Mov_r32_rm32) [EBX,R9D]                          encoding(3 bytes) = 41 8b d9
0013h lea rcx,[rsp+0A0h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 a0 00 00 00
001bh call 7FFC7C08EC70h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF8F0h:jmp64]        encoding(5 bytes) = e8 d0 f8 ff ff
0020h lea rcx,[rsp+80h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 80 00 00 00
0028h mov rdx,rdi                   ; MOV(Mov_r64_rm64) [RDX,RDI]                          encoding(3 bytes) = 48 8b d7
002bh call 7FFC7C08EC70h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF8F0h:jmp64]        encoding(5 bytes) = e8 c0 f8 ff ff
0030h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
0039h lea rcx,[rsp+60h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 60
003eh vmovupd [rsp+40h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 40
0044h vmovupd ymm0,[rsp+80h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 80 00 00 00
004dh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0053h lea rdx,[rsp+40h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 40
0058h lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
005dh movzx r9d,bl                  ; MOVZX(Movzx_r32_rm8) [R9D,BL]                        encoding(4 bytes) = 44 0f b6 cb
0061h call 7FFC7C07A118h            ; CALL(Call_rel32_64) [FFFFFFFFFFFEAD98h:jmp64]        encoding(5 bytes) = e8 32 ad fe ff
0066h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0069h vmovupd ymm0,[rsp+60h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 60
006fh vmovupd [rsp+40h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 40
0075h lea rdx,[rsp+40h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 40
007ah call 7FFC7C08EC90h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF910h:jmp64]        encoding(5 bytes) = e8 91 f8 ff ff
007fh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0082h add rsp,0C0h                  ; ADD(Add_rm64_imm32) [RSP,c0h:imm64]                  encoding(7 bytes) = 48 81 c4 c0 00 00 00
0089h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
008ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
008bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
008ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vperm2i128Bytes => new byte[141]{0x57,0x56,0x53,0x48,0x81,0xEC,0xC0,0x00,0x00,0x00,0x48,0x8B,0xF1,0x49,0x8B,0xF8,0x41,0x8B,0xD9,0x48,0x8D,0x8C,0x24,0xA0,0x00,0x00,0x00,0xE8,0xD0,0xF8,0xFF,0xFF,0x48,0x8D,0x8C,0x24,0x80,0x00,0x00,0x00,0x48,0x8B,0xD7,0xE8,0xC0,0xF8,0xFF,0xFF,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4C,0x24,0x60,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x10,0x84,0x24,0x80,0x00,0x00,0x00,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x44,0x0F,0xB6,0xCB,0xE8,0x32,0xAD,0xFE,0xFF,0x48,0x8B,0xCE,0xC5,0xFD,0x10,0x44,0x24,0x60,0xC5,0xFD,0x11,0x44,0x24,0x40,0x48,0x8D,0x54,0x24,0x40,0xE8,0x91,0xF8,0xFF,0xFF,0x48,0x8B,0xC6,0x48,0x81,0xC4,0xC0,0x00,0x00,0x00,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
