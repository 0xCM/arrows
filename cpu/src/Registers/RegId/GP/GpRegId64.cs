//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Classifies 64-bit general purpose registers
    /// </summary>
    [Flags]
    public enum GpRegId64 : ulong
    {
        /// <summary>
        /// Identifies the 64-bit register RAX
        /// </summary>
        rax = Pow2.T32 | Pow2.T06,
        
        /// <summary>
        /// Identifies the 64-bit register RBX
        /// </summary>
        rbx = (RegOffsets.RBX << 32) | Pow2.T06,

        /// <summary>
        /// Identifies the 64-bit register RCX
        /// </summary>
        rcx = (RegOffsets.RCX << 32) | Pow2.T06,

        /// <summary>
        /// Identifies the 64-bit register RDX
        /// </summary>
        rdx = (RegOffsets.RDX << 32) | Pow2.T06,

        /// <summary>
        /// Identifies the 64-bit register RSI
        /// </summary>
        rsi = (RegOffsets.RSI << 32) | Pow2.T06,

        /// <summary>
        /// Identifies the 64-bit register RDI
        /// </summary>
        rdi = (RegOffsets.RDI << 32) | Pow2.T06,

        /// <summary>
        /// Identifies the 64-bit register RSP
        /// </summary>
        rsp = (RegOffsets.RSP << 32) | Pow2.T06,

        rbp = (RegOffsets.RBP << 32) | Pow2.T06,

        r8 = (RegOffsets.R8 << 32) | Pow2.T06,

        r9 = (RegOffsets.R9 << 32) | Pow2.T06,
        
        r10 = (RegOffsets.R10 << 32) | Pow2.T06,

        r11 = (RegOffsets.R11 << 32) | Pow2.T06,

        r12 = (RegOffsets.R12 << 32) | Pow2.T06,

        r13 = (RegOffsets.R13 << 32) | Pow2.T06,

        r14 = (RegOffsets.R14 << 32) | Pow2.T06,

        r15 = (RegOffsets.R15 << 32) | Pow2.T06,
    
    }

}
