//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    
    using static GpRegIdBase;
    using static RegIdOffset;
    using static Pow2;


    [Flags,Info(Desc.RegIdInfo, BitWidth.Bw64)]
    public enum ControlRegId : ulong
    {
        c0 = T15,
        
        c1 = T15 | offset1,

        c2 = T15 | offset2,

        c3 = T15 | offset3,

        c4 = T15 | offset4,

        c5 = T15 | offset5,

        c6 = T15 | offset6,

        c7 = T15 | offset7,

        c8 = T15 | offset8,

        c9 = T15 | offset9,

        c10 = T15 | offset10,

        c11 = T15 | offset11,

        c12 = T15 | offset12,

        c13 = T15 | offset13,

        c14 = T15 | offset14,

        c15 = T15 | offset15,

    }
}