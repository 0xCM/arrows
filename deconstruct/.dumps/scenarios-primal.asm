# 2019-07-27 03:27:11:940
7FFC86DAB220h sbyte add8i(sbyte x, sbyte y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xd2, 0x03, 0xc2, 0x48, 0x0f, 0xbe, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB220h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c1} (4 bytes)
0009h  movsx rdx,dl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,d2} (4 bytes)
000dh  add eax,edx   ; opcode := Add_r32_rm32 | encoded := {03,c2} (2 bytes)
000fh  movsx rax,al   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c0} (4 bytes)
0013h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB220h ---------------------------------------------------------------------------------------------

7FFC86DAB250h byte add8u(byte x, byte y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xd2, 0x03, 0xc2, 0x0f, 0xb6, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB250h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c1} (3 bytes)
0008h  movzx edx,dl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,d2} (3 bytes)
000bh  add eax,edx   ; opcode := Add_r32_rm32 | encoded := {03,c2} (2 bytes)
000dh  movzx eax,al   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c0} (3 bytes)
0010h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB250h ---------------------------------------------------------------------------------------------

7FFC86DAB280h short add16i(short x, short y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbf, 0xc1, 0x48, 0x0f, 0xbf, 0xd2, 0x03, 0xc2, 0x48, 0x0f, 0xbf, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB280h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c1} (4 bytes)
0009h  movsx rdx,dx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,d2} (4 bytes)
000dh  add eax,edx   ; opcode := Add_r32_rm32 | encoded := {03,c2} (2 bytes)
000fh  movsx rax,ax   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c0} (4 bytes)
0013h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB280h ---------------------------------------------------------------------------------------------

7FFC86DAB2B0h ushort add16u(ushort x, ushort y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xd2, 0x03, 0xc2, 0x0f, 0xb7, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB2B0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c1} (3 bytes)
0008h  movzx edx,dx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,d2} (3 bytes)
000bh  add eax,edx   ; opcode := Add_r32_rm32 | encoded := {03,c2} (2 bytes)
000dh  movzx eax,ax   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c0} (3 bytes)
0010h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB2B0h ---------------------------------------------------------------------------------------------

7FFC86DAB2E0h int add32i(int x, int y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8d, 0x04, 0x11, 0xc3}
asm-body-begin 7FFC86DAB2E0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  lea eax,[rcx+rdx]   ; opcode := Lea_r32_m | encoded := {8d,04,11} (3 bytes)
0008h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB2E0h ---------------------------------------------------------------------------------------------

7FFC86DAB300h uint add32u(uint x, uint y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8d, 0x04, 0x11, 0xc3}
asm-body-begin 7FFC86DAB300h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  lea eax,[rcx+rdx]   ; opcode := Lea_r32_m | encoded := {8d,04,11} (3 bytes)
0008h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB300h ---------------------------------------------------------------------------------------------

7FFC86DAB320h long add64i(long x, long y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8d, 0x04, 0x11, 0xc3}
asm-body-begin 7FFC86DAB320h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  lea rax,[rcx+rdx]   ; opcode := Lea_r64_m | encoded := {48,8d,04,11} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB320h ---------------------------------------------------------------------------------------------

7FFC86DAB340h ulong add64u(ulong x, ulong y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8d, 0x04, 0x11, 0xc3}
asm-body-begin 7FFC86DAB340h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  lea rax,[rcx+rdx]   ; opcode := Lea_r64_m | encoded := {48,8d,04,11} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB340h ---------------------------------------------------------------------------------------------

7FFC86DAB360h float add32f(float x, float y)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfa, 0x58, 0xc1, 0xc3}
asm-body-begin 7FFC86DAB360h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vaddss xmm0,xmm0,xmm1   ; opcode := VEX_Vaddss_xmm_xmm_xmmm32 (VEX encoded) | encoded := {c5,fa,58,c1} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB360h ---------------------------------------------------------------------------------------------

7FFC86DAB380h double add64f(double x, double y)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfb, 0x58, 0xc1, 0xc3}
asm-body-begin 7FFC86DAB380h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vaddsd xmm0,xmm0,xmm1   ; opcode := VEX_Vaddsd_xmm_xmm_xmmm64 (VEX encoded) | encoded := {c5,fb,58,c1} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB380h ---------------------------------------------------------------------------------------------

7FFC86DAB3A0h byte and8u(byte x, byte y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xd2, 0x23, 0xc2, 0x0f, 0xb6, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB3A0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c1} (3 bytes)
0008h  movzx edx,dl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,d2} (3 bytes)
000bh  and eax,edx   ; opcode := And_r32_rm32 | encoded := {23,c2} (2 bytes)
000dh  movzx eax,al   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c0} (3 bytes)
0010h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB3A0h ---------------------------------------------------------------------------------------------

7FFC86DAB3D0h sbyte and8i(sbyte x, sbyte y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xd2, 0x23, 0xc2, 0x48, 0x0f, 0xbe, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB3D0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c1} (4 bytes)
0009h  movsx rdx,dl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,d2} (4 bytes)
000dh  and eax,edx   ; opcode := And_r32_rm32 | encoded := {23,c2} (2 bytes)
000fh  movsx rax,al   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c0} (4 bytes)
0013h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB3D0h ---------------------------------------------------------------------------------------------

7FFC86DAB400h short and16i(short x, short y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbf, 0xc1, 0x48, 0x0f, 0xbf, 0xd2, 0x23, 0xc2, 0x48, 0x0f, 0xbf, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB400h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c1} (4 bytes)
0009h  movsx rdx,dx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,d2} (4 bytes)
000dh  and eax,edx   ; opcode := And_r32_rm32 | encoded := {23,c2} (2 bytes)
000fh  movsx rax,ax   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c0} (4 bytes)
0013h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB400h ---------------------------------------------------------------------------------------------

7FFC86DAB430h ushort and16u(ushort x, ushort y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xd2, 0x23, 0xc2, 0x0f, 0xb7, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB430h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c1} (3 bytes)
0008h  movzx edx,dx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,d2} (3 bytes)
000bh  and eax,edx   ; opcode := And_r32_rm32 | encoded := {23,c2} (2 bytes)
000dh  movzx eax,ax   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c0} (3 bytes)
0010h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB430h ---------------------------------------------------------------------------------------------

7FFC86DAB460h int and32i(int x, int y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x23, 0xc2, 0xc3}
asm-body-begin 7FFC86DAB460h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
0007h  and eax,edx   ; opcode := And_r32_rm32 | encoded := {23,c2} (2 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB460h ---------------------------------------------------------------------------------------------

7FFC86DAB480h uint and32u(uint x, uint y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x23, 0xc2, 0xc3}
asm-body-begin 7FFC86DAB480h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
0007h  and eax,edx   ; opcode := And_r32_rm32 | encoded := {23,c2} (2 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB480h ---------------------------------------------------------------------------------------------

7FFC86DAB4A0h long and64i(long x, long y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x48, 0x23, 0xc2, 0xc3}
asm-body-begin 7FFC86DAB4A0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0008h  and rax,rdx   ; opcode := And_r64_rm64 | encoded := {48,23,c2} (3 bytes)
000bh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB4A0h ---------------------------------------------------------------------------------------------

7FFC86DAB4C0h ulong and64u(ulong x, ulong y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x48, 0x23, 0xc2, 0xc3}
asm-body-begin 7FFC86DAB4C0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0008h  and rax,rdx   ; opcode := And_r64_rm64 | encoded := {48,23,c2} (3 bytes)
000bh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB4C0h ---------------------------------------------------------------------------------------------

7FFC86DAB4E0h sbyte div8i(sbyte x, sbyte y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xca, 0x99, 0xf7, 0xf9, 0x48, 0x0f, 0xbe, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB4E0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c1} (4 bytes)
0009h  movsx rcx,dl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,ca} (4 bytes)
000dh  cdq   ; opcode := Cdq | encoded := {99} (1 bytes)
000eh  idiv ecx   ; opcode := Idiv_rm32 | encoded := {f7,f9} (2 bytes)
0010h  movsx rax,al   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c0} (4 bytes)
0014h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB4E0h ---------------------------------------------------------------------------------------------

7FFC86DAB510h byte div8u(byte x, byte y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xca, 0x99, 0xf7, 0xf9, 0x0f, 0xb6, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB510h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c1} (3 bytes)
0008h  movzx ecx,dl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,ca} (3 bytes)
000bh  cdq   ; opcode := Cdq | encoded := {99} (1 bytes)
000ch  idiv ecx   ; opcode := Idiv_rm32 | encoded := {f7,f9} (2 bytes)
000eh  movzx eax,al   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c0} (3 bytes)
0011h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB510h ---------------------------------------------------------------------------------------------

7FFC86DAB540h short div16i(short x, short y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbf, 0xc1, 0x48, 0x0f, 0xbf, 0xca, 0x99, 0xf7, 0xf9, 0x48, 0x0f, 0xbf, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB540h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c1} (4 bytes)
0009h  movsx rcx,dx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,ca} (4 bytes)
000dh  cdq   ; opcode := Cdq | encoded := {99} (1 bytes)
000eh  idiv ecx   ; opcode := Idiv_rm32 | encoded := {f7,f9} (2 bytes)
0010h  movsx rax,ax   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c0} (4 bytes)
0014h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB540h ---------------------------------------------------------------------------------------------

7FFC86DAB570h ushort div16u(ushort x, ushort y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xca, 0x99, 0xf7, 0xf9, 0x0f, 0xb7, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB570h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c1} (3 bytes)
0008h  movzx ecx,dx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,ca} (3 bytes)
000bh  cdq   ; opcode := Cdq | encoded := {99} (1 bytes)
000ch  idiv ecx   ; opcode := Idiv_rm32 | encoded := {f7,f9} (2 bytes)
000eh  movzx eax,ax   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c0} (3 bytes)
0011h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB570h ---------------------------------------------------------------------------------------------

7FFC86DAB5A0h int div32i(int x, int y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x44, 0x8b, 0xc2, 0x8b, 0xc1, 0x99, 0x41, 0xf7, 0xf8, 0xc3}
asm-body-begin 7FFC86DAB5A0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov r8d,edx   ; opcode := Mov_r32_rm32 | encoded := {44,8b,c2} (3 bytes)
0008h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
000ah  cdq   ; opcode := Cdq | encoded := {99} (1 bytes)
000bh  idiv r8d   ; opcode := Idiv_rm32 | encoded := {41,f7,f8} (3 bytes)
000eh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB5A0h ---------------------------------------------------------------------------------------------

7FFC86DAB5C0h uint div32u(uint x, uint y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x44, 0x8b, 0xc2, 0x8b, 0xc1, 0x33, 0xd2, 0x41, 0xf7, 0xf0, 0xc3}
asm-body-begin 7FFC86DAB5C0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov r8d,edx   ; opcode := Mov_r32_rm32 | encoded := {44,8b,c2} (3 bytes)
0008h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
000ah  xor edx,edx   ; opcode := Xor_r32_rm32 | encoded := {33,d2} (2 bytes)
000ch  div r8d   ; opcode := Div_rm32 | encoded := {41,f7,f0} (3 bytes)
000fh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB5C0h ---------------------------------------------------------------------------------------------

7FFC86DAB5E0h long div64i(long x, long y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x4c, 0x8b, 0xc2, 0x48, 0x8b, 0xc1, 0x48, 0x99, 0x49, 0xf7, 0xf8, 0xc3}
asm-body-begin 7FFC86DAB5E0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov r8,rdx   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,c2} (3 bytes)
0008h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
000bh  cqo   ; opcode := Cqo | encoded := {48,99} (2 bytes)
000dh  idiv r8   ; opcode := Idiv_rm64 | encoded := {49,f7,f8} (3 bytes)
0010h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB5E0h ---------------------------------------------------------------------------------------------

7FFC86DAB610h ulong div64u(ulong x, ulong y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x4c, 0x8b, 0xc2, 0x48, 0x8b, 0xc1, 0x33, 0xd2, 0x49, 0xf7, 0xf0, 0xc3}
asm-body-begin 7FFC86DAB610h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov r8,rdx   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,c2} (3 bytes)
0008h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
000bh  xor edx,edx   ; opcode := Xor_r32_rm32 | encoded := {33,d2} (2 bytes)
000dh  div r8   ; opcode := Div_rm64 | encoded := {49,f7,f0} (3 bytes)
0010h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB610h ---------------------------------------------------------------------------------------------

7FFC86DAB640h float div32f(float x, float y)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfa, 0x5e, 0xc1, 0xc3}
asm-body-begin 7FFC86DAB640h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vdivss xmm0,xmm0,xmm1   ; opcode := VEX_Vdivss_xmm_xmm_xmmm32 (VEX encoded) | encoded := {c5,fa,5e,c1} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB640h ---------------------------------------------------------------------------------------------

7FFC86DAB660h double div64f(double x, double y)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfb, 0x5e, 0xc1, 0xc3}
asm-body-begin 7FFC86DAB660h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vdivsd xmm0,xmm0,xmm1   ; opcode := VEX_Vdivsd_xmm_xmm_xmmm64 (VEX encoded) | encoded := {c5,fb,5e,c1} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB660h ---------------------------------------------------------------------------------------------

7FFC86DAB680h sbyte mul8i(sbyte x, sbyte y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xd2, 0x0f, 0xaf, 0xc2, 0x48, 0x0f, 0xbe, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB680h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c1} (4 bytes)
0009h  movsx rdx,dl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,d2} (4 bytes)
000dh  imul eax,edx   ; opcode := Imul_r32_rm32 | encoded := {0f,af,c2} (3 bytes)
0010h  movsx rax,al   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c0} (4 bytes)
0014h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB680h ---------------------------------------------------------------------------------------------

7FFC86DAB6B0h byte mul8u(byte x, byte y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xd2, 0x0f, 0xaf, 0xc2, 0x0f, 0xb6, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB6B0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c1} (3 bytes)
0008h  movzx edx,dl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,d2} (3 bytes)
000bh  imul eax,edx   ; opcode := Imul_r32_rm32 | encoded := {0f,af,c2} (3 bytes)
000eh  movzx eax,al   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c0} (3 bytes)
0011h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB6B0h ---------------------------------------------------------------------------------------------

7FFC86DAB6E0h short mul16i(short x, short y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbf, 0xc1, 0x48, 0x0f, 0xbf, 0xd2, 0x0f, 0xaf, 0xc2, 0x48, 0x0f, 0xbf, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB6E0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c1} (4 bytes)
0009h  movsx rdx,dx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,d2} (4 bytes)
000dh  imul eax,edx   ; opcode := Imul_r32_rm32 | encoded := {0f,af,c2} (3 bytes)
0010h  movsx rax,ax   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c0} (4 bytes)
0014h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB6E0h ---------------------------------------------------------------------------------------------

7FFC86DAB710h ushort mul16u(ushort x, ushort y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xd2, 0x0f, 0xaf, 0xc2, 0x0f, 0xb7, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB710h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c1} (3 bytes)
0008h  movzx edx,dx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,d2} (3 bytes)
000bh  imul eax,edx   ; opcode := Imul_r32_rm32 | encoded := {0f,af,c2} (3 bytes)
000eh  movzx eax,ax   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c0} (3 bytes)
0011h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB710h ---------------------------------------------------------------------------------------------

7FFC86DAB740h int mul32i(int x, int y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x0f, 0xaf, 0xc2, 0xc3}
asm-body-begin 7FFC86DAB740h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
0007h  imul eax,edx   ; opcode := Imul_r32_rm32 | encoded := {0f,af,c2} (3 bytes)
000ah  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB740h ---------------------------------------------------------------------------------------------

7FFC86DAB760h uint mul32u(uint x, uint y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x0f, 0xaf, 0xc2, 0xc3}
asm-body-begin 7FFC86DAB760h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
0007h  imul eax,edx   ; opcode := Imul_r32_rm32 | encoded := {0f,af,c2} (3 bytes)
000ah  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB760h ---------------------------------------------------------------------------------------------

7FFC86DAB780h long mul64i(long x, long y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x48, 0x0f, 0xaf, 0xc2, 0xc3}
asm-body-begin 7FFC86DAB780h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0008h  imul rax,rdx   ; opcode := Imul_r64_rm64 | encoded := {48,0f,af,c2} (4 bytes)
000ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB780h ---------------------------------------------------------------------------------------------

7FFC86DAB7A0h ulong mul64u(ulong x, ulong y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x48, 0x0f, 0xaf, 0xc2, 0xc3}
asm-body-begin 7FFC86DAB7A0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0008h  imul rax,rdx   ; opcode := Imul_r64_rm64 | encoded := {48,0f,af,c2} (4 bytes)
000ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB7A0h ---------------------------------------------------------------------------------------------

7FFC86DAB7C0h float mul32f(float x, float y)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfa, 0x59, 0xc1, 0xc3}
asm-body-begin 7FFC86DAB7C0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmulss xmm0,xmm0,xmm1   ; opcode := VEX_Vmulss_xmm_xmm_xmmm32 (VEX encoded) | encoded := {c5,fa,59,c1} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB7C0h ---------------------------------------------------------------------------------------------

7FFC86DAB7E0h double mul64f(double x, double y)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfb, 0x59, 0xc1, 0xc3}
asm-body-begin 7FFC86DAB7E0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmulsd xmm0,xmm0,xmm1   ; opcode := VEX_Vmulsd_xmm_xmm_xmmm64 (VEX encoded) | encoded := {c5,fb,59,c1} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB7E0h ---------------------------------------------------------------------------------------------

7FFC86DAB800h byte or8u(byte x, byte y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xd2, 0x0b, 0xc2, 0x0f, 0xb6, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB800h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c1} (3 bytes)
0008h  movzx edx,dl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,d2} (3 bytes)
000bh  or eax,edx   ; opcode := Or_r32_rm32 | encoded := {0b,c2} (2 bytes)
000dh  movzx eax,al   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c0} (3 bytes)
0010h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB800h ---------------------------------------------------------------------------------------------

7FFC86DAB830h sbyte or8i(sbyte x, sbyte y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xd2, 0x0b, 0xc2, 0x48, 0x0f, 0xbe, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB830h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c1} (4 bytes)
0009h  movsx rdx,dl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,d2} (4 bytes)
000dh  or eax,edx   ; opcode := Or_r32_rm32 | encoded := {0b,c2} (2 bytes)
000fh  movsx rax,al   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c0} (4 bytes)
0013h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB830h ---------------------------------------------------------------------------------------------

7FFC86DAB860h short or16i(short x, short y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbf, 0xc1, 0x48, 0x0f, 0xbf, 0xd2, 0x0b, 0xc2, 0x48, 0x0f, 0xbf, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB860h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c1} (4 bytes)
0009h  movsx rdx,dx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,d2} (4 bytes)
000dh  or eax,edx   ; opcode := Or_r32_rm32 | encoded := {0b,c2} (2 bytes)
000fh  movsx rax,ax   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c0} (4 bytes)
0013h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB860h ---------------------------------------------------------------------------------------------

7FFC86DAB890h ushort or16u(ushort x, ushort y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xd2, 0x0b, 0xc2, 0x0f, 0xb7, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB890h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c1} (3 bytes)
0008h  movzx edx,dx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,d2} (3 bytes)
000bh  or eax,edx   ; opcode := Or_r32_rm32 | encoded := {0b,c2} (2 bytes)
000dh  movzx eax,ax   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c0} (3 bytes)
0010h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB890h ---------------------------------------------------------------------------------------------

7FFC86DAB8C0h int or32i(int x, int y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x0b, 0xc2, 0xc3}
asm-body-begin 7FFC86DAB8C0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
0007h  or eax,edx   ; opcode := Or_r32_rm32 | encoded := {0b,c2} (2 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB8C0h ---------------------------------------------------------------------------------------------

7FFC86DAB8E0h uint or32u(uint x, uint y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x0b, 0xc2, 0xc3}
asm-body-begin 7FFC86DAB8E0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
0007h  or eax,edx   ; opcode := Or_r32_rm32 | encoded := {0b,c2} (2 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB8E0h ---------------------------------------------------------------------------------------------

7FFC86DAB900h long or64i(long x, long y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x48, 0x0b, 0xc2, 0xc3}
asm-body-begin 7FFC86DAB900h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0008h  or rax,rdx   ; opcode := Or_r64_rm64 | encoded := {48,0b,c2} (3 bytes)
000bh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB900h ---------------------------------------------------------------------------------------------

7FFC86DAB920h ulong or64u(ulong x, ulong y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x48, 0x0b, 0xc2, 0xc3}
asm-body-begin 7FFC86DAB920h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0008h  or rax,rdx   ; opcode := Or_r64_rm64 | encoded := {48,0b,c2} (3 bytes)
000bh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB920h ---------------------------------------------------------------------------------------------

7FFC86DAB940h sbyte sub8i(sbyte x, sbyte y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xd2, 0x2b, 0xc2, 0x48, 0x0f, 0xbe, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB940h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c1} (4 bytes)
0009h  movsx rdx,dl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,d2} (4 bytes)
000dh  sub eax,edx   ; opcode := Sub_r32_rm32 | encoded := {2b,c2} (2 bytes)
000fh  movsx rax,al   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c0} (4 bytes)
0013h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB940h ---------------------------------------------------------------------------------------------

7FFC86DAB970h byte sub8u(byte x, byte y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xd2, 0x2b, 0xc2, 0x0f, 0xb6, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB970h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c1} (3 bytes)
0008h  movzx edx,dl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,d2} (3 bytes)
000bh  sub eax,edx   ; opcode := Sub_r32_rm32 | encoded := {2b,c2} (2 bytes)
000dh  movzx eax,al   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c0} (3 bytes)
0010h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB970h ---------------------------------------------------------------------------------------------

7FFC86DAB9A0h short sub16i(short x, short y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbf, 0xc1, 0x48, 0x0f, 0xbf, 0xd2, 0x2b, 0xc2, 0x48, 0x0f, 0xbf, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB9A0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c1} (4 bytes)
0009h  movsx rdx,dx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,d2} (4 bytes)
000dh  sub eax,edx   ; opcode := Sub_r32_rm32 | encoded := {2b,c2} (2 bytes)
000fh  movsx rax,ax   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c0} (4 bytes)
0013h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB9A0h ---------------------------------------------------------------------------------------------

7FFC86DAB9D0h ushort sub16u(ushort x, ushort y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xd2, 0x2b, 0xc2, 0x0f, 0xb7, 0xc0, 0xc3}
asm-body-begin 7FFC86DAB9D0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c1} (3 bytes)
0008h  movzx edx,dx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,d2} (3 bytes)
000bh  sub eax,edx   ; opcode := Sub_r32_rm32 | encoded := {2b,c2} (2 bytes)
000dh  movzx eax,ax   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c0} (3 bytes)
0010h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DAB9D0h ---------------------------------------------------------------------------------------------

7FFC86DABA00h int sub32i(int x, int y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x2b, 0xc2, 0xc3}
asm-body-begin 7FFC86DABA00h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
0007h  sub eax,edx   ; opcode := Sub_r32_rm32 | encoded := {2b,c2} (2 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DABA00h ---------------------------------------------------------------------------------------------

7FFC86DABA20h uint sub32u(uint x, uint y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x2b, 0xc2, 0xc3}
asm-body-begin 7FFC86DABA20h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
0007h  sub eax,edx   ; opcode := Sub_r32_rm32 | encoded := {2b,c2} (2 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DABA20h ---------------------------------------------------------------------------------------------

7FFC86DABA40h long sub64i(long x, long y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x48, 0x2b, 0xc2, 0xc3}
asm-body-begin 7FFC86DABA40h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0008h  sub rax,rdx   ; opcode := Sub_r64_rm64 | encoded := {48,2b,c2} (3 bytes)
000bh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DABA40h ---------------------------------------------------------------------------------------------

7FFC86DABA60h ulong sub64u(ulong x, ulong y)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x48, 0x2b, 0xc2, 0xc3}
asm-body-begin 7FFC86DABA60h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0008h  sub rax,rdx   ; opcode := Sub_r64_rm64 | encoded := {48,2b,c2} (3 bytes)
000bh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DABA60h ---------------------------------------------------------------------------------------------

7FFC86DABA80h float sub32f(float x, float y)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfa, 0x5c, 0xc1, 0xc3}
asm-body-begin 7FFC86DABA80h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vsubss xmm0,xmm0,xmm1   ; opcode := VEX_Vsubss_xmm_xmm_xmmm32 (VEX encoded) | encoded := {c5,fa,5c,c1} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DABA80h ---------------------------------------------------------------------------------------------

7FFC86DABAA0h double sub64f(double x, double y)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfb, 0x5c, 0xc1, 0xc3}
asm-body-begin 7FFC86DABAA0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vsubsd xmm0,xmm0,xmm1   ; opcode := VEX_Vsubsd_xmm_xmm_xmmm64 (VEX encoded) | encoded := {c5,fb,5c,c1} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DABAA0h ---------------------------------------------------------------------------------------------

7FFC86DABAC0h byte rotr8u(byte src, byte offset)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xd2, 0x8b, 0xca, 0x44, 0x8b, 0xc0, 0x41, 0xd3, 0xf8, 0x8b, 0xca, 0xf7, 0xd9, 0x83, 0xc1, 0x08, 0xd3, 0xe0, 0x41, 0x0b, 0xc0, 0x0f, 0xb6, 0xc0, 0xc3}
asm-body-begin 7FFC86DABAC0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c1} (3 bytes)
0008h  movzx edx,dl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,d2} (3 bytes)
000bh  mov ecx,edx   ; opcode := Mov_r32_rm32 | encoded := {8b,ca} (2 bytes)
000dh  mov r8d,eax   ; opcode := Mov_r32_rm32 | encoded := {44,8b,c0} (3 bytes)
0010h  sar r8d,cl   ; opcode := Sar_rm32_CL | encoded := {41,d3,f8} (3 bytes)
0013h  mov ecx,edx   ; opcode := Mov_r32_rm32 | encoded := {8b,ca} (2 bytes)
0015h  neg ecx   ; opcode := Neg_rm32 | encoded := {f7,d9} (2 bytes)
0017h  add ecx,8   ; opcode := Add_rm32_imm8 | encoded := {83,c1,08} (3 bytes)
001ah  shl eax,cl   ; opcode := Shl_rm32_CL | encoded := {d3,e0} (2 bytes)
001ch  or eax,r8d   ; opcode := Or_r32_rm32 | encoded := {41,0b,c0} (3 bytes)
001fh  movzx eax,al   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c0} (3 bytes)
0022h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DABAC0h ---------------------------------------------------------------------------------------------

7FFC86DABB00h ushort rotr16u(ushort src, ushort offset)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xd2, 0x8b, 0xca, 0x44, 0x8b, 0xc0, 0x41, 0xd3, 0xf8, 0x8b, 0xca, 0xf7, 0xd9, 0x83, 0xc1, 0x10, 0xd3, 0xe0, 0x41, 0x0b, 0xc0, 0x0f, 0xb7, 0xc0, 0xc3}
asm-body-begin 7FFC86DABB00h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c1} (3 bytes)
0008h  movzx edx,dx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,d2} (3 bytes)
000bh  mov ecx,edx   ; opcode := Mov_r32_rm32 | encoded := {8b,ca} (2 bytes)
000dh  mov r8d,eax   ; opcode := Mov_r32_rm32 | encoded := {44,8b,c0} (3 bytes)
0010h  sar r8d,cl   ; opcode := Sar_rm32_CL | encoded := {41,d3,f8} (3 bytes)
0013h  mov ecx,edx   ; opcode := Mov_r32_rm32 | encoded := {8b,ca} (2 bytes)
0015h  neg ecx   ; opcode := Neg_rm32 | encoded := {f7,d9} (2 bytes)
0017h  add ecx,10h   ; opcode := Add_rm32_imm8 | encoded := {83,c1,10} (3 bytes)
001ah  shl eax,cl   ; opcode := Shl_rm32_CL | encoded := {d3,e0} (2 bytes)
001ch  or eax,r8d   ; opcode := Or_r32_rm32 | encoded := {41,0b,c0} (3 bytes)
001fh  movzx eax,ax   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c0} (3 bytes)
0022h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DABB00h ---------------------------------------------------------------------------------------------

7FFC86DABB40h uint rotr32u(uint src, uint offset)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x8b, 0xca, 0xd3, 0xc8, 0xc3}
asm-body-begin 7FFC86DABB40h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
0007h  mov ecx,edx   ; opcode := Mov_r32_rm32 | encoded := {8b,ca} (2 bytes)
0009h  ror eax,cl   ; opcode := Ror_rm32_CL | encoded := {d3,c8} (2 bytes)
000bh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DABB40h ---------------------------------------------------------------------------------------------

7FFC86DABB60h ulong rotr64u(ulong src, ulong offset)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x8b, 0xca, 0x48, 0xd3, 0xc8, 0xc3}
asm-body-begin 7FFC86DABB60h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0008h  mov ecx,edx   ; opcode := Mov_r32_rm32 | encoded := {8b,ca} (2 bytes)
000ah  ror rax,cl   ; opcode := Ror_rm64_CL | encoded := {48,d3,c8} (3 bytes)
000dh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DABB60h ---------------------------------------------------------------------------------------------

7FFC86DABB80h byte rotl8u(byte x, byte offset)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xd2, 0x8b, 0xca, 0x44, 0x8b, 0xc0, 0x41, 0xd3, 0xe0, 0x8b, 0xca, 0xf7, 0xd9, 0x83, 0xc1, 0x08, 0xd3, 0xf8, 0x41, 0x0b, 0xc0, 0x0f, 0xb6, 0xc0, 0xc3}
asm-body-begin 7FFC86DABB80h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c1} (3 bytes)
0008h  movzx edx,dl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,d2} (3 bytes)
000bh  mov ecx,edx   ; opcode := Mov_r32_rm32 | encoded := {8b,ca} (2 bytes)
000dh  mov r8d,eax   ; opcode := Mov_r32_rm32 | encoded := {44,8b,c0} (3 bytes)
0010h  shl r8d,cl   ; opcode := Shl_rm32_CL | encoded := {41,d3,e0} (3 bytes)
0013h  mov ecx,edx   ; opcode := Mov_r32_rm32 | encoded := {8b,ca} (2 bytes)
0015h  neg ecx   ; opcode := Neg_rm32 | encoded := {f7,d9} (2 bytes)
0017h  add ecx,8   ; opcode := Add_rm32_imm8 | encoded := {83,c1,08} (3 bytes)
001ah  sar eax,cl   ; opcode := Sar_rm32_CL | encoded := {d3,f8} (2 bytes)
001ch  or eax,r8d   ; opcode := Or_r32_rm32 | encoded := {41,0b,c0} (3 bytes)
001fh  movzx eax,al   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c0} (3 bytes)
0022h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DABB80h ---------------------------------------------------------------------------------------------

7FFC86DABBC0h ushort rotl16u(ushort x, ushort offset)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xd2, 0x8b, 0xca, 0x44, 0x8b, 0xc0, 0x41, 0xd3, 0xe0, 0x8b, 0xca, 0xf7, 0xd9, 0x83, 0xc1, 0x10, 0xd3, 0xe8, 0x41, 0x0b, 0xc0, 0x0f, 0xb7, 0xc0, 0xc3}
asm-body-begin 7FFC86DABBC0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c1} (3 bytes)
0008h  movzx edx,dx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,d2} (3 bytes)
000bh  mov ecx,edx   ; opcode := Mov_r32_rm32 | encoded := {8b,ca} (2 bytes)
000dh  mov r8d,eax   ; opcode := Mov_r32_rm32 | encoded := {44,8b,c0} (3 bytes)
0010h  shl r8d,cl   ; opcode := Shl_rm32_CL | encoded := {41,d3,e0} (3 bytes)
0013h  mov ecx,edx   ; opcode := Mov_r32_rm32 | encoded := {8b,ca} (2 bytes)
0015h  neg ecx   ; opcode := Neg_rm32 | encoded := {f7,d9} (2 bytes)
0017h  add ecx,10h   ; opcode := Add_rm32_imm8 | encoded := {83,c1,10} (3 bytes)
001ah  shr eax,cl   ; opcode := Shr_rm32_CL | encoded := {d3,e8} (2 bytes)
001ch  or eax,r8d   ; opcode := Or_r32_rm32 | encoded := {41,0b,c0} (3 bytes)
001fh  movzx eax,ax   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c0} (3 bytes)
0022h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DABBC0h ---------------------------------------------------------------------------------------------

7FFC86DABC00h uint rotl32u(uint x, uint offset)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x8b, 0xca, 0xd3, 0xc0, 0xc3}
asm-body-begin 7FFC86DABC00h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
0007h  mov ecx,edx   ; opcode := Mov_r32_rm32 | encoded := {8b,ca} (2 bytes)
0009h  rol eax,cl   ; opcode := Rol_rm32_CL | encoded := {d3,c0} (2 bytes)
000bh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DABC00h ---------------------------------------------------------------------------------------------

7FFC86DABC20h ulong rotl64u(ulong x, ulong offset)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x8b, 0xca, 0x48, 0xd3, 0xc0, 0xc3}
asm-body-begin 7FFC86DABC20h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0008h  mov ecx,edx   ; opcode := Mov_r32_rm32 | encoded := {8b,ca} (2 bytes)
000ah  rol rax,cl   ; opcode := Rol_rm64_CL | encoded := {48,d3,c0} (3 bytes)
000dh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86DABC20h ---------------------------------------------------------------------------------------------

