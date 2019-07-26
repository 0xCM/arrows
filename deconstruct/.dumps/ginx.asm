# 2019-07-24 20:36:14:559
7FF95A4D48E0h: Vec128<byte> or<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xeb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D4D20h: Vec128<ushort> or<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xeb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D4D50h: Vec128<uint> or<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xeb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D5190h: Vec128<ulong> or<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xeb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D55D0h: Vec128<sbyte> or<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xeb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D5600h: Vec128<short> or<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xeb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D5A40h: Vec128<int> or<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xeb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D5E80h: Vec128<long> or<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xeb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D5EB0h: Vec128<float> or<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf8, 0x56, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D62F0h: Vec128<double> or<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0x56, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D6B30h: Vec256<byte> or<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xeb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D6F70h: Vec256<ushort> or<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xeb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D6FA0h: Vec256<uint> or<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xeb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D73E0h: Vec256<ulong> or<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xeb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D7820h: Vec256<sbyte> or<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xeb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D7850h: Vec256<short> or<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xeb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D7C90h: Vec256<int> or<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xeb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D80D0h: Vec256<long> or<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xeb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D8100h: Vec256<float> or<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfc, 0x56, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D8540h: Vec256<double> or<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0x56, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D8570h: void or<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xeb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D85A0h: void or<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xeb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D85D0h: void or<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xeb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D8600h: void or<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xeb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D8630h: void or<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xeb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D8A70h: void or<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xeb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D8AA0h: void or<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xeb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D8AD0h: void or<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xeb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D8B00h: void or<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf8, 0x56, 0xc1, 0xc4, 0xc1, 0x78, 0x11, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vorps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D8B30h: void or<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0x56, 0xc1, 0xc4, 0xc1, 0x79, 0x11, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vorpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D8B60h: void or<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xeb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D8B90h: void or<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xeb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D8BC0h: void or<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xeb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D8BF0h: void or<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xeb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D8C20h: void or<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xeb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D8C50h: void or<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xeb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D8C80h: void or<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xeb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D8CB0h: void or<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xeb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D8CE0h: void or<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfc, 0x56, 0xc1, 0xc4, 0xc1, 0x7c, 0x11, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D8D10h: void or<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0x56, 0xc1, 0xc4, 0xc1, 0x7d, 0x11, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D8D40h: Vec128<byte> xor<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xef, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D8D70h: Vec128<ushort> xor<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xef, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D8DA0h: Vec128<uint> xor<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xef, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D8DD0h: Vec128<ulong> xor<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xef, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D8E00h: Vec128<sbyte> xor<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xef, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D8E30h: Vec128<short> xor<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xef, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D8E60h: Vec128<int> xor<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xef, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D92A0h: Vec128<long> xor<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xef, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D92D0h: Vec128<float> xor<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf8, 0x57, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D9300h: Vec128<double> xor<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0x57, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D9330h: Vec256<byte> xor<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xef, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9360h: Vec256<ushort> xor<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xef, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9390h: Vec256<uint> xor<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xef, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D93C0h: Vec256<ulong> xor<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xef, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D93F0h: Vec256<sbyte> xor<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xef, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9420h: Vec256<short> xor<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xef, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9450h: Vec256<int> xor<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xef, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9480h: Vec256<long> xor<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xef, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D94B0h: Vec256<float> xor<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfc, 0x57, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D94E0h: Vec256<double> xor<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0x57, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9510h: void xor<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xef, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D9540h: void xor<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xef, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D9570h: void xor<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xef, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D95A0h: void xor<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xef, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D95D0h: void xor<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xef, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D9600h: void xor<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xef, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D9630h: void xor<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xef, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D9660h: void xor<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xef, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpxor xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D9690h: void xor<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf8, 0x57, 0xc1, 0xc4, 0xc1, 0x78, 0x11, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vxorps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D96C0h: void xor<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0x57, 0xc1, 0xc4, 0xc1, 0x79, 0x11, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vxorpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4D96F0h: void xor<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xef, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9720h: void xor<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xef, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9750h: void xor<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xef, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9780h: void xor<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xef, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D97B0h: void xor<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xef, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D97E0h: void xor<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xef, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9810h: void xor<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xef, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9840h: void xor<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xef, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9870h: void xor<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfc, 0x57, 0xc1, 0xc4, 0xc1, 0x7c, 0x11, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9CB0h: void xor<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0x57, 0xc1, 0xc4, 0xc1, 0x7d, 0x11, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9CE0h: Vec128<byte> add<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfc, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D9D10h: Vec128<ushort> add<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfd, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D9D40h: Vec128<uint> add<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfe, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D9D70h: Vec128<ulong> add<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xd4, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D9DA0h: Vec128<sbyte> add<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfc, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D9DD0h: Vec128<short> add<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfd, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D9E00h: Vec128<int> add<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfe, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D9E30h: Vec128<long> add<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xd4, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D9E60h: Vec128<float> add<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf8, 0x58, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D9E90h: Vec128<double> add<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0x58, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4D9EC0h: Vec256<byte> add<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfc, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9EF0h: Vec256<ushort> add<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfd, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9F20h: Vec256<uint> add<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfe, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9F50h: Vec256<ulong> add<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xd4, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9F80h: Vec256<sbyte> add<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfc, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9FB0h: Vec256<short> add<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfd, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4D9FE0h: Vec256<int> add<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfe, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DA010h: Vec256<long> add<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xd4, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DA040h: Vec256<float> add<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfc, 0x58, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DA070h: Vec256<double> add<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0x58, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DA0A0h: void add<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfc, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddb xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DA0D0h: void add<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfd, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddw xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DA100h: void add<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfe, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddd xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DA130h: void add<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xd4, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddq xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DA160h: void add<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfc, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddb xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DA190h: void add<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfd, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddw xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DA1C0h: void add<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfe, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddd xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DA1F0h: void add<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xd4, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpaddq xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DA220h: void add<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf8, 0x58, 0xc1, 0xc4, 0xc1, 0x78, 0x11, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vaddps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DA250h: void add<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0x58, 0xc1, 0xc4, 0xc1, 0x79, 0x11, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vaddpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DA280h: byref Byte add<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfc, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfe, 0x7f, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DA6C0h: byref UInt16 add<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfd, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfe, 0x7f, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DA700h: byref UInt32 add<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfe, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfe, 0x7f, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DA740h: byref UInt64 add<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xd4, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfe, 0x7f, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DA780h: byref SByte add<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfc, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfe, 0x7f, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DA7C0h: byref Int16 add<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfd, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfe, 0x7f, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DA800h: byref Int32 add<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfe, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfe, 0x7f, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DA840h: byref Int64 add<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xd4, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfe, 0x7f, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DA880h: byref Single add<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfc, 0x58, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfc, 0x11, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DA8C0h: byref Double add<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0x58, 0xc1, 0x49, 0x8b, 0xc0, 0xc5, 0xfd, 0x11, 0x00, 0x49, 0x8b, 0xc0, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DA900h: Num128<byte> add<byte>(byref Num128<byte> lhs, byref Num128<byte> rhs)
;; {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8d, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x12, 0x25, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0xbb, 0x53, 0x6e, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x12, 0x25, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0xa4, 0x53, 0x6e, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0x99, 0xfc, 0xff, 0xff, 0x48, 0x8b, 0xc8, 0xe8, 0x01, 0x0d, 0x5b, 0x5f, 0xcc}
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Dh
  000ch  mov edi,1
  0011h  mov ecx,2512h
  0016h  mov rdx,7FF95A0710C0h
  0020h  call 7FF9B9BBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2512h
  002dh  mov rdx,7FF95A0710C0h
  0037h  call 7FF9B9BBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF95A4DA5F0h
  0057h  mov rcx,rax
  005ah  call 7FF9B9A8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF95A4DA980h: Num128<ushort> add<ushort>(byref Num128<ushort> lhs, byref Num128<ushort> rhs)
;; {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8d, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x12, 0x25, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0x3b, 0x53, 0x6e, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x12, 0x25, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0x24, 0x53, 0x6e, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0x99, 0xfc, 0xff, 0xff, 0x48, 0x8b, 0xc8, 0xe8, 0x81, 0x0c, 0x5b, 0x5f, 0xcc}
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Dh
  000ch  mov edi,1
  0011h  mov ecx,2512h
  0016h  mov rdx,7FF95A0710C0h
  0020h  call 7FF9B9BBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2512h
  002dh  mov rdx,7FF95A0710C0h
  0037h  call 7FF9B9BBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF95A4DA670h
  0057h  mov rcx,rax
  005ah  call 7FF9B9A8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF95A4DAE00h: Num128<uint> add<uint>(byref Num128<uint> lhs, byref Num128<uint> rhs)
;; {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8d, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x12, 0x25, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0xbb, 0x4e, 0x6e, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x12, 0x25, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0xa4, 0x4e, 0x6e, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0x29, 0xf8, 0xff, 0xff, 0x48, 0x8b, 0xc8, 0xe8, 0x01, 0x08, 0x5b, 0x5f, 0xcc}
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Dh
  000ch  mov edi,1
  0011h  mov ecx,2512h
  0016h  mov rdx,7FF95A0710C0h
  0020h  call 7FF9B9BBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2512h
  002dh  mov rdx,7FF95A0710C0h
  0037h  call 7FF9B9BBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF95A4DA680h
  0057h  mov rcx,rax
  005ah  call 7FF9B9A8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF95A4DAE80h: Num128<ulong> add<ulong>(byref Num128<ulong> lhs, byref Num128<ulong> rhs)
;; {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8d, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x12, 0x25, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0x3b, 0x4e, 0x6e, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x12, 0x25, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0x24, 0x4e, 0x6e, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0xb9, 0xf7, 0xff, 0xff, 0x48, 0x8b, 0xc8, 0xe8, 0x81, 0x07, 0x5b, 0x5f, 0xcc}
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Dh
  000ch  mov edi,1
  0011h  mov ecx,2512h
  0016h  mov rdx,7FF95A0710C0h
  0020h  call 7FF9B9BBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2512h
  002dh  mov rdx,7FF95A0710C0h
  0037h  call 7FF9B9BBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF95A4DA690h
  0057h  mov rcx,rax
  005ah  call 7FF9B9A8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF95A4DAF00h: Num128<sbyte> add<sbyte>(byref Num128<sbyte> lhs, byref Num128<sbyte> rhs)
;; {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8d, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x12, 0x25, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0xbb, 0x4d, 0x6e, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x12, 0x25, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0xa4, 0x4d, 0x6e, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0x49, 0xf7, 0xff, 0xff, 0x48, 0x8b, 0xc8, 0xe8, 0x01, 0x07, 0x5b, 0x5f, 0xcc}
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Dh
  000ch  mov edi,1
  0011h  mov ecx,2512h
  0016h  mov rdx,7FF95A0710C0h
  0020h  call 7FF9B9BBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2512h
  002dh  mov rdx,7FF95A0710C0h
  0037h  call 7FF9B9BBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF95A4DA6A0h
  0057h  mov rcx,rax
  005ah  call 7FF9B9A8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF95A4DAF80h: Num128<short> add<short>(byref Num128<short> lhs, byref Num128<short> rhs)
;; {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8d, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x12, 0x25, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0x3b, 0x4d, 0x6e, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x12, 0x25, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0x24, 0x4d, 0x6e, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0xa1, 0xfb, 0xff, 0xff, 0x48, 0x8b, 0xc8, 0xe8, 0x81, 0x06, 0x5b, 0x5f, 0xcc}
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Dh
  000ch  mov edi,1
  0011h  mov ecx,2512h
  0016h  mov rdx,7FF95A0710C0h
  0020h  call 7FF9B9BBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2512h
  002dh  mov rdx,7FF95A0710C0h
  0037h  call 7FF9B9BBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF95A4DAB78h
  0057h  mov rcx,rax
  005ah  call 7FF9B9A8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF95A4DB000h: Num128<int> add<int>(byref Num128<int> lhs, byref Num128<int> rhs)
;; {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8d, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x12, 0x25, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0xbb, 0x4c, 0x6e, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x12, 0x25, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0xa4, 0x4c, 0x6e, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0x91, 0xfb, 0xff, 0xff, 0x48, 0x8b, 0xc8, 0xe8, 0x01, 0x06, 0x5b, 0x5f, 0xcc}
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Dh
  000ch  mov edi,1
  0011h  mov ecx,2512h
  0016h  mov rdx,7FF95A0710C0h
  0020h  call 7FF9B9BBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2512h
  002dh  mov rdx,7FF95A0710C0h
  0037h  call 7FF9B9BBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF95A4DABE8h
  0057h  mov rcx,rax
  005ah  call 7FF9B9A8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF95A4DB080h: Num128<long> add<long>(byref Num128<long> lhs, byref Num128<long> rhs)
;; {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8d, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x12, 0x25, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0x3b, 0x4c, 0x6e, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x12, 0x25, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0x24, 0x4c, 0x6e, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0x81, 0xfb, 0xff, 0xff, 0x48, 0x8b, 0xc8, 0xe8, 0x81, 0x05, 0x5b, 0x5f, 0xcc}
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Dh
  000ch  mov edi,1
  0011h  mov ecx,2512h
  0016h  mov rdx,7FF95A0710C0h
  0020h  call 7FF9B9BBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,2512h
  002dh  mov rdx,7FF95A0710C0h
  0037h  call 7FF9B9BBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF95A4DAC58h
  0057h  mov rcx,rax
  005ah  call 7FF9B9A8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF95A4DB500h: Num128<float> add<float>(byref Num128<float> lhs, byref Num128<float> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xfa, 0x58, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4DB530h: Num128<double> add<double>(byref Num128<double> lhs, byref Num128<double> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xfb, 0x58, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4DB560h: Vec128<byte> sub<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xf8, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4DB590h: Vec128<ushort> sub<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xf9, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4DB5C0h: Vec128<uint> sub<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfa, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4DBA00h: Vec128<ulong> sub<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4DBA30h: Vec128<sbyte> sub<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xf8, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4DBA60h: Vec128<short> sub<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xf9, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4DBA90h: Vec128<int> sub<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfa, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4DBAC0h: Vec128<long> sub<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xfb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4DBAF0h: Vec128<float> sub<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf8, 0x5c, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4DBB20h: Vec128<double> sub<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0x5c, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A4DBB50h: Vec256<byte> sub<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xf8, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DBB80h: Vec256<ushort> sub<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xf9, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DBBB0h: Vec256<uint> sub<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfa, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DBBE0h: Vec256<ulong> sub<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DBC10h: Vec256<sbyte> sub<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xf8, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DBC40h: Vec256<short> sub<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xf9, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DBC70h: Vec256<int> sub<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfa, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DBCA0h: Vec256<long> sub<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xfb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DBCD0h: Vec256<float> sub<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfc, 0x5c, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DBD00h: Vec256<double> sub<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0x5c, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DBD30h: void sub<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xf8, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubb xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DBD60h: void sub<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xf9, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubw xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DBD90h: void sub<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfa, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubd xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DBDC0h: void sub<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubq xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DBDF0h: void sub<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xf8, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubb xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DBE20h: void sub<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xf9, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubw xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DBE50h: void sub<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfa, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubd xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DBE80h: void sub<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xfb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpsubq xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DBEB0h: void sub<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf8, 0x5c, 0xc1, 0xc4, 0xc1, 0x78, 0x11, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vsubps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DBEE0h: void sub<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0x5c, 0xc1, 0xc4, 0xc1, 0x79, 0x11, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vsubpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A4DBF10h: void sub<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xf8, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DBF40h: void sub<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xf9, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DBF70h: void sub<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfa, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DBFA0h: void sub<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A4DBFD0h: void sub<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xf8, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DC860h: void sub<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xf9, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DC890h: void sub<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfa, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DC8C0h: void sub<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xfb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DC8F0h: void sub<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfc, 0x5c, 0xc1, 0xc4, 0xc1, 0x7c, 0x11, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DC920h: void sub<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0x5c, 0xc1, 0xc4, 0xc1, 0x7d, 0x11, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DC950h: Num128<byte> sub<byte>(byref Num128<byte> lhs, byref Num128<byte> rhs)
;; {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8a, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x9c, 0x26, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0x6b, 0x33, 0x7e, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x9c, 0x26, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0x54, 0x33, 0x7e, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0x49, 0xdc, 0x0f, 0x00, 0x48, 0x8b, 0xc8, 0xe8, 0xb1, 0xec, 0x6a, 0x5f, 0xcc}
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Ah
  000ch  mov edi,1
  0011h  mov ecx,269Ch
  0016h  mov rdx,7FF95A0710C0h
  0020h  call 7FF9B9BBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,269Ch
  002dh  mov rdx,7FF95A0710C0h
  0037h  call 7FF9B9BBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF95A4DA5F0h
  0057h  mov rcx,rax
  005ah  call 7FF9B9A8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF95A3DC9D0h: Num128<ushort> sub<ushort>(byref Num128<ushort> lhs, byref Num128<ushort> rhs)
;; {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8a, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x9c, 0x26, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0xeb, 0x32, 0x7e, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x9c, 0x26, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0xd4, 0x32, 0x7e, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0x49, 0xdc, 0x0f, 0x00, 0x48, 0x8b, 0xc8, 0xe8, 0x31, 0xec, 0x6a, 0x5f, 0xcc}
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Ah
  000ch  mov edi,1
  0011h  mov ecx,269Ch
  0016h  mov rdx,7FF95A0710C0h
  0020h  call 7FF9B9BBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,269Ch
  002dh  mov rdx,7FF95A0710C0h
  0037h  call 7FF9B9BBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF95A4DA670h
  0057h  mov rcx,rax
  005ah  call 7FF9B9A8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF95A3DCA50h: Num128<uint> sub<uint>(byref Num128<uint> lhs, byref Num128<uint> rhs)
;; {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8a, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x9c, 0x26, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0x6b, 0x32, 0x7e, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x9c, 0x26, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0x54, 0x32, 0x7e, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0xd9, 0xdb, 0x0f, 0x00, 0x48, 0x8b, 0xc8, 0xe8, 0xb1, 0xeb, 0x6a, 0x5f, 0xcc}
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Ah
  000ch  mov edi,1
  0011h  mov ecx,269Ch
  0016h  mov rdx,7FF95A0710C0h
  0020h  call 7FF9B9BBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,269Ch
  002dh  mov rdx,7FF95A0710C0h
  0037h  call 7FF9B9BBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF95A4DA680h
  0057h  mov rcx,rax
  005ah  call 7FF9B9A8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF95A3DCAD0h: Num128<ulong> sub<ulong>(byref Num128<ulong> lhs, byref Num128<ulong> rhs)
;; {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8a, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x9c, 0x26, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0xeb, 0x31, 0x7e, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x9c, 0x26, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0xd4, 0x31, 0x7e, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0x69, 0xdb, 0x0f, 0x00, 0x48, 0x8b, 0xc8, 0xe8, 0x31, 0xeb, 0x6a, 0x5f, 0xcc}
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Ah
  000ch  mov edi,1
  0011h  mov ecx,269Ch
  0016h  mov rdx,7FF95A0710C0h
  0020h  call 7FF9B9BBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,269Ch
  002dh  mov rdx,7FF95A0710C0h
  0037h  call 7FF9B9BBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF95A4DA690h
  0057h  mov rcx,rax
  005ah  call 7FF9B9A8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF95A3DCB50h: Num128<sbyte> sub<sbyte>(byref Num128<sbyte> lhs, byref Num128<sbyte> rhs)
;; {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8a, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x9c, 0x26, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0x6b, 0x31, 0x7e, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x9c, 0x26, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0x54, 0x31, 0x7e, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0xf9, 0xda, 0x0f, 0x00, 0x48, 0x8b, 0xc8, 0xe8, 0xb1, 0xea, 0x6a, 0x5f, 0xcc}
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Ah
  000ch  mov edi,1
  0011h  mov ecx,269Ch
  0016h  mov rdx,7FF95A0710C0h
  0020h  call 7FF9B9BBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,269Ch
  002dh  mov rdx,7FF95A0710C0h
  0037h  call 7FF9B9BBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF95A4DA6A0h
  0057h  mov rcx,rax
  005ah  call 7FF9B9A8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF95A3DCBD0h: Num128<short> sub<short>(byref Num128<short> lhs, byref Num128<short> rhs)
;; {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8a, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x9c, 0x26, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0xeb, 0x30, 0x7e, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x9c, 0x26, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0xd4, 0x30, 0x7e, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0x51, 0xdf, 0x0f, 0x00, 0x48, 0x8b, 0xc8, 0xe8, 0x31, 0xea, 0x6a, 0x5f, 0xcc}
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Ah
  000ch  mov edi,1
  0011h  mov ecx,269Ch
  0016h  mov rdx,7FF95A0710C0h
  0020h  call 7FF9B9BBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,269Ch
  002dh  mov rdx,7FF95A0710C0h
  0037h  call 7FF9B9BBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF95A4DAB78h
  0057h  mov rcx,rax
  005ah  call 7FF9B9A8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF95A3DCC50h: Num128<int> sub<int>(byref Num128<int> lhs, byref Num128<int> rhs)
;; {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8a, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x9c, 0x26, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0x6b, 0x30, 0x7e, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x9c, 0x26, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0x54, 0x30, 0x7e, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0x41, 0xdf, 0x0f, 0x00, 0x48, 0x8b, 0xc8, 0xe8, 0xb1, 0xe9, 0x6a, 0x5f, 0xcc}
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Ah
  000ch  mov edi,1
  0011h  mov ecx,269Ch
  0016h  mov rdx,7FF95A0710C0h
  0020h  call 7FF9B9BBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,269Ch
  002dh  mov rdx,7FF95A0710C0h
  0037h  call 7FF9B9BBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF95A4DABE8h
  0057h  mov rcx,rax
  005ah  call 7FF9B9A8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF95A3DCCD0h: Num128<long> sub<long>(byref Num128<long> lhs, byref Num128<long> rhs)
;; {0x57, 0x56, 0x53, 0x48, 0x83, 0xec, 0x30, 0xbe, 0x8a, 0x00, 0x00, 0x00, 0xbf, 0x01, 0x00, 0x00, 0x00, 0xb9, 0x9c, 0x26, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0xeb, 0x2f, 0x7e, 0x5f, 0x48, 0x8b, 0xd8, 0xb9, 0x9c, 0x26, 0x00, 0x00, 0x48, 0xba, 0xc0, 0x10, 0x07, 0x5a, 0xf9, 0x7f, 0x00, 0x00, 0xe8, 0xd4, 0x2f, 0x7e, 0x5f, 0x48, 0x8b, 0xd0, 0x48, 0x8d, 0x4c, 0x24, 0x28, 0x40, 0x88, 0x39, 0x89, 0x71, 0x04, 0x48, 0x8b, 0xcb, 0x4c, 0x8b, 0x44, 0x24, 0x28, 0xe8, 0x31, 0xdf, 0x0f, 0x00, 0x48, 0x8b, 0xc8, 0xe8, 0x31, 0xe9, 0x6a, 0x5f, 0xcc}
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbx
  0003h  sub rsp,30h
  0007h  mov esi,8Ah
  000ch  mov edi,1
  0011h  mov ecx,269Ch
  0016h  mov rdx,7FF95A0710C0h
  0020h  call 7FF9B9BBFCE0h
  0025h  mov rbx,rax
  0028h  mov ecx,269Ch
  002dh  mov rdx,7FF95A0710C0h
  0037h  call 7FF9B9BBFCE0h
  003ch  mov rdx,rax
  003fh  lea rcx,[rsp+28h]
  0044h  mov [rcx],dil
  0047h  mov [rcx+4],esi
  004ah  mov rcx,rbx
  004dh  mov r8,[rsp+28h]
  0052h  call 7FF95A4DAC58h
  0057h  mov rcx,rax
  005ah  call 7FF9B9A8B660h
  005fh  int 3
end asm ------------------------------------------------------------------------

7FF95A3DCD50h: Num128<float> sub<float>(byref Num128<float> lhs, byref Num128<float> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xfa, 0x5c, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A3DCD80h: Num128<double> sub<double>(byref Num128<double> lhs, byref Num128<double> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xfb, 0x5c, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A3DCDB0h: Vec128<byte> and<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xdb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A3DCDE0h: Vec128<ushort> and<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xdb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A3DCE10h: Vec128<uint> and<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xdb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A3DCE40h: Vec128<ulong> and<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xdb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A3DCE70h: Vec128<sbyte> and<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xdb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A3DCEA0h: Vec128<short> and<short>(byref Vec128<short> lhs, byref Vec128<short> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xdb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A3DCED0h: Vec128<int> and<int>(byref Vec128<int> lhs, byref Vec128<int> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xdb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A3DCF00h: Vec128<long> and<long>(byref Vec128<long> lhs, byref Vec128<long> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0xdb, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A3DCF30h: Vec128<float> and<float>(byref Vec128<float> lhs, byref Vec128<float> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf8, 0x54, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A3DCF60h: Vec128<double> and<double>(byref Vec128<double> lhs, byref Vec128<double> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x02, 0xc4, 0xc1, 0x79, 0x10, 0x08, 0xc5, 0xf9, 0x54, 0xc1, 0xc5, 0xf9, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc3}
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

7FF95A3DCF90h: Vec256<byte> and<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xdb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DCFC0h: Vec256<ushort> and<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xdb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DCFF0h: Vec256<uint> and<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xdb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DD020h: Vec256<ulong> and<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xdb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DD050h: Vec256<sbyte> and<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xdb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DD080h: Vec256<short> and<short>(byref Vec256<short> lhs, byref Vec256<short> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xdb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DD0B0h: Vec256<int> and<int>(byref Vec256<int> lhs, byref Vec256<int> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xdb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DD4F0h: Vec256<long> and<long>(byref Vec256<long> lhs, byref Vec256<long> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0xdb, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DD520h: Vec256<float> and<float>(byref Vec256<float> lhs, byref Vec256<float> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfc, 0x54, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DD550h: Vec256<double> and<double>(byref Vec256<double> lhs, byref Vec256<double> rhs)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x02, 0xc4, 0xc1, 0x7d, 0x10, 0x08, 0xc5, 0xfd, 0x54, 0xc1, 0xc5, 0xfd, 0x11, 0x01, 0x48, 0x8b, 0xc1, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DD580h: void and<byte>(byref Vec128<byte> lhs, byref Vec128<byte> rhs, byref Byte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xdb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A3DD5B0h: void and<ushort>(byref Vec128<ushort> lhs, byref Vec128<ushort> rhs, byref UInt16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xdb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A3DD5E0h: void and<uint>(byref Vec128<uint> lhs, byref Vec128<uint> rhs, byref UInt32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xdb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A3DD610h: void and<ulong>(byref Vec128<ulong> lhs, byref Vec128<ulong> rhs, byref UInt64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xdb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A3DD640h: void and<sbyte>(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs, byref SByte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xdb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A3DD670h: void and<short>(byref Vec128<short> lhs, byref Vec128<short> rhs, byref Int16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xdb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A3DD6A0h: void and<int>(byref Vec128<int> lhs, byref Vec128<int> rhs, byref Int32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xdb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A3DD6D0h: void and<long>(byref Vec128<long> lhs, byref Vec128<long> rhs, byref Int64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0xdb, 0xc1, 0xc4, 0xc1, 0x7a, 0x7f, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vpand xmm0,xmm0,xmm1
  0011h  vmovdqu xmmword ptr [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A3DD700h: void and<float>(byref Vec128<float> lhs, byref Vec128<float> rhs, byref Single dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf8, 0x54, 0xc1, 0xc4, 0xc1, 0x78, 0x11, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vandps xmm0,xmm0,xmm1
  0011h  vmovups [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A3DD730h: void and<double>(byref Vec128<double> lhs, byref Vec128<double> rhs, byref Double dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xf9, 0x10, 0x01, 0xc5, 0xf9, 0x10, 0x0a, 0xc5, 0xf9, 0x54, 0xc1, 0xc4, 0xc1, 0x79, 0x11, 0x00, 0xc3}
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rcx]
  0009h  vmovupd xmm1,[rdx]
  000dh  vandpd xmm0,xmm0,xmm1
  0011h  vmovupd [r8],xmm0
  0016h  ret
end asm ------------------------------------------------------------------------

7FF95A3DD760h: void and<byte>(byref Vec256<byte> lhs, byref Vec256<byte> rhs, byref Byte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xdb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DD790h: void and<ushort>(byref Vec256<ushort> lhs, byref Vec256<ushort> rhs, byref UInt16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xdb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DD7C0h: void and<uint>(byref Vec256<uint> lhs, byref Vec256<uint> rhs, byref UInt32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xdb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DD7F0h: void and<ulong>(byref Vec256<ulong> lhs, byref Vec256<ulong> rhs, byref UInt64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xdb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DD820h: void and<sbyte>(byref Vec256<sbyte> lhs, byref Vec256<sbyte> rhs, byref SByte dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xdb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DD850h: void and<short>(byref Vec256<short> lhs, byref Vec256<short> rhs, byref Int16 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xdb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DD880h: void and<int>(byref Vec256<int> lhs, byref Vec256<int> rhs, byref Int32 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xdb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DD8B0h: void and<long>(byref Vec256<long> lhs, byref Vec256<long> rhs, byref Int64 dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0xdb, 0xc1, 0xc4, 0xc1, 0x7e, 0x7f, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DD8E0h: void and<float>(byref Vec256<float> lhs, byref Vec256<float> rhs, byref Single dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfc, 0x54, 0xc1, 0xc4, 0xc1, 0x7c, 0x11, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

7FF95A3DD910h: void and<double>(byref Vec256<double> lhs, byref Vec256<double> rhs, byref Double dst)
;; {0xc5, 0xf8, 0x77, 0x66, 0x90, 0xc5, 0xfd, 0x10, 0x01, 0xc5, 0xfd, 0x10, 0x0a, 0xc5, 0xfd, 0x54, 0xc1, 0xc4, 0xc1, 0x7d, 0x11, 0x00, 0xc5, 0xf8, 0x77, 0xc3}
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

