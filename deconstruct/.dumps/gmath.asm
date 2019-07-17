# 2019-07-14 13:27:25:128
7FF968FA36D0h: byte sub<byte>(byte lhs, byte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx edx,dl
  000bh  sub eax,edx
  000dh  movzx eax,al
  0010h  ret
end asm ------------------------------------------------------------------------

7FF968FA3700h: ushort sub<ushort>(ushort lhs, ushort rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx edx,dx
  000bh  sub eax,edx
  000dh  movzx eax,ax
  0010h  ret
end asm ------------------------------------------------------------------------

7FF968FA3730h: uint sub<uint>(uint lhs, uint rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  sub eax,edx
  0009h  ret
end asm ------------------------------------------------------------------------

7FF968FA3B60h: ulong sub<ulong>(ulong lhs, ulong rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  sub rax,rdx
  000bh  ret
end asm ------------------------------------------------------------------------

7FF968FA3B80h: sbyte sub<sbyte>(sbyte lhs, sbyte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rdx,dl
  000dh  sub eax,edx
  000fh  movsx rax,al
  0013h  ret
end asm ------------------------------------------------------------------------

7FF968FA3BB0h: short sub<short>(short lhs, short rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rdx,dx
  000dh  sub eax,edx
  000fh  movsx rax,ax
  0013h  ret
end asm ------------------------------------------------------------------------

7FF968FA3BE0h: int sub<int>(int lhs, int rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  sub eax,edx
  0009h  ret
end asm ------------------------------------------------------------------------

7FF968FA3C00h: long sub<long>(long lhs, long rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  sub rax,rdx
  000bh  ret
end asm ------------------------------------------------------------------------

7FF968FA3C20h: float sub<float>(float lhs, float rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vsubss xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF968FA3C40h: double sub<double>(double lhs, double rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vsubsd xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF968FA3C60h: byte mul<byte>(byte lhs, byte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx edx,dl
  000bh  imul eax,edx
  000eh  movzx eax,al
  0011h  ret
end asm ------------------------------------------------------------------------

7FF968FA3C90h: ushort mul<ushort>(ushort lhs, ushort rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx edx,dx
  000bh  imul eax,edx
  000eh  movzx eax,ax
  0011h  ret
end asm ------------------------------------------------------------------------

7FF968FA3CC0h: uint mul<uint>(uint lhs, uint rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  imul eax,edx
  000ah  ret
end asm ------------------------------------------------------------------------

7FF968FA40F0h: ulong mul<ulong>(ulong lhs, ulong rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  imul rax,rdx
  000ch  ret
end asm ------------------------------------------------------------------------

7FF968FA4110h: sbyte mul<sbyte>(sbyte lhs, sbyte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rdx,dl
  000dh  imul eax,edx
  0010h  movsx rax,al
  0014h  ret
end asm ------------------------------------------------------------------------

7FF968FA4140h: short mul<short>(short lhs, short rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rdx,dx
  000dh  imul eax,edx
  0010h  movsx rax,ax
  0014h  ret
end asm ------------------------------------------------------------------------

7FF968FA4170h: int mul<int>(int lhs, int rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  imul eax,edx
  000ah  ret
end asm ------------------------------------------------------------------------

7FF968FA4190h: long mul<long>(long lhs, long rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  imul rax,rdx
  000ch  ret
end asm ------------------------------------------------------------------------

7FF968FA41B0h: float mul<float>(float lhs, float rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmulss xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF968FA41D0h: double mul<double>(double lhs, double rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmulsd xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF968FA41F0h: byte add<byte>(byte lhs, byte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx edx,dl
  000bh  add eax,edx
  000dh  movzx eax,al
  0010h  ret
end asm ------------------------------------------------------------------------

7FF968FA4220h: ushort add<ushort>(ushort lhs, ushort rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx edx,dx
  000bh  add eax,edx
  000dh  movzx eax,ax
  0010h  ret
end asm ------------------------------------------------------------------------

7FF968FA4250h: uint add<uint>(uint lhs, uint rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea eax,[rcx+rdx]
  0008h  ret
end asm ------------------------------------------------------------------------

7FF968FA4270h: ulong add<ulong>(ulong lhs, ulong rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea rax,[rcx+rdx]
  0009h  ret
end asm ------------------------------------------------------------------------

7FF968FA4290h: sbyte add<sbyte>(sbyte lhs, sbyte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rdx,dl
  000dh  add eax,edx
  000fh  movsx rax,al
  0013h  ret
end asm ------------------------------------------------------------------------

7FF968FA42C0h: short add<short>(short lhs, short rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rdx,dx
  000dh  add eax,edx
  000fh  movsx rax,ax
  0013h  ret
end asm ------------------------------------------------------------------------

7FF968FA42F0h: int add<int>(int lhs, int rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea eax,[rcx+rdx]
  0008h  ret
end asm ------------------------------------------------------------------------

7FF968FA4310h: long add<long>(long lhs, long rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea rax,[rcx+rdx]
  0009h  ret
end asm ------------------------------------------------------------------------

7FF968FA4330h: float add<float>(float lhs, float rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vaddss xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF968FA4350h: double add<double>(double lhs, double rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vaddsd xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF968FA4370h: byte div<byte>(byte lhs, byte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx ecx,dl
  000bh  cdq
  000ch  idiv ecx
  000eh  movzx eax,al
  0011h  ret
end asm ------------------------------------------------------------------------

7FF968FA43A0h: ushort div<ushort>(ushort lhs, ushort rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx ecx,dx
  000bh  cdq
  000ch  idiv ecx
  000eh  movzx eax,ax
  0011h  ret
end asm ------------------------------------------------------------------------

7FF968FA43D0h: uint div<uint>(uint lhs, uint rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8d,edx
  0008h  mov eax,ecx
  000ah  xor edx,edx
  000ch  div r8d
  000fh  ret
end asm ------------------------------------------------------------------------

7FF968FA43F0h: ulong div<ulong>(ulong lhs, ulong rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8,rdx
  0008h  mov rax,rcx
  000bh  xor edx,edx
  000dh  div r8
  0010h  ret
end asm ------------------------------------------------------------------------

7FF968FA4420h: sbyte div<sbyte>(sbyte lhs, sbyte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rcx,dl
  000dh  cdq
  000eh  idiv ecx
  0010h  movsx rax,al
  0014h  ret
end asm ------------------------------------------------------------------------

7FF968FA4450h: short div<short>(short lhs, short rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rcx,dx
  000dh  cdq
  000eh  idiv ecx
  0010h  movsx rax,ax
  0014h  ret
end asm ------------------------------------------------------------------------

7FF968FA4480h: int div<int>(int lhs, int rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8d,edx
  0008h  mov eax,ecx
  000ah  cdq
  000bh  idiv r8d
  000eh  ret
end asm ------------------------------------------------------------------------

7FF968FA44A0h: long div<long>(long lhs, long rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8,rdx
  0008h  mov rax,rcx
  000bh  cqo
  000dh  idiv r8
  0010h  ret
end asm ------------------------------------------------------------------------

7FF968FA44D0h: float div<float>(float lhs, float rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vdivss xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF968FA4900h: double div<double>(double lhs, double rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vdivsd xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

7FF968FA4920h: byte mod<byte>(byte lhs, byte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx ecx,dl
  000bh  cdq
  000ch  idiv ecx
  000eh  movzx eax,dl
  0011h  ret
end asm ------------------------------------------------------------------------

7FF968FA4950h: ushort mod<ushort>(ushort lhs, ushort rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx ecx,dx
  000bh  cdq
  000ch  idiv ecx
  000eh  movzx eax,dx
  0011h  ret
end asm ------------------------------------------------------------------------

7FF968FA4980h: uint mod<uint>(uint lhs, uint rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8d,edx
  0008h  mov eax,ecx
  000ah  xor edx,edx
  000ch  div r8d
  000fh  mov eax,edx
  0011h  ret
end asm ------------------------------------------------------------------------

7FF968FA49B0h: ulong mod<ulong>(ulong lhs, ulong rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8,rdx
  0008h  mov rax,rcx
  000bh  xor edx,edx
  000dh  div r8
  0010h  mov rax,rdx
  0013h  ret
end asm ------------------------------------------------------------------------

7FF968FA49E0h: sbyte mod<sbyte>(sbyte lhs, sbyte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rcx,dl
  000dh  cdq
  000eh  idiv ecx
  0010h  movsx rax,dl
  0014h  ret
end asm ------------------------------------------------------------------------

7FF968FA4A10h: short mod<short>(short lhs, short rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rcx,dx
  000dh  cdq
  000eh  idiv ecx
  0010h  movsx rax,dx
  0014h  ret
end asm ------------------------------------------------------------------------

7FF968FA4A40h: int mod<int>(int lhs, int rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8d,edx
  0008h  mov eax,ecx
  000ah  cdq
  000bh  idiv r8d
  000eh  mov eax,edx
  0010h  ret
end asm ------------------------------------------------------------------------

7FF968FA4A70h: long mod<long>(long lhs, long rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8,rdx
  0008h  mov rax,rcx
  000bh  cqo
  000dh  idiv r8
  0010h  mov rax,rdx
  0013h  ret
end asm ------------------------------------------------------------------------

7FF968FA4AA0h: float mod<float>(float lhs, float rhs)
asm ----------------------------------------------------------------------------
  0000h  sub rsp,28h
  0004h  vzeroupper
  0007h  call 7FF9C8740D90h
  000ch  nop
  000dh  add rsp,28h
  0011h  ret
end asm ------------------------------------------------------------------------

7FF968FA4AD0h: double mod<double>(double lhs, double rhs)
asm ----------------------------------------------------------------------------
  0000h  sub rsp,28h
  0004h  vzeroupper
  0007h  call 7FF9C8740D00h
  000ch  nop
  000dh  add rsp,28h
  0011h  ret
end asm ------------------------------------------------------------------------

