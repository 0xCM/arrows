# 2019-07-29 03:15:51:334
7FFC798330C0h Vec128<sbyte> add1(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,Memory] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,Memory] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 fc c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [Memory,XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798330D9h ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFC,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798330F0h Vec128<sbyte> add2(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,Memory] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,Memory] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 fc c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [Memory,XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79833109h ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFC,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79833120h Vector128<sbyte> add3(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,Memory] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpaddb xmm0,xmm0,[r8]         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,Memory] encoding(VEX, 5 bytes) = c4 c1 79 fc 00
000eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [Memory,XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79833135h ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xFC,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79833150h Vector256<sbyte> add4(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,Memory] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpaddb ymm0,ymm0,[r8]         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM0,YMM0,Memory] encoding(VEX, 5 bytes) = c4 c1 7d fc 00
000eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [Memory,YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79833168h ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xFC,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79833180h Vec256<sbyte> add5(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,Memory] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,Memory] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpaddb ymm0,ymm0,ymm1         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd fc c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [Memory,YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC7983319Ch ;{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xFC,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798335C0h Vec256<long> permute4x64(in Vec256<long> value, byte control)
0000h push rsi                      ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0001h sub rsp,70h                   ; SUB(Sub_rm64_imm8) [RSP,70h:imm64]         encoding(4 bytes) = 48 83 ec 70
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0008h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
000ah mov [rsp+40h],rax             ; MOV(Mov_rm64_r64) [Memory,RAX]             encoding(5 bytes) = 48 89 44 24 40
000fh mov [rsp+48h],rax             ; MOV(Mov_rm64_r64) [Memory,RAX]             encoding(5 bytes) = 48 89 44 24 48
0014h mov [rsp+50h],rax             ; MOV(Mov_rm64_r64) [Memory,RAX]             encoding(5 bytes) = 48 89 44 24 50
0019h mov [rsp+58h],rax             ; MOV(Mov_rm64_r64) [Memory,RAX]             encoding(5 bytes) = 48 89 44 24 58
001eh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
0021h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,Memory] encoding(VEX, 4 bytes) = c5 fd 10 02
0025h lea rcx,[rsp+40h]             ; LEA(Lea_r64_m) [RCX,Memory]                encoding(5 bytes) = 48 8d 4c 24 40
002ah vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [Memory,YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0030h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,Memory]                encoding(5 bytes) = 48 8d 54 24 20
0035h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]             encoding(4 bytes) = 45 0f b6 c0
0039h call 7FFC7929A110h            ; CALL(Call_rel32_64) [NearBranch64]         encoding(5 bytes) = e8 12 6b a6 ff
003eh vmovupd ymm0,[rsp+40h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,Memory] encoding(VEX, 6 bytes) = c5 fd 10 44 24 40
0044h vmovupd [rsi],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [Memory,YMM0] encoding(VEX, 4 bytes) = c5 fd 11 06
0048h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                encoding(3 bytes) = 48 8b c6
004bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
004eh add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]         encoding(4 bytes) = 48 83 c4 70
0052h pop rsi                       ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
0053h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79833613h ;{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x40,0x48,0x89,0x44,0x24,0x48,0x48,0x89,0x44,0x24,0x50,0x48,0x89,0x44,0x24,0x58,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0x48,0x8D,0x4C,0x24,0x40,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0x12,0x6B,0xA6,0xFF,0xC5,0xFD,0x10,0x44,0x24,0x40,0xC5,0xFD,0x11,0x06,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79833630h Vec256<ulong> permute4x64(in Vec256<ulong> value, byte control)
0000h push rsi                      ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0001h sub rsp,70h                   ; SUB(Sub_rm64_imm8) [RSP,70h:imm64]         encoding(4 bytes) = 48 83 ec 70
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0008h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
000ah mov [rsp+40h],rax             ; MOV(Mov_rm64_r64) [Memory,RAX]             encoding(5 bytes) = 48 89 44 24 40
000fh mov [rsp+48h],rax             ; MOV(Mov_rm64_r64) [Memory,RAX]             encoding(5 bytes) = 48 89 44 24 48
0014h mov [rsp+50h],rax             ; MOV(Mov_rm64_r64) [Memory,RAX]             encoding(5 bytes) = 48 89 44 24 50
0019h mov [rsp+58h],rax             ; MOV(Mov_rm64_r64) [Memory,RAX]             encoding(5 bytes) = 48 89 44 24 58
001eh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
0021h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,Memory] encoding(VEX, 4 bytes) = c5 fd 10 02
0025h lea rcx,[rsp+40h]             ; LEA(Lea_r64_m) [RCX,Memory]                encoding(5 bytes) = 48 8d 4c 24 40
002ah vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [Memory,YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0030h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,Memory]                encoding(5 bytes) = 48 8d 54 24 20
0035h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]             encoding(4 bytes) = 45 0f b6 c0
0039h call 7FFC7929A118h            ; CALL(Call_rel32_64) [NearBranch64]         encoding(5 bytes) = e8 aa 6a a6 ff
003eh vmovupd ymm0,[rsp+40h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,Memory] encoding(VEX, 6 bytes) = c5 fd 10 44 24 40
0044h vmovupd [rsi],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [Memory,YMM0] encoding(VEX, 4 bytes) = c5 fd 11 06
0048h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                encoding(3 bytes) = 48 8b c6
004bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
004eh add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]         encoding(4 bytes) = 48 83 c4 70
0052h pop rsi                       ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
0053h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79833683h ;{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x40,0x48,0x89,0x44,0x24,0x48,0x48,0x89,0x44,0x24,0x50,0x48,0x89,0x44,0x24,0x58,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0x48,0x8D,0x4C,0x24,0x40,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0xAA,0x6A,0xA6,0xFF,0xC5,0xFD,0x10,0x44,0x24,0x40,0xC5,0xFD,0x11,0x06,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798336A0h Vec256<double> permute4x64(in Vec256<double> value, byte control)
0000h push rsi                      ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0001h sub rsp,70h                   ; SUB(Sub_rm64_imm8) [RSP,70h:imm64]         encoding(4 bytes) = 48 83 ec 70
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0008h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
000ah mov [rsp+40h],rax             ; MOV(Mov_rm64_r64) [Memory,RAX]             encoding(5 bytes) = 48 89 44 24 40
000fh mov [rsp+48h],rax             ; MOV(Mov_rm64_r64) [Memory,RAX]             encoding(5 bytes) = 48 89 44 24 48
0014h mov [rsp+50h],rax             ; MOV(Mov_rm64_r64) [Memory,RAX]             encoding(5 bytes) = 48 89 44 24 50
0019h mov [rsp+58h],rax             ; MOV(Mov_rm64_r64) [Memory,RAX]             encoding(5 bytes) = 48 89 44 24 58
001eh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
0021h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,Memory] encoding(VEX, 4 bytes) = c5 fd 10 02
0025h lea rcx,[rsp+40h]             ; LEA(Lea_r64_m) [RCX,Memory]                encoding(5 bytes) = 48 8d 4c 24 40
002ah vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [Memory,YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0030h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,Memory]                encoding(5 bytes) = 48 8d 54 24 20
0035h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]             encoding(4 bytes) = 45 0f b6 c0
0039h call 7FFC7929A120h            ; CALL(Call_rel32_64) [NearBranch64]         encoding(5 bytes) = e8 42 6a a6 ff
003eh vmovupd ymm0,[rsp+40h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,Memory] encoding(VEX, 6 bytes) = c5 fd 10 44 24 40
0044h vmovupd [rsi],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [Memory,YMM0] encoding(VEX, 4 bytes) = c5 fd 11 06
0048h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                encoding(3 bytes) = 48 8b c6
004bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
004eh add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]         encoding(4 bytes) = 48 83 c4 70
0052h pop rsi                       ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
0053h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798336F3h ;{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x40,0x48,0x89,0x44,0x24,0x48,0x48,0x89,0x44,0x24,0x50,0x48,0x89,0x44,0x24,0x58,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0x48,0x8D,0x4C,0x24,0x40,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0x42,0x6A,0xA6,0xFF,0xC5,0xFD,0x10,0x44,0x24,0x40,0xC5,0xFD,0x11,0x06,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79833710h Vector256<long> permute4x64(in Vector256<long> value, byte control)
0000h push rsi                      ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0001h sub rsp,50h                   ; SUB(Sub_rm64_imm8) [RSP,50h:imm64]         encoding(4 bytes) = 48 83 ec 50
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
000bh vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,Memory] encoding(VEX, 4 bytes) = c5 fd 10 02
000fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
0012h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [Memory,YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0018h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,Memory]                encoding(5 bytes) = 48 8d 54 24 20
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]             encoding(4 bytes) = 45 0f b6 c0
0021h call 7FFC7929A110h            ; CALL(Call_rel32_64) [NearBranch64]         encoding(5 bytes) = e8 da 69 a6 ff
0026h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                encoding(3 bytes) = 48 8b c6
0029h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
002ch add rsp,50h                   ; ADD(Add_rm64_imm8) [RSP,50h:imm64]         encoding(4 bytes) = 48 83 c4 50
0030h pop rsi                       ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
0031h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79833741h ;{0x56,0x48,0x83,0xEC,0x50,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0xDA,0x69,0xA6,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x50,0x5E,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79833760h Vector256<ulong> permute4x64(in Vector256<ulong> value, byte control)
0000h push rsi                      ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0001h sub rsp,50h                   ; SUB(Sub_rm64_imm8) [RSP,50h:imm64]         encoding(4 bytes) = 48 83 ec 50
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
000bh vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,Memory] encoding(VEX, 4 bytes) = c5 fd 10 02
000fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
0012h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [Memory,YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0018h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,Memory]                encoding(5 bytes) = 48 8d 54 24 20
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]             encoding(4 bytes) = 45 0f b6 c0
0021h call 7FFC7929A118h            ; CALL(Call_rel32_64) [NearBranch64]         encoding(5 bytes) = e8 92 69 a6 ff
0026h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                encoding(3 bytes) = 48 8b c6
0029h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
002ch add rsp,50h                   ; ADD(Add_rm64_imm8) [RSP,50h:imm64]         encoding(4 bytes) = 48 83 c4 50
0030h pop rsi                       ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
0031h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79833791h ;{0x56,0x48,0x83,0xEC,0x50,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0x92,0x69,0xA6,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x50,0x5E,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798337B0h Vector256<double> permute4x64(in Vector256<double> value, byte control)
0000h push rsi                      ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0001h sub rsp,50h                   ; SUB(Sub_rm64_imm8) [RSP,50h:imm64]         encoding(4 bytes) = 48 83 ec 50
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
000bh vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,Memory] encoding(VEX, 4 bytes) = c5 fd 10 02
000fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
0012h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [Memory,YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0018h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,Memory]                encoding(5 bytes) = 48 8d 54 24 20
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]             encoding(4 bytes) = 45 0f b6 c0
0021h call 7FFC7929A120h            ; CALL(Call_rel32_64) [NearBranch64]         encoding(5 bytes) = e8 4a 69 a6 ff
0026h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                encoding(3 bytes) = 48 8b c6
0029h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
002ch add rsp,50h                   ; ADD(Add_rm64_imm8) [RSP,50h:imm64]         encoding(4 bytes) = 48 83 c4 50
0030h pop rsi                       ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
0031h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798337E1h ;{0x56,0x48,0x83,0xEC,0x50,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0x4A,0x69,0xA6,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x50,0x5E,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79833800h Vector256<long> shiftlw(in Vector256<long> src, byte count)
0000h push rsi                      ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0001h sub rsp,50h                   ; SUB(Sub_rm64_imm8) [RSP,50h:imm64]         encoding(4 bytes) = 48 83 ec 50
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
000bh vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,Memory] encoding(VEX, 4 bytes) = c5 fd 10 02
000fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
0012h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [Memory,YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0018h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,Memory]                encoding(5 bytes) = 48 8d 54 24 20
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]             encoding(4 bytes) = 45 0f b6 c0
0021h call 7FFC7929A1D0h            ; CALL(Call_rel32_64) [NearBranch64]         encoding(5 bytes) = e8 aa 69 a6 ff
0026h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                encoding(3 bytes) = 48 8b c6
0029h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
002ch add rsp,50h                   ; ADD(Add_rm64_imm8) [RSP,50h:imm64]         encoding(4 bytes) = 48 83 c4 50
0030h pop rsi                       ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
0031h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79833831h ;{0x56,0x48,0x83,0xEC,0x50,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0xAA,0x69,0xA6,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x50,0x5E,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC79833850h Vector256<ulong> shiftlw(Vector256<ulong> src, byte count)
0000h push rsi                      ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0001h sub rsp,50h                   ; SUB(Sub_rm64_imm8) [RSP,50h:imm64]         encoding(4 bytes) = 48 83 ec 50
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
000bh vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,Memory] encoding(VEX, 4 bytes) = c5 fd 10 02
000fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
0012h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [Memory,YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0018h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,Memory]                encoding(5 bytes) = 48 8d 54 24 20
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]             encoding(4 bytes) = 45 0f b6 c0
0021h call 7FFC7929A1D8h            ; CALL(Call_rel32_64) [NearBranch64]         encoding(5 bytes) = e8 62 69 a6 ff
0026h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                encoding(3 bytes) = 48 8b c6
0029h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
002ch add rsp,50h                   ; ADD(Add_rm64_imm8) [RSP,50h:imm64]         encoding(4 bytes) = 48 83 c4 50
0030h pop rsi                       ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
0031h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC79833881h ;{0x56,0x48,0x83,0xEC,0x50,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0x62,0x69,0xA6,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x50,0x5E,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC798338A0h Vec256<ulong> shiftlw(Vec256<ulong> src, byte count)
0000h push rsi                      ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0001h sub rsp,70h                   ; SUB(Sub_rm64_imm8) [RSP,70h:imm64]         encoding(4 bytes) = 48 83 ec 70
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0008h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
000ah mov [rsp+40h],rax             ; MOV(Mov_rm64_r64) [Memory,RAX]             encoding(5 bytes) = 48 89 44 24 40
000fh mov [rsp+48h],rax             ; MOV(Mov_rm64_r64) [Memory,RAX]             encoding(5 bytes) = 48 89 44 24 48
0014h mov [rsp+50h],rax             ; MOV(Mov_rm64_r64) [Memory,RAX]             encoding(5 bytes) = 48 89 44 24 50
0019h mov [rsp+58h],rax             ; MOV(Mov_rm64_r64) [Memory,RAX]             encoding(5 bytes) = 48 89 44 24 58
001eh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
0021h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,Memory] encoding(VEX, 4 bytes) = c5 fd 10 02
0025h lea rcx,[rsp+40h]             ; LEA(Lea_r64_m) [RCX,Memory]                encoding(5 bytes) = 48 8d 4c 24 40
002ah vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [Memory,YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0030h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,Memory]                encoding(5 bytes) = 48 8d 54 24 20
0035h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]             encoding(4 bytes) = 45 0f b6 c0
0039h call 7FFC7929A1D8h            ; CALL(Call_rel32_64) [NearBranch64]         encoding(5 bytes) = e8 fa 68 a6 ff
003eh vmovupd ymm0,[rsp+40h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,Memory] encoding(VEX, 6 bytes) = c5 fd 10 44 24 40
0044h vmovupd [rsi],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [Memory,YMM0] encoding(VEX, 4 bytes) = c5 fd 11 06
0048h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                encoding(3 bytes) = 48 8b c6
004bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
004eh add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]         encoding(4 bytes) = 48 83 c4 70
0052h pop rsi                       ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
0053h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC798338F3h ;{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x40,0x48,0x89,0x44,0x24,0x48,0x48,0x89,0x44,0x24,0x50,0x48,0x89,0x44,0x24,0x58,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0x48,0x8D,0x4C,0x24,0x40,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0xFA,0x68,0xA6,0xFF,0xC5,0xFD,0x10,0x44,0x24,0x40,0xC5,0xFD,0x11,0x06,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3}
------------------------------------------------------------------------------------------------------------------------
