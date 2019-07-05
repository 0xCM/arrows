# 2019-07-01 01:15:28:328
Vec128<sbyte> add1(byref Vec128<sbyte> lhs, byref Vec128<sbyte> rhs)
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

Vec128<sbyte> add2(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
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

Vector128<sbyte> add3(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
asm ----------------------------------------------------------------------------
  0000h  vzeroupper
  0003h  xchg ax,ax
  0005h  vmovupd xmm0,[rdx]
  0009h  vpaddb xmm0,xmm0,[r8]
  000eh  vmovupd [rcx],xmm0
  0012h  mov rax,rcx
  0015h  ret
end asm ------------------------------------------------------------------------

Vector256<sbyte> add4(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
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

Vec256<sbyte> add5(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
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

