//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    
    using static MmRegIdBase;
    using static RegIdOffset;

    [Flags,Info(Desc.RegIdInfo, BitWidth.Bw256)]
    public enum YmmRegId : ulong
    {
        ymm0 = bmm256,

        ymm1 = bmm256 | offset1,

        ymm2 = bmm256 | offset2,

        ymm3 = bmm256 | offset3,

        ymm4 = bmm256 | offset4,

        ymm5 = bmm256 | offset5,

        ymm6 = bmm256 | offset6,

        ymm7 = bmm256 | offset7,

        ymm8 = bmm256 | offset8,

        ymm9 = bmm256 | offset9,

        ymm10 = bmm256 | offset10,

        ymm11 = bmm256 | offset11,

        ymm12 = bmm256 | offset12,

        ymm13 = bmm256 | offset13,

        ymm14 = bmm256 | offset14,

        ymm15 = bmm256 | offset15,

        ymm16 = bmm256 | offset16,

        ymm17 = bmm256 | offset17,

        ymm18 = bmm256 | offset18,

        ymm19 = bmm256 | offset19,

        ymm20 = bmm256 | offset20,

        ymm21 = bmm256 | offset21,

        ymm22 = bmm256 | offset22,

        ymm23 = bmm256 | offset23,

        ymm24 = bmm256 | offset24,

        ymm25 = bmm256 | offset25,

        ymm26 = bmm256 | offset26,

        ymm27 = bmm256 | offset27,

        ymm28 = bmm256 | offset28,

        ymm29 = bmm256 | offset29,

        ymm30 = bmm256 | offset30,

        ymm31 = bmm256 | offset31,

    }

}