//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using static zfunc;

    public static partial class Vec256
    {

        [MethodImpl(Inline)]
        public static Vec256<T> zero<T>() 
            where T : struct
                => Vec256<T>.Zero;

    } 
}