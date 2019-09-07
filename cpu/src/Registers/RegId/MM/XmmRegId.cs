//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    ///  Classifies XMM registers
    /// </summary>
    [Flags]
    public enum XmmRegId : ulong
    {
        xmm0 = ((RegOffsets.XMM << 32) + 0) | Pow2.T07,

        xmm1 = ((RegOffsets.XMM << 32) + 8) | Pow2.T07,

        xmm2 = ((RegOffsets.XMM << 32) + 16) | Pow2.T07,

        xmm3 = ((RegOffsets.XMM << 32) + 24) | Pow2.T07,

        xmm4 =((RegOffsets.XMM << 32) + 32) | Pow2.T07,

        xmm5 = ((RegOffsets.XMM << 32) + 40) | Pow2.T07,

        xmm6 = ((RegOffsets.XMM << 32) + 48) | Pow2.T07,

        xmm7 = ((RegOffsets.XMM << 32) + 56) | Pow2.T07,

        xmm8 = ((RegOffsets.XMM << 32) + 64) | Pow2.T07,

        xmm9 = ((RegOffsets.XMM << 32) + 70) | Pow2.T07,

        xmm10 = ((RegOffsets.XMM << 32) + 78) | Pow2.T07,

        xmm11 = ((RegOffsets.XMM << 32) + 86) | Pow2.T07,

        xmm12 = ((RegOffsets.XMM << 32) + 94) | Pow2.T07,

        xmm13 = ((RegOffsets.XMM << 32) + 102) | Pow2.T07,

        xmm14 = ((RegOffsets.XMM << 32) + 110) | Pow2.T07,

        xmm15 = ((RegOffsets.XMM << 32) + 118) | Pow2.T07,

        xmm16 = ((RegOffsets.XMM << 32) + 126) | Pow2.T07,

        xmm17 = ((RegOffsets.XMM << 32) + 134) | Pow2.T07,

        xmm18 = ((RegOffsets.XMM << 32) + 142) | Pow2.T07,

        xmm19 = ((RegOffsets.XMM << 32) + 150) | Pow2.T07,

        xmm20 = ((RegOffsets.XMM << 32) + 158) | Pow2.T07,

        xmm21 = ((RegOffsets.XMM << 32) + 166) | Pow2.T07,

        xmm22 = ((RegOffsets.XMM << 32) + 174) | Pow2.T07,

        xmm23 = ((RegOffsets.XMM << 32) + 182) | Pow2.T07,

        xmm24 = ((RegOffsets.XMM << 32) + 190) | Pow2.T07,

        xmm25 = ((RegOffsets.XMM << 32) + 198) | Pow2.T07,

        xmm26 = ((RegOffsets.XMM << 32) + 206) | Pow2.T07,

        xmm27 = ((RegOffsets.XMM << 32) + 214) | Pow2.T07,

        xmm28 = ((RegOffsets.XMM << 32) + 222) | Pow2.T07,

        xmm29 = ((RegOffsets.XMM << 32) + 230) | Pow2.T07,

        xmm30 = ((RegOffsets.XMM << 32) + 236) | Pow2.T07,

        xmm31 = ((RegOffsets.XMM << 32) + 244) | Pow2.T07,

    }
}