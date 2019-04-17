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
        // dst = x*y + z
        [MethodImpl(Inline)]
        public static Vec128<float> muladd(Num128<float> x, Num128<float> y, Num128<float> z)
            => Fma.MultiplyAddScalar(x,y,z);

        
        // dst = x*y + z
        [MethodImpl(Inline)]
        public static Vec128<double> muladd(Num128<double> x, Num128<double> y, Num128<double> z)
            => Fma.MultiplyAddScalar(x,y,z);

        // dst = x*y + z
        [MethodImpl(Inline)]
        public static Vec128<float> muladd(Vec128<float> x, Vec128<float> y, Vec128<float> z)
            => Fma.MultiplyAdd(x,y,z);

        
        // dst = x*y + z
        [MethodImpl(Inline)]
        public static Vec128<double> muladd(Vec128<double> x, Vec128<double> y, Vec128<double> z)
            => Fma.MultiplyAdd(x,y,z);

    }

}