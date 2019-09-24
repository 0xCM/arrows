; 2019-09-24 02:30:06:135
; function: int abs(int x)
; location: [7FFC872FC260h, 7FFC872FC26Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
000ah add edx,eax                   ; ADD(Add_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 03 d0
000ch xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC1,0xF8,0x1F,0x03,0xD0,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint add(uint a, uint b)
; location: [7FFC872FC280h, 7FFC872FC289h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h add edx,ecx                   ; ADD(Add_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 03 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x03,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and(uint a, uint b)
; location: [7FFC872FC2A0h, 7FFC872FC2A9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> load(in byte src)
; location: [7FFC872FC2C0h, 7FFC872FC2D3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
0009h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
000dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0010h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loadBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFF,0xF0,0x02,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint xor32u(uint x, uint y)
; location: [7FFC872FC6F0h, 7FFC872FC6FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xCA,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> xor256x32u(Vector256<uint> ymm0, Vector256<uint> ymm1)
; location: [7FFC872FCD50h, 7FFC872FCD6Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor256x32uBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> and256x32u(Vector256<uint> ymm0, Vector256<uint> ymm1)
; location: [7FFC872FD190h, 7FFC872FD1ACh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and256x32uBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xDB,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vpxor(in byte ymm0, in byte ymm1, in byte ymm2, in byte ymm3)
; location: [7FFC872FD1C0h, 7FFC872FD1F2h]
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
; function: Vector256<int> blend_256x32i(in int ymm0, int ymm1)
; location: [7FFC872FD210h, 7FFC872FD234h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
000ah vmovdqa ymm0,ymmword ptr [rdx]; VMOVDQA(VEX_Vmovdqa_ymm_ymmm256) [YMM0,mem(Packed256_Int32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 6f 02
000eh vmovdqa ymm1,ymmword ptr [rsp+18h]; VMOVDQA(VEX_Vmovdqa_ymm_ymmm256) [YMM1,mem(Packed256_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fd 6f 4c 24 18
0014h vpblendd ymm0,ymm0,ymm1,55h   ; VPBLENDD(VEX_Vpblendd_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM1,55h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 02 c1 55
001ah vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blend_256x32iBytes => new byte[37]{0xC5,0xF8,0x77,0x66,0x90,0x44,0x89,0x44,0x24,0x18,0xC5,0xFD,0x6F,0x02,0xC5,0xFD,0x6F,0x4C,0x24,0x18,0xC4,0xE3,0x7D,0x02,0xC1,0x55,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vpaddq(in ulong ymm0, in ulong ymm1, in ulong ymm2, in ulong ymm3, in ulong ymm4, in ulong ymm5, in ulong ymm6, in ulong ymm7, in ulong ymm8, in ulong ymm9, in ulong ymm10, in ulong ymm11, in ulong ymm12, in ulong ymm13, in ulong ymm14, in ulong ymm15)
; location: [7FFC872FD250h, 7FFC872FD3DFh]
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
004bh vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
004fh vlddqu ymm1,ymmword ptr [r8]  ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 08
0054h vlddqu ymm2,ymmword ptr [r9]  ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 11
0059h mov rax,[rsp+0D0h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 d0 00 00 00
0061h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0065h mov rax,[rsp+0D8h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 d8 00 00 00
006dh vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
0071h mov rax,[rsp+0E0h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 e0 00 00 00
0079h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
007dh mov rax,[rsp+0E8h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 e8 00 00 00
0085h vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
0089h mov rax,[rsp+0F0h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 f0 00 00 00
0091h vlddqu ymm7,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM7,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 38
0095h mov rax,[rsp+0F8h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 f8 00 00 00
009dh vlddqu ymm8,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM8,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 7f f0 00
00a1h mov rax,[rsp+100h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 00 01 00 00
00a9h vlddqu ymm9,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM9,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 7f f0 08
00adh mov rax,[rsp+108h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 08 01 00 00
00b5h vlddqu ymm10,ymmword ptr [rax]; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM10,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 7f f0 10
00b9h mov rax,[rsp+110h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 10 01 00 00
00c1h vlddqu ymm11,ymmword ptr [rax]; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM11,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 7f f0 18
00c5h mov rax,[rsp+118h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 18 01 00 00
00cdh vlddqu ymm12,ymmword ptr [rax]; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM12,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 7f f0 20
00d1h mov rax,[rsp+120h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 20 01 00 00
00d9h vlddqu ymm13,ymmword ptr [rax]; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM13,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 7f f0 28
00ddh mov rax,[rsp+128h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 28 01 00 00
00e5h vlddqu ymm14,ymmword ptr [rax]; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM14,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 7f f0 30
00e9h mov rax,[rsp+130h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 30 01 00 00
00f1h vlddqu ymm15,ymmword ptr [rax]; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM15,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 7f f0 38
00f5h vpaddq ymm0,ymm0,ymm1         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 4 bytes) = c5 fd d4 c1
00f9h vpaddq ymm1,ymm2,ymm3         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM1,YMM2,YMM3]  encoding(VEX, 4 bytes) = c5 ed d4 cb
00fdh vpaddq ymm2,ymm4,ymm5         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM2,YMM4,YMM5]  encoding(VEX, 4 bytes) = c5 dd d4 d5
0101h vpaddq ymm3,ymm6,ymm7         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM3,YMM6,YMM7]  encoding(VEX, 4 bytes) = c5 cd d4 df
0105h vpaddq ymm4,ymm8,ymm9         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM4,YMM8,YMM9]  encoding(VEX, 5 bytes) = c4 c1 3d d4 e1
010ah vpaddq ymm5,ymm10,ymm11       ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM5,YMM10,YMM11] encoding(VEX, 5 bytes) = c4 c1 2d d4 eb
010fh vpaddq ymm6,ymm12,ymm13       ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM6,YMM12,YMM13] encoding(VEX, 5 bytes) = c4 c1 1d d4 f5
0114h vpaddq ymm7,ymm14,ymm15       ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM7,YMM14,YMM15] encoding(VEX, 5 bytes) = c4 c1 0d d4 ff
0119h vpaddq ymm0,ymm0,ymm1         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 4 bytes) = c5 fd d4 c1
011dh vpaddq ymm1,ymm2,ymm3         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM1,YMM2,YMM3]  encoding(VEX, 4 bytes) = c5 ed d4 cb
0121h vpaddq ymm2,ymm3,ymm4         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM2,YMM3,YMM4]  encoding(VEX, 4 bytes) = c5 e5 d4 d4
0125h vpaddq ymm3,ymm4,ymm5         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM3,YMM4,YMM5]  encoding(VEX, 4 bytes) = c5 dd d4 dd
0129h vpaddq ymm4,ymm6,ymm7         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM4,YMM6,YMM7]  encoding(VEX, 4 bytes) = c5 cd d4 e7
012dh vpaddq ymm0,ymm0,ymm1         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 4 bytes) = c5 fd d4 c1
0131h vpaddq ymm1,ymm2,ymm3         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM1,YMM2,YMM3]  encoding(VEX, 4 bytes) = c5 ed d4 cb
0135h vpaddq ymm0,ymm0,ymm1         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 4 bytes) = c5 fd d4 c1
0139h vpaddq ymm0,ymm0,ymm4         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM4]  encoding(VEX, 4 bytes) = c5 fd d4 c4
013dh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
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
0185h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0188h add rsp,0A8h                  ; ADD(Add_rm64_imm32) [RSP,a8h:imm64]                  encoding(7 bytes) = 48 81 c4 a8 00 00 00
018fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpaddqBytes => new byte[400]{0x48,0x81,0xEC,0xA8,0x00,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0xB4,0x24,0x90,0x00,0x00,0x00,0xC5,0xF8,0x29,0xBC,0x24,0x80,0x00,0x00,0x00,0xC5,0x78,0x29,0x44,0x24,0x70,0xC5,0x78,0x29,0x4C,0x24,0x60,0xC5,0x78,0x29,0x54,0x24,0x50,0xC5,0x78,0x29,0x5C,0x24,0x40,0xC5,0x78,0x29,0x64,0x24,0x30,0xC5,0x78,0x29,0x6C,0x24,0x20,0xC5,0x78,0x29,0x74,0x24,0x10,0xC5,0x78,0x29,0x3C,0x24,0xC5,0xFF,0xF0,0x02,0xC4,0xC1,0x7F,0xF0,0x08,0xC4,0xC1,0x7F,0xF0,0x11,0x48,0x8B,0x84,0x24,0xD0,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x18,0x48,0x8B,0x84,0x24,0xD8,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x20,0x48,0x8B,0x84,0x24,0xE0,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x28,0x48,0x8B,0x84,0x24,0xE8,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x30,0x48,0x8B,0x84,0x24,0xF0,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x38,0x48,0x8B,0x84,0x24,0xF8,0x00,0x00,0x00,0xC5,0x7F,0xF0,0x00,0x48,0x8B,0x84,0x24,0x00,0x01,0x00,0x00,0xC5,0x7F,0xF0,0x08,0x48,0x8B,0x84,0x24,0x08,0x01,0x00,0x00,0xC5,0x7F,0xF0,0x10,0x48,0x8B,0x84,0x24,0x10,0x01,0x00,0x00,0xC5,0x7F,0xF0,0x18,0x48,0x8B,0x84,0x24,0x18,0x01,0x00,0x00,0xC5,0x7F,0xF0,0x20,0x48,0x8B,0x84,0x24,0x20,0x01,0x00,0x00,0xC5,0x7F,0xF0,0x28,0x48,0x8B,0x84,0x24,0x28,0x01,0x00,0x00,0xC5,0x7F,0xF0,0x30,0x48,0x8B,0x84,0x24,0x30,0x01,0x00,0x00,0xC5,0x7F,0xF0,0x38,0xC5,0xFD,0xD4,0xC1,0xC5,0xED,0xD4,0xCB,0xC5,0xDD,0xD4,0xD5,0xC5,0xCD,0xD4,0xDF,0xC4,0xC1,0x3D,0xD4,0xE1,0xC4,0xC1,0x2D,0xD4,0xEB,0xC4,0xC1,0x1D,0xD4,0xF5,0xC4,0xC1,0x0D,0xD4,0xFF,0xC5,0xFD,0xD4,0xC1,0xC5,0xED,0xD4,0xCB,0xC5,0xE5,0xD4,0xD4,0xC5,0xDD,0xD4,0xDD,0xC5,0xCD,0xD4,0xE7,0xC5,0xFD,0xD4,0xC1,0xC5,0xED,0xD4,0xCB,0xC5,0xFD,0xD4,0xC1,0xC5,0xFD,0xD4,0xC4,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x28,0xB4,0x24,0x90,0x00,0x00,0x00,0xC5,0xF8,0x28,0xBC,0x24,0x80,0x00,0x00,0x00,0xC5,0x78,0x28,0x44,0x24,0x70,0xC5,0x78,0x28,0x4C,0x24,0x60,0xC5,0x78,0x28,0x54,0x24,0x50,0xC5,0x78,0x28,0x5C,0x24,0x40,0xC5,0x78,0x28,0x64,0x24,0x30,0xC5,0x78,0x28,0x6C,0x24,0x20,0xC5,0x78,0x28,0x74,0x24,0x10,0xC5,0x78,0x28,0x3C,0x24,0xC5,0xF8,0x77,0x48,0x81,0xC4,0xA8,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
