# 2019-07-20 02:42:57:529
7FF9673DA7E0h: ReadOnlySpan<byte> get_U8Data()
;; 0f 1f 44 00 00 48 b8 5c b1 e4 1d ea 01 00 00 48 89 01 c7 41 08 40 00 00 00 48 8b c1 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,1EA1DE4B15Ch
  000fh  mov [rcx],rax
  0012h  mov dword ptr [rcx+8],40h
  0019h  mov rax,rcx
  001ch  ret
end asm ------------------------------------------------------------------------

7FF9673DA810h: ReadOnlySpan<uint> get_U32Data()
;; 56 48 83 ec 20 c5 f8 77 48 8b f1 48 b9 20 2f 1a 67 f9 7f 00 00 ba 10 00 00 00 e8 71 e9 5e 5f 48 ba 1c b1 e4 1d ea 01 00 00 48 8d 48 10 c5 fa 6f 02 c5 fa 7f 01 c5 fa 6f 42 10 c5 fa 7f 41 10 c5 fa 6f 42 20 c5 fa 7f 41 20 c5 fa 6f 42 30 c5 fa 7f 41 30 48 83 c0 10 ba 10 00 00 00 48 89 06 89 56 08 48 8b c6 48 83 c4 20 5e c3 
asm ----------------------------------------------------------------------------
  0000h  push rsi
  0001h  sub rsp,20h
  0005h  vzeroupper
  0008h  mov rsi,rcx
  000bh  mov rcx,7FF9671A2F20h
  0015h  mov edx,10h
  001ah  call 7FF9C69C91A0h
  001fh  mov rdx,1EA1DE4B11Ch
  0029h  lea rcx,[rax+10h]
  002dh  vmovdqu xmm0,xmmword ptr [rdx]
  0031h  vmovdqu xmmword ptr [rcx],xmm0
  0035h  vmovdqu xmm0,xmmword ptr [rdx+10h]
  003ah  vmovdqu xmmword ptr [rcx+10h],xmm0
  003fh  vmovdqu xmm0,xmmword ptr [rdx+20h]
  0044h  vmovdqu xmmword ptr [rcx+20h],xmm0
  0049h  vmovdqu xmm0,xmmword ptr [rdx+30h]
  004eh  vmovdqu xmmword ptr [rcx+30h],xmm0
  0053h  add rax,10h
  0057h  mov edx,10h
  005ch  mov [rsi],rax
  005fh  mov [rsi+8],edx
  0062h  mov rax,rsi
  0065h  add rsp,20h
  0069h  pop rsi
  006ah  ret
end asm ------------------------------------------------------------------------

7FF9673DA8A0h: sbyte AddI8(sbyte x, sbyte y)
;; 0f 1f 44 00 00 48 0f be c1 48 0f be d2 03 c2 48 0f be c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rdx,dl
  000dh  add eax,edx
  000fh  movsx rax,al
  0013h  ret
end asm ------------------------------------------------------------------------

7FF9673DA8D0h: sbyte AddI8Inline(sbyte x, sbyte y)
;; 0f 1f 44 00 00 48 0f be c1 48 0f be d2 03 c2 48 0f be c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rdx,dl
  000dh  add eax,edx
  000fh  movsx rax,al
  0013h  ret
end asm ------------------------------------------------------------------------

7FF9673DA900h: int AddI32Inline(int x, int y)
;; 0f 1f 44 00 00 8d 04 11 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea eax,[rcx+rdx]
  0008h  ret
end asm ------------------------------------------------------------------------

7FF9673DA920h: ulong AddU64Inline(ulong x, ulong y)
;; 0f 1f 44 00 00 48 8d 04 11 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea rax,[rcx+rdx]
  0009h  ret
end asm ------------------------------------------------------------------------

7FF9673DA940h: int SubI32Inline(int x, int y)
;; 0f 1f 44 00 00 8b c1 2b c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  sub eax,edx
  0009h  ret
end asm ------------------------------------------------------------------------

7FF9673DA960h: int MulI32Inline(int x, int y)
;; 0f 1f 44 00 00 8b c1 0f af c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  imul eax,edx
  000ah  ret
end asm ------------------------------------------------------------------------

7FF9673DA980h: byte AndU8Inline(byte x, byte y)
;; 0f 1f 44 00 00 0f b6 c1 0f b6 d2 23 c2 0f b6 c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx edx,dl
  000bh  and eax,edx
  000dh  movzx eax,al
  0010h  ret
end asm ------------------------------------------------------------------------

7FF9673DA9B0h: ushort AndU16(ushort x, ushort y)
;; 0f 1f 44 00 00 0f b7 c1 0f b7 d2 23 c2 0f b7 c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx edx,dx
  000bh  and eax,edx
  000dh  movzx eax,ax
  0010h  ret
end asm ------------------------------------------------------------------------

7FF9673DA9E0h: ulong AndU64(ulong x, ulong y)
;; 0f 1f 44 00 00 48 8b c1 48 23 c2 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  and rax,rdx
  000bh  ret
end asm ------------------------------------------------------------------------

7FF9673DAA00h: int AddI32LoopInline()
;; 0f 1f 44 00 00 33 c0 33 d2 03 c2 ff c2 83 fa 64 7c f7 c3 
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

7FF9673DAA30h: int AddI32Loop()
;; 0f 1f 44 00 00 33 c0 33 d2 03 c2 ff c2 83 fa 64 7c f7 c3 
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

7FF9673DAA60h: int AddI32LoopInlineCall()
;; 0f 1f 44 00 00 33 c0 33 d2 03 c2 ff c2 83 fa 64 7c f7 c3 
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

7FF9673DAA90h: int AddI32LoopCall()
;; 0f 1f 44 00 00 48 b8 30 aa 3d 67 f9 7f 00 00 48 ff e0 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,7FF9673DAA30h
  000fh  jmp rax
end asm ------------------------------------------------------------------------

7FF9673DAAC0h: uint Or8Inline(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
;; 0f 1f 44 00 00 0b d1 41 0b d0 41 0b d1 0b 54 24 28 0b 54 24 30 8b c2 0b 44 24 38 0b 44 24 40 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  or edx,ecx
  0007h  or edx,r8d
  000ah  or edx,r9d
  000dh  or edx,[rsp+28h]
  0011h  or edx,[rsp+30h]
  0015h  mov eax,edx
  0017h  or eax,[rsp+38h]
  001bh  or eax,[rsp+40h]
  001fh  ret
end asm ------------------------------------------------------------------------

7FF9673DAAF0h: uint RotLU32Inline(uint x, int offset)
;; 0f 1f 44 00 00 8b c1 8b ca d3 c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  mov ecx,edx
  0009h  rol eax,cl
  000bh  ret
end asm ------------------------------------------------------------------------

7FF9673DAB10h: int ChoiceSwitchInline(int x)
;; 0f 1f 44 00 00 ff ca 83 fa 04 77 38 8b c2 48 8d 15 33 00 00 00 8b 14 82 48 8d 0d e6 ff ff ff 48 03 d1 ff e2 b8 01 00 00 00 c3 b8 04 00 00 00 c3 b8 08 00 00 00 c3 b8 10 00 00 00 eb 09 b8 20 00 00 00 eb 02 33 c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  dec edx
  0007h  cmp edx,4
  000ah  ja short 0044h
  000ch  mov eax,edx
  000eh  lea rdx,[7FF9673DAB58h]
  0015h  mov edx,[rdx+rax*4]
  0018h  lea rcx,[7FF9673DAB15h]
  001fh  add rdx,rcx
  0022h  jmp rdx
  0024h  mov eax,1
  0029h  ret
  002ah  mov eax,4
  002fh  ret
  0030h  mov eax,8
  0035h  ret
  0036h  mov eax,10h
  003bh  jmp short 0046h
  003dh  mov eax,20h
  0042h  jmp short 0046h
  0044h  xor eax,eax
  0046h  ret
end asm ------------------------------------------------------------------------

7FF9673DAB80h: int ChoiceIfElse5Inline(int x)
;; 0f 1f 44 00 00 83 fa 01 75 06 b8 01 00 00 00 c3 83 fa 02 75 06 b8 04 00 00 00 c3 83 fa 03 75 06 b8 08 00 00 00 c3 83 fa 04 75 07 b8 10 00 00 00 eb 0e 83 fa 05 75 07 b8 20 00 00 00 eb 02 33 c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  cmp edx,1
  0008h  jne short 0010h
  000ah  mov eax,1
  000fh  ret
  0010h  cmp edx,2
  0013h  jne short 001bh
  0015h  mov eax,4
  001ah  ret
  001bh  cmp edx,3
  001eh  jne short 0026h
  0020h  mov eax,8
  0025h  ret
  0026h  cmp edx,4
  0029h  jne short 0032h
  002bh  mov eax,10h
  0030h  jmp short 0040h
  0032h  cmp edx,5
  0035h  jne short 003eh
  0037h  mov eax,20h
  003ch  jmp short 0040h
  003eh  xor eax,eax
  0040h  ret
end asm ------------------------------------------------------------------------

7FF9673DABE0h: int ChoiceIfElse10Inline(int x)
;; 0f 1f 44 00 00 83 fa 01 75 06 b8 01 00 00 00 c3 83 fa 02 75 06 b8 04 00 00 00 c3 83 fa 03 75 06 b8 08 00 00 00 c3 83 fa 04 75 07 b8 10 00 00 00 eb 4a 83 fa 05 75 07 b8 20 00 00 00 eb 3e 83 fa 06 75 07 b8 40 00 00 00 eb 32 83 fa 07 75 07 b8 80 00 00 00 eb 26 83 fa 08 75 07 b8 00 01 00 00 eb 1a 83 fa 09 75 07 b8 00 02 00 00 eb 0e 83 fa 0a 75 07 b8 00 04 00 00 eb 02 33 c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  cmp edx,1
  0008h  jne short 0010h
  000ah  mov eax,1
  000fh  ret
  0010h  cmp edx,2
  0013h  jne short 001bh
  0015h  mov eax,4
  001ah  ret
  001bh  cmp edx,3
  001eh  jne short 0026h
  0020h  mov eax,8
  0025h  ret
  0026h  cmp edx,4
  0029h  jne short 0032h
  002bh  mov eax,10h
  0030h  jmp short 007ch
  0032h  cmp edx,5
  0035h  jne short 003eh
  0037h  mov eax,20h
  003ch  jmp short 007ch
  003eh  cmp edx,6
  0041h  jne short 004ah
  0043h  mov eax,40h
  0048h  jmp short 007ch
  004ah  cmp edx,7
  004dh  jne short 0056h
  004fh  mov eax,80h
  0054h  jmp short 007ch
  0056h  cmp edx,8
  0059h  jne short 0062h
  005bh  mov eax,100h
  0060h  jmp short 007ch
  0062h  cmp edx,9
  0065h  jne short 006eh
  0067h  mov eax,200h
  006ch  jmp short 007ch
  006eh  cmp edx,0Ah
  0071h  jne short 007ah
  0073h  mov eax,400h
  0078h  jmp short 007ch
  007ah  xor eax,eax
  007ch  ret
end asm ------------------------------------------------------------------------

7FF9673DAC70h: int CallChoiceSwitchInline(int x)
;; 0f 1f 44 00 00 48 b8 10 ab 3d 67 f9 7f 00 00 48 ff e0 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,7FF9673DAB10h
  000fh  jmp rax
end asm ------------------------------------------------------------------------

7FF9673DACA0h: int CallChoiceIfElse5Inline(int x)
;; 0f 1f 44 00 00 83 fa 01 75 07 b8 01 00 00 00 eb 32 83 fa 02 75 07 b8 04 00 00 00 eb 26 83 fa 03 75 07 b8 08 00 00 00 eb 1a 83 fa 04 75 07 b8 10 00 00 00 eb 0e 83 fa 05 75 07 b8 20 00 00 00 eb 02 33 c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  cmp edx,1
  0008h  jne short 0011h
  000ah  mov eax,1
  000fh  jmp short 0043h
  0011h  cmp edx,2
  0014h  jne short 001dh
  0016h  mov eax,4
  001bh  jmp short 0043h
  001dh  cmp edx,3
  0020h  jne short 0029h
  0022h  mov eax,8
  0027h  jmp short 0043h
  0029h  cmp edx,4
  002ch  jne short 0035h
  002eh  mov eax,10h
  0033h  jmp short 0043h
  0035h  cmp edx,5
  0038h  jne short 0041h
  003ah  mov eax,20h
  003fh  jmp short 0043h
  0041h  xor eax,eax
  0043h  ret
end asm ------------------------------------------------------------------------

7FF9673DAD00h: int CallChoiceIfElse10Inline(int x)
;; 0f 1f 44 00 00 83 fa 01 75 07 b8 01 00 00 00 eb 6e 83 fa 02 75 07 b8 04 00 00 00 eb 62 83 fa 03 75 07 b8 08 00 00 00 eb 56 83 fa 04 75 07 b8 10 00 00 00 eb 4a 83 fa 05 75 07 b8 20 00 00 00 eb 3e 83 fa 06 75 07 b8 40 00 00 00 eb 32 83 fa 07 75 07 b8 80 00 00 00 eb 26 83 fa 08 75 07 b8 00 01 00 00 eb 1a 83 fa 09 75 07 b8 00 02 00 00 eb 0e 83 fa 0a 75 07 b8 00 04 00 00 eb 02 33 c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  cmp edx,1
  0008h  jne short 0011h
  000ah  mov eax,1
  000fh  jmp short 007fh
  0011h  cmp edx,2
  0014h  jne short 001dh
  0016h  mov eax,4
  001bh  jmp short 007fh
  001dh  cmp edx,3
  0020h  jne short 0029h
  0022h  mov eax,8
  0027h  jmp short 007fh
  0029h  cmp edx,4
  002ch  jne short 0035h
  002eh  mov eax,10h
  0033h  jmp short 007fh
  0035h  cmp edx,5
  0038h  jne short 0041h
  003ah  mov eax,20h
  003fh  jmp short 007fh
  0041h  cmp edx,6
  0044h  jne short 004dh
  0046h  mov eax,40h
  004bh  jmp short 007fh
  004dh  cmp edx,7
  0050h  jne short 0059h
  0052h  mov eax,80h
  0057h  jmp short 007fh
  0059h  cmp edx,8
  005ch  jne short 0065h
  005eh  mov eax,100h
  0063h  jmp short 007fh
  0065h  cmp edx,9
  0068h  jne short 0071h
  006ah  mov eax,200h
  006fh  jmp short 007fh
  0071h  cmp edx,0Ah
  0074h  jne short 007dh
  0076h  mov eax,400h
  007bh  jmp short 007fh
  007dh  xor eax,eax
  007fh  ret
end asm ------------------------------------------------------------------------

7FF9673DAD90h: int InvokeBinOp(Func<int,int,int> f, int x, int y)
;; 50 0f 1f 40 00 48 89 14 24 48 8b 4a 08 41 8b d0 45 8b c1 48 8b 04 24 48 8b 40 18 48 83 c4 08 48 ff e0 
asm ----------------------------------------------------------------------------
  0000h  push rax
  0001h  nop dword ptr [rax]
  0005h  mov [rsp],rdx
  0009h  mov rcx,[rdx+8]
  000dh  mov edx,r8d
  0010h  mov r8d,r9d
  0013h  mov rax,[rsp]
  0017h  mov rax,[rax+18h]
  001bh  add rsp,8
  001fh  jmp rax
end asm ------------------------------------------------------------------------

7FF9673DADD0h: int AddMulInline(int x, int y)
;; 0f 1f 44 00 00 8d 04 11 0f af c8 0f af c2 03 c1 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea eax,[rcx+rdx]
  0008h  imul ecx,eax
  000bh  imul eax,edx
  000eh  add eax,ecx
  0010h  ret
end asm ------------------------------------------------------------------------

7FF9673DAE00h: int CallInvokeBinOp(int x, int y)
;; 57 56 55 53 48 83 ec 28 48 8b f1 8b fa 41 8b d8 48 b9 b0 d2 37 67 f9 7f 00 00 e8 51 e2 5e 5f 48 8b e8 48 8d 4d 08 48 8b d5 e8 32 cf 5e 5f 48 b9 f0 db d1 66 f9 7f 00 00 48 89 4d 18 48 b9 d0 ad 3d 67 f9 7f 00 00 48 89 4d 20 48 8b ce 48 8b d5 44 8b c7 44 8b cb 48 b8 90 ad 3d 67 f9 7f 00 00 48 83 c4 28 5b 5d 5e 5f 48 ff e0 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbp
  0003h  push rbx
  0004h  sub rsp,28h
  0008h  mov rsi,rcx
  000bh  mov edi,edx
  000dh  mov ebx,r8d
  0010h  mov rcx,7FF96737D2B0h
  001ah  call 7FF9C69C9070h
  001fh  mov rbp,rax
  0022h  lea rcx,[rbp+8]
  0026h  mov rdx,rbp
  0029h  call 7FF9C69C7D60h
  002eh  mov rcx,7FF966D1DBF0h
  0038h  mov [rbp+18h],rcx
  003ch  mov rcx,7FF9673DADD0h
  0046h  mov [rbp+20h],rcx
  004ah  mov rcx,rsi
  004dh  mov rdx,rbp
  0050h  mov r8d,edi
  0053h  mov r9d,ebx
  0056h  mov rax,7FF9673DAD90h
  0060h  add rsp,28h
  0064h  pop rbx
  0065h  pop rbp
  0066h  pop rsi
  0067h  pop rdi
  0068h  jmp rax
end asm ------------------------------------------------------------------------

7FF9673DAE90h: int JumpTarget1()
;; 0f 1f 44 00 00 b8 01 00 00 00 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,1
  000ah  ret
end asm ------------------------------------------------------------------------

7FF9673DAEB0h: int JumpTarget2()
;; 0f 1f 44 00 00 b8 02 00 00 00 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,2
  000ah  ret
end asm ------------------------------------------------------------------------

7FF9673DAED0h: int JumpTarget3()
;; 0f 1f 44 00 00 b8 03 00 00 00 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,3
  000ah  ret
end asm ------------------------------------------------------------------------

7FF9673DAEF0h: int JumpTarget4()
;; 0f 1f 44 00 00 b8 04 00 00 00 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,4
  000ah  ret
end asm ------------------------------------------------------------------------

7FF9673DAF10h: int Jump(int target)
;; 0f 1f 44 00 00 83 fa 01 74 31 83 fa 02 74 1f 83 fa 03 74 0d 48 b8 f0 ae 3d 67 f9 7f 00 00 48 ff e0 48 b8 d0 ae 3d 67 f9 7f 00 00 48 ff e0 48 b8 b0 ae 3d 67 f9 7f 00 00 48 ff e0 48 b8 90 ae 3d 67 f9 7f 00 00 48 ff e0 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  cmp edx,1
  0008h  je short 003bh
  000ah  cmp edx,2
  000dh  je short 002eh
  000fh  cmp edx,3
  0012h  je short 0021h
  0014h  mov rax,7FF9673DAEF0h
  001eh  jmp rax
  0021h  mov rax,7FF9673DAED0h
  002bh  jmp rax
  002eh  mov rax,7FF9673DAEB0h
  0038h  jmp rax
  003bh  mov rax,7FF9673DAE90h
  0045h  jmp rax
end asm ------------------------------------------------------------------------

7FF9673DAF70h: uint CallRotLU32Inline(uint x, int offset)
;; 0f 1f 44 00 00 41 8b c8 8b c2 d3 c0 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov ecx,r8d
  0008h  mov eax,edx
  000ah  rol eax,cl
  000ch  ret
end asm ------------------------------------------------------------------------

7FF9673DAF90h: uint CallOr8InlineConst()
;; 0f 1f 44 00 00 b8 7e 00 00 00 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,7Eh
  000ah  ret
end asm ------------------------------------------------------------------------

7FF9673DAFB0h: uint CallOr8InlineVar(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
;; 0f 1f 44 00 00 41 0b d0 41 0b d1 0b 54 24 28 0b 54 24 30 0b 54 24 38 8b c2 0b 44 24 40 0b 44 24 48 c3 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  or edx,r8d
  0008h  or edx,r9d
  000bh  or edx,[rsp+28h]
  000fh  or edx,[rsp+30h]
  0013h  or edx,[rsp+38h]
  0017h  mov eax,edx
  0019h  or eax,[rsp+40h]
  001dh  or eax,[rsp+48h]
  0021h  ret
end asm ------------------------------------------------------------------------

7FF9673DAFF0h: ReadOnlySpan<byte> ReadU8Data(int count)
;; 48 83 ec 28 90 41 8b c0 48 83 f8 40 77 19 48 b8 5c b1 e4 1d ea 01 00 00 48 89 02 44 89 42 08 48 8b c2 48 83 c4 28 c3 e8 44 18 a7 ff cc 
asm ----------------------------------------------------------------------------
  0000h  sub rsp,28h
  0004h  nop
  0005h  mov eax,r8d
  0008h  cmp rax,40h
  000ch  ja short 0027h
  000eh  mov rax,1EA1DE4B15Ch
  0018h  mov [rdx],rax
  001bh  mov [rdx+8],r8d
  001fh  mov rax,rdx
  0022h  add rsp,28h
  0026h  ret
  0027h  call 7FF966E4C860h
  002ch  int 3
end asm ------------------------------------------------------------------------

7FF9673DB040h: ReadOnlySpan<uint> ReadU32Data(int count)
;; 57 56 48 83 ec 38 33 c0 48 89 44 24 28 48 89 44 24 30 48 8b f2 41 8b f8 48 8d 4c 24 28 e8 ae f7 ff ff 8b c7 8b 54 24 30 48 3b c2 77 15 48 8b 44 24 28 48 89 06 89 7e 08 48 8b c6 48 83 c4 38 5e 5f c3 e8 d9 17 a7 ff cc 
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  sub rsp,38h
  0006h  xor eax,eax
  0008h  mov [rsp+28h],rax
  000dh  mov [rsp+30h],rax
  0012h  mov rsi,rdx
  0015h  mov edi,r8d
  0018h  lea rcx,[rsp+28h]
  001dh  call 7FF9673DA810h
  0022h  mov eax,edi
  0024h  mov edx,[rsp+30h]
  0028h  cmp rax,rdx
  002bh  ja short 0042h
  002dh  mov rax,[rsp+28h]
  0032h  mov [rsi],rax
  0035h  mov [rsi+8],edi
  0038h  mov rax,rsi
  003bh  add rsp,38h
  003fh  pop rsi
  0040h  pop rdi
  0041h  ret
  0042h  call 7FF966E4C860h
  0047h  int 3
end asm ------------------------------------------------------------------------

7FF9673DB410h: void VoidReturn()
;; 0f 1f 44 00 00 48 b9 60 30 fc 2d ea 01 00 00 48 8b 09 48 b8 e8 b3 3d 67 f9 7f 00 00 48 ff e0 
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rcx,1EA2DFC3060h
  000fh  mov rcx,[rcx]
  0012h  mov rax,7FF9673DB3E8h
  001ch  jmp rax
end asm ------------------------------------------------------------------------

