//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    
    using static Pow2;
    using static GpRegIdBase;
    using static RegIdOffset;

    [Flags,Info(Desc.RegIdInfo, Pow2.T05)]
    public enum GpRegId32 : ulong
    {
        /// <summary>
        /// Identifies RAX[31:0]
        /// </summary>
        eax =  Pow2.T32 | Pow2.T02,  
        
        /// <summary>
        /// Identifies RBX[31:0]
        /// </summary>
        ebx = ((ulong)Gp64Offsets.RBX << 32) | Pow2.T02,

        /// <summary>
        /// Identifies RCX[31:0]
        /// </summary>
        ecx =  ((ulong)Gp64Offsets.RCX << 32) | Pow2.T02,

        /// <summary>
        /// Identifies EDX[31:0]
        /// </summary>
        edx =  ((ulong)Gp64Offsets.RDX << 32) | Pow2.T02,

        /// <summary>
        /// Identifies RSI[31:0]
        /// </summary>
        esi =  ((ulong)Gp64Offsets.RSI << 32) | Pow2.T02,

        /// <summary>
        /// Identifies RDI[31:0]
        /// </summary>
        edi =  ((ulong)Gp64Offsets.RDI << 32) | Pow2.T02,

        /// <summary>
        /// Identifies RSP[31:0]
        /// </summary>
        esp =  ((ulong)Gp64Offsets.RSP << 32) | Pow2.T02,

        /// <summary>
        /// Identifies RBP[31:0]
        /// </summary>
        ebp =  ((ulong)Gp64Offsets.RBP << 32) | Pow2.T02,

        r8d = ((ulong)Gp64Offsets.R8 << 32) | Pow2.T02,

        r9d = ((ulong)Gp64Offsets.R9 << 32) | Pow2.T02,

        r10d = ((ulong)Gp64Offsets.R10 << 32) | Pow2.T02,

        r11d = ((ulong)Gp64Offsets.R11 << 32) | Pow2.T02,

        r12d = ((ulong)Gp64Offsets.R12 << 32) | Pow2.T02,

        r13d = ((ulong)Gp64Offsets.R13 << 32) | Pow2.T02,

        r14d = ((ulong)Gp64Offsets.R14 << 32) | Pow2.T02,

        r15d = ((ulong)Gp64Offsets.R15 << 32) | Pow2.T02,

    }
}
