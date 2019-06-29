//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;

    using static GpRegIdBase;
    using static RegIdOffset;

    [Flags,Info(Desc.RegIdInfo, BitWidth.Bw8)]
    public enum GpRegId8 : ulong
    {
        al = gpb8,    

        ah = gpb8 | offset16,        
        
        bl = gpb8 | offset1,    

        bh = gpb8 | offset17,    

        cl = gpb8 | offset2,

        ch = gpb8 | offset17,

        dl = gpb8 | offset3,

        dh = gpb8 | offset18,

        sil = gpb8 | offset4,

        dil = gpb8 | offset5,

        bpl = gpb8 | offset6,

        spl = gpb8 | offset7,

        r8b = gpb8 | offset8,

        r9b = gpb8 | offset9,

        r10b = gpb8 | offset10,

        r11b = gpb8 | offset11,

        r12b= gpb8 | offset12,

        r13b = gpb8 | offset13,

        r14b = gpb8 | offset14,

        r15b = gpb8 | offset15,

    }

}