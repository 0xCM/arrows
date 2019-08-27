; 2019-08-26 19:39:48:670
; function: byte rotr8u(byte src, byte offset)
; location: [7FFC7BF17210h, 7FFC7BF17220h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000bh ror eax,cl                    ; ROR(Ror_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c8
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotr8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0xD3,0xC8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort rotr16u(ushort src, ushort offset)
; location: [7FFC7BF17240h, 7FFC7BF17250h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
000bh ror eax,cl                    ; ROR(Ror_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c8
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotr16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0xD3,0xC8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rotr32u(uint src, uint offset)
; location: [7FFC7BF17270h, 7FFC7BF1727Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h ror eax,cl                    ; ROR(Ror_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotr32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotr64u(ulong src, ulong offset)
; location: [7FFC7BF17290h, 7FFC7BF1729Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah ror rax,cl                    ; ROR(Ror_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotr64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotl8u(byte x, byte offset)
; location: [7FFC7BF172B0h, 7FFC7BF172C0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000bh rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0xD3,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort rotl16u(ushort x, ushort offset)
; location: [7FFC7BF172E0h, 7FFC7BF172F0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
000bh rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0xD3,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rotl32u(uint x, uint offset)
; location: [7FFC7BF17310h, 7FFC7BF1731Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotl64u(ulong x, ulong offset)
; location: [7FFC7BF17330h, 7FFC7BF1733Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah rol rax,cl                    ; ROL(Rol_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void loopedCall(int count, Action<int> callee)
; location: [7FFC7BF17350h, 7FFC7BF1737Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h mov esi,ecx                   ; MOV(Mov_r32_rm32) [ESI,ECX]                          encoding(2 bytes) = 8b f1
0009h mov rdi,rdx                   ; MOV(Mov_r64_rm64) [RDI,RDX]                          encoding(3 bytes) = 48 8b fa
000ch xor ebx,ebx                   ; XOR(Xor_r32_rm32) [EBX,EBX]                          encoding(2 bytes) = 33 db
000eh test esi,esi                  ; TEST(Test_rm32_r32) [ESI,ESI]                        encoding(2 bytes) = 85 f6
0010h jle short 0024h               ; JLE(Jle_rel8_64) [24h:jmp64]                         encoding(2 bytes) = 7e 12
0012h mov rax,rdi                   ; MOV(Mov_r64_rm64) [RAX,RDI]                          encoding(3 bytes) = 48 8b c7
0015h mov rcx,[rax+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(4 bytes) = 48 8b 48 08
0019h mov edx,ebx                   ; MOV(Mov_r32_rm32) [EDX,EBX]                          encoding(2 bytes) = 8b d3
001bh call qword ptr [rax+18h]      ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,DS:sr)]      encoding(3 bytes) = ff 50 18
001eh inc ebx                       ; INC(Inc_rm32) [EBX]                                  encoding(2 bytes) = ff c3
0020h cmp ebx,esi                   ; CMP(Cmp_r32_rm32) [EBX,ESI]                          encoding(2 bytes) = 3b de
0022h jl short 0012h                ; JL(Jl_rel8_64) [12h:jmp64]                           encoding(2 bytes) = 7c ee
0024h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0028h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0029h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
002ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loopedCallBytes => new byte[44]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0x8B,0xF1,0x48,0x8B,0xFA,0x33,0xDB,0x85,0xF6,0x7E,0x12,0x48,0x8B,0xC7,0x48,0x8B,0x48,0x08,0x8B,0xD3,0xFF,0x50,0x18,0xFF,0xC3,0x3B,0xDE,0x7C,0xEE,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void swap8u(ref byte x, ref byte y)
; location: [7FFC7BF173A0h, 7FFC7BF173B1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h movzx r8d,byte ptr [rdx]      ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RDX:br,DS:sr)]      encoding(4 bytes) = 44 0f b6 02
000ch mov [rcx],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 01
000fh mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> swap8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x44,0x0F,0xB6,0x02,0x44,0x88,0x01,0x88,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void swap32i(ref int x, ref int y)
; location: [7FFC7BF173D0h, 7FFC7BF173DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h mov r8d,[rdx]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 44 8b 02
000ah mov [rcx],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R8D]        encoding(3 bytes) = 44 89 01
000dh mov [rdx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]        encoding(2 bytes) = 89 02
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> swap32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x44,0x8B,0x02,0x44,0x89,0x01,0x89,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int space3()
; location: [7FFC7BF173F0h, 7FFC7BF17435h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rcx,7FFC7B956B80h         ; MOV(Mov_r64_imm64) [RCX,7ffc7b956b80h:imm64]         encoding(10 bytes) = 48 b9 80 6b 95 7b fc 7f 00 00
000fh mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
0014h call 7FFCDB3BC680h            ; CALL(Call_rel32_64) [5F4A5290h:jmp64]                encoding(5 bytes) = e8 77 52 4a 5f
0019h mov rax,7FFC7B956BDCh         ; MOV(Mov_r64_imm64) [RAX,7ffc7b956bdch:imm64]         encoding(10 bytes) = 48 b8 dc 6b 95 7b fc 7f 00 00
0023h mov eax,[rax]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 00
0025h mov rdx,7FFC7B956BE0h         ; MOV(Mov_r64_imm64) [RDX,7ffc7b956be0h:imm64]         encoding(10 bytes) = 48 ba e0 6b 95 7b fc 7f 00 00
002fh mov edx,[rdx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 12
0031h mov rcx,7FFC7B956BE4h         ; MOV(Mov_r64_imm64) [RCX,7ffc7b956be4h:imm64]         encoding(10 bytes) = 48 b9 e4 6b 95 7b fc 7f 00 00
003bh mov ecx,[rcx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 09
003dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
003fh add eax,ecx                   ; ADD(Add_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 03 c1
0041h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> space3Bytes => new byte[70]{0x48,0x83,0xEC,0x28,0x90,0x48,0xB9,0x80,0x6B,0x95,0x7B,0xFC,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0x77,0x52,0x4A,0x5F,0x48,0xB8,0xDC,0x6B,0x95,0x7B,0xFC,0x7F,0x00,0x00,0x8B,0x00,0x48,0xBA,0xE0,0x6B,0x95,0x7B,0xFC,0x7F,0x00,0x00,0x8B,0x12,0x48,0xB9,0xE4,0x6B,0x95,0x7B,0xFC,0x7F,0x00,0x00,0x8B,0x09,0x03,0xC2,0x03,0xC1,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
