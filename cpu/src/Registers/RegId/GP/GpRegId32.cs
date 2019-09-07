//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Classifies 32-bit general purpose registers
    /// </summary>
    [Flags]
    public enum GpRegId32 : ulong
    {
        /// <summary>
        /// Identifies RAX[31:0]
        /// </summary>
        eax =  Pow2.T32 | Pow2.T05,  
        
        /// <summary>
        /// Identifies RBX[31:0]
        /// </summary>
        ebx = (RegOffsets.RBX << 32) | Pow2.T05,

        /// <summary>
        /// Identifies RCX[31:0]
        /// </summary>
        ecx =  (RegOffsets.RCX << 32) | Pow2.T05,

        /// <summary>
        /// Identifies EDX[31:0]
        /// </summary>
        edx =  (RegOffsets.RDX << 32) | Pow2.T05,

        /// <summary>
        /// Identifies RSI[31:0]
        /// </summary>
        esi =  (RegOffsets.RSI << 32) | Pow2.T05,

        /// <summary>
        /// Identifies RDI[31:0]
        /// </summary>
        edi =  (RegOffsets.RDI << 32) | Pow2.T05,

        /// <summary>
        /// Identifies RSP[31:0]
        /// </summary>
        esp =  (RegOffsets.RSP << 32) | Pow2.T05,

        /// <summary>
        /// Identifies RBP[31:0]
        /// </summary>
        ebp =  (RegOffsets.RBP << 32) | Pow2.T05,

        /// <summary>
        /// Identifies R8[31:0]
        /// </summary>
        r8d = (RegOffsets.R8 << 32) | Pow2.T05,

        /// <summary>
        /// Identifies R9[31:0]
        /// </summary>
        r9d = (RegOffsets.R9 << 32) | Pow2.T05,

        /// <summary>
        /// Identifies R10[31:0]
        /// </summary>
        r10d = (RegOffsets.R10 << 32) | Pow2.T05,

        /// <summary>
        /// Identifies R11[31:0]
        /// </summary>
        r11d = (RegOffsets.R11 << 32) | Pow2.T05,

        /// <summary>
        /// Identifies R12[31:0]
        /// </summary>
        r12d = (RegOffsets.R12 << 32) | Pow2.T05,

        /// <summary>
        /// Identifies R13[31:0]
        /// </summary>
        r13d = (RegOffsets.R13 << 32) | Pow2.T05,

        /// <summary>
        /// Identifies R14[31:0]
        /// </summary>
        r14d = (RegOffsets.R14 << 32) | Pow2.T05,

        /// <summary>
        /// Identifies R15[31:0]
        /// </summary>
        r15d = (RegOffsets.R15 << 32) | Pow2.T05,

    }
}
