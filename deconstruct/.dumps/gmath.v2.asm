# 2019-07-27 04:33:03:205
byte sub<byte>(byte lhs, byte rhs)  ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,2b,c2,0f,b6,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
000dh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ushort sub<ushort>(ushort lhs, ushort rhs); {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,2b,c2,0f,b7,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
000dh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
uint sub<uint>(uint lhs, uint rhs)  ; {0f,1f,44,00,00,8b,c1,2b,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ulong sub<ulong>(ulong lhs, ulong rhs); {0f,1f,44,00,00,48,8b,c1,48,2b,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h sub rax,rdx                   ; Sub | Sub_r64_rm64 | encoding() = 48 2b c2 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
sbyte sub<sbyte>(sbyte lhs, sbyte rhs); {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,d2,2b,c2,48,0f,be,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rdx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be d2 (4 bytes)
000dh sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
000fh movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
short sub<short>(short lhs, short rhs); {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,d2,2b,c2,48,0f,bf,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rdx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf d2 (4 bytes)
000dh sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
000fh movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
int sub<int>(int lhs, int rhs)      ; {0f,1f,44,00,00,8b,c1,2b,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
long sub<long>(long lhs, long rhs)  ; {0f,1f,44,00,00,48,8b,c1,48,2b,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h sub rax,rdx                   ; Sub | Sub_r64_rm64 | encoding() = 48 2b c2 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
float sub<float>(float lhs, float rhs); {c5,f8,77,66,90,c5,fa,5c,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vsubss xmm0,xmm0,xmm1         ; Vsubss | VEX_Vsubss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 5c c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
double sub<double>(double lhs, double rhs); {c5,f8,77,66,90,c5,fb,5c,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vsubsd xmm0,xmm0,xmm1         ; Vsubsd | VEX_Vsubsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 5c c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byte mul<byte>(byte lhs, byte rhs)  ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,0f,af,c2,0f,b6,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
000eh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ushort mul<ushort>(ushort lhs, ushort rhs); {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,0f,af,c2,0f,b7,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
000eh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
uint mul<uint>(uint lhs, uint rhs)  ; {0f,1f,44,00,00,8b,c1,0f,af,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
000ah ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ulong mul<ulong>(ulong lhs, ulong rhs); {0f,1f,44,00,00,48,8b,c1,48,0f,af,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h imul rax,rdx                  ; Imul | Imul_r64_rm64 | encoding() = 48 0f af c2 (4 bytes)
000ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
sbyte mul<sbyte>(sbyte lhs, sbyte rhs); {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,d2,0f,af,c2,48,0f,be,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rdx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be d2 (4 bytes)
000dh imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
0010h movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
short mul<short>(short lhs, short rhs); {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,d2,0f,af,c2,48,0f,bf,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rdx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf d2 (4 bytes)
000dh imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
0010h movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
int mul<int>(int lhs, int rhs)      ; {0f,1f,44,00,00,8b,c1,0f,af,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
000ah ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
long mul<long>(long lhs, long rhs)  ; {0f,1f,44,00,00,48,8b,c1,48,0f,af,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h imul rax,rdx                  ; Imul | Imul_r64_rm64 | encoding() = 48 0f af c2 (4 bytes)
000ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
float mul<float>(float lhs, float rhs); {c5,f8,77,66,90,c5,fa,59,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmulss xmm0,xmm0,xmm1         ; Vmulss | VEX_Vmulss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 59 c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
double mul<double>(double lhs, double rhs); {c5,f8,77,66,90,c5,fb,59,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmulsd xmm0,xmm0,xmm1         ; Vmulsd | VEX_Vmulsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 59 c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byte add<byte>(byte lhs, byte rhs)  ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,03,c2,0f,b6,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000dh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ushort add<ushort>(ushort lhs, ushort rhs); {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,03,c2,0f,b7,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000dh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
uint add<uint>(uint lhs, uint rhs)  ; {0f,1f,44,00,00,8d,04,11,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea eax,[rcx+rdx]             ; Lea | Lea_r32_m | encoding() = 8d 04 11 (3 bytes)
0008h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ulong add<ulong>(ulong lhs, ulong rhs); {0f,1f,44,00,00,48,8d,04,11,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea rax,[rcx+rdx]             ; Lea | Lea_r64_m | encoding() = 48 8d 04 11 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
sbyte add<sbyte>(sbyte lhs, sbyte rhs); {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,d2,03,c2,48,0f,be,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rdx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be d2 (4 bytes)
000dh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000fh movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
short add<short>(short lhs, short rhs); {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,d2,03,c2,48,0f,bf,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rdx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf d2 (4 bytes)
000dh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000fh movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
int add<int>(int lhs, int rhs)      ; {0f,1f,44,00,00,8d,04,11,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea eax,[rcx+rdx]             ; Lea | Lea_r32_m | encoding() = 8d 04 11 (3 bytes)
0008h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
long add<long>(long lhs, long rhs)  ; {0f,1f,44,00,00,48,8d,04,11,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea rax,[rcx+rdx]             ; Lea | Lea_r64_m | encoding() = 48 8d 04 11 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
float add<float>(float lhs, float rhs); {c5,f8,77,66,90,c5,fa,58,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vaddss xmm0,xmm0,xmm1         ; Vaddss | VEX_Vaddss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 58 c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
double add<double>(double lhs, double rhs); {c5,f8,77,66,90,c5,fb,58,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vaddsd xmm0,xmm0,xmm1         ; Vaddsd | VEX_Vaddsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 58 c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byte div<byte>(byte lhs, byte rhs)  ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,ca,99,f7,f9,0f,b6,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx ecx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 ca (3 bytes)
000bh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000ch idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
000eh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ushort div<ushort>(ushort lhs, ushort rhs); {0f,1f,44,00,00,0f,b7,c1,0f,b7,ca,99,f7,f9,0f,b7,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx ecx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 ca (3 bytes)
000bh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000ch idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
000eh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
uint div<uint>(uint lhs, uint rhs)  ; {0f,1f,44,00,00,44,8b,c2,8b,c1,33,d2,41,f7,f0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8d,edx                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c2 (3 bytes)
0008h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
000ah xor edx,edx                   ; Xor | Xor_r32_rm32 | encoding() = 33 d2 (2 bytes)
000ch div r8d                       ; Div | Div_rm32 | encoding() = 41 f7 f0 (3 bytes)
000fh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ulong div<ulong>(ulong lhs, ulong rhs); {0f,1f,44,00,00,4c,8b,c2,48,8b,c1,33,d2,49,f7,f0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8,rdx                    ; Mov | Mov_r64_rm64 | encoding() = 4c 8b c2 (3 bytes)
0008h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
000bh xor edx,edx                   ; Xor | Xor_r32_rm32 | encoding() = 33 d2 (2 bytes)
000dh div r8                        ; Div | Div_rm64 | encoding() = 49 f7 f0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
sbyte div<sbyte>(sbyte lhs, sbyte rhs); {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,ca,99,f7,f9,48,0f,be,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rcx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be ca (4 bytes)
000dh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000eh idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
0010h movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
short div<short>(short lhs, short rhs); {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,ca,99,f7,f9,48,0f,bf,c0,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rcx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf ca (4 bytes)
000dh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000eh idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
0010h movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
int div<int>(int lhs, int rhs)      ; {0f,1f,44,00,00,44,8b,c2,8b,c1,99,41,f7,f8,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8d,edx                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c2 (3 bytes)
0008h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
000ah cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000bh idiv r8d                      ; Idiv | Idiv_rm32 | encoding() = 41 f7 f8 (3 bytes)
000eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
long div<long>(long lhs, long rhs)  ; {0f,1f,44,00,00,4c,8b,c2,48,8b,c1,48,99,49,f7,f8,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8,rdx                    ; Mov | Mov_r64_rm64 | encoding() = 4c 8b c2 (3 bytes)
0008h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
000bh cqo                           ; Cqo | Cqo | encoding() = 48 99 (2 bytes)
000dh idiv r8                       ; Idiv | Idiv_rm64 | encoding() = 49 f7 f8 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
float div<float>(float lhs, float rhs); {c5,f8,77,66,90,c5,fa,5e,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vdivss xmm0,xmm0,xmm1         ; Vdivss | VEX_Vdivss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 5e c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
double div<double>(double lhs, double rhs); {c5,f8,77,66,90,c5,fb,5e,c1,c3}
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vdivsd xmm0,xmm0,xmm1         ; Vdivsd | VEX_Vdivsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 5e c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
byte mod<byte>(byte lhs, byte rhs)  ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,ca,99,f7,f9,0f,b6,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx ecx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 ca (3 bytes)
000bh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000ch idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
000eh movzx eax,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c2 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ushort mod<ushort>(ushort lhs, ushort rhs); {0f,1f,44,00,00,0f,b7,c1,0f,b7,ca,99,f7,f9,0f,b7,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx ecx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 ca (3 bytes)
000bh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000ch idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
000eh movzx eax,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c2 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
uint mod<uint>(uint lhs, uint rhs)  ; {0f,1f,44,00,00,44,8b,c2,8b,c1,33,d2,41,f7,f0,8b,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8d,edx                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c2 (3 bytes)
0008h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
000ah xor edx,edx                   ; Xor | Xor_r32_rm32 | encoding() = 33 d2 (2 bytes)
000ch div r8d                       ; Div | Div_rm32 | encoding() = 41 f7 f0 (3 bytes)
000fh mov eax,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c2 (2 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
ulong mod<ulong>(ulong lhs, ulong rhs); {0f,1f,44,00,00,4c,8b,c2,48,8b,c1,33,d2,49,f7,f0,48,8b,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8,rdx                    ; Mov | Mov_r64_rm64 | encoding() = 4c 8b c2 (3 bytes)
0008h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
000bh xor edx,edx                   ; Xor | Xor_r32_rm32 | encoding() = 33 d2 (2 bytes)
000dh div r8                        ; Div | Div_rm64 | encoding() = 49 f7 f0 (3 bytes)
0010h mov rax,rdx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c2 (3 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
sbyte mod<sbyte>(sbyte lhs, sbyte rhs); {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,ca,99,f7,f9,48,0f,be,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rcx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be ca (4 bytes)
000dh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000eh idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
0010h movsx rax,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c2 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
short mod<short>(short lhs, short rhs); {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,ca,99,f7,f9,48,0f,bf,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rcx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf ca (4 bytes)
000dh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000eh idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
0010h movsx rax,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c2 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
int mod<int>(int lhs, int rhs)      ; {0f,1f,44,00,00,44,8b,c2,8b,c1,99,41,f7,f8,8b,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8d,edx                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c2 (3 bytes)
0008h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
000ah cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000bh idiv r8d                      ; Idiv | Idiv_rm32 | encoding() = 41 f7 f8 (3 bytes)
000eh mov eax,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c2 (2 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
long mod<long>(long lhs, long rhs)  ; {0f,1f,44,00,00,4c,8b,c2,48,8b,c1,48,99,49,f7,f8,48,8b,c2,c3}
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8,rdx                    ; Mov | Mov_r64_rm64 | encoding() = 4c 8b c2 (3 bytes)
0008h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
000bh cqo                           ; Cqo | Cqo | encoding() = 48 99 (2 bytes)
000dh idiv r8                       ; Idiv | Idiv_rm64 | encoding() = 49 f7 f8 (3 bytes)
0010h mov rax,rdx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c2 (3 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
float mod<float>(float lhs, float rhs); {48,83,ec,28,c5,f8,77,e8,44,d8,77,5f,90,48,83,c4,28,c3}
0000h sub rsp,28h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 28 (4 bytes)
0004h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0007h call 7FFCE6443690h            ; Call | Call_rel32_64 | encoding() = e8 44 d8 77 5f (5 bytes)
000ch nop                           ; Nop | Nopd | encoding() = 90 (1 bytes)
000dh add rsp,28h                   ; Add | Add_rm64_imm8 | encoding() = 48 83 c4 28 (4 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
double mod<double>(double lhs, double rhs); {48,83,ec,28,c5,f8,77,e8,84,d7,77,5f,90,48,83,c4,28,c3}
0000h sub rsp,28h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 28 (4 bytes)
0004h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0007h call 7FFCE6443600h            ; Call | Call_rel32_64 | encoding() = e8 84 d7 77 5f (5 bytes)
000ch nop                           ; Nop | Nopd | encoding() = 90 (1 bytes)
000dh add rsp,28h                   ; Add | Add_rm64_imm8 | encoding() = 48 83 c4 28 (4 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)

------------------------------------------------------------------------------------------------------------------------
