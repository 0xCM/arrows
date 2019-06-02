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
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Avx;
        
    using static zfunc;    

    partial class dinx
    {


        [MethodImpl(Inline)]
        public static Vec128<float> recip(Vec128<float> src)
            => Reciprocal(src);


        [MethodImpl(Inline)]
        public static Vec256<float> recip(Vec256<float> src)
            => Reciprocal(src);


    }

}