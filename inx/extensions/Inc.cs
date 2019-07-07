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

    public static class IncX
    {
        public static Vec128<T> Inc<T>(in this Vec128<T> src)
            where T : struct
                => ginx.inc(in src);
        public static Vec256<T> Inc<T>(in this Vec256<T> src)
            where T : struct
                => ginx.inc(in src);
    }
}
