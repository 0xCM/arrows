//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    
    /// <summary>
    /// Classifies 16-bit general purpose registers
    /// </summary>
    [Flags]
    public enum GpRegId16 : ulong
    {        
        /// <summary>
        /// Identifies RAX[15:0] or EAX[15:0]
        /// </summary>
        ax =  (RegOffsets.RAX << 32) | Pow2.T04,  

        /// <summary>
        /// Identifies RBX[15:0] or EBX[15:0]
        /// </summary>
        bx = (RegOffsets.RBX << 32) | Pow2.T04,

        /// <summary>
        /// Identifies RCX[15:0] or ECX[15:0]
        /// </summary>
        cx = (RegOffsets.RCX << 32) | Pow2.T04,

        /// <summary>
        /// Identifies RDX[15:0] or EDX[15:0]
        /// </summary>
        dx = (RegOffsets.RDX << 32) | Pow2.T04,
        
        /// <summary>
        /// Identifies RSI[15:0] or ESI[15:0]
        /// </summary>
        si  = (RegOffsets.RSI << 32) | Pow2.T04,


        /// <summary>
        /// Identifies RDI[15:0] or EDI[15:0]
        /// </summary>
        di = (RegOffsets.RDI << 32) | Pow2.T04,

        /// <summary>
        /// Identifies RBP[15:0] or EBP[15:0]
        /// </summary>
        bp = (RegOffsets.RBP << 32) | Pow2.T04,

        /// <summary>
        /// Identifies RSP[15:0] or ESP[15:0]
        /// </summary>
        sp = (RegOffsets.RSP << 32) | Pow2.T04,

        /// <summary>
        /// Identifies R8[15:0] or R8d[15:0]
        /// </summary>
        r8w = (RegOffsets.R8 << 32) | Pow2.T04,

        /// <summary>
        /// Identifies R9[15:0] or R9d[15:0]
        /// </summary>
        r9w = (RegOffsets.R9 << 32) | Pow2.T04,

        /// <summary>
        /// Identifies R10[15:0] or R10d[15:0]
        /// </summary>
        r10w = (RegOffsets.R10 << 32) | Pow2.T04,

        /// <summary>
        /// Identifies R11[15:0] or R11d[15:0]
        /// </summary>
        r11w = (RegOffsets.R11 << 32) | Pow2.T04,

        /// <summary>
        /// Identifies R12[15:0] or R12d[15:0]
        /// </summary>
        r12w = (RegOffsets.R12 << 32) | Pow2.T04,

        /// <summary>
        /// Identifies R13[15:0] or R13d[15:0]
        /// </summary>
        r13w = (RegOffsets.R13 << 32) | Pow2.T04,

        /// <summary>
        /// Identifies R14[15:0] or R14d[15:0]
        /// </summary>
        r14w = (RegOffsets.R14 << 32) | Pow2.T04,
 
        /// <summary>
        /// Identifies R15[15:0] or R15d[15:0]
        /// </summary>
        r15w = (RegOffsets.R15 << 32) | Pow2.T04,
    }

}