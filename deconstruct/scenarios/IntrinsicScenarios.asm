; 2019-08-26 19:39:48:562
; function: Vector128<sbyte> addv8u128(in Vector128<sbyte> lhs, in Vector128<sbyte> rhs)
; location: [7FFC7BF13C90h, 7FFC7BF13CA5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpaddb xmm0,xmm0,[r8]         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_Int8,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 fc 00
000eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addv8u128Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xFC,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<sbyte> add2(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
; location: [7FFC7BF13CC0h, 7FFC7BF13CD5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpaddb xmm0,xmm0,[r8]         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_Int8,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 fc 00
000eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add2Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xFC,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<sbyte> add3(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
; location: [7FFC7BF13CF0h, 7FFC7BF13D05h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpaddb xmm0,xmm0,[r8]         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_Int8,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 fc 00
000eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add3Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xFC,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<sbyte> add4(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
; location: [7FFC7BF13D20h, 7FFC7BF13D38h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpaddb ymm0,ymm0,[r8]         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_Int8,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d fc 00
000eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add4Bytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xFC,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<sbyte> add5(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
; location: [7FFC7BF13D50h, 7FFC7BF13D68h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpaddb ymm0,ymm0,[r8]         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_Int8,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d fc 00
000eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add5Bytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xFC,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<long> shiftlw(in Vector256<long> src, byte count)
; location: [7FFC7BF13D80h, 7FFC7BF13DB1h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,50h                   ; SUB(Sub_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 ec 50
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0012h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0018h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h call 7FFC7B8BA1D0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9A6450h:jmp64]        encoding(5 bytes) = e8 2a 64 9a ff
0026h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0029h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002ch add rsp,50h                   ; ADD(Add_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 c4 50
0030h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> shiftlwBytes => new byte[50]{0x56,0x48,0x83,0xEC,0x50,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0x2A,0x64,0x9A,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x50,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> shiftlw(Vector256<ulong> src, byte count)
; location: [7FFC7BF13DD0h, 7FFC7BF13E01h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,50h                   ; SUB(Sub_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 ec 50
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0012h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0018h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h call 7FFC7B8BA1D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9A6408h:jmp64]        encoding(5 bytes) = e8 e2 63 9a ff
0026h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0029h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002ch add rsp,50h                   ; ADD(Add_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 c4 50
0030h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> shiftlwBytes => new byte[50]{0x56,0x48,0x83,0xEC,0x50,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0xE2,0x63,0x9A,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x50,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<float> permute(in Vector128<float> value, byte control)
; location: [7FFC7BF13E20h, 7FFC7BF13E4Eh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0012h vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
0018h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h call 7FFC7B8B9FD0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9A61B0h:jmp64]        encoding(5 bytes) = e8 8a 61 9a ff
0026h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0029h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
002dh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permuteBytes => new byte[47]{0x56,0x48,0x83,0xEC,0x30,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xF9,0x10,0x02,0x48,0x8B,0xCE,0xC5,0xF9,0x29,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0x8A,0x61,0x9A,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<double> permute(in Vector128<double> value, byte control)
; location: [7FFC7BF13E70h, 7FFC7BF13E9Eh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0012h vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
0018h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h call 7FFC7B8B9FD8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9A6168h:jmp64]        encoding(5 bytes) = e8 42 61 9a ff
0026h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0029h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
002dh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permuteBytes => new byte[47]{0x56,0x48,0x83,0xEC,0x30,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xF9,0x10,0x02,0x48,0x8B,0xCE,0xC5,0xF9,0x29,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0x42,0x61,0x9A,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<float> permute(in Vector128<float> lhs, in Vector128<int> control)
; location: [7FFC7BF13EC0h, 7FFC7BF13ED5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpermilps xmm0,xmm0,[r8]      ; VPERMILPS(VEX_Vpermilps_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_Float32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c2 79 0c 00
000eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permuteBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC2,0x79,0x0C,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<double> permute(in Vector128<double> lhs, in Vector128<long> control)
; location: [7FFC7BF13EF0h, 7FFC7BF13F05h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpermilpd xmm0,xmm0,[r8]      ; VPERMILPD(VEX_Vpermilpd_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c2 79 0d 00
000eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permuteBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC2,0x79,0x0D,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<float> permute(Vector256<float> lhs, in Vector256<int> control)
; location: [7FFC7BF13F20h, 7FFC7BF13F38h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpermilps ymm0,ymm0,[r8]      ; VPERMILPS(VEX_Vpermilps_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_Float32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c2 7d 0c 00
000eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permuteBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC2,0x7D,0x0C,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<double> permute(Vector256<double> lhs, in Vector256<long> control)
; location: [7FFC7BF13F50h, 7FFC7BF13F68h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpermilpd ymm0,ymm0,[r8]      ; VPERMILPD(VEX_Vpermilpd_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c2 7d 0d 00
000eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permuteBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC2,0x7D,0x0D,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<sbyte> permute2x128(in Vector256<sbyte> lhs, in Vector256<sbyte> rhs, byte spec)
; location: [7FFC7BF13F80h, 7FFC7BF13FC1h]
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
0031h call 7FFC7B8BA0D0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9A6150h:jmp64]        encoding(5 bytes) = e8 1a 61 9a ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permute2x128Bytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0x1A,0x61,0x9A,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> permute2x128(in Vector256<byte> lhs, in Vector256<byte> rhs, byte spec)
; location: [7FFC7BF13FE0h, 7FFC7BF14021h]
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
0031h call 7FFC7B8BA0D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9A60F8h:jmp64]        encoding(5 bytes) = e8 c2 60 9a ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permute2x128Bytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0xC2,0x60,0x9A,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<short> permute2x128(in Vector256<short> lhs, in Vector256<short> rhs, byte spec)
; location: [7FFC7BF14040h, 7FFC7BF14081h]
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
0031h call 7FFC7B8BA0E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9A60A0h:jmp64]        encoding(5 bytes) = e8 6a 60 9a ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permute2x128Bytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0x6A,0x60,0x9A,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> permute2x128(in Vector256<ushort> lhs, in Vector256<ushort> rhs, byte spec)
; location: [7FFC7BF140A0h, 7FFC7BF140E1h]
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
0031h call 7FFC7B8BA0E8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9A6048h:jmp64]        encoding(5 bytes) = e8 12 60 9a ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permute2x128Bytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0x12,0x60,0x9A,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<int> permute2x128(in Vector256<int> lhs, in Vector256<int> rhs, byte spec)
; location: [7FFC7BF14100h, 7FFC7BF14141h]
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
0031h call 7FFC7B8BA0F0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9A5FF0h:jmp64]        encoding(5 bytes) = e8 ba 5f 9a ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permute2x128Bytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0xBA,0x5F,0x9A,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> permute2x128(in Vector256<uint> lhs, in Vector256<uint> rhs, byte spec)
; location: [7FFC7BF14160h, 7FFC7BF141A1h]
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
0031h call 7FFC7B8BA0F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9A5F98h:jmp64]        encoding(5 bytes) = e8 62 5f 9a ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permute2x128Bytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0x62,0x5F,0x9A,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<long> permute2x128(in Vector256<long> lhs, in Vector256<long> rhs, byte spec)
; location: [7FFC7BF141C0h, 7FFC7BF14201h]
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
0031h call 7FFC7B8BA100h            ; CALL(Call_rel32_64) [FFFFFFFFFF9A5F40h:jmp64]        encoding(5 bytes) = e8 0a 5f 9a ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permute2x128Bytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0x0A,0x5F,0x9A,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> permute2x128(in Vector256<ulong> lhs, in Vector256<ulong> rhs, byte spec)
; location: [7FFC7BF14220h, 7FFC7BF14261h]
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
0031h call 7FFC7B8BA108h            ; CALL(Call_rel32_64) [FFFFFFFFFF9A5EE8h:jmp64]        encoding(5 bytes) = e8 b2 5e 9a ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permute2x128Bytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0xB2,0x5E,0x9A,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<float> permute2x128(in Vector256<float> lhs, in Vector256<float> rhs, byte spec)
; location: [7FFC7BF14280h, 7FFC7BF142C1h]
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
0031h call 7FFC7B8BA030h            ; CALL(Call_rel32_64) [FFFFFFFFFF9A5DB0h:jmp64]        encoding(5 bytes) = e8 7a 5d 9a ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permute2x128Bytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0x7A,0x5D,0x9A,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<double> permute2x128(in Vector256<double> lhs, in Vector256<double> rhs, byte spec)
; location: [7FFC7BF142E0h, 7FFC7BF14321h]
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
0031h call 7FFC7B8BA038h            ; CALL(Call_rel32_64) [FFFFFFFFFF9A5D58h:jmp64]        encoding(5 bytes) = e8 22 5d 9a ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permute2x128Bytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0x22,0x5D,0x9A,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<int> permute8x32(in Vector256<int> src, in Vector256<int> control)
; location: [7FFC7BF14340h, 7FFC7BF14359h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vpermd ymm0,ymm0,[rdx]        ; VPERMD(VEX_Vpermd_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_Int32,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 36 02
000fh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permute8x32Bytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC4,0xE2,0x7D,0x36,0x02,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> permute8x32(in Vector256<uint> src, in Vector256<uint> control)
; location: [7FFC7BF14370h, 7FFC7BF14389h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vpermd ymm0,ymm0,[rdx]        ; VPERMD(VEX_Vpermd_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_Int32,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 36 02
000fh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permute8x32Bytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC4,0xE2,0x7D,0x36,0x02,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<float> permute8x32(in Vector256<float> src, in Vector256<int> control)
; location: [7FFC7BF143A0h, 7FFC7BF143B9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vpermps ymm0,ymm0,[rdx]       ; VPERMPS(VEX_Vpermps_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_Float32,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 16 02
000fh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permute8x32Bytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC4,0xE2,0x7D,0x16,0x02,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<long> permute4x64(in Vector256<long> value, byte control)
; location: [7FFC7BF143D0h, 7FFC7BF14401h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,50h                   ; SUB(Sub_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 ec 50
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0012h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0018h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h call 7FFC7B8BA110h            ; CALL(Call_rel32_64) [FFFFFFFFFF9A5D40h:jmp64]        encoding(5 bytes) = e8 1a 5d 9a ff
0026h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0029h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002ch add rsp,50h                   ; ADD(Add_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 c4 50
0030h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permute4x64Bytes => new byte[50]{0x56,0x48,0x83,0xEC,0x50,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0x1A,0x5D,0x9A,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x50,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> permute4x64(in Vector256<ulong> value, byte control)
; location: [7FFC7BF14420h, 7FFC7BF14451h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,50h                   ; SUB(Sub_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 ec 50
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0012h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0018h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h call 7FFC7B8BA118h            ; CALL(Call_rel32_64) [FFFFFFFFFF9A5CF8h:jmp64]        encoding(5 bytes) = e8 d2 5c 9a ff
0026h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0029h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002ch add rsp,50h                   ; ADD(Add_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 c4 50
0030h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permute4x64Bytes => new byte[50]{0x56,0x48,0x83,0xEC,0x50,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0xD2,0x5C,0x9A,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x50,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<double> permute4x64(in Vector256<double> value, byte control)
; location: [7FFC7BF14470h, 7FFC7BF144A1h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,50h                   ; SUB(Sub_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 ec 50
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0012h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0018h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h call 7FFC7B8BA120h            ; CALL(Call_rel32_64) [FFFFFFFFFF9A5CB0h:jmp64]        encoding(5 bytes) = e8 8a 5c 9a ff
0026h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0029h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002ch add rsp,50h                   ; ADD(Add_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 c4 50
0030h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> permute4x64Bytes => new byte[50]{0x56,0x48,0x83,0xEC,0x50,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0x8A,0x5C,0x9A,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x50,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testz(in Vector128<byte> lhs, in Vector128<byte> rhs)
; location: [7FFC7BF144C0h, 7FFC7BF144D4h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vptest xmm0,xmmword ptr [rdx] ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,mem(UInt128,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c4 e2 79 17 02
000eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testzBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x17,0x02,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testz(in Vector128<long> lhs, in Vector128<long> rhs)
; location: [7FFC7BF144F0h, 7FFC7BF14504h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vptest xmm0,xmmword ptr [rdx] ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,mem(UInt128,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c4 e2 79 17 02
000eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testzBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x17,0x02,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testz(in Vector128<ulong> lhs, in Vector128<ulong> rhs)
; location: [7FFC7BF14520h, 7FFC7BF14534h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vptest xmm0,xmmword ptr [rdx] ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,mem(UInt128,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c4 e2 79 17 02
000eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testzBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x17,0x02,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testz(in Vector128<float> lhs, in Vector128<float> rhs)
; location: [7FFC7BF14550h, 7FFC7BF14564h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vtestps xmm0,[rdx]            ; VTESTPS(VEX_Vtestps_xmm_xmmm128) [XMM0,mem(Packed128_Float32,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c4 e2 79 0e 02
000eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testzBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x0E,0x02,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testz(in Vector128<double> lhs, in Vector128<double> rhs)
; location: [7FFC7BF14580h, 7FFC7BF14594h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vtestpd xmm0,[rdx]            ; VTESTPD(VEX_Vtestpd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c4 e2 79 0f 02
000eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testzBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x0F,0x02,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testz(in Vector256<long> lhs, in Vector256<long> rhs)
; location: [7FFC7BF145B0h, 7FFC7BF145C7h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vptest ymm0,ymmword ptr [rdx] ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 17 02
000eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testzBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE2,0x7D,0x17,0x02,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testz(in Vector256<ulong> lhs, in Vector256<ulong> rhs)
; location: [7FFC7BF145E0h, 7FFC7BF145F7h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vptest ymm0,ymmword ptr [rdx] ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 17 02
000eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testzBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE2,0x7D,0x17,0x02,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testz(in Vector256<float> lhs, in Vector256<float> rhs)
; location: [7FFC7BF14610h, 7FFC7BF14627h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vtestps ymm0,[rdx]            ; VTESTPS(VEX_Vtestps_ymm_ymmm256) [YMM0,mem(Packed256_Float32,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 0e 02
000eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testzBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE2,0x7D,0x0E,0x02,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testz(in Vector256<double> lhs, in Vector256<double> rhs)
; location: [7FFC7BF14640h, 7FFC7BF14657h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vtestpd ymm0,[rdx]            ; VTESTPD(VEX_Vtestpd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 0f 02
000eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testzBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE2,0x7D,0x0F,0x02,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
