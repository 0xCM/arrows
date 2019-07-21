# 2019-07-20 02:42:57:249
7FF966E56FB0h: Vec128<sbyte> add1(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
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

7FF966E56FE0h: Vec128<sbyte> add2(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
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

7FF966E57010h: Vector128<sbyte> add3(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
;; c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 fc 00 c5 f9 11 01 48 8b c1 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vpaddb xmm0,xmm0,[r8]
  000eh  vmovupd [rcx],xmm0
  0012h  mov rax,rcx
  0015h  ret
end asm ------------------------------------------------------------------------

7FF966E57040h: Vector256<sbyte> add4(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
;; c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d fc 00 c5 fd 11 01 48 8b c1 c5 f8 77 c3 
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd ymm0,[rdx]
  0009h  vpaddb ymm0,ymm0,[r8]
  000eh  vmovupd [rcx],ymm0
  0012h  mov rax,rcx
  0015h  vzeroupper
  0018h  ret
end asm ------------------------------------------------------------------------

7FF966E57070h: Vec256<sbyte> add5(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
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

