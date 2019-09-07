//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;
    using System.Reflection.Emit;

    using static zfunc;

    public enum ModCode : byte
    {
        M00 = 0b00,
        
        M01 = 0b01,

        M10 = 0b10,

        M11 = 0b11
    }



}