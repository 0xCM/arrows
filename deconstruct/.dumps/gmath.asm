# 2019-07-24 20:36:15:046
7FF95A3E4DA0h: byte sub<byte>(byte lhs, byte rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xd2, 0x2b, 0xc2, 0x0f, 0xb6, 0xc0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx edx,dl
  000bh  sub eax,edx
  000dh  movzx eax,al
  0010h  ret
end asm ------------------------------------------------------------------------

7FF95A3E4DD0h: ushort sub<ushort>(ushort lhs, ushort rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xd2, 0x2b, 0xc2, 0x0f, 0xb7, 0xc0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx edx,dx
  000bh  sub eax,edx
  000dh  movzx eax,ax
  0010h  ret
end asm ------------------------------------------------------------------------

7FF95A3E4E00h: uint sub<uint>(uint lhs, uint rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x2b, 0xc2, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  sub eax,edx
  0009h  ret
end asm ------------------------------------------------------------------------

7FF95A3E4E20h: ulong sub<ulong>(ulong lhs, ulong rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x48, 0x2b, 0xc2, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  sub rax,rdx
  000bh  ret
end asm ------------------------------------------------------------------------

7FF95A3E4E40h: sbyte sub<sbyte>(sbyte lhs, sbyte rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xd2, 0x2b, 0xc2, 0x48, 0x0f, 0xbe, 0xc0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rdx,dl
  000dh  sub eax,edx
  000fh  movsx rax,al
  0013h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5270h: short sub<short>(short lhs, short rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbf, 0xc1, 0x48, 0x0f, 0xbf, 0xd2, 0x2b, 0xc2, 0x48, 0x0f, 0xbf, 0xc0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rdx,dx
  000dh  sub eax,edx
  000fh  movsx rax,ax
  0013h  ret
end asm ------------------------------------------------------------------------

7FF95A3E52A0h: int sub<int>(int lhs, int rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x2b, 0xc2, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  sub eax,edx
  0009h  ret
end asm ------------------------------------------------------------------------

7FF95A3E52C0h: long sub<long>(long lhs, long rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x48, 0x2b, 0xc2, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  sub rax,rdx
  000bh  ret
end asm ------------------------------------------------------------------------

7FF95A3E52E0h: float sub<float>(float lhs, float rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfa, 0x5c, 0xc1, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vsubss xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5300h: double sub<double>(double lhs, double rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfb, 0x5c, 0xc1, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vsubsd xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5320h: byte mul<byte>(byte lhs, byte rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xd2, 0x0f, 0xaf, 0xc2, 0x0f, 0xb6, 0xc0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx edx,dl
  000bh  imul eax,edx
  000eh  movzx eax,al
  0011h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5350h: ushort mul<ushort>(ushort lhs, ushort rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xd2, 0x0f, 0xaf, 0xc2, 0x0f, 0xb7, 0xc0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx edx,dx
  000bh  imul eax,edx
  000eh  movzx eax,ax
  0011h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5380h: uint mul<uint>(uint lhs, uint rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x0f, 0xaf, 0xc2, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  imul eax,edx
  000ah  ret
end asm ------------------------------------------------------------------------

7FF95A3E53A0h: ulong mul<ulong>(ulong lhs, ulong rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x48, 0x0f, 0xaf, 0xc2, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  imul rax,rdx
  000ch  ret
end asm ------------------------------------------------------------------------

7FF95A3E53C0h: sbyte mul<sbyte>(sbyte lhs, sbyte rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xd2, 0x0f, 0xaf, 0xc2, 0x48, 0x0f, 0xbe, 0xc0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rdx,dl
  000dh  imul eax,edx
  0010h  movsx rax,al
  0014h  ret
end asm ------------------------------------------------------------------------

7FF95A3E53F0h: short mul<short>(short lhs, short rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbf, 0xc1, 0x48, 0x0f, 0xbf, 0xd2, 0x0f, 0xaf, 0xc2, 0x48, 0x0f, 0xbf, 0xc0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rdx,dx
  000dh  imul eax,edx
  0010h  movsx rax,ax
  0014h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5820h: int mul<int>(int lhs, int rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8b, 0xc1, 0x0f, 0xaf, 0xc2, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  imul eax,edx
  000ah  ret
end asm ------------------------------------------------------------------------

7FF95A3E5840h: long mul<long>(long lhs, long rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8b, 0xc1, 0x48, 0x0f, 0xaf, 0xc2, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  imul rax,rdx
  000ch  ret
end asm ------------------------------------------------------------------------

7FF95A3E5860h: float mul<float>(float lhs, float rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfa, 0x59, 0xc1, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmulss xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5880h: double mul<double>(double lhs, double rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfb, 0x59, 0xc1, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmulsd xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF95A3E58A0h: byte add<byte>(byte lhs, byte rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xd2, 0x03, 0xc2, 0x0f, 0xb6, 0xc0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx edx,dl
  000bh  add eax,edx
  000dh  movzx eax,al
  0010h  ret
end asm ------------------------------------------------------------------------

7FF95A3E58D0h: ushort add<ushort>(ushort lhs, ushort rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xd2, 0x03, 0xc2, 0x0f, 0xb7, 0xc0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx edx,dx
  000bh  add eax,edx
  000dh  movzx eax,ax
  0010h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5900h: uint add<uint>(uint lhs, uint rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8d, 0x04, 0x11, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea eax,[rcx+rdx]
  0008h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5920h: ulong add<ulong>(ulong lhs, ulong rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8d, 0x04, 0x11, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea rax,[rcx+rdx]
  0009h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5940h: sbyte add<sbyte>(sbyte lhs, sbyte rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xd2, 0x03, 0xc2, 0x48, 0x0f, 0xbe, 0xc0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rdx,dl
  000dh  add eax,edx
  000fh  movsx rax,al
  0013h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5970h: short add<short>(short lhs, short rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbf, 0xc1, 0x48, 0x0f, 0xbf, 0xd2, 0x03, 0xc2, 0x48, 0x0f, 0xbf, 0xc0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rdx,dx
  000dh  add eax,edx
  000fh  movsx rax,ax
  0013h  ret
end asm ------------------------------------------------------------------------

7FF95A3E59A0h: int add<int>(int lhs, int rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8d, 0x04, 0x11, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea eax,[rcx+rdx]
  0008h  ret
end asm ------------------------------------------------------------------------

7FF95A3E59C0h: long add<long>(long lhs, long rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x8d, 0x04, 0x11, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea rax,[rcx+rdx]
  0009h  ret
end asm ------------------------------------------------------------------------

7FF95A3E59E0h: float add<float>(float lhs, float rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfa, 0x58, 0xc1, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vaddss xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5A00h: double add<double>(double lhs, double rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfb, 0x58, 0xc1, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vaddsd xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5A20h: byte div<byte>(byte lhs, byte rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xca, 0x99, 0xf7, 0xf9, 0x0f, 0xb6, 0xc0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx ecx,dl
  000bh  cdq
  000ch  idiv ecx
  000eh  movzx eax,al
  0011h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5A50h: ushort div<ushort>(ushort lhs, ushort rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xca, 0x99, 0xf7, 0xf9, 0x0f, 0xb7, 0xc0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx ecx,dx
  000bh  cdq
  000ch  idiv ecx
  000eh  movzx eax,ax
  0011h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5A80h: uint div<uint>(uint lhs, uint rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x44, 0x8b, 0xc2, 0x8b, 0xc1, 0x33, 0xd2, 0x41, 0xf7, 0xf0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8d,edx
  0008h  mov eax,ecx
  000ah  xor edx,edx
  000ch  div r8d
  000fh  ret
end asm ------------------------------------------------------------------------

7FF95A3E5AA0h: ulong div<ulong>(ulong lhs, ulong rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x4c, 0x8b, 0xc2, 0x48, 0x8b, 0xc1, 0x33, 0xd2, 0x49, 0xf7, 0xf0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8,rdx
  0008h  mov rax,rcx
  000bh  xor edx,edx
  000dh  div r8
  0010h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5AD0h: sbyte div<sbyte>(sbyte lhs, sbyte rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xca, 0x99, 0xf7, 0xf9, 0x48, 0x0f, 0xbe, 0xc0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rcx,dl
  000dh  cdq
  000eh  idiv ecx
  0010h  movsx rax,al
  0014h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5B00h: short div<short>(short lhs, short rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbf, 0xc1, 0x48, 0x0f, 0xbf, 0xca, 0x99, 0xf7, 0xf9, 0x48, 0x0f, 0xbf, 0xc0, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rcx,dx
  000dh  cdq
  000eh  idiv ecx
  0010h  movsx rax,ax
  0014h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5B30h: int div<int>(int lhs, int rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x44, 0x8b, 0xc2, 0x8b, 0xc1, 0x99, 0x41, 0xf7, 0xf8, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8d,edx
  0008h  mov eax,ecx
  000ah  cdq
  000bh  idiv r8d
  000eh  ret
end asm ------------------------------------------------------------------------

7FF95A3E5B50h: long div<long>(long lhs, long rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x4c, 0x8b, 0xc2, 0x48, 0x8b, 0xc1, 0x48, 0x99, 0x49, 0xf7, 0xf8, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8,rdx
  0008h  mov rax,rcx
  000bh  cqo
  000dh  idiv r8
  0010h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5B80h: float div<float>(float lhs, float rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfa, 0x5e, 0xc1, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vdivss xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5BA0h: double div<double>(double lhs, double rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfb, 0x5e, 0xc1, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vdivsd xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5BC0h: byte mod<byte>(byte lhs, byte rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xca, 0x99, 0xf7, 0xf9, 0x0f, 0xb6, 0xc2, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx ecx,dl
  000bh  cdq
  000ch  idiv ecx
  000eh  movzx eax,dl
  0011h  ret
end asm ------------------------------------------------------------------------

7FF95A3E5BF0h: ushort mod<ushort>(ushort lhs, ushort rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb7, 0xc1, 0x0f, 0xb7, 0xca, 0x99, 0xf7, 0xf9, 0x0f, 0xb7, 0xc2, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx ecx,dx
  000bh  cdq
  000ch  idiv ecx
  000eh  movzx eax,dx
  0011h  ret
end asm ------------------------------------------------------------------------

7FF95A3E6020h: uint mod<uint>(uint lhs, uint rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x44, 0x8b, 0xc2, 0x8b, 0xc1, 0x33, 0xd2, 0x41, 0xf7, 0xf0, 0x8b, 0xc2, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8d,edx
  0008h  mov eax,ecx
  000ah  xor edx,edx
  000ch  div r8d
  000fh  mov eax,edx
  0011h  ret
end asm ------------------------------------------------------------------------

7FF95A3E6050h: ulong mod<ulong>(ulong lhs, ulong rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x4c, 0x8b, 0xc2, 0x48, 0x8b, 0xc1, 0x33, 0xd2, 0x49, 0xf7, 0xf0, 0x48, 0x8b, 0xc2, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8,rdx
  0008h  mov rax,rcx
  000bh  xor edx,edx
  000dh  div r8
  0010h  mov rax,rdx
  0013h  ret
end asm ------------------------------------------------------------------------

7FF95A3E6080h: sbyte mod<sbyte>(sbyte lhs, sbyte rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xca, 0x99, 0xf7, 0xf9, 0x48, 0x0f, 0xbe, 0xc2, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rcx,dl
  000dh  cdq
  000eh  idiv ecx
  0010h  movsx rax,dl
  0014h  ret
end asm ------------------------------------------------------------------------

7FF95A3E60B0h: short mod<short>(short lhs, short rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbf, 0xc1, 0x48, 0x0f, 0xbf, 0xca, 0x99, 0xf7, 0xf9, 0x48, 0x0f, 0xbf, 0xc2, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rcx,dx
  000dh  cdq
  000eh  idiv ecx
  0010h  movsx rax,dx
  0014h  ret
end asm ------------------------------------------------------------------------

7FF95A3E60E0h: int mod<int>(int lhs, int rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x44, 0x8b, 0xc2, 0x8b, 0xc1, 0x99, 0x41, 0xf7, 0xf8, 0x8b, 0xc2, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8d,edx
  0008h  mov eax,ecx
  000ah  cdq
  000bh  idiv r8d
  000eh  mov eax,edx
  0010h  ret
end asm ------------------------------------------------------------------------

7FF95A3E6110h: long mod<long>(long lhs, long rhs)
;; {0x0f, 0x1f, 0x44, 0x00, 0x00, 0x4c, 0x8b, 0xc2, 0x48, 0x8b, 0xc1, 0x48, 0x99, 0x49, 0xf7, 0xf8, 0x48, 0x8b, 0xc2, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8,rdx
  0008h  mov rax,rcx
  000bh  cqo
  000dh  idiv r8
  0010h  mov rax,rdx
  0013h  ret
end asm ------------------------------------------------------------------------

7FF95A3E6140h: float mod<float>(float lhs, float rhs)
;; {0x48, 0x83, 0xec, 0x28, 0xc5, 0xf8, 0x77, 0xe8, 0x44, 0xac, 0x7d, 0x5f, 0x90, 0x48, 0x83, 0xc4, 0x28, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  sub rsp,28h
  0004h  vzeroupper
  0007h  call 7FF9B9BC0D90h
  000ch  nop
  000dh  add rsp,28h
  0011h  ret
end asm ------------------------------------------------------------------------

7FF95A3E6170h: double mod<double>(double lhs, double rhs)
;; {0x48, 0x83, 0xec, 0x28, 0xc5, 0xf8, 0x77, 0xe8, 0x84, 0xab, 0x7d, 0x5f, 0x90, 0x48, 0x83, 0xc4, 0x28, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  sub rsp,28h
  0004h  vzeroupper
  0007h  call 7FF9B9BC0D00h
  000ch  nop
  000dh  add rsp,28h
  0011h  ret
end asm ------------------------------------------------------------------------

