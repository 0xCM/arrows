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

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<short> addh(in Vec128<short> lhs, in Vec128<short> rhs)
            => HorizontalAdd(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> addh(in Vec128<int> lhs, in Vec128<int> rhs)
            => HorizontalAdd(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> addh(in Vec128<float> lhs, in Vec128<float> rhs)
            => HorizontalAdd(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> addh(in Vec128<double> lhs, in Vec128<double> rhs)
            => HorizontalAdd(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> addh(in Vec256<short> lhs, in Vec256<short> rhs)
            => HorizontalAdd(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> addh(in Vec256<int> lhs, in Vec256<int> rhs)
            => HorizontalAdd(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> addh(in Vec256<float> lhs, in Vec256<float> rhs)
            => HorizontalAdd(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> addh(in Vec256<double> lhs, in Vec256<double> rhs)
            => HorizontalAdd(lhs, rhs);

        [MethodImpl(Inline)]
        public static void addh(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
            => store(HorizontalAdd(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void addh(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
            => store(HorizontalAdd(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void addh(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => store(HorizontalAdd(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void addh(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => store(HorizontalAdd(lhs, rhs), ref dst);
 
        [MethodImpl(Inline)]
        public static void addh(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => store(HorizontalAdd(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void addh(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => store(HorizontalAdd(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void addh(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => store(HorizontalAdd(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void addh(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => store(HorizontalAdd(lhs, rhs), ref dst);

   }

}