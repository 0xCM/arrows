//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    
    using static RegIdOffset;
    using static Pow2;

    [Flags,Info(Desc.RegIdInfo, BitWidth.Bw64)]
    public enum MaskRegId : ulong
    {
        k0 = T07,
        
        k1 = T07 | offset1,

        k2 = T07 | offset2,

        k3 = T07 | offset3,

        k4 = T07 | offset4,

        k5 = T07 | offset5,

        k6 = T07 | offset6,

        k7 = T07 | offset7,

    }
}