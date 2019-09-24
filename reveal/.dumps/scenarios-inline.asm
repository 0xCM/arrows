# 2019-07-29 18:32:29:173
; function: BitSize GetWidth(IImm<byte> src)
; location: [7FFC7C63DEA0h, 7FFC7C63DEBBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0008h mov r11,7FFC7C500060h         ; MOV(Mov_r64_imm64) [R11,7ffc7c500060h:imm64]         encoding(10 bytes) = 49 bb 60 00 50 7c fc 7f 00 00
0012h mov rax,[7FFC7C500060h]       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RIP:br,DS:sr)]        encoding(7 bytes) = 48 8b 05 a7 21 ec ff
0019h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
001bh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; code = new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xCA,0x49,0xBB,0x60,0x00,0x50,0x7C,0xFC,0x7F,0x00,0x00,0x48,0x8B,0x05,0xA7,0x21,0xEC,0xFF,0x39,0x09,0x48,0xFF,0xE0}
------------------------------------------------------------------------------------------------------------------------
; function: string GetLabel(IImm<byte> src)
; location: [7FFC7C63DED0h, 7FFC7C63DEEBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0008h mov r11,7FFC7C500068h         ; MOV(Mov_r64_imm64) [R11,7ffc7c500068h:imm64]         encoding(10 bytes) = 49 bb 68 00 50 7c fc 7f 00 00
0012h mov rax,[7FFC7C500068h]       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RIP:br,DS:sr)]        encoding(7 bytes) = 48 8b 05 7f 21 ec ff
0019h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
001bh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; code = new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xCA,0x49,0xBB,0x68,0x00,0x50,0x7C,0xFC,0x7F,0x00,0x00,0x48,0x8B,0x05,0x7F,0x21,0xEC,0xFF,0x39,0x09,0x48,0xFF,0xE0}
------------------------------------------------------------------------------------------------------------------------
; function: byte GetValue1(IImm<byte> src)
; location: [7FFC7C63DF00h, 7FFC7C63DF1Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0008h mov r11,7FFC7C500070h         ; MOV(Mov_r64_imm64) [R11,7ffc7c500070h:imm64]         encoding(10 bytes) = 49 bb 70 00 50 7c fc 7f 00 00
0012h mov rax,[7FFC7C500070h]       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RIP:br,DS:sr)]        encoding(7 bytes) = 48 8b 05 57 21 ec ff
0019h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
001bh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; code = new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xCA,0x49,0xBB,0x70,0x00,0x50,0x7C,0xFC,0x7F,0x00,0x00,0x48,0x8B,0x05,0x57,0x21,0xEC,0xFF,0x39,0x09,0x48,0xFF,0xE0}
------------------------------------------------------------------------------------------------------------------------
; function: byte GetValue2(Imm8 src)
; location: [7FFC7C63DF30h, 7FFC7C63DF38h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; code = new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
; function: byte GetValue3(IImm<byte> src)
; location: [7FFC7C63DF50h, 7FFC7C63DF5Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 10
000ah movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 10
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; code = new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x0F,0xB6,0x44,0x24,0x10,0xC3}
------------------------------------------------------------------------------------------------------------------------
; function: byte GetValue4(IImm<byte> src)
; location: [7FFC7C63DF70h, 7FFC7C63DF7Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 10
000ah movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 10
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; code = new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x0F,0xB6,0x44,0x24,0x10,0xC3}
------------------------------------------------------------------------------------------------------------------------
; function: byte GetValue5(IImm<byte> src)
; location: [7FFC7C63F230h, 7FFC7C63F25Eh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rsp],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(4 bytes) = 48 89 14 24
0009h mov byte ptr [rsp+8],0        ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 08 00
000eh movzx eax,byte ptr [rsp]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(4 bytes) = 0f b6 04 24
0012h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0016h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
001bh movsx rax,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 00
001fh mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0023h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
0027h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ah add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; code = new byte[47]{0x48,0x83,0xEC,0x18,0x90,0x48,0x89,0x14,0x24,0xC6,0x44,0x24,0x08,0x00,0x0F,0xB6,0x04,0x24,0x88,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0x48,0x0F,0xBE,0x00,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3}
------------------------------------------------------------------------------------------------------------------------
; function: bool IsSignExtended(IImm<byte> src)
; location: [7FFC7C63F280h, 7FFC7C63F29Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0008h mov r11,7FFC7C500078h         ; MOV(Mov_r64_imm64) [R11,7ffc7c500078h:imm64]         encoding(10 bytes) = 49 bb 78 00 50 7c fc 7f 00 00
0012h mov rax,[7FFC7C500078h]       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RIP:br,DS:sr)]        encoding(7 bytes) = 48 8b 05 df 0d ec ff
0019h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
001bh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; code = new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xCA,0x49,0xBB,0x78,0x00,0x50,0x7C,0xFC,0x7F,0x00,0x00,0x48,0x8B,0x05,0xDF,0x0D,0xEC,0xFF,0x39,0x09,0x48,0xFF,0xE0}
------------------------------------------------------------------------------------------------------------------------
; function: int For(int min, int max)
; location: [7FFC7C63F2B0h, 7FFC7C63F2C3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0009h jge short 0013h               ; JGE(Jge_rel8_64) [NearBranch64]                      encoding(2 bytes) = 7d 08
000bh dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000dh inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
000fh cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0011h jl short 000bh                ; JL(Jl_rel8_64) [NearBranch64]                        encoding(2 bytes) = 7c f8
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; code = new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0x3B,0xCA,0x7D,0x08,0xFF,0xC8,0xFF,0xC1,0x3B,0xCA,0x7C,0xF8,0xC3}
------------------------------------------------------------------------------------------------------------------------
; function: int DoFor(int min, int max)
; location: [7FFC7C63F2E0h, 7FFC7C63F2F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0009h jge short 0013h               ; JGE(Jge_rel8_64) [NearBranch64]                      encoding(2 bytes) = 7d 08
000bh dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000dh inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
000fh cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0011h jl short 000bh                ; JL(Jl_rel8_64) [NearBranch64]                        encoding(2 bytes) = 7c f8
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; code = new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0x3B,0xCA,0x7D,0x08,0xFF,0xC8,0xFF,0xC1,0x3B,0xCA,0x7C,0xF8,0xC3}
------------------------------------------------------------------------------------------------------------------------
