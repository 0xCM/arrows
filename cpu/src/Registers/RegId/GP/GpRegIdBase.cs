//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using static Pow2;
 
    [Flags]
    public enum GpRegIdBase : ulong
    {
        gpb8 = T30,

        gpb16 = T16,

        gpb32 = T17,
        
        gpb64 = T18,
                
        b128 = T31,
        
        b256 = T32,

        b512 = T33,



    }
}