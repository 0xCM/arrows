# 2019-07-27 22:39:10:374
7FFC8A236D40h byte sub<byte>(byte lhs, byte rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
000dh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A236D50h                       ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,2b,c2,0f,b6,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A236D70h ushort sub<ushort>(ushort lhs, ushort rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
000dh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A236D80h                       ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,2b,c2,0f,b7,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A236DA0h uint sub<uint>(uint lhs, uint rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A236DA9h                       ; {0f,1f,44,00,00,8b,c1,2b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A236DC0h ulong sub<ulong>(ulong lhs, ulong rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h sub rax,rdx                   ; Sub | Sub_r64_rm64 | encoding() = 48 2b c2 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A236DCBh                       ; {0f,1f,44,00,00,48,8b,c1,48,2b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A236DE0h sbyte sub<sbyte>(sbyte lhs, sbyte rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rdx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be d2 (4 bytes)
000dh sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
000fh movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A236DF3h                       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,d2,2b,c2,48,0f,be,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A236E10h short sub<short>(short lhs, short rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rdx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf d2 (4 bytes)
000dh sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
000fh movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A236E23h                       ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,d2,2b,c2,48,0f,bf,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A236E40h int sub<int>(int lhs, int rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h sub eax,edx                   ; Sub | Sub_r32_rm32 | encoding() = 2b c2 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A236E49h                       ; {0f,1f,44,00,00,8b,c1,2b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A236E60h long sub<long>(long lhs, long rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h sub rax,rdx                   ; Sub | Sub_r64_rm64 | encoding() = 48 2b c2 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A236E6Bh                       ; {0f,1f,44,00,00,48,8b,c1,48,2b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237290h float sub<float>(float lhs, float rhs)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vsubss xmm0,xmm0,xmm1         ; Vsubss | VEX_Vsubss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 5c c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237299h                       ; {c5,f8,77,66,90,c5,fa,5c,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A2372B0h double sub<double>(double lhs, double rhs)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vsubsd xmm0,xmm0,xmm1         ; Vsubsd | VEX_Vsubsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 5c c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A2372B9h                       ; {c5,f8,77,66,90,c5,fb,5c,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A2372D0h byte add<byte>(byte lhs, byte rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000dh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A2372E0h                       ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,03,c2,0f,b6,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237300h ushort add<ushort>(ushort lhs, ushort rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000dh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237310h                       ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,03,c2,0f,b7,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237330h uint add<uint>(uint lhs, uint rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea eax,[rcx+rdx]             ; Lea | Lea_r32_m | encoding() = 8d 04 11 (3 bytes)
0008h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237338h                       ; {0f,1f,44,00,00,8d,04,11,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237350h ulong add<ulong>(ulong lhs, ulong rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea rax,[rcx+rdx]             ; Lea | Lea_r64_m | encoding() = 48 8d 04 11 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237359h                       ; {0f,1f,44,00,00,48,8d,04,11,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237370h sbyte add<sbyte>(sbyte lhs, sbyte rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rdx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be d2 (4 bytes)
000dh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000fh movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237383h                       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,d2,03,c2,48,0f,be,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A2373A0h short add<short>(short lhs, short rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rdx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf d2 (4 bytes)
000dh add eax,edx                   ; Add | Add_r32_rm32 | encoding() = 03 c2 (2 bytes)
000fh movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A2373B3h                       ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,d2,03,c2,48,0f,bf,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A2373D0h int add<int>(int lhs, int rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea eax,[rcx+rdx]             ; Lea | Lea_r32_m | encoding() = 8d 04 11 (3 bytes)
0008h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A2373D8h                       ; {0f,1f,44,00,00,8d,04,11,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A2373F0h long add<long>(long lhs, long rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea rax,[rcx+rdx]             ; Lea | Lea_r64_m | encoding() = 48 8d 04 11 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A2373F9h                       ; {0f,1f,44,00,00,48,8d,04,11,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237410h float add<float>(float lhs, float rhs)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vaddss xmm0,xmm0,xmm1         ; Vaddss | VEX_Vaddss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 58 c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237419h                       ; {c5,f8,77,66,90,c5,fa,58,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237430h double add<double>(double lhs, double rhs)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vaddsd xmm0,xmm0,xmm1         ; Vaddsd | VEX_Vaddsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 58 c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237439h                       ; {c5,f8,77,66,90,c5,fb,58,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237450h byte div<byte>(byte lhs, byte rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx ecx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 ca (3 bytes)
000bh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000ch idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
000eh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237461h                       ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,ca,99,f7,f9,0f,b6,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237480h ushort div<ushort>(ushort lhs, ushort rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx ecx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 ca (3 bytes)
000bh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000ch idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
000eh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237491h                       ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,ca,99,f7,f9,0f,b7,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A2374B0h uint div<uint>(uint lhs, uint rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8d,edx                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c2 (3 bytes)
0008h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
000ah xor edx,edx                   ; Xor | Xor_r32_rm32 | encoding() = 33 d2 (2 bytes)
000ch div r8d                       ; Div | Div_rm32 | encoding() = 41 f7 f0 (3 bytes)
000fh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A2374BFh                       ; {0f,1f,44,00,00,44,8b,c2,8b,c1,33,d2,41,f7,f0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A2374D0h ulong div<ulong>(ulong lhs, ulong rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8,rdx                    ; Mov | Mov_r64_rm64 | encoding() = 4c 8b c2 (3 bytes)
0008h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
000bh xor edx,edx                   ; Xor | Xor_r32_rm32 | encoding() = 33 d2 (2 bytes)
000dh div r8                        ; Div | Div_rm64 | encoding() = 49 f7 f0 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A2374E0h                       ; {0f,1f,44,00,00,4c,8b,c2,48,8b,c1,33,d2,49,f7,f0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237500h sbyte div<sbyte>(sbyte lhs, sbyte rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rcx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be ca (4 bytes)
000dh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000eh idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
0010h movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237514h                       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,ca,99,f7,f9,48,0f,be,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237530h short div<short>(short lhs, short rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rcx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf ca (4 bytes)
000dh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000eh idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
0010h movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237544h                       ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,ca,99,f7,f9,48,0f,bf,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237560h int div<int>(int lhs, int rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8d,edx                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c2 (3 bytes)
0008h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
000ah cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000bh idiv r8d                      ; Idiv | Idiv_rm32 | encoding() = 41 f7 f8 (3 bytes)
000eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23756Eh                       ; {0f,1f,44,00,00,44,8b,c2,8b,c1,99,41,f7,f8,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237580h long div<long>(long lhs, long rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8,rdx                    ; Mov | Mov_r64_rm64 | encoding() = 4c 8b c2 (3 bytes)
0008h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
000bh cqo                           ; Cqo | Cqo | encoding() = 48 99 (2 bytes)
000dh idiv r8                       ; Idiv | Idiv_rm64 | encoding() = 49 f7 f8 (3 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237590h                       ; {0f,1f,44,00,00,4c,8b,c2,48,8b,c1,48,99,49,f7,f8,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A2375B0h float div<float>(float lhs, float rhs)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vdivss xmm0,xmm0,xmm1         ; Vdivss | VEX_Vdivss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 5e c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A2375B9h                       ; {c5,f8,77,66,90,c5,fa,5e,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A2375D0h double div<double>(double lhs, double rhs)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vdivsd xmm0,xmm0,xmm1         ; Vdivsd | VEX_Vdivsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 5e c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A2375D9h                       ; {c5,f8,77,66,90,c5,fb,5e,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A2375F0h byte mod<byte>(byte lhs, byte rhs)
0000h push rax                      ; Push | Push_r64 | encoding() = 50 (1 bytes)
0001h nop dword ptr [rax]           ; Nop | Nop_rm32 | encoding() = 0f 1f 40 00 (4 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx ecx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 ca (3 bytes)
000bh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000ch idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
000eh mov [rsp+4],edx               ; Mov | Mov_rm32_r32 | encoding() = 89 54 24 04 (4 bytes)
0012h movzx eax,byte ptr [rsp+4]    ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 44 24 04 (5 bytes)
0017h add rsp,8                     ; Add | Add_rm64_imm8 | encoding() = 48 83 c4 08 (4 bytes)
001bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23760Bh                       ; {50,0f,1f,40,00,0f,b6,c1,0f,b6,ca,99,f7,f9,89,54,24,04,0f,b6,44,24,04,48,83,c4,08,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237620h ushort mod<ushort>(ushort lhs, ushort rhs)
0000h push rax                      ; Push | Push_r64 | encoding() = 50 (1 bytes)
0001h nop dword ptr [rax]           ; Nop | Nop_rm32 | encoding() = 0f 1f 40 00 (4 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx ecx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 ca (3 bytes)
000bh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000ch idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
000eh mov [rsp+4],edx               ; Mov | Mov_rm32_r32 | encoding() = 89 54 24 04 (4 bytes)
0012h movzx eax,word ptr [rsp+4]    ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 44 24 04 (5 bytes)
0017h add rsp,8                     ; Add | Add_rm64_imm8 | encoding() = 48 83 c4 08 (4 bytes)
001bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23763Bh                       ; {50,0f,1f,40,00,0f,b7,c1,0f,b7,ca,99,f7,f9,89,54,24,04,0f,b7,44,24,04,48,83,c4,08,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237650h uint mod<uint>(uint lhs, uint rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8d,edx                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c2 (3 bytes)
0008h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
000ah xor edx,edx                   ; Xor | Xor_r32_rm32 | encoding() = 33 d2 (2 bytes)
000ch div r8d                       ; Div | Div_rm32 | encoding() = 41 f7 f0 (3 bytes)
000fh mov eax,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c2 (2 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237661h                       ; {0f,1f,44,00,00,44,8b,c2,8b,c1,33,d2,41,f7,f0,8b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237A80h ulong mod<ulong>(ulong lhs, ulong rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8,rdx                    ; Mov | Mov_r64_rm64 | encoding() = 4c 8b c2 (3 bytes)
0008h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
000bh xor edx,edx                   ; Xor | Xor_r32_rm32 | encoding() = 33 d2 (2 bytes)
000dh div r8                        ; Div | Div_rm64 | encoding() = 49 f7 f0 (3 bytes)
0010h mov rax,rdx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c2 (3 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237A93h                       ; {0f,1f,44,00,00,4c,8b,c2,48,8b,c1,33,d2,49,f7,f0,48,8b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237AB0h sbyte mod<sbyte>(sbyte lhs, sbyte rhs)
0000h push rax                      ; Push | Push_r64 | encoding() = 50 (1 bytes)
0001h nop dword ptr [rax]           ; Nop | Nop_rm32 | encoding() = 0f 1f 40 00 (4 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rcx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be ca (4 bytes)
000dh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000eh idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
0010h mov [rsp+4],edx               ; Mov | Mov_rm32_r32 | encoding() = 89 54 24 04 (4 bytes)
0014h movsx rax,byte ptr [rsp+4]    ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be 44 24 04 (6 bytes)
001ah add rsp,8                     ; Add | Add_rm64_imm8 | encoding() = 48 83 c4 08 (4 bytes)
001eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237ACEh                       ; {50,0f,1f,40,00,48,0f,be,c1,48,0f,be,ca,99,f7,f9,89,54,24,04,48,0f,be,44,24,04,48,83,c4,08,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237AF0h short mod<short>(short lhs, short rhs)
0000h push rax                      ; Push | Push_r64 | encoding() = 50 (1 bytes)
0001h nop dword ptr [rax]           ; Nop | Nop_rm32 | encoding() = 0f 1f 40 00 (4 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rcx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf ca (4 bytes)
000dh cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000eh idiv ecx                      ; Idiv | Idiv_rm32 | encoding() = f7 f9 (2 bytes)
0010h mov [rsp+4],edx               ; Mov | Mov_rm32_r32 | encoding() = 89 54 24 04 (4 bytes)
0014h movsx rax,word ptr [rsp+4]    ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf 44 24 04 (6 bytes)
001ah add rsp,8                     ; Add | Add_rm64_imm8 | encoding() = 48 83 c4 08 (4 bytes)
001eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237B0Eh                       ; {50,0f,1f,40,00,48,0f,bf,c1,48,0f,bf,ca,99,f7,f9,89,54,24,04,48,0f,bf,44,24,04,48,83,c4,08,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237B30h int mod<int>(int lhs, int rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8d,edx                   ; Mov | Mov_r32_rm32 | encoding() = 44 8b c2 (3 bytes)
0008h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
000ah cdq                           ; Cdq | Cdq | encoding() = 99 (1 bytes)
000bh idiv r8d                      ; Idiv | Idiv_rm32 | encoding() = 41 f7 f8 (3 bytes)
000eh mov eax,edx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c2 (2 bytes)
0010h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237B40h                       ; {0f,1f,44,00,00,44,8b,c2,8b,c1,99,41,f7,f8,8b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237B60h long mod<long>(long lhs, long rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov r8,rdx                    ; Mov | Mov_r64_rm64 | encoding() = 4c 8b c2 (3 bytes)
0008h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
000bh cqo                           ; Cqo | Cqo | encoding() = 48 99 (2 bytes)
000dh idiv r8                       ; Idiv | Idiv_rm64 | encoding() = 49 f7 f8 (3 bytes)
0010h mov rax,rdx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c2 (3 bytes)
0013h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237B73h                       ; {0f,1f,44,00,00,4c,8b,c2,48,8b,c1,48,99,49,f7,f8,48,8b,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237B90h float mod<float>(float lhs, float rhs)
0000h sub rsp,28h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 28 (4 bytes)
0004h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0007h call 7FFCE97F3690h            ; Call | Call_rel32_64 | encoding() = e8 f4 ba 5b 5f (5 bytes)
000ch nop                           ; Nop | Nopd | encoding() = 90 (1 bytes)
000dh add rsp,28h                   ; Add | Add_rm64_imm8 | encoding() = 48 83 c4 28 (4 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237BA1h                       ; {48,83,ec,28,c5,f8,77,e8,f4,ba,5b,5f,90,48,83,c4,28,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237BC0h double mod<double>(double lhs, double rhs)
0000h sub rsp,28h                   ; Sub | Sub_rm64_imm8 | encoding() = 48 83 ec 28 (4 bytes)
0004h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0007h call 7FFCE97F3600h            ; Call | Call_rel32_64 | encoding() = e8 34 ba 5b 5f (5 bytes)
000ch nop                           ; Nop | Nopd | encoding() = 90 (1 bytes)
000dh add rsp,28h                   ; Add | Add_rm64_imm8 | encoding() = 48 83 c4 28 (4 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237BD1h                       ; {48,83,ec,28,c5,f8,77,e8,34,ba,5b,5f,90,48,83,c4,28,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237BF0h byte mul<byte>(byte lhs, byte rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h movzx edx,dl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 d2 (3 bytes)
000bh imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
000eh movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237C01h                       ; {0f,1f,44,00,00,0f,b6,c1,0f,b6,d2,0f,af,c2,0f,b6,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237C20h ushort mul<ushort>(ushort lhs, ushort rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h movzx edx,dx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 d2 (3 bytes)
000bh imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
000eh movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237C31h                       ; {0f,1f,44,00,00,0f,b7,c1,0f,b7,d2,0f,af,c2,0f,b7,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237C50h uint mul<uint>(uint lhs, uint rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
000ah ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237C5Ah                       ; {0f,1f,44,00,00,8b,c1,0f,af,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237C70h ulong mul<ulong>(ulong lhs, ulong rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h imul rax,rdx                  ; Imul | Imul_r64_rm64 | encoding() = 48 0f af c2 (4 bytes)
000ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237C7Ch                       ; {0f,1f,44,00,00,48,8b,c1,48,0f,af,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237C90h sbyte mul<sbyte>(sbyte lhs, sbyte rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h movsx rdx,dl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be d2 (4 bytes)
000dh imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
0010h movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237CA4h                       ; {0f,1f,44,00,00,48,0f,be,c1,48,0f,be,d2,0f,af,c2,48,0f,be,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237CC0h short mul<short>(short lhs, short rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h movsx rdx,dx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf d2 (4 bytes)
000dh imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
0010h movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
0014h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237CD4h                       ; {0f,1f,44,00,00,48,0f,bf,c1,48,0f,bf,d2,0f,af,c2,48,0f,bf,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237CF0h int mul<int>(int lhs, int rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h imul eax,edx                  ; Imul | Imul_r32_rm32 | encoding() = 0f af c2 (3 bytes)
000ah ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237CFAh                       ; {0f,1f,44,00,00,8b,c1,0f,af,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237D10h long mul<long>(long lhs, long rhs)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h imul rax,rdx                  ; Imul | Imul_r64_rm64 | encoding() = 48 0f af c2 (4 bytes)
000ch ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237D1Ch                       ; {0f,1f,44,00,00,48,8b,c1,48,0f,af,c2,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237D30h float mul<float>(float lhs, float rhs)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmulss xmm0,xmm0,xmm1         ; Vmulss | VEX_Vmulss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 59 c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237D39h                       ; {c5,f8,77,66,90,c5,fa,59,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A237D50h double mul<double>(double lhs, double rhs)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmulsd xmm0,xmm0,xmm1         ; Vmulsd | VEX_Vmulsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 59 c1 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A237D59h                       ; {c5,f8,77,66,90,c5,fb,59,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23A600h byte negate<byte>(byte src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h not eax                       ; Not | Not_rm32 | encoding() = f7 d0 (2 bytes)
000ah inc eax                       ; Inc | Inc_rm32 | encoding() = ff c0 (2 bytes)
000ch movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
000fh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23A60Fh                       ; {0f,1f,44,00,00,0f,b6,c1,f7,d0,ff,c0,0f,b6,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23A620h ushort negate<ushort>(ushort src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h not eax                       ; Not | Not_rm32 | encoding() = f7 d0 (2 bytes)
000ah inc eax                       ; Inc | Inc_rm32 | encoding() = ff c0 (2 bytes)
000ch movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
000fh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23A62Fh                       ; {0f,1f,44,00,00,0f,b7,c1,f7,d0,ff,c0,0f,b7,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23A640h uint negate<uint>(uint src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h not eax                       ; Not | Not_rm32 | encoding() = f7 d0 (2 bytes)
0009h inc eax                       ; Inc | Inc_rm32 | encoding() = ff c0 (2 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23A64Bh                       ; {0f,1f,44,00,00,8b,c1,f7,d0,ff,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23A660h ulong negate<ulong>(ulong src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h not rax                       ; Not | Not_rm64 | encoding() = 48 f7 d0 (3 bytes)
000bh inc rax                       ; Inc | Inc_rm64 | encoding() = 48 ff c0 (3 bytes)
000eh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23A66Eh                       ; {0f,1f,44,00,00,48,8b,c1,48,f7,d0,48,ff,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23A680h sbyte negate<sbyte>(sbyte src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h neg eax                       ; Neg | Neg_rm32 | encoding() = f7 d8 (2 bytes)
000bh movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
000fh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23A68Fh                       ; {0f,1f,44,00,00,48,0f,be,c1,f7,d8,48,0f,be,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23AAB0h short negate<short>(short src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h neg eax                       ; Neg | Neg_rm32 | encoding() = f7 d8 (2 bytes)
000bh movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
000fh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23AABFh                       ; {0f,1f,44,00,00,48,0f,bf,c1,f7,d8,48,0f,bf,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23AAD0h int negate<int>(int src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov eax,ecx                   ; Mov | Mov_r32_rm32 | encoding() = 8b c1 (2 bytes)
0007h neg eax                       ; Neg | Neg_rm32 | encoding() = f7 d8 (2 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23AAD9h                       ; {0f,1f,44,00,00,8b,c1,f7,d8,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23AAF0h long negate<long>(long src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h mov rax,rcx                   ; Mov | Mov_r64_rm64 | encoding() = 48 8b c1 (3 bytes)
0008h neg rax                       ; Neg | Neg_rm64 | encoding() = 48 f7 d8 (3 bytes)
000bh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23AAFBh                       ; {0f,1f,44,00,00,48,8b,c1,48,f7,d8,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23AB10h float negate<float>(float src)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovss xmm1,dword ptr [7FFC8A23AB28h]; Vmovss | VEX_Vmovss_xmm_m32 | encoding(VEX) = c5 fa 10 0d 0b 00 00 00 (8 bytes)
000dh vxorps xmm0,xmm0,xmm1         ; Vxorps | VEX_Vxorps_xmm_xmm_xmmm128 | encoding(VEX) = c5 f8 57 c1 (4 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23AB21h                       ; {c5,f8,77,66,90,c5,fa,10,0d,0b,00,00,00,c5,f8,57,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23AB40h double negate<double>(double src)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vmovsd xmm1,qword ptr [7FFC8A23AB58h]; Vmovsd | VEX_Vmovsd_xmm_m64 | encoding(VEX) = c5 fb 10 0d 0b 00 00 00 (8 bytes)
000dh vxorps xmm0,xmm0,xmm1         ; Vxorps | VEX_Vxorps_xmm_xmm_xmmm128 | encoding(VEX) = c5 f8 57 c1 (4 bytes)
0011h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23AB51h                       ; {c5,f8,77,66,90,c5,fb,10,0d,0b,00,00,00,c5,f8,57,c1,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23AB70h byte dec<byte>(byte src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h dec eax                       ; Dec | Dec_rm32 | encoding() = ff c8 (2 bytes)
000ah movzx eax,al                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c0 (3 bytes)
000dh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23AB7Dh                       ; {0f,1f,44,00,00,0f,b6,c1,ff,c8,0f,b6,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23AB90h ushort dec<ushort>(ushort src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h dec eax                       ; Dec | Dec_rm32 | encoding() = ff c8 (2 bytes)
000ah movzx eax,ax                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c0 (3 bytes)
000dh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23AB9Dh                       ; {0f,1f,44,00,00,0f,b7,c1,ff,c8,0f,b7,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23ABB0h uint dec<uint>(uint src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea eax,[rcx-1]               ; Lea | Lea_r32_m | encoding() = 8d 41 ff (3 bytes)
0008h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23ABB8h                       ; {0f,1f,44,00,00,8d,41,ff,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23ABD0h ulong dec<ulong>(ulong src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea rax,[rcx-1]               ; Lea | Lea_r64_m | encoding() = 48 8d 41 ff (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23ABD9h                       ; {0f,1f,44,00,00,48,8d,41,ff,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23ABF0h sbyte dec<sbyte>(sbyte src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h dec eax                       ; Dec | Dec_rm32 | encoding() = ff c8 (2 bytes)
000bh movsx rax,al                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c0 (4 bytes)
000fh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23ABFFh                       ; {0f,1f,44,00,00,48,0f,be,c1,ff,c8,48,0f,be,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23AC10h short dec<short>(short src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h dec eax                       ; Dec | Dec_rm32 | encoding() = ff c8 (2 bytes)
000bh movsx rax,ax                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c0 (4 bytes)
000fh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23AC1Fh                       ; {0f,1f,44,00,00,48,0f,bf,c1,ff,c8,48,0f,bf,c0,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23AC30h int dec<int>(int src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea eax,[rcx-1]               ; Lea | Lea_r32_m | encoding() = 8d 41 ff (3 bytes)
0008h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23AC38h                       ; {0f,1f,44,00,00,8d,41,ff,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23AC50h long dec<long>(long src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea rax,[rcx-1]               ; Lea | Lea_r64_m | encoding() = 48 8d 41 ff (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23AC59h                       ; {0f,1f,44,00,00,48,8d,41,ff,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23AC70h float dec<float>(float src)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vsubss xmm0,xmm0,dword ptr [7FFC8A23AC80h]; Vsubss | VEX_Vsubss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 5c 05 03 00 00 00 (8 bytes)
000dh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23AC7Dh                       ; {c5,f8,77,66,90,c5,fa,5c,05,03,00,00,00,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23ACA0h double dec<double>(double src)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vsubsd xmm0,xmm0,qword ptr [7FFC8A23ACB0h]; Vsubsd | VEX_Vsubsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 5c 05 03 00 00 00 (8 bytes)
000dh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23ACADh                       ; {c5,f8,77,66,90,c5,fb,5c,05,03,00,00,00,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23ACD0h byte inc<byte>(byte src)
0000h push rax                      ; Push | Push_r64 | encoding() = 50 (1 bytes)
0001h nop dword ptr [rax]           ; Nop | Nop_rm32 | encoding() = 0f 1f 40 00 (4 bytes)
0005h movzx eax,cl                  ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 c1 (3 bytes)
0008h inc eax                       ; Inc | Inc_rm32 | encoding() = ff c0 (2 bytes)
000ah mov [rsp+4],eax               ; Mov | Mov_rm32_r32 | encoding() = 89 44 24 04 (4 bytes)
000eh movzx eax,byte ptr [rsp+4]    ; Movzx | Movzx_r32_rm8 | encoding() = 0f b6 44 24 04 (5 bytes)
0013h add rsp,8                     ; Add | Add_rm64_imm8 | encoding() = 48 83 c4 08 (4 bytes)
0017h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23ACE7h                       ; {50,0f,1f,40,00,0f,b6,c1,ff,c0,89,44,24,04,0f,b6,44,24,04,48,83,c4,08,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23AD00h ushort inc<ushort>(ushort src)
0000h push rax                      ; Push | Push_r64 | encoding() = 50 (1 bytes)
0001h nop dword ptr [rax]           ; Nop | Nop_rm32 | encoding() = 0f 1f 40 00 (4 bytes)
0005h movzx eax,cx                  ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 c1 (3 bytes)
0008h inc eax                       ; Inc | Inc_rm32 | encoding() = ff c0 (2 bytes)
000ah mov [rsp+4],eax               ; Mov | Mov_rm32_r32 | encoding() = 89 44 24 04 (4 bytes)
000eh movzx eax,word ptr [rsp+4]    ; Movzx | Movzx_r32_rm16 | encoding() = 0f b7 44 24 04 (5 bytes)
0013h add rsp,8                     ; Add | Add_rm64_imm8 | encoding() = 48 83 c4 08 (4 bytes)
0017h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23AD17h                       ; {50,0f,1f,40,00,0f,b7,c1,ff,c0,89,44,24,04,0f,b7,44,24,04,48,83,c4,08,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23AD30h uint inc<uint>(uint src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea eax,[rcx+1]               ; Lea | Lea_r32_m | encoding() = 8d 41 01 (3 bytes)
0008h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23AD38h                       ; {0f,1f,44,00,00,8d,41,01,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23AD50h ulong inc<ulong>(ulong src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea rax,[rcx+1]               ; Lea | Lea_r64_m | encoding() = 48 8d 41 01 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23AD59h                       ; {0f,1f,44,00,00,48,8d,41,01,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23AD70h sbyte inc<sbyte>(sbyte src)
0000h push rax                      ; Push | Push_r64 | encoding() = 50 (1 bytes)
0001h nop dword ptr [rax]           ; Nop | Nop_rm32 | encoding() = 0f 1f 40 00 (4 bytes)
0005h movsx rax,cl                  ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be c1 (4 bytes)
0009h inc eax                       ; Inc | Inc_rm32 | encoding() = ff c0 (2 bytes)
000bh mov [rsp+4],eax               ; Mov | Mov_rm32_r32 | encoding() = 89 44 24 04 (4 bytes)
000fh movsx rax,byte ptr [rsp+4]    ; Movsx | Movsx_r64_rm8 | encoding() = 48 0f be 44 24 04 (6 bytes)
0015h add rsp,8                     ; Add | Add_rm64_imm8 | encoding() = 48 83 c4 08 (4 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23AD89h                       ; {50,0f,1f,40,00,48,0f,be,c1,ff,c0,89,44,24,04,48,0f,be,44,24,04,48,83,c4,08,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23ADA0h short inc<short>(short src)
0000h push rax                      ; Push | Push_r64 | encoding() = 50 (1 bytes)
0001h nop dword ptr [rax]           ; Nop | Nop_rm32 | encoding() = 0f 1f 40 00 (4 bytes)
0005h movsx rax,cx                  ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf c1 (4 bytes)
0009h inc eax                       ; Inc | Inc_rm32 | encoding() = ff c0 (2 bytes)
000bh mov [rsp+4],eax               ; Mov | Mov_rm32_r32 | encoding() = 89 44 24 04 (4 bytes)
000fh movsx rax,word ptr [rsp+4]    ; Movsx | Movsx_r64_rm16 | encoding() = 48 0f bf 44 24 04 (6 bytes)
0015h add rsp,8                     ; Add | Add_rm64_imm8 | encoding() = 48 83 c4 08 (4 bytes)
0019h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23ADB9h                       ; {50,0f,1f,40,00,48,0f,bf,c1,ff,c0,89,44,24,04,48,0f,bf,44,24,04,48,83,c4,08,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23ADD0h int inc<int>(int src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea eax,[rcx+1]               ; Lea | Lea_r32_m | encoding() = 8d 41 01 (3 bytes)
0008h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23ADD8h                       ; {0f,1f,44,00,00,8d,41,01,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23ADF0h long inc<long>(long src)
0000h nop dword ptr [rax+rax]       ; Nop | Nop_rm32 | encoding() = 0f 1f 44 00 00 (5 bytes)
0005h lea rax,[rcx+1]               ; Lea | Lea_r64_m | encoding() = 48 8d 41 01 (4 bytes)
0009h ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23ADF9h                       ; {0f,1f,44,00,00,48,8d,41,01,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23AE10h float inc<float>(float src)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vaddss xmm0,xmm0,dword ptr [7FFC8A23AE20h]; Vaddss | VEX_Vaddss_xmm_xmm_xmmm32 | encoding(VEX) = c5 fa 58 05 03 00 00 00 (8 bytes)
000dh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23AE1Dh                       ; {c5,f8,77,66,90,c5,fa,58,05,03,00,00,00,c3}
------------------------------------------------------------------------------------------------------------------------
7FFC8A23AE40h double inc<double>(double src)
0000h vzeroupper                    ; Vzeroupper | VEX_Vzeroupper | encoding(VEX) = c5 f8 77 (3 bytes)
0003h xchg ax,ax                    ; Nop | Nopw | encoding() = 66 90 (2 bytes)
0005h vaddsd xmm0,xmm0,qword ptr [7FFC8A23AE50h]; Vaddsd | VEX_Vaddsd_xmm_xmm_xmmm64 | encoding(VEX) = c5 fb 58 05 03 00 00 00 (8 bytes)
000dh ret                           ; Ret | Retnq | encoding() = c3 (1 bytes)
7FFC8A23AE4Dh                       ; {c5,f8,77,66,90,c5,fb,58,05,03,00,00,00,c3}
------------------------------------------------------------------------------------------------------------------------
