//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    [Flags]
    public enum MaskRegId : ulong
    {
        c0 = (RegOffsets.Mask << 32) | Pow2.T06,
        
        c1 = ((RegOffsets.Mask << 32) + 8) | Pow2.T06,

        c2 = ((RegOffsets.Mask << 32) + 16) | Pow2.T06,

        c3 = ((RegOffsets.Mask << 32) + 24) | Pow2.T06,

        c4 = ((RegOffsets.Mask << 32) + 32) | Pow2.T06,

        c5 = ((RegOffsets.Mask << 32) + 40) | Pow2.T06,

        c6 = ((RegOffsets.Mask << 32) + 48) | Pow2.T06,

        c7 = ((RegOffsets.Mask << 32) + 56) | Pow2.T06,

    }
}