//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static corefunc;

    using static Traits;
    using systype = System.UInt64;
    using opstype = UInt64Ops;


    public static class UInt64
    {
        public static string ToBitString(this systype src)
            => map(Bits.split(src), 
                    parts => parts.hi.ToBitString() 
                           + parts.lo.ToBitString());

    }

}