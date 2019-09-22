; 2019-09-22 15:32:03:424
; function: XMM pmovzxbw(XMM a)
; location: [7FFC895AF7F0h, 7FFC895AF815h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu xmm0,xmmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 02
000bh vpmovzxbw xmm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 30 c0
0010h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0015h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001ah vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pmovzxbwBytes => new byte[38]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0xF0,0x02,0xC4,0xE2,0x79,0x30,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> pmovzxbw_ref(Vector128<byte> a)
; location: [7FFC895AF830h, 7FFC895AF841h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vpmovzxbw xmm0,qword ptr [rdx]; VPMOVZXBW(VEX_Vpmovzxbw_xmm_xmmm64) [XMM0,mem(Packed64_UInt8,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c4 e2 79 30 02
000ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pmovzxbw_refBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0x79,0x30,0x02,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: XMM pmovzxbd(XMM a)
; location: [7FFC895AF860h, 7FFC895AF885h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu xmm0,xmmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 02
000bh vpmovzxbd xmm0,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 31 c0
0010h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0015h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001ah vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pmovzxbdBytes => new byte[38]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0xF0,0x02,0xC4,0xE2,0x79,0x31,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref XMM pmovzxbd_out_xmm(XMM a, out XMM dst)
; location: [7FFC895AF8A0h, 7FFC895AF8C5h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu xmm0,xmmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 01
000bh vpmovzxbd xmm0,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 31 c0
0010h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0015h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001ah vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
001eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0021h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pmovzxbd_out_xmmBytes => new byte[38]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0xF0,0x01,0xC4,0xE2,0x79,0x31,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x02,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<int> pmovzxbd_out_vec(XMM a, out Vector128<int> dst)
; location: [7FFC895AF8E0h, 7FFC895AF8F5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vlddqu xmm0,xmmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 01
0009h vpmovzxbd xmm0,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 31 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pmovzxbd_out_vecBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0xF0,0x01,0xC4,0xE2,0x79,0x31,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<int> pmovzxbd_ref(Vector128<byte> a)
; location: [7FFC895AF910h, 7FFC895AF921h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vpmovzxbd xmm0,dword ptr [rdx]; VPMOVZXBD(VEX_Vpmovzxbd_xmm_xmmm32) [XMM0,mem(Packed32_UInt8,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c4 e2 79 31 02
000ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pmovzxbd_refBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0x79,0x31,0x02,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: XMM pmovzxbq(XMM a)
; location: [7FFC895AF940h, 7FFC895AF965h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu xmm0,xmmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 02
000bh vpmovzxbq xmm0,xmm0           ; VPMOVZXBQ(VEX_Vpmovzxbq_xmm_xmmm16) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 32 c0
0010h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0015h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001ah vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pmovzxbqBytes => new byte[38]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0xF0,0x02,0xC4,0xE2,0x79,0x32,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: XMM pmovzxwd(XMM a)
; location: [7FFC895AFD90h, 7FFC895AFDB5h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu xmm0,xmmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 02
000bh vpmovzxwd xmm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 33 c0
0010h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0015h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001ah vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pmovzxwdBytes => new byte[38]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0xF0,0x02,0xC4,0xE2,0x79,0x33,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: XMM pmovzxwq(XMM a)
; location: [7FFC895AFDD0h, 7FFC895AFDF5h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu xmm0,xmmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 02
000bh vpmovzxwq xmm0,xmm0           ; VPMOVZXWQ(VEX_Vpmovzxwq_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 34 c0
0010h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0015h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001ah vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pmovzxwqBytes => new byte[38]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0xF0,0x02,0xC4,0xE2,0x79,0x34,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: XMM pmovzxdq(XMM a)
; location: [7FFC895AFE10h, 7FFC895AFE35h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu xmm0,xmmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 02
000bh vpmovzxdq xmm0,xmm0           ; VPMOVZXDQ(VEX_Vpmovzxdq_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 35 c0
0010h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0015h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001ah vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pmovzxdqBytes => new byte[38]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0xF0,0x02,0xC4,0xE2,0x79,0x35,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: XMM pmovzxbd32(XMM a)
; location: [7FFC895AFE50h, 7FFC895AFE75h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu xmm0,xmmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 02
000bh vpmovzxbd xmm0,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 31 c0
0010h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0015h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001ah vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pmovzxbd32Bytes => new byte[38]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0xF0,0x02,0xC4,0xE2,0x79,0x31,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: XMM pmovzxbq64(XMM a)
; location: [7FFC895AFE90h, 7FFC895AFEB5h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu xmm0,xmmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 02
000bh vpmovzxbq xmm0,xmm0           ; VPMOVZXBQ(VEX_Vpmovzxbq_xmm_xmmm16) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 32 c0
0010h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0015h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001ah vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pmovzxbq64Bytes => new byte[38]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0xF0,0x02,0xC4,0xE2,0x79,0x32,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: XMM pmovzxbw16(XMM a)
; location: [7FFC895AFED0h, 7FFC895AFEF5h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu xmm0,xmmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 02
000bh vpmovzxbw xmm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 30 c0
0010h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0015h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001ah vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pmovzxbw16Bytes => new byte[38]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0xF0,0x02,0xC4,0xE2,0x79,0x30,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref XMM movdqa(XMM src, ref XMM dst)
; location: [7FFC895B0320h, 7FFC895B0340h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu xmm0,xmmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 01
000bh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0010h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0015h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
0019h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
001ch add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> movdqaBytes => new byte[33]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0xF0,0x01,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x02,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref XMEM movdqa(XMM src, ref XMEM dst)
; location: [7FFC895B0360h, 7FFC895B0380h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu xmm0,xmmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 01
000bh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0010h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0015h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
0019h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
001ch add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> movdqaBytes => new byte[33]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0xF0,0x01,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x02,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref YMM vmovdqa(YMM src, ref YMM dst)
; location: [7FFC895B0D00h, 7FFC895B0D2Eh]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu ymm0,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 01
000bh vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0010h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0015h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
0019h vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
001fh vmovdqu xmmword ptr [rdx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 42 10
0024h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0027h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002ah add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmovdqaBytes => new byte[47]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0xC5,0xFF,0xF0,0x01,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x02,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x42,0x10,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref YMEM vmovdqa(YMM src, ref YMEM dst)
; location: [7FFC895B1160h, 7FFC895B118Eh]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu ymm0,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 01
000bh vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0010h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0015h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
0019h vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
001fh vmovdqu xmmword ptr [rdx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 42 10
0024h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0027h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002ah add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmovdqaBytes => new byte[47]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0xC5,0xFF,0xF0,0x01,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x02,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x42,0x10,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<int> vpadd_ref1(Vector256<int> v1, Vector256<int> v2)
; location: [7FFC895B11B0h, 7FFC895B11C8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpaddd ymm0,ymm0,[r8]         ; VPADDD(VEX_Vpaddd_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d fe 00
000eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpadd_ref1Bytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xFE,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<int> vpadd_ref2(Vec256<int> v1, Vec256<int> v2)
; location: [7FFC895B11E0h, 7FFC895B11FCh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpaddd ymm0,ymm0,ymm1         ; VPADDD(VEX_Vpaddd_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 4 bytes) = c5 fd fe c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpadd_ref2Bytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xFE,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: YMM vpadd(YMM ymm0, YMM ymm1)
; location: [7FFC895B1210h, 7FFC895B1247h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
000bh vlddqu ymm1,ymmword ptr [r8]  ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 08
0010h vpaddq ymm0,ymm0,ymm1         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 4 bytes) = c5 fd d4 c1
0014h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0019h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001eh vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0022h vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
0028h vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0033h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpaddBytes => new byte[56]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0xC5,0xFF,0xF0,0x02,0xC4,0xC1,0x7F,0xF0,0x08,0xC5,0xFD,0xD4,0xC1,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x41,0x10,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<long> vpadd(YMM ymm0, YMM ymm1, ref Vector256<long> dst)
; location: [7FFC895B1270h, 7FFC895B128Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vlddqu ymm0,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 01
0009h vlddqu ymm1,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 0a
000dh vpaddq ymm0,ymm0,ymm1         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 4 bytes) = c5 fd d4 c1
0011h vmovupd [r8],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R8:br,DS:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 00
0016h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpaddBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFF,0xF0,0x01,0xC5,0xFF,0xF0,0x0A,0xC5,0xFD,0xD4,0xC1,0xC4,0xC1,0x7D,0x11,0x00,0x49,0x8B,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: XMM vpblendw(XMM xmm2, XMM xmm3, Imm8 imm8)
; location: [7FFC895B12A0h, 7FFC895B12F6h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,60h                   ; SUB(Sub_rm64_imm8) [RSP,60h:imm64]                   encoding(4 bytes) = 48 83 ec 60
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh vlddqu xmm0,xmmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 02
000fh vlddqu xmm1,xmmword ptr [r8]  ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 08
0014h lea rcx,[rsp+50h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 50
0019h vmovapd [rsp+30h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 30
001fh vmovapd [rsp+20h],xmm1        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 f9 29 4c 24 20
0025h lea rdx,[rsp+30h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 30
002ah lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
002fh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0033h call 7FFC89599570h            ; CALL(Call_rel32_64) [FFFFFFFFFFFE82D0h:jmp64]        encoding(5 bytes) = e8 98 82 fe ff
0038h vmovapd xmm0,[rsp+50h]        ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 28 44 24 50
003eh vmovapd [rsp+40h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 40
0044h vmovdqu xmm0,xmmword ptr [rsp+40h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 40
004ah vmovdqu xmmword ptr [rsi],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSI:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 06
004eh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0051h add rsp,60h                   ; ADD(Add_rm64_imm8) [RSP,60h:imm64]                   encoding(4 bytes) = 48 83 c4 60
0055h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0056h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpblendwBytes => new byte[87]{0x56,0x48,0x83,0xEC,0x60,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFB,0xF0,0x02,0xC4,0xC1,0x7B,0xF0,0x08,0x48,0x8D,0x4C,0x24,0x50,0xC5,0xF9,0x29,0x44,0x24,0x30,0xC5,0xF9,0x29,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x30,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0x98,0x82,0xFE,0xFF,0xC5,0xF9,0x28,0x44,0x24,0x50,0xC5,0xF9,0x29,0x44,0x24,0x40,0xC5,0xFA,0x6F,0x44,0x24,0x40,0xC5,0xFA,0x7F,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x60,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vpblendw_ref(Vector128<ushort> xmm0, Vector128<ushort> xmm1, byte imm8)
; location: [7FFC895B1320h, 7FFC895B135Eh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000fh vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
0014h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0017h vmovapd [rsp+30h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 30
001dh vmovapd [rsp+20h],xmm1        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 f9 29 4c 24 20
0023h lea rdx,[rsp+30h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 30
0028h lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
002dh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0031h call 7FFC89599570h            ; CALL(Call_rel32_64) [FFFFFFFFFFFE8250h:jmp64]        encoding(5 bytes) = e8 1a 82 fe ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
003dh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpblendw_refBytes => new byte[63]{0x56,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0x48,0x8B,0xCE,0xC5,0xF9,0x29,0x44,0x24,0x30,0xC5,0xF9,0x29,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x30,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0x1A,0x82,0xFE,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x40,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vpblendw_ref(Vector256<ushort> xmm0, Vector256<ushort> xmm1, byte imm8)
; location: [7FFC895B1380h, 7FFC895B13C1h]
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
0031h call 7FFC8959A9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFFFE9678h:jmp64]        encoding(5 bytes) = e8 42 96 fe ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpblendw_refBytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0x42,0x96,0xFE,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vpblendd_ref(Vector256<uint> xmm0, Vector256<uint> xmm1, byte imm8)
; location: [7FFC895B13E0h, 7FFC895B1421h]
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
0031h call 7FFC8959AA08h            ; CALL(Call_rel32_64) [FFFFFFFFFFFE9628h:jmp64]        encoding(5 bytes) = e8 f2 95 fe ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpblendd_refBytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0xF2,0x95,0xFE,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<float> vpblendps_ref(Vector256<float> xmm0, Vector256<float> xmm1, byte imm8)
; location: [7FFC895B1850h, 7FFC895B1891h]
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
0031h call 7FFC89599CA8h            ; CALL(Call_rel32_64) [FFFFFFFFFFFE8458h:jmp64]        encoding(5 bytes) = e8 22 84 fe ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpblendps_refBytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0x22,0x84,0xFE,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: XMM vpcmpeqb(XMM xmm0, XMM xmm1)
; location: [7FFC895B18B0h, 7FFC895B18D9h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu xmm0,xmmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 02
000bh vlddqu xmm1,xmmword ptr [r8]  ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 08
0010h vpcmpeqb xmm0,xmm0,xmm1       ; VPCMPEQB(VEX_Vpcmpeqb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 74 c1
0014h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0019h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001eh vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0022h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpcmpeqbBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0xF0,0x02,0xC4,0xC1,0x7B,0xF0,0x08,0xC5,0xF9,0x74,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<byte> vpcmpeqb(XMM xmm0, XMM xmm1, ref Vector128<byte> dst)
; location: [7FFC895B1900h, 7FFC895B1919h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vlddqu xmm0,xmmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 01
0009h vlddqu xmm1,xmmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 0a
000dh vpcmpeqb xmm0,xmm0,xmm1       ; VPCMPEQB(VEX_Vpcmpeqb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 74 c1
0011h vmovupd [r8],xmm0             ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,R8:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 79 11 00
0016h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpcmpeqbBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0xF0,0x01,0xC5,0xFB,0xF0,0x0A,0xC5,0xF9,0x74,0xC1,0xC4,0xC1,0x79,0x11,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vcmpeqq_ref(Vector256<ulong> ymm0, Vector256<ulong> ymm1)
; location: [7FFC895B1930h, 7FFC895B1948h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpcmpeqq ymm0,ymm0,[r8]       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_Int64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c2 7d 29 00
000eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmpeqq_refBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC2,0x7D,0x29,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: YMM vcmpeqq(YMM ymm0, YMM ymm1)
; location: [7FFC895B1960h, 7FFC895B1998h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
000bh vlddqu ymm1,ymmword ptr [r8]  ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 08
0010h vpcmpeqq ymm0,ymm0,ymm1       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 29 c1
0015h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
001ah vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001fh vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0023h vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
0029h vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
002eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0031h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0034h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmpeqqBytes => new byte[57]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0xC5,0xFF,0xF0,0x02,0xC4,0xC1,0x7F,0xF0,0x08,0xC4,0xE2,0x7D,0x29,0xC1,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x41,0x10,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<ulong> vcmpeqq(YMM ymm0, YMM ymm1, ref Vector256<ulong> dst)
; location: [7FFC895B19C0h, 7FFC895B19DDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vlddqu ymm0,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 01
0009h vlddqu ymm1,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 0a
000dh vpcmpeqq ymm0,ymm0,ymm1       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 29 c1
0012h vmovupd [r8],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R8:br,DS:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 00
0017h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmpeqqBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFF,0xF0,0x01,0xC5,0xFF,0xF0,0x0A,0xC4,0xE2,0x7D,0x29,0xC1,0xC4,0xC1,0x7D,0x11,0x00,0x49,0x8B,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vpcmpeqb(YMM ymm0, YMM ymm1)
; location: [7FFC895B19F0h, 7FFC895B1A0Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
0009h vlddqu ymm1,ymmword ptr [r8]  ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 08
000eh vpcmpeqb ymm0,ymm0,ymm1       ; VPCMPEQB(VEX_Vpcmpeqb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 74 c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpcmpeqbBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFF,0xF0,0x02,0xC4,0xC1,0x7F,0xF0,0x08,0xC5,0xFD,0x74,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vcmpeqb(MemoryBuffer ymm0, MemoryBuffer ymm1)
; location: [7FFC895B2440h, 7FFC895B248Ch]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h add rdx,10h                   ; ADD(Add_rm64_imm8) [RDX,10h:imm64]                   encoding(4 bytes) = 48 83 c2 10
000bh mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
000eh mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0011h cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
0014h jbe short 0047h               ; JBE(Jbe_rel8_64) [47h:jmp64]                         encoding(2 bytes) = 76 31
0016h vmovdqa ymm0,ymmword ptr [rax]; VMOVDQA(VEX_Vmovdqa_ymm_ymmm256) [YMM0,mem(Packed256_Int32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 6f 00
001ah add r8,10h                    ; ADD(Add_rm64_imm8) [R8,10h:imm64]                    encoding(4 bytes) = 49 83 c0 10
001eh mov rax,[r8]                  ; MOV(Mov_r64_rm64) [RAX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 00
0021h mov edx,[r8+8]                ; MOV(Mov_r32_rm32) [EDX,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 41 8b 50 08
0025h cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
0028h jbe short 0047h               ; JBE(Jbe_rel8_64) [47h:jmp64]                         encoding(2 bytes) = 76 1d
002ah vmovdqa ymm1,ymmword ptr [rax]; VMOVDQA(VEX_Vmovdqa_ymm_ymmm256) [YMM1,mem(Packed256_Int32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 6f 08
002eh vpcmpeqb ymm0,ymm0,ymm1       ; VPCMPEQB(VEX_Vpcmpeqb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 74 c1
0032h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0036h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0040h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0041h call 7FFCE91D4C00h            ; CALL(Call_rel32_64) [5FC227C0h:jmp64]                encoding(5 bytes) = e8 7a 27 c2 5f
0046h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0047h call 7FFCE91D4DB0h            ; CALL(Call_rel32_64) [5FC22970h:jmp64]                encoding(5 bytes) = e8 24 29 c2 5f
004ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> vcmpeqbBytes => new byte[77]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x83,0xC2,0x10,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x76,0x31,0xC5,0xFD,0x6F,0x00,0x49,0x83,0xC0,0x10,0x49,0x8B,0x00,0x41,0x8B,0x50,0x08,0x83,0xFA,0x00,0x76,0x1D,0xC5,0xFD,0x6F,0x08,0xC5,0xFD,0x74,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x7A,0x27,0xC2,0x5F,0xCC,0xE8,0x24,0x29,0xC2,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vperm2i128(YMM a, YMM b, byte control)
; location: [7FFC895B24B0h, 7FFC895B24F1h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,70h                   ; SUB(Sub_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 ec 70
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
000fh vlddqu ymm1,ymmword ptr [r8]  ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 08
0014h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0017h vmovupd [rsp+40h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 40
001dh vmovupd [rsp+20h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 20
0023h lea rdx,[rsp+40h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 40
0028h lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
002dh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0031h call 7FFC8959A118h            ; CALL(Call_rel32_64) [FFFFFFFFFFFE7C68h:jmp64]        encoding(5 bytes) = e8 32 7c fe ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vperm2i128Bytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFF,0xF0,0x02,0xC4,0xC1,0x7F,0xF0,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0x32,0x7C,0xFE,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vperm2i128(Vector256<ulong> a, Vector256<ulong> b, byte control)
; location: [7FFC895B2510h, 7FFC895B2551h]
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
0031h call 7FFC8959A118h            ; CALL(Call_rel32_64) [FFFFFFFFFFFE7C08h:jmp64]        encoding(5 bytes) = e8 d2 7b fe ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vperm2i128Bytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0xD2,0x7B,0xFE,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<double> vperm2f128(YMM a, YMM b, byte control)
; location: [7FFC895B2980h, 7FFC895B2A1Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,0C0h                  ; SUB(Sub_rm64_imm32) [RSP,c0h:imm64]                  encoding(7 bytes) = 48 81 ec c0 00 00 00
000ah vmovaps [rsp+0B0h],xmm6       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM6] encoding(VEX, 9 bytes) = c5 f8 29 b4 24 b0 00 00 00
0013h vmovaps [rsp+0A0h],xmm7       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM7] encoding(VEX, 9 bytes) = c5 f8 29 bc 24 a0 00 00 00
001ch mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
001fh mov rsi,r8                    ; MOV(Mov_r64_rm64) [RSI,R8]                           encoding(3 bytes) = 49 8b f0
0022h mov ebx,r9d                   ; MOV(Mov_r32_rm32) [EBX,R9D]                          encoding(3 bytes) = 41 8b d9
0025h lea rcx,[rsp+80h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 80 00 00 00
002dh call 7FFC895B2428h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFAA8h:jmp64]        encoding(5 bytes) = e8 76 fa ff ff
0032h vmovupd ymm6,[rsp+80h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM6,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 b4 24 80 00 00 00
003bh lea rcx,[rsp+60h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 60
0040h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
0043h vextractf128 xmm7,ymm6,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM7,YMM6,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 f7 01
0049h call 7FFC895B2428h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFAA8h:jmp64]        encoding(5 bytes) = e8 5a fa ff ff
004eh vmovupd ymm0,[rsp+60h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 60
0054h vinsertf128 ymm6,ymm6,xmm7,1  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM6,YMM6,XMM7,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 4d 18 f7 01
005ah mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
005dh vmovupd [rsp+40h],ymm6        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM6] encoding(VEX, 6 bytes) = c5 fd 11 74 24 40
0063h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0069h lea rdx,[rsp+40h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 40
006eh lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
0073h movzx r9d,bl                  ; MOVZX(Movzx_r32_rm8) [R9D,BL]                        encoding(4 bytes) = 44 0f b6 cb
0077h call 7FFC8959A048h            ; CALL(Call_rel32_64) [FFFFFFFFFFFE76C8h:jmp64]        encoding(5 bytes) = e8 4c 76 fe ff
007ch mov rax,rdi                   ; MOV(Mov_r64_rm64) [RAX,RDI]                          encoding(3 bytes) = 48 8b c7
007fh vmovaps xmm6,[rsp+0B0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f8 28 b4 24 b0 00 00 00
0088h vmovaps xmm7,[rsp+0A0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f8 28 bc 24 a0 00 00 00
0091h add rsp,0C0h                  ; ADD(Add_rm64_imm32) [RSP,c0h:imm64]                  encoding(7 bytes) = 48 81 c4 c0 00 00 00
0098h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0099h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
009ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
009bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vperm2f128Bytes => new byte[156]{0x57,0x56,0x53,0x48,0x81,0xEC,0xC0,0x00,0x00,0x00,0xC5,0xF8,0x29,0xB4,0x24,0xB0,0x00,0x00,0x00,0xC5,0xF8,0x29,0xBC,0x24,0xA0,0x00,0x00,0x00,0x48,0x8B,0xF9,0x49,0x8B,0xF0,0x41,0x8B,0xD9,0x48,0x8D,0x8C,0x24,0x80,0x00,0x00,0x00,0xE8,0x76,0xFA,0xFF,0xFF,0xC5,0xFD,0x10,0xB4,0x24,0x80,0x00,0x00,0x00,0x48,0x8D,0x4C,0x24,0x60,0x48,0x8B,0xD6,0xC4,0xE3,0x7D,0x19,0xF7,0x01,0xE8,0x5A,0xFA,0xFF,0xFF,0xC5,0xFD,0x10,0x44,0x24,0x60,0xC4,0xE3,0x4D,0x18,0xF7,0x01,0x48,0x8B,0xCF,0xC5,0xFD,0x11,0x74,0x24,0x40,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x44,0x0F,0xB6,0xCB,0xE8,0x4C,0x76,0xFE,0xFF,0x48,0x8B,0xC7,0xC5,0xF8,0x28,0xB4,0x24,0xB0,0x00,0x00,0x00,0xC5,0xF8,0x28,0xBC,0x24,0xA0,0x00,0x00,0x00,0x48,0x81,0xC4,0xC0,0x00,0x00,0x00,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: YMM vperm2i128(YMM a, YMM b, byte control)
; location: [7FFC895B2A50h, 7FFC895B2B1Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,108h                  ; SUB(Sub_rm64_imm32) [RSP,108h:imm64]                 encoding(7 bytes) = 48 81 ec 08 01 00 00
0009h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh mov edi,r9d                   ; MOV(Mov_r32_rm32) [EDI,R9D]                          encoding(3 bytes) = 41 8b f9
0012h vmovdqu xmm0,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
0016h vmovdqu xmmword ptr [rsp+0C0h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 c0 00 00 00
001fh vmovdqu xmm0,xmmword ptr [rdx+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 42 10
0024h vmovdqu xmmword ptr [rsp+0D0h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 d0 00 00 00
002dh vmovdqu xmm0,xmmword ptr [r8] ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7a 6f 00
0032h vmovdqu xmmword ptr [rsp+0A0h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 a0 00 00 00
003bh vmovdqu xmm0,xmmword ptr [r8+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 6 bytes) = c4 c1 7a 6f 40 10
0041h vmovdqu xmmword ptr [rsp+0B0h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 b0 00 00 00
004ah lea rcx,[rsp+80h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 80 00 00 00
0052h lea rdx,[rsp+0C0h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 c0 00 00 00
005ah call 7FFC895B05A8h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFDB58h:jmp64]        encoding(5 bytes) = e8 f9 da ff ff
005fh vmovupd ymm0,[rsp+80h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 80 00 00 00
0068h vlddqu ymm1,ymmword ptr [rsp+0A0h]; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 ff f0 8c 24 a0 00 00 00
0071h lea rcx,[rsp+0E0h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 e0 00 00 00
0079h vmovupd [rsp+40h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 40
007fh vmovupd [rsp+20h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 20
0085h lea rdx,[rsp+40h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 40
008ah lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
008fh movzx r9d,dil                 ; MOVZX(Movzx_r32_rm8) [R9D,DIL]                       encoding(4 bytes) = 44 0f b6 cf
0093h call 7FFC8959A118h            ; CALL(Call_rel32_64) [FFFFFFFFFFFE76C8h:jmp64]        encoding(5 bytes) = e8 30 76 fe ff
0098h vmovupd ymm0,[rsp+0E0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 e0 00 00 00
00a1h vmovupd [rsp+60h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 60
00a7h vmovdqu xmm0,xmmword ptr [rsp+60h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 60
00adh vmovdqu xmmword ptr [rsi],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSI:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 06
00b1h vmovdqu xmm0,xmmword ptr [rsp+70h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 70
00b7h vmovdqu xmmword ptr [rsi+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSI:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 46 10
00bch mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00bfh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00c2h add rsp,108h                  ; ADD(Add_rm64_imm32) [RSP,108h:imm64]                 encoding(7 bytes) = 48 81 c4 08 01 00 00
00c9h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00cah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00cbh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vperm2i128Bytes => new byte[204]{0x57,0x56,0x48,0x81,0xEC,0x08,0x01,0x00,0x00,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x41,0x8B,0xF9,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x84,0x24,0xC0,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x42,0x10,0xC5,0xFA,0x7F,0x84,0x24,0xD0,0x00,0x00,0x00,0xC4,0xC1,0x7A,0x6F,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xA0,0x00,0x00,0x00,0xC4,0xC1,0x7A,0x6F,0x40,0x10,0xC5,0xFA,0x7F,0x84,0x24,0xB0,0x00,0x00,0x00,0x48,0x8D,0x8C,0x24,0x80,0x00,0x00,0x00,0x48,0x8D,0x94,0x24,0xC0,0x00,0x00,0x00,0xE8,0xF9,0xDA,0xFF,0xFF,0xC5,0xFD,0x10,0x84,0x24,0x80,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x8C,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x8C,0x24,0xE0,0x00,0x00,0x00,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x44,0x0F,0xB6,0xCF,0xE8,0x30,0x76,0xFE,0xFF,0xC5,0xFD,0x10,0x84,0x24,0xE0,0x00,0x00,0x00,0xC5,0xFD,0x11,0x44,0x24,0x60,0xC5,0xFA,0x6F,0x44,0x24,0x60,0xC5,0xFA,0x7F,0x06,0xC5,0xFA,0x6F,0x44,0x24,0x70,0xC5,0xFA,0x7F,0x46,0x10,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x81,0xC4,0x08,0x01,0x00,0x00,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vperm2f128(YMM a, YMM b, byte control)
; location: [7FFC895B2B50h, 7FFC895B2B91h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,70h                   ; SUB(Sub_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 ec 70
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
000fh vlddqu ymm1,ymmword ptr [r8]  ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 08
0014h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0017h vmovupd [rsp+40h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 40
001dh vmovupd [rsp+20h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 20
0023h lea rdx,[rsp+40h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 40
0028h lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
002dh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0031h call 7FFC8959A0E8h            ; CALL(Call_rel32_64) [FFFFFFFFFFFE7598h:jmp64]        encoding(5 bytes) = e8 62 75 fe ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vperm2f128Bytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFF,0xF0,0x02,0xC4,0xC1,0x7F,0xF0,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0x62,0x75,0xFE,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vpermd(YMM src, YMM control)
; location: [7FFC895B2BB0h, 7FFC895B2BCDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
0009h vlddqu ymm1,ymmword ptr [r8]  ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 08
000eh vpermd ymm0,ymm1,ymm0         ; VPERMD(VEX_Vpermd_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]  encoding(VEX, 5 bytes) = c4 e2 75 36 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpermdBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFF,0xF0,0x02,0xC4,0xC1,0x7F,0xF0,0x08,0xC4,0xE2,0x75,0x36,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Perm<N8> ToPerm(uint rep)
; location: [7FFC895B42B0h, 7FFC895B4384h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0008h mov esi,ecx                   ; MOV(Mov_r32_rm32) [ESI,ECX]                          encoding(2 bytes) = 8b f1
000ah mov rcx,7FFC89657DB0h         ; MOV(Mov_r64_imm64) [RCX,7ffc89657db0h:imm64]         encoding(10 bytes) = 48 b9 b0 7d 65 89 fc 7f 00 00
0014h mov edx,3                     ; MOV(Mov_r32_imm32) [EDX,3h:imm32]                    encoding(5 bytes) = ba 03 00 00 00
0019h call 7FFCE9076700h            ; CALL(Call_rel32_64) [5FAC2450h:jmp64]                encoding(5 bytes) = e8 32 24 ac 5f
001eh mov rdx,247900070B0h          ; MOV(Mov_r64_imm64) [RDX,247900070b0h:imm64]          encoding(10 bytes) = 48 ba b0 70 00 90 47 02 00 00
0028h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
002bh mov rdi,[rdx+8]               ; MOV(Mov_r64_rm64) [RDI,mem(64u,RDX:br,DS:sr)]        encoding(4 bytes) = 48 8b 7a 08
002fh mov ebx,[rdi+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RDI:br,DS:sr)]        encoding(3 bytes) = 8b 5f 08
0032h movsxd rdx,ebx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EBX]                    encoding(3 bytes) = 48 63 d3
0035h mov rcx,7FFC89635F48h         ; MOV(Mov_r64_imm64) [RCX,7ffc89635f48h:imm64]         encoding(10 bytes) = 48 b9 48 5f 63 89 fc 7f 00 00
003fh call 7FFCE90A94A0h            ; CALL(Call_rel32_64) [5FAF51F0h:jmp64]                encoding(5 bytes) = e8 ac 51 af 5f
0044h mov rbp,rax                   ; MOV(Mov_r64_rm64) [RBP,RAX]                          encoding(3 bytes) = 48 8b e8
0047h mov r8d,ebx                   ; MOV(Mov_r32_rm32) [R8D,EBX]                          encoding(3 bytes) = 44 8b c3
004ah mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
004dh mov rdx,rbp                   ; MOV(Mov_r64_rm64) [RDX,RBP]                          encoding(3 bytes) = 48 8b d5
0050h call 7FFC89591928h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDD678h:jmp64]        encoding(5 bytes) = e8 23 d6 fd ff
0055h mov rax,rbp                   ; MOV(Mov_r64_rm64) [RAX,RBP]                          encoding(3 bytes) = 48 8b c5
0058h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
005ah xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
005ch mov r8d,[7FFC897A8390h]       ; MOV(Mov_r32_rm32) [R8D,mem(32u,RIP:br,DS:sr)]        encoding(7 bytes) = 44 8b 05 7d 40 1f 00
0063h test r8d,r8d                  ; TEST(Test_rm32_r32) [R8D,R8D]                        encoding(3 bytes) = 45 85 c0
0066h jle short 00c0h               ; JLE(Jle_rel8_64) [C0h:jmp64]                         encoding(2 bytes) = 7e 58
0068h cmp edx,[rax+8]               ; CMP(Cmp_r32_rm32) [EDX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 3b 50 08
006bh jae short 00cfh               ; JAE(Jae_rel8_64) [CFh:jmp64]                         encoding(2 bytes) = 73 62
006dh movsxd r9,edx                 ; MOVSXD(Movsxd_r64_rm32) [R9,EDX]                     encoding(3 bytes) = 4c 63 ca
0070h lea r9,[rax+r9*4+10h]         ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(5 bytes) = 4e 8d 4c 88 10
0075h movzx r10d,cl                 ; MOVZX(Movzx_r32_rm8) [R10D,CL]                       encoding(4 bytes) = 44 0f b6 d1
0079h lea r11d,[rcx+2]              ; LEA(Lea_r32_m) [R11D,mem(Unknown,RCX:br,DS:sr)]      encoding(4 bytes) = 44 8d 59 02
007dh movzx r11d,r11b               ; MOVZX(Movzx_r32_rm8) [R11D,R11L]                     encoding(4 bytes) = 45 0f b6 db
0081h movzx edi,r10b                ; MOVZX(Movzx_r32_rm8) [EDI,R10L]                      encoding(4 bytes) = 41 0f b6 fa
0085h sub r10d,r11d                 ; SUB(Sub_r32_rm32) [R10D,R11D]                        encoding(3 bytes) = 45 2b d3
0088h test r10d,r10d                ; TEST(Test_rm32_r32) [R10D,R10D]                      encoding(3 bytes) = 45 85 d2
008bh jge short 0095h               ; JGE(Jge_rel8_64) [95h:jmp64]                         encoding(2 bytes) = 7d 08
008dh neg r10d                      ; NEG(Neg_rm32) [R10D]                                 encoding(3 bytes) = 41 f7 da
0090h test r10d,r10d                ; TEST(Test_rm32_r32) [R10D,R10D]                      encoding(3 bytes) = 45 85 d2
0093h jl short 00c9h                ; JL(Jl_rel8_64) [C9h:jmp64]                           encoding(2 bytes) = 7c 34
0095h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0098h movsxd r10,r10d               ; MOVSXD(Movsxd_r64_rm32) [R10,R10D]                   encoding(3 bytes) = 4d 63 d2
009bh movzx r11d,dil                ; MOVZX(Movzx_r32_rm8) [R11D,DIL]                      encoding(4 bytes) = 44 0f b6 df
009fh movzx r10d,r10b               ; MOVZX(Movzx_r32_rm8) [R10D,R10L]                     encoding(4 bytes) = 45 0f b6 d2
00a3h shl r10d,8                    ; SHL(Shl_rm32_imm8) [R10D,8h:imm8]                    encoding(4 bytes) = 41 c1 e2 08
00a7h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
00aah movzx r10d,r10w               ; MOVZX(Movzx_r32_rm16) [R10D,R10W]                    encoding(4 bytes) = 45 0f b7 d2
00aeh bextr r10d,esi,r10d           ; BEXTR(VEX_Bextr_r32_rm32_r32) [R10D,ESI,R10D]        encoding(VEX, 5 bytes) = c4 62 28 f7 d6
00b3h mov [r9],r10d                 ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),R10D]        encoding(3 bytes) = 45 89 11
00b6h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
00b8h add ecx,3                     ; ADD(Add_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 c1 03
00bbh cmp edx,r8d                   ; CMP(Cmp_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 3b d0
00beh jl short 0068h                ; JL(Jl_rel8_64) [68h:jmp64]                           encoding(2 bytes) = 7c a8
00c0h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00c4h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00c5h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
00c6h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00c7h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00c8h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00c9h call 7FFC895B4080h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFDD0h:jmp64]        encoding(5 bytes) = e8 02 fd ff ff
00ceh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00cfh call 7FFCE91D4DB0h            ; CALL(Call_rel32_64) [5FC20B00h:jmp64]                encoding(5 bytes) = e8 2c 0a c2 5f
00d4h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> ToPermBytes => new byte[213]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x8B,0xF1,0x48,0xB9,0xB0,0x7D,0x65,0x89,0xFC,0x7F,0x00,0x00,0xBA,0x03,0x00,0x00,0x00,0xE8,0x32,0x24,0xAC,0x5F,0x48,0xBA,0xB0,0x70,0x00,0x90,0x47,0x02,0x00,0x00,0x48,0x8B,0x12,0x48,0x8B,0x7A,0x08,0x8B,0x5F,0x08,0x48,0x63,0xD3,0x48,0xB9,0x48,0x5F,0x63,0x89,0xFC,0x7F,0x00,0x00,0xE8,0xAC,0x51,0xAF,0x5F,0x48,0x8B,0xE8,0x44,0x8B,0xC3,0x48,0x8B,0xCF,0x48,0x8B,0xD5,0xE8,0x23,0xD6,0xFD,0xFF,0x48,0x8B,0xC5,0x33,0xD2,0x33,0xC9,0x44,0x8B,0x05,0x7D,0x40,0x1F,0x00,0x45,0x85,0xC0,0x7E,0x58,0x3B,0x50,0x08,0x73,0x62,0x4C,0x63,0xCA,0x4E,0x8D,0x4C,0x88,0x10,0x44,0x0F,0xB6,0xD1,0x44,0x8D,0x59,0x02,0x45,0x0F,0xB6,0xDB,0x41,0x0F,0xB6,0xFA,0x45,0x2B,0xD3,0x45,0x85,0xD2,0x7D,0x08,0x41,0xF7,0xDA,0x45,0x85,0xD2,0x7C,0x34,0x41,0xFF,0xC2,0x4D,0x63,0xD2,0x44,0x0F,0xB6,0xDF,0x45,0x0F,0xB6,0xD2,0x41,0xC1,0xE2,0x08,0x45,0x0B,0xD3,0x45,0x0F,0xB7,0xD2,0xC4,0x62,0x28,0xF7,0xD6,0x45,0x89,0x11,0xFF,0xC2,0x83,0xC1,0x03,0x41,0x3B,0xD0,0x7C,0xA8,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0xC3,0xE8,0x02,0xFD,0xFF,0xFF,0xCC,0xE8,0x2C,0x0A,0xC2,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: YMM vpermd(YMM src, uint spec)
; location: [7FFC895B47B0h, 7FFC895B480Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0006h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0009h mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000ch mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000fh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0012h call 7FFC895B42B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFB00h:jmp64]        encoding(5 bytes) = e8 e9 fa ff ff
0017h vlddqu ymm0,ymmword ptr [rsi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RSI:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 06
001bh cmp dword ptr [rax+8],0       ; CMP(Cmp_rm32_imm8) [mem(32u,RAX:br,DS:sr),0h:imm32]  encoding(4 bytes) = 83 78 08 00
001fh jbe short 0056h               ; JBE(Jbe_rel8_64) [56h:jmp64]                         encoding(2 bytes) = 76 35
0021h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0025h vlddqu ymm1,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 08
0029h vpermd ymm0,ymm1,ymm0         ; VPERMD(VEX_Vpermd_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]  encoding(VEX, 5 bytes) = c4 e2 75 36 c0
002eh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0034h vmovdqu xmm0,xmmword ptr [rsp+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 20
003ah vmovdqu xmmword ptr [rdi],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDI:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 07
003eh vmovdqu xmm0,xmmword ptr [rsp+30h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 30
0044h vmovdqu xmmword ptr [rdi+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDI:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 47 10
0049h mov rax,rdi                   ; MOV(Mov_r64_rm64) [RAX,RDI]                          encoding(3 bytes) = 48 8b c7
004ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
004fh add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
0053h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0054h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0055h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0056h call 7FFCE91D4DB0h            ; CALL(Call_rel32_64) [5FC20600h:jmp64]                encoding(5 bytes) = e8 a5 05 c2 5f
005bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> vpermdBytes => new byte[92]{0x57,0x56,0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x41,0x8B,0xC8,0xE8,0xE9,0xFA,0xFF,0xFF,0xC5,0xFF,0xF0,0x06,0x83,0x78,0x08,0x00,0x76,0x35,0x48,0x83,0xC0,0x10,0xC5,0xFF,0xF0,0x08,0xC4,0xE2,0x75,0x36,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFA,0x6F,0x44,0x24,0x20,0xC5,0xFA,0x7F,0x07,0xC5,0xFA,0x6F,0x44,0x24,0x30,0xC5,0xFA,0x7F,0x47,0x10,0x48,0x8B,0xC7,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x48,0x5E,0x5F,0xC3,0xE8,0xA5,0x05,0xC2,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: XMM pxor(XMM xmm0, XMM xmm1)
; location: [7FFC895B4830h, 7FFC895B4859h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu xmm0,xmmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb f0 02
000bh vlddqu xmm1,xmmword ptr [r8]  ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 08
0010h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0014h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0019h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001eh vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0022h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pxorBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0xF0,0x02,0xC4,0xC1,0x7B,0xF0,0x08,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vpxor_ref(Vector256<ulong> ymm0, Vector256<ulong> ymm1)
; location: [7FFC895B4880h, 7FFC895B4898h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpxor ymm0,ymm0,[r8]          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d ef 00
000eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpxor_refBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xEF,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: YMM vpxor(YMM ymm0, YMM ymm1)
; location: [7FFC895B48B0h, 7FFC895B48E7h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
000bh vlddqu ymm1,ymmword ptr [r8]  ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 08
0010h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0014h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0019h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001eh vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0022h vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
0028h vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0033h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpxorBytes => new byte[56]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0xC5,0xFF,0xF0,0x02,0xC4,0xC1,0x7F,0xF0,0x08,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x41,0x10,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref YMM vpxor(YMM ymm0, YMM ymm1, ref YMM ymm2)
; location: [7FFC895B4910h, 7FFC895B4948h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu ymm0,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 01
000bh vlddqu ymm1,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 0a
000fh vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0013h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0018h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001dh vmovdqu xmmword ptr [r8],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 00
0022h vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
0028h vmovdqu xmmword ptr [r8+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,DS:sr),XMM0] encoding(VEX, 6 bytes) = c4 c1 7a 7f 40 10
002eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0031h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0034h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpxorBytes => new byte[57]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0xC5,0xFF,0xF0,0x01,0xC5,0xFF,0xF0,0x0A,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC4,0xC1,0x7A,0x7F,0x00,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC4,0xC1,0x7A,0x7F,0x40,0x10,0x49,0x8B,0xC0,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<ulong> vpxor(YMM ymm0, YMM ymm1, out Vector256<ulong> ymm2)
; location: [7FFC895B4970h, 7FFC895B498Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vlddqu ymm0,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 01
0009h vlddqu ymm1,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 0a
000dh vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0011h vmovupd [r8],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R8:br,DS:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 00
0016h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpxorBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFF,0xF0,0x01,0xC5,0xFF,0xF0,0x0A,0xC5,0xFD,0xEF,0xC1,0xC4,0xC1,0x7D,0x11,0x00,0x49,0x8B,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
