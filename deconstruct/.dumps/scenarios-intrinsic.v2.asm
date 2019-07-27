# 2019-07-27 04:33:01:884
Vec128<sbyte> add1(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,fc,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpaddb xmm0,xmm0,xmm1         ; Vpaddb | VEX_Vpaddb_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fc c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec128<sbyte> add2(Vec128<sbyte> lhs, Vec128<sbyte> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,10,08,c5,f9,fc,c1,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vmovupd xmm1,[r8]             ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c4 c1 79 10 08 (5 bytes)
000eh vpaddb xmm0,xmm0,xmm1         ; Vpaddb | VEX_Vpaddb_xmm_xmm_xmmm128 | encoding(VEX) = c5 f9 fc c1 (4 bytes)
0012h vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0016h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vector128<sbyte> add3(Vector128<sbyte> lhs, Vector128<sbyte> rhs); {c5,f8,77,66,90,c5,f9,10,02,c4,c1,79,fc,00,c5,f9,11,01,48,8b,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd xmm0,[rdx]            ; Vmovupd | VEX_Vmovupd_xmm_xmmm128 | encoding(VEX) = c5 f9 10 02 (4 bytes)
0009h vpaddb xmm0,xmm0,[r8]         ; Vpaddb | VEX_Vpaddb_xmm_xmm_xmmm128 | encoding(VEX) = c4 c1 79 fc 00 (5 bytes)
000eh vmovupd [rcx],xmm0            ; Vmovupd | VEX_Vmovupd_xmmm128_xmm | encoding(VEX) = c5 f9 11 01 (4 bytes)
0012h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0015h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vector256<sbyte> add4(Vector256<sbyte> lhs, Vector256<sbyte> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,fc,00,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovupd ymm0,[rdx]            ; Vmovupd | VEX_Vmovupd_ymm_ymmm256 | encoding(VEX) = c5 fd 10 02 (4 bytes)
0009h vpaddb ymm0,ymm0,[r8]         ; Vpaddb | VEX_Vpaddb_ymm_ymm_ymmm256 | encoding(VEX) = c4 c1 7d fc 00 (5 bytes)
000eh vmovupd [rcx],ymm0            ; Vmovupd | VEX_Vmovupd_ymmm256_ymm | encoding(VEX) = c5 fd 11 01 (4 bytes)
0012h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0015h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0018h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
Vec256<sbyte> add5(Vec256<sbyte> lhs, Vec256<sbyte> rhs); {c5,f8,77,66,90,c5,fd,10,02,c4,c1,7d,10,08,c5,fd,fc,c1,c5,fd,11,01,48,8b,c1,c5,f8,77,c3}
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
