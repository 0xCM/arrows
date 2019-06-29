//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;

    using static MmRegIdBase;
    using static RegIdOffset;

    [Flags,Info(Desc.RegIdInfo, BitWidth.Bw128)]
    public enum XmmRegId : ulong
    {
        xmm0 = bmm128,

        xmm1 = bmm128 | offset1,

        xmm2 = bmm128 | offset2,

        xmm3 = bmm128 | offset3,

        xmm4 = bmm128 | offset4,

        xmm5 = bmm128 | offset5,

        xmm6 = bmm128 | offset6,

        xmm7 = bmm128 | offset7,

        xmm8 = bmm128 | offset8,

        xmm9 = bmm128 | offset9,

        xmm10 = bmm128 | offset10,

        xmm11 = bmm128 | offset11,

        xmm12 = bmm128 | offset12,

        xmm13 = bmm128 | offset13,

        xmm14 = bmm128 | offset14,

        xmm15 = bmm128 | offset15,

        xmm16 = bmm128 | offset16,

        xmm17 = bmm128 | offset17,

        xmm18 = bmm128 | offset18,

        xmm19 = bmm128 | offset19,

        xmm20 = bmm128 | offset20,

        xmm21 = bmm128 | offset21,

        xmm22 = bmm128 | offset22,

        xmm23 = bmm128 | offset23,

        xmm24 = bmm128 | offset24,

        xmm25 = bmm128 | offset25,

        xmm26 = bmm128 | offset26,

        xmm27 = bmm128 | offset27,

        xmm28 = bmm128 | offset28,

        xmm29 = bmm128 | offset29,

        xmm30 = bmm128 | offset30,

        xmm31 = bmm128 | offset31,

    }
}