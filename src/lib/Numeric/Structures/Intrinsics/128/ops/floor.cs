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
    
    using static zcore;
    using static x86;

    partial class Vec128
    {

        [MethodImpl(Inline)]
        public static Vec128<float> floor(Vec128<float> src)
            => Sse41.Floor(src);
        
        [MethodImpl(Inline)]
        public static Vec128<double> floor(Vec128<double> src)
            => Sse41.Floor(src);


    }

}