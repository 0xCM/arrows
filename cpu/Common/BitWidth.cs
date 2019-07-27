//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;

    using static Pow2;
    using static zfunc;

    [Flags]
    public enum BitWidth : uint
    {
        BW1 = T00,
        
        Bw2 = T01,
        
        Bw4 = T02,

        Bw8 = T03,

        Bw16 = T04,

        Bw32 = T05,

        Bw64 = T06,

        Bw128 = T07,

        Bw256 = T08,

        Bw512 = T09,

        Bw1024 = T10,

    }

}