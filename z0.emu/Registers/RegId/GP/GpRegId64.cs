//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    
    using static GpRegIdBase;
    using static RegIdOffset;


    [Flags,Info(Desc.RegIdInfo, BitWidth.Bw64)]
    public enum GpRegId64 : ulong
    {
        rax = gpb64,

        rbx = gpb64 | offset1,

        rcx = gpb64 | offset2,

        rdx = gpb64 | offset3,

        rsi = gpb64 | offset4,

        rdi = gpb64 | offset5,

        rbp = gpb64 | offset6,

        rsp = gpb64 | offset7,

        r8 = gpb64 | offset8,

        r9 = gpb64 | offset9,
        
        r10 = gpb64 | offset10,

        r11 = gpb64 | offset11,

        r12 = gpb64 | offset12,

        r13 = gpb64 | offset13,

        r14 = gpb64 | offset14,

        r15 = gpb64 | offset15,


    }

}
