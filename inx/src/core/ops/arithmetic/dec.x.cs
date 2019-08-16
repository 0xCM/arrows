//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    


    partial class ginxs
    {
        public static Vec128<T> Dec<T>(this Vec128<T> src)
            where T : struct
                => ginx.dec(in src);

        public static Vec256<T> Dec<T>(this Vec256<T> src)
            where T : struct
                => ginx.dec(in src);

    }
}
