# 2019-07-01 01:15:29:912
byte sub<byte>(byte lhs, byte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx edx,dl
  000bh  sub eax,edx
  000dh  movzx eax,al
  0010h  ret
end asm ------------------------------------------------------------------------

ushort sub<ushort>(ushort lhs, ushort rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx edx,dx
  000bh  sub eax,edx
  000dh  movzx eax,ax
  0010h  ret
end asm ------------------------------------------------------------------------

uint sub<uint>(uint lhs, uint rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  sub eax,edx
  0009h  ret
end asm ------------------------------------------------------------------------

ulong sub<ulong>(ulong lhs, ulong rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  sub rax,rdx
  000bh  ret
end asm ------------------------------------------------------------------------

sbyte sub<sbyte>(sbyte lhs, sbyte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rdx,dl
  000dh  sub eax,edx
  000fh  movsx rax,al
  0013h  ret
end asm ------------------------------------------------------------------------

short sub<short>(short lhs, short rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rdx,dx
  000dh  sub eax,edx
  000fh  movsx rax,ax
  0013h  ret
end asm ------------------------------------------------------------------------

int sub<int>(int lhs, int rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  sub eax,edx
  0009h  ret
end asm ------------------------------------------------------------------------

long sub<long>(long lhs, long rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  sub rax,rdx
  000bh  ret
end asm ------------------------------------------------------------------------

float sub<float>(float lhs, float rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vsubss xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

double sub<double>(double lhs, double rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vsubsd xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

byte mul<byte>(byte lhs, byte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx edx,dl
  000bh  imul eax,edx
  000eh  movzx eax,al
  0011h  ret
end asm ------------------------------------------------------------------------

ushort mul<ushort>(ushort lhs, ushort rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx edx,dx
  000bh  imul eax,edx
  000eh  movzx eax,ax
  0011h  ret
end asm ------------------------------------------------------------------------

uint mul<uint>(uint lhs, uint rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  imul eax,edx
  000ah  ret
end asm ------------------------------------------------------------------------

ulong mul<ulong>(ulong lhs, ulong rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  imul rax,rdx
  000ch  ret
end asm ------------------------------------------------------------------------

sbyte mul<sbyte>(sbyte lhs, sbyte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rdx,dl
  000dh  imul eax,edx
  0010h  movsx rax,al
  0014h  ret
end asm ------------------------------------------------------------------------

short mul<short>(short lhs, short rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rdx,dx
  000dh  imul eax,edx
  0010h  movsx rax,ax
  0014h  ret
end asm ------------------------------------------------------------------------

int mul<int>(int lhs, int rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  imul eax,edx
  000ah  ret
end asm ------------------------------------------------------------------------

long mul<long>(long lhs, long rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  imul rax,rdx
  000ch  ret
end asm ------------------------------------------------------------------------

float mul<float>(float lhs, float rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmulss xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

double mul<double>(double lhs, double rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmulsd xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

byte add<byte>(byte lhs, byte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx edx,dl
  000bh  add eax,edx
  000dh  movzx eax,al
  0010h  ret
end asm ------------------------------------------------------------------------

ushort add<ushort>(ushort lhs, ushort rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx edx,dx
  000bh  add eax,edx
  000dh  movzx eax,ax
  0010h  ret
end asm ------------------------------------------------------------------------

uint add<uint>(uint lhs, uint rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea eax,[rcx+rdx]
  0008h  ret
end asm ------------------------------------------------------------------------

ulong add<ulong>(ulong lhs, ulong rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea rax,[rcx+rdx]
  0009h  ret
end asm ------------------------------------------------------------------------

sbyte add<sbyte>(sbyte lhs, sbyte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rdx,dl
  000dh  add eax,edx
  000fh  movsx rax,al
  0013h  ret
end asm ------------------------------------------------------------------------

short add<short>(short lhs, short rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rdx,dx
  000dh  add eax,edx
  000fh  movsx rax,ax
  0013h  ret
end asm ------------------------------------------------------------------------

int add<int>(int lhs, int rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea eax,[rcx+rdx]
  0008h  ret
end asm ------------------------------------------------------------------------

long add<long>(long lhs, long rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea rax,[rcx+rdx]
  0009h  ret
end asm ------------------------------------------------------------------------

float add<float>(float lhs, float rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vaddss xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

double add<double>(double lhs, double rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vaddsd xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

byte div<byte>(byte lhs, byte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx ecx,dl
  000bh  cdq
  000ch  idiv ecx
  000eh  movzx eax,al
  0011h  ret
end asm ------------------------------------------------------------------------

ushort div<ushort>(ushort lhs, ushort rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx ecx,dx
  000bh  cdq
  000ch  idiv ecx
  000eh  movzx eax,ax
  0011h  ret
end asm ------------------------------------------------------------------------

uint div<uint>(uint lhs, uint rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8d,edx
  0008h  mov eax,ecx
  000ah  xor edx,edx
  000ch  div r8d
  000fh  ret
end asm ------------------------------------------------------------------------

ulong div<ulong>(ulong lhs, ulong rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8,rdx
  0008h  mov rax,rcx
  000bh  xor edx,edx
  000dh  div r8
  0010h  ret
end asm ------------------------------------------------------------------------

sbyte div<sbyte>(sbyte lhs, sbyte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rcx,dl
  000dh  cdq
  000eh  idiv ecx
  0010h  movsx rax,al
  0014h  ret
end asm ------------------------------------------------------------------------

short div<short>(short lhs, short rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rcx,dx
  000dh  cdq
  000eh  idiv ecx
  0010h  movsx rax,ax
  0014h  ret
end asm ------------------------------------------------------------------------

int div<int>(int lhs, int rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8d,edx
  0008h  mov eax,ecx
  000ah  cdq
  000bh  idiv r8d
  000eh  ret
end asm ------------------------------------------------------------------------

long div<long>(long lhs, long rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8,rdx
  0008h  mov rax,rcx
  000bh  cqo
  000dh  idiv r8
  0010h  ret
end asm ------------------------------------------------------------------------

float div<float>(float lhs, float rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vdivss xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

double div<double>(double lhs, double rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vdivsd xmm0,xmm0,xmm1
  0009h  ret
end asm ------------------------------------------------------------------------

byte mod<byte>(byte lhs, byte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx ecx,dl
  000bh  cdq
  000ch  idiv ecx
  000eh  movzx eax,dl
  0011h  ret
end asm ------------------------------------------------------------------------

ushort mod<ushort>(ushort lhs, ushort rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx ecx,dx
  000bh  cdq
  000ch  idiv ecx
  000eh  movzx eax,dx
  0011h  ret
end asm ------------------------------------------------------------------------

uint mod<uint>(uint lhs, uint rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8d,edx
  0008h  mov eax,ecx
  000ah  xor edx,edx
  000ch  div r8d
  000fh  mov eax,edx
  0011h  ret
end asm ------------------------------------------------------------------------

ulong mod<ulong>(ulong lhs, ulong rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8,rdx
  0008h  mov rax,rcx
  000bh  xor edx,edx
  000dh  div r8
  0010h  mov rax,rdx
  0013h  ret
end asm ------------------------------------------------------------------------

sbyte mod<sbyte>(sbyte lhs, sbyte rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rcx,dl
  000dh  cdq
  000eh  idiv ecx
  0010h  movsx rax,dl
  0014h  ret
end asm ------------------------------------------------------------------------

short mod<short>(short lhs, short rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cx
  0009h  movsx rcx,dx
  000dh  cdq
  000eh  idiv ecx
  0010h  movsx rax,dx
  0014h  ret
end asm ------------------------------------------------------------------------

int mod<int>(int lhs, int rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8d,edx
  0008h  mov eax,ecx
  000ah  cdq
  000bh  idiv r8d
  000eh  mov eax,edx
  0010h  ret
end asm ------------------------------------------------------------------------

long mod<long>(long lhs, long rhs)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov r8,rdx
  0008h  mov rax,rcx
  000bh  cqo
  000dh  idiv r8
  0010h  mov rax,rdx
  0013h  ret
end asm ------------------------------------------------------------------------

float mod<float>(float lhs, float rhs)
asm ----------------------------------------------------------------------------
  0000h  sub rsp,28h
  0004h  vzeroupper
  0007h  call 7FFECBBC0D90h
  000ch  nop
  000dh  add rsp,28h
  0011h  ret
end asm ------------------------------------------------------------------------

double mod<double>(double lhs, double rhs)
asm ----------------------------------------------------------------------------
  0000h  sub rsp,28h
  0004h  vzeroupper
  0007h  call 7FFECBBC0D00h
  000ch  nop
  000dh  add rsp,28h
  0011h  ret
end asm ------------------------------------------------------------------------

