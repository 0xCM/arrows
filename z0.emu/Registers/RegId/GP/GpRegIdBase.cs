//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using static Pow2;
 
    [Flags, Info(Desc.BaseRegId)]
    public enum GpRegIdBase : ulong
    {
        [Info(Desc.BaseRegIdLit, BitWidth.Bw8)]
        gpb8 = T30,

        [Info(Desc.BaseRegIdLit, BitWidth.Bw16)]
        gpb16 = T16,

        [Info(Desc.BaseRegIdLit, BitWidth.Bw32)]
        gpb32 = T17,
        
        [Info(Desc.BaseRegIdLit, BitWidth.Bw64)]
        gpb64 = T18,
                
        [Info(Desc.BaseRegIdLit, BitWidth.Bw128)]
        b128 = T31,
        
        [Info(Desc.BaseRegIdLit, BitWidth.Bw256)]
        b256 = T32,

        [Info(Desc.BaseRegIdLit, BitWidth.Bw512)]
        b512 = T33,



    }
}