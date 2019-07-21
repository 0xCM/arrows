# 2019-07-20 02:42:59:118
7FF9672F48A0h: byte sub<byte>(byte lhs, byte rhs)
;; 0f 1f 44 00 00 0f b6 c1 0f b6 d2 2b c2 0f b6 c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx edx,dl
  000bh  sub eax,edx
  000dh  movzx eax,al
  0010h  ret
end asm ------------------------------------------------------------------------

7FF9672F48D0h: ushort sub<ushort>(ushort lhs, ushort rhs)
;; 0f 1f 44 00 00 0f b7 c1 0f b7 d2 2b c2 0f b7 c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx edx,dx
  000bh  sub eax,edx
  000dh  movzx eax,ax
  0010h  ret
end asm ------------------------------------------------------------------------

7FF9672F4900h: uint sub<uint>(uint lhs, uint rhs)
;; 0f 1f 44 00 00 8b c1 2b c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  sub eax,edx
  0009h  ret
end asm ------------------------------------------------------------------------

7FF9672F4920h: ulong sub<ulong>(ulong lhs, ulong rhs)
;; 0f 1f 44 00 00 48 8b c1 48 2b c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  sub rax,rdx
  000bh  ret
end asm ------------------------------------------------------------------------

7FF9672F4940h: sbyte sub<sbyte>(sbyte lhs, sbyte rhs)
;; 0f 1f 44 00 00 48 0f be c1 48 0f be d2 2b c2 48 0f be c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rdx,dl
  000dh  sub eax,edx
  000fh  movsx rax,al
  0013h  ret
end asm ------------------------------------------------------------------------

7FF9672F4970h: short sub<short>(short lhs, short rhs)
;; 0f 1f 44 00 00 48 0f bf c1 48 0f bf d2 2b c2 48 0f bf c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rdx,dx
  000dh  sub eax,edx
  000fh  movsx rax,ax
  0013h  ret
end asm ------------------------------------------------------------------------

7FF9672F49A0h: int sub<int>(int lhs, int rhs)
;; 0f 1f 44 00 00 8b c1 2b c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  sub eax,edx
  0009h  ret
end asm ------------------------------------------------------------------------

7FF9672F49C0h: long sub<long>(long lhs, long rhs)
;; 0f 1f 44 00 00 48 8b c1 48 2b c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  sub rax,rdx
  000bh  ret
end asm ------------------------------------------------------------------------

7FF9672F4DF0h: float sub<float>(float lhs, float rhs)
;; c5 f8 77 66 90 c5 fa 5c c1 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vsubss xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF9672F4E10h: double sub<double>(double lhs, double rhs)
;; c5 f8 77 66 90 c5 fb 5c c1 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vsubsd xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF9672F4E30h: byte mul<byte>(byte lhs, byte rhs)
;; 0f 1f 44 00 00 0f b6 c1 0f b6 d2 0f af c2 0f b6 c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx edx,dl
  000bh  imul eax,edx
  000eh  movzx eax,al
  0011h  ret
end asm ------------------------------------------------------------------------

7FF9672F4E60h: ushort mul<ushort>(ushort lhs, ushort rhs)
;; 0f 1f 44 00 00 0f b7 c1 0f b7 d2 0f af c2 0f b7 c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx edx,dx
  000bh  imul eax,edx
  000eh  movzx eax,ax
  0011h  ret
end asm ------------------------------------------------------------------------

7FF9672F4E90h: uint mul<uint>(uint lhs, uint rhs)
;; 0f 1f 44 00 00 8b c1 0f af c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  imul eax,edx
  000ah  ret
end asm ------------------------------------------------------------------------

7FF9672F4EB0h: ulong mul<ulong>(ulong lhs, ulong rhs)
;; 0f 1f 44 00 00 48 8b c1 48 0f af c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  imul rax,rdx
  000ch  ret
end asm ------------------------------------------------------------------------

7FF9672F4ED0h: sbyte mul<sbyte>(sbyte lhs, sbyte rhs)
;; 0f 1f 44 00 00 48 0f be c1 48 0f be d2 0f af c2 48 0f be c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rdx,dl
  000dh  imul eax,edx
  0010h  movsx rax,al
  0014h  ret
end asm ------------------------------------------------------------------------

7FF9672F4F00h: short mul<short>(short lhs, short rhs)
;; 0f 1f 44 00 00 48 0f bf c1 48 0f bf d2 0f af c2 48 0f bf c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rdx,dx
  000dh  imul eax,edx
  0010h  movsx rax,ax
  0014h  ret
end asm ------------------------------------------------------------------------

7FF9672F4F30h: int mul<int>(int lhs, int rhs)
;; 0f 1f 44 00 00 8b c1 0f af c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  imul eax,edx
  000ah  ret
end asm ------------------------------------------------------------------------

7FF9672F4F50h: long mul<long>(long lhs, long rhs)
;; 0f 1f 44 00 00 48 8b c1 48 0f af c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  imul rax,rdx
  000ch  ret
end asm ------------------------------------------------------------------------

7FF9672F4F70h: float mul<float>(float lhs, float rhs)
;; c5 f8 77 66 90 c5 fa 59 c1 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmulss xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF9672F4F90h: double mul<double>(double lhs, double rhs)
;; c5 f8 77 66 90 c5 fb 59 c1 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmulsd xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF9672F4FB0h: byte add<byte>(byte lhs, byte rhs)
;; 0f 1f 44 00 00 0f b6 c1 0f b6 d2 03 c2 0f b6 c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx edx,dl
  000bh  add eax,edx
  000dh  movzx eax,al
  0010h  ret
end asm ------------------------------------------------------------------------

7FF9672F4FE0h: ushort add<ushort>(ushort lhs, ushort rhs)
;; 0f 1f 44 00 00 0f b7 c1 0f b7 d2 03 c2 0f b7 c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx edx,dx
  000bh  add eax,edx
  000dh  movzx eax,ax
  0010h  ret
end asm ------------------------------------------------------------------------

7FF9672F5010h: uint add<uint>(uint lhs, uint rhs)
;; 0f 1f 44 00 00 8d 04 11 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea eax,[rcx+rdx]
  0008h  ret
end asm ------------------------------------------------------------------------

7FF9672F5030h: ulong add<ulong>(ulong lhs, ulong rhs)
;; 0f 1f 44 00 00 48 8d 04 11 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea rax,[rcx+rdx]
  0009h  ret
end asm ------------------------------------------------------------------------

7FF9672F5460h: sbyte add<sbyte>(sbyte lhs, sbyte rhs)
;; 0f 1f 44 00 00 48 0f be c1 48 0f be d2 03 c2 48 0f be c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rdx,dl
  000dh  add eax,edx
  000fh  movsx rax,al
  0013h  ret
end asm ------------------------------------------------------------------------

7FF9672F5490h: short add<short>(short lhs, short rhs)
;; 0f 1f 44 00 00 48 0f bf c1 48 0f bf d2 03 c2 48 0f bf c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rdx,dx
  000dh  add eax,edx
  000fh  movsx rax,ax
  0013h  ret
end asm ------------------------------------------------------------------------

7FF9672F54C0h: int add<int>(int lhs, int rhs)
;; 0f 1f 44 00 00 8d 04 11 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea eax,[rcx+rdx]
  0008h  ret
end asm ------------------------------------------------------------------------

7FF9672F54E0h: long add<long>(long lhs, long rhs)
;; 0f 1f 44 00 00 48 8d 04 11 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea rax,[rcx+rdx]
  0009h  ret
end asm ------------------------------------------------------------------------

7FF9672F5500h: float add<float>(float lhs, float rhs)
;; c5 f8 77 66 90 c5 fa 58 c1 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vaddss xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF9672F5520h: double add<double>(double lhs, double rhs)
;; c5 f8 77 66 90 c5 fb 58 c1 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vaddsd xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF9672F5540h: byte div<byte>(byte lhs, byte rhs)
;; 0f 1f 44 00 00 0f b6 c1 0f b6 ca 99 f7 f9 0f b6 c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx ecx,dl
  000bh  cdq
  000ch  idiv ecx
  000eh  movzx eax,al
  0011h  ret
end asm ------------------------------------------------------------------------

7FF9672F5570h: ushort div<ushort>(ushort lhs, ushort rhs)
;; 0f 1f 44 00 00 0f b7 c1 0f b7 ca 99 f7 f9 0f b7 c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx ecx,dx
  000bh  cdq
  000ch  idiv ecx
  000eh  movzx eax,ax
  0011h  ret
end asm ------------------------------------------------------------------------

7FF9672F55A0h: uint div<uint>(uint lhs, uint rhs)
;; 0f 1f 44 00 00 44 8b c2 8b c1 33 d2 41 f7 f0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8d,edx
  0008h  mov eax,ecx
  000ah  xor edx,edx
  000ch  div r8d
  000fh  ret
end asm ------------------------------------------------------------------------

7FF9672F55C0h: ulong div<ulong>(ulong lhs, ulong rhs)
;; 0f 1f 44 00 00 4c 8b c2 48 8b c1 33 d2 49 f7 f0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8,rdx
  0008h  mov rax,rcx
  000bh  xor edx,edx
  000dh  div r8
  0010h  ret
end asm ------------------------------------------------------------------------

7FF9672F55F0h: sbyte div<sbyte>(sbyte lhs, sbyte rhs)
;; 0f 1f 44 00 00 48 0f be c1 48 0f be ca 99 f7 f9 48 0f be c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rcx,dl
  000dh  cdq
  000eh  idiv ecx
  0010h  movsx rax,al
  0014h  ret
end asm ------------------------------------------------------------------------

7FF9672F5620h: short div<short>(short lhs, short rhs)
;; 0f 1f 44 00 00 48 0f bf c1 48 0f bf ca 99 f7 f9 48 0f bf c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rcx,dx
  000dh  cdq
  000eh  idiv ecx
  0010h  movsx rax,ax
  0014h  ret
end asm ------------------------------------------------------------------------

7FF9672F5650h: int div<int>(int lhs, int rhs)
;; 0f 1f 44 00 00 44 8b c2 8b c1 99 41 f7 f8 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8d,edx
  0008h  mov eax,ecx
  000ah  cdq
  000bh  idiv r8d
  000eh  ret
end asm ------------------------------------------------------------------------

7FF9672F5670h: long div<long>(long lhs, long rhs)
;; 0f 1f 44 00 00 4c 8b c2 48 8b c1 48 99 49 f7 f8 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8,rdx
  0008h  mov rax,rcx
  000bh  cqo
  000dh  idiv r8
  0010h  ret
end asm ------------------------------------------------------------------------

7FF9672F56A0h: float div<float>(float lhs, float rhs)
;; c5 f8 77 66 90 c5 fa 5e c1 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vdivss xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF9672F56C0h: double div<double>(double lhs, double rhs)
;; c5 f8 77 66 90 c5 fb 5e c1 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vdivsd xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF9672F56E0h: byte mod<byte>(byte lhs, byte rhs)
;; 0f 1f 44 00 00 0f b6 c1 0f b6 ca 99 f7 f9 0f b6 c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx ecx,dl
  000bh  cdq
  000ch  idiv ecx
  000eh  movzx eax,dl
  0011h  ret
end asm ------------------------------------------------------------------------

7FF9672F5710h: ushort mod<ushort>(ushort lhs, ushort rhs)
;; 0f 1f 44 00 00 0f b7 c1 0f b7 ca 99 f7 f9 0f b7 c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx ecx,dx
  000bh  cdq
  000ch  idiv ecx
  000eh  movzx eax,dx
  0011h  ret
end asm ------------------------------------------------------------------------

7FF9672F5740h: uint mod<uint>(uint lhs, uint rhs)
;; 0f 1f 44 00 00 44 8b c2 8b c1 33 d2 41 f7 f0 8b c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8d,edx
  0008h  mov eax,ecx
  000ah  xor edx,edx
  000ch  div r8d
  000fh  mov eax,edx
  0011h  ret
end asm ------------------------------------------------------------------------

7FF9672F5770h: ulong mod<ulong>(ulong lhs, ulong rhs)
;; 0f 1f 44 00 00 4c 8b c2 48 8b c1 33 d2 49 f7 f0 48 8b c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8,rdx
  0008h  mov rax,rcx
  000bh  xor edx,edx
  000dh  div r8
  0010h  mov rax,rdx
  0013h  ret
end asm ------------------------------------------------------------------------

7FF9672F57A0h: sbyte mod<sbyte>(sbyte lhs, sbyte rhs)
;; 0f 1f 44 00 00 48 0f be c1 48 0f be ca 99 f7 f9 48 0f be c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rcx,dl
  000dh  cdq
  000eh  idiv ecx
  0010h  movsx rax,dl
  0014h  ret
end asm ------------------------------------------------------------------------

7FF9672F57D0h: short mod<short>(short lhs, short rhs)
;; 0f 1f 44 00 00 48 0f bf c1 48 0f bf ca 99 f7 f9 48 0f bf c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rcx,dx
  000dh  cdq
  000eh  idiv ecx
  0010h  movsx rax,dx
  0014h  ret
end asm ------------------------------------------------------------------------

7FF9672F5800h: int mod<int>(int lhs, int rhs)
;; 0f 1f 44 00 00 44 8b c2 8b c1 99 41 f7 f8 8b c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8d,edx
  0008h  mov eax,ecx
  000ah  cdq
  000bh  idiv r8d
  000eh  mov eax,edx
  0010h  ret
end asm ------------------------------------------------------------------------

7FF9672F5830h: long mod<long>(long lhs, long rhs)
;; 0f 1f 44 00 00 4c 8b c2 48 8b c1 48 99 49 f7 f8 48 8b c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8,rdx
  0008h  mov rax,rcx
  000bh  cqo
  000dh  idiv r8
  0010h  mov rax,rdx
  0013h  ret
end asm ------------------------------------------------------------------------

7FF9672F5C60h: float mod<float>(float lhs, float rhs)
;; 48 83 ec 28 c5 f8 77 e8 24 b1 7c 5f 90 48 83 c4 28 c3 
asm ----------------------------------------------------------------------------
  0000h  sub rsp,28h
  0004h  vzeroupper
  0007h  call 7FF9C6AC0D90h
  000ch  nop
  000dh  add rsp,28h
  0011h  ret
end asm ------------------------------------------------------------------------

7FF9672F5C90h: double mod<double>(double lhs, double rhs)
;; 48 83 ec 28 c5 f8 77 e8 64 b0 7c 5f 90 48 83 c4 28 c3 
asm ----------------------------------------------------------------------------
  0000h  sub rsp,28h
  0004h  vzeroupper
  0007h  call 7FF9C6AC0D00h
  000ch  nop
  000dh  add rsp,28h
  0011h  ret
end asm ------------------------------------------------------------------------

