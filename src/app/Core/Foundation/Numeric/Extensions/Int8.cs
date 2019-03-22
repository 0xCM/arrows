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

    using systype = System.SByte;
    using opstype = Int8Ops;


    public static class Int8X
    {
        public static string ToBitString(this systype src)
                => lpadZ(Convert.ToString(src,2), opstype.MaxBitLength);

    }
}