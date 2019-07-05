# 2019-07-01 01:15:29:384
Vec128<byte> xor<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpxor xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<ushort> xor<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpxor xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<uint> xor<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpxor xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<ulong> xor<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpxor xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<sbyte> xor<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpxor xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<short> xor<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpxor xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<int> xor<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpxor xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<long> xor<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpxor xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<float> xor<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vxorps xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<double> xor<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vxorpd xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec256<byte> xor<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpxor ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<ushort> xor<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpxor ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<uint> xor<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpxor ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<ulong> xor<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpxor ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<sbyte> xor<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpxor ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<short> xor<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpxor ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<int> xor<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpxor ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<long> xor<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpxor ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<float> xor<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vxorps ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<double> xor<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vxorpd ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

void xor<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void xor<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void xor<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void xor<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void xor<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void xor<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void xor<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void xor<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void xor<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vxorps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void xor<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vxorpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void xor<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpxor ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void xor<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpxor ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void xor<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpxor ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void xor<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpxor ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void xor<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpxor ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void xor<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpxor ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void xor<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpxor ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void xor<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpxor ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void xor<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vxorps ymm0,ymm0,ymm1
  0011h  vmovups [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void xor<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vxorpd ymm0,ymm0,ymm1
  0011h  vmovupd [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<byte> add<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpaddb xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<ushort> add<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpaddw xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<uint> add<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpaddd xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<ulong> add<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpaddq xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<sbyte> add<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpaddb xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<short> add<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpaddw xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<int> add<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpaddd xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<long> add<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpaddq xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<float> add<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vaddps xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<double> add<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vaddpd xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec256<byte> add<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpaddb ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<ushort> add<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpaddw ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<uint> add<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpaddd ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<ulong> add<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpaddq ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<sbyte> add<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpaddb ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<short> add<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpaddw ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<int> add<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpaddd ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<long> add<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpaddq ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<float> add<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vaddps ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<double> add<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vaddpd ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

void add<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddb xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void add<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddw xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void add<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddd xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void add<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddq xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void add<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddb xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void add<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddw xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void add<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddd xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void add<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddq xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void add<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vaddps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void add<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vaddpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

byref Byte add<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpaddb ymm0,ymm0,ymm1
  0011h  mov rax,r8
  0014h  vmovdqu ymmword ptr [rax],ymm0
  0018h  mov rax,r8
  001bh  vzeroupper
  001eh  ret
end asm ------------------------------------------------------------------------

byref UInt16 add<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpaddw ymm0,ymm0,ymm1
  0011h  mov rax,r8
  0014h  vmovdqu ymmword ptr [rax],ymm0
  0018h  mov rax,r8
  001bh  vzeroupper
  001eh  ret
end asm ------------------------------------------------------------------------

byref UInt32 add<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpaddd ymm0,ymm0,ymm1
  0011h  mov rax,r8
  0014h  vmovdqu ymmword ptr [rax],ymm0
  0018h  mov rax,r8
  001bh  vzeroupper
  001eh  ret
end asm ------------------------------------------------------------------------

byref UInt64 add<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpaddq ymm0,ymm0,ymm1
  0011h  mov rax,r8
  0014h  vmovdqu ymmword ptr [rax],ymm0
  0018h  mov rax,r8
  001bh  vzeroupper
  001eh  ret
end asm ------------------------------------------------------------------------

byref SByte add<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpaddb ymm0,ymm0,ymm1
  0011h  mov rax,r8
  0014h  vmovdqu ymmword ptr [rax],ymm0
  0018h  mov rax,r8
  001bh  vzeroupper
  001eh  ret
end asm ------------------------------------------------------------------------

byref Int16 add<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpaddw ymm0,ymm0,ymm1
  0011h  mov rax,r8
  0014h  vmovdqu ymmword ptr [rax],ymm0
  0018h  mov rax,r8
  001bh  vzeroupper
  001eh  ret
end asm ------------------------------------------------------------------------

byref Int32 add<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpaddd ymm0,ymm0,ymm1
  0011h  mov rax,r8
  0014h  vmovdqu ymmword ptr [rax],ymm0
  0018h  mov rax,r8
  001bh  vzeroupper
  001eh  ret
end asm ------------------------------------------------------------------------

byref Int64 add<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpaddq ymm0,ymm0,ymm1
  0011h  mov rax,r8
  0014h  vmovdqu ymmword ptr [rax],ymm0
  0018h  mov rax,r8
  001bh  vzeroupper
  001eh  ret
end asm ------------------------------------------------------------------------

byref Single add<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vaddps ymm0,ymm0,ymm1
  0011h  mov rax,r8
  0014h  vmovups [rax],ymm0
  0018h  mov rax,r8
  001bh  vzeroupper
  001eh  ret
end asm ------------------------------------------------------------------------

byref Double add<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vaddpd ymm0,ymm0,ymm1
  0011h  mov rax,r8
  0014h  vmovupd [rax],ymm0
  0018h  mov rax,r8
  001bh  vzeroupper
  001eh  ret
end asm ------------------------------------------------------------------------

Num128<byte> add<byte>(byref Num128<byte> lhs, byref Num128<byte> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Fh
  000ch  mov edi,1
  0011h  mov ecx,3B1h
  0016h  mov rdx,7FFE6C0A0B88h
  0020h  call 7FFECBBBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,3B1h
  002dh  mov rdx,7FFE6C0A0B88h
  0037h  call 7FFECBBBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FFE6C4F7900h
  0057h  mov rcx,rax
  005ah  call 7FFECBA8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

Num128<ushort> add<ushort>(byref Num128<ushort> lhs, byref Num128<ushort> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Fh
  000ch  mov edi,1
  0011h  mov ecx,3B1h
  0016h  mov rdx,7FFE6C0A0B88h
  0020h  call 7FFECBBBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,3B1h
  002dh  mov rdx,7FFE6C0A0B88h
  0037h  call 7FFECBBBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FFE6C4F7980h
  0057h  mov rcx,rax
  005ah  call 7FFECBA8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

Num128<uint> add<uint>(byref Num128<uint> lhs, byref Num128<uint> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Fh
  000ch  mov edi,1
  0011h  mov ecx,3B1h
  0016h  mov rdx,7FFE6C0A0B88h
  0020h  call 7FFECBBBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,3B1h
  002dh  mov rdx,7FFE6C0A0B88h
  0037h  call 7FFECBBBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FFE6C4F79F0h
  0057h  mov rcx,rax
  005ah  call 7FFECBA8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

Num128<ulong> add<ulong>(byref Num128<ulong> lhs, byref Num128<ulong> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Fh
  000ch  mov edi,1
  0011h  mov ecx,3B1h
  0016h  mov rdx,7FFE6C0A0B88h
  0020h  call 7FFECBBBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,3B1h
  002dh  mov rdx,7FFE6C0A0B88h
  0037h  call 7FFECBBBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FFE6C4F7A60h
  0057h  mov rcx,rax
  005ah  call 7FFECBA8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

Num128<sbyte> add<sbyte>(byref Num128<sbyte> lhs, byref Num128<sbyte> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Fh
  000ch  mov edi,1
  0011h  mov ecx,3B1h
  0016h  mov rdx,7FFE6C0A0B88h
  0020h  call 7FFECBBBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,3B1h
  002dh  mov rdx,7FFE6C0A0B88h
  0037h  call 7FFECBBBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FFE6C4F7A70h
  0057h  mov rcx,rax
  005ah  call 7FFECBA8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

Num128<short> add<short>(byref Num128<short> lhs, byref Num128<short> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Fh
  000ch  mov edi,1
  0011h  mov ecx,3B1h
  0016h  mov rdx,7FFE6C0A0B88h
  0020h  call 7FFECBBBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,3B1h
  002dh  mov rdx,7FFE6C0A0B88h
  0037h  call 7FFECBBBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FFE6C4F7A80h
  0057h  mov rcx,rax
  005ah  call 7FFECBA8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

Num128<int> add<int>(byref Num128<int> lhs, byref Num128<int> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Fh
  000ch  mov edi,1
  0011h  mov ecx,3B1h
  0016h  mov rdx,7FFE6C0A0B88h
  0020h  call 7FFECBBBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,3B1h
  002dh  mov rdx,7FFE6C0A0B88h
  0037h  call 7FFECBBBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FFE6C4F7A90h
  0057h  mov rcx,rax
  005ah  call 7FFECBA8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

Num128<long> add<long>(byref Num128<long> lhs, byref Num128<long> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Fh
  000ch  mov edi,1
  0011h  mov ecx,3B1h
  0016h  mov rdx,7FFE6C0A0B88h
  0020h  call 7FFECBBBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,3B1h
  002dh  mov rdx,7FFE6C0A0B88h
  0037h  call 7FFECBBBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FFE6C4F7AA0h
  0057h  mov rcx,rax
  005ah  call 7FFECBA8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

Num128<float> add<float>(byref Num128<float> lhs, byref Num128<float> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vaddss xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Num128<double> add<double>(byref Num128<double> lhs, byref Num128<double> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vaddsd xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<byte> sub<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpsubb xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<ushort> sub<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpsubw xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<uint> sub<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpsubd xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<ulong> sub<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpsubq xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<sbyte> sub<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpsubb xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<short> sub<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpsubw xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<int> sub<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpsubd xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<long> sub<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpsubq xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<float> sub<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vsubps xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<double> sub<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vsubpd xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec256<byte> sub<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpsubb ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<ushort> sub<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpsubw ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<uint> sub<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpsubd ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<ulong> sub<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpsubq ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<sbyte> sub<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpsubb ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<short> sub<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpsubw ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<int> sub<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpsubd ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<long> sub<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpsubq ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<float> sub<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vsubps ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<double> sub<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vsubpd ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

void sub<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubb xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void sub<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubw xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void sub<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubd xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void sub<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubq xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void sub<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubb xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void sub<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubw xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void sub<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubd xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void sub<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubq xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void sub<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vsubps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void sub<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vsubpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void sub<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpsubb ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void sub<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpsubw ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void sub<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpsubd ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void sub<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpsubq ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void sub<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpsubb ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void sub<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpsubw ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void sub<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpsubd ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void sub<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpsubq ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void sub<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vsubps ymm0,ymm0,ymm1
  0011h  vmovups [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void sub<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vsubpd ymm0,ymm0,ymm1
  0011h  vmovupd [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

Num128<byte> sub<byte>(byref Num128<byte> lhs, byref Num128<byte> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Bh
  000ch  mov edi,1
  0011h  mov ecx,53Bh
  0016h  mov rdx,7FFE6C0A0B88h
  0020h  call 7FFECBBBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,53Bh
  002dh  mov rdx,7FFE6C0A0B88h
  0037h  call 7FFECBBBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FFE6C4F7900h
  0057h  mov rcx,rax
  005ah  call 7FFECBA8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

Num128<ushort> sub<ushort>(byref Num128<ushort> lhs, byref Num128<ushort> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Bh
  000ch  mov edi,1
  0011h  mov ecx,53Bh
  0016h  mov rdx,7FFE6C0A0B88h
  0020h  call 7FFECBBBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,53Bh
  002dh  mov rdx,7FFE6C0A0B88h
  0037h  call 7FFECBBBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FFE6C4F7980h
  0057h  mov rcx,rax
  005ah  call 7FFECBA8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

Num128<uint> sub<uint>(byref Num128<uint> lhs, byref Num128<uint> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Bh
  000ch  mov edi,1
  0011h  mov ecx,53Bh
  0016h  mov rdx,7FFE6C0A0B88h
  0020h  call 7FFECBBBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,53Bh
  002dh  mov rdx,7FFE6C0A0B88h
  0037h  call 7FFECBBBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FFE6C4F79F0h
  0057h  mov rcx,rax
  005ah  call 7FFECBA8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

Num128<ulong> sub<ulong>(byref Num128<ulong> lhs, byref Num128<ulong> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Bh
  000ch  mov edi,1
  0011h  mov ecx,53Bh
  0016h  mov rdx,7FFE6C0A0B88h
  0020h  call 7FFECBBBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,53Bh
  002dh  mov rdx,7FFE6C0A0B88h
  0037h  call 7FFECBBBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FFE6C4F7A60h
  0057h  mov rcx,rax
  005ah  call 7FFECBA8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

Num128<sbyte> sub<sbyte>(byref Num128<sbyte> lhs, byref Num128<sbyte> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Bh
  000ch  mov edi,1
  0011h  mov ecx,53Bh
  0016h  mov rdx,7FFE6C0A0B88h
  0020h  call 7FFECBBBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,53Bh
  002dh  mov rdx,7FFE6C0A0B88h
  0037h  call 7FFECBBBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FFE6C4F7A70h
  0057h  mov rcx,rax
  005ah  call 7FFECBA8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

Num128<short> sub<short>(byref Num128<short> lhs, byref Num128<short> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Bh
  000ch  mov edi,1
  0011h  mov ecx,53Bh
  0016h  mov rdx,7FFE6C0A0B88h
  0020h  call 7FFECBBBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,53Bh
  002dh  mov rdx,7FFE6C0A0B88h
  0037h  call 7FFECBBBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FFE6C4F7A80h
  0057h  mov rcx,rax
  005ah  call 7FFECBA8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

Num128<int> sub<int>(byref Num128<int> lhs, byref Num128<int> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Bh
  000ch  mov edi,1
  0011h  mov ecx,53Bh
  0016h  mov rdx,7FFE6C0A0B88h
  0020h  call 7FFECBBBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,53Bh
  002dh  mov rdx,7FFE6C0A0B88h
  0037h  call 7FFECBBBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FFE6C4F7A90h
  0057h  mov rcx,rax
  005ah  call 7FFECBA8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

Num128<long> sub<long>(byref Num128<long> lhs, byref Num128<long> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Bh
  000ch  mov edi,1
  0011h  mov ecx,53Bh
  0016h  mov rdx,7FFE6C0A0B88h
  0020h  call 7FFECBBBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,53Bh
  002dh  mov rdx,7FFE6C0A0B88h
  0037h  call 7FFECBBBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FFE6C4F7AA0h
  0057h  mov rcx,rax
  005ah  call 7FFECBA8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

Num128<float> sub<float>(byref Num128<float> lhs, byref Num128<float> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vsubss xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Num128<double> sub<double>(byref Num128<double> lhs, byref Num128<double> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vsubsd xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<byte> and<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpand xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<ushort> and<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpand xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<uint> and<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpand xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<ulong> and<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpand xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<sbyte> and<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpand xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<short> and<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpand xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<int> and<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpand xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<long> and<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpand xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<float> and<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vandps xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<double> and<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vandpd xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec256<byte> and<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpand ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<ushort> and<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpand ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<uint> and<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpand ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<ulong> and<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpand ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<sbyte> and<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpand ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<short> and<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpand ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<int> and<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpand ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<long> and<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpand ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<float> and<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vandps ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<double> and<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vandpd ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

void and<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void and<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void and<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void and<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void and<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void and<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void and<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void and<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void and<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vandps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void and<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vandpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void and<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpand ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void and<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpand ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void and<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpand ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void and<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpand ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void and<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpand ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void and<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpand ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void and<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpand ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void and<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpand ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void and<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vandps ymm0,ymm0,ymm1
  0011h  vmovups [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void and<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vandpd ymm0,ymm0,ymm1
  0011h  vmovupd [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<byte> or<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpor xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<ushort> or<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpor xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<uint> or<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpor xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<ulong> or<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpor xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<sbyte> or<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpor xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<short> or<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpor xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<int> or<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpor xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<long> or<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vpor xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<float> or<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vorps xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec128<double> or<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vmovupd xmm1,[r8]
  000eh  vorpd xmm0,xmm0,xmm1
  0012h  vmovupd [rcx],xmm0
  0016h  mov rax,rcx
  0019h  ret
end asm ------------------------------------------------------------------------

Vec256<byte> or<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpor ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<ushort> or<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpor ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<uint> or<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpor ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<ulong> or<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpor ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<sbyte> or<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpor ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<short> or<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpor ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<int> or<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpor ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<long> or<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vpor ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<float> or<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vorps ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

Vec256<double> or<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vmovupd ymm1,[r8]
  000eh  vorpd ymm0,ymm0,ymm1
  0012h  vmovupd [rcx],ymm0
  0016h  mov rax,rcx
  0019h  vzeroupper
  001ch  ret
end asm ------------------------------------------------------------------------

void or<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void or<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void or<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void or<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void or<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void or<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void or<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void or<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void or<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vorps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void or<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vorpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

void or<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpor ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void or<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpor ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void or<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpor ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void or<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpor ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void or<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpor ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void or<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpor ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void or<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpor ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void or<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vpor ymm0,ymm0,ymm1
  0011h  vmovdqu ymmword ptr [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void or<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vorps ymm0,ymm0,ymm1
  0011h  vmovups [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

void or<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rcx]
  0009h  vmovupd ymm1,[rdx]
  000dh  vorpd ymm0,ymm0,ymm1
  0011h  vmovupd [r8],ymm0
  0016h  vzeroupper
  0019h  ret
end asm ------------------------------------------------------------------------

