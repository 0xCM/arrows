//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;


    /// <summary>
    /// Classifies 8-bit general purpose registers
    /// </summary>
    [Flags]
    public enum GpRegId8 : ulong
    {
        /// <summary>
        /// Identifies RAX[7:0]
        /// </summary>
        al = (RegOffsets.RAX << 32) | Pow2.T03,

        /// <summary>
        /// Identifies RAX[15:7]
        /// </summary>
        ah =  ((RegOffsets.RAX << 32) + 4)  | Pow2.T03,
        
        /// <summary>
        /// Identifies RBX[7:0]
        /// </summary>
        bl = (RegOffsets.RBX << 32) | Pow2.T03,

        /// <summary>
        /// Identifies RBX[15:7]
        /// </summary>
        bh = ((RegOffsets.RBX << 32) + 4) | Pow2.T03,

        /// <summary>
        /// Identifies RCX[7:0]
        /// </summary>
        cl = (RegOffsets.RCX << 32) | Pow2.T03,

        /// <summary>
        /// Identifies RCX[15:7]
        /// </summary>
        ch = ((RegOffsets.RCX << 32) + 4) | Pow2.T03,

        /// <summary>
        /// Identifies RDX[7:0]
        /// </summary>
        dl = (RegOffsets.RDX << 32) | Pow2.T03,

        /// <summary>
        /// Identifies RDX[15:7]
        /// </summary>
        dh = ((RegOffsets.RDX << 32) + 4)| Pow2.T03,

        /// <summary>
        /// Identifies RSI[7:0]
        /// </summary>
        sil = (RegOffsets.RSI << 32) | Pow2.T03,

        /// <summary>
        /// Identifies RDI[7:0]
        /// </summary>
        dil = (RegOffsets.RDI << 32) | Pow2.T03,

        /// <summary>
        /// Identifies RBP[7:0]
        /// </summary>
        bpl = (RegOffsets.RBP << 32) | Pow2.T03,

        /// <summary>
        /// Identifies RSP[7:0]
        /// </summary>
        spl = (RegOffsets.RSP << 32) | Pow2.T03,

        r8b = (RegOffsets.R8 << 32) | Pow2.T03,

        r9b = (RegOffsets.R9 << 32) | Pow2.T03,

        r10b = (RegOffsets.R10 << 32) | Pow2.T03,

        r11b = (RegOffsets.R11 << 32) | Pow2.T03,

        r12b = (RegOffsets.R12 << 32) | Pow2.T03,

        r13b = (RegOffsets.R13 << 32) | Pow2.T03,

        r14b = (RegOffsets.R14 << 32) | Pow2.T03,

        r15b = (RegOffsets.R15 << 32) | Pow2.T03,

    }

}