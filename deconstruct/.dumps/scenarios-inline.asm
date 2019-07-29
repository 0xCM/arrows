# 2019-07-29 03:15:51:212
7FFC792AB090h BitSize GetWidth(IImm<byte> src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 8b ca
0008h mov r11,7FFC79170060h         ; MOV(Mov_r64_imm64) [R11,7ffc79170060h:imm64] encoding(10 bytes) = 49 bb 60 00 17 79 fc 7f 00 00
0012h mov rax,[7FFC79170060h]       ; MOV(Mov_r64_rm64) [RAX,Memory]             encoding(7 bytes) = 48 8b 05 b7 4f ec ff
0019h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [Memory,ECX]             encoding(2 bytes) = 39 09
001bh jmp rax                       ; JMP(Jmp_rm64) [RAX]                        encoding(3 bytes) = 48 ff e0
7FFC792AB0ABh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xCA,0x49,0xBB,0x60,0x00,0x17,0x79,0xFC,0x7F,0x00,0x00,0x48,0x8B,0x05,0xB7,0x4F,0xEC,0xFF,0x39,0x09,0x48,0xFF,0xE0}
------------------------------------------------------------------------------------------------------------------------
7FFC792AB0C0h string GetLabel(IImm<byte> src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 8b ca
0008h mov r11,7FFC79170068h         ; MOV(Mov_r64_imm64) [R11,7ffc79170068h:imm64] encoding(10 bytes) = 49 bb 68 00 17 79 fc 7f 00 00
0012h mov rax,[7FFC79170068h]       ; MOV(Mov_r64_rm64) [RAX,Memory]             encoding(7 bytes) = 48 8b 05 8f 4f ec ff
0019h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [Memory,ECX]             encoding(2 bytes) = 39 09
001bh jmp rax                       ; JMP(Jmp_rm64) [RAX]                        encoding(3 bytes) = 48 ff e0
7FFC792AB0DBh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xCA,0x49,0xBB,0x68,0x00,0x17,0x79,0xFC,0x7F,0x00,0x00,0x48,0x8B,0x05,0x8F,0x4F,0xEC,0xFF,0x39,0x09,0x48,0xFF,0xE0}
------------------------------------------------------------------------------------------------------------------------
7FFC792AB0F0h byte GetValue1(IImm<byte> src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 8b ca
0008h mov r11,7FFC79170070h         ; MOV(Mov_r64_imm64) [R11,7ffc79170070h:imm64] encoding(10 bytes) = 49 bb 70 00 17 79 fc 7f 00 00
0012h mov rax,[7FFC79170070h]       ; MOV(Mov_r64_rm64) [RAX,Memory]             encoding(7 bytes) = 48 8b 05 67 4f ec ff
0019h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [Memory,ECX]             encoding(2 bytes) = 39 09
001bh jmp rax                       ; JMP(Jmp_rm64) [RAX]                        encoding(3 bytes) = 48 ff e0
7FFC792AB10Bh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xCA,0x49,0xBB,0x70,0x00,0x17,0x79,0xFC,0x7F,0x00,0x00,0x48,0x8B,0x05,0x67,0x4F,0xEC,0xFF,0x39,0x09,0x48,0xFF,0xE0}
------------------------------------------------------------------------------------------------------------------------
7FFC792AB120h byte GetValue2(Imm8 src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0008h ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC792AB128h ;{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC792AB270h byte GetValue3(IImm<byte> src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [Memory,RDX]             encoding(5 bytes) = 48 89 54 24 10
000ah movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,Memory]          encoding(5 bytes) = 0f b6 44 24 10
000fh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC792AB27Fh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x0F,0xB6,0x44,0x24,0x10,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC792AB290h byte GetValue4(IImm<byte> src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [Memory,RDX]             encoding(5 bytes) = 48 89 54 24 10
000ah movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,Memory]          encoding(5 bytes) = 0f b6 44 24 10
000fh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC792AB29Fh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x0F,0xB6,0x44,0x24,0x10,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC792AC550h byte GetValue5(IImm<byte> src)
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                  encoding(1 byte ) = 90
0005h mov [rsp],rdx                 ; MOV(Mov_rm64_r64) [Memory,RDX]             encoding(4 bytes) = 48 89 14 24
0009h mov byte ptr [rsp+8],0        ; MOV(Mov_rm8_imm8) [Memory,0h:imm8]         encoding(5 bytes) = c6 44 24 08 00
000eh movzx eax,byte ptr [rsp]      ; MOVZX(Movzx_r32_rm8) [EAX,Memory]          encoding(4 bytes) = 0f b6 04 24
0012h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [Memory,AL]                encoding(4 bytes) = 88 44 24 08
0016h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,Memory]                encoding(5 bytes) = 48 8d 44 24 08
001bh movsx rax,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RAX,Memory]          encoding(4 bytes) = 48 0f be 00
001fh mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [Memory,AL]                encoding(4 bytes) = 88 44 24 10
0023h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,Memory]             encoding(4 bytes) = 8b 44 24 10
0027h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
002ah add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
002eh ret                           ; RET(Retnq)                                 encoding(1 byte ) = c3
7FFC792AC57Eh ;{0x48,0x83,0xEC,0x18,0x90,0x48,0x89,0x14,0x24,0xC6,0x44,0x24,0x08,0x00,0x0F,0xB6,0x04,0x24,0x88,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0x48,0x0F,0xBE,0x00,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3}
------------------------------------------------------------------------------------------------------------------------
7FFC792AC5A0h bool IsSignExtended(IImm<byte> src)
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [Memory]                     encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 8b ca
0008h mov r11,7FFC79170078h         ; MOV(Mov_r64_imm64) [R11,7ffc79170078h:imm64] encoding(10 bytes) = 49 bb 78 00 17 79 fc 7f 00 00
0012h mov rax,[7FFC79170078h]       ; MOV(Mov_r64_rm64) [RAX,Memory]             encoding(7 bytes) = 48 8b 05 bf 3a ec ff
0019h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [Memory,ECX]             encoding(2 bytes) = 39 09
001bh jmp rax                       ; JMP(Jmp_rm64) [RAX]                        encoding(3 bytes) = 48 ff e0
7FFC792AC5BBh ;{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xCA,0x49,0xBB,0x78,0x00,0x17,0x79,0xFC,0x7F,0x00,0x00,0x48,0x8B,0x05,0xBF,0x3A,0xEC,0xFF,0x39,0x09,0x48,0xFF,0xE0}
------------------------------------------------------------------------------------------------------------------------
