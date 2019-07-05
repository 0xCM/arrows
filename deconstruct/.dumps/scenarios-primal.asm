# 2019-07-01 01:15:28:488
sbyte addI8(sbyte x, sbyte y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rdx,dl
  000dh  add eax,edx
  000fh  movsx rax,al
  0013h  ret
end asm ------------------------------------------------------------------------

int addI32(int x, int y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea eax,[rcx+rdx]
  0008h  ret
end asm ------------------------------------------------------------------------

ulong addU64(ulong x, ulong y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea rax,[rcx+rdx]
  0009h  ret
end asm ------------------------------------------------------------------------

int subI32(int x, int y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  sub eax,edx
  0009h  ret
end asm ------------------------------------------------------------------------

int mulI32(int x, int y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  imul eax,edx
  000ah  ret
end asm ------------------------------------------------------------------------

byte andU8(byte x, byte y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx edx,dl
  000bh  and eax,edx
  000dh  movzx eax,al
  0010h  ret
end asm ------------------------------------------------------------------------

ushort andU16(ushort x, ushort y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx edx,dx
  000bh  and eax,edx
  000dh  movzx eax,ax
  0010h  ret
end asm ------------------------------------------------------------------------

ulong andU64(ulong x, ulong y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  and rax,rdx
  000bh  ret
end asm ------------------------------------------------------------------------

int addI32Loop()
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  xor eax,eax
  0007h  xor edx,edx
  0009h  add eax,edx
  000bh  inc edx
  000dh  cmp edx,64h
  0010h  jl short 0009h
  0012h  ret
end asm ------------------------------------------------------------------------

int addI32LoopOptimize()
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  xor eax,eax
  0007h  xor edx,edx
  0009h  add eax,edx
  000bh  inc edx
  000dh  cmp edx,64h
  0010h  jl short 0009h
  0012h  ret
end asm ------------------------------------------------------------------------

int AddI32LoopCall()
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  xor eax,eax
  0007h  xor edx,edx
  0009h  add eax,edx
  000bh  inc edx
  000dh  cmp edx,64h
  0010h  jl short 0009h
  0012h  ret
end asm ------------------------------------------------------------------------

