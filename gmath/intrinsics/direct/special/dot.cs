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
    
    
    using static mfunc;

    partial class dinx
    {


        [MethodImpl(Inline)]
        public static Vec128<float> dot(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.DotProduct(lhs, rhs,0);
        
        [MethodImpl(Inline)]
        public static Vec128<double> dot(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.DotProduct(lhs, rhs,0);

        [MethodImpl(Inline)]
        public static Vec256<float> dot(Vec256<float> lhs, Vec256<float> rhs)
            => Avx2.DotProduct(lhs, rhs,0);
        

    }

}