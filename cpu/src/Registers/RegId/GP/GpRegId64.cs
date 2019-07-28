//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    
    using Offsets = Gp64Offsets;

    public readonly struct Gp64Offsets
    {
        public const int RAX = 0;
        
        public const int RBX = 8;
        
        public const int RCX = 16;

        public const int RDX = 24;

        public const int RSI = 32;

        public const int RDI = 40;

        public const int RSP = 48;

        public const int RBP = 56;

        public const int R8 = 64;

        public const int R9 = 72;

        public const int R10 = 80;

        public const int R11 = 88;

        public const int R12 = 96;

        public const int R13 = 104;

        public const int R14 = 112;

        public const int R15 = 120;

    }


    [Flags,Info(Desc.RegIdInfo, BitWidth.Bw64)]
    public enum GpRegId64 : ulong
    {
        /// <summary>
        /// Identifies the 64-bit register RAX
        /// </summary>
        rax = (ulong)Pow2.T32 | Pow2.T03,
        
        /// <summary>
        /// Identifies the 64-bit register RBX
        /// </summary>
        rbx = ((ulong)Gp64Offsets.RBX << 32) | Pow2.T03,

        /// <summary>
        /// Identifies the 64-bit register RCX
        /// </summary>
        rcx = ((ulong)Gp64Offsets.RCX << 32) | Pow2.T03,

        /// <summary>
        /// Identifies the 64-bit register RDX
        /// </summary>
        rdx = ((ulong)Gp64Offsets.RDX << 32) | Pow2.T03,

        /// <summary>
        /// Identifies the 64-bit register RSI
        /// </summary>
        rsi = ((ulong)Gp64Offsets.RSI << 32) | Pow2.T03,

        /// <summary>
        /// Identifies the 64-bit register RDI
        /// </summary>
        rdi = ((ulong)Gp64Offsets.RDI << 32) | Pow2.T03,

        /// <summary>
        /// Identifies the 64-bit register RSP
        /// </summary>
        rsp = ((ulong)Gp64Offsets.RSP << 32) | Pow2.T03,

        rbp = ((ulong)Gp64Offsets.RBP << 32) | Pow2.T03,

        r8 = ((ulong)Gp64Offsets.R8 << 32) | Pow2.T03,

        r9 = ((ulong)Gp64Offsets.R9 << 32) | Pow2.T03,
        
        r10 = ((ulong)Gp64Offsets.R10 << 32) | Pow2.T03,

        r11 = ((ulong)Gp64Offsets.R11 << 32) | Pow2.T03,

        r12 = ((ulong)Gp64Offsets.R12 << 32) | Pow2.T03,

        r13 = ((ulong)Gp64Offsets.R13 << 32) | Pow2.T03,

        r14 = ((ulong)Gp64Offsets.R14 << 32) | Pow2.T03,

        r15 = ((ulong)Gp64Offsets.R15 << 32) | Pow2.T03,

        


    }

}
