//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;
    using static Registers;
    using Offsets = Gp64Offsets;


    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public struct GpRegBank
    {

        [FieldOffset(Offsets.RAX)]
        public RAX rax;

        [FieldOffset(Offsets.RAX)]
        public EAX eax;

        [FieldOffset(Offsets.RAX)]
        public AX ax;

        [FieldOffset(Offsets.RAX)]
        public AL al;
    
        [FieldOffset(Offsets.RAX + 1)]
        public AH ah;

        //!--
        
        [FieldOffset(Offsets.RBX)]
        public RBX rbx;

        [FieldOffset(Offsets.RBX)]
        public EBX ebx;

        [FieldOffset(Offsets.RBX)]
        public BX bx;

        [FieldOffset(Offsets.RBX)]
        public BL bl;

        [FieldOffset(Offsets.RBX + 1)]
        public BH bh;
        
        //!--

        [FieldOffset(Offsets.RCX)]        
        public RCX rcx;

        [FieldOffset(Offsets.RCX)]
        public ECX ecx;

        [FieldOffset(Offsets.RCX)]
        public CX cx;

        [FieldOffset(Offsets.RCX)]
        public CL cl;

        [FieldOffset(Offsets.RCX + 1)]
        public CH ch;

        //!--

        [FieldOffset(Offsets.RDX)]
        public RDX rdx;

        [FieldOffset(Offsets.RDX)]
        public EDX edx;

        [FieldOffset(Offsets.RDX)]
        public DX dx;

        [FieldOffset(Offsets.RDX)]
        public DL dl;

        [FieldOffset(Offsets.RDX + 1)]
        public DH dh;

        //!--

        [FieldOffset(Offsets.RSI)]
        public RSI rsi;

        [FieldOffset(Offsets.RSI)]
        public ESI esi;

        [FieldOffset(Offsets.RSI)]
        public SI si;

        [FieldOffset(Offsets.RSI)]
        public SIL sil;

        //!--

        [FieldOffset(Offsets.RDI)]
        public RDI rdi;

        [FieldOffset(Offsets.RDI)]
        public EDI edi;

        [FieldOffset(Offsets.RDI)]
        public DI di;

        [FieldOffset(Offsets.RDI)]
        public DIL dil;

        //!--

        [FieldOffset(Offsets.RSP)]
        public RSP rsp;

        [FieldOffset(Offsets.RSP)]
        public ESP esp;

        [FieldOffset(Offsets.RSP)]
        public SP sp;

        [FieldOffset(Offsets.RSP)]
        public SPL spl;
        
        //!--

        [FieldOffset(Offsets.RBP)]
        public RBP rbp;

        [FieldOffset(Offsets.RBP)]
        public EBP ebp;

        [FieldOffset(Offsets.RBP)]
        public BP bp;

        [FieldOffset(Offsets.RBP)]
        public BPL bpl;

        //!--

        [FieldOffset(Offsets.R8)]
        public R8 r8;

        [FieldOffset(Offsets.R8)]
        public R8D r8d;

        [FieldOffset(Offsets.R8)]
        public R8W r8w;

        [FieldOffset(Offsets.R8)]
        public R8B r8b;

        //!--

        [FieldOffset(Offsets.R9)]
        public R9 r9;

        [FieldOffset(Offsets.R9)]
        public R9D r9d;

        [FieldOffset(Offsets.R9)]
        public R9W r9w;

        [FieldOffset(Offsets.R9)]
        public R9B r9b;

        //!--

        [FieldOffset(Offsets.R10)]
        public R10 r10;

        [FieldOffset(Offsets.R10)]
        public R10D r10d;

        [FieldOffset(Offsets.R10)]
        public R10W r10w;

        [FieldOffset(Offsets.R10)]
        public R10B r10b;

        //!--

        [FieldOffset(Offsets.R11)]
        public R11 r11;

        [FieldOffset(Offsets.R11)]
        public R11D r11d;

        [FieldOffset(Offsets.R11)]
        public R11W r11w;

        [FieldOffset(Offsets.R11)]
        public R11B r11b;


        //!--

        [FieldOffset(Offsets.R12)]
        public R12 r12;

        [FieldOffset(Offsets.R12)]
        public R12D r12d;

        [FieldOffset(Offsets.R12)]
        public R12W r12w;

        [FieldOffset(Offsets.R12)]
        public R12B r12b;

        //!--

        [FieldOffset(Offsets.R13)]
        public R13 r13;

        [FieldOffset(Offsets.R13)]
        public R13D r13d;

        [FieldOffset(Offsets.R13)]
        public R13W r13w;

        [FieldOffset(Offsets.R13)]
        public R13B r13b;

        //!--

        [FieldOffset(Offsets.R14)]
        public R14 r14;

        [FieldOffset(Offsets.R14)]
        public R14D r14d;

        [FieldOffset(Offsets.R14)]
        public R14W r14w;

        [FieldOffset(Offsets.R14)]
        public R14B r14b;
        //!--

        [FieldOffset(Offsets.R15)]
        public R15 r15;

        [FieldOffset(Offsets.R15)]
        public R15D r15d;

        [FieldOffset(Offsets.R15)]
        public R15W r15w;

        [FieldOffset(Offsets.R15)]
        public R15B r15b;



    }

}