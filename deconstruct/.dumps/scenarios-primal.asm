# 2019-07-28 04:08:53:437
7FFC6847AEA0h sbyte add8i(sbyte x, sbyte y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rdx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be d2 (4 bytes)
000dh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000fh movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847AEB3h                       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,d2,03,c2,48,0f,be,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847AED0h byte add8u(byte x, byte y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000dh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847AEE0h                       ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,03,c2,0f,b6,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847AF00h short add16i(short x, short y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rdx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf d2 (4 bytes)
000dh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000fh movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847AF13h                       ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,d2,03,c2,48,0f,bf,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847AF30h ushort add16u(ushort x, ushort y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000dh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847AF40h                       ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,03,c2,0f,b7,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847AF60h int add32i(int x, int y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea eax,[rcx+rdx]             ; Lea | Lea_r32_m | encoding() = 8d 04 11 (3 bytes)
0008h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847AF68h                       ; {0f,1f,44,00,00,8d,04,11,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847AF80h uint add32u(uint x, uint y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea eax,[rcx+rdx]             ; Lea | Lea_r32_m | encoding() = 8d 04 11 (3 bytes)
0008h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847AF88h                       ; {0f,1f,44,00,00,8d,04,11,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847AFA0h long add64i(long x, long y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea rax,[rcx+rdx]             ; Lea | Lea_r64_m | encoding() = 48 8d 04 11 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847AFA9h                       ; {0f,1f,44,00,00,48,8d,04,11,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847AFC0h ulong add64u(ulong x, ulong y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea rax,[rcx+rdx]             ; Lea | Lea_r64_m | encoding() = 48 8d 04 11 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847AFC9h                       ; {0f,1f,44,00,00,48,8d,04,11,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847AFE0h float add32f(float x, float y)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vaddss xmm0,xmm0,xmm1         ; Vaddss | VEX_Vaddss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 58 c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847AFE9h                       ; {c5,f8,77,66,90,c5,fa,58,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B000h double add64f(double x, double y)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vaddsd xmm0,xmm0,xmm1         ; Vaddsd | VEX_Vaddsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 58 c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B009h                       ; {c5,f8,77,66,90,c5,fb,58,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B020h sbyte add8ix3(sbyte x, sbyte y, sbyte z)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rdx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be d2 (4 bytes)
000dh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000fh movsx rdx,r8b                 ; Movsx | Movsx_r64_rm8 | encoding() = 49 0f be d0 (4 bytes)
0013h add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
0015h movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B039h                       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,d2,03,c2,49,0f,be,d0,03,c2,48,0f,be,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B050h byte add8ux3(byte x, byte y, byte z)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000dh movzx edx,r8b                 ; Movzx | Movzx_r32_rm8 | encoding() = 41 0f b6 d0 (4 bytes)
0011h add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
0013h movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B066h                       ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,03,c2,41,0f,b6,d0,03,c2,0f,b6,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B080h short add16ix3(short x, short y, short z)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rdx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf d2 (4 bytes)
000dh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000fh movsx rdx,r8w                 ; Movsx | Movsx_r64_rm16 | encoding() = 49 0f bf d0 (4 bytes)
0013h add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
0015h movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B099h                       ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,d2,03,c2,49,0f,bf,d0,03,c2,48,0f,bf,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B0B0h ushort add16ux3(ushort x, ushort y, ushort z)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000dh movzx edx,r8w                 ; Movzx | Movzx_r32_rm16 | encoding() = 41 0f b7 d0 (4 bytes)
0011h add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
0013h movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0016h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B0C6h                       ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,03,c2,41,0f,b7,d0,03,c2,0f,b7,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B0E0h int add32ix3(int x, int y, int z)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea eax,[rcx+rdx]             ; Lea | Lea_r32_m | encoding() = 8d 04 11 (3 bytes)
0008h add eax,r8d                   ; Add | Add_r32_rm32 | encoding() = 41 03 c0 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B0EBh                       ; {0f,1f,44,00,00,8d,04,11,41,03,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B100h uint add32ux3(uint x, uint y, uint z)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea eax,[rcx+rdx]             ; Lea | Lea_r32_m | encoding() = 8d 04 11 (3 bytes)
0008h add eax,r8d                   ; Add | Add_r32_rm32 | encoding() = 41 03 c0 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B10Bh                       ; {0f,1f,44,00,00,8d,04,11,41,03,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B120h long add64ix3(long x, long y, long z)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea rax,[rcx+rdx]             ; Lea | Lea_r64_m | encoding() = 48 8d 04 11 (4 bytes)
0009h add rax,r8                    ; Add | Add_r64_rm64 | encoding() = 49 03 c0 (3 bytes)
000ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B12Ch                       ; {0f,1f,44,00,00,48,8d,04,11,49,03,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B140h ulong add64ux3(ulong x, ulong y, ulong z)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea rax,[rcx+rdx]             ; Lea | Lea_r64_m | encoding() = 48 8d 04 11 (4 bytes)
0009h add rax,r8                    ; Add | Add_r64_rm64 | encoding() = 49 03 c0 (3 bytes)
000ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B14Ch                       ; {0f,1f,44,00,00,48,8d,04,11,49,03,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B160h float add32fx3(float x, float y, float z)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vaddss xmm0,xmm0,xmm1         ; Vaddss | VEX_Vaddss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 58 c1 (4 bytes)
0009h vaddss xmm0,xmm0,xmm2         ; Vaddss | VEX_Vaddss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 58 c2 (4 bytes)
000dh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B16Dh                       ; {c5,f8,77,66,90,c5,fa,58,c1,c5,fa,58,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B180h double add64fx3(double x, double y, double z)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vaddsd xmm0,xmm0,xmm1         ; Vaddsd | VEX_Vaddsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 58 c1 (4 bytes)
0009h vaddsd xmm0,xmm0,xmm2         ; Vaddsd | VEX_Vaddsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 58 c2 (4 bytes)
000dh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B18Dh                       ; {c5,f8,77,66,90,c5,fb,58,c1,c5,fb,58,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B1A0h byte and8u(byte x, byte y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh and eax,edx                   ; And | And_r32_rm32 | encoding() = 23 c2 (2 bytes)
000dh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B1B0h                       ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,23,c2,0f,b6,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B1D0h sbyte and8i(sbyte x, sbyte y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rdx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be d2 (4 bytes)
000dh and eax,edx                   ; And | And_r32_rm32 | encoding() = 23 c2 (2 bytes)
000fh movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B1E3h                       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,d2,23,c2,48,0f,be,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B200h short and16i(short x, short y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rdx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf d2 (4 bytes)
000dh and eax,edx                   ; And | And_r32_rm32 | encoding() = 23 c2 (2 bytes)
000fh movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B213h                       ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,d2,23,c2,48,0f,bf,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B230h ushort and16u(ushort x, ushort y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh and eax,edx                   ; And | And_r32_rm32 | encoding() = 23 c2 (2 bytes)
000dh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B240h                       ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,23,c2,0f,b7,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B260h int and32i(int x, int y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h and eax,edx                   ; And | And_r32_rm32 | encoding() = 23 c2 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B269h                       ; {0f,1f,44,00,00,8b,c1,23,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B280h uint and32u(uint x, uint y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h and eax,edx                   ; And | And_r32_rm32 | encoding() = 23 c2 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B289h                       ; {0f,1f,44,00,00,8b,c1,23,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B2A0h long and64i(long x, long y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h and rax,rdx                   ; And | And_r64_rm64 | encoding() = 48 23 c2 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B2ABh                       ; {0f,1f,44,00,00,48,8b,c1,48,23,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B2C0h ulong and64u(ulong x, ulong y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h and rax,rdx                   ; And | And_r64_rm64 | encoding() = 48 23 c2 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B2CBh                       ; {0f,1f,44,00,00,48,8b,c1,48,23,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B2E0h sbyte div8i(sbyte x, sbyte y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rcx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be ca (4 bytes)
000dh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000eh idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
0010h movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B2F4h                       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,ca,99,f7,f9,48,0f,be,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B310h byte div8u(byte x, byte y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx ecx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 ca (3 bytes)
000bh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000ch idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
000eh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B321h                       ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,ca,99,f7,f9,0f,b6,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B340h short div16i(short x, short y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rcx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf ca (4 bytes)
000dh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000eh idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
0010h movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B354h                       ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,ca,99,f7,f9,48,0f,bf,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B370h ushort div16u(ushort x, ushort y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx ecx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 ca (3 bytes)
000bh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000ch idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
000eh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B381h                       ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,ca,99,f7,f9,0f,b7,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B3A0h int div32i(int x, int y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8d,edx                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c2 (3 bytes)
0008h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
000ah cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000bh idiv r8d                      ; Idiv | Idiv_rm32 | encoding() = 41 f7 f8 (3 bytes)
000eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B3AEh                       ; {0f,1f,44,00,00,44,8b,c2,8b,c1,99,41,f7,f8,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B3C0h uint div32u(uint x, uint y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8d,edx                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c2 (3 bytes)
0008h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
000ah xor edx,edx                   ; Xor | Xor_r32_rm32 | encoding() = 33 d2 (2 bytes)
000ch div r8d                       ; Div | Div_rm32 | encoding() = 41 f7 f0 (3 bytes)
000fh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B3CFh                       ; {0f,1f,44,00,00,44,8b,c2,8b,c1,33,d2,41,f7,f0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B3E0h long div64i(long x, long y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8,rdx                    ; Mov | Mov_r64_rm64 | encoding() = 4c 8b c2 (3 bytes)
0008h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
000bh cqo                           ; Cqo | Cqo | encoding() = 48 99 (2 bytes)
000dh idiv r8                       ; Idiv | Idiv_rm64 | encoding() = 49 f7 f8 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B3F0h                       ; {0f,1f,44,00,00,4c,8b,c2,48,8b,c1,48,99,49,f7,f8,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B410h ulong div64u(ulong x, ulong y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8,rdx                    ; Mov | Mov_r64_rm64 | encoding() = 4c 8b c2 (3 bytes)
0008h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
000bh xor edx,edx                   ; Xor | Xor_r32_rm32 | encoding() = 33 d2 (2 bytes)
000dh div r8                        ; Div | Div_rm64 | encoding() = 49 f7 f0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B420h                       ; {0f,1f,44,00,00,4c,8b,c2,48,8b,c1,33,d2,49,f7,f0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B440h float div32f(float x, float y)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vdivss xmm0,xmm0,xmm1         ; Vdivss | VEX_Vdivss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 5e c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B449h                       ; {c5,f8,77,66,90,c5,fa,5e,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B460h double div64f(double x, double y)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vdivsd xmm0,xmm0,xmm1         ; Vdivsd | VEX_Vdivsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 5e c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B469h                       ; {c5,f8,77,66,90,c5,fb,5e,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B480h sbyte mul8i(sbyte x, sbyte y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rdx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be d2 (4 bytes)
000dh imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
0010h movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B494h                       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,d2,0f,af,c2,48,0f,be,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B4B0h byte mul8u(byte x, byte y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
000eh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B4C1h                       ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,0f,af,c2,0f,b6,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B4E0h short mul16i(short x, short y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rdx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf d2 (4 bytes)
000dh imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
0010h movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B4F4h                       ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,d2,0f,af,c2,48,0f,bf,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B510h ushort mul16u(ushort x, ushort y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
000eh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B521h                       ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,0f,af,c2,0f,b7,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B540h int mul32i(int x, int y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
000ah ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B54Ah                       ; {0f,1f,44,00,00,8b,c1,0f,af,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B560h uint mul32u(uint x, uint y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
000ah ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B56Ah                       ; {0f,1f,44,00,00,8b,c1,0f,af,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B580h long mul64i(long x, long y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h imul rax,rdx                  ; Imul | Imul_r64_rm64 | encoding() = 48 0f af c2 (4 bytes)
000ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B58Ch                       ; {0f,1f,44,00,00,48,8b,c1,48,0f,af,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B5A0h ulong mul64u(ulong x, ulong y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h imul rax,rdx                  ; Imul | Imul_r64_rm64 | encoding() = 48 0f af c2 (4 bytes)
000ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B5ACh                       ; {0f,1f,44,00,00,48,8b,c1,48,0f,af,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B5C0h float mul32f(float x, float y)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmulss xmm0,xmm0,xmm1         ; Vmulss | VEX_Vmulss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 59 c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B5C9h                       ; {c5,f8,77,66,90,c5,fa,59,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B5E0h double mul64f(double x, double y)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmulsd xmm0,xmm0,xmm1         ; Vmulsd | VEX_Vmulsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 59 c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B5E9h                       ; {c5,f8,77,66,90,c5,fb,59,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B600h sbyte mod8i(sbyte x, sbyte y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rcx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be ca (4 bytes)
000dh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000eh idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
0010h movsx rax,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c2 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B614h                       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,ca,99,f7,f9,48,0f,be,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B630h byte mod8u(byte x, byte y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx ecx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 ca (3 bytes)
000bh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000ch idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
000eh movzx eax,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c2 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B641h                       ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,ca,99,f7,f9,0f,b6,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B660h short mod16i(short x, short y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rcx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf ca (4 bytes)
000dh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000eh idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
0010h movsx rax,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c2 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B674h                       ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,ca,99,f7,f9,48,0f,bf,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B690h ushort mod16u(ushort x, ushort y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx ecx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 ca (3 bytes)
000bh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000ch idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
000eh movzx eax,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c2 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B6A1h                       ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,ca,99,f7,f9,0f,b7,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B6C0h int mod32i(int x, int y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8d,edx                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c2 (3 bytes)
0008h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
000ah cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000bh idiv r8d                      ; Idiv | Idiv_rm32 | encoding() = 41 f7 f8 (3 bytes)
000eh mov eax,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c2 (2 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B6D0h                       ; {0f,1f,44,00,00,44,8b,c2,8b,c1,99,41,f7,f8,8b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B6F0h uint mod32u(uint x, uint y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8d,edx                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c2 (3 bytes)
0008h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
000ah xor edx,edx                   ; Xor | Xor_r32_rm32 | encoding() = 33 d2 (2 bytes)
000ch div r8d                       ; Div | Div_rm32 | encoding() = 41 f7 f0 (3 bytes)
000fh mov eax,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c2 (2 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B701h                       ; {0f,1f,44,00,00,44,8b,c2,8b,c1,33,d2,41,f7,f0,8b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B720h long mod64i(long x, long y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8,rdx                    ; Mov | Mov_r64_rm64 | encoding() = 4c 8b c2 (3 bytes)
0008h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
000bh cqo                           ; Cqo | Cqo | encoding() = 48 99 (2 bytes)
000dh idiv r8                       ; Idiv | Idiv_rm64 | encoding() = 49 f7 f8 (3 bytes)
0010h mov rax,rdx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c2 (3 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B733h                       ; {0f,1f,44,00,00,4c,8b,c2,48,8b,c1,48,99,49,f7,f8,48,8b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B750h ulong mod64u(ulong x, ulong y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8,rdx                    ; Mov | Mov_r64_rm64 | encoding() = 4c 8b c2 (3 bytes)
0008h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
000bh xor edx,edx                   ; Xor | Xor_r32_rm32 | encoding() = 33 d2 (2 bytes)
000dh div r8                        ; Div | Div_rm64 | encoding() = 49 f7 f0 (3 bytes)
0010h mov rax,rdx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c2 (3 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B763h                       ; {0f,1f,44,00,00,4c,8b,c2,48,8b,c1,33,d2,49,f7,f0,48,8b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B780h float mod32f(float x, float y)
0000h sub rsp,28h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 28 (4 bytes)
0004h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0007h call 7FFCC80B3690h            ; Call | Call_rel32_64 | encoding() = e8 04 7f c3 5f (5 bytes)
000ch nop                           ; Nop | Nopd | encoding() = 90 (1 bytes)
000dh add rsp,28h                   ; Add | Add_rm64_imm8 | encoding() = 48 83 c4 28 (4 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B791h                       ; {48,83,ec,28,c5,f8,77,e8,04,7f,c3,5f,90,48,83,c4,28,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B7B0h double mod64f(double x, double y)
0000h sub rsp,28h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 28 (4 bytes)
0004h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0007h call 7FFCC80B3600h            ; Call | Call_rel32_64 | encoding() = e8 44 7e c3 5f (5 bytes)
000ch nop                           ; Nop | Nopd | encoding() = 90 (1 bytes)
000dh add rsp,28h                   ; Add | Add_rm64_imm8 | encoding() = 48 83 c4 28 (4 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B7C1h                       ; {48,83,ec,28,c5,f8,77,e8,44,7e,c3,5f,90,48,83,c4,28,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B7E0h byte or8u(byte x, byte y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh or eax,edx                    ; Or | Or_r32_rm32 | encoding() = 0b c2 (2 bytes)
000dh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B7F0h                       ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,0b,c2,0f,b6,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B810h sbyte or8i(sbyte x, sbyte y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rdx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be d2 (4 bytes)
000dh or eax,edx                    ; Or | Or_r32_rm32 | encoding() = 0b c2 (2 bytes)
000fh movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B823h                       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,d2,0b,c2,48,0f,be,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B840h short or16i(short x, short y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rdx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf d2 (4 bytes)
000dh or eax,edx                    ; Or | Or_r32_rm32 | encoding() = 0b c2 (2 bytes)
000fh movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B853h                       ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,d2,0b,c2,48,0f,bf,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B870h ushort or16u(ushort x, ushort y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh or eax,edx                    ; Or | Or_r32_rm32 | encoding() = 0b c2 (2 bytes)
000dh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B880h                       ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,0b,c2,0f,b7,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B8A0h int or32i(int x, int y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h or eax,edx                    ; Or | Or_r32_rm32 | encoding() = 0b c2 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B8A9h                       ; {0f,1f,44,00,00,8b,c1,0b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B8C0h uint or32u(uint x, uint y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h or eax,edx                    ; Or | Or_r32_rm32 | encoding() = 0b c2 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B8C9h                       ; {0f,1f,44,00,00,8b,c1,0b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B8E0h long or64i(long x, long y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h or rax,rdx                    ; Or | Or_r64_rm64 | encoding() = 48 0b c2 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B8EBh                       ; {0f,1f,44,00,00,48,8b,c1,48,0b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B900h ulong or64u(ulong x, ulong y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h or rax,rdx                    ; Or | Or_r64_rm64 | encoding() = 48 0b c2 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B90Bh                       ; {0f,1f,44,00,00,48,8b,c1,48,0b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B920h sbyte sub8i(sbyte x, sbyte y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rdx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be d2 (4 bytes)
000dh sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
000fh movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B933h                       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,d2,2b,c2,48,0f,be,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B950h byte sub8u(byte x, byte y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
000dh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B960h                       ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,2b,c2,0f,b6,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B980h short sub16i(short x, short y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rdx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf d2 (4 bytes)
000dh sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
000fh movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B993h                       ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,d2,2b,c2,48,0f,bf,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B9B0h ushort sub16u(ushort x, ushort y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
000dh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B9C0h                       ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,2b,c2,0f,b7,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847B9E0h int sub32i(int x, int y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847B9E9h                       ; {0f,1f,44,00,00,8b,c1,2b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BA00h uint sub32u(uint x, uint y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BA09h                       ; {0f,1f,44,00,00,8b,c1,2b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BA20h long sub64i(long x, long y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h sub rax,rdx                   ; Sub | Sub_r64_rm64 | encoding() = 48 2b c2 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BA2Bh                       ; {0f,1f,44,00,00,48,8b,c1,48,2b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BA40h ulong sub64u(ulong x, ulong y)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h sub rax,rdx                   ; Sub | Sub_r64_rm64 | encoding() = 48 2b c2 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BA4Bh                       ; {0f,1f,44,00,00,48,8b,c1,48,2b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BA60h float sub32f(float x, float y)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vsubss xmm0,xmm0,xmm1         ; Vsubss | VEX_Vsubss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 5c c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BA69h                       ; {c5,f8,77,66,90,c5,fa,5c,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BA80h double sub64f(double x, double y)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vsubsd xmm0,xmm0,xmm1         ; Vsubsd | VEX_Vsubsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 5c c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BA89h                       ; {c5,f8,77,66,90,c5,fb,5c,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BAA0h byte rotr8u(byte src, byte offset)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh mov ecx,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b ca (2 bytes)
000dh mov r8d,eax                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c0 (3 bytes)
0010h sar r8d,cl                    ; Sar | Sar_rm32_CL | encoding() = 41 d3 f8 (3 bytes)
0013h mov ecx,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b ca (2 bytes)
0015h neg ecx                       ; Neg | Neg_rm32 | encoding() = f7 d9 (2 bytes)
0017h add ecx,8                     ; Add | Add_rm32_imm8 | encoding() = 83 c1 08 (3 bytes)
001ah shl eax,cl                    ; Shl | Shl_rm32_CL | encoding() = d3 e0 (2 bytes)
001ch or eax,r8d                    ; Or | Or_r32_rm32 | encoding() = 41 0b c0 (3 bytes)
001fh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0022h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BAC2h                       ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,8b,ca,44,8b,c0,41,d3,f8,8b,ca,f7,d9,83,c1,08,d3,e0,41,0b,c0,0f,b6,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BAE0h ushort rotr16u(ushort src, ushort offset)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh mov ecx,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b ca (2 bytes)
000dh mov r8d,eax                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c0 (3 bytes)
0010h sar r8d,cl                    ; Sar | Sar_rm32_CL | encoding() = 41 d3 f8 (3 bytes)
0013h mov ecx,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b ca (2 bytes)
0015h neg ecx                       ; Neg | Neg_rm32 | encoding() = f7 d9 (2 bytes)
0017h add ecx,10h                   ; Add | Add_rm32_imm8 | encoding() = 83 c1 10 (3 bytes)
001ah shl eax,cl                    ; Shl | Shl_rm32_CL | encoding() = d3 e0 (2 bytes)
001ch or eax,r8d                    ; Or | Or_r32_rm32 | encoding() = 41 0b c0 (3 bytes)
001fh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0022h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BB02h                       ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,8b,ca,44,8b,c0,41,d3,f8,8b,ca,f7,d9,83,c1,10,d3,e0,41,0b,c0,0f,b7,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BB20h uint rotr32u(uint src, uint offset)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h mov ecx,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b ca (2 bytes)
0009h ror eax,cl                    ; Ror | Ror_rm32_CL | encoding() = d3 c8 (2 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BB2Bh                       ; {0f,1f,44,00,00,8b,c1,8b,ca,d3,c8,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BB40h ulong rotr64u(ulong src, ulong offset)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h mov ecx,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b ca (2 bytes)
000ah ror rax,cl                    ; Ror | Ror_rm64_CL | encoding() = 48 d3 c8 (3 bytes)
000dh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BB4Dh                       ; {0f,1f,44,00,00,48,8b,c1,8b,ca,48,d3,c8,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BB60h byte rotl8u(byte x, byte offset)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh mov ecx,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b ca (2 bytes)
000dh mov r8d,eax                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c0 (3 bytes)
0010h shl r8d,cl                    ; Shl | Shl_rm32_CL | encoding() = 41 d3 e0 (3 bytes)
0013h mov ecx,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b ca (2 bytes)
0015h neg ecx                       ; Neg | Neg_rm32 | encoding() = f7 d9 (2 bytes)
0017h add ecx,8                     ; Add | Add_rm32_imm8 | encoding() = 83 c1 08 (3 bytes)
001ah sar eax,cl                    ; Sar | Sar_rm32_CL | encoding() = d3 f8 (2 bytes)
001ch or eax,r8d                    ; Or | Or_r32_rm32 | encoding() = 41 0b c0 (3 bytes)
001fh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0022h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BB82h                       ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,8b,ca,44,8b,c0,41,d3,e0,8b,ca,f7,d9,83,c1,08,d3,f8,41,0b,c0,0f,b6,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BBA0h ushort rotl16u(ushort x, ushort offset)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh mov ecx,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b ca (2 bytes)
000dh mov r8d,eax                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c0 (3 bytes)
0010h shl r8d,cl                    ; Shl | Shl_rm32_CL | encoding() = 41 d3 e0 (3 bytes)
0013h mov ecx,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b ca (2 bytes)
0015h neg ecx                       ; Neg | Neg_rm32 | encoding() = f7 d9 (2 bytes)
0017h add ecx,10h                   ; Add | Add_rm32_imm8 | encoding() = 83 c1 10 (3 bytes)
001ah shr eax,cl                    ; Shr | Shr_rm32_CL | encoding() = d3 e8 (2 bytes)
001ch or eax,r8d                    ; Or | Or_r32_rm32 | encoding() = 41 0b c0 (3 bytes)
001fh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0022h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BBC2h                       ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,8b,ca,44,8b,c0,41,d3,e0,8b,ca,f7,d9,83,c1,10,d3,e8,41,0b,c0,0f,b7,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BBE0h uint rotl32u(uint x, uint offset)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h mov ecx,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b ca (2 bytes)
0009h rol eax,cl                    ; Rol | Rol_rm32_CL | encoding() = d3 c0 (2 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BBEBh                       ; {0f,1f,44,00,00,8b,c1,8b,ca,d3,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BC00h ulong rotl64u(ulong x, ulong offset)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h mov ecx,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b ca (2 bytes)
000ah rol rax,cl                    ; Rol | Rol_rm64_CL | encoding() = 48 d3 c0 (3 bytes)
000dh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BC0Dh                       ; {0f,1f,44,00,00,48,8b,c1,8b,ca,48,d3,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BC20h sbyte negate(sbyte src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h neg eax                       ; Neg | Neg_rm32 | encoding() = f7 d8 (2 bytes)
000bh movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
000fh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BC2Fh                       ; {0f,1f,44,00,00,48,0f,be,c1,f7,d8,48,0f,be,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BC40h byte negate(byte src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h not eax                       ; Not | Not_rm32 | encoding() = f7 d0 (2 bytes)
000ah inc eax                       ; Inc | Inc_rm32 | encoding() = ff c0 (2 bytes)
000ch movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
000fh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BC4Fh                       ; {0f,1f,44,00,00,0f,b6,c1,f7,d0,ff,c0,0f,b6,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BC60h short negate(short src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h neg eax                       ; Neg | Neg_rm32 | encoding() = f7 d8 (2 bytes)
000bh movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
000fh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BC6Fh                       ; {0f,1f,44,00,00,48,0f,bf,c1,f7,d8,48,0f,bf,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BC80h ushort negate(ushort src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h not eax                       ; Not | Not_rm32 | encoding() = f7 d0 (2 bytes)
000ah inc eax                       ; Inc | Inc_rm32 | encoding() = ff c0 (2 bytes)
000ch movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
000fh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BC8Fh                       ; {0f,1f,44,00,00,0f,b7,c1,f7,d0,ff,c0,0f,b7,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BCA0h int negate(int src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h neg eax                       ; Neg | Neg_rm32 | encoding() = f7 d8 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BCA9h                       ; {0f,1f,44,00,00,8b,c1,f7,d8,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BCC0h uint negate(uint src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h not eax                       ; Not | Not_rm32 | encoding() = f7 d0 (2 bytes)
0009h inc eax                       ; Inc | Inc_rm32 | encoding() = ff c0 (2 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BCCBh                       ; {0f,1f,44,00,00,8b,c1,f7,d0,ff,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BCE0h long negate(long src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h neg rax                       ; Neg | Neg_rm64 | encoding() = 48 f7 d8 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BCEBh                       ; {0f,1f,44,00,00,48,8b,c1,48,f7,d8,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BD00h ulong negate(ulong src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h not rax                       ; Not | Not_rm64 | encoding() = 48 f7 d0 (3 bytes)
000bh inc rax                       ; Inc | Inc_rm64 | encoding() = 48 ff c0 (3 bytes)
000eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BD0Eh                       ; {0f,1f,44,00,00,48,8b,c1,48,f7,d0,48,ff,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BD20h float negate(float src)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovss xmm1,dword ptr [7FFC6847BD38h]; Vmovss | VEX_Vmovss_xmm_m32 | encoding(VEX) = c5 fa 10 0d 0b 00 00 00 (8 bytes)
000dh vxorps xmm0,xmm0,xmm1         ; Vxorps | VEX_Vxorps_xmm_xmm_xmmm128 | encoding(VEX) = c5 f8 57 c1 (4 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BD31h                       ; {c5,f8,77,66,90,c5,fa,10,0d,0b,00,00,00,c5,f8,57,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BD50h double negate(double src)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovsd xmm1,qword ptr [7FFC6847BD68h]; Vmovsd | VEX_Vmovsd_xmm_m64 | encoding(VEX) = c5 fb 10 0d 0b 00 00 00 (8 bytes)
000dh vxorps xmm0,xmm0,xmm1         ; Vxorps | VEX_Vxorps_xmm_xmm_xmmm128 | encoding(VEX) = c5 f8 57 c1 (4 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BD61h                       ; {c5,f8,77,66,90,c5,fb,10,0d,0b,00,00,00,c5,f8,57,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BD80h sbyte inc(sbyte src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
000dh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BD8Dh                       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BDA0h byte inc(byte src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BDABh                       ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BDC0h short inc(short src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
000dh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BDCDh                       ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BDE0h ushort inc(ushort src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BDEBh                       ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BE00h int inc(int src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BE07h                       ; {0f,1f,44,00,00,8b,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BE20h uint inc(uint src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BE27h                       ; {0f,1f,44,00,00,8b,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BE40h long inc(long src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BE48h                       ; {0f,1f,44,00,00,48,8b,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BE60h ulong inc(ulong src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BE68h                       ; {0f,1f,44,00,00,48,8b,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BE80h float inc(float src)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BE85h                       ; {c5,f8,77,66,90,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC6847BEA0h double inc(double src)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC6847BEA5h                       ; {c5,f8,77,66,90,c3}
------------------------------------------------------------------------------------------------------------------------
