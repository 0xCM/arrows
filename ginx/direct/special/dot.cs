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
    using static System.Runtime.Intrinsics.X86.Sse41;    
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static zfunc;    

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<float> dot(Vec128<float> lhs, Vec128<float> rhs)
            => DotProduct(lhs, rhs,0);
        
        [MethodImpl(Inline)]
        public static Vec128<double> dot(Vec128<double> lhs, Vec128<double> rhs)
            => DotProduct(lhs, rhs,0);

        [MethodImpl(Inline)]
        public static Vec256<float> dot(Vec256<float> lhs, Vec256<float> rhs)
            => DotProduct(lhs, rhs,0);

        [MethodImpl(Inline)]
        public static void dot(Vec128<float> lhs, Vec128<float> rhs, ref float dst)
            => store(DotProduct(lhs, rhs,0), ref dst);
        
        [MethodImpl(Inline)]
        public static void dot(Vec128<double> lhs, Vec128<double> rhs, ref double dst)
            => store(DotProduct(lhs, rhs,0), ref dst);

        [MethodImpl(Inline)]
        public static void dot(Vec256<float> lhs, Vec256<float> rhs, ref float dst)
            => store(DotProduct(lhs, rhs,0), ref dst);


    }

}