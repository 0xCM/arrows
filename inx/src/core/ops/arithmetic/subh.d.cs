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
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;

    public partial class dinx
    {
        
        /// <summary>
        /// _mm_hsub_epi16
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec128<short> hsub(in Vec128<short> lhs, in Vec128<short> rhs)
            => HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> hsub(in Vec128<int> lhs, in Vec128<int> rhs)
            => HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> hsub(in Vec128<float> lhs, in Vec128<float> rhs)
            => HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> hsub(in Vec128<double> lhs, in Vec128<double> rhs)
            => HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> subh(in Vec256<short> lhs, in Vec256<short> rhs)
            => HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> hsub(in Vec256<int> lhs, in Vec256<int> rhs)
            => HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> hsub(in Vec256<float> lhs, in Vec256<float> rhs)
            => HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> hsub(in Vec256<double> lhs, in Vec256<double> rhs)
            => HorizontalSubtract(lhs, rhs);



    }
}