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
    using static inX;


    partial class InX
    {


        [MethodImpl(Inline)]
        public static Num128<double> sqrt(Num128<double> src)
            => Avx2.SqrtScalar(src);

        [MethodImpl(Inline)]
        public static Num128<float> sqrt(Num128<float> src)
            => Avx2.SqrtScalar(src);


        [MethodImpl(Inline)]
        public static Vec128<float> sqrt(Vec128<float> src)
            => Avx2.Sqrt(src);

        [MethodImpl(Inline)]
        public static Vec128<double> sqrt(Vec128<double> src)
            => Avx2.Sqrt(src);




    }

}