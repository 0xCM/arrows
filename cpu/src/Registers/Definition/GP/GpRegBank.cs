//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;
    using static Registers;

    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public struct GpRegBank
    {

        [FieldOffset(RaxOffset)]
        public RAX rax;

        [FieldOffset(RaxOffset)]
        public EAX eax;

        [FieldOffset(RaxOffset)]
        public AX ax;

        [FieldOffset(RaxOffset)]
        public AL al;
    
        [FieldOffset(RaxOffset + 1)]
        public AH ah;

        //!--
        
        [FieldOffset(RbxOffset)]
        public RBX rbx;

        [FieldOffset(RbxOffset)]
        public EBX ebx;

        [FieldOffset(RbxOffset)]
        public BX bx;

        [FieldOffset(RbxOffset)]
        public BL bl;

        [FieldOffset(RbxOffset + 1)]
        public BH bh;
        
        //!--

        [FieldOffset(RcxOffset)]        
        public RCX rcx;

        [FieldOffset(RcxOffset)]
        public ECX ecx;

        [FieldOffset(RcxOffset)]
        public CX cx;

        [FieldOffset(RcxOffset)]
        public CL cl;

        [FieldOffset(RcxOffset + 1)]
        public CH ch;

        //!--

        [FieldOffset(RdxOffset)]
        public RDX rdx;

        [FieldOffset(RdxOffset)]
        public EDX edx;

        [FieldOffset(RdxOffset)]
        public DX dx;

        [FieldOffset(RdxOffset)]
        public DL dl;

        [FieldOffset(RdxOffset + 1)]
        public DH dh;

        //!--

        [FieldOffset(RsiOffset)]
        public RSI rsi;

        [FieldOffset(RsiOffset)]
        public ESI esi;

        [FieldOffset(RsiOffset)]
        public SI si;

        [FieldOffset(RsiOffset)]
        public SIL sil;

        //!--

        [FieldOffset(RdiOffset)]
        public RDI rdi;

        [FieldOffset(RdiOffset)]
        public EDI edi;

        [FieldOffset(RdiOffset)]
        public DI di;

        [FieldOffset(RdiOffset)]
        public DIL dil;

        //!--

        [FieldOffset(RspOffset)]
        public RSP rsp;

        [FieldOffset(RspOffset)]
        public ESP esp;

        [FieldOffset(RspOffset)]
        public SP sp;

        [FieldOffset(RspOffset)]
        public SPL spl;
        
        //!--

        [FieldOffset(RbpOffset)]
        public RBP rbp;

        [FieldOffset(RbpOffset)]
        public EBP ebp;

        [FieldOffset(RbpOffset)]
        public BP bp;

        [FieldOffset(RbpOffset)]
        public BPL bpl;

        //!--

        [FieldOffset(R8Offset)]
        public R8 r8;

        [FieldOffset(R8Offset)]
        public R8D r8d;

        [FieldOffset(R8Offset)]
        public R8W r8w;

        [FieldOffset(R8Offset)]
        public R8B r8b;

        //!--

        [FieldOffset(R9Offset)]
        public R9 r9;

        [FieldOffset(R9Offset)]
        public R9D r9d;

        [FieldOffset(R9Offset)]
        public R9W r9w;

        [FieldOffset(R9Offset)]
        public R9B r9b;

        //!--

        [FieldOffset(R10Offset)]
        public R10 r10;

        [FieldOffset(R10Offset)]
        public R10D r10d;

        [FieldOffset(R10Offset)]
        public R10W r10w;

        [FieldOffset(R10Offset)]
        public R10B r10b;

        //!--

        [FieldOffset(R11Offset)]
        public R11 r11;

        [FieldOffset(R11Offset)]
        public R11D r11d;

        [FieldOffset(R11Offset)]
        public R11W r11w;

        [FieldOffset(R11Offset)]
        public R11B r11b;


        //!--

        [FieldOffset(R12Offset)]
        public R12 r12;

        [FieldOffset(R12Offset)]
        public R12D r12d;

        [FieldOffset(R12Offset)]
        public R12W r12w;

        [FieldOffset(R12Offset)]
        public R12B r12b;

        //!--

        [FieldOffset(R13Offset)]
        public R13 r13;

        [FieldOffset(R13Offset)]
        public R13D r13d;

        [FieldOffset(R13Offset)]
        public R13W r13w;

        [FieldOffset(R13Offset)]
        public R13B r13b;

        //!--

        [FieldOffset(R14Offset)]
        public R14 r14;

        [FieldOffset(R14Offset)]
        public R14D r14d;

        [FieldOffset(R14Offset)]
        public R14W r14w;

        [FieldOffset(R14Offset)]
        public R14B r14b;
        //!--

        [FieldOffset(R15Offset)]
        public R15 r15;

        [FieldOffset(R15Offset)]
        public R15D r15d;

        [FieldOffset(R15Offset)]
        public R15W r15w;

        [FieldOffset(R15Offset)]
        public R15B r15b;



        const int RaxOffset = 0;
        
        const int RbxOffset = 8;

        const int RcxOffset = 16;

        const int RdxOffset = 24;

        const int RsiOffset = 32;

        const int RdiOffset = 40;

        const int RspOffset = 48;

        const int RbpOffset = 56;

        const int R8Offset = 64;

        const int R9Offset = 72;

        const int R10Offset = 80;

        const int R11Offset = 88;

        const int R12Offset = 96;

        const int R13Offset = 104;

        const int R14Offset = 112;

        const int R15Offset = 120;

    }

}