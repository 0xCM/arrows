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
        
        [MethodImpl(Inline)]
        public static Vec128<short> subh(in Vec128<short> lhs, in Vec128<short> rhs)
            => HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> subh(in Vec128<int> lhs, in Vec128<int> rhs)
            => HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> subh(in Vec128<float> lhs, in Vec128<float> rhs)
            => HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> subh(in Vec128<double> lhs, in Vec128<double> rhs)
            => HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> subh(in Vec256<short> lhs, in Vec256<short> rhs)
            => HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> subh(in Vec256<int> lhs, in Vec256<int> rhs)
            => HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> subh(in Vec256<float> lhs, in Vec256<float> rhs)
            => HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> subh(in Vec256<double> lhs, in Vec256<double> rhs)
            => HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static void subh(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
            => store(HorizontalSubtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void subh(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
            => store(HorizontalSubtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void subh(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => store(HorizontalSubtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void subh(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => store(HorizontalSubtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void subh(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => store(HorizontalSubtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void subh(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => store(HorizontalSubtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void subh(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => store(HorizontalSubtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void subh(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => store(HorizontalSubtract(lhs, rhs), ref dst);


    }
}