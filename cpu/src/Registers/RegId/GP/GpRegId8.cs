//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;

    using static GpRegIdBase;
    using static RegIdOffset;

    [Flags,Info(Desc.RegIdInfo, Pow2.T03)]
    public enum GpRegId8 : ulong
    {
        /// <summary>
        /// Identifies RAX[7:0]
        /// </summary>
        al = Pow2.T32 | Pow2.T00,

        /// <summary>
        /// Identifies RAX[15:7]
        /// </summary>
        ah = Pow2.T33 | Pow2.T00,
        
        /// <summary>
        /// Identifies RBX[7:0]
        /// </summary>
        bl = ((ulong)Gp64Offsets.RBX << 32) | Pow2.T00,

        /// <summary>
        /// Identifies RBX[15:7]
        /// </summary>
        bh = ((ulong)Gp64Offsets.RBX << 33) | Pow2.T00,

        /// <summary>
        /// Identifies RCX[7:0]
        /// </summary>
        cl = ((ulong)Gp64Offsets.RCX << 32) | Pow2.T00,

        /// <summary>
        /// Identifies RCX[15:7]
        /// </summary>
        ch = ((ulong)Gp64Offsets.RCX << 33) | Pow2.T00,

        /// <summary>
        /// Identifies RDX[7:0]
        /// </summary>
        dl = ((ulong)Gp64Offsets.RDX << 32) | Pow2.T00,

        /// <summary>
        /// Identifies RDX[15:7]
        /// </summary>
        dh = ((ulong)Gp64Offsets.RDX << 33) | Pow2.T00,

        /// <summary>
        /// Identifies RSI[7:0]
        /// </summary>
        sil = ((ulong)Gp64Offsets.RSI << 32) | Pow2.T00,

        /// <summary>
        /// Identifies RDI[7:0]
        /// </summary>
        dil = ((ulong)Gp64Offsets.RDI << 32) | Pow2.T00,

        /// <summary>
        /// Identifies RBP[7:0]
        /// </summary>
        bpl = ((ulong)Gp64Offsets.RBP << 32) | Pow2.T00,

        /// <summary>
        /// Identifies RSP[7:0]
        /// </summary>
        spl = ((ulong)Gp64Offsets.RSP << 32) | Pow2.T00,

        r8b = ((ulong)Gp64Offsets.R8 << 32) | Pow2.T00,

        r9b = ((ulong)Gp64Offsets.R9 << 32) | Pow2.T00,

        r10b = ((ulong)Gp64Offsets.R10 << 32) | Pow2.T00,

        r11b = ((ulong)Gp64Offsets.R11 << 32) | Pow2.T00,

        r12b = ((ulong)Gp64Offsets.R12 << 32) | Pow2.T00,

        r13b = ((ulong)Gp64Offsets.R13 << 32) | Pow2.T00,

        r14b = ((ulong)Gp64Offsets.R14 << 32) | Pow2.T00,

        r15b = ((ulong)Gp64Offsets.R15 << 32) | Pow2.T00,

    }

}