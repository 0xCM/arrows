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
        public static Vec128<double> sqrt(Scalar128<double> src)
            => Sse42.SqrtScalar(src);

        [MethodImpl(Inline)]
        public static Vec128<float> sqrt(Scalar128<float> src)
            => Sse42.SqrtScalar(src);

        [MethodImpl(Inline)]
        public static Vec128<float> recipsqrt(Scalar128<float> src)
            => Sse42.ReciprocalSqrtScalar(src);

        [MethodImpl(Inline)]
        public static Vec128<float> sqrt(Vec128<float> src)
            => Sse42.Sqrt(src);

        [MethodImpl(Inline)]
        public static Vec128<double> sqrt(Vec128<double> src)
            => Sse42.Sqrt(src);


        [MethodImpl(Inline)]
        public static Vec128<float> recipsqrt(Vec128<float> src)
            => Sse42.ReciprocalSqrt(src);



    }

}