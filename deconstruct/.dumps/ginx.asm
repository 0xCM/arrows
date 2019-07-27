# 2019-07-27 04:33:02:929
7FFC86D85440h void sub<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xf8, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86D85440h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpsubb xmm0,xmm0,xmm1   ; opcode := VEX_Vpsubb_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,f8,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D85440h ---------------------------------------------------------------------------------------------

7FFC86D85880h void sub<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xf9, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86D85880h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpsubw xmm0,xmm0,xmm1   ; opcode := VEX_Vpsubw_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,f9,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D85880h ---------------------------------------------------------------------------------------------

7FFC86D85CC0h void sub<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfa, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86D85CC0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpsubd xmm0,xmm0,xmm1   ; opcode := VEX_Vpsubd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fa,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D85CC0h ---------------------------------------------------------------------------------------------

7FFC86D85CF0h void sub<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86D85CF0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpsubq xmm0,xmm0,xmm1   ; opcode := VEX_Vpsubq_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fb,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D85CF0h ---------------------------------------------------------------------------------------------

7FFC86D86130h void sub<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xf8, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86D86130h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpsubb xmm0,xmm0,xmm1   ; opcode := VEX_Vpsubb_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,f8,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D86130h ---------------------------------------------------------------------------------------------

7FFC86D86160h void sub<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xf9, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86D86160h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpsubw xmm0,xmm0,xmm1   ; opcode := VEX_Vpsubw_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,f9,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D86160h ---------------------------------------------------------------------------------------------

7FFC86D865A0h void sub<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfa, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86D865A0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpsubd xmm0,xmm0,xmm1   ; opcode := VEX_Vpsubd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fa,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D865A0h ---------------------------------------------------------------------------------------------

7FFC86D869E0h void sub<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86D869E0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpsubq xmm0,xmm0,xmm1   ; opcode := VEX_Vpsubq_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fb,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D869E0h ---------------------------------------------------------------------------------------------

7FFC86D86A10h void sub<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf8, 0x5c, 0xc1, 0xc4, 0xc1, 0x78, 0x11, 0x00, 0xc3}
asm-body-begin 7FFC86D86A10h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vsubps xmm0,xmm0,xmm1   ; opcode := VEX_Vsubps_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f8,5c,c1} (4 bytes)
0011h  vmovups [r8],xmm0   ; opcode := VEX_Vmovups_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,78,11,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D86A10h ---------------------------------------------------------------------------------------------

7FFC86D86E50h void sub<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0x5c, 0xc1, 0xc4, 0xc1, 0x79, 0x11, 0x00, 0xc3}
asm-body-begin 7FFC86D86E50h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vsubpd xmm0,xmm0,xmm1   ; opcode := VEX_Vsubpd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,5c,c1} (4 bytes)
0011h  vmovupd [r8],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,79,11,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D86E50h ---------------------------------------------------------------------------------------------

7FFC86D87290h void sub<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xf8, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86D87290h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpsubb ymm0,ymm0,ymm1   ; opcode := VEX_Vpsubb_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,f8,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D87290h ---------------------------------------------------------------------------------------------

7FFC86D872C0h void sub<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xf9, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86D872C0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpsubw ymm0,ymm0,ymm1   ; opcode := VEX_Vpsubw_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,f9,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D872C0h ---------------------------------------------------------------------------------------------

7FFC86D87700h void sub<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfa, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86D87700h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpsubd ymm0,ymm0,ymm1   ; opcode := VEX_Vpsubd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fa,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D87700h ---------------------------------------------------------------------------------------------

7FFC86D87730h void sub<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86D87730h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpsubq ymm0,ymm0,ymm1   ; opcode := VEX_Vpsubq_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fb,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D87730h ---------------------------------------------------------------------------------------------

7FFC86D87B70h void sub<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xf8, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86D87B70h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpsubb ymm0,ymm0,ymm1   ; opcode := VEX_Vpsubb_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,f8,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D87B70h ---------------------------------------------------------------------------------------------

7FFC86D87BA0h void sub<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xf9, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86D87BA0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpsubw ymm0,ymm0,ymm1   ; opcode := VEX_Vpsubw_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,f9,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D87BA0h ---------------------------------------------------------------------------------------------

7FFC86D87FE0h void sub<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfa, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86D87FE0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpsubd ymm0,ymm0,ymm1   ; opcode := VEX_Vpsubd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fa,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D87FE0h ---------------------------------------------------------------------------------------------

7FFC86D88010h void sub<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86D88010h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpsubq ymm0,ymm0,ymm1   ; opcode := VEX_Vpsubq_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fb,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D88010h ---------------------------------------------------------------------------------------------

7FFC86D88450h void sub<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfc, 0x5c, 0xc1, 0xc4, 0xc1, 0x7c, 0x11, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86D88450h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vsubps ymm0,ymm0,ymm1   ; opcode := VEX_Vsubps_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fc,5c,c1} (4 bytes)
0011h  vmovups [r8],ymm0   ; opcode := VEX_Vmovups_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7c,11,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D88450h ---------------------------------------------------------------------------------------------

7FFC86D88890h void sub<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0x5c, 0xc1, 0xc4, 0xc1, 0x7d, 0x11, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86D88890h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vsubpd ymm0,ymm0,ymm1   ; opcode := VEX_Vsubpd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,5c,c1} (4 bytes)
0011h  vmovupd [r8],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7d,11,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D88890h ---------------------------------------------------------------------------------------------

7FFC86D888C0h Num128<byte> sub<byte>(byref Num128<byte> lhs, byref Num128<byte> rhs)
# encoding: {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8a, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x23, 0x2e, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0xfb, 0x9c, 0x6b, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x23, 0x2e, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0xe4, 0x9c, 0x6b, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0xe1, 0xfd, 0xff, 0xff, 0x48, 0x8b, 0xc8, 0xe8, 0xb1, 0xaf, 0x51, 0x5f, 0xcc}
asm-body-begin 7FFC86D888C0h -------------------------------------------------------------------------------------------
0000h  push rdi   ; opcode := Push_r64 | encoded := {57} (1 bytes)
0001h  push rsi   ; opcode := Push_r64 | encoded := {56} (1 bytes)
0002h  push rbx   ; opcode := Push_r64 | encoded := {53} (1 bytes)
0003h  sub rsp,30h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,30} (4 bytes)
0007h  mov esi,8Ah   ; opcode := Mov_r32_imm32 | encoded := {be,8a,00,00,00} (5 bytes)
000ch  mov edi,1   ; opcode := Mov_r32_imm32 | encoded := {bf,01,00,00,00} (5 bytes)
0011h  mov ecx,2E23h   ; opcode := Mov_r32_imm32 | encoded := {b9,23,2e,00,00} (5 bytes)
0016h  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0020h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,fb,9c,6b,5f} (5 bytes)
0025h  mov rbx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d8} (3 bytes)
0028h  mov ecx,2E23h   ; opcode := Mov_r32_imm32 | encoded := {b9,23,2e,00,00} (5 bytes)
002dh  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0037h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,e4,9c,6b,5f} (5 bytes)
003ch  mov rdx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d0} (3 bytes)
003fh  lea rcx,[rsp+28h]   ; opcode := Lea_r64_m | encoded := {48,8d,4c,24,28} (5 bytes)
0044h  mov [rcx],dil   ; opcode := Mov_rm8_r8 | encoded := {40,88,39} (3 bytes)
0047h  mov [rcx+4],esi   ; opcode := Mov_rm32_r32 | encoded := {89,71,04} (3 bytes)
004ah  mov rcx,rbx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,cb} (3 bytes)
004dh  mov r8,[rsp+28h]   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,44,24,28} (5 bytes)
0052h  call 7FFC86D886F8h   ; opcode := Call_rel32_64 | encoded := {e8,e1,fd,ff,ff} (5 bytes)
0057h  mov rcx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c8} (3 bytes)
005ah  call 7FFCE62A38D0h   ; opcode := Call_rel32_64 | encoded := {e8,b1,af,51,5f} (5 bytes)
005fh  int 3   ; opcode := Int3 | encoded := {cc} (1 bytes)
asm-body-end 7FFC86D888C0h ---------------------------------------------------------------------------------------------

7FFC86D88940h Num128<ushort> sub<ushort>(byref Num128<ushort> lhs, byref Num128<ushort> rhs)
# encoding: {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8a, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x23, 0x2e, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x7b, 0x9c, 0x6b, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x23, 0x2e, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x64, 0x9c, 0x6b, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0xe1, 0xfd, 0xff, 0xff, 0x48, 0x8b, 0xc8, 0xe8, 0x31, 0xaf, 0x51, 0x5f, 0xcc}
asm-body-begin 7FFC86D88940h -------------------------------------------------------------------------------------------
0000h  push rdi   ; opcode := Push_r64 | encoded := {57} (1 bytes)
0001h  push rsi   ; opcode := Push_r64 | encoded := {56} (1 bytes)
0002h  push rbx   ; opcode := Push_r64 | encoded := {53} (1 bytes)
0003h  sub rsp,30h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,30} (4 bytes)
0007h  mov esi,8Ah   ; opcode := Mov_r32_imm32 | encoded := {be,8a,00,00,00} (5 bytes)
000ch  mov edi,1   ; opcode := Mov_r32_imm32 | encoded := {bf,01,00,00,00} (5 bytes)
0011h  mov ecx,2E23h   ; opcode := Mov_r32_imm32 | encoded := {b9,23,2e,00,00} (5 bytes)
0016h  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0020h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,7b,9c,6b,5f} (5 bytes)
0025h  mov rbx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d8} (3 bytes)
0028h  mov ecx,2E23h   ; opcode := Mov_r32_imm32 | encoded := {b9,23,2e,00,00} (5 bytes)
002dh  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0037h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,64,9c,6b,5f} (5 bytes)
003ch  mov rdx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d0} (3 bytes)
003fh  lea rcx,[rsp+28h]   ; opcode := Lea_r64_m | encoded := {48,8d,4c,24,28} (5 bytes)
0044h  mov [rcx],dil   ; opcode := Mov_rm8_r8 | encoded := {40,88,39} (3 bytes)
0047h  mov [rcx+4],esi   ; opcode := Mov_rm32_r32 | encoded := {89,71,04} (3 bytes)
004ah  mov rcx,rbx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,cb} (3 bytes)
004dh  mov r8,[rsp+28h]   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,44,24,28} (5 bytes)
0052h  call 7FFC86D88778h   ; opcode := Call_rel32_64 | encoded := {e8,e1,fd,ff,ff} (5 bytes)
0057h  mov rcx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c8} (3 bytes)
005ah  call 7FFCE62A38D0h   ; opcode := Call_rel32_64 | encoded := {e8,31,af,51,5f} (5 bytes)
005fh  int 3   ; opcode := Int3 | encoded := {cc} (1 bytes)
asm-body-end 7FFC86D88940h ---------------------------------------------------------------------------------------------

7FFC86D889C0h Num128<uint> sub<uint>(byref Num128<uint> lhs, byref Num128<uint> rhs)
# encoding: {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8a, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x23, 0x2e, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0xfb, 0x9b, 0x6b, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x23, 0x2e, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0xe4, 0x9b, 0x6b, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0xd1, 0xfd, 0xff, 0xff, 0x48, 0x8b, 0xc8, 0xe8, 0xb1, 0xae, 0x51, 0x5f, 0xcc}
asm-body-begin 7FFC86D889C0h -------------------------------------------------------------------------------------------
0000h  push rdi   ; opcode := Push_r64 | encoded := {57} (1 bytes)
0001h  push rsi   ; opcode := Push_r64 | encoded := {56} (1 bytes)
0002h  push rbx   ; opcode := Push_r64 | encoded := {53} (1 bytes)
0003h  sub rsp,30h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,30} (4 bytes)
0007h  mov esi,8Ah   ; opcode := Mov_r32_imm32 | encoded := {be,8a,00,00,00} (5 bytes)
000ch  mov edi,1   ; opcode := Mov_r32_imm32 | encoded := {bf,01,00,00,00} (5 bytes)
0011h  mov ecx,2E23h   ; opcode := Mov_r32_imm32 | encoded := {b9,23,2e,00,00} (5 bytes)
0016h  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0020h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,fb,9b,6b,5f} (5 bytes)
0025h  mov rbx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d8} (3 bytes)
0028h  mov ecx,2E23h   ; opcode := Mov_r32_imm32 | encoded := {b9,23,2e,00,00} (5 bytes)
002dh  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0037h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,e4,9b,6b,5f} (5 bytes)
003ch  mov rdx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d0} (3 bytes)
003fh  lea rcx,[rsp+28h]   ; opcode := Lea_r64_m | encoded := {48,8d,4c,24,28} (5 bytes)
0044h  mov [rcx],dil   ; opcode := Mov_rm8_r8 | encoded := {40,88,39} (3 bytes)
0047h  mov [rcx+4],esi   ; opcode := Mov_rm32_r32 | encoded := {89,71,04} (3 bytes)
004ah  mov rcx,rbx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,cb} (3 bytes)
004dh  mov r8,[rsp+28h]   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,44,24,28} (5 bytes)
0052h  call 7FFC86D887E8h   ; opcode := Call_rel32_64 | encoded := {e8,d1,fd,ff,ff} (5 bytes)
0057h  mov rcx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c8} (3 bytes)
005ah  call 7FFCE62A38D0h   ; opcode := Call_rel32_64 | encoded := {e8,b1,ae,51,5f} (5 bytes)
005fh  int 3   ; opcode := Int3 | encoded := {cc} (1 bytes)
asm-body-end 7FFC86D889C0h ---------------------------------------------------------------------------------------------

7FFC86D88A40h Num128<ulong> sub<ulong>(byref Num128<ulong> lhs, byref Num128<ulong> rhs)
# encoding: {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8a, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x23, 0x2e, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x7b, 0x9b, 0x6b, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x23, 0x2e, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x64, 0x9b, 0x6b, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0xc1, 0xfd, 0xff, 0xff, 0x48, 0x8b, 0xc8, 0xe8, 0x31, 0xae, 0x51, 0x5f, 0xcc}
asm-body-begin 7FFC86D88A40h -------------------------------------------------------------------------------------------
0000h  push rdi   ; opcode := Push_r64 | encoded := {57} (1 bytes)
0001h  push rsi   ; opcode := Push_r64 | encoded := {56} (1 bytes)
0002h  push rbx   ; opcode := Push_r64 | encoded := {53} (1 bytes)
0003h  sub rsp,30h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,30} (4 bytes)
0007h  mov esi,8Ah   ; opcode := Mov_r32_imm32 | encoded := {be,8a,00,00,00} (5 bytes)
000ch  mov edi,1   ; opcode := Mov_r32_imm32 | encoded := {bf,01,00,00,00} (5 bytes)
0011h  mov ecx,2E23h   ; opcode := Mov_r32_imm32 | encoded := {b9,23,2e,00,00} (5 bytes)
0016h  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0020h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,7b,9b,6b,5f} (5 bytes)
0025h  mov rbx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d8} (3 bytes)
0028h  mov ecx,2E23h   ; opcode := Mov_r32_imm32 | encoded := {b9,23,2e,00,00} (5 bytes)
002dh  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0037h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,64,9b,6b,5f} (5 bytes)
003ch  mov rdx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d0} (3 bytes)
003fh  lea rcx,[rsp+28h]   ; opcode := Lea_r64_m | encoded := {48,8d,4c,24,28} (5 bytes)
0044h  mov [rcx],dil   ; opcode := Mov_rm8_r8 | encoded := {40,88,39} (3 bytes)
0047h  mov [rcx+4],esi   ; opcode := Mov_rm32_r32 | encoded := {89,71,04} (3 bytes)
004ah  mov rcx,rbx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,cb} (3 bytes)
004dh  mov r8,[rsp+28h]   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,44,24,28} (5 bytes)
0052h  call 7FFC86D88858h   ; opcode := Call_rel32_64 | encoded := {e8,c1,fd,ff,ff} (5 bytes)
0057h  mov rcx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c8} (3 bytes)
005ah  call 7FFCE62A38D0h   ; opcode := Call_rel32_64 | encoded := {e8,31,ae,51,5f} (5 bytes)
005fh  int 3   ; opcode := Int3 | encoded := {cc} (1 bytes)
asm-body-end 7FFC86D88A40h ---------------------------------------------------------------------------------------------

7FFC86D88EC0h Num128<sbyte> sub<sbyte>(byref Num128<sbyte> lhs, byref Num128<sbyte> rhs)
# encoding: {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8a, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x23, 0x2e, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0xfb, 0x96, 0x6b, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x23, 0x2e, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0xe4, 0x96, 0x6b, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0x51, 0xf9, 0xff, 0xff, 0x48, 0x8b, 0xc8, 0xe8, 0xb1, 0xa9, 0x51, 0x5f, 0xcc}
asm-body-begin 7FFC86D88EC0h -------------------------------------------------------------------------------------------
0000h  push rdi   ; opcode := Push_r64 | encoded := {57} (1 bytes)
0001h  push rsi   ; opcode := Push_r64 | encoded := {56} (1 bytes)
0002h  push rbx   ; opcode := Push_r64 | encoded := {53} (1 bytes)
0003h  sub rsp,30h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,30} (4 bytes)
0007h  mov esi,8Ah   ; opcode := Mov_r32_imm32 | encoded := {be,8a,00,00,00} (5 bytes)
000ch  mov edi,1   ; opcode := Mov_r32_imm32 | encoded := {bf,01,00,00,00} (5 bytes)
0011h  mov ecx,2E23h   ; opcode := Mov_r32_imm32 | encoded := {b9,23,2e,00,00} (5 bytes)
0016h  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0020h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,fb,96,6b,5f} (5 bytes)
0025h  mov rbx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d8} (3 bytes)
0028h  mov ecx,2E23h   ; opcode := Mov_r32_imm32 | encoded := {b9,23,2e,00,00} (5 bytes)
002dh  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0037h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,e4,96,6b,5f} (5 bytes)
003ch  mov rdx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d0} (3 bytes)
003fh  lea rcx,[rsp+28h]   ; opcode := Lea_r64_m | encoded := {48,8d,4c,24,28} (5 bytes)
0044h  mov [rcx],dil   ; opcode := Mov_rm8_r8 | encoded := {40,88,39} (3 bytes)
0047h  mov [rcx+4],esi   ; opcode := Mov_rm32_r32 | encoded := {89,71,04} (3 bytes)
004ah  mov rcx,rbx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,cb} (3 bytes)
004dh  mov r8,[rsp+28h]   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,44,24,28} (5 bytes)
0052h  call 7FFC86D88868h   ; opcode := Call_rel32_64 | encoded := {e8,51,f9,ff,ff} (5 bytes)
0057h  mov rcx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c8} (3 bytes)
005ah  call 7FFCE62A38D0h   ; opcode := Call_rel32_64 | encoded := {e8,b1,a9,51,5f} (5 bytes)
005fh  int 3   ; opcode := Int3 | encoded := {cc} (1 bytes)
asm-body-end 7FFC86D88EC0h ---------------------------------------------------------------------------------------------

7FFC86D88F40h Num128<short> sub<short>(byref Num128<short> lhs, byref Num128<short> rhs)
# encoding: {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8a, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x23, 0x2e, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x7b, 0x96, 0x6b, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x23, 0x2e, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x64, 0x96, 0x6b, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0xe1, 0xfb, 0xff, 0xff, 0x48, 0x8b, 0xc8, 0xe8, 0x31, 0xa9, 0x51, 0x5f, 0xcc}
asm-body-begin 7FFC86D88F40h -------------------------------------------------------------------------------------------
0000h  push rdi   ; opcode := Push_r64 | encoded := {57} (1 bytes)
0001h  push rsi   ; opcode := Push_r64 | encoded := {56} (1 bytes)
0002h  push rbx   ; opcode := Push_r64 | encoded := {53} (1 bytes)
0003h  sub rsp,30h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,30} (4 bytes)
0007h  mov esi,8Ah   ; opcode := Mov_r32_imm32 | encoded := {be,8a,00,00,00} (5 bytes)
000ch  mov edi,1   ; opcode := Mov_r32_imm32 | encoded := {bf,01,00,00,00} (5 bytes)
0011h  mov ecx,2E23h   ; opcode := Mov_r32_imm32 | encoded := {b9,23,2e,00,00} (5 bytes)
0016h  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0020h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,7b,96,6b,5f} (5 bytes)
0025h  mov rbx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d8} (3 bytes)
0028h  mov ecx,2E23h   ; opcode := Mov_r32_imm32 | encoded := {b9,23,2e,00,00} (5 bytes)
002dh  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0037h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,64,96,6b,5f} (5 bytes)
003ch  mov rdx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d0} (3 bytes)
003fh  lea rcx,[rsp+28h]   ; opcode := Lea_r64_m | encoded := {48,8d,4c,24,28} (5 bytes)
0044h  mov [rcx],dil   ; opcode := Mov_rm8_r8 | encoded := {40,88,39} (3 bytes)
0047h  mov [rcx+4],esi   ; opcode := Mov_rm32_r32 | encoded := {89,71,04} (3 bytes)
004ah  mov rcx,rbx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,cb} (3 bytes)
004dh  mov r8,[rsp+28h]   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,44,24,28} (5 bytes)
0052h  call 7FFC86D88B78h   ; opcode := Call_rel32_64 | encoded := {e8,e1,fb,ff,ff} (5 bytes)
0057h  mov rcx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c8} (3 bytes)
005ah  call 7FFCE62A38D0h   ; opcode := Call_rel32_64 | encoded := {e8,31,a9,51,5f} (5 bytes)
005fh  int 3   ; opcode := Int3 | encoded := {cc} (1 bytes)
asm-body-end 7FFC86D88F40h ---------------------------------------------------------------------------------------------

7FFC86D88FC0h Num128<int> sub<int>(byref Num128<int> lhs, byref Num128<int> rhs)
# encoding: {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8a, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x23, 0x2e, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0xfb, 0x95, 0x6b, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x23, 0x2e, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0xe4, 0x95, 0x6b, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0xd1, 0xfb, 0xff, 0xff, 0x48, 0x8b, 0xc8, 0xe8, 0xb1, 0xa8, 0x51, 0x5f, 0xcc}
asm-body-begin 7FFC86D88FC0h -------------------------------------------------------------------------------------------
0000h  push rdi   ; opcode := Push_r64 | encoded := {57} (1 bytes)
0001h  push rsi   ; opcode := Push_r64 | encoded := {56} (1 bytes)
0002h  push rbx   ; opcode := Push_r64 | encoded := {53} (1 bytes)
0003h  sub rsp,30h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,30} (4 bytes)
0007h  mov esi,8Ah   ; opcode := Mov_r32_imm32 | encoded := {be,8a,00,00,00} (5 bytes)
000ch  mov edi,1   ; opcode := Mov_r32_imm32 | encoded := {bf,01,00,00,00} (5 bytes)
0011h  mov ecx,2E23h   ; opcode := Mov_r32_imm32 | encoded := {b9,23,2e,00,00} (5 bytes)
0016h  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0020h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,fb,95,6b,5f} (5 bytes)
0025h  mov rbx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d8} (3 bytes)
0028h  mov ecx,2E23h   ; opcode := Mov_r32_imm32 | encoded := {b9,23,2e,00,00} (5 bytes)
002dh  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0037h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,e4,95,6b,5f} (5 bytes)
003ch  mov rdx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d0} (3 bytes)
003fh  lea rcx,[rsp+28h]   ; opcode := Lea_r64_m | encoded := {48,8d,4c,24,28} (5 bytes)
0044h  mov [rcx],dil   ; opcode := Mov_rm8_r8 | encoded := {40,88,39} (3 bytes)
0047h  mov [rcx+4],esi   ; opcode := Mov_rm32_r32 | encoded := {89,71,04} (3 bytes)
004ah  mov rcx,rbx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,cb} (3 bytes)
004dh  mov r8,[rsp+28h]   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,44,24,28} (5 bytes)
0052h  call 7FFC86D88BE8h   ; opcode := Call_rel32_64 | encoded := {e8,d1,fb,ff,ff} (5 bytes)
0057h  mov rcx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c8} (3 bytes)
005ah  call 7FFCE62A38D0h   ; opcode := Call_rel32_64 | encoded := {e8,b1,a8,51,5f} (5 bytes)
005fh  int 3   ; opcode := Int3 | encoded := {cc} (1 bytes)
asm-body-end 7FFC86D88FC0h ---------------------------------------------------------------------------------------------

7FFC86D89040h Num128<long> sub<long>(byref Num128<long> lhs, byref Num128<long> rhs)
# encoding: {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8a, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x23, 0x2e, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x7b, 0x95, 0x6b, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x23, 0x2e, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x64, 0x95, 0x6b, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0xc1, 0xfb, 0xff, 0xff, 0x48, 0x8b, 0xc8, 0xe8, 0x31, 0xa8, 0x51, 0x5f, 0xcc}
asm-body-begin 7FFC86D89040h -------------------------------------------------------------------------------------------
0000h  push rdi   ; opcode := Push_r64 | encoded := {57} (1 bytes)
0001h  push rsi   ; opcode := Push_r64 | encoded := {56} (1 bytes)
0002h  push rbx   ; opcode := Push_r64 | encoded := {53} (1 bytes)
0003h  sub rsp,30h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,30} (4 bytes)
0007h  mov esi,8Ah   ; opcode := Mov_r32_imm32 | encoded := {be,8a,00,00,00} (5 bytes)
000ch  mov edi,1   ; opcode := Mov_r32_imm32 | encoded := {bf,01,00,00,00} (5 bytes)
0011h  mov ecx,2E23h   ; opcode := Mov_r32_imm32 | encoded := {b9,23,2e,00,00} (5 bytes)
0016h  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0020h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,7b,95,6b,5f} (5 bytes)
0025h  mov rbx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d8} (3 bytes)
0028h  mov ecx,2E23h   ; opcode := Mov_r32_imm32 | encoded := {b9,23,2e,00,00} (5 bytes)
002dh  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0037h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,64,95,6b,5f} (5 bytes)
003ch  mov rdx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d0} (3 bytes)
003fh  lea rcx,[rsp+28h]   ; opcode := Lea_r64_m | encoded := {48,8d,4c,24,28} (5 bytes)
0044h  mov [rcx],dil   ; opcode := Mov_rm8_r8 | encoded := {40,88,39} (3 bytes)
0047h  mov [rcx+4],esi   ; opcode := Mov_rm32_r32 | encoded := {89,71,04} (3 bytes)
004ah  mov rcx,rbx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,cb} (3 bytes)
004dh  mov r8,[rsp+28h]   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,44,24,28} (5 bytes)
0052h  call 7FFC86D88C58h   ; opcode := Call_rel32_64 | encoded := {e8,c1,fb,ff,ff} (5 bytes)
0057h  mov rcx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c8} (3 bytes)
005ah  call 7FFCE62A38D0h   ; opcode := Call_rel32_64 | encoded := {e8,31,a8,51,5f} (5 bytes)
005fh  int 3   ; opcode := Int3 | encoded := {cc} (1 bytes)
asm-body-end 7FFC86D89040h ---------------------------------------------------------------------------------------------

7FFC86D894C0h Num128<float> sub<float>(byref Num128<float> lhs, byref Num128<float> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xfa, 0x5c, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86D894C0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vsubss xmm0,xmm0,xmm1   ; opcode := VEX_Vsubss_xmm_xmm_xmmm32 (VEX encoded) | encoded := {c5,fa,5c,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D894C0h ---------------------------------------------------------------------------------------------

7FFC86D894F0h Num128<double> sub<double>(byref Num128<double> lhs, byref Num128<double> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xfb, 0x5c, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86D894F0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vsubsd xmm0,xmm0,xmm1   ; opcode := VEX_Vsubsd_xmm_xmm_xmmm64 (VEX encoded) | encoded := {c5,fb,5c,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D894F0h ---------------------------------------------------------------------------------------------

7FFC86D89520h Vec128<byte> and<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xdb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86D89520h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpand xmm0,xmm0,xmm1   ; opcode := VEX_Vpand_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,db,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D89520h ---------------------------------------------------------------------------------------------

7FFC86D89960h Vec128<ushort> and<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xdb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86D89960h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpand xmm0,xmm0,xmm1   ; opcode := VEX_Vpand_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,db,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D89960h ---------------------------------------------------------------------------------------------

7FFC86D89990h Vec128<uint> and<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xdb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86D89990h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpand xmm0,xmm0,xmm1   ; opcode := VEX_Vpand_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,db,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D89990h ---------------------------------------------------------------------------------------------

7FFC86D899C0h Vec128<ulong> and<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xdb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86D899C0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpand xmm0,xmm0,xmm1   ; opcode := VEX_Vpand_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,db,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D899C0h ---------------------------------------------------------------------------------------------

7FFC86D89E00h Vec128<sbyte> and<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xdb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86D89E00h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpand xmm0,xmm0,xmm1   ; opcode := VEX_Vpand_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,db,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D89E00h ---------------------------------------------------------------------------------------------

7FFC86D89E30h Vec128<short> and<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xdb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86D89E30h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpand xmm0,xmm0,xmm1   ; opcode := VEX_Vpand_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,db,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D89E30h ---------------------------------------------------------------------------------------------

7FFC86D89E60h Vec128<int> and<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xdb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86D89E60h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpand xmm0,xmm0,xmm1   ; opcode := VEX_Vpand_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,db,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D89E60h ---------------------------------------------------------------------------------------------

7FFC86D8A2A0h Vec128<long> and<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xdb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86D8A2A0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpand xmm0,xmm0,xmm1   ; opcode := VEX_Vpand_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,db,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D8A2A0h ---------------------------------------------------------------------------------------------

7FFC86D8A2D0h Vec128<float> and<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf8, 0x54, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86D8A2D0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vandps xmm0,xmm0,xmm1   ; opcode := VEX_Vandps_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f8,54,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86D8A2D0h ---------------------------------------------------------------------------------------------

7FFC8682A410h Vec128<double> and<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0x54, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC8682A410h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vandpd xmm0,xmm0,xmm1   ; opcode := VEX_Vandpd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,54,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC8682A410h ---------------------------------------------------------------------------------------------

7FFC86CB7F70h Vec256<byte> and<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xdb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB7F70h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpand ymm0,ymm0,ymm1   ; opcode := VEX_Vpand_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,db,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB7F70h ---------------------------------------------------------------------------------------------

7FFC86CB7FA0h Vec256<ushort> and<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xdb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB7FA0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpand ymm0,ymm0,ymm1   ; opcode := VEX_Vpand_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,db,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB7FA0h ---------------------------------------------------------------------------------------------

7FFC86CB7FD0h Vec256<uint> and<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xdb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB7FD0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpand ymm0,ymm0,ymm1   ; opcode := VEX_Vpand_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,db,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB7FD0h ---------------------------------------------------------------------------------------------

7FFC86CB8410h Vec256<ulong> and<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xdb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB8410h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpand ymm0,ymm0,ymm1   ; opcode := VEX_Vpand_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,db,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8410h ---------------------------------------------------------------------------------------------

7FFC86CB8440h Vec256<sbyte> and<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xdb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB8440h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpand ymm0,ymm0,ymm1   ; opcode := VEX_Vpand_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,db,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8440h ---------------------------------------------------------------------------------------------

7FFC86CB8470h Vec256<short> and<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xdb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB8470h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpand ymm0,ymm0,ymm1   ; opcode := VEX_Vpand_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,db,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8470h ---------------------------------------------------------------------------------------------

7FFC86CB88B0h Vec256<int> and<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xdb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB88B0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpand ymm0,ymm0,ymm1   ; opcode := VEX_Vpand_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,db,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB88B0h ---------------------------------------------------------------------------------------------

7FFC86CB88E0h Vec256<long> and<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xdb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB88E0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpand ymm0,ymm0,ymm1   ; opcode := VEX_Vpand_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,db,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB88E0h ---------------------------------------------------------------------------------------------

7FFC86CB8910h Vec256<float> and<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfc, 0x54, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB8910h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vandps ymm0,ymm0,ymm1   ; opcode := VEX_Vandps_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fc,54,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8910h ---------------------------------------------------------------------------------------------

7FFC86CB8D50h Vec256<double> and<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0x54, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB8D50h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vandpd ymm0,ymm0,ymm1   ; opcode := VEX_Vandpd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,54,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8D50h ---------------------------------------------------------------------------------------------

7FFC86CB8D80h void and<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xdb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CB8D80h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpand xmm0,xmm0,xmm1   ; opcode := VEX_Vpand_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,db,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8D80h ---------------------------------------------------------------------------------------------

7FFC86CB8DB0h void and<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xdb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CB8DB0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpand xmm0,xmm0,xmm1   ; opcode := VEX_Vpand_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,db,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8DB0h ---------------------------------------------------------------------------------------------

7FFC86CB8DE0h void and<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xdb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CB8DE0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpand xmm0,xmm0,xmm1   ; opcode := VEX_Vpand_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,db,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8DE0h ---------------------------------------------------------------------------------------------

7FFC86CB8E10h void and<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xdb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CB8E10h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpand xmm0,xmm0,xmm1   ; opcode := VEX_Vpand_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,db,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8E10h ---------------------------------------------------------------------------------------------

7FFC86CB8E40h void and<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xdb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CB8E40h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpand xmm0,xmm0,xmm1   ; opcode := VEX_Vpand_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,db,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8E40h ---------------------------------------------------------------------------------------------

7FFC86CB8E70h void and<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xdb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CB8E70h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpand xmm0,xmm0,xmm1   ; opcode := VEX_Vpand_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,db,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8E70h ---------------------------------------------------------------------------------------------

7FFC86CB8EA0h void and<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xdb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CB8EA0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpand xmm0,xmm0,xmm1   ; opcode := VEX_Vpand_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,db,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8EA0h ---------------------------------------------------------------------------------------------

7FFC86CB8ED0h void and<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xdb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CB8ED0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpand xmm0,xmm0,xmm1   ; opcode := VEX_Vpand_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,db,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8ED0h ---------------------------------------------------------------------------------------------

7FFC86CB8F00h void and<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf8, 0x54, 0xc1, 0xc4, 0xc1, 0x78, 0x11, 0x00, 0xc3}
asm-body-begin 7FFC86CB8F00h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vandps xmm0,xmm0,xmm1   ; opcode := VEX_Vandps_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f8,54,c1} (4 bytes)
0011h  vmovups [r8],xmm0   ; opcode := VEX_Vmovups_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,78,11,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8F00h ---------------------------------------------------------------------------------------------

7FFC86CB8F30h void and<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0x54, 0xc1, 0xc4, 0xc1, 0x79, 0x11, 0x00, 0xc3}
asm-body-begin 7FFC86CB8F30h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vandpd xmm0,xmm0,xmm1   ; opcode := VEX_Vandpd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,54,c1} (4 bytes)
0011h  vmovupd [r8],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,79,11,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8F30h ---------------------------------------------------------------------------------------------

7FFC86CB8F60h void and<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xdb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB8F60h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpand ymm0,ymm0,ymm1   ; opcode := VEX_Vpand_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,db,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8F60h ---------------------------------------------------------------------------------------------

7FFC86CB8F90h void and<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xdb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB8F90h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpand ymm0,ymm0,ymm1   ; opcode := VEX_Vpand_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,db,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8F90h ---------------------------------------------------------------------------------------------

7FFC86CB8FC0h void and<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xdb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB8FC0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpand ymm0,ymm0,ymm1   ; opcode := VEX_Vpand_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,db,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8FC0h ---------------------------------------------------------------------------------------------

7FFC86CB8FF0h void and<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xdb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB8FF0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpand ymm0,ymm0,ymm1   ; opcode := VEX_Vpand_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,db,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB8FF0h ---------------------------------------------------------------------------------------------

7FFC86CB9020h void and<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xdb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB9020h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpand ymm0,ymm0,ymm1   ; opcode := VEX_Vpand_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,db,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9020h ---------------------------------------------------------------------------------------------

7FFC86CB9050h void and<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xdb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB9050h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpand ymm0,ymm0,ymm1   ; opcode := VEX_Vpand_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,db,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9050h ---------------------------------------------------------------------------------------------

7FFC86CB9080h void and<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xdb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB9080h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpand ymm0,ymm0,ymm1   ; opcode := VEX_Vpand_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,db,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9080h ---------------------------------------------------------------------------------------------

7FFC86CB90B0h void and<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xdb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB90B0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpand ymm0,ymm0,ymm1   ; opcode := VEX_Vpand_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,db,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB90B0h ---------------------------------------------------------------------------------------------

7FFC86CB90E0h void and<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfc, 0x54, 0xc1, 0xc4, 0xc1, 0x7c, 0x11, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB90E0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vandps ymm0,ymm0,ymm1   ; opcode := VEX_Vandps_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fc,54,c1} (4 bytes)
0011h  vmovups [r8],ymm0   ; opcode := VEX_Vmovups_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7c,11,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB90E0h ---------------------------------------------------------------------------------------------

7FFC86CB9110h void and<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0x54, 0xc1, 0xc4, 0xc1, 0x7d, 0x11, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB9110h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vandpd ymm0,ymm0,ymm1   ; opcode := VEX_Vandpd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,54,c1} (4 bytes)
0011h  vmovupd [r8],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7d,11,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9110h ---------------------------------------------------------------------------------------------

7FFC86CB9140h Vec128<byte> or<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xeb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CB9140h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpor xmm0,xmm0,xmm1   ; opcode := VEX_Vpor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,eb,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9140h ---------------------------------------------------------------------------------------------

7FFC86CB9170h Vec128<ushort> or<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xeb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CB9170h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpor xmm0,xmm0,xmm1   ; opcode := VEX_Vpor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,eb,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9170h ---------------------------------------------------------------------------------------------

7FFC86CB91A0h Vec128<uint> or<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xeb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CB91A0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpor xmm0,xmm0,xmm1   ; opcode := VEX_Vpor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,eb,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB91A0h ---------------------------------------------------------------------------------------------

7FFC86CB91D0h Vec128<ulong> or<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xeb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CB91D0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpor xmm0,xmm0,xmm1   ; opcode := VEX_Vpor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,eb,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB91D0h ---------------------------------------------------------------------------------------------

7FFC86CB9200h Vec128<sbyte> or<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xeb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CB9200h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpor xmm0,xmm0,xmm1   ; opcode := VEX_Vpor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,eb,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9200h ---------------------------------------------------------------------------------------------

7FFC86CB9640h Vec128<short> or<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xeb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CB9640h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpor xmm0,xmm0,xmm1   ; opcode := VEX_Vpor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,eb,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9640h ---------------------------------------------------------------------------------------------

7FFC86CB9670h Vec128<int> or<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xeb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CB9670h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpor xmm0,xmm0,xmm1   ; opcode := VEX_Vpor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,eb,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9670h ---------------------------------------------------------------------------------------------

7FFC86CB96A0h Vec128<long> or<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xeb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CB96A0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpor xmm0,xmm0,xmm1   ; opcode := VEX_Vpor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,eb,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB96A0h ---------------------------------------------------------------------------------------------

7FFC86CB96D0h Vec128<float> or<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf8, 0x56, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CB96D0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vorps xmm0,xmm0,xmm1   ; opcode := VEX_Vorps_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f8,56,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB96D0h ---------------------------------------------------------------------------------------------

7FFC86CB9700h Vec128<double> or<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0x56, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CB9700h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vorpd xmm0,xmm0,xmm1   ; opcode := VEX_Vorpd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,56,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9700h ---------------------------------------------------------------------------------------------

7FFC86CB9730h Vec256<byte> or<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xeb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB9730h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpor ymm0,ymm0,ymm1   ; opcode := VEX_Vpor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,eb,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9730h ---------------------------------------------------------------------------------------------

7FFC86CB9760h Vec256<ushort> or<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xeb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB9760h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpor ymm0,ymm0,ymm1   ; opcode := VEX_Vpor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,eb,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9760h ---------------------------------------------------------------------------------------------

7FFC86CB9790h Vec256<uint> or<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xeb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB9790h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpor ymm0,ymm0,ymm1   ; opcode := VEX_Vpor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,eb,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9790h ---------------------------------------------------------------------------------------------

7FFC86CB97C0h Vec256<ulong> or<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xeb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB97C0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpor ymm0,ymm0,ymm1   ; opcode := VEX_Vpor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,eb,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB97C0h ---------------------------------------------------------------------------------------------

7FFC86CB97F0h Vec256<sbyte> or<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xeb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB97F0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpor ymm0,ymm0,ymm1   ; opcode := VEX_Vpor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,eb,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB97F0h ---------------------------------------------------------------------------------------------

7FFC86CB9820h Vec256<short> or<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xeb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB9820h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpor ymm0,ymm0,ymm1   ; opcode := VEX_Vpor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,eb,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9820h ---------------------------------------------------------------------------------------------

7FFC86CB9850h Vec256<int> or<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xeb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB9850h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpor ymm0,ymm0,ymm1   ; opcode := VEX_Vpor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,eb,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9850h ---------------------------------------------------------------------------------------------

7FFC86CB9880h Vec256<long> or<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xeb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB9880h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpor ymm0,ymm0,ymm1   ; opcode := VEX_Vpor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,eb,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9880h ---------------------------------------------------------------------------------------------

7FFC86CB98B0h Vec256<float> or<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfc, 0x56, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB98B0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vorps ymm0,ymm0,ymm1   ; opcode := VEX_Vorps_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fc,56,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB98B0h ---------------------------------------------------------------------------------------------

7FFC86CB98E0h Vec256<double> or<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0x56, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB98E0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vorpd ymm0,ymm0,ymm1   ; opcode := VEX_Vorpd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,56,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB98E0h ---------------------------------------------------------------------------------------------

7FFC86CB9910h void or<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xeb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CB9910h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpor xmm0,xmm0,xmm1   ; opcode := VEX_Vpor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,eb,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9910h ---------------------------------------------------------------------------------------------

7FFC86CB9940h void or<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xeb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CB9940h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpor xmm0,xmm0,xmm1   ; opcode := VEX_Vpor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,eb,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9940h ---------------------------------------------------------------------------------------------

7FFC86CB9970h void or<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xeb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CB9970h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpor xmm0,xmm0,xmm1   ; opcode := VEX_Vpor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,eb,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9970h ---------------------------------------------------------------------------------------------

7FFC86CB99A0h void or<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xeb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CB99A0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpor xmm0,xmm0,xmm1   ; opcode := VEX_Vpor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,eb,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB99A0h ---------------------------------------------------------------------------------------------

7FFC86CB99D0h void or<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xeb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CB99D0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpor xmm0,xmm0,xmm1   ; opcode := VEX_Vpor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,eb,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB99D0h ---------------------------------------------------------------------------------------------

7FFC86CB9A00h void or<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xeb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CB9A00h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpor xmm0,xmm0,xmm1   ; opcode := VEX_Vpor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,eb,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9A00h ---------------------------------------------------------------------------------------------

7FFC86CB9A30h void or<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xeb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CB9A30h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpor xmm0,xmm0,xmm1   ; opcode := VEX_Vpor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,eb,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9A30h ---------------------------------------------------------------------------------------------

7FFC86CB9A60h void or<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xeb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CB9A60h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpor xmm0,xmm0,xmm1   ; opcode := VEX_Vpor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,eb,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9A60h ---------------------------------------------------------------------------------------------

7FFC86CB9A90h void or<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf8, 0x56, 0xc1, 0xc4, 0xc1, 0x78, 0x11, 0x00, 0xc3}
asm-body-begin 7FFC86CB9A90h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vorps xmm0,xmm0,xmm1   ; opcode := VEX_Vorps_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f8,56,c1} (4 bytes)
0011h  vmovups [r8],xmm0   ; opcode := VEX_Vmovups_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,78,11,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9A90h ---------------------------------------------------------------------------------------------

7FFC86CB9AC0h void or<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0x56, 0xc1, 0xc4, 0xc1, 0x79, 0x11, 0x00, 0xc3}
asm-body-begin 7FFC86CB9AC0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vorpd xmm0,xmm0,xmm1   ; opcode := VEX_Vorpd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,56,c1} (4 bytes)
0011h  vmovupd [r8],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,79,11,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9AC0h ---------------------------------------------------------------------------------------------

7FFC86CB9AF0h void or<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xeb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB9AF0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpor ymm0,ymm0,ymm1   ; opcode := VEX_Vpor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,eb,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9AF0h ---------------------------------------------------------------------------------------------

7FFC86CB9B20h void or<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xeb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB9B20h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpor ymm0,ymm0,ymm1   ; opcode := VEX_Vpor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,eb,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9B20h ---------------------------------------------------------------------------------------------

7FFC86CB9B50h void or<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xeb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB9B50h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpor ymm0,ymm0,ymm1   ; opcode := VEX_Vpor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,eb,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9B50h ---------------------------------------------------------------------------------------------

7FFC86CB9B80h void or<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xeb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB9B80h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpor ymm0,ymm0,ymm1   ; opcode := VEX_Vpor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,eb,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9B80h ---------------------------------------------------------------------------------------------

7FFC86CB9BB0h void or<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xeb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB9BB0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpor ymm0,ymm0,ymm1   ; opcode := VEX_Vpor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,eb,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9BB0h ---------------------------------------------------------------------------------------------

7FFC86CB9BE0h void or<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xeb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB9BE0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpor ymm0,ymm0,ymm1   ; opcode := VEX_Vpor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,eb,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9BE0h ---------------------------------------------------------------------------------------------

7FFC86CB9C10h void or<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xeb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CB9C10h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpor ymm0,ymm0,ymm1   ; opcode := VEX_Vpor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,eb,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CB9C10h ---------------------------------------------------------------------------------------------

7FFC86CBA050h void or<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xeb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBA050h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpor ymm0,ymm0,ymm1   ; opcode := VEX_Vpor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,eb,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA050h ---------------------------------------------------------------------------------------------

7FFC86CBA080h void or<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfc, 0x56, 0xc1, 0xc4, 0xc1, 0x7c, 0x11, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBA080h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vorps ymm0,ymm0,ymm1   ; opcode := VEX_Vorps_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fc,56,c1} (4 bytes)
0011h  vmovups [r8],ymm0   ; opcode := VEX_Vmovups_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7c,11,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA080h ---------------------------------------------------------------------------------------------

7FFC86CBA0B0h void or<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0x56, 0xc1, 0xc4, 0xc1, 0x7d, 0x11, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBA0B0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vorpd ymm0,ymm0,ymm1   ; opcode := VEX_Vorpd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,56,c1} (4 bytes)
0011h  vmovupd [r8],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7d,11,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA0B0h ---------------------------------------------------------------------------------------------

7FFC86CBA0E0h Vec128<byte> xor<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xef, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBA0E0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpxor xmm0,xmm0,xmm1   ; opcode := VEX_Vpxor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,ef,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA0E0h ---------------------------------------------------------------------------------------------

7FFC86CBA110h Vec128<ushort> xor<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xef, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBA110h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpxor xmm0,xmm0,xmm1   ; opcode := VEX_Vpxor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,ef,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA110h ---------------------------------------------------------------------------------------------

7FFC86CBA140h Vec128<uint> xor<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xef, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBA140h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpxor xmm0,xmm0,xmm1   ; opcode := VEX_Vpxor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,ef,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA140h ---------------------------------------------------------------------------------------------

7FFC86CBA170h Vec128<ulong> xor<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xef, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBA170h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpxor xmm0,xmm0,xmm1   ; opcode := VEX_Vpxor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,ef,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA170h ---------------------------------------------------------------------------------------------

7FFC86CBA1A0h Vec128<sbyte> xor<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xef, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBA1A0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpxor xmm0,xmm0,xmm1   ; opcode := VEX_Vpxor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,ef,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA1A0h ---------------------------------------------------------------------------------------------

7FFC86CBA1D0h Vec128<short> xor<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xef, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBA1D0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpxor xmm0,xmm0,xmm1   ; opcode := VEX_Vpxor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,ef,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA1D0h ---------------------------------------------------------------------------------------------

7FFC86CBA200h Vec128<int> xor<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xef, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBA200h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpxor xmm0,xmm0,xmm1   ; opcode := VEX_Vpxor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,ef,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA200h ---------------------------------------------------------------------------------------------

7FFC86CBA230h Vec128<long> xor<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xef, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBA230h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpxor xmm0,xmm0,xmm1   ; opcode := VEX_Vpxor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,ef,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA230h ---------------------------------------------------------------------------------------------

7FFC86CBA260h Vec128<float> xor<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf8, 0x57, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBA260h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vxorps xmm0,xmm0,xmm1   ; opcode := VEX_Vxorps_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f8,57,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA260h ---------------------------------------------------------------------------------------------

7FFC86CBA290h Vec128<double> xor<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0x57, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBA290h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vxorpd xmm0,xmm0,xmm1   ; opcode := VEX_Vxorpd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,57,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA290h ---------------------------------------------------------------------------------------------

7FFC86CBA2C0h Vec256<byte> xor<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xef, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBA2C0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpxor ymm0,ymm0,ymm1   ; opcode := VEX_Vpxor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,ef,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA2C0h ---------------------------------------------------------------------------------------------

7FFC86CBA2F0h Vec256<ushort> xor<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xef, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBA2F0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpxor ymm0,ymm0,ymm1   ; opcode := VEX_Vpxor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,ef,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA2F0h ---------------------------------------------------------------------------------------------

7FFC86CBA320h Vec256<uint> xor<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xef, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBA320h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpxor ymm0,ymm0,ymm1   ; opcode := VEX_Vpxor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,ef,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA320h ---------------------------------------------------------------------------------------------

7FFC86CBA350h Vec256<ulong> xor<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xef, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBA350h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpxor ymm0,ymm0,ymm1   ; opcode := VEX_Vpxor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,ef,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA350h ---------------------------------------------------------------------------------------------

7FFC86CBA380h Vec256<sbyte> xor<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xef, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBA380h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpxor ymm0,ymm0,ymm1   ; opcode := VEX_Vpxor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,ef,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA380h ---------------------------------------------------------------------------------------------

7FFC86CBA3B0h Vec256<short> xor<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xef, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBA3B0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpxor ymm0,ymm0,ymm1   ; opcode := VEX_Vpxor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,ef,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA3B0h ---------------------------------------------------------------------------------------------

7FFC86CBA3E0h Vec256<int> xor<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xef, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBA3E0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpxor ymm0,ymm0,ymm1   ; opcode := VEX_Vpxor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,ef,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA3E0h ---------------------------------------------------------------------------------------------

7FFC86CBA410h Vec256<long> xor<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xef, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBA410h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpxor ymm0,ymm0,ymm1   ; opcode := VEX_Vpxor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,ef,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA410h ---------------------------------------------------------------------------------------------

7FFC86CBA440h Vec256<float> xor<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfc, 0x57, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBA440h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vxorps ymm0,ymm0,ymm1   ; opcode := VEX_Vxorps_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fc,57,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA440h ---------------------------------------------------------------------------------------------

7FFC86CBA470h Vec256<double> xor<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0x57, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBA470h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vxorpd ymm0,ymm0,ymm1   ; opcode := VEX_Vxorpd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,57,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA470h ---------------------------------------------------------------------------------------------

7FFC86CBA4A0h void xor<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xef, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CBA4A0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpxor xmm0,xmm0,xmm1   ; opcode := VEX_Vpxor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,ef,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA4A0h ---------------------------------------------------------------------------------------------

7FFC86CBA4D0h void xor<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xef, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CBA4D0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpxor xmm0,xmm0,xmm1   ; opcode := VEX_Vpxor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,ef,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA4D0h ---------------------------------------------------------------------------------------------

7FFC86CBA500h void xor<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xef, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CBA500h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpxor xmm0,xmm0,xmm1   ; opcode := VEX_Vpxor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,ef,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA500h ---------------------------------------------------------------------------------------------

7FFC86CBA530h void xor<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xef, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CBA530h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpxor xmm0,xmm0,xmm1   ; opcode := VEX_Vpxor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,ef,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA530h ---------------------------------------------------------------------------------------------

7FFC86CBA560h void xor<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xef, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CBA560h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpxor xmm0,xmm0,xmm1   ; opcode := VEX_Vpxor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,ef,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA560h ---------------------------------------------------------------------------------------------

7FFC86CBA590h void xor<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xef, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CBA590h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpxor xmm0,xmm0,xmm1   ; opcode := VEX_Vpxor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,ef,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA590h ---------------------------------------------------------------------------------------------

7FFC86CBA5C0h void xor<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xef, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CBA5C0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpxor xmm0,xmm0,xmm1   ; opcode := VEX_Vpxor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,ef,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA5C0h ---------------------------------------------------------------------------------------------

7FFC86CBA5F0h void xor<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xef, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CBA5F0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpxor xmm0,xmm0,xmm1   ; opcode := VEX_Vpxor_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,ef,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA5F0h ---------------------------------------------------------------------------------------------

7FFC86CBA620h void xor<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf8, 0x57, 0xc1, 0xc4, 0xc1, 0x78, 0x11, 0x00, 0xc3}
asm-body-begin 7FFC86CBA620h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vxorps xmm0,xmm0,xmm1   ; opcode := VEX_Vxorps_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f8,57,c1} (4 bytes)
0011h  vmovups [r8],xmm0   ; opcode := VEX_Vmovups_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,78,11,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBA620h ---------------------------------------------------------------------------------------------

7FFC86CBAA60h void xor<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0x57, 0xc1, 0xc4, 0xc1, 0x79, 0x11, 0x00, 0xc3}
asm-body-begin 7FFC86CBAA60h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vxorpd xmm0,xmm0,xmm1   ; opcode := VEX_Vxorpd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,57,c1} (4 bytes)
0011h  vmovupd [r8],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,79,11,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAA60h ---------------------------------------------------------------------------------------------

7FFC86CBAA90h void xor<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xef, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBAA90h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpxor ymm0,ymm0,ymm1   ; opcode := VEX_Vpxor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,ef,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAA90h ---------------------------------------------------------------------------------------------

7FFC86CBAAC0h void xor<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xef, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBAAC0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpxor ymm0,ymm0,ymm1   ; opcode := VEX_Vpxor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,ef,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAAC0h ---------------------------------------------------------------------------------------------

7FFC86CBAAF0h void xor<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xef, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBAAF0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpxor ymm0,ymm0,ymm1   ; opcode := VEX_Vpxor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,ef,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAAF0h ---------------------------------------------------------------------------------------------

7FFC86CBAB20h void xor<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xef, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBAB20h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpxor ymm0,ymm0,ymm1   ; opcode := VEX_Vpxor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,ef,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAB20h ---------------------------------------------------------------------------------------------

7FFC86CBAB50h void xor<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xef, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBAB50h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpxor ymm0,ymm0,ymm1   ; opcode := VEX_Vpxor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,ef,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAB50h ---------------------------------------------------------------------------------------------

7FFC86CBAB80h void xor<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xef, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBAB80h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpxor ymm0,ymm0,ymm1   ; opcode := VEX_Vpxor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,ef,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAB80h ---------------------------------------------------------------------------------------------

7FFC86CBABB0h void xor<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xef, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBABB0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpxor ymm0,ymm0,ymm1   ; opcode := VEX_Vpxor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,ef,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBABB0h ---------------------------------------------------------------------------------------------

7FFC86CBABE0h void xor<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xef, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBABE0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpxor ymm0,ymm0,ymm1   ; opcode := VEX_Vpxor_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,ef,c1} (4 bytes)
0011h  vmovdqu ymmword ptr [r8],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7e,7f,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBABE0h ---------------------------------------------------------------------------------------------

7FFC86CBAC10h void xor<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfc, 0x57, 0xc1, 0xc4, 0xc1, 0x7c, 0x11, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBAC10h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vxorps ymm0,ymm0,ymm1   ; opcode := VEX_Vxorps_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fc,57,c1} (4 bytes)
0011h  vmovups [r8],ymm0   ; opcode := VEX_Vmovups_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7c,11,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAC10h ---------------------------------------------------------------------------------------------

7FFC86CBAC40h void xor<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0x57, 0xc1, 0xc4, 0xc1, 0x7d, 0x11, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBAC40h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vxorpd ymm0,ymm0,ymm1   ; opcode := VEX_Vxorpd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,57,c1} (4 bytes)
0011h  vmovupd [r8],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c4,c1,7d,11,00} (5 bytes)
0016h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAC40h ---------------------------------------------------------------------------------------------

7FFC86CBAC70h Vec128<byte> add<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfc, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBAC70h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpaddb xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddb_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fc,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAC70h ---------------------------------------------------------------------------------------------

7FFC86CBACA0h Vec128<ushort> add<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfd, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBACA0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpaddw xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddw_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fd,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBACA0h ---------------------------------------------------------------------------------------------

7FFC86CBACD0h Vec128<uint> add<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfe, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBACD0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpaddd xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fe,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBACD0h ---------------------------------------------------------------------------------------------

7FFC86CBAD00h Vec128<ulong> add<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xd4, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBAD00h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpaddq xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddq_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,d4,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAD00h ---------------------------------------------------------------------------------------------

7FFC86CBAD30h Vec128<sbyte> add<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfc, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBAD30h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpaddb xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddb_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fc,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAD30h ---------------------------------------------------------------------------------------------

7FFC86CBAD60h Vec128<short> add<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfd, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBAD60h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpaddw xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddw_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fd,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAD60h ---------------------------------------------------------------------------------------------

7FFC86CBAD90h Vec128<int> add<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfe, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBAD90h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpaddd xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fe,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAD90h ---------------------------------------------------------------------------------------------

7FFC86CBADC0h Vec128<long> add<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xd4, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBADC0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpaddq xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddq_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,d4,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBADC0h ---------------------------------------------------------------------------------------------

7FFC86CBADF0h Vec128<float> add<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf8, 0x58, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBADF0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vaddps xmm0,xmm0,xmm1   ; opcode := VEX_Vaddps_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f8,58,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBADF0h ---------------------------------------------------------------------------------------------

7FFC86CBAE20h Vec128<double> add<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0x58, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBAE20h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vaddpd xmm0,xmm0,xmm1   ; opcode := VEX_Vaddpd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,58,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAE20h ---------------------------------------------------------------------------------------------

7FFC86CBAE50h Vec256<byte> add<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfc, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBAE50h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpaddb ymm0,ymm0,ymm1   ; opcode := VEX_Vpaddb_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fc,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAE50h ---------------------------------------------------------------------------------------------

7FFC86CBAE80h Vec256<ushort> add<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfd, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBAE80h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpaddw ymm0,ymm0,ymm1   ; opcode := VEX_Vpaddw_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fd,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAE80h ---------------------------------------------------------------------------------------------

7FFC86CBAEB0h Vec256<uint> add<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfe, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBAEB0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpaddd ymm0,ymm0,ymm1   ; opcode := VEX_Vpaddd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fe,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAEB0h ---------------------------------------------------------------------------------------------

7FFC86CBAEE0h Vec256<ulong> add<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xd4, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBAEE0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpaddq ymm0,ymm0,ymm1   ; opcode := VEX_Vpaddq_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,d4,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAEE0h ---------------------------------------------------------------------------------------------

7FFC86CBAF10h Vec256<sbyte> add<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfc, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBAF10h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpaddb ymm0,ymm0,ymm1   ; opcode := VEX_Vpaddb_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fc,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAF10h ---------------------------------------------------------------------------------------------

7FFC86CBAF40h Vec256<short> add<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfd, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBAF40h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpaddw ymm0,ymm0,ymm1   ; opcode := VEX_Vpaddw_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fd,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAF40h ---------------------------------------------------------------------------------------------

7FFC86CBAF70h Vec256<int> add<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfe, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBAF70h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpaddd ymm0,ymm0,ymm1   ; opcode := VEX_Vpaddd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fe,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAF70h ---------------------------------------------------------------------------------------------

7FFC86CBAFA0h Vec256<long> add<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xd4, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBAFA0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpaddq ymm0,ymm0,ymm1   ; opcode := VEX_Vpaddq_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,d4,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAFA0h ---------------------------------------------------------------------------------------------

7FFC86CBAFD0h Vec256<float> add<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfc, 0x58, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBAFD0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vaddps ymm0,ymm0,ymm1   ; opcode := VEX_Vaddps_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fc,58,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBAFD0h ---------------------------------------------------------------------------------------------

7FFC86CBB000h Vec256<double> add<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0x58, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBB000h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vaddpd ymm0,ymm0,ymm1   ; opcode := VEX_Vaddpd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,58,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB000h ---------------------------------------------------------------------------------------------

7FFC86CBB030h void add<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfc, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CBB030h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpaddb xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddb_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fc,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB030h ---------------------------------------------------------------------------------------------

7FFC86CBB470h void add<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfd, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CBB470h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpaddw xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddw_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fd,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB470h ---------------------------------------------------------------------------------------------

7FFC86CBB4A0h void add<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfe, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CBB4A0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpaddd xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fe,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB4A0h ---------------------------------------------------------------------------------------------

7FFC86CBB4D0h void add<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xd4, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CBB4D0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpaddq xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddq_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,d4,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB4D0h ---------------------------------------------------------------------------------------------

7FFC86CBB500h void add<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfc, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CBB500h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpaddb xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddb_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fc,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB500h ---------------------------------------------------------------------------------------------

7FFC86CBB530h void add<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfd, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CBB530h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpaddw xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddw_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fd,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB530h ---------------------------------------------------------------------------------------------

7FFC86CBB560h void add<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfe, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CBB560h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpaddd xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fe,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB560h ---------------------------------------------------------------------------------------------

7FFC86CBB590h void add<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xd4, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm-body-begin 7FFC86CBB590h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vpaddq xmm0,xmm0,xmm1   ; opcode := VEX_Vpaddq_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,d4,c1} (4 bytes)
0011h  vmovdqu xmmword ptr [r8],xmm0   ; opcode := VEX_Vmovdqu_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,7a,7f,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB590h ---------------------------------------------------------------------------------------------

7FFC86CBB5C0h void add<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf8, 0x58, 0xc1, 0xc4, 0xc1, 0x78, 0x11, 0x00, 0xc3}
asm-body-begin 7FFC86CBB5C0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vaddps xmm0,xmm0,xmm1   ; opcode := VEX_Vaddps_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f8,58,c1} (4 bytes)
0011h  vmovups [r8],xmm0   ; opcode := VEX_Vmovups_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,78,11,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB5C0h ---------------------------------------------------------------------------------------------

7FFC86CBB5F0h void add<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0x58, 0xc1, 0xc4, 0xc1, 0x79, 0x11, 0x00, 0xc3}
asm-body-begin 7FFC86CBB5F0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rcx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,01} (4 bytes)
0009h  vmovupd xmm1,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,0a} (4 bytes)
000dh  vaddpd xmm0,xmm0,xmm1   ; opcode := VEX_Vaddpd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,58,c1} (4 bytes)
0011h  vmovupd [r8],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c4,c1,79,11,00} (5 bytes)
0016h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB5F0h ---------------------------------------------------------------------------------------------

7FFC86CBB620h byref Byte add<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfc, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfe, 0x7f, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBB620h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpaddb ymm0,ymm0,ymm1   ; opcode := VEX_Vpaddb_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fc,c1} (4 bytes)
0011h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
0014h  vmovdqu ymmword ptr [rax],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c5,fe,7f,00} (4 bytes)
0018h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
001bh  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001eh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB620h ---------------------------------------------------------------------------------------------

7FFC86CBB660h byref UInt16 add<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfd, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfe, 0x7f, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBB660h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpaddw ymm0,ymm0,ymm1   ; opcode := VEX_Vpaddw_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fd,c1} (4 bytes)
0011h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
0014h  vmovdqu ymmword ptr [rax],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c5,fe,7f,00} (4 bytes)
0018h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
001bh  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001eh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB660h ---------------------------------------------------------------------------------------------

7FFC86CBB6A0h byref UInt32 add<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfe, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfe, 0x7f, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBB6A0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpaddd ymm0,ymm0,ymm1   ; opcode := VEX_Vpaddd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fe,c1} (4 bytes)
0011h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
0014h  vmovdqu ymmword ptr [rax],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c5,fe,7f,00} (4 bytes)
0018h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
001bh  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001eh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB6A0h ---------------------------------------------------------------------------------------------

7FFC86CBB6E0h byref UInt64 add<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xd4, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfe, 0x7f, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBB6E0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpaddq ymm0,ymm0,ymm1   ; opcode := VEX_Vpaddq_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,d4,c1} (4 bytes)
0011h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
0014h  vmovdqu ymmword ptr [rax],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c5,fe,7f,00} (4 bytes)
0018h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
001bh  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001eh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB6E0h ---------------------------------------------------------------------------------------------

7FFC86CBB720h byref SByte add<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfc, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfe, 0x7f, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBB720h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpaddb ymm0,ymm0,ymm1   ; opcode := VEX_Vpaddb_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fc,c1} (4 bytes)
0011h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
0014h  vmovdqu ymmword ptr [rax],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c5,fe,7f,00} (4 bytes)
0018h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
001bh  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001eh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB720h ---------------------------------------------------------------------------------------------

7FFC86CBB760h byref Int16 add<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfd, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfe, 0x7f, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBB760h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpaddw ymm0,ymm0,ymm1   ; opcode := VEX_Vpaddw_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fd,c1} (4 bytes)
0011h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
0014h  vmovdqu ymmword ptr [rax],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c5,fe,7f,00} (4 bytes)
0018h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
001bh  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001eh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB760h ---------------------------------------------------------------------------------------------

7FFC86CBB7A0h byref Int32 add<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfe, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfe, 0x7f, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBB7A0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpaddd ymm0,ymm0,ymm1   ; opcode := VEX_Vpaddd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fe,c1} (4 bytes)
0011h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
0014h  vmovdqu ymmword ptr [rax],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c5,fe,7f,00} (4 bytes)
0018h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
001bh  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001eh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB7A0h ---------------------------------------------------------------------------------------------

7FFC86CBB7E0h byref Int64 add<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xd4, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfe, 0x7f, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBB7E0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vpaddq ymm0,ymm0,ymm1   ; opcode := VEX_Vpaddq_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,d4,c1} (4 bytes)
0011h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
0014h  vmovdqu ymmword ptr [rax],ymm0   ; opcode := VEX_Vmovdqu_ymmm256_ymm (VEX encoded) | encoded := {c5,fe,7f,00} (4 bytes)
0018h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
001bh  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001eh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB7E0h ---------------------------------------------------------------------------------------------

7FFC86CBB820h byref Single add<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfc, 0x58, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfc, 0x11, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBB820h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vaddps ymm0,ymm0,ymm1   ; opcode := VEX_Vaddps_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fc,58,c1} (4 bytes)
0011h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
0014h  vmovups [rax],ymm0   ; opcode := VEX_Vmovups_ymmm256_ymm (VEX encoded) | encoded := {c5,fc,11,00} (4 bytes)
0018h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
001bh  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001eh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB820h ---------------------------------------------------------------------------------------------

7FFC86CBB860h byref Double add<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0x58, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfd, 0x11, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBB860h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rcx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,01} (4 bytes)
0009h  vmovupd ymm1,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,0a} (4 bytes)
000dh  vaddpd ymm0,ymm0,ymm1   ; opcode := VEX_Vaddpd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,58,c1} (4 bytes)
0011h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
0014h  vmovupd [rax],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,00} (4 bytes)
0018h  mov rax,r8   ; opcode := Mov_r64_rm64 | encoded := {49,8b,c0} (3 bytes)
001bh  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001eh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBB860h ---------------------------------------------------------------------------------------------

7FFC86CBB8A0h Num128<byte> add<byte>(byref Num128<byte> lhs, byref Num128<byte> rhs)
# encoding: {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8d, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x45, 0x2c, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x1b, 0x6d, 0x78, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x45, 0x2c, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x04, 0x6d, 0x78, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0x01, 0xce, 0x0c, 0x00, 0x48, 0x8b, 0xc8, 0xe8, 0xd1, 0x7f, 0x5e, 0x5f, 0xcc}
asm-body-begin 7FFC86CBB8A0h -------------------------------------------------------------------------------------------
0000h  push rdi   ; opcode := Push_r64 | encoded := {57} (1 bytes)
0001h  push rsi   ; opcode := Push_r64 | encoded := {56} (1 bytes)
0002h  push rbx   ; opcode := Push_r64 | encoded := {53} (1 bytes)
0003h  sub rsp,30h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,30} (4 bytes)
0007h  mov esi,8Dh   ; opcode := Mov_r32_imm32 | encoded := {be,8d,00,00,00} (5 bytes)
000ch  mov edi,1   ; opcode := Mov_r32_imm32 | encoded := {bf,01,00,00,00} (5 bytes)
0011h  mov ecx,2C45h   ; opcode := Mov_r32_imm32 | encoded := {b9,45,2c,00,00} (5 bytes)
0016h  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0020h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,1b,6d,78,5f} (5 bytes)
0025h  mov rbx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d8} (3 bytes)
0028h  mov ecx,2C45h   ; opcode := Mov_r32_imm32 | encoded := {b9,45,2c,00,00} (5 bytes)
002dh  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0037h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,04,6d,78,5f} (5 bytes)
003ch  mov rdx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d0} (3 bytes)
003fh  lea rcx,[rsp+28h]   ; opcode := Lea_r64_m | encoded := {48,8d,4c,24,28} (5 bytes)
0044h  mov [rcx],dil   ; opcode := Mov_rm8_r8 | encoded := {40,88,39} (3 bytes)
0047h  mov [rcx+4],esi   ; opcode := Mov_rm32_r32 | encoded := {89,71,04} (3 bytes)
004ah  mov rcx,rbx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,cb} (3 bytes)
004dh  mov r8,[rsp+28h]   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,44,24,28} (5 bytes)
0052h  call 7FFC86D886F8h   ; opcode := Call_rel32_64 | encoded := {e8,01,ce,0c,00} (5 bytes)
0057h  mov rcx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c8} (3 bytes)
005ah  call 7FFCE62A38D0h   ; opcode := Call_rel32_64 | encoded := {e8,d1,7f,5e,5f} (5 bytes)
005fh  int 3   ; opcode := Int3 | encoded := {cc} (1 bytes)
asm-body-end 7FFC86CBB8A0h ---------------------------------------------------------------------------------------------

7FFC86CBB920h Num128<ushort> add<ushort>(byref Num128<ushort> lhs, byref Num128<ushort> rhs)
# encoding: {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8d, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x45, 0x2c, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x9b, 0x6c, 0x78, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x45, 0x2c, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x84, 0x6c, 0x78, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0x01, 0xce, 0x0c, 0x00, 0x48, 0x8b, 0xc8, 0xe8, 0x51, 0x7f, 0x5e, 0x5f, 0xcc}
asm-body-begin 7FFC86CBB920h -------------------------------------------------------------------------------------------
0000h  push rdi   ; opcode := Push_r64 | encoded := {57} (1 bytes)
0001h  push rsi   ; opcode := Push_r64 | encoded := {56} (1 bytes)
0002h  push rbx   ; opcode := Push_r64 | encoded := {53} (1 bytes)
0003h  sub rsp,30h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,30} (4 bytes)
0007h  mov esi,8Dh   ; opcode := Mov_r32_imm32 | encoded := {be,8d,00,00,00} (5 bytes)
000ch  mov edi,1   ; opcode := Mov_r32_imm32 | encoded := {bf,01,00,00,00} (5 bytes)
0011h  mov ecx,2C45h   ; opcode := Mov_r32_imm32 | encoded := {b9,45,2c,00,00} (5 bytes)
0016h  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0020h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,9b,6c,78,5f} (5 bytes)
0025h  mov rbx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d8} (3 bytes)
0028h  mov ecx,2C45h   ; opcode := Mov_r32_imm32 | encoded := {b9,45,2c,00,00} (5 bytes)
002dh  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0037h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,84,6c,78,5f} (5 bytes)
003ch  mov rdx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d0} (3 bytes)
003fh  lea rcx,[rsp+28h]   ; opcode := Lea_r64_m | encoded := {48,8d,4c,24,28} (5 bytes)
0044h  mov [rcx],dil   ; opcode := Mov_rm8_r8 | encoded := {40,88,39} (3 bytes)
0047h  mov [rcx+4],esi   ; opcode := Mov_rm32_r32 | encoded := {89,71,04} (3 bytes)
004ah  mov rcx,rbx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,cb} (3 bytes)
004dh  mov r8,[rsp+28h]   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,44,24,28} (5 bytes)
0052h  call 7FFC86D88778h   ; opcode := Call_rel32_64 | encoded := {e8,01,ce,0c,00} (5 bytes)
0057h  mov rcx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c8} (3 bytes)
005ah  call 7FFCE62A38D0h   ; opcode := Call_rel32_64 | encoded := {e8,51,7f,5e,5f} (5 bytes)
005fh  int 3   ; opcode := Int3 | encoded := {cc} (1 bytes)
asm-body-end 7FFC86CBB920h ---------------------------------------------------------------------------------------------

7FFC86CBB9A0h Num128<uint> add<uint>(byref Num128<uint> lhs, byref Num128<uint> rhs)
# encoding: {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8d, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x45, 0x2c, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x1b, 0x6c, 0x78, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x45, 0x2c, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x04, 0x6c, 0x78, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0xf1, 0xcd, 0x0c, 0x00, 0x48, 0x8b, 0xc8, 0xe8, 0xd1, 0x7e, 0x5e, 0x5f, 0xcc}
asm-body-begin 7FFC86CBB9A0h -------------------------------------------------------------------------------------------
0000h  push rdi   ; opcode := Push_r64 | encoded := {57} (1 bytes)
0001h  push rsi   ; opcode := Push_r64 | encoded := {56} (1 bytes)
0002h  push rbx   ; opcode := Push_r64 | encoded := {53} (1 bytes)
0003h  sub rsp,30h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,30} (4 bytes)
0007h  mov esi,8Dh   ; opcode := Mov_r32_imm32 | encoded := {be,8d,00,00,00} (5 bytes)
000ch  mov edi,1   ; opcode := Mov_r32_imm32 | encoded := {bf,01,00,00,00} (5 bytes)
0011h  mov ecx,2C45h   ; opcode := Mov_r32_imm32 | encoded := {b9,45,2c,00,00} (5 bytes)
0016h  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0020h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,1b,6c,78,5f} (5 bytes)
0025h  mov rbx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d8} (3 bytes)
0028h  mov ecx,2C45h   ; opcode := Mov_r32_imm32 | encoded := {b9,45,2c,00,00} (5 bytes)
002dh  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0037h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,04,6c,78,5f} (5 bytes)
003ch  mov rdx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d0} (3 bytes)
003fh  lea rcx,[rsp+28h]   ; opcode := Lea_r64_m | encoded := {48,8d,4c,24,28} (5 bytes)
0044h  mov [rcx],dil   ; opcode := Mov_rm8_r8 | encoded := {40,88,39} (3 bytes)
0047h  mov [rcx+4],esi   ; opcode := Mov_rm32_r32 | encoded := {89,71,04} (3 bytes)
004ah  mov rcx,rbx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,cb} (3 bytes)
004dh  mov r8,[rsp+28h]   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,44,24,28} (5 bytes)
0052h  call 7FFC86D887E8h   ; opcode := Call_rel32_64 | encoded := {e8,f1,cd,0c,00} (5 bytes)
0057h  mov rcx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c8} (3 bytes)
005ah  call 7FFCE62A38D0h   ; opcode := Call_rel32_64 | encoded := {e8,d1,7e,5e,5f} (5 bytes)
005fh  int 3   ; opcode := Int3 | encoded := {cc} (1 bytes)
asm-body-end 7FFC86CBB9A0h ---------------------------------------------------------------------------------------------

7FFC86CBBA20h Num128<ulong> add<ulong>(byref Num128<ulong> lhs, byref Num128<ulong> rhs)
# encoding: {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8d, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x45, 0x2c, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x9b, 0x6b, 0x78, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x45, 0x2c, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x84, 0x6b, 0x78, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0xe1, 0xcd, 0x0c, 0x00, 0x48, 0x8b, 0xc8, 0xe8, 0x51, 0x7e, 0x5e, 0x5f, 0xcc}
asm-body-begin 7FFC86CBBA20h -------------------------------------------------------------------------------------------
0000h  push rdi   ; opcode := Push_r64 | encoded := {57} (1 bytes)
0001h  push rsi   ; opcode := Push_r64 | encoded := {56} (1 bytes)
0002h  push rbx   ; opcode := Push_r64 | encoded := {53} (1 bytes)
0003h  sub rsp,30h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,30} (4 bytes)
0007h  mov esi,8Dh   ; opcode := Mov_r32_imm32 | encoded := {be,8d,00,00,00} (5 bytes)
000ch  mov edi,1   ; opcode := Mov_r32_imm32 | encoded := {bf,01,00,00,00} (5 bytes)
0011h  mov ecx,2C45h   ; opcode := Mov_r32_imm32 | encoded := {b9,45,2c,00,00} (5 bytes)
0016h  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0020h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,9b,6b,78,5f} (5 bytes)
0025h  mov rbx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d8} (3 bytes)
0028h  mov ecx,2C45h   ; opcode := Mov_r32_imm32 | encoded := {b9,45,2c,00,00} (5 bytes)
002dh  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0037h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,84,6b,78,5f} (5 bytes)
003ch  mov rdx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d0} (3 bytes)
003fh  lea rcx,[rsp+28h]   ; opcode := Lea_r64_m | encoded := {48,8d,4c,24,28} (5 bytes)
0044h  mov [rcx],dil   ; opcode := Mov_rm8_r8 | encoded := {40,88,39} (3 bytes)
0047h  mov [rcx+4],esi   ; opcode := Mov_rm32_r32 | encoded := {89,71,04} (3 bytes)
004ah  mov rcx,rbx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,cb} (3 bytes)
004dh  mov r8,[rsp+28h]   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,44,24,28} (5 bytes)
0052h  call 7FFC86D88858h   ; opcode := Call_rel32_64 | encoded := {e8,e1,cd,0c,00} (5 bytes)
0057h  mov rcx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c8} (3 bytes)
005ah  call 7FFCE62A38D0h   ; opcode := Call_rel32_64 | encoded := {e8,51,7e,5e,5f} (5 bytes)
005fh  int 3   ; opcode := Int3 | encoded := {cc} (1 bytes)
asm-body-end 7FFC86CBBA20h ---------------------------------------------------------------------------------------------

7FFC86CBBAA0h Num128<sbyte> add<sbyte>(byref Num128<sbyte> lhs, byref Num128<sbyte> rhs)
# encoding: {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8d, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x45, 0x2c, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x1b, 0x6b, 0x78, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x45, 0x2c, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x04, 0x6b, 0x78, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0x71, 0xcd, 0x0c, 0x00, 0x48, 0x8b, 0xc8, 0xe8, 0xd1, 0x7d, 0x5e, 0x5f, 0xcc}
asm-body-begin 7FFC86CBBAA0h -------------------------------------------------------------------------------------------
0000h  push rdi   ; opcode := Push_r64 | encoded := {57} (1 bytes)
0001h  push rsi   ; opcode := Push_r64 | encoded := {56} (1 bytes)
0002h  push rbx   ; opcode := Push_r64 | encoded := {53} (1 bytes)
0003h  sub rsp,30h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,30} (4 bytes)
0007h  mov esi,8Dh   ; opcode := Mov_r32_imm32 | encoded := {be,8d,00,00,00} (5 bytes)
000ch  mov edi,1   ; opcode := Mov_r32_imm32 | encoded := {bf,01,00,00,00} (5 bytes)
0011h  mov ecx,2C45h   ; opcode := Mov_r32_imm32 | encoded := {b9,45,2c,00,00} (5 bytes)
0016h  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0020h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,1b,6b,78,5f} (5 bytes)
0025h  mov rbx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d8} (3 bytes)
0028h  mov ecx,2C45h   ; opcode := Mov_r32_imm32 | encoded := {b9,45,2c,00,00} (5 bytes)
002dh  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0037h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,04,6b,78,5f} (5 bytes)
003ch  mov rdx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d0} (3 bytes)
003fh  lea rcx,[rsp+28h]   ; opcode := Lea_r64_m | encoded := {48,8d,4c,24,28} (5 bytes)
0044h  mov [rcx],dil   ; opcode := Mov_rm8_r8 | encoded := {40,88,39} (3 bytes)
0047h  mov [rcx+4],esi   ; opcode := Mov_rm32_r32 | encoded := {89,71,04} (3 bytes)
004ah  mov rcx,rbx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,cb} (3 bytes)
004dh  mov r8,[rsp+28h]   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,44,24,28} (5 bytes)
0052h  call 7FFC86D88868h   ; opcode := Call_rel32_64 | encoded := {e8,71,cd,0c,00} (5 bytes)
0057h  mov rcx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c8} (3 bytes)
005ah  call 7FFCE62A38D0h   ; opcode := Call_rel32_64 | encoded := {e8,d1,7d,5e,5f} (5 bytes)
005fh  int 3   ; opcode := Int3 | encoded := {cc} (1 bytes)
asm-body-end 7FFC86CBBAA0h ---------------------------------------------------------------------------------------------

7FFC86CBBB20h Num128<short> add<short>(byref Num128<short> lhs, byref Num128<short> rhs)
# encoding: {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8d, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x45, 0x2c, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x9b, 0x6a, 0x78, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x45, 0x2c, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x84, 0x6a, 0x78, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0x01, 0xd0, 0x0c, 0x00, 0x48, 0x8b, 0xc8, 0xe8, 0x51, 0x7d, 0x5e, 0x5f, 0xcc}
asm-body-begin 7FFC86CBBB20h -------------------------------------------------------------------------------------------
0000h  push rdi   ; opcode := Push_r64 | encoded := {57} (1 bytes)
0001h  push rsi   ; opcode := Push_r64 | encoded := {56} (1 bytes)
0002h  push rbx   ; opcode := Push_r64 | encoded := {53} (1 bytes)
0003h  sub rsp,30h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,30} (4 bytes)
0007h  mov esi,8Dh   ; opcode := Mov_r32_imm32 | encoded := {be,8d,00,00,00} (5 bytes)
000ch  mov edi,1   ; opcode := Mov_r32_imm32 | encoded := {bf,01,00,00,00} (5 bytes)
0011h  mov ecx,2C45h   ; opcode := Mov_r32_imm32 | encoded := {b9,45,2c,00,00} (5 bytes)
0016h  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0020h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,9b,6a,78,5f} (5 bytes)
0025h  mov rbx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d8} (3 bytes)
0028h  mov ecx,2C45h   ; opcode := Mov_r32_imm32 | encoded := {b9,45,2c,00,00} (5 bytes)
002dh  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0037h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,84,6a,78,5f} (5 bytes)
003ch  mov rdx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d0} (3 bytes)
003fh  lea rcx,[rsp+28h]   ; opcode := Lea_r64_m | encoded := {48,8d,4c,24,28} (5 bytes)
0044h  mov [rcx],dil   ; opcode := Mov_rm8_r8 | encoded := {40,88,39} (3 bytes)
0047h  mov [rcx+4],esi   ; opcode := Mov_rm32_r32 | encoded := {89,71,04} (3 bytes)
004ah  mov rcx,rbx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,cb} (3 bytes)
004dh  mov r8,[rsp+28h]   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,44,24,28} (5 bytes)
0052h  call 7FFC86D88B78h   ; opcode := Call_rel32_64 | encoded := {e8,01,d0,0c,00} (5 bytes)
0057h  mov rcx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c8} (3 bytes)
005ah  call 7FFCE62A38D0h   ; opcode := Call_rel32_64 | encoded := {e8,51,7d,5e,5f} (5 bytes)
005fh  int 3   ; opcode := Int3 | encoded := {cc} (1 bytes)
asm-body-end 7FFC86CBBB20h ---------------------------------------------------------------------------------------------

7FFC86CBBBA0h Num128<int> add<int>(byref Num128<int> lhs, byref Num128<int> rhs)
# encoding: {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8d, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x45, 0x2c, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x1b, 0x6a, 0x78, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x45, 0x2c, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x04, 0x6a, 0x78, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0xf1, 0xcf, 0x0c, 0x00, 0x48, 0x8b, 0xc8, 0xe8, 0xd1, 0x7c, 0x5e, 0x5f, 0xcc}
asm-body-begin 7FFC86CBBBA0h -------------------------------------------------------------------------------------------
0000h  push rdi   ; opcode := Push_r64 | encoded := {57} (1 bytes)
0001h  push rsi   ; opcode := Push_r64 | encoded := {56} (1 bytes)
0002h  push rbx   ; opcode := Push_r64 | encoded := {53} (1 bytes)
0003h  sub rsp,30h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,30} (4 bytes)
0007h  mov esi,8Dh   ; opcode := Mov_r32_imm32 | encoded := {be,8d,00,00,00} (5 bytes)
000ch  mov edi,1   ; opcode := Mov_r32_imm32 | encoded := {bf,01,00,00,00} (5 bytes)
0011h  mov ecx,2C45h   ; opcode := Mov_r32_imm32 | encoded := {b9,45,2c,00,00} (5 bytes)
0016h  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0020h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,1b,6a,78,5f} (5 bytes)
0025h  mov rbx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d8} (3 bytes)
0028h  mov ecx,2C45h   ; opcode := Mov_r32_imm32 | encoded := {b9,45,2c,00,00} (5 bytes)
002dh  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0037h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,04,6a,78,5f} (5 bytes)
003ch  mov rdx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d0} (3 bytes)
003fh  lea rcx,[rsp+28h]   ; opcode := Lea_r64_m | encoded := {48,8d,4c,24,28} (5 bytes)
0044h  mov [rcx],dil   ; opcode := Mov_rm8_r8 | encoded := {40,88,39} (3 bytes)
0047h  mov [rcx+4],esi   ; opcode := Mov_rm32_r32 | encoded := {89,71,04} (3 bytes)
004ah  mov rcx,rbx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,cb} (3 bytes)
004dh  mov r8,[rsp+28h]   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,44,24,28} (5 bytes)
0052h  call 7FFC86D88BE8h   ; opcode := Call_rel32_64 | encoded := {e8,f1,cf,0c,00} (5 bytes)
0057h  mov rcx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c8} (3 bytes)
005ah  call 7FFCE62A38D0h   ; opcode := Call_rel32_64 | encoded := {e8,d1,7c,5e,5f} (5 bytes)
005fh  int 3   ; opcode := Int3 | encoded := {cc} (1 bytes)
asm-body-end 7FFC86CBBBA0h ---------------------------------------------------------------------------------------------

7FFC86CBBC20h Num128<long> add<long>(byref Num128<long> lhs, byref Num128<long> rhs)
# encoding: {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8d, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x45, 0x2c, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x9b, 0x69, 0x78, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x45, 0x2c, 0x00, 0x00, 0x48, 0xba, 0x58, 0x0c, 0x93, 0x86, 0xfc, 0x7f, 0x00, 0x00, 0xe8, 0x84, 0x69, 0x78, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0xe1, 0xcf, 0x0c, 0x00, 0x48, 0x8b, 0xc8, 0xe8, 0x51, 0x7c, 0x5e, 0x5f, 0xcc}
asm-body-begin 7FFC86CBBC20h -------------------------------------------------------------------------------------------
0000h  push rdi   ; opcode := Push_r64 | encoded := {57} (1 bytes)
0001h  push rsi   ; opcode := Push_r64 | encoded := {56} (1 bytes)
0002h  push rbx   ; opcode := Push_r64 | encoded := {53} (1 bytes)
0003h  sub rsp,30h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,30} (4 bytes)
0007h  mov esi,8Dh   ; opcode := Mov_r32_imm32 | encoded := {be,8d,00,00,00} (5 bytes)
000ch  mov edi,1   ; opcode := Mov_r32_imm32 | encoded := {bf,01,00,00,00} (5 bytes)
0011h  mov ecx,2C45h   ; opcode := Mov_r32_imm32 | encoded := {b9,45,2c,00,00} (5 bytes)
0016h  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0020h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,9b,69,78,5f} (5 bytes)
0025h  mov rbx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d8} (3 bytes)
0028h  mov ecx,2C45h   ; opcode := Mov_r32_imm32 | encoded := {b9,45,2c,00,00} (5 bytes)
002dh  mov rdx,7FFC86930C58h   ; opcode := Mov_r64_imm64 | encoded := {48,ba,58,0c,93,86,fc,7f,00,00} (10 bytes)
0037h  call 7FFCE64425E0h   ; opcode := Call_rel32_64 | encoded := {e8,84,69,78,5f} (5 bytes)
003ch  mov rdx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,d0} (3 bytes)
003fh  lea rcx,[rsp+28h]   ; opcode := Lea_r64_m | encoded := {48,8d,4c,24,28} (5 bytes)
0044h  mov [rcx],dil   ; opcode := Mov_rm8_r8 | encoded := {40,88,39} (3 bytes)
0047h  mov [rcx+4],esi   ; opcode := Mov_rm32_r32 | encoded := {89,71,04} (3 bytes)
004ah  mov rcx,rbx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,cb} (3 bytes)
004dh  mov r8,[rsp+28h]   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,44,24,28} (5 bytes)
0052h  call 7FFC86D88C58h   ; opcode := Call_rel32_64 | encoded := {e8,e1,cf,0c,00} (5 bytes)
0057h  mov rcx,rax   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c8} (3 bytes)
005ah  call 7FFCE62A38D0h   ; opcode := Call_rel32_64 | encoded := {e8,51,7c,5e,5f} (5 bytes)
005fh  int 3   ; opcode := Int3 | encoded := {cc} (1 bytes)
asm-body-end 7FFC86CBBC20h ---------------------------------------------------------------------------------------------

7FFC86CBBCA0h Num128<float> add<float>(byref Num128<float> lhs, byref Num128<float> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xfa, 0x58, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBBCA0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vaddss xmm0,xmm0,xmm1   ; opcode := VEX_Vaddss_xmm_xmm_xmmm32 (VEX encoded) | encoded := {c5,fa,58,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBBCA0h ---------------------------------------------------------------------------------------------

7FFC86CBBCD0h Num128<double> add<double>(byref Num128<double> lhs, byref Num128<double> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xfb, 0x58, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBBCD0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vaddsd xmm0,xmm0,xmm1   ; opcode := VEX_Vaddsd_xmm_xmm_xmmm64 (VEX encoded) | encoded := {c5,fb,58,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBBCD0h ---------------------------------------------------------------------------------------------

7FFC86CBBD00h Vec128<byte> sub<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xf8, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBBD00h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpsubb xmm0,xmm0,xmm1   ; opcode := VEX_Vpsubb_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,f8,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBBD00h ---------------------------------------------------------------------------------------------

7FFC86CBBD30h Vec128<ushort> sub<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xf9, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBBD30h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpsubw xmm0,xmm0,xmm1   ; opcode := VEX_Vpsubw_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,f9,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBBD30h ---------------------------------------------------------------------------------------------

7FFC86CBBD60h Vec128<uint> sub<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfa, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBBD60h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpsubd xmm0,xmm0,xmm1   ; opcode := VEX_Vpsubd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fa,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBBD60h ---------------------------------------------------------------------------------------------

7FFC86CBC1A0h Vec128<ulong> sub<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBC1A0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpsubq xmm0,xmm0,xmm1   ; opcode := VEX_Vpsubq_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fb,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBC1A0h ---------------------------------------------------------------------------------------------

7FFC86CBC1D0h Vec128<sbyte> sub<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xf8, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBC1D0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpsubb xmm0,xmm0,xmm1   ; opcode := VEX_Vpsubb_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,f8,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBC1D0h ---------------------------------------------------------------------------------------------

7FFC86CBC200h Vec128<short> sub<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xf9, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBC200h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpsubw xmm0,xmm0,xmm1   ; opcode := VEX_Vpsubw_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,f9,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBC200h ---------------------------------------------------------------------------------------------

7FFC86CBC230h Vec128<int> sub<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfa, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBC230h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpsubd xmm0,xmm0,xmm1   ; opcode := VEX_Vpsubd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fa,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBC230h ---------------------------------------------------------------------------------------------

7FFC86CBC260h Vec128<long> sub<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBC260h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vpsubq xmm0,xmm0,xmm1   ; opcode := VEX_Vpsubq_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,fb,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBC260h ---------------------------------------------------------------------------------------------

7FFC86CBC290h Vec128<float> sub<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf8, 0x5c, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBC290h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vsubps xmm0,xmm0,xmm1   ; opcode := VEX_Vsubps_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f8,5c,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBC290h ---------------------------------------------------------------------------------------------

7FFC86CBC2C0h Vec128<double> sub<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0x5c, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
asm-body-begin 7FFC86CBC2C0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd xmm0,[rdx]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,10,02} (4 bytes)
0009h  vmovupd xmm1,[r8]   ; opcode := VEX_Vmovupd_xmm_xmmm128 (VEX encoded) | encoded := {c4,c1,79,10,08} (5 bytes)
000eh  vsubpd xmm0,xmm0,xmm1   ; opcode := VEX_Vsubpd_xmm_xmm_xmmm128 (VEX encoded) | encoded := {c5,f9,5c,c1} (4 bytes)
0012h  vmovupd [rcx],xmm0   ; opcode := VEX_Vmovupd_xmmm128_xmm (VEX encoded) | encoded := {c5,f9,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBC2C0h ---------------------------------------------------------------------------------------------

7FFC86CBC2F0h Vec256<byte> sub<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xf8, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBC2F0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpsubb ymm0,ymm0,ymm1   ; opcode := VEX_Vpsubb_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,f8,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBC2F0h ---------------------------------------------------------------------------------------------

7FFC86CBC320h Vec256<ushort> sub<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xf9, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBC320h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpsubw ymm0,ymm0,ymm1   ; opcode := VEX_Vpsubw_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,f9,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBC320h ---------------------------------------------------------------------------------------------

7FFC86CBC350h Vec256<uint> sub<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfa, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBC350h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpsubd ymm0,ymm0,ymm1   ; opcode := VEX_Vpsubd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fa,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBC350h ---------------------------------------------------------------------------------------------

7FFC86CBC380h Vec256<ulong> sub<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBC380h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpsubq ymm0,ymm0,ymm1   ; opcode := VEX_Vpsubq_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fb,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBC380h ---------------------------------------------------------------------------------------------

7FFC86CBC3B0h Vec256<sbyte> sub<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xf8, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBC3B0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpsubb ymm0,ymm0,ymm1   ; opcode := VEX_Vpsubb_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,f8,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBC3B0h ---------------------------------------------------------------------------------------------

7FFC86CBC3E0h Vec256<short> sub<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xf9, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBC3E0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpsubw ymm0,ymm0,ymm1   ; opcode := VEX_Vpsubw_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,f9,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBC3E0h ---------------------------------------------------------------------------------------------

7FFC86CBC410h Vec256<int> sub<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfa, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBC410h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpsubd ymm0,ymm0,ymm1   ; opcode := VEX_Vpsubd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fa,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBC410h ---------------------------------------------------------------------------------------------

7FFC86CBC440h Vec256<long> sub<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBC440h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vpsubq ymm0,ymm0,ymm1   ; opcode := VEX_Vpsubq_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,fb,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBC440h ---------------------------------------------------------------------------------------------

7FFC86CBC470h Vec256<float> sub<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfc, 0x5c, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBC470h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vsubps ymm0,ymm0,ymm1   ; opcode := VEX_Vsubps_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fc,5c,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBC470h ---------------------------------------------------------------------------------------------

7FFC86CBC4A0h Vec256<double> sub<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0x5c, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
asm-body-begin 7FFC86CBC4A0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmovupd ymm0,[rdx]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,10,02} (4 bytes)
0009h  vmovupd ymm1,[r8]   ; opcode := VEX_Vmovupd_ymm_ymmm256 (VEX encoded) | encoded := {c4,c1,7d,10,08} (5 bytes)
000eh  vsubpd ymm0,ymm0,ymm1   ; opcode := VEX_Vsubpd_ymm_ymm_ymmm256 (VEX encoded) | encoded := {c5,fd,5c,c1} (4 bytes)
0012h  vmovupd [rcx],ymm0   ; opcode := VEX_Vmovupd_ymmm256_ymm (VEX encoded) | encoded := {c5,fd,11,01} (4 bytes)
0016h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0019h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
001ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CBC4A0h ---------------------------------------------------------------------------------------------

