//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;

    using R = Registers;

    using static zfunc;

    using static BitWidth;

    partial class Machine
    {

        //! RAX
        //! -------------------------------------------------------------------
        ref R.AL al
        {
            [MethodImpl(Inline)]
            get => ref RAX.al;
        }

        ref R.AX ax
        {
            [MethodImpl(Inline)]
            get => ref RAX.ax;
        }

        ref R.EAX eax
        {
            [MethodImpl(Inline)]
            get => ref RAX.eax;
        }

        ref R.RAX rax
        {
            [MethodImpl(Inline)]
            get => ref RAX;
        }

        //! RCX
        //! -------------------------------------------------------------------

        ref R.CL cl
        {
            [MethodImpl(Inline)]
            get => ref RCX.cl;
        }

        ref R.CX cx
        {
            [MethodImpl(Inline)]
            get => ref RCX.cx;
        }

        ref R.ECX ecx
        {
            [MethodImpl(Inline)]
            get => ref RCX.ecx;
        }


        ref R.RCX rcx
        {
            [MethodImpl(Inline)]
            get => ref RCX;
        }

        //! RBX
        //! -------------------------------------------------------------------
        
        ref R.BL bl
        {
            [MethodImpl(Inline)]
            get => ref RBX.bl;
        }

        ref R.BX bx
        {
            [MethodImpl(Inline)]
            get => ref RBX.bx;
        }

        ref R.EBX ebx
        {
            [MethodImpl(Inline)]
            get => ref RBX.ebx;
        }

        ref R.RBX rbx
        {
            [MethodImpl(Inline)]
            get => ref RBX;
        }

        //! RDX
        //! -------------------------------------------------------------------

        ref R.DL dl
        {
            [MethodImpl(Inline)]
            get => ref RDX.dl;
        }

        ref R.DX dx
        {
            [MethodImpl(Inline)]
            get => ref RDX.dx;
        }

        ref R.EDX edx
        {
            [MethodImpl(Inline)]
            get => ref RDX.edx;
        }

        ref R.RDX rdx
        {
            [MethodImpl(Inline)]
            get => ref RDX;
        }

        //! RSI
        //! -------------------------------------------------------------------

        ref R.SIL sil
        {
            [MethodImpl(Inline)]
            get => ref RSI.sil;
        }

        ref R.SI si
        {
            [MethodImpl(Inline)]
            get => ref RSI.si;
        }

        ref R.ESI esi
        {
            [MethodImpl(Inline)]
            get => ref RSI.esi;
        }

        ref R.RSI rsi
        {
            [MethodImpl(Inline)]
            get => ref RSI;
        }

        //! RBP
        //! -------------------------------------------------------------------

        ref R.BPL bpl
        {
            [MethodImpl(Inline)]
            get => ref RBP.bpl;
        }

        ref R.BP bp
        {
            [MethodImpl(Inline)]
            get => ref RBP.bp;
        }

        ref R.EBP ebp
        {
            [MethodImpl(Inline)]
            get => ref RBP.ebp;
        }

        ref R.RBP rbp
        {
            [MethodImpl(Inline)]
            get => ref RBP;
        }

        //! RDI
        //! -------------------------------------------------------------------

        ref R.DIL dil
        {
            [MethodImpl(Inline)]
            get => ref RDI.dil;
        }

        ref R.DI di
        {
            [MethodImpl(Inline)]
            get => ref RDI.di;
        }

        ref R.EDI edi
        {
            [MethodImpl(Inline)]
            get => ref RDI.edi;
        }

        ref R.RDI rdi
        {
            [MethodImpl(Inline)]
            get => ref RDI;
        }

        //! RSP
        //! -------------------------------------------------------------------

        ref R.SPL spl
        {
            [MethodImpl(Inline)]
            get => ref RSP.spl;
        }

        ref R.SP sp
        {
            [MethodImpl(Inline)]
            get => ref RSP.sp;
        }

        ref R.ESP esp
        {
            [MethodImpl(Inline)]
            get => ref RSP.esp;
        }

        ref R.RSP rsp
        {
            [MethodImpl(Inline)]
            get => ref RSP;
        }

        //! R8
        //! -------------------------------------------------------------------

        ref R.R8B r8b
        {
            [MethodImpl(Inline)]
            get => ref R8.r8b;
        }

        ref R.R8W r8w
        {
            [MethodImpl(Inline)]
            get => ref R8.r8w;
        }

        ref R.R8D r8d
        {
            [MethodImpl(Inline)]
            get => ref R8.r8d;
        }

        ref R.R8 r8
        {
            [MethodImpl(Inline)]
            get => ref R8;
        }

        //! R9
        //! -------------------------------------------------------------------

        ref R.R9B r9b
        {
            [MethodImpl(Inline)]
            get => ref R9.r9b;
        }

        ref R.R9W r9w
        {
            [MethodImpl(Inline)]
            get => ref R9.r9w;
        }

        ref R.R9D r9d
        {
            [MethodImpl(Inline)]
            get => ref R9.r9d;
        }

        ref R.R9 r9
        {
            [MethodImpl(Inline)]
            get => ref R9;
        }

        //! R10
        //! -------------------------------------------------------------------

        ref R.R10B r10b
        {
            [MethodImpl(Inline)]
            get => ref R10.r10b;
        }

        ref R.R10W r10w
        {
            [MethodImpl(Inline)]
            get => ref R10.r10w;
        }

        ref R.R10D r10d
        {
            [MethodImpl(Inline)]
            get => ref R10.r10d;
        }

        ref R.R10 r10
        {
            [MethodImpl(Inline)]
            get => ref R10;
        }

        //! R11
        //! -------------------------------------------------------------------

        ref byte r11b
        {
            [MethodImpl(Inline)]
            get => ref R11.r11b;
        }

        ref ushort r11w
        {
            [MethodImpl(Inline)]
            get => ref R11.r11w;
        }

        ref uint r11d
        {
            [MethodImpl(Inline)]
            get => ref R11.r11d;
        }

        ref ulong r11
        {
            [MethodImpl(Inline)]
            get => ref R11.r11;
        }


        //! R12
        //! -------------------------------------------------------------------

        ref byte r12b
        {
            [MethodImpl(Inline)]
            get => ref R12.r12b;
        }

        ref ushort r12w
        {
            [MethodImpl(Inline)]
            get => ref R12.r12w;
        }

        ref uint r12d
        {
            [MethodImpl(Inline)]
            get => ref R12.r12d;
        }

        ref ulong r12
        {
            [MethodImpl(Inline)]
            get => ref R12.r12;
        }

        //! R13
        //! -------------------------------------------------------------------

        ref byte r13b
        {
            [MethodImpl(Inline)]
            get => ref R13.r13b;
        }

        ref ushort r13w
        {
            [MethodImpl(Inline)]
            get => ref R13.r13w;
        }

        ref uint r13d
        {
            [MethodImpl(Inline)]
            get => ref R13.r13d;
        }

        ref ulong r13
        {
            [MethodImpl(Inline)]
            get => ref R13.r13;
        }

        //! R14
        //! -------------------------------------------------------------------

        ref byte r14b
        {
            [MethodImpl(Inline)]
            get => ref R14.r14b;
        }

        ref ushort r14w
        {
            [MethodImpl(Inline)]
            get => ref R14.r14w;
        }

        ref uint r14d
        {
            [MethodImpl(Inline)]
            get => ref R14.r14d;
        }

        ref ulong r14
        {
            [MethodImpl(Inline)]
            get => ref R14.r14;
        }

        //! R15
        //! -------------------------------------------------------------------

        ref byte r15b
        {
            [MethodImpl(Inline)]
            get => ref R15.r15b;
        }

        ref ushort r15w
        {
            [MethodImpl(Inline)]
            get => ref R15.r15w;
        }

        ref uint r15d
        {
            [MethodImpl(Inline)]
            get => ref R15.r15d;
        }

        ref ulong r15
        {
            [MethodImpl(Inline)]
            get => ref R15.r15;
        }

        //! Segment Registers
        //! -------------------------------------------------------------------

        ref R.CS cs
        {
            [MethodImpl(Inline)]
            get => ref CS;
        }

        ref R.DS ds
        {
            [MethodImpl(Inline)]
            get => ref DS;
        }

        ref R.ES es
        {
            [MethodImpl(Inline)]
            get => ref ES;
        }

        ref R.FS fs
        {
            [MethodImpl(Inline)]
            get => ref FS;
        }

        ref R.GS gs
        {
            [MethodImpl(Inline)]
            get => ref GS;
        }

        ref R.SS ss
        {
            [MethodImpl(Inline)]
            get => ref SS;
        }

        //! ZMM
        //! -------------------------------------------------------------------
        ref R.ZMM zmm0
        {
            [MethodImpl(Inline)]
            get => ref ZMM[0];
        }

        ref R.ZMM zmm1
        {
            [MethodImpl(Inline)]
            get => ref ZMM[1];
        }

        ref R.ZMM zmm2
        {
            [MethodImpl(Inline)]
            get => ref ZMM[2];
        }

        ref R.ZMM zmm3
        {
            [MethodImpl(Inline)]
            get => ref ZMM[3];
        }

        ref R.ZMM zmm4
        {
            [MethodImpl(Inline)]
            get => ref ZMM[4];
        }

        ref R.ZMM zmm5
        {
            [MethodImpl(Inline)]
            get => ref ZMM[5];
        }

        ref R.ZMM zmm6
        {
            [MethodImpl(Inline)]
            get => ref ZMM[6];
        }

        ref R.ZMM zmm7
        {
            [MethodImpl(Inline)]
            get => ref ZMM[7];
        }

        ref R.ZMM zmm8
        {
            [MethodImpl(Inline)]
            get => ref ZMM[8];
        }

        ref R.ZMM zmm9
        {
            [MethodImpl(Inline)]
            get => ref ZMM[9];
        }

        ref R.ZMM zmm10
        {
            [MethodImpl(Inline)]
            get => ref ZMM[10];
        }

        ref R.ZMM zmm11
        {
            [MethodImpl(Inline)]
            get => ref ZMM[11];
        }

        ref R.ZMM zmm12
        {
            [MethodImpl(Inline)]
            get => ref ZMM[12];
        }

        ref R.ZMM zmm13
        {
            [MethodImpl(Inline)]
            get => ref ZMM[13];
        }

        ref R.ZMM zmm14
        {
            [MethodImpl(Inline)]
            get => ref ZMM[14];
        }

        ref R.ZMM zmm15
        {
            [MethodImpl(Inline)]
            get => ref ZMM[15];
        }

        ref R.ZMM zmm16
        {
            [MethodImpl(Inline)]
            get => ref ZMM[16];
        }

        ref R.ZMM zmm17
        {
            [MethodImpl(Inline)]
            get => ref ZMM[17];
        }

        ref R.ZMM zmm18
        {
            [MethodImpl(Inline)]
            get => ref ZMM[18];
        }

        ref R.ZMM zmm19
        {
            [MethodImpl(Inline)]
            get => ref ZMM[19];
        }

        ref R.ZMM zmm20
        {
            [MethodImpl(Inline)]
            get => ref ZMM[20];
        }

        ref R.ZMM zmm21
        {
            [MethodImpl(Inline)]
            get => ref ZMM[21];
        }

        ref R.ZMM zmm22
        {
            [MethodImpl(Inline)]
            get => ref ZMM[22];
        }

        ref R.ZMM zmm23
        {
            [MethodImpl(Inline)]
            get => ref ZMM[23];
        }

        ref R.ZMM zmm24
        {
            [MethodImpl(Inline)]
            get => ref ZMM[24];
        }

        ref R.ZMM zmm25
        {
            [MethodImpl(Inline)]
            get => ref ZMM[25];
        }

        ref R.ZMM zmm26
        {
            [MethodImpl(Inline)]
            get => ref ZMM[26];
        }

        ref R.ZMM zmm27
        {
            [MethodImpl(Inline)]
            get => ref ZMM[27];
        }

        ref R.ZMM zmm28
        {
            [MethodImpl(Inline)]
            get => ref ZMM[28];
        }

        ref R.ZMM zmm29
        {
            [MethodImpl(Inline)]
            get => ref ZMM[29];
        }

        ref R.ZMM zmm30
        {
            [MethodImpl(Inline)]
            get => ref ZMM[30];
        }

        ref R.ZMM zmm31
        {
            [MethodImpl(Inline)]
            get => ref ZMM[31];
        }

        //! YMM
        //! -------------------------------------------------------------------

        ref R.YMM ymm0
        {
            [MethodImpl(Inline)]
            get => ref zmm0.ymm0;
        }

        ref R.YMM ymm1
        {
            [MethodImpl(Inline)]
            get => ref zmm1.ymm0;
        }

        ref R.YMM ymm2
        {
            [MethodImpl(Inline)]
            get => ref zmm2.ymm0;
        }

        ref R.YMM ymm3
        {
            [MethodImpl(Inline)]
            get => ref zmm3.ymm0;
        }

        ref R.YMM ymm4
        {
            [MethodImpl(Inline)]
            get => ref zmm4.ymm0;
        }

        ref R.YMM ymm5
        {
            [MethodImpl(Inline)]
            get => ref zmm5.ymm0;
        }

        ref R.YMM ymm6
        {
            [MethodImpl(Inline)]
            get => ref zmm6.ymm0;
        }

        ref R.YMM ymm7
        {
            [MethodImpl(Inline)]
            get => ref zmm7.ymm0;
        }

        ref R.YMM ymm8
        {
            [MethodImpl(Inline)]
            get => ref zmm8.ymm0;
        }

        ref R.YMM ymm9
        {
            [MethodImpl(Inline)]
            get => ref zmm9.ymm0;
        }

        ref R.YMM ymm10
        {
            [MethodImpl(Inline)]
            get => ref zmm10.ymm0;
        }

        ref R.YMM ymm11
        {
            [MethodImpl(Inline)]
            get => ref zmm11.ymm0;
        }

        ref R.YMM ymm12
        {
            [MethodImpl(Inline)]
            get => ref zmm12.ymm0;
        }

        ref R.YMM ymm13
        {
            [MethodImpl(Inline)]
            get => ref zmm13.ymm0;
        }

        ref R.YMM ymm14
        {
            [MethodImpl(Inline)]
            get => ref zmm14.ymm0;
        }

        ref R.YMM ymm15
        {
            [MethodImpl(Inline)]
            get => ref zmm15.ymm0;
        }

        ref R.YMM ymm16
        {
            [MethodImpl(Inline)]
            get => ref zmm16.ymm0;
        }

        ref R.YMM ymm17
        {
            [MethodImpl(Inline)]
            get => ref zmm17.ymm0;
        }

        ref R.YMM ymm18
        {
            [MethodImpl(Inline)]
            get => ref zmm18.ymm0;
        }

        ref R.YMM ymm19
        {
            [MethodImpl(Inline)]
            get => ref zmm19.ymm0;
        }

        ref R.YMM ymm20
        {
            [MethodImpl(Inline)]
            get => ref zmm20.ymm0;
        }

        ref R.YMM ymm21
        {
            [MethodImpl(Inline)]
            get => ref zmm21.ymm0;
        }

        ref R.YMM ymm22
        {
            [MethodImpl(Inline)]
            get => ref zmm22.ymm0;
        }

        ref R.YMM ymm23
        {
            [MethodImpl(Inline)]
            get => ref zmm23.ymm0;
        }

        ref R.YMM ymm24
        {
            [MethodImpl(Inline)]
            get => ref zmm24.ymm0;
        }

        ref R.YMM ymm25
        {
            [MethodImpl(Inline)]
            get => ref zmm25.ymm0;
        }

        ref R.YMM ymm26
        {
            [MethodImpl(Inline)]
            get => ref zmm26.ymm0;
        }

        ref R.YMM ymm27
        {
            [MethodImpl(Inline)]
            get => ref zmm27.ymm0;
        }

        ref R.YMM ymm28
        {
            [MethodImpl(Inline)]
            get => ref zmm28.ymm0;
        }

        ref R.YMM ymm29
        {
            [MethodImpl(Inline)]
            get => ref zmm29.ymm0;
        }

        ref R.YMM ymm30
        {
            [MethodImpl(Inline)]
            get => ref zmm30.ymm0;
        }

        ref R.YMM ymm31
        {
            [MethodImpl(Inline)]
            get => ref zmm31.ymm0;
        }

        //! XMM
        //! -------------------------------------------------------------------

        ref R.XMM xmm0
        {
            [MethodImpl(Inline)]
            get => ref zmm0.xmm0;
        }

        ref R.XMM xmm1
        {
            [MethodImpl(Inline)]
            get => ref zmm1.xmm0;
        }

        ref R.XMM xmm2
        {
            [MethodImpl(Inline)]
            get => ref zmm2.xmm0;
        }

        ref R.XMM xmm3
        {
            [MethodImpl(Inline)]
            get => ref zmm3.xmm0;
        }

        ref R.XMM xmm4
        {
            [MethodImpl(Inline)]
            get => ref zmm4.xmm0;
        }

        ref R.XMM xmm5
        {
            [MethodImpl(Inline)]
            get => ref zmm5.xmm0;
        }

        ref R.XMM xmm6
        {
            [MethodImpl(Inline)]
            get => ref zmm6.xmm0;
        }

        ref R.XMM xmm7
        {
            [MethodImpl(Inline)]
            get => ref zmm7.xmm0;
        }

        ref R.XMM xmm8
        {
            [MethodImpl(Inline)]
            get => ref zmm8.xmm0;
        }

        ref R.XMM xmm9
        {
            [MethodImpl(Inline)]
            get => ref zmm9.xmm0;
        }

        ref R.XMM xmm10
        {
            [MethodImpl(Inline)]
            get => ref zmm10.xmm0;
        }

        ref R.XMM xmm11
        {
            [MethodImpl(Inline)]
            get => ref zmm11.xmm0;
        }

        ref R.XMM xmm12
        {
            [MethodImpl(Inline)]
            get => ref zmm12.xmm0;
        }

        ref R.XMM xmm13
        {
            [MethodImpl(Inline)]
            get => ref zmm13.xmm0;
        }

        ref R.XMM xmm14
        {
            [MethodImpl(Inline)]
            get => ref zmm14.xmm0;
        }

        ref R.XMM xmm15
        {
            [MethodImpl(Inline)]
            get => ref zmm15.xmm0;
        }

        ref R.XMM xmm16
        {
            [MethodImpl(Inline)]
            get => ref zmm16.xmm0;
        }

        ref R.XMM xmm17
        {
            [MethodImpl(Inline)]
            get => ref zmm17.xmm0;
        }

        ref R.XMM xmm18
        {
            [MethodImpl(Inline)]
            get => ref zmm18.xmm0;
        }

        ref R.XMM xmm19
        {
            [MethodImpl(Inline)]
            get => ref zmm19.xmm0;
        }

        ref R.XMM xmm20
        {
            [MethodImpl(Inline)]
            get => ref zmm20.xmm0;
        }

        ref R.XMM xmm21
        {
            [MethodImpl(Inline)]
            get => ref zmm21.xmm0;
        }

        ref R.XMM xmm22
        {
            [MethodImpl(Inline)]
            get => ref zmm22.xmm0;
        }

        ref R.XMM xmm23
        {
            [MethodImpl(Inline)]
            get => ref zmm23.xmm0;
        }

        ref R.XMM xmm24
        {
            [MethodImpl(Inline)]
            get => ref zmm24.xmm0;
        }

        ref R.XMM xmm25
        {
            [MethodImpl(Inline)]
            get => ref zmm25.xmm0;
        }

        ref R.XMM xmm26
        {
            [MethodImpl(Inline)]
            get => ref zmm26.xmm0;
        }

        ref R.XMM xmm27
        {
            [MethodImpl(Inline)]
            get => ref zmm27.xmm0;
        }

        ref R.XMM xmm28
        {
            [MethodImpl(Inline)]
            get => ref zmm28.xmm0;
        }

        ref R.XMM xmm29
        {
            [MethodImpl(Inline)]
            get => ref zmm29.xmm0;
        }

        ref R.XMM xmm30
        {
            [MethodImpl(Inline)]
            get => ref zmm30.xmm0;
        }

        ref R.XMM xmm31
        {
            [MethodImpl(Inline)]
            get => ref zmm31.xmm0;
        }
    }
}