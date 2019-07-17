# 2019-07-14 13:27:24:672
7FF969083F60h: Vec128<byte> xor<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
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

7FF969083F90h: Vec128<ushort> xor<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
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

7FF9690843D0h: Vec128<uint> xor<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
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

7FF969084810h: Vec128<ulong> xor<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
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

7FF969084840h: Vec128<sbyte> xor<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
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

7FF969084C80h: Vec128<short> xor<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
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

7FF9690850C0h: Vec128<int> xor<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
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

7FF9690850F0h: Vec128<long> xor<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
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

7FF969085530h: Vec128<float> xor<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
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

7FF969085970h: Vec128<double> xor<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
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

7FF9690861B0h: Vec256<byte> xor<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
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

7FF9690865F0h: Vec256<ushort> xor<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
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

7FF969086620h: Vec256<uint> xor<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
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

7FF969086A60h: Vec256<ulong> xor<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
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

7FF969086EA0h: Vec256<sbyte> xor<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
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

7FF969086ED0h: Vec256<short> xor<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
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

7FF969087310h: Vec256<int> xor<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
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

7FF969087750h: Vec256<long> xor<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
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

7FF969087780h: Vec256<float> xor<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
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

7FF969087BC0h: Vec256<double> xor<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
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

7FF969087BF0h: void xor<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF969087C20h: void xor<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF969087C50h: void xor<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF969087C80h: void xor<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF969087CB0h: void xor<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9690880F0h: void xor<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF969088120h: void xor<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF969088150h: void xor<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF969088180h: void xor<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vxorps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9690881B0h: void xor<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vxorpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9690881E0h: void xor<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
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

7FF969088210h: void xor<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
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

7FF969088240h: void xor<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
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

7FF969088270h: void xor<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
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

7FF9690882A0h: void xor<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
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

7FF9690882D0h: void xor<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
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

7FF969088300h: void xor<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
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

7FF969088330h: void xor<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
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

7FF969088360h: void xor<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
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

7FF969088390h: void xor<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
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

7FF9690883C0h: Vec128<byte> add<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
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

7FF9690883F0h: Vec128<ushort> add<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
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

7FF969088420h: Vec128<uint> add<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
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

7FF969088450h: Vec128<ulong> add<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
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

7FF969088480h: Vec128<sbyte> add<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
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

7FF9690884B0h: Vec128<short> add<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
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

7FF9690884E0h: Vec128<int> add<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
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

7FF969088920h: Vec128<long> add<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
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

7FF969088950h: Vec128<float> add<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
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

7FF969088980h: Vec128<double> add<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
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

7FF9690889B0h: Vec256<byte> add<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
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

7FF9690889E0h: Vec256<ushort> add<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
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

7FF969088A10h: Vec256<uint> add<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
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

7FF969088A40h: Vec256<ulong> add<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
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

7FF969088A70h: Vec256<sbyte> add<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
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

7FF969088AA0h: Vec256<short> add<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
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

7FF969088AD0h: Vec256<int> add<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
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

7FF969088B00h: Vec256<long> add<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
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

7FF969088B30h: Vec256<float> add<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
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

7FF969088B60h: Vec256<double> add<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
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

7FF969088B90h: void add<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddb xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF969088BC0h: void add<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddw xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF969088BF0h: void add<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddd xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF969088C20h: void add<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddq xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF969088C50h: void add<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddb xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF969088C80h: void add<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddw xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF969088CB0h: void add<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddd xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF969088CE0h: void add<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddq xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF969088D10h: void add<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vaddps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF969088D40h: void add<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vaddpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF969088D70h: byref Byte add<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
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

7FF969088DB0h: byref UInt16 add<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
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

7FF969088DF0h: byref UInt32 add<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
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

7FF969088E30h: byref UInt64 add<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
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

7FF969088E70h: byref SByte add<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
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

7FF969088EB0h: byref Int16 add<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
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

7FF969088EF0h: byref Int32 add<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
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

7FF969088F30h: byref Int64 add<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
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

7FF969088F70h: byref Single add<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
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

7FF9690893B0h: byref Double add<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
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

7FF9690893F0h: Num128<byte> add<byte>(byref Num128<byte> lhs, byref Num128<byte> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Fh
  000ch  mov edi,1
  0011h  mov ecx,247Bh
  0016h  mov rdx,7FF968C21060h
  0020h  call 7FF9C873FCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,247Bh
  002dh  mov rdx,7FF968C21060h
  0037h  call 7FF9C873FCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9690891D0h
  0057h  mov rcx,rax
  005ah  call 7FF9C860B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF969089470h: Num128<ushort> add<ushort>(byref Num128<ushort> lhs, byref Num128<ushort> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Fh
  000ch  mov edi,1
  0011h  mov ecx,247Bh
  0016h  mov rdx,7FF968C21060h
  0020h  call 7FF9C873FCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,247Bh
  002dh  mov rdx,7FF968C21060h
  0037h  call 7FF9C873FCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF969089250h
  0057h  mov rcx,rax
  005ah  call 7FF9C860B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9690894F0h: Num128<uint> add<uint>(byref Num128<uint> lhs, byref Num128<uint> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Fh
  000ch  mov edi,1
  0011h  mov ecx,247Bh
  0016h  mov rdx,7FF968C21060h
  0020h  call 7FF9C873FCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,247Bh
  002dh  mov rdx,7FF968C21060h
  0037h  call 7FF9C873FCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9690892C0h
  0057h  mov rcx,rax
  005ah  call 7FF9C860B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF969089570h: Num128<ulong> add<ulong>(byref Num128<ulong> lhs, byref Num128<ulong> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Fh
  000ch  mov edi,1
  0011h  mov ecx,247Bh
  0016h  mov rdx,7FF968C21060h
  0020h  call 7FF9C873FCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,247Bh
  002dh  mov rdx,7FF968C21060h
  0037h  call 7FF9C873FCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF969089330h
  0057h  mov rcx,rax
  005ah  call 7FF9C860B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9690899F0h: Num128<sbyte> add<sbyte>(byref Num128<sbyte> lhs, byref Num128<sbyte> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Fh
  000ch  mov edi,1
  0011h  mov ecx,247Bh
  0016h  mov rdx,7FF968C21060h
  0020h  call 7FF9C873FCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,247Bh
  002dh  mov rdx,7FF968C21060h
  0037h  call 7FF9C873FCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9690895E8h
  0057h  mov rcx,rax
  005ah  call 7FF9C860B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF969089A70h: Num128<short> add<short>(byref Num128<short> lhs, byref Num128<short> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Fh
  000ch  mov edi,1
  0011h  mov ecx,247Bh
  0016h  mov rdx,7FF968C21060h
  0020h  call 7FF9C873FCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,247Bh
  002dh  mov rdx,7FF968C21060h
  0037h  call 7FF9C873FCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF969089658h
  0057h  mov rcx,rax
  005ah  call 7FF9C860B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF969089AF0h: Num128<int> add<int>(byref Num128<int> lhs, byref Num128<int> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Fh
  000ch  mov edi,1
  0011h  mov ecx,247Bh
  0016h  mov rdx,7FF968C21060h
  0020h  call 7FF9C873FCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,247Bh
  002dh  mov rdx,7FF968C21060h
  0037h  call 7FF9C873FCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9690896C8h
  0057h  mov rcx,rax
  005ah  call 7FF9C860B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF969089B70h: Num128<long> add<long>(byref Num128<long> lhs, byref Num128<long> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Fh
  000ch  mov edi,1
  0011h  mov ecx,247Bh
  0016h  mov rdx,7FF968C21060h
  0020h  call 7FF9C873FCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,247Bh
  002dh  mov rdx,7FF968C21060h
  0037h  call 7FF9C873FCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF969089738h
  0057h  mov rcx,rax
  005ah  call 7FF9C860B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF969089FF0h: Num128<float> add<float>(byref Num128<float> lhs, byref Num128<float> rhs)
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

7FF96908A020h: Num128<double> add<double>(byref Num128<double> lhs, byref Num128<double> rhs)
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

7FF96908A050h: Vec128<byte> sub<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
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

7FF96908A080h: Vec128<ushort> sub<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
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

7FF96908A0B0h: Vec128<uint> sub<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
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

7FF96908A0E0h: Vec128<ulong> sub<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
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

7FF96908A110h: Vec128<sbyte> sub<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
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

7FF96908A140h: Vec128<short> sub<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
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

7FF96908A170h: Vec128<int> sub<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
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

7FF96908A1A0h: Vec128<long> sub<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
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

7FF96908A1D0h: Vec128<float> sub<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
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

7FF96908A200h: Vec128<double> sub<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
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

7FF96908A230h: Vec256<byte> sub<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
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

7FF96908A260h: Vec256<ushort> sub<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
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

7FF96908A6A0h: Vec256<uint> sub<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
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

7FF96908A6D0h: Vec256<ulong> sub<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
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

7FF96908A700h: Vec256<sbyte> sub<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
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

7FF96908A730h: Vec256<short> sub<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
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

7FF96908A760h: Vec256<int> sub<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
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

7FF96908A790h: Vec256<long> sub<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
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

7FF96908A7C0h: Vec256<float> sub<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
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

7FF96908A7F0h: Vec256<double> sub<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
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

7FF96908A820h: void sub<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubb xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908A850h: void sub<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubw xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908A880h: void sub<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubd xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908A8B0h: void sub<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubq xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908A8E0h: void sub<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubb xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908A910h: void sub<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubw xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908A940h: void sub<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubd xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908A970h: void sub<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubq xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908A9A0h: void sub<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vsubps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908A9D0h: void sub<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vsubpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908AA00h: void sub<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
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

7FF96908AA30h: void sub<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
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

7FF96908AA60h: void sub<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
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

7FF96908AA90h: void sub<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
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

7FF96908AAC0h: void sub<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
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

7FF96908AAF0h: void sub<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
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

7FF96908AB20h: void sub<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
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

7FF96908AB50h: void sub<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
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

7FF96908AB80h: void sub<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
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

7FF96908ABB0h: void sub<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
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

7FF96908ABE0h: Num128<byte> sub<byte>(byref Num128<byte> lhs, byref Num128<byte> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Bh
  000ch  mov edi,1
  0011h  mov ecx,2605h
  0016h  mov rdx,7FF968C21060h
  0020h  call 7FF9C873FCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2605h
  002dh  mov rdx,7FF968C21060h
  0037h  call 7FF9C873FCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9690891D0h
  0057h  mov rcx,rax
  005ah  call 7FF9C860B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF96908AC60h: Num128<ushort> sub<ushort>(byref Num128<ushort> lhs, byref Num128<ushort> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Bh
  000ch  mov edi,1
  0011h  mov ecx,2605h
  0016h  mov rdx,7FF968C21060h
  0020h  call 7FF9C873FCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2605h
  002dh  mov rdx,7FF968C21060h
  0037h  call 7FF9C873FCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF969089250h
  0057h  mov rcx,rax
  005ah  call 7FF9C860B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF96908ACE0h: Num128<uint> sub<uint>(byref Num128<uint> lhs, byref Num128<uint> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Bh
  000ch  mov edi,1
  0011h  mov ecx,2605h
  0016h  mov rdx,7FF968C21060h
  0020h  call 7FF9C873FCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2605h
  002dh  mov rdx,7FF968C21060h
  0037h  call 7FF9C873FCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9690892C0h
  0057h  mov rcx,rax
  005ah  call 7FF9C860B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF96908AD60h: Num128<ulong> sub<ulong>(byref Num128<ulong> lhs, byref Num128<ulong> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Bh
  000ch  mov edi,1
  0011h  mov ecx,2605h
  0016h  mov rdx,7FF968C21060h
  0020h  call 7FF9C873FCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2605h
  002dh  mov rdx,7FF968C21060h
  0037h  call 7FF9C873FCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF969089330h
  0057h  mov rcx,rax
  005ah  call 7FF9C860B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF96908ADE0h: Num128<sbyte> sub<sbyte>(byref Num128<sbyte> lhs, byref Num128<sbyte> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Bh
  000ch  mov edi,1
  0011h  mov ecx,2605h
  0016h  mov rdx,7FF968C21060h
  0020h  call 7FF9C873FCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2605h
  002dh  mov rdx,7FF968C21060h
  0037h  call 7FF9C873FCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9690895E8h
  0057h  mov rcx,rax
  005ah  call 7FF9C860B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF96908AE60h: Num128<short> sub<short>(byref Num128<short> lhs, byref Num128<short> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Bh
  000ch  mov edi,1
  0011h  mov ecx,2605h
  0016h  mov rdx,7FF968C21060h
  0020h  call 7FF9C873FCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2605h
  002dh  mov rdx,7FF968C21060h
  0037h  call 7FF9C873FCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF969089658h
  0057h  mov rcx,rax
  005ah  call 7FF9C860B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF96908AEE0h: Num128<int> sub<int>(byref Num128<int> lhs, byref Num128<int> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Bh
  000ch  mov edi,1
  0011h  mov ecx,2605h
  0016h  mov rdx,7FF968C21060h
  0020h  call 7FF9C873FCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2605h
  002dh  mov rdx,7FF968C21060h
  0037h  call 7FF9C873FCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9690896C8h
  0057h  mov rcx,rax
  005ah  call 7FF9C860B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF96908AF60h: Num128<long> sub<long>(byref Num128<long> lhs, byref Num128<long> rhs)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Bh
  000ch  mov edi,1
  0011h  mov ecx,2605h
  0016h  mov rdx,7FF968C21060h
  0020h  call 7FF9C873FCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2605h
  002dh  mov rdx,7FF968C21060h
  0037h  call 7FF9C873FCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF969089738h
  0057h  mov rcx,rax
  005ah  call 7FF9C860B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF96908B3E0h: Num128<float> sub<float>(byref Num128<float> lhs, byref Num128<float> rhs)
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

7FF96908B410h: Num128<double> sub<double>(byref Num128<double> lhs, byref Num128<double> rhs)
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

7FF96908B440h: Vec128<byte> and<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
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

7FF96908B470h: Vec128<ushort> and<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
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

7FF96908B4A0h: Vec128<uint> and<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
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

7FF96908B4D0h: Vec128<ulong> and<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
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

7FF96908B500h: Vec128<sbyte> and<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
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

7FF96908B530h: Vec128<short> and<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
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

7FF96908B560h: Vec128<int> and<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
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

7FF96908B590h: Vec128<long> and<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
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

7FF96908B5C0h: Vec128<float> and<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
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

7FF96908B5F0h: Vec128<double> and<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
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

7FF96908B620h: Vec256<byte> and<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
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

7FF96908B650h: Vec256<ushort> and<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
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

7FF96908B680h: Vec256<uint> and<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
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

7FF96908B6B0h: Vec256<ulong> and<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
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

7FF96908B6E0h: Vec256<sbyte> and<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
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

7FF96908B710h: Vec256<short> and<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
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

7FF96908B740h: Vec256<int> and<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
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

7FF96908B770h: Vec256<long> and<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
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

7FF96908B7A0h: Vec256<float> and<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
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

7FF96908B7D0h: Vec256<double> and<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
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

7FF96908B800h: void and<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908B830h: void and<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908B860h: void and<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908B890h: void and<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908B8C0h: void and<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908B8F0h: void and<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908BD30h: void and<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908BD60h: void and<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908BD90h: void and<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vandps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908BDC0h: void and<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vandpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF96908BDF0h: void and<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
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

7FF96908BE20h: void and<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
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

7FF96908BE50h: void and<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
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

7FF96908BE80h: void and<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
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

7FF96908BEB0h: void and<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
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

7FF96908BEE0h: void and<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
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

7FF96908BF10h: void and<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
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

7FF96908BF40h: void and<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
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

7FF96908BF70h: void and<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
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

7FF96908BFA0h: void and<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
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

7FF96908BFD0h: Vec128<byte> or<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
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

7FF96908C000h: Vec128<ushort> or<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
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

7FF96908C030h: Vec128<uint> or<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
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

7FF96908C060h: Vec128<ulong> or<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
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

7FF96908C090h: Vec128<sbyte> or<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
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

7FF96908C0C0h: Vec128<short> or<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
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

7FF96908C0F0h: Vec128<int> or<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
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

7FF96908C120h: Vec128<long> or<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
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

7FF96908C150h: Vec128<float> or<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
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

7FF96908C180h: Vec128<double> or<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
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

7FF96908C1B0h: Vec256<byte> or<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
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

7FF96908C1E0h: Vec256<ushort> or<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
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

7FF96908C210h: Vec256<uint> or<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
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

7FF96908C240h: Vec256<ulong> or<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
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

7FF96908C270h: Vec256<sbyte> or<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
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

7FF96908C2A0h: Vec256<short> or<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
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

7FF96908C2D0h: Vec256<int> or<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
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

7FF96908C300h: Vec256<long> or<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
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

7FF968F9BBC0h: Vec256<float> or<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
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

7FF968F9BBF0h: Vec256<double> or<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
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

7FF968F9BC20h: void or<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF968F9BC50h: void or<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF968F9BC80h: void or<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF968F9BCB0h: void or<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF968F9BCE0h: void or<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF968F9BD10h: void or<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF968F9BD40h: void or<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF968F9BD70h: void or<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF968F9BDA0h: void or<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vorps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF968F9BDD0h: void or<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vorpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF968F9BE00h: void or<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
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

7FF968F9BE30h: void or<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
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

7FF968F9BE60h: void or<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
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

7FF968F9BE90h: void or<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
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

7FF968F9BEC0h: void or<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
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

7FF968F9BEF0h: void or<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
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

7FF968F9BF20h: void or<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
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

7FF968F9BF50h: void or<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
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

7FF968F9BF80h: void or<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
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

7FF968F9BFB0h: void or<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
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

