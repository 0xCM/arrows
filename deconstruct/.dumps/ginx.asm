# 2019-07-20 02:42:58:622
7FF9673E46E0h: Vec128<byte> xor<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 ef c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E4B20h: Vec128<ushort> xor<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 ef c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E4F60h: Vec128<uint> xor<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 ef c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E4F90h: Vec128<ulong> xor<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 ef c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E53D0h: Vec128<sbyte> xor<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 ef c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E5810h: Vec128<short> xor<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 ef c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E5840h: Vec128<int> xor<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 ef c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E5C80h: Vec128<long> xor<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 ef c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E60C0h: Vec128<float> xor<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f8 57 c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E60F0h: Vec128<double> xor<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 57 c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E6930h: Vec256<byte> xor<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd ef c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E6D70h: Vec256<ushort> xor<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd ef c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E71B0h: Vec256<uint> xor<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd ef c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E71E0h: Vec256<ulong> xor<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd ef c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E7620h: Vec256<sbyte> xor<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd ef c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E7A60h: Vec256<short> xor<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd ef c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E7A90h: Vec256<int> xor<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd ef c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E7ED0h: Vec256<long> xor<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd ef c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E7F00h: Vec256<float> xor<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fc 57 c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E8340h: Vec256<double> xor<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd 57 c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E8370h: void xor<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 ef c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E83A0h: void xor<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 ef c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E83D0h: void xor<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 ef c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E8400h: void xor<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 ef c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E8840h: void xor<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 ef c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E8870h: void xor<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 ef c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E88A0h: void xor<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 ef c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E88D0h: void xor<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 ef c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E8900h: void xor<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f8 57 c1 c4 c1 78 11 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vxorps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E8930h: void xor<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 57 c1 c4 c1 79 11 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vxorpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E8960h: void xor<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd ef c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9673E8990h: void xor<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd ef c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9673E89C0h: void xor<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd ef c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9673E89F0h: void xor<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd ef c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9673E8A20h: void xor<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd ef c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9673E8A50h: void xor<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd ef c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9673E8A80h: void xor<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd ef c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9673E8AB0h: void xor<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd ef c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9673E8AE0h: void xor<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fc 57 c1 c4 c1 7c 11 00 c5 f8 77 c3 
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

7FF9673E8B10h: void xor<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd 57 c1 c4 c1 7d 11 00 c5 f8 77 c3 
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

7FF9673E8B40h: Vec128<byte> add<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 fc c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E8F80h: Vec128<ushort> add<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 fd c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E8FB0h: Vec128<uint> add<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 fe c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E8FE0h: Vec128<ulong> add<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 d4 c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E9010h: Vec128<sbyte> add<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 fc c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E9040h: Vec128<short> add<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 fd c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E9070h: Vec128<int> add<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 fe c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E90A0h: Vec128<long> add<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 d4 c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E90D0h: Vec128<float> add<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f8 58 c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E9100h: Vec128<double> add<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 58 c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673E9130h: Vec256<byte> add<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd fc c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E9160h: Vec256<ushort> add<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd fd c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E9190h: Vec256<uint> add<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd fe c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E91C0h: Vec256<ulong> add<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd d4 c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E91F0h: Vec256<sbyte> add<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd fc c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E9220h: Vec256<short> add<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd fd c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E9250h: Vec256<int> add<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd fe c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E9280h: Vec256<long> add<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd d4 c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E92B0h: Vec256<float> add<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fc 58 c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E92E0h: Vec256<double> add<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd 58 c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673E9310h: void add<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 fc c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddb xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E9340h: void add<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 fd c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddw xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E9370h: void add<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 fe c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddd xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E93A0h: void add<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 d4 c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddq xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E93D0h: void add<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 fc c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddb xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E9400h: void add<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 fd c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddw xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E9430h: void add<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 fe c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddd xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E9460h: void add<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 d4 c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddq xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E9490h: void add<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f8 58 c1 c4 c1 78 11 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vaddps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E94C0h: void add<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 58 c1 c4 c1 79 11 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vaddpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673E94F0h: byref Byte add<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd fc c1 49 8b c0 c5 fe 7f 00 49 8b c0 c5 f8 77 c3 
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

7FF9673E9530h: byref UInt16 add<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd fd c1 49 8b c0 c5 fe 7f 00 49 8b c0 c5 f8 77 c3 
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

7FF9673E9570h: byref UInt32 add<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd fe c1 49 8b c0 c5 fe 7f 00 49 8b c0 c5 f8 77 c3 
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

7FF9673E99B0h: byref UInt64 add<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd d4 c1 49 8b c0 c5 fe 7f 00 49 8b c0 c5 f8 77 c3 
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

7FF9673E99F0h: byref SByte add<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd fc c1 49 8b c0 c5 fe 7f 00 49 8b c0 c5 f8 77 c3 
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

7FF9673E9A30h: byref Int16 add<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd fd c1 49 8b c0 c5 fe 7f 00 49 8b c0 c5 f8 77 c3 
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

7FF9673E9A70h: byref Int32 add<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd fe c1 49 8b c0 c5 fe 7f 00 49 8b c0 c5 f8 77 c3 
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

7FF9673E9AB0h: byref Int64 add<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd d4 c1 49 8b c0 c5 fe 7f 00 49 8b c0 c5 f8 77 c3 
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

7FF9673E9AF0h: byref Single add<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fc 58 c1 49 8b c0 c5 fc 11 00 49 8b c0 c5 f8 77 c3 
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

7FF9673E9B30h: byref Double add<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd 58 c1 49 8b c0 c5 fd 11 00 49 8b c0 c5 f8 77 c3 
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

7FF9673E9B70h: Num128<byte> add<byte>(byref Num128<byte> lhs, byref Num128<byte> rhs)
;; 57 56 53 48 83 ec 30 be 8d 00 00 00 bf 01 00 00 00 b9 ae 24 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 4b 61 6d 5f 48 8b d8 b9 ae 24 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 34 61 6d 5f 48 8b d0 48 8d 4c 24 28 40 88 39 89 71 04 48 8b cb 4c 8b 44 24 28 e8 d9 fc ff ff 48 8b c8 e8 91 1a 5a 5f cc 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Dh
  000ch  mov edi,1
  0011h  mov ecx,24AEh
  0016h  mov rdx,7FF966F81060h
  0020h  call 7FF9C6ABFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,24AEh
  002dh  mov rdx,7FF966F81060h
  0037h  call 7FF9C6ABFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9673E98A0h
  0057h  mov rcx,rax
  005ah  call 7FF9C698B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9673E9BF0h: Num128<ushort> add<ushort>(byref Num128<ushort> lhs, byref Num128<ushort> rhs)
;; 57 56 53 48 83 ec 30 be 8d 00 00 00 bf 01 00 00 00 b9 ae 24 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 cb 60 6d 5f 48 8b d8 b9 ae 24 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 b4 60 6d 5f 48 8b d0 48 8d 4c 24 28 40 88 39 89 71 04 48 8b cb 4c 8b 44 24 28 e8 d9 fc ff ff 48 8b c8 e8 11 1a 5a 5f cc 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Dh
  000ch  mov edi,1
  0011h  mov ecx,24AEh
  0016h  mov rdx,7FF966F81060h
  0020h  call 7FF9C6ABFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,24AEh
  002dh  mov rdx,7FF966F81060h
  0037h  call 7FF9C6ABFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9673E9920h
  0057h  mov rcx,rax
  005ah  call 7FF9C698B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9673E9C70h: Num128<uint> add<uint>(byref Num128<uint> lhs, byref Num128<uint> rhs)
;; 57 56 53 48 83 ec 30 be 8d 00 00 00 bf 01 00 00 00 b9 ae 24 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 4b 60 6d 5f 48 8b d8 b9 ae 24 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 34 60 6d 5f 48 8b d0 48 8d 4c 24 28 40 88 39 89 71 04 48 8b cb 4c 8b 44 24 28 e8 c9 fc ff ff 48 8b c8 e8 91 19 5a 5f cc 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Dh
  000ch  mov edi,1
  0011h  mov ecx,24AEh
  0016h  mov rdx,7FF966F81060h
  0020h  call 7FF9C6ABFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,24AEh
  002dh  mov rdx,7FF966F81060h
  0037h  call 7FF9C6ABFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9673E9990h
  0057h  mov rcx,rax
  005ah  call 7FF9C698B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9673EA0F0h: Num128<ulong> add<ulong>(byref Num128<ulong> lhs, byref Num128<ulong> rhs)
;; 57 56 53 48 83 ec 30 be 8d 00 00 00 bf 01 00 00 00 b9 ae 24 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 cb 5b 6d 5f 48 8b d8 b9 ae 24 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 b4 5b 6d 5f 48 8b d0 48 8d 4c 24 28 40 88 39 89 71 04 48 8b cb 4c 8b 44 24 28 e8 01 fc ff ff 48 8b c8 e8 11 15 5a 5f cc 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Dh
  000ch  mov edi,1
  0011h  mov ecx,24AEh
  0016h  mov rdx,7FF966F81060h
  0020h  call 7FF9C6ABFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,24AEh
  002dh  mov rdx,7FF966F81060h
  0037h  call 7FF9C6ABFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9673E9D48h
  0057h  mov rcx,rax
  005ah  call 7FF9C698B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9673EA170h: Num128<sbyte> add<sbyte>(byref Num128<sbyte> lhs, byref Num128<sbyte> rhs)
;; 57 56 53 48 83 ec 30 be 8d 00 00 00 bf 01 00 00 00 b9 ae 24 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 4b 5b 6d 5f 48 8b d8 b9 ae 24 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 34 5b 6d 5f 48 8b d0 48 8d 4c 24 28 40 88 39 89 71 04 48 8b cb 4c 8b 44 24 28 e8 f1 fb ff ff 48 8b c8 e8 91 14 5a 5f cc 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Dh
  000ch  mov edi,1
  0011h  mov ecx,24AEh
  0016h  mov rdx,7FF966F81060h
  0020h  call 7FF9C6ABFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,24AEh
  002dh  mov rdx,7FF966F81060h
  0037h  call 7FF9C6ABFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9673E9DB8h
  0057h  mov rcx,rax
  005ah  call 7FF9C698B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9673EA1F0h: Num128<short> add<short>(byref Num128<short> lhs, byref Num128<short> rhs)
;; 57 56 53 48 83 ec 30 be 8d 00 00 00 bf 01 00 00 00 b9 ae 24 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 cb 5a 6d 5f 48 8b d8 b9 ae 24 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 b4 5a 6d 5f 48 8b d0 48 8d 4c 24 28 40 88 39 89 71 04 48 8b cb 4c 8b 44 24 28 e8 e1 fb ff ff 48 8b c8 e8 11 14 5a 5f cc 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Dh
  000ch  mov edi,1
  0011h  mov ecx,24AEh
  0016h  mov rdx,7FF966F81060h
  0020h  call 7FF9C6ABFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,24AEh
  002dh  mov rdx,7FF966F81060h
  0037h  call 7FF9C6ABFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9673E9E28h
  0057h  mov rcx,rax
  005ah  call 7FF9C698B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9673EA270h: Num128<int> add<int>(byref Num128<int> lhs, byref Num128<int> rhs)
;; 57 56 53 48 83 ec 30 be 8d 00 00 00 bf 01 00 00 00 b9 ae 24 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 4b 5a 6d 5f 48 8b d8 b9 ae 24 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 34 5a 6d 5f 48 8b d0 48 8d 4c 24 28 40 88 39 89 71 04 48 8b cb 4c 8b 44 24 28 e8 d1 fb ff ff 48 8b c8 e8 91 13 5a 5f cc 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Dh
  000ch  mov edi,1
  0011h  mov ecx,24AEh
  0016h  mov rdx,7FF966F81060h
  0020h  call 7FF9C6ABFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,24AEh
  002dh  mov rdx,7FF966F81060h
  0037h  call 7FF9C6ABFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9673E9E98h
  0057h  mov rcx,rax
  005ah  call 7FF9C698B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9673EA2F0h: Num128<long> add<long>(byref Num128<long> lhs, byref Num128<long> rhs)
;; 57 56 53 48 83 ec 30 be 8d 00 00 00 bf 01 00 00 00 b9 ae 24 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 cb 59 6d 5f 48 8b d8 b9 ae 24 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 b4 59 6d 5f 48 8b d0 48 8d 4c 24 28 40 88 39 89 71 04 48 8b cb 4c 8b 44 24 28 e8 c1 fb ff ff 48 8b c8 e8 11 13 5a 5f cc 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Dh
  000ch  mov edi,1
  0011h  mov ecx,24AEh
  0016h  mov rdx,7FF966F81060h
  0020h  call 7FF9C6ABFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,24AEh
  002dh  mov rdx,7FF966F81060h
  0037h  call 7FF9C6ABFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9673E9F08h
  0057h  mov rcx,rax
  005ah  call 7FF9C698B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9673EA770h: Num128<float> add<float>(byref Num128<float> lhs, byref Num128<float> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 fa 58 c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EA7A0h: Num128<double> add<double>(byref Num128<double> lhs, byref Num128<double> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 fb 58 c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EA7D0h: Vec128<byte> sub<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 f8 c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EA800h: Vec128<ushort> sub<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 f9 c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EA830h: Vec128<uint> sub<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 fa c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EA860h: Vec128<ulong> sub<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 fb c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EA890h: Vec128<sbyte> sub<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 f8 c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EA8C0h: Vec128<short> sub<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 f9 c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EAD00h: Vec128<int> sub<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 fa c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EAD30h: Vec128<long> sub<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 fb c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EAD60h: Vec128<float> sub<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f8 5c c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EAD90h: Vec128<double> sub<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 5c c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EADC0h: Vec256<byte> sub<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd f8 c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EADF0h: Vec256<ushort> sub<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd f9 c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EAE20h: Vec256<uint> sub<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd fa c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EAE50h: Vec256<ulong> sub<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd fb c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EAE80h: Vec256<sbyte> sub<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd f8 c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EAEB0h: Vec256<short> sub<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd f9 c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EAEE0h: Vec256<int> sub<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd fa c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EAF10h: Vec256<long> sub<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd fb c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EAF40h: Vec256<float> sub<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fc 5c c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EAF70h: Vec256<double> sub<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd 5c c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EAFA0h: void sub<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 f8 c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubb xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673EAFD0h: void sub<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 f9 c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubw xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673EB000h: void sub<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 fa c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubd xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673EB030h: void sub<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 fb c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubq xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673EB060h: void sub<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 f8 c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubb xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673EB090h: void sub<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 f9 c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubw xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673EB0C0h: void sub<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 fa c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubd xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673EB0F0h: void sub<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 fb c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubq xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673EB120h: void sub<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f8 5c c1 c4 c1 78 11 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vsubps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673EB150h: void sub<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 5c c1 c4 c1 79 11 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vsubpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9673EB180h: void sub<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd f8 c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9673EB1B0h: void sub<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd f9 c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9673EB1E0h: void sub<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd fa c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9673EB210h: void sub<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd fb c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9673EB240h: void sub<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd f8 c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9673EB270h: void sub<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd f9 c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9673EB2A0h: void sub<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd fa c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9673EB2D0h: void sub<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd fb c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9673EB710h: void sub<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fc 5c c1 c4 c1 7c 11 00 c5 f8 77 c3 
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

7FF9673EB740h: void sub<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd 5c c1 c4 c1 7d 11 00 c5 f8 77 c3 
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

7FF9673EB770h: Num128<byte> sub<byte>(byref Num128<byte> lhs, byref Num128<byte> rhs)
;; 57 56 53 48 83 ec 30 be 8a 00 00 00 bf 01 00 00 00 b9 38 26 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 4b 45 6d 5f 48 8b d8 b9 38 26 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 34 45 6d 5f 48 8b d0 48 8d 4c 24 28 40 88 39 89 71 04 48 8b cb 4c 8b 44 24 28 e8 d9 e0 ff ff 48 8b c8 e8 91 fe 59 5f cc 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Ah
  000ch  mov edi,1
  0011h  mov ecx,2638h
  0016h  mov rdx,7FF966F81060h
  0020h  call 7FF9C6ABFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2638h
  002dh  mov rdx,7FF966F81060h
  0037h  call 7FF9C6ABFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9673E98A0h
  0057h  mov rcx,rax
  005ah  call 7FF9C698B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9673EB7F0h: Num128<ushort> sub<ushort>(byref Num128<ushort> lhs, byref Num128<ushort> rhs)
;; 57 56 53 48 83 ec 30 be 8a 00 00 00 bf 01 00 00 00 b9 38 26 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 cb 44 6d 5f 48 8b d8 b9 38 26 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 b4 44 6d 5f 48 8b d0 48 8d 4c 24 28 40 88 39 89 71 04 48 8b cb 4c 8b 44 24 28 e8 d9 e0 ff ff 48 8b c8 e8 11 fe 59 5f cc 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Ah
  000ch  mov edi,1
  0011h  mov ecx,2638h
  0016h  mov rdx,7FF966F81060h
  0020h  call 7FF9C6ABFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2638h
  002dh  mov rdx,7FF966F81060h
  0037h  call 7FF9C6ABFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9673E9920h
  0057h  mov rcx,rax
  005ah  call 7FF9C698B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9673EB870h: Num128<uint> sub<uint>(byref Num128<uint> lhs, byref Num128<uint> rhs)
;; 57 56 53 48 83 ec 30 be 8a 00 00 00 bf 01 00 00 00 b9 38 26 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 4b 44 6d 5f 48 8b d8 b9 38 26 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 34 44 6d 5f 48 8b d0 48 8d 4c 24 28 40 88 39 89 71 04 48 8b cb 4c 8b 44 24 28 e8 c9 e0 ff ff 48 8b c8 e8 91 fd 59 5f cc 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Ah
  000ch  mov edi,1
  0011h  mov ecx,2638h
  0016h  mov rdx,7FF966F81060h
  0020h  call 7FF9C6ABFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2638h
  002dh  mov rdx,7FF966F81060h
  0037h  call 7FF9C6ABFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9673E9990h
  0057h  mov rcx,rax
  005ah  call 7FF9C698B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9673EB8F0h: Num128<ulong> sub<ulong>(byref Num128<ulong> lhs, byref Num128<ulong> rhs)
;; 57 56 53 48 83 ec 30 be 8a 00 00 00 bf 01 00 00 00 b9 38 26 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 cb 43 6d 5f 48 8b d8 b9 38 26 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 b4 43 6d 5f 48 8b d0 48 8d 4c 24 28 40 88 39 89 71 04 48 8b cb 4c 8b 44 24 28 e8 01 e4 ff ff 48 8b c8 e8 11 fd 59 5f cc 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Ah
  000ch  mov edi,1
  0011h  mov ecx,2638h
  0016h  mov rdx,7FF966F81060h
  0020h  call 7FF9C6ABFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2638h
  002dh  mov rdx,7FF966F81060h
  0037h  call 7FF9C6ABFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9673E9D48h
  0057h  mov rcx,rax
  005ah  call 7FF9C698B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9673EB970h: Num128<sbyte> sub<sbyte>(byref Num128<sbyte> lhs, byref Num128<sbyte> rhs)
;; 57 56 53 48 83 ec 30 be 8a 00 00 00 bf 01 00 00 00 b9 38 26 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 4b 43 6d 5f 48 8b d8 b9 38 26 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 34 43 6d 5f 48 8b d0 48 8d 4c 24 28 40 88 39 89 71 04 48 8b cb 4c 8b 44 24 28 e8 f1 e3 ff ff 48 8b c8 e8 91 fc 59 5f cc 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Ah
  000ch  mov edi,1
  0011h  mov ecx,2638h
  0016h  mov rdx,7FF966F81060h
  0020h  call 7FF9C6ABFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2638h
  002dh  mov rdx,7FF966F81060h
  0037h  call 7FF9C6ABFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9673E9DB8h
  0057h  mov rcx,rax
  005ah  call 7FF9C698B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9673EB9F0h: Num128<short> sub<short>(byref Num128<short> lhs, byref Num128<short> rhs)
;; 57 56 53 48 83 ec 30 be 8a 00 00 00 bf 01 00 00 00 b9 38 26 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 cb 42 6d 5f 48 8b d8 b9 38 26 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 b4 42 6d 5f 48 8b d0 48 8d 4c 24 28 40 88 39 89 71 04 48 8b cb 4c 8b 44 24 28 e8 e1 e3 ff ff 48 8b c8 e8 11 fc 59 5f cc 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Ah
  000ch  mov edi,1
  0011h  mov ecx,2638h
  0016h  mov rdx,7FF966F81060h
  0020h  call 7FF9C6ABFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2638h
  002dh  mov rdx,7FF966F81060h
  0037h  call 7FF9C6ABFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9673E9E28h
  0057h  mov rcx,rax
  005ah  call 7FF9C698B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9673EBA70h: Num128<int> sub<int>(byref Num128<int> lhs, byref Num128<int> rhs)
;; 57 56 53 48 83 ec 30 be 8a 00 00 00 bf 01 00 00 00 b9 38 26 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 4b 42 6d 5f 48 8b d8 b9 38 26 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 34 42 6d 5f 48 8b d0 48 8d 4c 24 28 40 88 39 89 71 04 48 8b cb 4c 8b 44 24 28 e8 d1 e3 ff ff 48 8b c8 e8 91 fb 59 5f cc 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Ah
  000ch  mov edi,1
  0011h  mov ecx,2638h
  0016h  mov rdx,7FF966F81060h
  0020h  call 7FF9C6ABFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2638h
  002dh  mov rdx,7FF966F81060h
  0037h  call 7FF9C6ABFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9673E9E98h
  0057h  mov rcx,rax
  005ah  call 7FF9C698B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9673EBAF0h: Num128<long> sub<long>(byref Num128<long> lhs, byref Num128<long> rhs)
;; 57 56 53 48 83 ec 30 be 8a 00 00 00 bf 01 00 00 00 b9 38 26 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 cb 41 6d 5f 48 8b d8 b9 38 26 00 00 48 ba 60 10 f8 66 f9 7f 00 00 e8 b4 41 6d 5f 48 8b d0 48 8d 4c 24 28 40 88 39 89 71 04 48 8b cb 4c 8b 44 24 28 e8 c1 e3 ff ff 48 8b c8 e8 11 fb 59 5f cc 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Ah
  000ch  mov edi,1
  0011h  mov ecx,2638h
  0016h  mov rdx,7FF966F81060h
  0020h  call 7FF9C6ABFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2638h
  002dh  mov rdx,7FF966F81060h
  0037h  call 7FF9C6ABFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF9673E9F08h
  0057h  mov rcx,rax
  005ah  call 7FF9C698B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF9673EBB70h: Num128<float> sub<float>(byref Num128<float> lhs, byref Num128<float> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 fa 5c c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EBBA0h: Num128<double> sub<double>(byref Num128<double> lhs, byref Num128<double> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 fb 5c c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EBBD0h: Vec128<byte> and<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 db c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EBC00h: Vec128<ushort> and<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 db c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EBC30h: Vec128<uint> and<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 db c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EBC60h: Vec128<ulong> and<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 db c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EBC90h: Vec128<sbyte> and<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 db c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EBCC0h: Vec128<short> and<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 db c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EBCF0h: Vec128<int> and<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 db c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EBD20h: Vec128<long> and<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 db c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EBD50h: Vec128<float> and<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f8 54 c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EBD80h: Vec128<double> and<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 54 c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9673EBDB0h: Vec256<byte> and<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd db c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EBDE0h: Vec256<ushort> and<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd db c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EBE10h: Vec256<uint> and<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd db c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EBE40h: Vec256<ulong> and<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd db c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EBE70h: Vec256<sbyte> and<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd db c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EBEA0h: Vec256<short> and<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd db c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EBED0h: Vec256<int> and<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd db c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EBF00h: Vec256<long> and<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd db c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9673EBF30h: Vec256<float> and<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fc 54 c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9672EC2A0h: Vec256<double> and<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd 54 c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9672EC2D0h: void and<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 db c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672EC300h: void and<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 db c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672EC330h: void and<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 db c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672EC360h: void and<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 db c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672EC390h: void and<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 db c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672EC3C0h: void and<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 db c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672EC3F0h: void and<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 db c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672EC420h: void and<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 db c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672EC450h: void and<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f8 54 c1 c4 c1 78 11 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vandps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672EC480h: void and<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 54 c1 c4 c1 79 11 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vandpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672EC4B0h: void and<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd db c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9672EC4E0h: void and<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd db c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9672EC510h: void and<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd db c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9672EC540h: void and<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd db c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9672EC570h: void and<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd db c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9672EC5A0h: void and<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd db c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9672EC5D0h: void and<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd db c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9672EC600h: void and<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd db c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9672EC630h: void and<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fc 54 c1 c4 c1 7c 11 00 c5 f8 77 c3 
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

7FF9672EC660h: void and<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd 54 c1 c4 c1 7d 11 00 c5 f8 77 c3 
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

7FF9672EC690h: Vec128<byte> or<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 eb c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9672EC6C0h: Vec128<ushort> or<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 eb c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9672EC6F0h: Vec128<uint> or<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 eb c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9672EC720h: Vec128<ulong> or<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 eb c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9672EC750h: Vec128<sbyte> or<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 eb c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9672EC780h: Vec128<short> or<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 eb c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9672EC7B0h: Vec128<int> or<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 eb c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9672EC7E0h: Vec128<long> or<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 eb c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9672EC810h: Vec128<float> or<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f8 56 c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9672EC840h: Vec128<double> or<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f9 56 c1 c5 f9 11 01 48 8b c1 c3 
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

7FF9672EC870h: Vec256<byte> or<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd eb c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9672ECCB0h: Vec256<ushort> or<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd eb c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9672ECCE0h: Vec256<uint> or<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd eb c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9672ECD10h: Vec256<ulong> or<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd eb c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9672ECD40h: Vec256<sbyte> or<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd eb c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9672ECD70h: Vec256<short> or<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd eb c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9672ECDA0h: Vec256<int> or<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd eb c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9672ECDD0h: Vec256<long> or<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd eb c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9672ECE00h: Vec256<float> or<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fc 56 c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9672ECE30h: Vec256<double> or<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c5 fd 56 c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
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

7FF9672ECE60h: void or<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 eb c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672ECE90h: void or<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 eb c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672ECEC0h: void or<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 eb c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672ECEF0h: void or<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 eb c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672ECF20h: void or<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 eb c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672ECF50h: void or<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 eb c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672ECF80h: void or<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 eb c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672ECFB0h: void or<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 eb c1 c4 c1 7a 7f 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672ECFE0h: void or<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f8 56 c1 c4 c1 78 11 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vorps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672ED010h: void or<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
;; c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c5 f9 56 c1 c4 c1 79 11 00 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vorpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF9672ED040h: void or<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd eb c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9672ED070h: void or<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd eb c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9672ED0A0h: void or<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd eb c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9672ED0D0h: void or<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd eb c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9672ED100h: void or<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd eb c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9672ED130h: void or<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd eb c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9672ED160h: void or<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd eb c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9672ED190h: void or<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd eb c1 c4 c1 7e 7f 00 c5 f8 77 c3 
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

7FF9672ED1C0h: void or<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fc 56 c1 c4 c1 7c 11 00 c5 f8 77 c3 
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

7FF9672ED1F0h: void or<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
;; c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c5 fd 56 c1 c4 c1 7d 11 00 c5 f8 77 c3 
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

