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

    partial class InX    
    {
        // dst = x*y + z
        [MethodImpl(Inline)]
        public static Num128<float> muladd(in Num128<float> x, in Num128<float> y, in Num128<float> z)
            => Fma.MultiplyAddScalar(x,y,z);

        
        // dst = x*y + z
        [MethodImpl(Inline)]
        public static Num128<double> muladd(in Num128<double> x, in Num128<double> y, in Num128<double> z)
            => Fma.MultiplyAddScalar(x,y,z);

        // dst = x*y + z
        [MethodImpl(Inline)]
        public static Vec128<float> muladd(in Vec128<float> x, in Vec128<float> y, in Vec128<float> z)
            => Fma.MultiplyAdd(x,y,z);

        
        // dst = x*y + z
        [MethodImpl(Inline)]
        public static Vec128<double> muladd(in Vec128<double> x, in Vec128<double> y, in Vec128<double> z)
            => Fma.MultiplyAdd(x,y,z);

    }

}