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
    using static inxfunc;


    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Num128<float> recipsqrt(Num128<float> src)
            => Avx2.ReciprocalSqrtScalar(src);

        [MethodImpl(Inline)]
        public static Vec128<float> recipsqrt(Vec128<float> src)
            => Avx2.ReciprocalSqrt(src);
    }

}