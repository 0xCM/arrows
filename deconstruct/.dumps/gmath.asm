# 2019-07-27 04:33:03:196
7FFC86CC4A80h byte sub<byte>(byte lhs, byte rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xd2, 0x2b, 0xc2, 0x0f, 0xb6, 0xc0, 0xc3}
asm-body-begin 7FFC86CC4A80h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c1} (3 bytes)
0008h  movzx edx,dl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,d2} (3 bytes)
000bh  sub eax,edx   ; opcode := Sub_r32_rm32 | encoded := {2b,c2} (2 bytes)
000dh  movzx eax,al   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c0} (3 bytes)
0010h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC4A80h ---------------------------------------------------------------------------------------------

7FFC86CC4AB0h ushort sub<ushort>(ushort lhs, ushort rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xd2, 0x2b, 0xc2, 0x0f, 0xb7, 0xc0, 0xc3}
asm-body-begin 7FFC86CC4AB0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c1} (3 bytes)
0008h  movzx edx,dx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,d2} (3 bytes)
000bh  sub eax,edx   ; opcode := Sub_r32_rm32 | encoded := {2b,c2} (2 bytes)
000dh  movzx eax,ax   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c0} (3 bytes)
0010h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC4AB0h ---------------------------------------------------------------------------------------------

7FFC86CC4AE0h uint sub<uint>(uint lhs, uint rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x2b, 0xc2, 0xc3}
asm-body-begin 7FFC86CC4AE0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
0007h  sub eax,edx   ; opcode := Sub_r32_rm32 | encoded := {2b,c2} (2 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC4AE0h ---------------------------------------------------------------------------------------------

7FFC86CC4F10h ulong sub<ulong>(ulong lhs, ulong rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x48, 0x2b, 0xc2, 0xc3}
asm-body-begin 7FFC86CC4F10h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0008h  sub rax,rdx   ; opcode := Sub_r64_rm64 | encoded := {48,2b,c2} (3 bytes)
000bh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC4F10h ---------------------------------------------------------------------------------------------

7FFC86CC4F30h sbyte sub<sbyte>(sbyte lhs, sbyte rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xd2, 0x2b, 0xc2, 0x48, 0x0f, 0xbe, 0xc0, 0xc3}
asm-body-begin 7FFC86CC4F30h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c1} (4 bytes)
0009h  movsx rdx,dl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,d2} (4 bytes)
000dh  sub eax,edx   ; opcode := Sub_r32_rm32 | encoded := {2b,c2} (2 bytes)
000fh  movsx rax,al   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c0} (4 bytes)
0013h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC4F30h ---------------------------------------------------------------------------------------------

7FFC86CC4F60h short sub<short>(short lhs, short rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbf, 0xc1, 0x48, 0x0f, 0xbf, 0xd2, 0x2b, 0xc2, 0x48, 0x0f, 0xbf, 0xc0, 0xc3}
asm-body-begin 7FFC86CC4F60h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c1} (4 bytes)
0009h  movsx rdx,dx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,d2} (4 bytes)
000dh  sub eax,edx   ; opcode := Sub_r32_rm32 | encoded := {2b,c2} (2 bytes)
000fh  movsx rax,ax   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c0} (4 bytes)
0013h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC4F60h ---------------------------------------------------------------------------------------------

7FFC86CC4F90h int sub<int>(int lhs, int rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x2b, 0xc2, 0xc3}
asm-body-begin 7FFC86CC4F90h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
0007h  sub eax,edx   ; opcode := Sub_r32_rm32 | encoded := {2b,c2} (2 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC4F90h ---------------------------------------------------------------------------------------------

7FFC86CC4FB0h long sub<long>(long lhs, long rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x48, 0x2b, 0xc2, 0xc3}
asm-body-begin 7FFC86CC4FB0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0008h  sub rax,rdx   ; opcode := Sub_r64_rm64 | encoded := {48,2b,c2} (3 bytes)
000bh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC4FB0h ---------------------------------------------------------------------------------------------

7FFC86CC4FD0h float sub<float>(float lhs, float rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfa, 0x5c, 0xc1, 0xc3}
asm-body-begin 7FFC86CC4FD0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vsubss xmm0,xmm0,xmm1   ; opcode := VEX_Vsubss_xmm_xmm_xmmm32 (VEX encoded) | encoded := {c5,fa,5c,c1} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC4FD0h ---------------------------------------------------------------------------------------------

7FFC86CC4FF0h double sub<double>(double lhs, double rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfb, 0x5c, 0xc1, 0xc3}
asm-body-begin 7FFC86CC4FF0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vsubsd xmm0,xmm0,xmm1   ; opcode := VEX_Vsubsd_xmm_xmm_xmmm64 (VEX encoded) | encoded := {c5,fb,5c,c1} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC4FF0h ---------------------------------------------------------------------------------------------

7FFC86CC5010h byte mul<byte>(byte lhs, byte rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xd2, 0x0f, 0xaf, 0xc2, 0x0f, 0xb6, 0xc0, 0xc3}
asm-body-begin 7FFC86CC5010h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c1} (3 bytes)
0008h  movzx edx,dl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,d2} (3 bytes)
000bh  imul eax,edx   ; opcode := Imul_r32_rm32 | encoded := {0f,af,c2} (3 bytes)
000eh  movzx eax,al   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c0} (3 bytes)
0011h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5010h ---------------------------------------------------------------------------------------------

7FFC86CC5040h ushort mul<ushort>(ushort lhs, ushort rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xd2, 0x0f, 0xaf, 0xc2, 0x0f, 0xb7, 0xc0, 0xc3}
asm-body-begin 7FFC86CC5040h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c1} (3 bytes)
0008h  movzx edx,dx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,d2} (3 bytes)
000bh  imul eax,edx   ; opcode := Imul_r32_rm32 | encoded := {0f,af,c2} (3 bytes)
000eh  movzx eax,ax   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c0} (3 bytes)
0011h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5040h ---------------------------------------------------------------------------------------------

7FFC86CC5070h uint mul<uint>(uint lhs, uint rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x0f, 0xaf, 0xc2, 0xc3}
asm-body-begin 7FFC86CC5070h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
0007h  imul eax,edx   ; opcode := Imul_r32_rm32 | encoded := {0f,af,c2} (3 bytes)
000ah  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5070h ---------------------------------------------------------------------------------------------

7FFC86CC54A0h ulong mul<ulong>(ulong lhs, ulong rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x48, 0x0f, 0xaf, 0xc2, 0xc3}
asm-body-begin 7FFC86CC54A0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0008h  imul rax,rdx   ; opcode := Imul_r64_rm64 | encoded := {48,0f,af,c2} (4 bytes)
000ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC54A0h ---------------------------------------------------------------------------------------------

7FFC86CC54C0h sbyte mul<sbyte>(sbyte lhs, sbyte rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xd2, 0x0f, 0xaf, 0xc2, 0x48, 0x0f, 0xbe, 0xc0, 0xc3}
asm-body-begin 7FFC86CC54C0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c1} (4 bytes)
0009h  movsx rdx,dl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,d2} (4 bytes)
000dh  imul eax,edx   ; opcode := Imul_r32_rm32 | encoded := {0f,af,c2} (3 bytes)
0010h  movsx rax,al   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c0} (4 bytes)
0014h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC54C0h ---------------------------------------------------------------------------------------------

7FFC86CC54F0h short mul<short>(short lhs, short rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbf, 0xc1, 0x48, 0x0f, 0xbf, 0xd2, 0x0f, 0xaf, 0xc2, 0x48, 0x0f, 0xbf, 0xc0, 0xc3}
asm-body-begin 7FFC86CC54F0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c1} (4 bytes)
0009h  movsx rdx,dx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,d2} (4 bytes)
000dh  imul eax,edx   ; opcode := Imul_r32_rm32 | encoded := {0f,af,c2} (3 bytes)
0010h  movsx rax,ax   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c0} (4 bytes)
0014h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC54F0h ---------------------------------------------------------------------------------------------

7FFC86CC5520h int mul<int>(int lhs, int rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x0f, 0xaf, 0xc2, 0xc3}
asm-body-begin 7FFC86CC5520h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
0007h  imul eax,edx   ; opcode := Imul_r32_rm32 | encoded := {0f,af,c2} (3 bytes)
000ah  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5520h ---------------------------------------------------------------------------------------------

7FFC86CC5540h long mul<long>(long lhs, long rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x48, 0x0f, 0xaf, 0xc2, 0xc3}
asm-body-begin 7FFC86CC5540h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
0008h  imul rax,rdx   ; opcode := Imul_r64_rm64 | encoded := {48,0f,af,c2} (4 bytes)
000ch  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5540h ---------------------------------------------------------------------------------------------

7FFC86CC5560h float mul<float>(float lhs, float rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfa, 0x59, 0xc1, 0xc3}
asm-body-begin 7FFC86CC5560h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmulss xmm0,xmm0,xmm1   ; opcode := VEX_Vmulss_xmm_xmm_xmmm32 (VEX encoded) | encoded := {c5,fa,59,c1} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5560h ---------------------------------------------------------------------------------------------

7FFC86CC5580h double mul<double>(double lhs, double rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfb, 0x59, 0xc1, 0xc3}
asm-body-begin 7FFC86CC5580h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vmulsd xmm0,xmm0,xmm1   ; opcode := VEX_Vmulsd_xmm_xmm_xmmm64 (VEX encoded) | encoded := {c5,fb,59,c1} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5580h ---------------------------------------------------------------------------------------------

7FFC86CC55A0h byte add<byte>(byte lhs, byte rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xd2, 0x03, 0xc2, 0x0f, 0xb6, 0xc0, 0xc3}
asm-body-begin 7FFC86CC55A0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c1} (3 bytes)
0008h  movzx edx,dl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,d2} (3 bytes)
000bh  add eax,edx   ; opcode := Add_r32_rm32 | encoded := {03,c2} (2 bytes)
000dh  movzx eax,al   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c0} (3 bytes)
0010h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC55A0h ---------------------------------------------------------------------------------------------

7FFC86CC55D0h ushort add<ushort>(ushort lhs, ushort rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xd2, 0x03, 0xc2, 0x0f, 0xb7, 0xc0, 0xc3}
asm-body-begin 7FFC86CC55D0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c1} (3 bytes)
0008h  movzx edx,dx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,d2} (3 bytes)
000bh  add eax,edx   ; opcode := Add_r32_rm32 | encoded := {03,c2} (2 bytes)
000dh  movzx eax,ax   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c0} (3 bytes)
0010h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC55D0h ---------------------------------------------------------------------------------------------

7FFC86CC5600h uint add<uint>(uint lhs, uint rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8d, 0x04, 0x11, 0xc3}
asm-body-begin 7FFC86CC5600h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  lea eax,[rcx+rdx]   ; opcode := Lea_r32_m | encoded := {8d,04,11} (3 bytes)
0008h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5600h ---------------------------------------------------------------------------------------------

7FFC86CC5620h ulong add<ulong>(ulong lhs, ulong rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8d, 0x04, 0x11, 0xc3}
asm-body-begin 7FFC86CC5620h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  lea rax,[rcx+rdx]   ; opcode := Lea_r64_m | encoded := {48,8d,04,11} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5620h ---------------------------------------------------------------------------------------------

7FFC86CC5640h sbyte add<sbyte>(sbyte lhs, sbyte rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xd2, 0x03, 0xc2, 0x48, 0x0f, 0xbe, 0xc0, 0xc3}
asm-body-begin 7FFC86CC5640h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c1} (4 bytes)
0009h  movsx rdx,dl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,d2} (4 bytes)
000dh  add eax,edx   ; opcode := Add_r32_rm32 | encoded := {03,c2} (2 bytes)
000fh  movsx rax,al   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c0} (4 bytes)
0013h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5640h ---------------------------------------------------------------------------------------------

7FFC86CC5670h short add<short>(short lhs, short rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbf, 0xc1, 0x48, 0x0f, 0xbf, 0xd2, 0x03, 0xc2, 0x48, 0x0f, 0xbf, 0xc0, 0xc3}
asm-body-begin 7FFC86CC5670h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c1} (4 bytes)
0009h  movsx rdx,dx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,d2} (4 bytes)
000dh  add eax,edx   ; opcode := Add_r32_rm32 | encoded := {03,c2} (2 bytes)
000fh  movsx rax,ax   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c0} (4 bytes)
0013h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5670h ---------------------------------------------------------------------------------------------

7FFC86CC56A0h int add<int>(int lhs, int rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8d, 0x04, 0x11, 0xc3}
asm-body-begin 7FFC86CC56A0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  lea eax,[rcx+rdx]   ; opcode := Lea_r32_m | encoded := {8d,04,11} (3 bytes)
0008h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC56A0h ---------------------------------------------------------------------------------------------

7FFC86CC56C0h long add<long>(long lhs, long rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8d, 0x04, 0x11, 0xc3}
asm-body-begin 7FFC86CC56C0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  lea rax,[rcx+rdx]   ; opcode := Lea_r64_m | encoded := {48,8d,04,11} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC56C0h ---------------------------------------------------------------------------------------------

7FFC86CC56E0h float add<float>(float lhs, float rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfa, 0x58, 0xc1, 0xc3}
asm-body-begin 7FFC86CC56E0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vaddss xmm0,xmm0,xmm1   ; opcode := VEX_Vaddss_xmm_xmm_xmmm32 (VEX encoded) | encoded := {c5,fa,58,c1} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC56E0h ---------------------------------------------------------------------------------------------

7FFC86CC5700h double add<double>(double lhs, double rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfb, 0x58, 0xc1, 0xc3}
asm-body-begin 7FFC86CC5700h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vaddsd xmm0,xmm0,xmm1   ; opcode := VEX_Vaddsd_xmm_xmm_xmmm64 (VEX encoded) | encoded := {c5,fb,58,c1} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5700h ---------------------------------------------------------------------------------------------

7FFC86CC5720h byte div<byte>(byte lhs, byte rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xca, 0x99, 0xf7, 0xf9, 0x0f, 0xb6, 0xc0, 0xc3}
asm-body-begin 7FFC86CC5720h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c1} (3 bytes)
0008h  movzx ecx,dl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,ca} (3 bytes)
000bh  cdq   ; opcode := Cdq | encoded := {99} (1 bytes)
000ch  idiv ecx   ; opcode := Idiv_rm32 | encoded := {f7,f9} (2 bytes)
000eh  movzx eax,al   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c0} (3 bytes)
0011h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5720h ---------------------------------------------------------------------------------------------

7FFC86CC5750h ushort div<ushort>(ushort lhs, ushort rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xca, 0x99, 0xf7, 0xf9, 0x0f, 0xb7, 0xc0, 0xc3}
asm-body-begin 7FFC86CC5750h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c1} (3 bytes)
0008h  movzx ecx,dx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,ca} (3 bytes)
000bh  cdq   ; opcode := Cdq | encoded := {99} (1 bytes)
000ch  idiv ecx   ; opcode := Idiv_rm32 | encoded := {f7,f9} (2 bytes)
000eh  movzx eax,ax   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c0} (3 bytes)
0011h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5750h ---------------------------------------------------------------------------------------------

7FFC86CC5780h uint div<uint>(uint lhs, uint rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x44, 0x8b, 0xc2, 0x8b, 0xc1, 0x33, 0xd2, 0x41, 0xf7, 0xf0, 0xc3}
asm-body-begin 7FFC86CC5780h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov r8d,edx   ; opcode := Mov_r32_rm32 | encoded := {44,8b,c2} (3 bytes)
0008h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
000ah  xor edx,edx   ; opcode := Xor_r32_rm32 | encoded := {33,d2} (2 bytes)
000ch  div r8d   ; opcode := Div_rm32 | encoded := {41,f7,f0} (3 bytes)
000fh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5780h ---------------------------------------------------------------------------------------------

7FFC86CC57A0h ulong div<ulong>(ulong lhs, ulong rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x4c, 0x8b, 0xc2, 0x48, 0x8b, 0xc1, 0x33, 0xd2, 0x49, 0xf7, 0xf0, 0xc3}
asm-body-begin 7FFC86CC57A0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov r8,rdx   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,c2} (3 bytes)
0008h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
000bh  xor edx,edx   ; opcode := Xor_r32_rm32 | encoded := {33,d2} (2 bytes)
000dh  div r8   ; opcode := Div_rm64 | encoded := {49,f7,f0} (3 bytes)
0010h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC57A0h ---------------------------------------------------------------------------------------------

7FFC86CC57D0h sbyte div<sbyte>(sbyte lhs, sbyte rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xca, 0x99, 0xf7, 0xf9, 0x48, 0x0f, 0xbe, 0xc0, 0xc3}
asm-body-begin 7FFC86CC57D0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c1} (4 bytes)
0009h  movsx rcx,dl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,ca} (4 bytes)
000dh  cdq   ; opcode := Cdq | encoded := {99} (1 bytes)
000eh  idiv ecx   ; opcode := Idiv_rm32 | encoded := {f7,f9} (2 bytes)
0010h  movsx rax,al   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c0} (4 bytes)
0014h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC57D0h ---------------------------------------------------------------------------------------------

7FFC86CC5800h short div<short>(short lhs, short rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbf, 0xc1, 0x48, 0x0f, 0xbf, 0xca, 0x99, 0xf7, 0xf9, 0x48, 0x0f, 0xbf, 0xc0, 0xc3}
asm-body-begin 7FFC86CC5800h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c1} (4 bytes)
0009h  movsx rcx,dx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,ca} (4 bytes)
000dh  cdq   ; opcode := Cdq | encoded := {99} (1 bytes)
000eh  idiv ecx   ; opcode := Idiv_rm32 | encoded := {f7,f9} (2 bytes)
0010h  movsx rax,ax   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c0} (4 bytes)
0014h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5800h ---------------------------------------------------------------------------------------------

7FFC86CC5830h int div<int>(int lhs, int rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x44, 0x8b, 0xc2, 0x8b, 0xc1, 0x99, 0x41, 0xf7, 0xf8, 0xc3}
asm-body-begin 7FFC86CC5830h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov r8d,edx   ; opcode := Mov_r32_rm32 | encoded := {44,8b,c2} (3 bytes)
0008h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
000ah  cdq   ; opcode := Cdq | encoded := {99} (1 bytes)
000bh  idiv r8d   ; opcode := Idiv_rm32 | encoded := {41,f7,f8} (3 bytes)
000eh  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5830h ---------------------------------------------------------------------------------------------

7FFC86CC5850h long div<long>(long lhs, long rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x4c, 0x8b, 0xc2, 0x48, 0x8b, 0xc1, 0x48, 0x99, 0x49, 0xf7, 0xf8, 0xc3}
asm-body-begin 7FFC86CC5850h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov r8,rdx   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,c2} (3 bytes)
0008h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
000bh  cqo   ; opcode := Cqo | encoded := {48,99} (2 bytes)
000dh  idiv r8   ; opcode := Idiv_rm64 | encoded := {49,f7,f8} (3 bytes)
0010h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5850h ---------------------------------------------------------------------------------------------

7FFC86CC5C80h float div<float>(float lhs, float rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfa, 0x5e, 0xc1, 0xc3}
asm-body-begin 7FFC86CC5C80h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vdivss xmm0,xmm0,xmm1   ; opcode := VEX_Vdivss_xmm_xmm_xmmm32 (VEX encoded) | encoded := {c5,fa,5e,c1} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5C80h ---------------------------------------------------------------------------------------------

7FFC86CC5CA0h double div<double>(double lhs, double rhs)
# encoding: {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfb, 0x5e, 0xc1, 0xc3}
asm-body-begin 7FFC86CC5CA0h -------------------------------------------------------------------------------------------
0000h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0003h  xchg ax,ax   ; opcode := Nopw | encoded := {66,90} (2 bytes)
0005h  vdivsd xmm0,xmm0,xmm1   ; opcode := VEX_Vdivsd_xmm_xmm_xmmm64 (VEX encoded) | encoded := {c5,fb,5e,c1} (4 bytes)
0009h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5CA0h ---------------------------------------------------------------------------------------------

7FFC86CC5CC0h byte mod<byte>(byte lhs, byte rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xca, 0x99, 0xf7, 0xf9, 0x0f, 0xb6, 0xc2, 0xc3}
asm-body-begin 7FFC86CC5CC0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c1} (3 bytes)
0008h  movzx ecx,dl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,ca} (3 bytes)
000bh  cdq   ; opcode := Cdq | encoded := {99} (1 bytes)
000ch  idiv ecx   ; opcode := Idiv_rm32 | encoded := {f7,f9} (2 bytes)
000eh  movzx eax,dl   ; opcode := Movzx_r32_rm8 | encoded := {0f,b6,c2} (3 bytes)
0011h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5CC0h ---------------------------------------------------------------------------------------------

7FFC86CC5CF0h ushort mod<ushort>(ushort lhs, ushort rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xca, 0x99, 0xf7, 0xf9, 0x0f, 0xb7, 0xc2, 0xc3}
asm-body-begin 7FFC86CC5CF0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movzx eax,cx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c1} (3 bytes)
0008h  movzx ecx,dx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,ca} (3 bytes)
000bh  cdq   ; opcode := Cdq | encoded := {99} (1 bytes)
000ch  idiv ecx   ; opcode := Idiv_rm32 | encoded := {f7,f9} (2 bytes)
000eh  movzx eax,dx   ; opcode := Movzx_r32_rm16 | encoded := {0f,b7,c2} (3 bytes)
0011h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5CF0h ---------------------------------------------------------------------------------------------

7FFC86CC5D20h uint mod<uint>(uint lhs, uint rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x44, 0x8b, 0xc2, 0x8b, 0xc1, 0x33, 0xd2, 0x41, 0xf7, 0xf0, 0x8b, 0xc2, 0xc3}
asm-body-begin 7FFC86CC5D20h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov r8d,edx   ; opcode := Mov_r32_rm32 | encoded := {44,8b,c2} (3 bytes)
0008h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
000ah  xor edx,edx   ; opcode := Xor_r32_rm32 | encoded := {33,d2} (2 bytes)
000ch  div r8d   ; opcode := Div_rm32 | encoded := {41,f7,f0} (3 bytes)
000fh  mov eax,edx   ; opcode := Mov_r32_rm32 | encoded := {8b,c2} (2 bytes)
0011h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5D20h ---------------------------------------------------------------------------------------------

7FFC86CC5D50h ulong mod<ulong>(ulong lhs, ulong rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x4c, 0x8b, 0xc2, 0x48, 0x8b, 0xc1, 0x33, 0xd2, 0x49, 0xf7, 0xf0, 0x48, 0x8b, 0xc2, 0xc3}
asm-body-begin 7FFC86CC5D50h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov r8,rdx   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,c2} (3 bytes)
0008h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
000bh  xor edx,edx   ; opcode := Xor_r32_rm32 | encoded := {33,d2} (2 bytes)
000dh  div r8   ; opcode := Div_rm64 | encoded := {49,f7,f0} (3 bytes)
0010h  mov rax,rdx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c2} (3 bytes)
0013h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5D50h ---------------------------------------------------------------------------------------------

7FFC86CC5D80h sbyte mod<sbyte>(sbyte lhs, sbyte rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xca, 0x99, 0xf7, 0xf9, 0x48, 0x0f, 0xbe, 0xc2, 0xc3}
asm-body-begin 7FFC86CC5D80h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c1} (4 bytes)
0009h  movsx rcx,dl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,ca} (4 bytes)
000dh  cdq   ; opcode := Cdq | encoded := {99} (1 bytes)
000eh  idiv ecx   ; opcode := Idiv_rm32 | encoded := {f7,f9} (2 bytes)
0010h  movsx rax,dl   ; opcode := Movsx_r64_rm8 | encoded := {48,0f,be,c2} (4 bytes)
0014h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5D80h ---------------------------------------------------------------------------------------------

7FFC86CC5DB0h short mod<short>(short lhs, short rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbf, 0xc1, 0x48, 0x0f, 0xbf, 0xca, 0x99, 0xf7, 0xf9, 0x48, 0x0f, 0xbf, 0xc2, 0xc3}
asm-body-begin 7FFC86CC5DB0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  movsx rax,cx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c1} (4 bytes)
0009h  movsx rcx,dx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,ca} (4 bytes)
000dh  cdq   ; opcode := Cdq | encoded := {99} (1 bytes)
000eh  idiv ecx   ; opcode := Idiv_rm32 | encoded := {f7,f9} (2 bytes)
0010h  movsx rax,dx   ; opcode := Movsx_r64_rm16 | encoded := {48,0f,bf,c2} (4 bytes)
0014h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5DB0h ---------------------------------------------------------------------------------------------

7FFC86CC5DE0h int mod<int>(int lhs, int rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x44, 0x8b, 0xc2, 0x8b, 0xc1, 0x99, 0x41, 0xf7, 0xf8, 0x8b, 0xc2, 0xc3}
asm-body-begin 7FFC86CC5DE0h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov r8d,edx   ; opcode := Mov_r32_rm32 | encoded := {44,8b,c2} (3 bytes)
0008h  mov eax,ecx   ; opcode := Mov_r32_rm32 | encoded := {8b,c1} (2 bytes)
000ah  cdq   ; opcode := Cdq | encoded := {99} (1 bytes)
000bh  idiv r8d   ; opcode := Idiv_rm32 | encoded := {41,f7,f8} (3 bytes)
000eh  mov eax,edx   ; opcode := Mov_r32_rm32 | encoded := {8b,c2} (2 bytes)
0010h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5DE0h ---------------------------------------------------------------------------------------------

7FFC86CC5E10h long mod<long>(long lhs, long rhs)
# encoding: {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x4c, 0x8b, 0xc2, 0x48, 0x8b, 0xc1, 0x48, 0x99, 0x49, 0xf7, 0xf8, 0x48, 0x8b, 0xc2, 0xc3}
asm-body-begin 7FFC86CC5E10h -------------------------------------------------------------------------------------------
0000h  nop dword ptr [rax+rax]   ; opcode := Nop_rm32 | encoded := {0f,1f,44,00,00} (5 bytes)
0005h  mov r8,rdx   ; opcode := Mov_r64_rm64 | encoded := {4c,8b,c2} (3 bytes)
0008h  mov rax,rcx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c1} (3 bytes)
000bh  cqo   ; opcode := Cqo | encoded := {48,99} (2 bytes)
000dh  idiv r8   ; opcode := Idiv_rm64 | encoded := {49,f7,f8} (3 bytes)
0010h  mov rax,rdx   ; opcode := Mov_r64_rm64 | encoded := {48,8b,c2} (3 bytes)
0013h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5E10h ---------------------------------------------------------------------------------------------

7FFC86CC5E40h float mod<float>(float lhs, float rhs)
# encoding: {0x48, 0x83, 0xec, 0x28, 0xc5, 0xf8, 0x77, 0xe8, 0x44, 0xd8, 0x77, 0x5f, 0x90, 0x48, 0x83, 0xc4, 0x28, 0xc3}
asm-body-begin 7FFC86CC5E40h -------------------------------------------------------------------------------------------
0000h  sub rsp,28h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,28} (4 bytes)
0004h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0007h  call 7FFCE6443690h   ; opcode := Call_rel32_64 | encoded := {e8,44,d8,77,5f} (5 bytes)
000ch  nop   ; opcode := Nopd | encoded := {90} (1 bytes)
000dh  add rsp,28h   ; opcode := Add_rm64_imm8 | encoded := {48,83,c4,28} (4 bytes)
0011h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5E40h ---------------------------------------------------------------------------------------------

7FFC86CC5E70h double mod<double>(double lhs, double rhs)
# encoding: {0x48, 0x83, 0xec, 0x28, 0xc5, 0xf8, 0x77, 0xe8, 0x84, 0xd7, 0x77, 0x5f, 0x90, 0x48, 0x83, 0xc4, 0x28, 0xc3}
asm-body-begin 7FFC86CC5E70h -------------------------------------------------------------------------------------------
0000h  sub rsp,28h   ; opcode := Sub_rm64_imm8 | encoded := {48,83,ec,28} (4 bytes)
0004h  vzeroupper   ; opcode := VEX_Vzeroupper (VEX encoded) | encoded := {c5,f8,77} (3 bytes)
0007h  call 7FFCE6443600h   ; opcode := Call_rel32_64 | encoded := {e8,84,d7,77,5f} (5 bytes)
000ch  nop   ; opcode := Nopd | encoded := {90} (1 bytes)
000dh  add rsp,28h   ; opcode := Add_rm64_imm8 | encoded := {48,83,c4,28} (4 bytes)
0011h  ret   ; opcode := Retnq | encoded := {c3} (1 bytes)
asm-body-end 7FFC86CC5E70h ---------------------------------------------------------------------------------------------

