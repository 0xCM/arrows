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

    
    [Flags,Info(Desc.RegIdInfo, BitWidth.Bw16)]
    public enum GpRegId16 : ulong
    {
        
        /// <summary>
        /// Identifies RAX[15:0]
        /// </summary>
        ax =  Pow2.T32 | Pow2.T01,  

        /// <summary>
        /// Identifies RBX[15:0]
        /// </summary>
        bx = ((ulong)Gp64Offsets.RBX << 32) | Pow2.T01,

        /// <summary>
        /// Identifies RCX[15:0]
        /// </summary>
        cx = ((ulong)Gp64Offsets.RCX << 32) | Pow2.T01,

        /// <summary>
        /// Identifies RDX[15:0]
        /// </summary>
        dx = ((ulong)Gp64Offsets.RDX << 32) | Pow2.T01,
        
        /// <summary>
        /// Identifies RSI[15:0]
        /// </summary>
        si  = ((ulong)Gp64Offsets.RSI << 32) | Pow2.T01,

        /// <summary>
        /// Identifies RDI[15:0]
        /// </summary>
        di = ((ulong)Gp64Offsets.RDI << 32) | Pow2.T01,

        /// <summary>
        /// Identifies RBP[15:0]
        /// </summary>
        bp = ((ulong)Gp64Offsets.RBP << 32) | Pow2.T01,

        /// <summary>
        /// Identifies RSP[15:0]
        /// </summary>
        sp = ((ulong)Gp64Offsets.RSP << 32) | Pow2.T01,

        r8w = ((ulong)Gp64Offsets.R8 << 32) | Pow2.T01,

        r9w = ((ulong)Gp64Offsets.R9 << 32) | Pow2.T01,

        r10w = ((ulong)Gp64Offsets.R10 << 32) | Pow2.T01,

        r11w = ((ulong)Gp64Offsets.R11 << 32) | Pow2.T01,

        r12w = ((ulong)Gp64Offsets.R12 << 32) | Pow2.T01,

        r13w = ((ulong)Gp64Offsets.R13 << 32) | Pow2.T01,

        r14w = ((ulong)Gp64Offsets.R14 << 32) | Pow2.T01,
 
        r15w = ((ulong)Gp64Offsets.R15 << 32) | Pow2.T01,
    }

}