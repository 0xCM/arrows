//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;
    using System.Reflection.Emit;

    using static zfunc;
    using static AsmOps;

    partial class AsmOps
    {
    
        readonly struct AddHost<T>
            where T : struct
        {
            
            public static readonly AddHost<T> TheOnly = default;

            static readonly AsmBinOp<T> Reified = AddCode<T>().CreateBinOp();
            
            public AsmBinOp<T> Operator
                => Reified;
        }
    
        

        [MethodImpl(Inline)]
        public static AsmBinOp<T> Add<T>()
            where T : struct
            => AddHost<T>.TheOnly.Operator;


        static AsmCode<T> AddCode<T>()
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return AsmCode.FromBytes<T>(add8iBytes);
            else if(typeof(T) == typeof(byte))
                return AsmCode.FromBytes<T>(add8uBytes);
            else if(typeof(T) == typeof(short))
                return AsmCode.FromBytes<T>(add16iBytes);
            else if(typeof(T) == typeof(ushort))
                return AsmCode.FromBytes<T>(add16uBytes);
            else if(typeof(T) == typeof(int))
                return AsmCode.FromBytes<T>(add32iBytes);
            else if(typeof(T) == typeof(uint))
                return AsmCode.FromBytes<T>(add32uBytes);
            else if(typeof(T) == typeof(long))
                return AsmCode.FromBytes<T>(add64iBytes);
            else if(typeof(T) == typeof(ulong))
                return AsmCode.FromBytes<T>(add64uBytes);
            else if(typeof(T) == typeof(float))
                return AsmCode.FromBytes<T>(add32fBytes);
            else if(typeof(T) == typeof(double))
                return AsmCode.FromBytes<T>(add64fBytes);
            else 
                throw unsupported<T>();
        }

        static ReadOnlySpan<byte> rand32uBytes => new byte[] { 0x0f, 0xc7, 0xf0, 0x0f, 0x92, 0x01, 0xc3};            

        static ReadOnlySpan<byte> add8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};    

        static ReadOnlySpan<byte> add8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x03,0xC2,0x0F,0xB6,0xC0,0xC3};
  
        static ReadOnlySpan<byte> add16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};        

        static ReadOnlySpan<byte> add16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x03,0xC2,0x0F,0xB7,0xC0,0xC3};        

        static ReadOnlySpan<byte> add32iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};
  
        static ReadOnlySpan<byte> add32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};

        static ReadOnlySpan<byte> add64iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};        
  
        static ReadOnlySpan<byte> add64uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};
        
        static ReadOnlySpan<byte> add32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x58,0xC1,0xC3};
        
        static ReadOnlySpan<byte> add64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x58,0xC1,0xC3};

    }


}

/*
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte add8i(sbyte x, sbyte y)
; location: [7FFC7CBF1B10h, 7FFC7CBF1B23h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add8iBytes = new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte add8i_In(in sbyte x, in sbyte y)
; location: [7FFC7CBF1B40h, 7FFC7CBF1B53h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rcx]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 01
0009h movsx rdx,byte ptr [rdx]      ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RDX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 12
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add8i_InBytes = new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x01,0x48,0x0F,0xBE,0x12,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte add8i_Ref(ref sbyte x, in sbyte y)
; location: [7FFC7CBF1B70h, 7FFC7CBF1B7Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rdx]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RDX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 02
0009h add [rcx],al                  ; ADD(Add_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 00 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add8i_RefBytes = new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x02,0x00,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte add8u(byte x, byte y)
; location: [7FFC7CBF1B90h, 7FFC7CBF1BA0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add8uBytes = new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x03,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte add8u_In(in byte x, in byte y)
; location: [7FFC7CBF1BC0h, 7FFC7CBF1BD0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h movzx edx,byte ptr [rdx]      ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RDX:br,DS:sr)]      encoding(3 bytes) = 0f b6 12
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add8u_InBytes = new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x0F,0xB6,0x12,0x03,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte add8u_Ref(ref byte x, in byte y)
; location: [7FFC7CBF1BF0h, 7FFC7CBF1BFDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rdx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RDX:br,DS:sr)]      encoding(3 bytes) = 0f b6 02
0008h add [rcx],al                  ; ADD(Add_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 00 01
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add8u_RefBytes = new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x02,0x00,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short add16i(short x, short y)
; location: [7FFC7CBF1C10h, 7FFC7CBF1C23h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add16iBytes = new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short add16i_In(in short x, in short y)
; location: [7FFC7CBF1C40h, 7FFC7CBF1C53h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rcx]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RCX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 01
0009h movsx rdx,word ptr [rdx]      ; MOVSX(Movsx_r64_rm16) [RDX,mem(16i,RDX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 12
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add16i_InBytes = new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x01,0x48,0x0F,0xBF,0x12,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short add16i_Ref(ref short x, in short y)
; location: [7FFC7CBF1C70h, 7FFC7CBF1C7Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rdx]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RDX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 02
0009h add [rcx],ax                  ; ADD(Add_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 01 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add16i_RefBytes = new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x02,0x66,0x01,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort add16u(ushort x, ushort y)
; location: [7FFC7CBF1C90h, 7FFC7CBF1CA0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add16uBytes = new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x03,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort add16u_In(in ushort x, in ushort y)
; location: [7FFC7CBF1CC0h, 7FFC7CBF1CD0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h movzx edx,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [EDX,mem(16u,RDX:br,DS:sr)]    encoding(3 bytes) = 0f b7 12
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add16u_InBytes = new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0x0F,0xB7,0x12,0x03,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort add16u_Ref(ref ushort x, in ushort y)
; location: [7FFC7CBF1CF0h, 7FFC7CBF1CFEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RDX:br,DS:sr)]    encoding(3 bytes) = 0f b7 02
0008h add [rcx],ax                  ; ADD(Add_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 01 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add16u_RefBytes = new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x02,0x66,0x01,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int add32i(int x, int y)
; location: [7FFC7CBF1D10h, 7FFC7CBF1D18h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 04 11
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add32iBytes = new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int add32i_In(in int x, in int y)
; location: [7FFC7CBF1D30h, 7FFC7CBF1D39h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h add eax,[rdx]                 ; ADD(Add_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 03 02
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add32i_InBytes = new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x03,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int add32i_Ref(ref int x, in int y)
; location: [7FFC7CBF1D50h, 7FFC7CBF1D5Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rdx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 02
0007h add [rcx],eax                 ; ADD(Add_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 01 01
0009h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add32i_RefBytes = new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x02,0x01,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint add32u(uint x, uint y)
; location: [7FFC7CBF1D70h, 7FFC7CBF1D78h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 04 11
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add32uBytes = new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint add32u_In(in uint x, in uint y)
; location: [7FFC7CBF1D90h, 7FFC7CBF1D99h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h add eax,[rdx]                 ; ADD(Add_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 03 02
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add32u_InBytes = new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x03,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint add32u_Ref(ref uint x, in uint y)
; location: [7FFC7CBF1DB0h, 7FFC7CBF1DBCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rdx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 02
0007h add [rcx],eax                 ; ADD(Add_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 01 01
0009h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add32u_RefBytes = new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x02,0x01,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long add64i(long x, long y)
; location: [7FFC7CBF1DD0h, 7FFC7CBF1DD9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 04 11
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add64iBytes = new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long add64i_In(in long x, in long y)
; location: [7FFC7CBF1DF0h, 7FFC7CBF1DFBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h add rax,[rdx]                 ; ADD(Add_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 03 02
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add64i_InBytes = new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x03,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long add64i_Ref(ref long x, in long y)
; location: [7FFC7CBF1E10h, 7FFC7CBF1E1Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h add [rcx],rax                 ; ADD(Add_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 01 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add64i_RefBytes = new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x01,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong add64u(ulong x, ulong y)
; location: [7FFC7CBF1E30h, 7FFC7CBF1E39h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 04 11
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add64uBytes = new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong add64u_In(in ulong x, in ulong y)
; location: [7FFC7CBF1E50h, 7FFC7CBF1E5Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h add rax,[rdx]                 ; ADD(Add_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 03 02
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add64u_InBytes = new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x03,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong add64u_Ref(ref ulong x, in ulong y)
; location: [7FFC7CBF1E70h, 7FFC7CBF1E7Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h add [rcx],rax                 ; ADD(Add_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 01 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add64u_RefBytes = new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x01,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float add32f(float x, float y)
; location: [7FFC7CBF1E90h, 7FFC7CBF1E99h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vaddss xmm0,xmm0,xmm1         ; VADDSS(VEX_Vaddss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fa 58 c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add32fBytes = new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x58,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double add64f(double x, double y)
; location: [7FFC7CBF1EB0h, 7FFC7CBF1EB9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vaddsd xmm0,xmm0,xmm1         ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 58 c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add64fBytes = new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x58,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double add64f_In(in double x, in double y)
; location: [7FFC7CBF1ED0h, 7FFC7CBF1EDDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 01
0009h vaddsd xmm0,xmm0,qword ptr [rdx]; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,mem(Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 58 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add64f_InBytes = new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x01,0xC5,0xFB,0x58,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double add64f_Ref(ref double x, in double y)
; location: [7FFC7CBF1EF0h, 7FFC7CBF1F04h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 01
0009h vaddsd xmm0,xmm0,qword ptr [rdx]; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,mem(Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 58 02
000dh vmovsd qword ptr [rcx],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add64f_RefBytes = new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x01,0xC5,0xFB,0x58,0x02,0xC5,0xFB,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float add32f_In(in float x, in float y)
; location: [7FFC7CBF1F20h, 7FFC7CBF1F2Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 01
0009h vaddss xmm0,xmm0,dword ptr [rdx]; VADDSS(VEX_Vaddss_xmm_xmm_xmmm32) [XMM0,XMM0,mem(Float32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 58 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add32f_InBytes = new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x01,0xC5,0xFA,0x58,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float add32f_Ref(ref float x, in float y)
; location: [7FFC7CBF1F40h, 7FFC7CBF1F54h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 01
0009h vaddss xmm0,xmm0,dword ptr [rdx]; VADDSS(VEX_Vaddss_xmm_xmm_xmmm32) [XMM0,XMM0,mem(Float32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 58 02
000dh vmovss dword ptr [rcx],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add32f_RefBytes = new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x01,0xC5,0xFA,0x58,0x02,0xC5,0xFA,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------


 */