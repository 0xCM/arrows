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

    partial class CpuCore
    {

        //~ RAX
        //~ ----------------------------
        ref R.AL al
        {
            [MethodImpl(Inline)]
            get => ref Gpr.al;
        }

        ref R.AX ax
        {
            [MethodImpl(Inline)]
            get => ref Gpr.ax;
        }

        ref R.EAX eax
        {
            [MethodImpl(Inline)]
            get => ref Gpr.eax;
        }

        ref R.RAX rax
        {
            [MethodImpl(Inline)]
            get => ref Gpr.rax;
        }

        //~ RCX
        //~ ----------------------------

        ref R.CL cl
        {
            [MethodImpl(Inline)]
            get => ref Gpr.cl;
        }

        ref R.CX cx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.cx;
        }

        ref R.ECX ecx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.ecx;
        }


        ref R.RCX rcx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.rcx;
        }

        //~ RBX
        //~ ----------------------------
        
        ref R.BL bl
        {
            [MethodImpl(Inline)]
            get => ref Gpr.bl;
        }

        ref R.BX bx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.bx;
        }

        ref R.EBX ebx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.ebx;
        }

        ref R.RBX rbx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.rbx;
        }

        //~ RDX
        //~ ----------------------------

        ref R.DL dl
        {
            [MethodImpl(Inline)]
            get => ref Gpr.dl;
        }

        ref R.DX dx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.dx;
        }

        ref R.EDX edx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.edx;
        }

        ref R.RDX rdx
        {
            [MethodImpl(Inline)]
            get => ref Gpr.rdx;
        }

        //~ RSI
        //~ ----------------------------

        ref R.SIL sil
        {
            [MethodImpl(Inline)]
            get => ref Gpr.sil;
        }

        ref R.SI si
        {
            [MethodImpl(Inline)]
            get => ref Gpr.si;
        }

        ref R.ESI esi
        {
            [MethodImpl(Inline)]
            get => ref Gpr.esi;
        }

        ref R.RSI rsi
        {
            [MethodImpl(Inline)]
            get => ref Gpr.rsi;
        }

        //~ RBP
        //~ ----------------------------

        ref R.BPL bpl
        {
            [MethodImpl(Inline)]
            get => ref Gpr.bpl;
        }

        ref R.BP bp
        {
            [MethodImpl(Inline)]
            get => ref Gpr.bp;
        }

        ref R.EBP ebp
        {
            [MethodImpl(Inline)]
            get => ref Gpr.ebp;
        }

        ref R.RBP rbp
        {
            [MethodImpl(Inline)]
            get => ref Gpr.rbp;
        }

        //~ RDI
        //~ ----------------------------

        ref R.DIL dil
        {
            [MethodImpl(Inline)]
            get => ref Gpr.dil;
        }

        ref R.DI di
        {
            [MethodImpl(Inline)]
            get => ref Gpr.di;
        }

        ref R.EDI edi
        {
            [MethodImpl(Inline)]
            get => ref Gpr.edi;
        }

        ref R.RDI rdi
        {
            [MethodImpl(Inline)]
            get => ref Gpr.rdi;
        }

        //~ RSP
        //~ ----------------------------

        ref R.SPL spl
        {
            [MethodImpl(Inline)]
            get => ref Gpr.spl;
        }

        ref R.SP sp
        {
            [MethodImpl(Inline)]
            get => ref Gpr.sp;
        }

        ref R.ESP esp
        {
            [MethodImpl(Inline)]
            get => ref Gpr.esp;
        }

        ref R.RSP rsp
        {
            [MethodImpl(Inline)]
            get => ref Gpr.rsp;
        }

        //~ R8
        //~ ----------------------------

        ref R.R8B r8b
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r8b;
        }

        ref R.R8W r8w
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r8w;
        }

        ref R.R8D r8d
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r8d;
        }

        ref R.R8 r8
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r8;
        }

        //~ R9
        //~ ----------------------------

        ref R.R9B r9b
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r9b;
        }

        ref R.R9W r9w
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r9w;
        }

        ref R.R9D r9d
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r9d;
        }

        ref R.R9 r9
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r9;
        }

        //~ R10
        //~ ----------------------------

        ref R.R10B r10b
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r10b;
        }

        ref R.R10W r10w
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r10w;
        }

        ref R.R10D r10d
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r10d;
        }

        ref R.R10 r10
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r10;
        }

        //~ R11
        //~ ----------------------------

        ref R.R11B r11b
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r11.r11b;
        }

        ref R.R11W r11w
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r11w;
        }

        ref R.R11D r11d
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r11d;
        }

        ref R.R11 r11
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r11;
        }


        //~ R12
        //~ ----------------------------

        ref R.R12B r12b
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r12b;
        }

        ref R.R12W r12w
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r12w;
        }

        ref R.R12D r12d
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r12d;
        }

        ref R.R12 r12
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r12;
        }

        //~ R13
        //~ ----------------------------

        ref R.R13B r13b
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r13b;
        }

        ref R.R13W r13w
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r13w;
        }

        ref R.R13D r13d
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r13d;
        }

        ref R.R13 r13
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r13;
        }

        //~ R14
        //~ ----------------------------

        ref R.R14B r14b
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r14b;
        }

        ref R.R14W r14w
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r14w;
        }

        ref R.R14D r14d
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r14d;
        }

        ref R.R14 r14
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r14;
        }

        //~ R15
        //~ ----------------------------

        ref R.R15B r15b
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r15b;
        }

        ref R.R15W r15w
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r15w;
        }

        ref R.R15D r15d
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r15d;
        }

        ref R.R15 r15
        {
            [MethodImpl(Inline)]
            get => ref Gpr.r15;
        }

        //~ Segment Registers
        //~ ----------------------------

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

        //~ ZMM
        //~ ----------------------------
        ref R.ZMM zmm0
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm0;
        }

        ref R.ZMM zmm1
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm1;
        }

        ref R.ZMM zmm2
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm2;
        }

        ref R.ZMM zmm3
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm3;
        }

        ref R.ZMM zmm4
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm4;
        }

        ref R.ZMM zmm5
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm5;
        }

        ref R.ZMM zmm6
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm6;
        }

        ref R.ZMM zmm7
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm7;
        }

        ref R.ZMM zmm8
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm8;
        }

        ref R.ZMM zmm9
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm9;
        }

        ref R.ZMM zmm10
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm10;
        }

        ref R.ZMM zmm11
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm11;
        }

        ref R.ZMM zmm12
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm12;
        }

        ref R.ZMM zmm13
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm13;
        }

        ref R.ZMM zmm14
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm14;
        }

        ref R.ZMM zmm15
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm15;
        }

        ref R.ZMM zmm16
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm16;
        }

        ref R.ZMM zmm17
        {
            [MethodImpl(Inline)]
            get => ref Zmm.zmm17;
        }


        //~ YMM
        //~ ----------------------------

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

        // ref R.YMM ymm18
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm18.ymm0;
        // }

        // ref R.YMM ymm19
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm19.ymm0;
        // }

        // ref R.YMM ymm20
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm20.ymm0;
        // }

        // ref R.YMM ymm21
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm21.ymm0;
        // }

        // ref R.YMM ymm22
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm22.ymm0;
        // }

        // ref R.YMM ymm23
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm23.ymm0;
        // }

        // ref R.YMM ymm24
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm24.ymm0;
        // }

        // ref R.YMM ymm25
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm25.ymm0;
        // }

        // ref R.YMM ymm26
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm26.ymm0;
        // }

        // ref R.YMM ymm27
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm27.ymm0;
        // }

        // ref R.YMM ymm28
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm28.ymm0;
        // }

        // ref R.YMM ymm29
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm29.ymm0;
        // }

        // ref R.YMM ymm30
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm30.ymm0;
        // }

        // ref R.YMM ymm31
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm31.ymm0;
        // }

        //~ XMM
        //~ ----------------------------

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

        // ref R.XMM xmm18
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm18.xmm0;
        // }

        // ref R.XMM xmm19
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm19.xmm0;
        // }

        // ref R.XMM xmm20
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm20.xmm0;
        // }

        // ref R.XMM xmm21
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm21.xmm0;
        // }

        // ref R.XMM xmm22
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm22.xmm0;
        // }

        // ref R.XMM xmm23
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm23.xmm0;
        // }

        // ref R.XMM xmm24
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm24.xmm0;
        // }

        // ref R.XMM xmm25
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm25.xmm0;
        // }

        // ref R.XMM xmm26
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm26.xmm0;
        // }

        // ref R.XMM xmm27
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm27.xmm0;
        // }

        // ref R.XMM xmm28
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm28.xmm0;
        // }

        // ref R.XMM xmm29
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm29.xmm0;
        // }

        // ref R.XMM xmm30
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm30.xmm0;
        // }

        // ref R.XMM xmm31
        // {
        //     [MethodImpl(Inline)]
        //     get => ref zmm31.xmm0;
        // }
    }
}