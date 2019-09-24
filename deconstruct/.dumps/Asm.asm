; 2019-09-24 02:30:06:003
; function: XMM pmovzxbw(XMM a)
; location: [7FFC872F8D40h, 7FFC872F8D65h]
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
; function: XMM pmovzxbd(XMM a)
; location: [7FFC872F8D80h, 7FFC872F8DA5h]
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
; location: [7FFC872F8DC0h, 7FFC872F8DE5h]
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
; function: XMM pmovzxbq(XMM a)
; location: [7FFC872F8E00h, 7FFC872F8E25h]
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
; location: [7FFC872F8E40h, 7FFC872F8E65h]
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
; location: [7FFC872F8E80h, 7FFC872F8EA5h]
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
; location: [7FFC872F92D0h, 7FFC872F92F5h]
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
; location: [7FFC872F9310h, 7FFC872F9335h]
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
; location: [7FFC872F9350h, 7FFC872F9375h]
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
; location: [7FFC872F9390h, 7FFC872F93B5h]
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
; location: [7FFC872F93D0h, 7FFC872F93F0h]
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
; location: [7FFC872F9410h, 7FFC872F9430h]
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
; location: [7FFC872F99A0h, 7FFC872F99CEh]
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
; location: [7FFC872F99F0h, 7FFC872F9A1Eh]
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
; function: YMM vpaddq(YMM ymm0, YMM ymm1)
; location: [7FFC872F9A40h, 7FFC872F9A77h]
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
; static ReadOnlySpan<byte> vpaddqBytes => new byte[56]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0xC5,0xFF,0xF0,0x02,0xC4,0xC1,0x7F,0xF0,0x08,0xC5,0xFD,0xD4,0xC1,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x41,0x10,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: YMM<long> vpaddq(YMM<long> ymm0, YMM<long> ymm1)
; location: [7FFC872F9EA0h, 7FFC872F9EBCh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpaddq ymm0,ymm0,ymm1         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 4 bytes) = c5 fd d4 c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpaddqBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xD4,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: YMM<ulong> vpaddq(YMM<ulong> ymm0, YMM<ulong> ymm1)
; location: [7FFC872F9ED0h, 7FFC872F9EECh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpaddq ymm0,ymm0,ymm1         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 4 bytes) = c5 fd d4 c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpaddqBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xD4,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref YMM<long> vpaddq(YMM ymm0, YMM ymm1, ref YMM<long> dst)
; location: [7FFC872F9F00h, 7FFC872F9F1Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vlddqu ymm0,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 01
0009h vlddqu ymm1,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 0a
000dh vpaddq ymm0,ymm0,ymm1         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 4 bytes) = c5 fd d4 c1
0011h vmovupd [r8],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R8:br,DS:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 00
0016h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpaddqBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFF,0xF0,0x01,0xC5,0xFF,0xF0,0x0A,0xC5,0xFD,0xD4,0xC1,0xC4,0xC1,0x7D,0x11,0x00,0x49,0x8B,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref YMM<ulong> vpaddq(YMM ymm0, YMM ymm1, ref YMM<ulong> dst)
; location: [7FFC872F9F30h, 7FFC872F9F4Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vlddqu ymm0,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 01
0009h vlddqu ymm1,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 0a
000dh vpaddq ymm0,ymm0,ymm1         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 4 bytes) = c5 fd d4 c1
0011h vmovupd [r8],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R8:br,DS:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 00
0016h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpaddqBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFF,0xF0,0x01,0xC5,0xFF,0xF0,0x0A,0xC5,0xFD,0xD4,0xC1,0xC4,0xC1,0x7D,0x11,0x00,0x49,0x8B,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: XMM vpblendw(XMM xmm2, XMM xmm3, Imm8 imm8)
; location: [7FFC872F9F60h, 7FFC872F9FB6h]
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
0033h call 7FFC86C19570h            ; CALL(Call_rel32_64) [FFFFFFFFFF91F610h:jmp64]        encoding(5 bytes) = e8 d8 f5 91 ff
0038h vmovapd xmm0,[rsp+50h]        ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 28 44 24 50
003eh vmovapd [rsp+40h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 40
0044h vmovdqu xmm0,xmmword ptr [rsp+40h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 40
004ah vmovdqu xmmword ptr [rsi],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSI:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 06
004eh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0051h add rsp,60h                   ; ADD(Add_rm64_imm8) [RSP,60h:imm64]                   encoding(4 bytes) = 48 83 c4 60
0055h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0056h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpblendwBytes => new byte[87]{0x56,0x48,0x83,0xEC,0x60,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFB,0xF0,0x02,0xC4,0xC1,0x7B,0xF0,0x08,0x48,0x8D,0x4C,0x24,0x50,0xC5,0xF9,0x29,0x44,0x24,0x30,0xC5,0xF9,0x29,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x30,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0xD8,0xF5,0x91,0xFF,0xC5,0xF9,0x28,0x44,0x24,0x50,0xC5,0xF9,0x29,0x44,0x24,0x40,0xC5,0xFA,0x6F,0x44,0x24,0x40,0xC5,0xFA,0x7F,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x60,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: XMM vpcmpeqb(XMM xmm0, XMM xmm1)
; location: [7FFC872F9FE0h, 7FFC872FA009h]
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
; function: YMM vcmpeqq(YMM ymm0, YMM ymm1)
; location: [7FFC872FA030h, 7FFC872FA068h]
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
; location: [7FFC872FA090h, 7FFC872FA0ADh]
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
; location: [7FFC872FA4D0h, 7FFC872FA4ECh]
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
; function: Vector256<ulong> vperm2i128(YMM a, YMM b, byte control)
; location: [7FFC872FA500h, 7FFC872FA541h]
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
0031h call 7FFC86C1A118h            ; CALL(Call_rel32_64) [FFFFFFFFFF91FC18h:jmp64]        encoding(5 bytes) = e8 e2 fb 91 ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vperm2i128Bytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFF,0xF0,0x02,0xC4,0xC1,0x7F,0xF0,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0xE2,0xFB,0x91,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vperm2i128(Vector256<ulong> a, Vector256<ulong> b, byte control)
; location: [7FFC872FA560h, 7FFC872FA5A1h]
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
0031h call 7FFC86C1A118h            ; CALL(Call_rel32_64) [FFFFFFFFFF91FBB8h:jmp64]        encoding(5 bytes) = e8 82 fb 91 ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vperm2i128Bytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0x82,0xFB,0x91,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<double> vperm2f128(YMM a, YMM b, byte control)
; location: [7FFC872FA5C0h, 7FFC872FA62Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,0A0h                  ; SUB(Sub_rm64_imm32) [RSP,a0h:imm64]                  encoding(7 bytes) = 48 81 ec a0 00 00 00
000ah mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000dh mov rsi,r8                    ; MOV(Mov_r64_rm64) [RSI,R8]                           encoding(3 bytes) = 49 8b f0
0010h mov ebx,r9d                   ; MOV(Mov_r32_rm32) [EBX,R9D]                          encoding(3 bytes) = 41 8b d9
0013h lea rcx,[rsp+80h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 80 00 00 00
001bh call 7FFC872FA1D0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFC10h:jmp64]        encoding(5 bytes) = e8 f0 fb ff ff
0020h lea rcx,[rsp+60h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 60
0025h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
0028h call 7FFC872FA1D0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFC10h:jmp64]        encoding(5 bytes) = e8 e3 fb ff ff
002dh vmovupd ymm0,[rsp+80h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 80 00 00 00
0036h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0039h vmovupd [rsp+40h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 40
003fh vmovupd ymm0,[rsp+60h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 60
0045h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
004bh lea rdx,[rsp+40h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 40
0050h lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
0055h movzx r9d,bl                  ; MOVZX(Movzx_r32_rm8) [R9D,BL]                        encoding(4 bytes) = 44 0f b6 cb
0059h call 7FFC86C1A048h            ; CALL(Call_rel32_64) [FFFFFFFFFF91FA88h:jmp64]        encoding(5 bytes) = e8 2a fa 91 ff
005eh mov rax,rdi                   ; MOV(Mov_r64_rm64) [RAX,RDI]                          encoding(3 bytes) = 48 8b c7
0061h add rsp,0A0h                  ; ADD(Add_rm64_imm32) [RSP,a0h:imm64]                  encoding(7 bytes) = 48 81 c4 a0 00 00 00
0068h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0069h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
006ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
006bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vperm2f128Bytes => new byte[108]{0x57,0x56,0x53,0x48,0x81,0xEC,0xA0,0x00,0x00,0x00,0x48,0x8B,0xF9,0x49,0x8B,0xF0,0x41,0x8B,0xD9,0x48,0x8D,0x8C,0x24,0x80,0x00,0x00,0x00,0xE8,0xF0,0xFB,0xFF,0xFF,0x48,0x8D,0x4C,0x24,0x60,0x48,0x8B,0xD6,0xE8,0xE3,0xFB,0xFF,0xFF,0xC5,0xFD,0x10,0x84,0x24,0x80,0x00,0x00,0x00,0x48,0x8B,0xCF,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x10,0x44,0x24,0x60,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x44,0x0F,0xB6,0xCB,0xE8,0x2A,0xFA,0x91,0xFF,0x48,0x8B,0xC7,0x48,0x81,0xC4,0xA0,0x00,0x00,0x00,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: YMM vperm2i128(YMM a, YMM b, Perm2x128:byte control)
; location: [7FFC872FA650h, 7FFC872FA701h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,0F0h                  ; SUB(Sub_rm64_imm32) [RSP,f0h:imm64]                  encoding(7 bytes) = 48 81 ec f0 00 00 00
0008h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000bh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000eh vmovdqu xmm0,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
0012h vmovdqu xmmword ptr [rsp+0A0h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 a0 00 00 00
001bh vmovdqu xmm0,xmmword ptr [rdx+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 42 10
0020h vmovdqu xmmword ptr [rsp+0B0h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 b0 00 00 00
0029h vmovdqu xmm0,xmmword ptr [r8] ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7a 6f 00
002eh vmovdqu xmmword ptr [rsp+80h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 80 00 00 00
0037h vmovdqu xmm0,xmmword ptr [r8+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,R8:br,DS:sr)] encoding(VEX, 6 bytes) = c4 c1 7a 6f 40 10
003dh vmovdqu xmmword ptr [rsp+90h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 90 00 00 00
0046h vlddqu ymm0,ymmword ptr [rsp+0A0h]; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 ff f0 84 24 a0 00 00 00
004fh vlddqu ymm1,ymmword ptr [rsp+80h]; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 ff f0 8c 24 80 00 00 00
0058h lea rcx,[rsp+0C0h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 c0 00 00 00
0060h vmovupd [rsp+40h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 40
0066h vmovupd [rsp+20h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 20
006ch lea rdx,[rsp+40h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 40
0071h lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
0076h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
007ah call 7FFC86C1A118h            ; CALL(Call_rel32_64) [FFFFFFFFFF91FAC8h:jmp64]        encoding(5 bytes) = e8 49 fa 91 ff
007fh vmovupd ymm0,[rsp+0C0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 c0 00 00 00
0088h vmovupd [rsp+60h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 60
008eh vmovdqu xmm0,xmmword ptr [rsp+60h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 60
0094h vmovdqu xmmword ptr [rsi],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSI:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 06
0098h vmovdqu xmm0,xmmword ptr [rsp+70h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 70
009eh vmovdqu xmmword ptr [rsi+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSI:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 46 10
00a3h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00a6h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00a9h add rsp,0F0h                  ; ADD(Add_rm64_imm32) [RSP,f0h:imm64]                  encoding(7 bytes) = 48 81 c4 f0 00 00 00
00b0h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00b1h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vperm2i128Bytes => new byte[178]{0x56,0x48,0x81,0xEC,0xF0,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x42,0x10,0xC5,0xFA,0x7F,0x84,0x24,0xB0,0x00,0x00,0x00,0xC4,0xC1,0x7A,0x6F,0x00,0xC5,0xFA,0x7F,0x84,0x24,0x80,0x00,0x00,0x00,0xC4,0xC1,0x7A,0x6F,0x40,0x10,0xC5,0xFA,0x7F,0x84,0x24,0x90,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x8C,0x24,0x80,0x00,0x00,0x00,0x48,0x8D,0x8C,0x24,0xC0,0x00,0x00,0x00,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0x49,0xFA,0x91,0xFF,0xC5,0xFD,0x10,0x84,0x24,0xC0,0x00,0x00,0x00,0xC5,0xFD,0x11,0x44,0x24,0x60,0xC5,0xFA,0x6F,0x44,0x24,0x60,0xC5,0xFA,0x7F,0x06,0xC5,0xFA,0x6F,0x44,0x24,0x70,0xC5,0xFA,0x7F,0x46,0x10,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x81,0xC4,0xF0,0x00,0x00,0x00,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vperm2f128(YMM a, YMM b, Perm2x128:byte control)
; location: [7FFC872FA730h, 7FFC872FA771h]
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
0031h call 7FFC86C1A0E8h            ; CALL(Call_rel32_64) [FFFFFFFFFF91F9B8h:jmp64]        encoding(5 bytes) = e8 82 f9 91 ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,70h                   ; ADD(Add_rm64_imm8) [RSP,70h:imm64]                   encoding(4 bytes) = 48 83 c4 70
0040h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vperm2f128Bytes => new byte[66]{0x56,0x48,0x83,0xEC,0x70,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xFF,0xF0,0x02,0xC4,0xC1,0x7F,0xF0,0x08,0x48,0x8B,0xCE,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0x45,0x0F,0xB6,0xC9,0xE8,0x82,0xF9,0x91,0xFF,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x70,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: YMM vpermd(YMM src, YMM control)
; location: [7FFC872FA790h, 7FFC872FA7C8h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
000bh vlddqu ymm1,ymmword ptr [r8]  ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 08
0010h vpermd ymm0,ymm1,ymm0         ; VPERMD(VEX_Vpermd_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]  encoding(VEX, 5 bytes) = c4 e2 75 36 c0
0015h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
001ah vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001fh vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0023h vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
0029h vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
002eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0031h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0034h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpermdBytes => new byte[57]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0xC5,0xFF,0xF0,0x02,0xC4,0xC1,0x7F,0xF0,0x08,0xC4,0xE2,0x75,0x36,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x41,0x10,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: YMM<uint> vpermd(YMM<uint> ymm0, Perm8 spec)
; location: [7FFC872FB000h, 7FFC872FB039h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h test r8,r8                    ; TEST(Test_rm64_r64) [R8,R8]                          encoding(3 bytes) = 4d 85 c0
000ah jne short 0010h               ; JNE(Jne_rel8_64) [10h:jmp64]                         encoding(2 bytes) = 75 04
000ch xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000eh jmp short 0018h               ; JMP(Jmp_rel8_64) [18h:jmp64]                         encoding(2 bytes) = eb 08
0010h lea rax,[r8+10h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R8:br,DS:sr)]        encoding(4 bytes) = 49 8d 40 10
0014h mov r8d,[r8+8]                ; MOV(Mov_r32_rm32) [R8D,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 45 8b 40 08
0018h vlddqu ymm0,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
001ch vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
0020h vpermd ymm0,ymm0,ymm1         ; VPERMD(VEX_Vpermd_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 5 bytes) = c4 e2 7d 36 c1
0025h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0029h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002fh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0034h call 7FFCE6864C00h            ; CALL(Call_rel32_64) [5F569C00h:jmp64]                encoding(5 bytes) = e8 c7 9b 56 5f
0039h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> vpermdBytes => new byte[58]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x4D,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x08,0x49,0x8D,0x40,0x10,0x45,0x8B,0x40,0x08,0xC5,0xFF,0xF0,0x00,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x36,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xC7,0x9B,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: YMM vpermd(YMM src, Perm8 spec)
; location: [7FFC872FB060h, 7FFC872FB0B0h]
0000h sub rsp,58h                   ; SUB(Sub_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 ec 58
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h test r8,r8                    ; TEST(Test_rm64_r64) [R8,R8]                          encoding(3 bytes) = 4d 85 c0
000ah jne short 0010h               ; JNE(Jne_rel8_64) [10h:jmp64]                         encoding(2 bytes) = 75 04
000ch xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000eh jmp short 0018h               ; JMP(Jmp_rel8_64) [18h:jmp64]                         encoding(2 bytes) = eb 08
0010h lea rax,[r8+10h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R8:br,DS:sr)]        encoding(4 bytes) = 49 8d 40 10
0014h mov r8d,[r8+8]                ; MOV(Mov_r32_rm32) [R8D,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 45 8b 40 08
0018h vlddqu ymm0,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
001ch vlddqu ymm1,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 0a
0020h vpermd ymm0,ymm0,ymm1         ; VPERMD(VEX_Vpermd_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 5 bytes) = c4 e2 7d 36 c1
0025h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
002bh vmovdqu xmm0,xmmword ptr [rsp+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 20
0031h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0035h vmovdqu xmm0,xmmword ptr [rsp+30h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 30
003bh vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
0040h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0043h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0046h add rsp,58h                   ; ADD(Add_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 c4 58
004ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004bh call 7FFCE6864C00h            ; CALL(Call_rel32_64) [5F569BA0h:jmp64]                encoding(5 bytes) = e8 50 9b 56 5f
0050h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> vpermdBytes => new byte[81]{0x48,0x83,0xEC,0x58,0xC5,0xF8,0x77,0x4D,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x08,0x49,0x8D,0x40,0x10,0x45,0x8B,0x40,0x08,0xC5,0xFF,0xF0,0x00,0xC5,0xFF,0xF0,0x0A,0xC4,0xE2,0x7D,0x36,0xC1,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFA,0x6F,0x44,0x24,0x20,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x44,0x24,0x30,0xC5,0xFA,0x7F,0x41,0x10,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x58,0xC3,0xE8,0x50,0x9B,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: XMM pxor(XMM xmm0, XMM xmm1)
; location: [7FFC872FB0D0h, 7FFC872FB0F9h]
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
; location: [7FFC872FB120h, 7FFC872FB138h]
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
; location: [7FFC872FB150h, 7FFC872FB187h]
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
; location: [7FFC872FB1B0h, 7FFC872FB1E8h]
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
; location: [7FFC872FB210h, 7FFC872FB22Ch]
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
