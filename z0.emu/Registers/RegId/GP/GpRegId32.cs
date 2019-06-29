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

    [Flags,Info(Desc.RegIdInfo, BitWidth.Bw32)]
    public enum GpRegId32 : ulong
    {
        eax = gpb32,
        
        ebx = gpb32 | offset1,

        ecx = gpb32 | offset2,

        edx = gpb32 | offset3,

        esi = gpb32 | offset4,

        edi = gpb32 | offset5,

        ebp = gpb32 | offset6,

        esp = gpb32 | offset7,

        r8d = gpb32 | offset8,

        r9d = gpb32 | offset9,

        r10d = gpb32 | offset10,

        r11d = gpb32 | offset11,

        r12d = gpb32 | offset12,

        r13d = gpb32 | offset13,

        r14d = gpb32 | offset14,

        r15d = gpb32 | offset15,

    }
}
