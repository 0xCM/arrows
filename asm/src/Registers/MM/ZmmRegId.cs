//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    

    /// <summary>
    ///  Classifies ZMM registers
    /// </summary>
    [Flags]
    public enum ZmmRegId : ulong
    {
        zmm0 = ((RegOffsets.ZMM << 32) + 0) | Pow2.T09,

        zmm1 = ((RegOffsets.ZMM << 32) + 8) | Pow2.T09,

        zmm2 = ((RegOffsets.ZMM << 32) + 16) | Pow2.T09,

        zmm3 = ((RegOffsets.ZMM << 32) + 24) | Pow2.T09,

        zmm4 =((RegOffsets.ZMM << 32) + 32) | Pow2.T09,

        zmm5 = ((RegOffsets.ZMM << 32) + 40) | Pow2.T09,

        zmm6 = ((RegOffsets.ZMM << 32) + 48) | Pow2.T09,

        zmm7 = ((RegOffsets.ZMM << 32) + 56) | Pow2.T09,

        zmm8 = ((RegOffsets.ZMM << 32) + 64) | Pow2.T09,

        zmm9 = ((RegOffsets.ZMM << 32) + 70) | Pow2.T09,

        zmm10 = ((RegOffsets.ZMM << 32) + 78) | Pow2.T09,

        zmm11 = ((RegOffsets.ZMM << 32) + 86) | Pow2.T09,

        zmm12 = ((RegOffsets.ZMM << 32) + 94) | Pow2.T09,

        zmm13 = ((RegOffsets.ZMM << 32) + 102) | Pow2.T09,

        zmm14 = ((RegOffsets.ZMM << 32) + 110) | Pow2.T09,

        zmm15 = ((RegOffsets.ZMM << 32) + 118) | Pow2.T09,

        zmm16 = ((RegOffsets.ZMM << 32) + 126) | Pow2.T09,

        zmm17 = ((RegOffsets.ZMM << 32) + 134) | Pow2.T09,

        zmm18 = ((RegOffsets.ZMM << 32) + 142) | Pow2.T09,

        zmm19 = ((RegOffsets.ZMM << 32) + 150) | Pow2.T09,

        zmm20 = ((RegOffsets.ZMM << 32) + 158) | Pow2.T09,

        zmm21 = ((RegOffsets.ZMM << 32) + 166) | Pow2.T09,

        zmm22 = ((RegOffsets.ZMM << 32) + 174) | Pow2.T09,

        zmm23 = ((RegOffsets.ZMM << 32) + 182) | Pow2.T09,

        zmm24 = ((RegOffsets.ZMM << 32) + 190) | Pow2.T09,

        zmm25 = ((RegOffsets.ZMM << 32) + 198) | Pow2.T09,

        zmm26 = ((RegOffsets.ZMM << 32) + 206) | Pow2.T09,

        zmm27 = ((RegOffsets.ZMM << 32) + 214) | Pow2.T09,

        zmm28 = ((RegOffsets.ZMM << 32) + 222) | Pow2.T09,

        zmm29 = ((RegOffsets.ZMM << 32) + 230) | Pow2.T09,

        zmm30 = ((RegOffsets.ZMM << 32) + 236) | Pow2.T09,

        zmm31 = ((RegOffsets.ZMM << 32) + 244) | Pow2.T09,
  }

}