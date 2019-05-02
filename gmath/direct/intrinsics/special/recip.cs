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
        public static Num128<float> recip(Num128<float> src)
            => Avx2.ReciprocalScalar(src);

        [MethodImpl(Inline)]
        public static Vec128<float> recip(Vec128<float> src)
            => Avx2.Reciprocal(src);


        [MethodImpl(Inline)]
        public static Vec256<float> recip(Vec256<float> src)
            => Avx2.Reciprocal(src);


    }

}