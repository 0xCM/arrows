# 2019-07-14 13:27:23:719
7FF96907A3C0h: ReadOnlySpan<byte> get_U8Data()
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,2133CD9AEC0h
  000fh  mov [rcx],rax
  0012h  mov dword ptr [rcx+8],40h
  0019h  mov rax,rcx
  001ch  ret
end asm ------------------------------------------------------------------------

7FF96907A800h: ReadOnlySpan<uint> get_U32Data()
asm ----------------------------------------------------------------------------
  0000h  push rsi
  0001h  sub rsp,20h
  0005h  vzeroupper
  0008h  mov rsi,rcx
  000bh  mov rcx,7FF968E42F20h
  0015h  mov edx,10h
  001ah  call 7FF9C86491A0h
  001fh  mov rdx,2133CD9AE80h
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

7FF96907A890h: sbyte AddI8(sbyte x, sbyte y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rdx,dl
  000dh  add eax,edx
  000fh  movsx rax,al
  0013h  ret
end asm ------------------------------------------------------------------------

7FF96907A8C0h: sbyte AddI8Inline(sbyte x, sbyte y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movsx rax,cl
  0009h  movsx rdx,dl
  000dh  add eax,edx
  000fh  movsx rax,al
  0013h  ret
end asm ------------------------------------------------------------------------

7FF96907A8F0h: int AddI32Inline(int x, int y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea eax,[rcx+rdx]
  0008h  ret
end asm ------------------------------------------------------------------------

7FF96907A910h: ulong AddU64Inline(ulong x, ulong y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea rax,[rcx+rdx]
  0009h  ret
end asm ------------------------------------------------------------------------

7FF96907A930h: int SubI32Inline(int x, int y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  sub eax,edx
  0009h  ret
end asm ------------------------------------------------------------------------

7FF96907A950h: int MulI32Inline(int x, int y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  imul eax,edx
  000ah  ret
end asm ------------------------------------------------------------------------

7FF96907A970h: byte AndU8Inline(byte x, byte y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cl
  0008h  movzx edx,dl
  000bh  and eax,edx
  000dh  movzx eax,al
  0010h  ret
end asm ------------------------------------------------------------------------

7FF96907A9A0h: ushort AndU16(ushort x, ushort y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  movzx eax,cx
  0008h  movzx edx,dx
  000bh  and eax,edx
  000dh  movzx eax,ax
  0010h  ret
end asm ------------------------------------------------------------------------

7FF96907A9D0h: ulong AndU64(ulong x, ulong y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,rcx
  0008h  and rax,rdx
  000bh  ret
end asm ------------------------------------------------------------------------

7FF96907A9F0h: int AddI32LoopInline()
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

7FF96907AA20h: int AddI32Loop()
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

7FF96907AA50h: int AddI32LoopInlineCall()
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

7FF96907AA80h: int AddI32LoopCall()
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,7FF96907AA20h
  000fh  jmp rax
end asm ------------------------------------------------------------------------

7FF96907AAB0h: uint Or8Inline(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
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

7FF96907AAE0h: uint RotLU32Inline(uint x, int offset)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,ecx
  0007h  mov ecx,edx
  0009h  rol eax,cl
  000bh  ret
end asm ------------------------------------------------------------------------

7FF96907AB00h: int ChoiceSwitchInline(int x)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  dec edx
  0007h  cmp edx,4
  000ah  ja short 0044h
  000ch  mov eax,edx
  000eh  lea rdx,[7FF96907AB48h]
  0015h  mov edx,[rdx+rax*4]
  0018h  lea rcx,[7FF96907AB05h]
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

7FF96907AB70h: int ChoiceIfElse5Inline(int x)
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

7FF96907ABD0h: int ChoiceIfElse10Inline(int x)
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

7FF96907AC60h: int CallChoiceSwitchInline(int x)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov rax,7FF96907AB00h
  000fh  jmp rax
end asm ------------------------------------------------------------------------

7FF96907AC90h: int CallChoiceIfElse5Inline(int x)
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

7FF96907ACF0h: int CallChoiceIfElse10Inline(int x)
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

7FF96907AD80h: int InvokeBinOp(Func<int,int,int> f, int x, int y)
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

7FF96907ADC0h: int AddMulInline(int x, int y)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  lea eax,[rcx+rdx]
  0008h  imul ecx,eax
  000bh  imul eax,edx
  000eh  add eax,ecx
  0010h  ret
end asm ------------------------------------------------------------------------

7FF96907ADF0h: int CallInvokeBinOp(int x, int y)
asm ----------------------------------------------------------------------------
  0000h  push rdi
  0001h  push rsi
  0002h  push rbp
  0003h  push rbx
  0004h  sub rsp,28h
  0008h  mov rsi,rcx
  000bh  mov edi,edx
  000dh  mov ebx,r8d
  0010h  mov rcx,7FF96901C9B0h
  001ah  call 7FF9C8649070h
  001fh  mov rbp,rax
  0022h  lea rcx,[rbp+8]
  0026h  mov rdx,rbp
  0029h  call 7FF9C8647D60h
  002eh  mov rcx,7FF9689BDBF0h
  0038h  mov [rbp+18h],rcx
  003ch  mov rcx,7FF96907ADC0h
  0046h  mov [rbp+20h],rcx
  004ah  mov rcx,rsi
  004dh  mov rdx,rbp
  0050h  mov r8d,edi
  0053h  mov r9d,ebx
  0056h  mov rax,7FF96907AD80h
  0060h  add rsp,28h
  0064h  pop rbx
  0065h  pop rbp
  0066h  pop rsi
  0067h  pop rdi
  0068h  jmp rax
end asm ------------------------------------------------------------------------

7FF96907AE80h: int JumpTarget1()
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,1
  000ah  ret
end asm ------------------------------------------------------------------------

7FF96907AEA0h: int JumpTarget2()
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,2
  000ah  ret
end asm ------------------------------------------------------------------------

7FF96907AEC0h: int JumpTarget3()
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,3
  000ah  ret
end asm ------------------------------------------------------------------------

7FF96907AEE0h: int JumpTarget4()
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,4
  000ah  ret
end asm ------------------------------------------------------------------------

7FF96907AF00h: int Jump(int target)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  cmp edx,1
  0008h  je short 003bh
  000ah  cmp edx,2
  000dh  je short 002eh
  000fh  cmp edx,3
  0012h  je short 0021h
  0014h  mov rax,7FF96907AEE0h
  001eh  jmp rax
  0021h  mov rax,7FF96907AEC0h
  002bh  jmp rax
  002eh  mov rax,7FF96907AEA0h
  0038h  jmp rax
  003bh  mov rax,7FF96907AE80h
  0045h  jmp rax
end asm ------------------------------------------------------------------------

7FF96907AF60h: uint CallRotLU32Inline(uint x, int offset)
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov ecx,r8d
  0008h  mov eax,edx
  000ah  rol eax,cl
  000ch  ret
end asm ------------------------------------------------------------------------

7FF96907AF80h: uint CallOr8InlineConst()
asm ----------------------------------------------------------------------------
  0000h  nop dword ptr [rax+rax]
  0005h  mov eax,7Eh
  000ah  ret
end asm ------------------------------------------------------------------------

7FF96907AFA0h: uint CallOr8InlineVar(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
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

7FF96907AFE0h: ReadOnlySpan<byte> ReadU8Data(int count)
asm ----------------------------------------------------------------------------
  0000h  sub rsp,28h
  0004h  nop
  0005h  mov eax,r8d
  0008h  cmp rax,40h
  000ch  ja short 0027h
  000eh  mov rax,2133CD9AEC0h
  0018h  mov [rdx],rax
  001bh  mov [rdx+8],r8d
  001fh  mov rax,rdx
  0022h  add rsp,28h
  0026h  ret
  0027h  call 7FF968AEC860h
  002ch  int 3
end asm ------------------------------------------------------------------------

7FF96907B030h: ReadOnlySpan<uint> ReadU32Data(int count)
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
  001dh  call 7FF96907A800h
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
  0042h  call 7FF968AEC860h
  0047h  int 3
end asm ------------------------------------------------------------------------

