//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    
    using static MmRegIdBase;
    using static RegIdOffset;


    [Flags,Info(Desc.RegIdInfo, BitWidth.Bw512)]
    public enum ZmmRegId : ulong
    {
        zmm0 = bmm512,

        zmm1 = bmm512 | offset1,

        zmm2 = bmm512 | offset2,

        zmm3 = bmm512 | offset3,

        zmm4 = bmm512 | offset4,

        zmm5 = bmm512 | offset5,

        zmm6 = bmm512 | offset6,

        zmm7 = bmm512 | offset7,

        zmm8 = bmm512 | offset8,

        zmm9 = bmm512 | offset9,

        zmm10 = bmm512 | offset10,

        zmm11 = bmm512 | offset11,

        zmm12 = bmm512 | offset12,

        zmm13 = bmm512 | offset13,

        zmm14 = bmm512 | offset14,

        zmm15 = bmm512 | offset15,

        zmm16 = bmm512 | offset16,

        zmm17 = bmm512 | offset17,

        zmm18 = bmm512 | offset18,

        zmm19 = bmm512 | offset19,

        zmm20 = bmm512 | offset20,

        zmm21 = bmm512 | offset21,

        zmm22 = bmm512 | offset22,

        zmm23 = bmm512 | offset23,

        zmm24 = bmm512 | offset24,

        zmm25 = bmm512 | offset25,

        zmm26 = bmm512 | offset26,

        zmm27 = bmm512 | offset27,

        zmm28 = bmm512 | offset28,

        zmm29 = bmm512 | offset29,

        zmm30 = bmm512 | offset30,

        zmm31 = bmm512 | offset31,
  }

}