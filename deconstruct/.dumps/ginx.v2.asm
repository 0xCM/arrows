# 2019-07-27 04:33:02:964
void sub<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,f8,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpsubb xmm0,xmm0,xmm1         ; Vpsubb | VEX_Vpsubb_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 f8 c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,f9,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpsubw xmm0,xmm0,xmm1         ; Vpsubw | VEX_Vpsubw_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 f9 c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,fa,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpsubd xmm0,xmm0,xmm1         ; Vpsubd | VEX_Vpsubd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fa c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,fb,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpsubq xmm0,xmm0,xmm1         ; Vpsubq | VEX_Vpsubq_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fb c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,f8,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpsubb xmm0,xmm0,xmm1         ; Vpsubb | VEX_Vpsubb_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 f8 c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,f9,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpsubw xmm0,xmm0,xmm1         ; Vpsubw | VEX_Vpsubw_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 f9 c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,fa,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpsubd xmm0,xmm0,xmm1         ; Vpsubd | VEX_Vpsubd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fa c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,fb,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpsubq xmm0,xmm0,xmm1         ; Vpsubq | VEX_Vpsubq_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fb c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f8,5c,c1,c4,c1,78,11,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vsubps xmm0,xmm0,xmm1         ; Vsubps | VEX_Vsubps_xmm_xmm_xmmm128 | encoding(VEX) = c5 f8 5c c1 (4 bytes)
0011h vmovups [r8],xmm0             ; Vmovups | VEX_Vmovups_xmmm128_xmm | encoding(VEX) = c4 c1 78 11 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,5c,c1,c4,c1,79,11,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vsubpd xmm0,xmm0,xmm1         ; Vsubpd | VEX_Vsubpd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 5c c1 (4 bytes)
0011h vmovupd [r8],xmm0             ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c4 c1 79 11 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,f8,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpsubb ymm0,ymm0,ymm1         ; Vpsubb | VEX_Vpsubb_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd f8 c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,f9,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpsubw ymm0,ymm0,ymm1         ; Vpsubw | VEX_Vpsubw_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd f9 c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,fa,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpsubd ymm0,ymm0,ymm1         ; Vpsubd | VEX_Vpsubd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fa c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,fb,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpsubq ymm0,ymm0,ymm1         ; Vpsubq | VEX_Vpsubq_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fb c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,f8,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpsubb ymm0,ymm0,ymm1         ; Vpsubb | VEX_Vpsubb_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd f8 c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,f9,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpsubw ymm0,ymm0,ymm1         ; Vpsubw | VEX_Vpsubw_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd f9 c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,fa,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpsubd ymm0,ymm0,ymm1         ; Vpsubd | VEX_Vpsubd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fa c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,fb,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpsubq ymm0,ymm0,ymm1         ; Vpsubq | VEX_Vpsubq_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fb c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fc,5c,c1,c4,c1,7c,11,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vsubps ymm0,ymm0,ymm1         ; Vsubps | VEX_Vsubps_ymm_ymm_ymmm256 | encoding(VEX) = c5 fc 5c c1 (4 bytes)
0011h vmovups [r8],ymm0             ; Vmovups | VEX_Vmovups_ymmm256_ymm | encoding(VEX) = c4 c1 7c 11 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void sub<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,5c,c1,c4,c1,7d,11,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vsubpd ymm0,ymm0,ymm1         ; Vsubpd | VEX_Vsubpd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd 5c c1 (4 bytes)
0011h vmovupd [r8],ymm0             ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c4 c1 7d 11 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<byte> sub<byte>(byref Num128<byte> lhs, byref Num128<byte> rhs); {57,56,53,48,83,ec,30,be,8a,00,00,00,bf,01,00,00,00,b9,23,2e,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,fb,9c,6b,5f,48,8b,d8,b9,23,2e,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,e4,9c,6b,5f,48,8b,d0,48,8d,4c,24,28,40,88,39,89,71,04,48,8b,cb,4c,8b,44,24,28,e8,e1,fd,ff,ff,48,8b,c8,e8,b1,af,51,5f,cc}
0000h push rdi                      ; Push | Push_r64 | encoding() = 57 (1 bytes)
0001h push rsi                      ; Push | Push_r64 | encoding() = 56 (1 bytes)
0002h push rbx                      ; Push | Push_r64 | encoding() = 53 (1 bytes)
0003h sub rsp,30h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 30 (4 bytes)
0007h mov esi,8Ah                   ; Mov | Mov_r32_imm32 | encoding() = be 8a 00 00 00 (5 bytes)
000ch mov edi,1                     ; Mov | Mov_r32_imm32 | encoding() = bf 01 00 00 00 (5 bytes)
0011h mov ecx,2E23h                 ; Mov | Mov_r32_imm32 | encoding() = b9 23 2e 00 00 (5 bytes)
0016h mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0020h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 fb 9c 6b 5f (5 bytes)
0025h mov rbx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d8 (3 bytes)
0028h mov ecx,2E23h                 ; Mov | Mov_r32_imm32 | encoding() = b9 23 2e 00 00 (5 bytes)
002dh mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0037h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 e4 9c 6b 5f (5 bytes)
003ch mov rdx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d0 (3 bytes)
003fh lea rcx,[rsp+28h]             ; Lea | Lea_r64_m | encoding() = 48 8d 4c 24 28 (5 bytes)
0044h mov [rcx],dil                 ; Mov | Mov_rm8_r8 | encoding() = 40 88 39 (3 bytes)
0047h mov [rcx+4],esi               ; Mov | Mov_rm32_r32 | encoding() = 89 71 04 (3 bytes)
004ah mov rcx,rbx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b cb (3 bytes)
004dh mov r8,[rsp+28h]              ; Mov | Mov_r64_rm64 | encoding() = 4c 8b 44 24 28 (5 bytes)
0052h call 7FFC86D886F8h            ; Call | Call_rel32_64 | encoding() = e8 e1 fd ff ff (5 bytes)
0057h mov rcx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c8 (3 bytes)
005ah call 7FFCE62A38D0h            ; Call | Call_rel32_64 | encoding() = e8 b1 af 51 5f (5 bytes)
005fh int 3                         ; Int | Int3 | encoding() = cc (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<ushort> sub<ushort>(byref Num128<ushort> lhs, byref Num128<ushort> rhs); {57,56,53,48,83,ec,30,be,8a,00,00,00,bf,01,00,00,00,b9,23,2e,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,7b,9c,6b,5f,48,8b,d8,b9,23,2e,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,64,9c,6b,5f,48,8b,d0,48,8d,4c,24,28,40,88,39,89,71,04,48,8b,cb,4c,8b,44,24,28,e8,e1,fd,ff,ff,48,8b,c8,e8,31,af,51,5f,cc}
0000h push rdi                      ; Push | Push_r64 | encoding() = 57 (1 bytes)
0001h push rsi                      ; Push | Push_r64 | encoding() = 56 (1 bytes)
0002h push rbx                      ; Push | Push_r64 | encoding() = 53 (1 bytes)
0003h sub rsp,30h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 30 (4 bytes)
0007h mov esi,8Ah                   ; Mov | Mov_r32_imm32 | encoding() = be 8a 00 00 00 (5 bytes)
000ch mov edi,1                     ; Mov | Mov_r32_imm32 | encoding() = bf 01 00 00 00 (5 bytes)
0011h mov ecx,2E23h                 ; Mov | Mov_r32_imm32 | encoding() = b9 23 2e 00 00 (5 bytes)
0016h mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0020h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 7b 9c 6b 5f (5 bytes)
0025h mov rbx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d8 (3 bytes)
0028h mov ecx,2E23h                 ; Mov | Mov_r32_imm32 | encoding() = b9 23 2e 00 00 (5 bytes)
002dh mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0037h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 64 9c 6b 5f (5 bytes)
003ch mov rdx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d0 (3 bytes)
003fh lea rcx,[rsp+28h]             ; Lea | Lea_r64_m | encoding() = 48 8d 4c 24 28 (5 bytes)
0044h mov [rcx],dil                 ; Mov | Mov_rm8_r8 | encoding() = 40 88 39 (3 bytes)
0047h mov [rcx+4],esi               ; Mov | Mov_rm32_r32 | encoding() = 89 71 04 (3 bytes)
004ah mov rcx,rbx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b cb (3 bytes)
004dh mov r8,[rsp+28h]              ; Mov | Mov_r64_rm64 | encoding() = 4c 8b 44 24 28 (5 bytes)
0052h call 7FFC86D88778h            ; Call | Call_rel32_64 | encoding() = e8 e1 fd ff ff (5 bytes)
0057h mov rcx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c8 (3 bytes)
005ah call 7FFCE62A38D0h            ; Call | Call_rel32_64 | encoding() = e8 31 af 51 5f (5 bytes)
005fh int 3                         ; Int | Int3 | encoding() = cc (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<uint> sub<uint>(byref Num128<uint> lhs, byref Num128<uint> rhs); {57,56,53,48,83,ec,30,be,8a,00,00,00,bf,01,00,00,00,b9,23,2e,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,fb,9b,6b,5f,48,8b,d8,b9,23,2e,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,e4,9b,6b,5f,48,8b,d0,48,8d,4c,24,28,40,88,39,89,71,04,48,8b,cb,4c,8b,44,24,28,e8,d1,fd,ff,ff,48,8b,c8,e8,b1,ae,51,5f,cc}
0000h push rdi                      ; Push | Push_r64 | encoding() = 57 (1 bytes)
0001h push rsi                      ; Push | Push_r64 | encoding() = 56 (1 bytes)
0002h push rbx                      ; Push | Push_r64 | encoding() = 53 (1 bytes)
0003h sub rsp,30h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 30 (4 bytes)
0007h mov esi,8Ah                   ; Mov | Mov_r32_imm32 | encoding() = be 8a 00 00 00 (5 bytes)
000ch mov edi,1                     ; Mov | Mov_r32_imm32 | encoding() = bf 01 00 00 00 (5 bytes)
0011h mov ecx,2E23h                 ; Mov | Mov_r32_imm32 | encoding() = b9 23 2e 00 00 (5 bytes)
0016h mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0020h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 fb 9b 6b 5f (5 bytes)
0025h mov rbx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d8 (3 bytes)
0028h mov ecx,2E23h                 ; Mov | Mov_r32_imm32 | encoding() = b9 23 2e 00 00 (5 bytes)
002dh mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0037h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 e4 9b 6b 5f (5 bytes)
003ch mov rdx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d0 (3 bytes)
003fh lea rcx,[rsp+28h]             ; Lea | Lea_r64_m | encoding() = 48 8d 4c 24 28 (5 bytes)
0044h mov [rcx],dil                 ; Mov | Mov_rm8_r8 | encoding() = 40 88 39 (3 bytes)
0047h mov [rcx+4],esi               ; Mov | Mov_rm32_r32 | encoding() = 89 71 04 (3 bytes)
004ah mov rcx,rbx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b cb (3 bytes)
004dh mov r8,[rsp+28h]              ; Mov | Mov_r64_rm64 | encoding() = 4c 8b 44 24 28 (5 bytes)
0052h call 7FFC86D887E8h            ; Call | Call_rel32_64 | encoding() = e8 d1 fd ff ff (5 bytes)
0057h mov rcx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c8 (3 bytes)
005ah call 7FFCE62A38D0h            ; Call | Call_rel32_64 | encoding() = e8 b1 ae 51 5f (5 bytes)
005fh int 3                         ; Int | Int3 | encoding() = cc (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<ulong> sub<ulong>(byref Num128<ulong> lhs, byref Num128<ulong> rhs); {57,56,53,48,83,ec,30,be,8a,00,00,00,bf,01,00,00,00,b9,23,2e,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,7b,9b,6b,5f,48,8b,d8,b9,23,2e,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,64,9b,6b,5f,48,8b,d0,48,8d,4c,24,28,40,88,39,89,71,04,48,8b,cb,4c,8b,44,24,28,e8,c1,fd,ff,ff,48,8b,c8,e8,31,ae,51,5f,cc}
0000h push rdi                      ; Push | Push_r64 | encoding() = 57 (1 bytes)
0001h push rsi                      ; Push | Push_r64 | encoding() = 56 (1 bytes)
0002h push rbx                      ; Push | Push_r64 | encoding() = 53 (1 bytes)
0003h sub rsp,30h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 30 (4 bytes)
0007h mov esi,8Ah                   ; Mov | Mov_r32_imm32 | encoding() = be 8a 00 00 00 (5 bytes)
000ch mov edi,1                     ; Mov | Mov_r32_imm32 | encoding() = bf 01 00 00 00 (5 bytes)
0011h mov ecx,2E23h                 ; Mov | Mov_r32_imm32 | encoding() = b9 23 2e 00 00 (5 bytes)
0016h mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0020h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 7b 9b 6b 5f (5 bytes)
0025h mov rbx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d8 (3 bytes)
0028h mov ecx,2E23h                 ; Mov | Mov_r32_imm32 | encoding() = b9 23 2e 00 00 (5 bytes)
002dh mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0037h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 64 9b 6b 5f (5 bytes)
003ch mov rdx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d0 (3 bytes)
003fh lea rcx,[rsp+28h]             ; Lea | Lea_r64_m | encoding() = 48 8d 4c 24 28 (5 bytes)
0044h mov [rcx],dil                 ; Mov | Mov_rm8_r8 | encoding() = 40 88 39 (3 bytes)
0047h mov [rcx+4],esi               ; Mov | Mov_rm32_r32 | encoding() = 89 71 04 (3 bytes)
004ah mov rcx,rbx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b cb (3 bytes)
004dh mov r8,[rsp+28h]              ; Mov | Mov_r64_rm64 | encoding() = 4c 8b 44 24 28 (5 bytes)
0052h call 7FFC86D88858h            ; Call | Call_rel32_64 | encoding() = e8 c1 fd ff ff (5 bytes)
0057h mov rcx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c8 (3 bytes)
005ah call 7FFCE62A38D0h            ; Call | Call_rel32_64 | encoding() = e8 31 ae 51 5f (5 bytes)
005fh int 3                         ; Int | Int3 | encoding() = cc (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<sbyte> sub<sbyte>(byref Num128<sbyte> lhs, byref Num128<sbyte> rhs); {57,56,53,48,83,ec,30,be,8a,00,00,00,bf,01,00,00,00,b9,23,2e,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,fb,96,6b,5f,48,8b,d8,b9,23,2e,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,e4,96,6b,5f,48,8b,d0,48,8d,4c,24,28,40,88,39,89,71,04,48,8b,cb,4c,8b,44,24,28,e8,51,f9,ff,ff,48,8b,c8,e8,b1,a9,51,5f,cc}
0000h push rdi                      ; Push | Push_r64 | encoding() = 57 (1 bytes)
0001h push rsi                      ; Push | Push_r64 | encoding() = 56 (1 bytes)
0002h push rbx                      ; Push | Push_r64 | encoding() = 53 (1 bytes)
0003h sub rsp,30h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 30 (4 bytes)
0007h mov esi,8Ah                   ; Mov | Mov_r32_imm32 | encoding() = be 8a 00 00 00 (5 bytes)
000ch mov edi,1                     ; Mov | Mov_r32_imm32 | encoding() = bf 01 00 00 00 (5 bytes)
0011h mov ecx,2E23h                 ; Mov | Mov_r32_imm32 | encoding() = b9 23 2e 00 00 (5 bytes)
0016h mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0020h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 fb 96 6b 5f (5 bytes)
0025h mov rbx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d8 (3 bytes)
0028h mov ecx,2E23h                 ; Mov | Mov_r32_imm32 | encoding() = b9 23 2e 00 00 (5 bytes)
002dh mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0037h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 e4 96 6b 5f (5 bytes)
003ch mov rdx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d0 (3 bytes)
003fh lea rcx,[rsp+28h]             ; Lea | Lea_r64_m | encoding() = 48 8d 4c 24 28 (5 bytes)
0044h mov [rcx],dil                 ; Mov | Mov_rm8_r8 | encoding() = 40 88 39 (3 bytes)
0047h mov [rcx+4],esi               ; Mov | Mov_rm32_r32 | encoding() = 89 71 04 (3 bytes)
004ah mov rcx,rbx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b cb (3 bytes)
004dh mov r8,[rsp+28h]              ; Mov | Mov_r64_rm64 | encoding() = 4c 8b 44 24 28 (5 bytes)
0052h call 7FFC86D88868h            ; Call | Call_rel32_64 | encoding() = e8 51 f9 ff ff (5 bytes)
0057h mov rcx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c8 (3 bytes)
005ah call 7FFCE62A38D0h            ; Call | Call_rel32_64 | encoding() = e8 b1 a9 51 5f (5 bytes)
005fh int 3                         ; Int | Int3 | encoding() = cc (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<short> sub<short>(byref Num128<short> lhs, byref Num128<short> rhs); {57,56,53,48,83,ec,30,be,8a,00,00,00,bf,01,00,00,00,b9,23,2e,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,7b,96,6b,5f,48,8b,d8,b9,23,2e,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,64,96,6b,5f,48,8b,d0,48,8d,4c,24,28,40,88,39,89,71,04,48,8b,cb,4c,8b,44,24,28,e8,e1,fb,ff,ff,48,8b,c8,e8,31,a9,51,5f,cc}
0000h push rdi                      ; Push | Push_r64 | encoding() = 57 (1 bytes)
0001h push rsi                      ; Push | Push_r64 | encoding() = 56 (1 bytes)
0002h push rbx                      ; Push | Push_r64 | encoding() = 53 (1 bytes)
0003h sub rsp,30h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 30 (4 bytes)
0007h mov esi,8Ah                   ; Mov | Mov_r32_imm32 | encoding() = be 8a 00 00 00 (5 bytes)
000ch mov edi,1                     ; Mov | Mov_r32_imm32 | encoding() = bf 01 00 00 00 (5 bytes)
0011h mov ecx,2E23h                 ; Mov | Mov_r32_imm32 | encoding() = b9 23 2e 00 00 (5 bytes)
0016h mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0020h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 7b 96 6b 5f (5 bytes)
0025h mov rbx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d8 (3 bytes)
0028h mov ecx,2E23h                 ; Mov | Mov_r32_imm32 | encoding() = b9 23 2e 00 00 (5 bytes)
002dh mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0037h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 64 96 6b 5f (5 bytes)
003ch mov rdx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d0 (3 bytes)
003fh lea rcx,[rsp+28h]             ; Lea | Lea_r64_m | encoding() = 48 8d 4c 24 28 (5 bytes)
0044h mov [rcx],dil                 ; Mov | Mov_rm8_r8 | encoding() = 40 88 39 (3 bytes)
0047h mov [rcx+4],esi               ; Mov | Mov_rm32_r32 | encoding() = 89 71 04 (3 bytes)
004ah mov rcx,rbx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b cb (3 bytes)
004dh mov r8,[rsp+28h]              ; Mov | Mov_r64_rm64 | encoding() = 4c 8b 44 24 28 (5 bytes)
0052h call 7FFC86D88B78h            ; Call | Call_rel32_64 | encoding() = e8 e1 fb ff ff (5 bytes)
0057h mov rcx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c8 (3 bytes)
005ah call 7FFCE62A38D0h            ; Call | Call_rel32_64 | encoding() = e8 31 a9 51 5f (5 bytes)
005fh int 3                         ; Int | Int3 | encoding() = cc (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<int> sub<int>(byref Num128<int> lhs, byref Num128<int> rhs); {57,56,53,48,83,ec,30,be,8a,00,00,00,bf,01,00,00,00,b9,23,2e,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,fb,95,6b,5f,48,8b,d8,b9,23,2e,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,e4,95,6b,5f,48,8b,d0,48,8d,4c,24,28,40,88,39,89,71,04,48,8b,cb,4c,8b,44,24,28,e8,d1,fb,ff,ff,48,8b,c8,e8,b1,a8,51,5f,cc}
0000h push rdi                      ; Push | Push_r64 | encoding() = 57 (1 bytes)
0001h push rsi                      ; Push | Push_r64 | encoding() = 56 (1 bytes)
0002h push rbx                      ; Push | Push_r64 | encoding() = 53 (1 bytes)
0003h sub rsp,30h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 30 (4 bytes)
0007h mov esi,8Ah                   ; Mov | Mov_r32_imm32 | encoding() = be 8a 00 00 00 (5 bytes)
000ch mov edi,1                     ; Mov | Mov_r32_imm32 | encoding() = bf 01 00 00 00 (5 bytes)
0011h mov ecx,2E23h                 ; Mov | Mov_r32_imm32 | encoding() = b9 23 2e 00 00 (5 bytes)
0016h mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0020h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 fb 95 6b 5f (5 bytes)
0025h mov rbx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d8 (3 bytes)
0028h mov ecx,2E23h                 ; Mov | Mov_r32_imm32 | encoding() = b9 23 2e 00 00 (5 bytes)
002dh mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0037h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 e4 95 6b 5f (5 bytes)
003ch mov rdx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d0 (3 bytes)
003fh lea rcx,[rsp+28h]             ; Lea | Lea_r64_m | encoding() = 48 8d 4c 24 28 (5 bytes)
0044h mov [rcx],dil                 ; Mov | Mov_rm8_r8 | encoding() = 40 88 39 (3 bytes)
0047h mov [rcx+4],esi               ; Mov | Mov_rm32_r32 | encoding() = 89 71 04 (3 bytes)
004ah mov rcx,rbx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b cb (3 bytes)
004dh mov r8,[rsp+28h]              ; Mov | Mov_r64_rm64 | encoding() = 4c 8b 44 24 28 (5 bytes)
0052h call 7FFC86D88BE8h            ; Call | Call_rel32_64 | encoding() = e8 d1 fb ff ff (5 bytes)
0057h mov rcx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c8 (3 bytes)
005ah call 7FFCE62A38D0h            ; Call | Call_rel32_64 | encoding() = e8 b1 a8 51 5f (5 bytes)
005fh int 3                         ; Int | Int3 | encoding() = cc (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<long> sub<long>(byref Num128<long> lhs, byref Num128<long> rhs); {57,56,53,48,83,ec,30,be,8a,00,00,00,bf,01,00,00,00,b9,23,2e,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,7b,95,6b,5f,48,8b,d8,b9,23,2e,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,64,95,6b,5f,48,8b,d0,48,8d,4c,24,28,40,88,39,89,71,04,48,8b,cb,4c,8b,44,24,28,e8,c1,fb,ff,ff,48,8b,c8,e8,31,a8,51,5f,cc}
0000h push rdi                      ; Push | Push_r64 | encoding() = 57 (1 bytes)
0001h push rsi                      ; Push | Push_r64 | encoding() = 56 (1 bytes)
0002h push rbx                      ; Push | Push_r64 | encoding() = 53 (1 bytes)
0003h sub rsp,30h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 30 (4 bytes)
0007h mov esi,8Ah                   ; Mov | Mov_r32_imm32 | encoding() = be 8a 00 00 00 (5 bytes)
000ch mov edi,1                     ; Mov | Mov_r32_imm32 | encoding() = bf 01 00 00 00 (5 bytes)
0011h mov ecx,2E23h                 ; Mov | Mov_r32_imm32 | encoding() = b9 23 2e 00 00 (5 bytes)
0016h mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0020h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 7b 95 6b 5f (5 bytes)
0025h mov rbx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d8 (3 bytes)
0028h mov ecx,2E23h                 ; Mov | Mov_r32_imm32 | encoding() = b9 23 2e 00 00 (5 bytes)
002dh mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0037h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 64 95 6b 5f (5 bytes)
003ch mov rdx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d0 (3 bytes)
003fh lea rcx,[rsp+28h]             ; Lea | Lea_r64_m | encoding() = 48 8d 4c 24 28 (5 bytes)
0044h mov [rcx],dil                 ; Mov | Mov_rm8_r8 | encoding() = 40 88 39 (3 bytes)
0047h mov [rcx+4],esi               ; Mov | Mov_rm32_r32 | encoding() = 89 71 04 (3 bytes)
004ah mov rcx,rbx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b cb (3 bytes)
004dh mov r8,[rsp+28h]              ; Mov | Mov_r64_rm64 | encoding() = 4c 8b 44 24 28 (5 bytes)
0052h call 7FFC86D88C58h            ; Call | Call_rel32_64 | encoding() = e8 c1 fb ff ff (5 bytes)
0057h mov rcx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c8 (3 bytes)
005ah call 7FFCE62A38D0h            ; Call | Call_rel32_64 | encoding() = e8 31 a8 51 5f (5 bytes)
005fh int 3                         ; Int | Int3 | encoding() = cc (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<float> sub<float>(byref Num128<float> lhs, byref Num128<float> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,fa,5c,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vsubss xmm0,xmm0,xmm1         ; Vsubss | VEX_Vsubss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 5c c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<double> sub<double>(byref Num128<double> lhs, byref Num128<double> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,fb,5c,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vsubsd xmm0,xmm0,xmm1         ; Vsubsd | VEX_Vsubsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 5c c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<byte> and<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,db,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpand xmm0,xmm0,xmm1          ; Vpand | VEX_Vpand_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 db c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<ushort> and<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,db,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpand xmm0,xmm0,xmm1          ; Vpand | VEX_Vpand_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 db c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<uint> and<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,db,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpand xmm0,xmm0,xmm1          ; Vpand | VEX_Vpand_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 db c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<ulong> and<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,db,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpand xmm0,xmm0,xmm1          ; Vpand | VEX_Vpand_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 db c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<sbyte> and<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,db,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpand xmm0,xmm0,xmm1          ; Vpand | VEX_Vpand_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 db c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<short> and<short>(byref Vec128<short> lhs, byref Vec128<short> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,db,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpand xmm0,xmm0,xmm1          ; Vpand | VEX_Vpand_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 db c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<int> and<int>(byref Vec128<int> lhs, byref Vec128<int> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,db,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpand xmm0,xmm0,xmm1          ; Vpand | VEX_Vpand_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 db c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<long> and<long>(byref Vec128<long> lhs, byref Vec128<long> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,db,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpand xmm0,xmm0,xmm1          ; Vpand | VEX_Vpand_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 db c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<float> and<float>(byref Vec128<float> lhs, byref Vec128<float> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f8,54,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vandps xmm0,xmm0,xmm1         ; Vandps | VEX_Vandps_xmm_xmm_xmmm128 | encoding(VEX) = c5 f8 54 c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<double> and<double>(byref Vec128<double> lhs, byref Vec128<double> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,54,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vandpd xmm0,xmm0,xmm1         ; Vandpd | VEX_Vandpd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 54 c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<byte> and<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,db,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpand ymm0,ymm0,ymm1          ; Vpand | VEX_Vpand_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd db c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<ushort> and<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,db,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpand ymm0,ymm0,ymm1          ; Vpand | VEX_Vpand_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd db c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<uint> and<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,db,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpand ymm0,ymm0,ymm1          ; Vpand | VEX_Vpand_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd db c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<ulong> and<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,db,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpand ymm0,ymm0,ymm1          ; Vpand | VEX_Vpand_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd db c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<sbyte> and<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,db,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpand ymm0,ymm0,ymm1          ; Vpand | VEX_Vpand_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd db c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<short> and<short>(byref Vec256<short> lhs, byref Vec256<short> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,db,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpand ymm0,ymm0,ymm1          ; Vpand | VEX_Vpand_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd db c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<int> and<int>(byref Vec256<int> lhs, byref Vec256<int> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,db,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpand ymm0,ymm0,ymm1          ; Vpand | VEX_Vpand_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd db c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<long> and<long>(byref Vec256<long> lhs, byref Vec256<long> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,db,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpand ymm0,ymm0,ymm1          ; Vpand | VEX_Vpand_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd db c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<float> and<float>(byref Vec256<float> lhs, byref Vec256<float> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fc,54,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vandps ymm0,ymm0,ymm1         ; Vandps | VEX_Vandps_ymm_ymm_ymmm256 | encoding(VEX) = c5 fc 54 c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<double> and<double>(byref Vec256<double> lhs, byref Vec256<double> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,54,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vandpd ymm0,ymm0,ymm1         ; Vandpd | VEX_Vandpd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd 54 c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,db,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpand xmm0,xmm0,xmm1          ; Vpand | VEX_Vpand_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 db c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,db,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpand xmm0,xmm0,xmm1          ; Vpand | VEX_Vpand_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 db c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,db,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpand xmm0,xmm0,xmm1          ; Vpand | VEX_Vpand_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 db c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,db,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpand xmm0,xmm0,xmm1          ; Vpand | VEX_Vpand_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 db c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,db,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpand xmm0,xmm0,xmm1          ; Vpand | VEX_Vpand_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 db c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,db,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpand xmm0,xmm0,xmm1          ; Vpand | VEX_Vpand_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 db c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,db,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpand xmm0,xmm0,xmm1          ; Vpand | VEX_Vpand_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 db c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,db,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpand xmm0,xmm0,xmm1          ; Vpand | VEX_Vpand_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 db c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f8,54,c1,c4,c1,78,11,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vandps xmm0,xmm0,xmm1         ; Vandps | VEX_Vandps_xmm_xmm_xmmm128 | encoding(VEX) = c5 f8 54 c1 (4 bytes)
0011h vmovups [r8],xmm0             ; Vmovups | VEX_Vmovups_xmmm128_xmm | encoding(VEX) = c4 c1 78 11 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,54,c1,c4,c1,79,11,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vandpd xmm0,xmm0,xmm1         ; Vandpd | VEX_Vandpd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 54 c1 (4 bytes)
0011h vmovupd [r8],xmm0             ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c4 c1 79 11 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,db,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpand ymm0,ymm0,ymm1          ; Vpand | VEX_Vpand_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd db c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,db,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpand ymm0,ymm0,ymm1          ; Vpand | VEX_Vpand_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd db c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,db,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpand ymm0,ymm0,ymm1          ; Vpand | VEX_Vpand_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd db c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,db,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpand ymm0,ymm0,ymm1          ; Vpand | VEX_Vpand_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd db c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,db,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpand ymm0,ymm0,ymm1          ; Vpand | VEX_Vpand_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd db c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,db,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpand ymm0,ymm0,ymm1          ; Vpand | VEX_Vpand_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd db c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,db,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpand ymm0,ymm0,ymm1          ; Vpand | VEX_Vpand_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd db c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,db,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpand ymm0,ymm0,ymm1          ; Vpand | VEX_Vpand_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd db c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fc,54,c1,c4,c1,7c,11,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vandps ymm0,ymm0,ymm1         ; Vandps | VEX_Vandps_ymm_ymm_ymmm256 | encoding(VEX) = c5 fc 54 c1 (4 bytes)
0011h vmovups [r8],ymm0             ; Vmovups | VEX_Vmovups_ymmm256_ymm | encoding(VEX) = c4 c1 7c 11 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void and<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,54,c1,c4,c1,7d,11,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vandpd ymm0,ymm0,ymm1         ; Vandpd | VEX_Vandpd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd 54 c1 (4 bytes)
0011h vmovupd [r8],ymm0             ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c4 c1 7d 11 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<byte> or<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,eb,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpor xmm0,xmm0,xmm1           ; Vpor | VEX_Vpor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 eb c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<ushort> or<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,eb,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpor xmm0,xmm0,xmm1           ; Vpor | VEX_Vpor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 eb c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<uint> or<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,eb,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpor xmm0,xmm0,xmm1           ; Vpor | VEX_Vpor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 eb c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<ulong> or<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,eb,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpor xmm0,xmm0,xmm1           ; Vpor | VEX_Vpor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 eb c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<sbyte> or<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,eb,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpor xmm0,xmm0,xmm1           ; Vpor | VEX_Vpor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 eb c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<short> or<short>(byref Vec128<short> lhs, byref Vec128<short> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,eb,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpor xmm0,xmm0,xmm1           ; Vpor | VEX_Vpor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 eb c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<int> or<int>(byref Vec128<int> lhs, byref Vec128<int> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,eb,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpor xmm0,xmm0,xmm1           ; Vpor | VEX_Vpor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 eb c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<long> or<long>(byref Vec128<long> lhs, byref Vec128<long> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,eb,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpor xmm0,xmm0,xmm1           ; Vpor | VEX_Vpor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 eb c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<float> or<float>(byref Vec128<float> lhs, byref Vec128<float> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f8,56,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vorps xmm0,xmm0,xmm1          ; Vorps | VEX_Vorps_xmm_xmm_xmmm128 | encoding(VEX) = c5 f8 56 c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<double> or<double>(byref Vec128<double> lhs, byref Vec128<double> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,56,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vorpd xmm0,xmm0,xmm1          ; Vorpd | VEX_Vorpd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 56 c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<byte> or<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,eb,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpor ymm0,ymm0,ymm1           ; Vpor | VEX_Vpor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd eb c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<ushort> or<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,eb,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpor ymm0,ymm0,ymm1           ; Vpor | VEX_Vpor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd eb c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<uint> or<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,eb,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpor ymm0,ymm0,ymm1           ; Vpor | VEX_Vpor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd eb c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<ulong> or<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,eb,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpor ymm0,ymm0,ymm1           ; Vpor | VEX_Vpor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd eb c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<sbyte> or<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,eb,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpor ymm0,ymm0,ymm1           ; Vpor | VEX_Vpor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd eb c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<short> or<short>(byref Vec256<short> lhs, byref Vec256<short> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,eb,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpor ymm0,ymm0,ymm1           ; Vpor | VEX_Vpor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd eb c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<int> or<int>(byref Vec256<int> lhs, byref Vec256<int> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,eb,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpor ymm0,ymm0,ymm1           ; Vpor | VEX_Vpor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd eb c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<long> or<long>(byref Vec256<long> lhs, byref Vec256<long> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,eb,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpor ymm0,ymm0,ymm1           ; Vpor | VEX_Vpor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd eb c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<float> or<float>(byref Vec256<float> lhs, byref Vec256<float> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fc,56,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vorps ymm0,ymm0,ymm1          ; Vorps | VEX_Vorps_ymm_ymm_ymmm256 | encoding(VEX) = c5 fc 56 c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<double> or<double>(byref Vec256<double> lhs, byref Vec256<double> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,56,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vorpd ymm0,ymm0,ymm1          ; Vorpd | VEX_Vorpd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd 56 c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,eb,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpor xmm0,xmm0,xmm1           ; Vpor | VEX_Vpor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 eb c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,eb,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpor xmm0,xmm0,xmm1           ; Vpor | VEX_Vpor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 eb c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,eb,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpor xmm0,xmm0,xmm1           ; Vpor | VEX_Vpor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 eb c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,eb,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpor xmm0,xmm0,xmm1           ; Vpor | VEX_Vpor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 eb c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,eb,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpor xmm0,xmm0,xmm1           ; Vpor | VEX_Vpor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 eb c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,eb,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpor xmm0,xmm0,xmm1           ; Vpor | VEX_Vpor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 eb c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,eb,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpor xmm0,xmm0,xmm1           ; Vpor | VEX_Vpor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 eb c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,eb,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpor xmm0,xmm0,xmm1           ; Vpor | VEX_Vpor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 eb c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f8,56,c1,c4,c1,78,11,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vorps xmm0,xmm0,xmm1          ; Vorps | VEX_Vorps_xmm_xmm_xmmm128 | encoding(VEX) = c5 f8 56 c1 (4 bytes)
0011h vmovups [r8],xmm0             ; Vmovups | VEX_Vmovups_xmmm128_xmm | encoding(VEX) = c4 c1 78 11 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,56,c1,c4,c1,79,11,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vorpd xmm0,xmm0,xmm1          ; Vorpd | VEX_Vorpd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 56 c1 (4 bytes)
0011h vmovupd [r8],xmm0             ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c4 c1 79 11 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,eb,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpor ymm0,ymm0,ymm1           ; Vpor | VEX_Vpor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd eb c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,eb,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpor ymm0,ymm0,ymm1           ; Vpor | VEX_Vpor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd eb c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,eb,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpor ymm0,ymm0,ymm1           ; Vpor | VEX_Vpor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd eb c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,eb,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpor ymm0,ymm0,ymm1           ; Vpor | VEX_Vpor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd eb c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,eb,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpor ymm0,ymm0,ymm1           ; Vpor | VEX_Vpor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd eb c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,eb,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpor ymm0,ymm0,ymm1           ; Vpor | VEX_Vpor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd eb c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,eb,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpor ymm0,ymm0,ymm1           ; Vpor | VEX_Vpor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd eb c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,eb,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpor ymm0,ymm0,ymm1           ; Vpor | VEX_Vpor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd eb c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fc,56,c1,c4,c1,7c,11,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vorps ymm0,ymm0,ymm1          ; Vorps | VEX_Vorps_ymm_ymm_ymmm256 | encoding(VEX) = c5 fc 56 c1 (4 bytes)
0011h vmovups [r8],ymm0             ; Vmovups | VEX_Vmovups_ymmm256_ymm | encoding(VEX) = c4 c1 7c 11 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void or<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,56,c1,c4,c1,7d,11,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vorpd ymm0,ymm0,ymm1          ; Vorpd | VEX_Vorpd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd 56 c1 (4 bytes)
0011h vmovupd [r8],ymm0             ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c4 c1 7d 11 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<byte> xor<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,ef,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpxor xmm0,xmm0,xmm1          ; Vpxor | VEX_Vpxor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 ef c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<ushort> xor<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,ef,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpxor xmm0,xmm0,xmm1          ; Vpxor | VEX_Vpxor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 ef c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<uint> xor<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,ef,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpxor xmm0,xmm0,xmm1          ; Vpxor | VEX_Vpxor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 ef c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<ulong> xor<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,ef,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpxor xmm0,xmm0,xmm1          ; Vpxor | VEX_Vpxor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 ef c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<sbyte> xor<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,ef,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpxor xmm0,xmm0,xmm1          ; Vpxor | VEX_Vpxor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 ef c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<short> xor<short>(byref Vec128<short> lhs, byref Vec128<short> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,ef,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpxor xmm0,xmm0,xmm1          ; Vpxor | VEX_Vpxor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 ef c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<int> xor<int>(byref Vec128<int> lhs, byref Vec128<int> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,ef,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpxor xmm0,xmm0,xmm1          ; Vpxor | VEX_Vpxor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 ef c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<long> xor<long>(byref Vec128<long> lhs, byref Vec128<long> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,ef,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpxor xmm0,xmm0,xmm1          ; Vpxor | VEX_Vpxor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 ef c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<float> xor<float>(byref Vec128<float> lhs, byref Vec128<float> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f8,57,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vxorps xmm0,xmm0,xmm1         ; Vxorps | VEX_Vxorps_xmm_xmm_xmmm128 | encoding(VEX) = c5 f8 57 c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<double> xor<double>(byref Vec128<double> lhs, byref Vec128<double> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,57,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vxorpd xmm0,xmm0,xmm1         ; Vxorpd | VEX_Vxorpd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 57 c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<byte> xor<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,ef,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpxor ymm0,ymm0,ymm1          ; Vpxor | VEX_Vpxor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd ef c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<ushort> xor<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,ef,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpxor ymm0,ymm0,ymm1          ; Vpxor | VEX_Vpxor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd ef c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<uint> xor<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,ef,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpxor ymm0,ymm0,ymm1          ; Vpxor | VEX_Vpxor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd ef c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<ulong> xor<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,ef,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpxor ymm0,ymm0,ymm1          ; Vpxor | VEX_Vpxor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd ef c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<sbyte> xor<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,ef,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpxor ymm0,ymm0,ymm1          ; Vpxor | VEX_Vpxor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd ef c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<short> xor<short>(byref Vec256<short> lhs, byref Vec256<short> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,ef,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpxor ymm0,ymm0,ymm1          ; Vpxor | VEX_Vpxor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd ef c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<int> xor<int>(byref Vec256<int> lhs, byref Vec256<int> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,ef,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpxor ymm0,ymm0,ymm1          ; Vpxor | VEX_Vpxor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd ef c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<long> xor<long>(byref Vec256<long> lhs, byref Vec256<long> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,ef,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpxor ymm0,ymm0,ymm1          ; Vpxor | VEX_Vpxor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd ef c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<float> xor<float>(byref Vec256<float> lhs, byref Vec256<float> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fc,57,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vxorps ymm0,ymm0,ymm1         ; Vxorps | VEX_Vxorps_ymm_ymm_ymmm256 | encoding(VEX) = c5 fc 57 c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<double> xor<double>(byref Vec256<double> lhs, byref Vec256<double> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,57,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vxorpd ymm0,ymm0,ymm1         ; Vxorpd | VEX_Vxorpd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd 57 c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,ef,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpxor xmm0,xmm0,xmm1          ; Vpxor | VEX_Vpxor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 ef c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,ef,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpxor xmm0,xmm0,xmm1          ; Vpxor | VEX_Vpxor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 ef c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,ef,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpxor xmm0,xmm0,xmm1          ; Vpxor | VEX_Vpxor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 ef c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,ef,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpxor xmm0,xmm0,xmm1          ; Vpxor | VEX_Vpxor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 ef c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,ef,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpxor xmm0,xmm0,xmm1          ; Vpxor | VEX_Vpxor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 ef c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,ef,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpxor xmm0,xmm0,xmm1          ; Vpxor | VEX_Vpxor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 ef c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,ef,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpxor xmm0,xmm0,xmm1          ; Vpxor | VEX_Vpxor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 ef c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,ef,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpxor xmm0,xmm0,xmm1          ; Vpxor | VEX_Vpxor_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 ef c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f8,57,c1,c4,c1,78,11,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vxorps xmm0,xmm0,xmm1         ; Vxorps | VEX_Vxorps_xmm_xmm_xmmm128 | encoding(VEX) = c5 f8 57 c1 (4 bytes)
0011h vmovups [r8],xmm0             ; Vmovups | VEX_Vmovups_xmmm128_xmm | encoding(VEX) = c4 c1 78 11 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,57,c1,c4,c1,79,11,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vxorpd xmm0,xmm0,xmm1         ; Vxorpd | VEX_Vxorpd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 57 c1 (4 bytes)
0011h vmovupd [r8],xmm0             ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c4 c1 79 11 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,ef,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpxor ymm0,ymm0,ymm1          ; Vpxor | VEX_Vpxor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd ef c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,ef,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpxor ymm0,ymm0,ymm1          ; Vpxor | VEX_Vpxor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd ef c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,ef,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpxor ymm0,ymm0,ymm1          ; Vpxor | VEX_Vpxor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd ef c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,ef,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpxor ymm0,ymm0,ymm1          ; Vpxor | VEX_Vpxor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd ef c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,ef,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpxor ymm0,ymm0,ymm1          ; Vpxor | VEX_Vpxor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd ef c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,ef,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpxor ymm0,ymm0,ymm1          ; Vpxor | VEX_Vpxor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd ef c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,ef,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpxor ymm0,ymm0,ymm1          ; Vpxor | VEX_Vpxor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd ef c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,ef,c1,c4,c1,7e,7f,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpxor ymm0,ymm0,ymm1          ; Vpxor | VEX_Vpxor_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd ef c1 (4 bytes)
0011h vmovdqu ymmword ptr [r8],ymm0 ; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c4 c1 7e 7f 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fc,57,c1,c4,c1,7c,11,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vxorps ymm0,ymm0,ymm1         ; Vxorps | VEX_Vxorps_ymm_ymm_ymmm256 | encoding(VEX) = c5 fc 57 c1 (4 bytes)
0011h vmovups [r8],ymm0             ; Vmovups | VEX_Vmovups_ymmm256_ymm | encoding(VEX) = c4 c1 7c 11 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void xor<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,57,c1,c4,c1,7d,11,00,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vxorpd ymm0,ymm0,ymm1         ; Vxorpd | VEX_Vxorpd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd 57 c1 (4 bytes)
0011h vmovupd [r8],ymm0             ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c4 c1 7d 11 00 (5 bytes)
0016h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<byte> add<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,fc,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpaddb xmm0,xmm0,xmm1         ; Vpaddb | VEX_Vpaddb_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fc c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<ushort> add<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,fd,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpaddw xmm0,xmm0,xmm1         ; Vpaddw | VEX_Vpaddw_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fd c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<uint> add<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,fe,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpaddd xmm0,xmm0,xmm1         ; Vpaddd | VEX_Vpaddd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fe c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<ulong> add<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,d4,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpaddq xmm0,xmm0,xmm1         ; Vpaddq | VEX_Vpaddq_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 d4 c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<sbyte> add<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,fc,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpaddb xmm0,xmm0,xmm1         ; Vpaddb | VEX_Vpaddb_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fc c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<short> add<short>(byref Vec128<short> lhs, byref Vec128<short> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,fd,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpaddw xmm0,xmm0,xmm1         ; Vpaddw | VEX_Vpaddw_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fd c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<int> add<int>(byref Vec128<int> lhs, byref Vec128<int> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,fe,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpaddd xmm0,xmm0,xmm1         ; Vpaddd | VEX_Vpaddd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fe c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<long> add<long>(byref Vec128<long> lhs, byref Vec128<long> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,d4,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpaddq xmm0,xmm0,xmm1         ; Vpaddq | VEX_Vpaddq_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 d4 c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<float> add<float>(byref Vec128<float> lhs, byref Vec128<float> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f8,58,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vaddps xmm0,xmm0,xmm1         ; Vaddps | VEX_Vaddps_xmm_xmm_xmmm128 | encoding(VEX) = c5 f8 58 c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<double> add<double>(byref Vec128<double> lhs, byref Vec128<double> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,58,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vaddpd xmm0,xmm0,xmm1         ; Vaddpd | VEX_Vaddpd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 58 c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<byte> add<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,fc,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpaddb ymm0,ymm0,ymm1         ; Vpaddb | VEX_Vpaddb_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fc c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<ushort> add<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,fd,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpaddw ymm0,ymm0,ymm1         ; Vpaddw | VEX_Vpaddw_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fd c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<uint> add<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,fe,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpaddd ymm0,ymm0,ymm1         ; Vpaddd | VEX_Vpaddd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fe c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<ulong> add<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,d4,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpaddq ymm0,ymm0,ymm1         ; Vpaddq | VEX_Vpaddq_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd d4 c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<sbyte> add<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,fc,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpaddb ymm0,ymm0,ymm1         ; Vpaddb | VEX_Vpaddb_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fc c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<short> add<short>(byref Vec256<short> lhs, byref Vec256<short> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,fd,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpaddw ymm0,ymm0,ymm1         ; Vpaddw | VEX_Vpaddw_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fd c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<int> add<int>(byref Vec256<int> lhs, byref Vec256<int> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,fe,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpaddd ymm0,ymm0,ymm1         ; Vpaddd | VEX_Vpaddd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fe c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<long> add<long>(byref Vec256<long> lhs, byref Vec256<long> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,d4,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpaddq ymm0,ymm0,ymm1         ; Vpaddq | VEX_Vpaddq_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd d4 c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<float> add<float>(byref Vec256<float> lhs, byref Vec256<float> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fc,58,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vaddps ymm0,ymm0,ymm1         ; Vaddps | VEX_Vaddps_ymm_ymm_ymmm256 | encoding(VEX) = c5 fc 58 c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<double> add<double>(byref Vec256<double> lhs, byref Vec256<double> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,58,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vaddpd ymm0,ymm0,ymm1         ; Vaddpd | VEX_Vaddpd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd 58 c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void add<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,fc,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpaddb xmm0,xmm0,xmm1         ; Vpaddb | VEX_Vpaddb_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fc c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void add<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,fd,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpaddw xmm0,xmm0,xmm1         ; Vpaddw | VEX_Vpaddw_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fd c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void add<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,fe,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpaddd xmm0,xmm0,xmm1         ; Vpaddd | VEX_Vpaddd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fe c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void add<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,d4,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpaddq xmm0,xmm0,xmm1         ; Vpaddq | VEX_Vpaddq_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 d4 c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void add<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,fc,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpaddb xmm0,xmm0,xmm1         ; Vpaddb | VEX_Vpaddb_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fc c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void add<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,fd,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpaddw xmm0,xmm0,xmm1         ; Vpaddw | VEX_Vpaddw_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fd c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void add<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,fe,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpaddd xmm0,xmm0,xmm1         ; Vpaddd | VEX_Vpaddd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fe c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void add<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,d4,c1,c4,c1,7a,7f,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vpaddq xmm0,xmm0,xmm1         ; Vpaddq | VEX_Vpaddq_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 d4 c1 (4 bytes)
0011h vmovdqu xmmword ptr [r8],xmm0 ; Vmovdqu | VEX_Vmovdqu_xmmm128_xmm | encoding(VEX) = c4 c1 7a 7f 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void add<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f8,58,c1,c4,c1,78,11,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vaddps xmm0,xmm0,xmm1         ; Vaddps | VEX_Vaddps_xmm_xmm_xmmm128 | encoding(VEX) = c5 f8 58 c1 (4 bytes)
0011h vmovups [r8],xmm0             ; Vmovups | VEX_Vmovups_xmmm128_xmm | encoding(VEX) = c4 c1 78 11 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void add<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst); {c5,f8,77,66,90,c5,f9,10,01,c5,f9,10,0a,c5,f9,58,c1,c4,c1,79,11,00,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rcx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 01 (4 bytes)
0009h vmovupd xmm1,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 0a (4 bytes)
000dh vaddpd xmm0,xmm0,xmm1         ; Vaddpd | VEX_Vaddpd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 58 c1 (4 bytes)
0011h vmovupd [r8],xmm0             ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c4 c1 79 11 00 (5 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byref Byte add<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,fc,c1,49,8b,c0,c5,fe,7f,00,49,8b,c0,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpaddb ymm0,ymm0,ymm1         ; Vpaddb | VEX_Vpaddb_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fc c1 (4 bytes)
0011h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
0014h vmovdqu ymmword ptr [rax],ymm0; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c5 fe 7f 00 (4 bytes)
0018h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
001bh vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byref UInt16 add<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,fd,c1,49,8b,c0,c5,fe,7f,00,49,8b,c0,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpaddw ymm0,ymm0,ymm1         ; Vpaddw | VEX_Vpaddw_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fd c1 (4 bytes)
0011h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
0014h vmovdqu ymmword ptr [rax],ymm0; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c5 fe 7f 00 (4 bytes)
0018h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
001bh vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byref UInt32 add<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,fe,c1,49,8b,c0,c5,fe,7f,00,49,8b,c0,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpaddd ymm0,ymm0,ymm1         ; Vpaddd | VEX_Vpaddd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fe c1 (4 bytes)
0011h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
0014h vmovdqu ymmword ptr [rax],ymm0; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c5 fe 7f 00 (4 bytes)
0018h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
001bh vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byref UInt64 add<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,d4,c1,49,8b,c0,c5,fe,7f,00,49,8b,c0,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpaddq ymm0,ymm0,ymm1         ; Vpaddq | VEX_Vpaddq_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd d4 c1 (4 bytes)
0011h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
0014h vmovdqu ymmword ptr [rax],ymm0; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c5 fe 7f 00 (4 bytes)
0018h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
001bh vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byref SByte add<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,fc,c1,49,8b,c0,c5,fe,7f,00,49,8b,c0,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpaddb ymm0,ymm0,ymm1         ; Vpaddb | VEX_Vpaddb_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fc c1 (4 bytes)
0011h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
0014h vmovdqu ymmword ptr [rax],ymm0; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c5 fe 7f 00 (4 bytes)
0018h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
001bh vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byref Int16 add<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,fd,c1,49,8b,c0,c5,fe,7f,00,49,8b,c0,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpaddw ymm0,ymm0,ymm1         ; Vpaddw | VEX_Vpaddw_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fd c1 (4 bytes)
0011h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
0014h vmovdqu ymmword ptr [rax],ymm0; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c5 fe 7f 00 (4 bytes)
0018h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
001bh vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byref Int32 add<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,fe,c1,49,8b,c0,c5,fe,7f,00,49,8b,c0,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpaddd ymm0,ymm0,ymm1         ; Vpaddd | VEX_Vpaddd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fe c1 (4 bytes)
0011h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
0014h vmovdqu ymmword ptr [rax],ymm0; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c5 fe 7f 00 (4 bytes)
0018h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
001bh vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byref Int64 add<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,d4,c1,49,8b,c0,c5,fe,7f,00,49,8b,c0,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vpaddq ymm0,ymm0,ymm1         ; Vpaddq | VEX_Vpaddq_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd d4 c1 (4 bytes)
0011h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
0014h vmovdqu ymmword ptr [rax],ymm0; Vmovdqu | VEX_Vmovdqu_ymmm256_ymm | encoding(VEX) = c5 fe 7f 00 (4 bytes)
0018h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
001bh vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byref Single add<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fc,58,c1,49,8b,c0,c5,fc,11,00,49,8b,c0,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vaddps ymm0,ymm0,ymm1         ; Vaddps | VEX_Vaddps_ymm_ymm_ymmm256 | encoding(VEX) = c5 fc 58 c1 (4 bytes)
0011h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
0014h vmovups [rax],ymm0            ; Vmovups | VEX_Vmovups_ymmm256_ymm | encoding(VEX) = c5 fc 11 00 (4 bytes)
0018h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
001bh vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byref Double add<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst); {c5,f8,77,66,90,c5,fd,10,01,c5,fd,10,0a,c5,fd,58,c1,49,8b,c0,c5,fd,11,00,49,8b,c0,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rcx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 01 (4 bytes)
0009h vmovupd ymm1,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 0a (4 bytes)
000dh vaddpd ymm0,ymm0,ymm1         ; Vaddpd | VEX_Vaddpd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd 58 c1 (4 bytes)
0011h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
0014h vmovupd [rax],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 00 (4 bytes)
0018h mov rax,r8                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c0 (3 bytes)
001bh vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<byte> add<byte>(byref Num128<byte> lhs, byref Num128<byte> rhs); {57,56,53,48,83,ec,30,be,8d,00,00,00,bf,01,00,00,00,b9,45,2c,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,1b,6d,78,5f,48,8b,d8,b9,45,2c,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,04,6d,78,5f,48,8b,d0,48,8d,4c,24,28,40,88,39,89,71,04,48,8b,cb,4c,8b,44,24,28,e8,01,ce,0c,00,48,8b,c8,e8,d1,7f,5e,5f,cc}
0000h push rdi                      ; Push | Push_r64 | encoding() = 57 (1 bytes)
0001h push rsi                      ; Push | Push_r64 | encoding() = 56 (1 bytes)
0002h push rbx                      ; Push | Push_r64 | encoding() = 53 (1 bytes)
0003h sub rsp,30h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 30 (4 bytes)
0007h mov esi,8Dh                   ; Mov | Mov_r32_imm32 | encoding() = be 8d 00 00 00 (5 bytes)
000ch mov edi,1                     ; Mov | Mov_r32_imm32 | encoding() = bf 01 00 00 00 (5 bytes)
0011h mov ecx,2C45h                 ; Mov | Mov_r32_imm32 | encoding() = b9 45 2c 00 00 (5 bytes)
0016h mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0020h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 1b 6d 78 5f (5 bytes)
0025h mov rbx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d8 (3 bytes)
0028h mov ecx,2C45h                 ; Mov | Mov_r32_imm32 | encoding() = b9 45 2c 00 00 (5 bytes)
002dh mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0037h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 04 6d 78 5f (5 bytes)
003ch mov rdx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d0 (3 bytes)
003fh lea rcx,[rsp+28h]             ; Lea | Lea_r64_m | encoding() = 48 8d 4c 24 28 (5 bytes)
0044h mov [rcx],dil                 ; Mov | Mov_rm8_r8 | encoding() = 40 88 39 (3 bytes)
0047h mov [rcx+4],esi               ; Mov | Mov_rm32_r32 | encoding() = 89 71 04 (3 bytes)
004ah mov rcx,rbx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b cb (3 bytes)
004dh mov r8,[rsp+28h]              ; Mov | Mov_r64_rm64 | encoding() = 4c 8b 44 24 28 (5 bytes)
0052h call 7FFC86D886F8h            ; Call | Call_rel32_64 | encoding() = e8 01 ce 0c 00 (5 bytes)
0057h mov rcx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c8 (3 bytes)
005ah call 7FFCE62A38D0h            ; Call | Call_rel32_64 | encoding() = e8 d1 7f 5e 5f (5 bytes)
005fh int 3                         ; Int | Int3 | encoding() = cc (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<ushort> add<ushort>(byref Num128<ushort> lhs, byref Num128<ushort> rhs); {57,56,53,48,83,ec,30,be,8d,00,00,00,bf,01,00,00,00,b9,45,2c,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,9b,6c,78,5f,48,8b,d8,b9,45,2c,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,84,6c,78,5f,48,8b,d0,48,8d,4c,24,28,40,88,39,89,71,04,48,8b,cb,4c,8b,44,24,28,e8,01,ce,0c,00,48,8b,c8,e8,51,7f,5e,5f,cc}
0000h push rdi                      ; Push | Push_r64 | encoding() = 57 (1 bytes)
0001h push rsi                      ; Push | Push_r64 | encoding() = 56 (1 bytes)
0002h push rbx                      ; Push | Push_r64 | encoding() = 53 (1 bytes)
0003h sub rsp,30h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 30 (4 bytes)
0007h mov esi,8Dh                   ; Mov | Mov_r32_imm32 | encoding() = be 8d 00 00 00 (5 bytes)
000ch mov edi,1                     ; Mov | Mov_r32_imm32 | encoding() = bf 01 00 00 00 (5 bytes)
0011h mov ecx,2C45h                 ; Mov | Mov_r32_imm32 | encoding() = b9 45 2c 00 00 (5 bytes)
0016h mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0020h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 9b 6c 78 5f (5 bytes)
0025h mov rbx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d8 (3 bytes)
0028h mov ecx,2C45h                 ; Mov | Mov_r32_imm32 | encoding() = b9 45 2c 00 00 (5 bytes)
002dh mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0037h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 84 6c 78 5f (5 bytes)
003ch mov rdx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d0 (3 bytes)
003fh lea rcx,[rsp+28h]             ; Lea | Lea_r64_m | encoding() = 48 8d 4c 24 28 (5 bytes)
0044h mov [rcx],dil                 ; Mov | Mov_rm8_r8 | encoding() = 40 88 39 (3 bytes)
0047h mov [rcx+4],esi               ; Mov | Mov_rm32_r32 | encoding() = 89 71 04 (3 bytes)
004ah mov rcx,rbx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b cb (3 bytes)
004dh mov r8,[rsp+28h]              ; Mov | Mov_r64_rm64 | encoding() = 4c 8b 44 24 28 (5 bytes)
0052h call 7FFC86D88778h            ; Call | Call_rel32_64 | encoding() = e8 01 ce 0c 00 (5 bytes)
0057h mov rcx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c8 (3 bytes)
005ah call 7FFCE62A38D0h            ; Call | Call_rel32_64 | encoding() = e8 51 7f 5e 5f (5 bytes)
005fh int 3                         ; Int | Int3 | encoding() = cc (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<uint> add<uint>(byref Num128<uint> lhs, byref Num128<uint> rhs); {57,56,53,48,83,ec,30,be,8d,00,00,00,bf,01,00,00,00,b9,45,2c,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,1b,6c,78,5f,48,8b,d8,b9,45,2c,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,04,6c,78,5f,48,8b,d0,48,8d,4c,24,28,40,88,39,89,71,04,48,8b,cb,4c,8b,44,24,28,e8,f1,cd,0c,00,48,8b,c8,e8,d1,7e,5e,5f,cc}
0000h push rdi                      ; Push | Push_r64 | encoding() = 57 (1 bytes)
0001h push rsi                      ; Push | Push_r64 | encoding() = 56 (1 bytes)
0002h push rbx                      ; Push | Push_r64 | encoding() = 53 (1 bytes)
0003h sub rsp,30h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 30 (4 bytes)
0007h mov esi,8Dh                   ; Mov | Mov_r32_imm32 | encoding() = be 8d 00 00 00 (5 bytes)
000ch mov edi,1                     ; Mov | Mov_r32_imm32 | encoding() = bf 01 00 00 00 (5 bytes)
0011h mov ecx,2C45h                 ; Mov | Mov_r32_imm32 | encoding() = b9 45 2c 00 00 (5 bytes)
0016h mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0020h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 1b 6c 78 5f (5 bytes)
0025h mov rbx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d8 (3 bytes)
0028h mov ecx,2C45h                 ; Mov | Mov_r32_imm32 | encoding() = b9 45 2c 00 00 (5 bytes)
002dh mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0037h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 04 6c 78 5f (5 bytes)
003ch mov rdx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d0 (3 bytes)
003fh lea rcx,[rsp+28h]             ; Lea | Lea_r64_m | encoding() = 48 8d 4c 24 28 (5 bytes)
0044h mov [rcx],dil                 ; Mov | Mov_rm8_r8 | encoding() = 40 88 39 (3 bytes)
0047h mov [rcx+4],esi               ; Mov | Mov_rm32_r32 | encoding() = 89 71 04 (3 bytes)
004ah mov rcx,rbx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b cb (3 bytes)
004dh mov r8,[rsp+28h]              ; Mov | Mov_r64_rm64 | encoding() = 4c 8b 44 24 28 (5 bytes)
0052h call 7FFC86D887E8h            ; Call | Call_rel32_64 | encoding() = e8 f1 cd 0c 00 (5 bytes)
0057h mov rcx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c8 (3 bytes)
005ah call 7FFCE62A38D0h            ; Call | Call_rel32_64 | encoding() = e8 d1 7e 5e 5f (5 bytes)
005fh int 3                         ; Int | Int3 | encoding() = cc (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<ulong> add<ulong>(byref Num128<ulong> lhs, byref Num128<ulong> rhs); {57,56,53,48,83,ec,30,be,8d,00,00,00,bf,01,00,00,00,b9,45,2c,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,9b,6b,78,5f,48,8b,d8,b9,45,2c,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,84,6b,78,5f,48,8b,d0,48,8d,4c,24,28,40,88,39,89,71,04,48,8b,cb,4c,8b,44,24,28,e8,e1,cd,0c,00,48,8b,c8,e8,51,7e,5e,5f,cc}
0000h push rdi                      ; Push | Push_r64 | encoding() = 57 (1 bytes)
0001h push rsi                      ; Push | Push_r64 | encoding() = 56 (1 bytes)
0002h push rbx                      ; Push | Push_r64 | encoding() = 53 (1 bytes)
0003h sub rsp,30h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 30 (4 bytes)
0007h mov esi,8Dh                   ; Mov | Mov_r32_imm32 | encoding() = be 8d 00 00 00 (5 bytes)
000ch mov edi,1                     ; Mov | Mov_r32_imm32 | encoding() = bf 01 00 00 00 (5 bytes)
0011h mov ecx,2C45h                 ; Mov | Mov_r32_imm32 | encoding() = b9 45 2c 00 00 (5 bytes)
0016h mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0020h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 9b 6b 78 5f (5 bytes)
0025h mov rbx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d8 (3 bytes)
0028h mov ecx,2C45h                 ; Mov | Mov_r32_imm32 | encoding() = b9 45 2c 00 00 (5 bytes)
002dh mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0037h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 84 6b 78 5f (5 bytes)
003ch mov rdx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d0 (3 bytes)
003fh lea rcx,[rsp+28h]             ; Lea | Lea_r64_m | encoding() = 48 8d 4c 24 28 (5 bytes)
0044h mov [rcx],dil                 ; Mov | Mov_rm8_r8 | encoding() = 40 88 39 (3 bytes)
0047h mov [rcx+4],esi               ; Mov | Mov_rm32_r32 | encoding() = 89 71 04 (3 bytes)
004ah mov rcx,rbx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b cb (3 bytes)
004dh mov r8,[rsp+28h]              ; Mov | Mov_r64_rm64 | encoding() = 4c 8b 44 24 28 (5 bytes)
0052h call 7FFC86D88858h            ; Call | Call_rel32_64 | encoding() = e8 e1 cd 0c 00 (5 bytes)
0057h mov rcx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c8 (3 bytes)
005ah call 7FFCE62A38D0h            ; Call | Call_rel32_64 | encoding() = e8 51 7e 5e 5f (5 bytes)
005fh int 3                         ; Int | Int3 | encoding() = cc (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<sbyte> add<sbyte>(byref Num128<sbyte> lhs, byref Num128<sbyte> rhs); {57,56,53,48,83,ec,30,be,8d,00,00,00,bf,01,00,00,00,b9,45,2c,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,1b,6b,78,5f,48,8b,d8,b9,45,2c,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,04,6b,78,5f,48,8b,d0,48,8d,4c,24,28,40,88,39,89,71,04,48,8b,cb,4c,8b,44,24,28,e8,71,cd,0c,00,48,8b,c8,e8,d1,7d,5e,5f,cc}
0000h push rdi                      ; Push | Push_r64 | encoding() = 57 (1 bytes)
0001h push rsi                      ; Push | Push_r64 | encoding() = 56 (1 bytes)
0002h push rbx                      ; Push | Push_r64 | encoding() = 53 (1 bytes)
0003h sub rsp,30h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 30 (4 bytes)
0007h mov esi,8Dh                   ; Mov | Mov_r32_imm32 | encoding() = be 8d 00 00 00 (5 bytes)
000ch mov edi,1                     ; Mov | Mov_r32_imm32 | encoding() = bf 01 00 00 00 (5 bytes)
0011h mov ecx,2C45h                 ; Mov | Mov_r32_imm32 | encoding() = b9 45 2c 00 00 (5 bytes)
0016h mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0020h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 1b 6b 78 5f (5 bytes)
0025h mov rbx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d8 (3 bytes)
0028h mov ecx,2C45h                 ; Mov | Mov_r32_imm32 | encoding() = b9 45 2c 00 00 (5 bytes)
002dh mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0037h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 04 6b 78 5f (5 bytes)
003ch mov rdx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d0 (3 bytes)
003fh lea rcx,[rsp+28h]             ; Lea | Lea_r64_m | encoding() = 48 8d 4c 24 28 (5 bytes)
0044h mov [rcx],dil                 ; Mov | Mov_rm8_r8 | encoding() = 40 88 39 (3 bytes)
0047h mov [rcx+4],esi               ; Mov | Mov_rm32_r32 | encoding() = 89 71 04 (3 bytes)
004ah mov rcx,rbx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b cb (3 bytes)
004dh mov r8,[rsp+28h]              ; Mov | Mov_r64_rm64 | encoding() = 4c 8b 44 24 28 (5 bytes)
0052h call 7FFC86D88868h            ; Call | Call_rel32_64 | encoding() = e8 71 cd 0c 00 (5 bytes)
0057h mov rcx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c8 (3 bytes)
005ah call 7FFCE62A38D0h            ; Call | Call_rel32_64 | encoding() = e8 d1 7d 5e 5f (5 bytes)
005fh int 3                         ; Int | Int3 | encoding() = cc (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<short> add<short>(byref Num128<short> lhs, byref Num128<short> rhs); {57,56,53,48,83,ec,30,be,8d,00,00,00,bf,01,00,00,00,b9,45,2c,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,9b,6a,78,5f,48,8b,d8,b9,45,2c,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,84,6a,78,5f,48,8b,d0,48,8d,4c,24,28,40,88,39,89,71,04,48,8b,cb,4c,8b,44,24,28,e8,01,d0,0c,00,48,8b,c8,e8,51,7d,5e,5f,cc}
0000h push rdi                      ; Push | Push_r64 | encoding() = 57 (1 bytes)
0001h push rsi                      ; Push | Push_r64 | encoding() = 56 (1 bytes)
0002h push rbx                      ; Push | Push_r64 | encoding() = 53 (1 bytes)
0003h sub rsp,30h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 30 (4 bytes)
0007h mov esi,8Dh                   ; Mov | Mov_r32_imm32 | encoding() = be 8d 00 00 00 (5 bytes)
000ch mov edi,1                     ; Mov | Mov_r32_imm32 | encoding() = bf 01 00 00 00 (5 bytes)
0011h mov ecx,2C45h                 ; Mov | Mov_r32_imm32 | encoding() = b9 45 2c 00 00 (5 bytes)
0016h mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0020h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 9b 6a 78 5f (5 bytes)
0025h mov rbx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d8 (3 bytes)
0028h mov ecx,2C45h                 ; Mov | Mov_r32_imm32 | encoding() = b9 45 2c 00 00 (5 bytes)
002dh mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0037h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 84 6a 78 5f (5 bytes)
003ch mov rdx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d0 (3 bytes)
003fh lea rcx,[rsp+28h]             ; Lea | Lea_r64_m | encoding() = 48 8d 4c 24 28 (5 bytes)
0044h mov [rcx],dil                 ; Mov | Mov_rm8_r8 | encoding() = 40 88 39 (3 bytes)
0047h mov [rcx+4],esi               ; Mov | Mov_rm32_r32 | encoding() = 89 71 04 (3 bytes)
004ah mov rcx,rbx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b cb (3 bytes)
004dh mov r8,[rsp+28h]              ; Mov | Mov_r64_rm64 | encoding() = 4c 8b 44 24 28 (5 bytes)
0052h call 7FFC86D88B78h            ; Call | Call_rel32_64 | encoding() = e8 01 d0 0c 00 (5 bytes)
0057h mov rcx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c8 (3 bytes)
005ah call 7FFCE62A38D0h            ; Call | Call_rel32_64 | encoding() = e8 51 7d 5e 5f (5 bytes)
005fh int 3                         ; Int | Int3 | encoding() = cc (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<int> add<int>(byref Num128<int> lhs, byref Num128<int> rhs); {57,56,53,48,83,ec,30,be,8d,00,00,00,bf,01,00,00,00,b9,45,2c,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,1b,6a,78,5f,48,8b,d8,b9,45,2c,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,04,6a,78,5f,48,8b,d0,48,8d,4c,24,28,40,88,39,89,71,04,48,8b,cb,4c,8b,44,24,28,e8,f1,cf,0c,00,48,8b,c8,e8,d1,7c,5e,5f,cc}
0000h push rdi                      ; Push | Push_r64 | encoding() = 57 (1 bytes)
0001h push rsi                      ; Push | Push_r64 | encoding() = 56 (1 bytes)
0002h push rbx                      ; Push | Push_r64 | encoding() = 53 (1 bytes)
0003h sub rsp,30h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 30 (4 bytes)
0007h mov esi,8Dh                   ; Mov | Mov_r32_imm32 | encoding() = be 8d 00 00 00 (5 bytes)
000ch mov edi,1                     ; Mov | Mov_r32_imm32 | encoding() = bf 01 00 00 00 (5 bytes)
0011h mov ecx,2C45h                 ; Mov | Mov_r32_imm32 | encoding() = b9 45 2c 00 00 (5 bytes)
0016h mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0020h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 1b 6a 78 5f (5 bytes)
0025h mov rbx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d8 (3 bytes)
0028h mov ecx,2C45h                 ; Mov | Mov_r32_imm32 | encoding() = b9 45 2c 00 00 (5 bytes)
002dh mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0037h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 04 6a 78 5f (5 bytes)
003ch mov rdx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d0 (3 bytes)
003fh lea rcx,[rsp+28h]             ; Lea | Lea_r64_m | encoding() = 48 8d 4c 24 28 (5 bytes)
0044h mov [rcx],dil                 ; Mov | Mov_rm8_r8 | encoding() = 40 88 39 (3 bytes)
0047h mov [rcx+4],esi               ; Mov | Mov_rm32_r32 | encoding() = 89 71 04 (3 bytes)
004ah mov rcx,rbx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b cb (3 bytes)
004dh mov r8,[rsp+28h]              ; Mov | Mov_r64_rm64 | encoding() = 4c 8b 44 24 28 (5 bytes)
0052h call 7FFC86D88BE8h            ; Call | Call_rel32_64 | encoding() = e8 f1 cf 0c 00 (5 bytes)
0057h mov rcx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c8 (3 bytes)
005ah call 7FFCE62A38D0h            ; Call | Call_rel32_64 | encoding() = e8 d1 7c 5e 5f (5 bytes)
005fh int 3                         ; Int | Int3 | encoding() = cc (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<long> add<long>(byref Num128<long> lhs, byref Num128<long> rhs); {57,56,53,48,83,ec,30,be,8d,00,00,00,bf,01,00,00,00,b9,45,2c,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,9b,69,78,5f,48,8b,d8,b9,45,2c,00,00,48,ba,58,0c,93,86,fc,7f,00,00,e8,84,69,78,5f,48,8b,d0,48,8d,4c,24,28,40,88,39,89,71,04,48,8b,cb,4c,8b,44,24,28,e8,e1,cf,0c,00,48,8b,c8,e8,51,7c,5e,5f,cc}
0000h push rdi                      ; Push | Push_r64 | encoding() = 57 (1 bytes)
0001h push rsi                      ; Push | Push_r64 | encoding() = 56 (1 bytes)
0002h push rbx                      ; Push | Push_r64 | encoding() = 53 (1 bytes)
0003h sub rsp,30h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 30 (4 bytes)
0007h mov esi,8Dh                   ; Mov | Mov_r32_imm32 | encoding() = be 8d 00 00 00 (5 bytes)
000ch mov edi,1                     ; Mov | Mov_r32_imm32 | encoding() = bf 01 00 00 00 (5 bytes)
0011h mov ecx,2C45h                 ; Mov | Mov_r32_imm32 | encoding() = b9 45 2c 00 00 (5 bytes)
0016h mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0020h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 9b 69 78 5f (5 bytes)
0025h mov rbx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d8 (3 bytes)
0028h mov ecx,2C45h                 ; Mov | Mov_r32_imm32 | encoding() = b9 45 2c 00 00 (5 bytes)
002dh mov rdx,7FFC86930C58h         ; Mov | Mov_r64_imm64 | encoding() = 48 ba 58 0c 93 86 fc 7f 00 00 (10 bytes)
0037h call 7FFCE64425E0h            ; Call | Call_rel32_64 | encoding() = e8 84 69 78 5f (5 bytes)
003ch mov rdx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b d0 (3 bytes)
003fh lea rcx,[rsp+28h]             ; Lea | Lea_r64_m | encoding() = 48 8d 4c 24 28 (5 bytes)
0044h mov [rcx],dil                 ; Mov | Mov_rm8_r8 | encoding() = 40 88 39 (3 bytes)
0047h mov [rcx+4],esi               ; Mov | Mov_rm32_r32 | encoding() = 89 71 04 (3 bytes)
004ah mov rcx,rbx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b cb (3 bytes)
004dh mov r8,[rsp+28h]              ; Mov | Mov_r64_rm64 | encoding() = 4c 8b 44 24 28 (5 bytes)
0052h call 7FFC86D88C58h            ; Call | Call_rel32_64 | encoding() = e8 e1 cf 0c 00 (5 bytes)
0057h mov rcx,rax                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c8 (3 bytes)
005ah call 7FFCE62A38D0h            ; Call | Call_rel32_64 | encoding() = e8 51 7c 5e 5f (5 bytes)
005fh int 3                         ; Int | Int3 | encoding() = cc (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<float> add<float>(byref Num128<float> lhs, byref Num128<float> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,fa,58,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vaddss xmm0,xmm0,xmm1         ; Vaddss | VEX_Vaddss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 58 c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Num128<double> add<double>(byref Num128<double> lhs, byref Num128<double> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,fb,58,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vaddsd xmm0,xmm0,xmm1         ; Vaddsd | VEX_Vaddsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 58 c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<byte> sub<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,f8,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpsubb xmm0,xmm0,xmm1         ; Vpsubb | VEX_Vpsubb_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 f8 c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<ushort> sub<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,f9,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpsubw xmm0,xmm0,xmm1         ; Vpsubw | VEX_Vpsubw_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 f9 c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<uint> sub<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,fa,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpsubd xmm0,xmm0,xmm1         ; Vpsubd | VEX_Vpsubd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fa c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<ulong> sub<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,fb,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpsubq xmm0,xmm0,xmm1         ; Vpsubq | VEX_Vpsubq_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fb c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<sbyte> sub<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,f8,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpsubb xmm0,xmm0,xmm1         ; Vpsubb | VEX_Vpsubb_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 f8 c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<short> sub<short>(byref Vec128<short> lhs, byref Vec128<short> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,f9,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpsubw xmm0,xmm0,xmm1         ; Vpsubw | VEX_Vpsubw_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 f9 c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<int> sub<int>(byref Vec128<int> lhs, byref Vec128<int> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,fa,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpsubd xmm0,xmm0,xmm1         ; Vpsubd | VEX_Vpsubd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fa c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<long> sub<long>(byref Vec128<long> lhs, byref Vec128<long> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,fb,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpsubq xmm0,xmm0,xmm1         ; Vpsubq | VEX_Vpsubq_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fb c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<float> sub<float>(byref Vec128<float> lhs, byref Vec128<float> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f8,5c,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vsubps xmm0,xmm0,xmm1         ; Vsubps | VEX_Vsubps_xmm_xmm_xmmm128 | encoding(VEX) = c5 f8 5c c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<double> sub<double>(byref Vec128<double> lhs, byref Vec128<double> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,5c,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vsubpd xmm0,xmm0,xmm1         ; Vsubpd | VEX_Vsubpd_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 5c c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<byte> sub<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,f8,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpsubb ymm0,ymm0,ymm1         ; Vpsubb | VEX_Vpsubb_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd f8 c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<ushort> sub<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,f9,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpsubw ymm0,ymm0,ymm1         ; Vpsubw | VEX_Vpsubw_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd f9 c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<uint> sub<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,fa,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpsubd ymm0,ymm0,ymm1         ; Vpsubd | VEX_Vpsubd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fa c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<ulong> sub<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,fb,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpsubq ymm0,ymm0,ymm1         ; Vpsubq | VEX_Vpsubq_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fb c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<sbyte> sub<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,f8,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpsubb ymm0,ymm0,ymm1         ; Vpsubb | VEX_Vpsubb_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd f8 c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<short> sub<short>(byref Vec256<short> lhs, byref Vec256<short> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,f9,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpsubw ymm0,ymm0,ymm1         ; Vpsubw | VEX_Vpsubw_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd f9 c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<int> sub<int>(byref Vec256<int> lhs, byref Vec256<int> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,fa,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpsubd ymm0,ymm0,ymm1         ; Vpsubd | VEX_Vpsubd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fa c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<long> sub<long>(byref Vec256<long> lhs, byref Vec256<long> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,fb,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vpsubq ymm0,ymm0,ymm1         ; Vpsubq | VEX_Vpsubq_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd fb c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<float> sub<float>(byref Vec256<float> lhs, byref Vec256<float> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fc,5c,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vsubps ymm0,ymm0,ymm1         ; Vsubps | VEX_Vsubps_ymm_ymm_ymmm256 | encoding(VEX) = c5 fc 5c c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<double> sub<double>(byref Vec256<double> lhs, byref Vec256<double> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,5c,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vmovupd ymm1,[r8]             ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c4 c1 7d 10 08 (5 bytes)
000eh vsubpd ymm0,ymm0,ymm1         ; Vsubpd | VEX_Vsubpd_ymm_ymm_ymmm256 | encoding(VEX) = c5 fd 5c c1 (4 bytes)
0012h vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
001ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
