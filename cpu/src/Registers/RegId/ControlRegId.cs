//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    

    [Flags]
    public enum ControlRegId : ulong
    {
        c0 = (RegOffsets.Control << 32) | Pow2.T06,
        
        c1 = ((RegOffsets.Control << 32) + 8) | Pow2.T06,

        c2 = ((RegOffsets.Control << 32) + 16) | Pow2.T06,

        c3 = ((RegOffsets.Control << 32) + 24) | Pow2.T06,

        c4 = ((RegOffsets.Control << 32) + 32) | Pow2.T06,

        c5 = ((RegOffsets.Control << 32) + 40) | Pow2.T06,

        c6 = ((RegOffsets.Control << 32) + 48) | Pow2.T06,

        c7 = ((RegOffsets.Control << 32) + 56) | Pow2.T06,

        c8 = ((RegOffsets.Control << 32) + 64) | Pow2.T06,

        c9 = ((RegOffsets.Control << 32) + 72) | Pow2.T06,

        c10 = ((RegOffsets.Control << 32) + 80) | Pow2.T06,

        c11 = ((RegOffsets.Control << 32) + 88) | Pow2.T06,

        c12 = ((RegOffsets.Control << 32) + 96) | Pow2.T06,

        c13 = ((RegOffsets.Control << 32) + 104) | Pow2.T06,

        c14 = ((RegOffsets.Control << 32) + 112) | Pow2.T06,

        c15 = ((RegOffsets.Control << 32) + 120) | Pow2.T06,

    }
}