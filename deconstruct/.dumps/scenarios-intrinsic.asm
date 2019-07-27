# 2019-07-27 03:27:11:663
7FFC86816970h Vec128<sbyte> add1(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfc, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86816970h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpaddb xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddb_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fc,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86816970h ---------------------------------------------------------------------------------------------

7FFC868169A0h Vec128<sbyte> add2(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfc, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC868169A0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpaddb xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddb_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fc,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC868169A0h ---------------------------------------------------------------------------------------------

7FFC868169D0h Vector128<sbyte> add3(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0xfc, 0x00, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC868169D0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vpaddb xmm0,xmm0,[r8]   ; opcode := VEX_Vpaddb_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,fc,00} (5 bytes)
000eh  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0012h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0015h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC868169D0h ---------------------------------------------------------------------------------------------

7FFC86816A00h Vector256<sbyte> add4(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0xfc, 0x00, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86816A00h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vpaddb ymm0,ymm0,[r8]   ; opcode := VEX_Vpaddb_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,fc,00} (5 bytes)
000eh  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0012h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0015h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0018h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86816A00h ---------------------------------------------------------------------------------------------

7FFC86816A30h Vec256<sbyte> add5(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfc, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86816A30h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpaddb ymm0,ymm0,ymm1   ; opcode := VEX_Vpaddb_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fc,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86816A30h ---------------------------------------------------------------------------------------------

