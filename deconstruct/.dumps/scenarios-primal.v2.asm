# 2019-07-27 04:33:02:028
sbyte add8i(sbyte x, sbyte y)       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,d2,03,c2,48,0f,be,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rdx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be d2 (4 bytes)
000dh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000fh movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byte add8u(byte x, byte y)          ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,03,c2,0f,b6,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000dh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
short add16i(short x, short y)      ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,d2,03,c2,48,0f,bf,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rdx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf d2 (4 bytes)
000dh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000fh movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ushort add16u(ushort x, ushort y)   ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,03,c2,0f,b7,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000dh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
int add32i(int x, int y)            ; {0f,1f,44,00,00,8d,04,11,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea eax,[rcx+rdx]             ; Lea | Lea_r32_m | encoding() = 8d 04 11 (3 bytes)
0008h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
uint add32u(uint x, uint y)         ; {0f,1f,44,00,00,8d,04,11,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea eax,[rcx+rdx]             ; Lea | Lea_r32_m | encoding() = 8d 04 11 (3 bytes)
0008h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
long add64i(long x, long y)         ; {0f,1f,44,00,00,48,8d,04,11,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea rax,[rcx+rdx]             ; Lea | Lea_r64_m | encoding() = 48 8d 04 11 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ulong add64u(ulong x, ulong y)      ; {0f,1f,44,00,00,48,8d,04,11,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea rax,[rcx+rdx]             ; Lea | Lea_r64_m | encoding() = 48 8d 04 11 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
float add32f(float x, float y)      ; {c5,f8,77,66,90,c5,fa,58,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vaddss xmm0,xmm0,xmm1         ; Vaddss | VEX_Vaddss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 58 c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
double add64f(double x, double y)   ; {c5,f8,77,66,90,c5,fb,58,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vaddsd xmm0,xmm0,xmm1         ; Vaddsd | VEX_Vaddsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 58 c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byte and8u(byte x, byte y)          ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,23,c2,0f,b6,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh and eax,edx                   ; And | And_r32_rm32 | encoding() = 23 c2 (2 bytes)
000dh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
sbyte and8i(sbyte x, sbyte y)       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,d2,23,c2,48,0f,be,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rdx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be d2 (4 bytes)
000dh and eax,edx                   ; And | And_r32_rm32 | encoding() = 23 c2 (2 bytes)
000fh movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
short and16i(short x, short y)      ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,d2,23,c2,48,0f,bf,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rdx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf d2 (4 bytes)
000dh and eax,edx                   ; And | And_r32_rm32 | encoding() = 23 c2 (2 bytes)
000fh movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ushort and16u(ushort x, ushort y)   ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,23,c2,0f,b7,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh and eax,edx                   ; And | And_r32_rm32 | encoding() = 23 c2 (2 bytes)
000dh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
int and32i(int x, int y)            ; {0f,1f,44,00,00,8b,c1,23,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h and eax,edx                   ; And | And_r32_rm32 | encoding() = 23 c2 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
uint and32u(uint x, uint y)         ; {0f,1f,44,00,00,8b,c1,23,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h and eax,edx                   ; And | And_r32_rm32 | encoding() = 23 c2 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
long and64i(long x, long y)         ; {0f,1f,44,00,00,48,8b,c1,48,23,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h and rax,rdx                   ; And | And_r64_rm64 | encoding() = 48 23 c2 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ulong and64u(ulong x, ulong y)      ; {0f,1f,44,00,00,48,8b,c1,48,23,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h and rax,rdx                   ; And | And_r64_rm64 | encoding() = 48 23 c2 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
sbyte div8i(sbyte x, sbyte y)       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,ca,99,f7,f9,48,0f,be,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rcx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be ca (4 bytes)
000dh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000eh idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
0010h movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byte div8u(byte x, byte y)          ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,ca,99,f7,f9,0f,b6,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx ecx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 ca (3 bytes)
000bh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000ch idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
000eh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
short div16i(short x, short y)      ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,ca,99,f7,f9,48,0f,bf,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rcx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf ca (4 bytes)
000dh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000eh idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
0010h movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ushort div16u(ushort x, ushort y)   ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,ca,99,f7,f9,0f,b7,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx ecx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 ca (3 bytes)
000bh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000ch idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
000eh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
int div32i(int x, int y)            ; {0f,1f,44,00,00,44,8b,c2,8b,c1,99,41,f7,f8,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8d,edx                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c2 (3 bytes)
0008h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
000ah cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000bh idiv r8d                      ; Idiv | Idiv_rm32 | encoding() = 41 f7 f8 (3 bytes)
000eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
uint div32u(uint x, uint y)         ; {0f,1f,44,00,00,44,8b,c2,8b,c1,33,d2,41,f7,f0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8d,edx                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c2 (3 bytes)
0008h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
000ah xor edx,edx                   ; Xor | Xor_r32_rm32 | encoding() = 33 d2 (2 bytes)
000ch div r8d                       ; Div | Div_rm32 | encoding() = 41 f7 f0 (3 bytes)
000fh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
long div64i(long x, long y)         ; {0f,1f,44,00,00,4c,8b,c2,48,8b,c1,48,99,49,f7,f8,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8,rdx                    ; Mov | Mov_r64_rm64 | encoding() = 4c 8b c2 (3 bytes)
0008h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
000bh cqo                           ; Cqo | Cqo | encoding() = 48 99 (2 bytes)
000dh idiv r8                       ; Idiv | Idiv_rm64 | encoding() = 49 f7 f8 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ulong div64u(ulong x, ulong y)      ; {0f,1f,44,00,00,4c,8b,c2,48,8b,c1,33,d2,49,f7,f0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8,rdx                    ; Mov | Mov_r64_rm64 | encoding() = 4c 8b c2 (3 bytes)
0008h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
000bh xor edx,edx                   ; Xor | Xor_r32_rm32 | encoding() = 33 d2 (2 bytes)
000dh div r8                        ; Div | Div_rm64 | encoding() = 49 f7 f0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
float div32f(float x, float y)      ; {c5,f8,77,66,90,c5,fa,5e,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vdivss xmm0,xmm0,xmm1         ; Vdivss | VEX_Vdivss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 5e c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
double div64f(double x, double y)   ; {c5,f8,77,66,90,c5,fb,5e,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vdivsd xmm0,xmm0,xmm1         ; Vdivsd | VEX_Vdivsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 5e c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
sbyte mul8i(sbyte x, sbyte y)       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,d2,0f,af,c2,48,0f,be,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rdx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be d2 (4 bytes)
000dh imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
0010h movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byte mul8u(byte x, byte y)          ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,0f,af,c2,0f,b6,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
000eh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
short mul16i(short x, short y)      ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,d2,0f,af,c2,48,0f,bf,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rdx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf d2 (4 bytes)
000dh imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
0010h movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ushort mul16u(ushort x, ushort y)   ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,0f,af,c2,0f,b7,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
000eh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
int mul32i(int x, int y)            ; {0f,1f,44,00,00,8b,c1,0f,af,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
000ah ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
uint mul32u(uint x, uint y)         ; {0f,1f,44,00,00,8b,c1,0f,af,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
000ah ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
long mul64i(long x, long y)         ; {0f,1f,44,00,00,48,8b,c1,48,0f,af,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h imul rax,rdx                  ; Imul | Imul_r64_rm64 | encoding() = 48 0f af c2 (4 bytes)
000ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ulong mul64u(ulong x, ulong y)      ; {0f,1f,44,00,00,48,8b,c1,48,0f,af,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h imul rax,rdx                  ; Imul | Imul_r64_rm64 | encoding() = 48 0f af c2 (4 bytes)
000ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
float mul32f(float x, float y)      ; {c5,f8,77,66,90,c5,fa,59,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmulss xmm0,xmm0,xmm1         ; Vmulss | VEX_Vmulss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 59 c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
double mul64f(double x, double y)   ; {c5,f8,77,66,90,c5,fb,59,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmulsd xmm0,xmm0,xmm1         ; Vmulsd | VEX_Vmulsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 59 c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byte or8u(byte x, byte y)           ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,0b,c2,0f,b6,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh or eax,edx                    ; Or | Or_r32_rm32 | encoding() = 0b c2 (2 bytes)
000dh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
sbyte or8i(sbyte x, sbyte y)        ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,d2,0b,c2,48,0f,be,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rdx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be d2 (4 bytes)
000dh or eax,edx                    ; Or | Or_r32_rm32 | encoding() = 0b c2 (2 bytes)
000fh movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
short or16i(short x, short y)       ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,d2,0b,c2,48,0f,bf,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rdx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf d2 (4 bytes)
000dh or eax,edx                    ; Or | Or_r32_rm32 | encoding() = 0b c2 (2 bytes)
000fh movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ushort or16u(ushort x, ushort y)    ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,0b,c2,0f,b7,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh or eax,edx                    ; Or | Or_r32_rm32 | encoding() = 0b c2 (2 bytes)
000dh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
int or32i(int x, int y)             ; {0f,1f,44,00,00,8b,c1,0b,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h or eax,edx                    ; Or | Or_r32_rm32 | encoding() = 0b c2 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
uint or32u(uint x, uint y)          ; {0f,1f,44,00,00,8b,c1,0b,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h or eax,edx                    ; Or | Or_r32_rm32 | encoding() = 0b c2 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
long or64i(long x, long y)          ; {0f,1f,44,00,00,48,8b,c1,48,0b,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h or rax,rdx                    ; Or | Or_r64_rm64 | encoding() = 48 0b c2 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ulong or64u(ulong x, ulong y)       ; {0f,1f,44,00,00,48,8b,c1,48,0b,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h or rax,rdx                    ; Or | Or_r64_rm64 | encoding() = 48 0b c2 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
sbyte sub8i(sbyte x, sbyte y)       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,d2,2b,c2,48,0f,be,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rdx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be d2 (4 bytes)
000dh sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
000fh movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byte sub8u(byte x, byte y)          ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,2b,c2,0f,b6,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
000dh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
short sub16i(short x, short y)      ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,d2,2b,c2,48,0f,bf,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rdx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf d2 (4 bytes)
000dh sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
000fh movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ushort sub16u(ushort x, ushort y)   ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,2b,c2,0f,b7,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
000dh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
int sub32i(int x, int y)            ; {0f,1f,44,00,00,8b,c1,2b,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
uint sub32u(uint x, uint y)         ; {0f,1f,44,00,00,8b,c1,2b,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
long sub64i(long x, long y)         ; {0f,1f,44,00,00,48,8b,c1,48,2b,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h sub rax,rdx                   ; Sub | Sub_r64_rm64 | encoding() = 48 2b c2 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ulong sub64u(ulong x, ulong y)      ; {0f,1f,44,00,00,48,8b,c1,48,2b,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h sub rax,rdx                   ; Sub | Sub_r64_rm64 | encoding() = 48 2b c2 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
float sub32f(float x, float y)      ; {c5,f8,77,66,90,c5,fa,5c,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vsubss xmm0,xmm0,xmm1         ; Vsubss | VEX_Vsubss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 5c c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
double sub64f(double x, double y)   ; {c5,f8,77,66,90,c5,fb,5c,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vsubsd xmm0,xmm0,xmm1         ; Vsubsd | VEX_Vsubsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 5c c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byte rotr8u(byte src, byte offset)  ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,8b,ca,44,8b,c0,41,d3,f8,8b,ca,f7,d9,83,c1,08,d3,e0,41,0b,c0,0f,b6,c0,c3}
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

------------------------------------------------------------------------------------------------------------------------
ushort rotr16u(ushort src, ushort offset); {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,8b,ca,44,8b,c0,41,d3,f8,8b,ca,f7,d9,83,c1,10,d3,e0,41,0b,c0,0f,b7,c0,c3}
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

------------------------------------------------------------------------------------------------------------------------
uint rotr32u(uint src, uint offset) ; {0f,1f,44,00,00,8b,c1,8b,ca,d3,c8,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h mov ecx,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b ca (2 bytes)
0009h ror eax,cl                    ; Ror | Ror_rm32_CL | encoding() = d3 c8 (2 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ulong rotr64u(ulong src, ulong offset); {0f,1f,44,00,00,48,8b,c1,8b,ca,48,d3,c8,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h mov ecx,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b ca (2 bytes)
000ah ror rax,cl                    ; Ror | Ror_rm64_CL | encoding() = 48 d3 c8 (3 bytes)
000dh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byte rotl8u(byte x, byte offset)    ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,8b,ca,44,8b,c0,41,d3,e0,8b,ca,f7,d9,83,c1,08,d3,f8,41,0b,c0,0f,b6,c0,c3}
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

------------------------------------------------------------------------------------------------------------------------
ushort rotl16u(ushort x, ushort offset); {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,8b,ca,44,8b,c0,41,d3,e0,8b,ca,f7,d9,83,c1,10,d3,e8,41,0b,c0,0f,b7,c0,c3}
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

------------------------------------------------------------------------------------------------------------------------
uint rotl32u(uint x, uint offset)   ; {0f,1f,44,00,00,8b,c1,8b,ca,d3,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h mov ecx,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b ca (2 bytes)
0009h rol eax,cl                    ; Rol | Rol_rm32_CL | encoding() = d3 c0 (2 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ulong rotl64u(ulong x, ulong offset); {0f,1f,44,00,00,48,8b,c1,8b,ca,48,d3,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h mov ecx,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b ca (2 bytes)
000ah rol rax,cl                    ; Rol | Rol_rm64_CL | encoding() = 48 d3 c0 (3 bytes)
000dh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void divrem32i(int x, int y, byref Int32 q, byref Int32 r); 
; {0f,1f,44,00,00,44,8b,d2,8b,c1,99,41,f7,fa,41,89,00,41,89,11,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r10d,edx                  ; Mov | Mov_r32_rm32 | encoding() = 44 8b d2 (3 bytes)
0008h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
000ah cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000bh idiv r10d                     ; Idiv | Idiv_rm32 | encoding() = 41 f7 fa (3 bytes)
000eh mov [r8],eax                  ; Mov | Mov_rm32_r32 | encoding() = 41 89 00 (3 bytes)
0017h mov [r9],edx                  ; Mov | Mov_rm32_r32 | encoding() = 41 89 11 (3 bytes)
001ah ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
void divrem64i(long x, long y, byref Int64 q, byref Int64 r); {0f,1f,44,00,00,4c,8b,d2,48,8b,c1,48,99,49,f7,fa,49,89,00,48,8b,c1,48,99,49,f7,fa,49,89,11,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r10,rdx                   ; Mov | Mov_r64_rm64 | encoding() = 4c 8b d2 (3 bytes)
0008h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
000bh cqo                           ; Cqo | Cqo | encoding() = 48 99 (2 bytes)
000dh idiv r10                      ; Idiv | Idiv_rm64 | encoding() = 49 f7 fa (3 bytes)
0010h mov [r8],rax                  ; Mov | Mov_rm64_r64 | encoding() = 49 89 00 (3 bytes)
0013h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0016h cqo                           ; Cqo | Cqo | encoding() = 48 99 (2 bytes)
0018h idiv r10                      ; Idiv | Idiv_rm64 | encoding() = 49 f7 fa (3 bytes)
001bh mov [r9],rdx                  ; Mov | Mov_rm64_r64 | encoding() = 49 89 11 (3 bytes)
001eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ValueTuple<ulong,ulong> divrem64u(ulong x, ulong y); {0f,1f,44,00,00,4c,8b,ca,49,8b,c1,33,d2,49,f7,f0,4c,8b,d0,49,8b,c1,33,d2,49,f7,f0,4c,89,11,48,89,51,08,48,8b,c1,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r9,rdx                    ; Mov | Mov_r64_rm64 | encoding() = 4c 8b ca (3 bytes)
0008h mov rax,r9                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c1 (3 bytes)
000bh xor edx,edx                   ; Xor | Xor_r32_rm32 | encoding() = 33 d2 (2 bytes)
000dh div r8                        ; Div | Div_rm64 | encoding() = 49 f7 f0 (3 bytes)
0010h mov r10,rax                   ; Mov | Mov_r64_rm64 | encoding() = 4c 8b d0 (3 bytes)
0013h mov rax,r9                    ; Mov | Mov_r64_rm64 | encoding() = 49 8b c1 (3 bytes)
0016h xor edx,edx                   ; Xor | Xor_r32_rm32 | encoding() = 33 d2 (2 bytes)
0018h div r8                        ; Div | Div_rm64 | encoding() = 49 f7 f0 (3 bytes)
001bh mov [rcx],r10                 ; Mov | Mov_rm64_r64 | encoding() = 4c 89 11 (3 bytes)
001eh mov [rcx+8],rdx               ; Mov | Mov_rm64_r64 | encoding() = 48 89 51 08 (4 bytes)
0022h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0025h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
