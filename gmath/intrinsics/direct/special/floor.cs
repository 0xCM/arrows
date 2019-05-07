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
    using static global::mfunc;


    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<float> floor(Vec128<float> src)
            => Avx2.Floor(src);

        [MethodImpl(Inline)]
        public static Vec128<double> floor(Vec128<double> src)
            => Avx2.Floor(src);
        
        [MethodImpl(Inline)]
        public static Vec256<float> floor(Vec256<float> src)
            => Avx2.Floor(src);


        [MethodImpl(Inline)]
        public static Vec256<double> floor(Vec256<double> src)
            => Avx2.Floor(src);


    }

}