//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    ///  Classifies YMM registers
    /// </summary>
    [Flags]
    public enum YmmRegId : ulong
    {
        ymm0 = ((RegOffsets.YMM << 32) + 0) | Pow2.T08,

        ymm1 = ((RegOffsets.YMM << 32) + 8) | Pow2.T08,

        ymm2 = ((RegOffsets.YMM << 32) + 16) | Pow2.T08,

        ymm3 = ((RegOffsets.YMM << 32) + 24) | Pow2.T08,

        ymm4 =((RegOffsets.YMM << 32) + 32) | Pow2.T08,

        ymm5 = ((RegOffsets.YMM << 32) + 40) | Pow2.T08,

        ymm6 = ((RegOffsets.YMM << 32) + 48) | Pow2.T08,

        ymm7 = ((RegOffsets.YMM << 32) + 56) | Pow2.T08,

        ymm8 = ((RegOffsets.YMM << 32) + 64) | Pow2.T08,

        ymm9 = ((RegOffsets.YMM << 32) + 70) | Pow2.T08,

        ymm10 = ((RegOffsets.YMM << 32) + 78) | Pow2.T08,

        ymm11 = ((RegOffsets.YMM << 32) + 86) | Pow2.T08,

        ymm12 = ((RegOffsets.YMM << 32) + 94) | Pow2.T08,

        ymm13 = ((RegOffsets.YMM << 32) + 102) | Pow2.T08,

        ymm14 = ((RegOffsets.YMM << 32) + 110) | Pow2.T08,

        ymm15 = ((RegOffsets.YMM << 32) + 118) | Pow2.T08,

        ymm16 = ((RegOffsets.YMM << 32) + 126) | Pow2.T08,

        ymm17 = ((RegOffsets.YMM << 32) + 134) | Pow2.T08,

        ymm18 = ((RegOffsets.YMM << 32) + 142) | Pow2.T08,

        ymm19 = ((RegOffsets.YMM << 32) + 150) | Pow2.T08,

        ymm20 = ((RegOffsets.YMM << 32) + 158) | Pow2.T08,

        ymm21 = ((RegOffsets.YMM << 32) + 166) | Pow2.T08,

        ymm22 = ((RegOffsets.YMM << 32) + 174) | Pow2.T08,

        ymm23 = ((RegOffsets.YMM << 32) + 182) | Pow2.T08,

        ymm24 = ((RegOffsets.YMM << 32) + 190) | Pow2.T08,

        ymm25 = ((RegOffsets.YMM << 32) + 198) | Pow2.T08,

        ymm26 = ((RegOffsets.YMM << 32) + 206) | Pow2.T08,

        ymm27 = ((RegOffsets.YMM << 32) + 214) | Pow2.T08,

        ymm28 = ((RegOffsets.YMM << 32) + 222) | Pow2.T08,

        ymm29 = ((RegOffsets.YMM << 32) + 230) | Pow2.T08,

        ymm30 = ((RegOffsets.YMM << 32) + 236) | Pow2.T08,

        ymm31 = ((RegOffsets.YMM << 32) + 244) | Pow2.T08,

    }

}