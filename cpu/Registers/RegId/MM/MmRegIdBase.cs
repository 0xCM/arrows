//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using static Pow2;
 
    [Flags, Info(Desc.BaseRegId)]
    public enum MmRegIdBase : ulong
    {
                
        [Info(Desc.BaseRegIdLit, BitWidth.Bw128)]
        bmm128 = T31,
        
        [Info(Desc.BaseRegIdLit, BitWidth.Bw256)]
        bmm256 = T32,

        [Info(Desc.BaseRegIdLit, BitWidth.Bw512)]
        bmm512 = T33,


    }
}