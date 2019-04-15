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

    public partial class InX
    {

        [MethodImpl(Inline)]
        public static Num128<float> max(Num128<float> lhs, Num128<float> rhs)
            => Avx2.MaxScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> max(Num128<double> lhs, Num128<double> rhs)
            => Avx2.MaxScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> max(Vec128<byte> lhs, Vec128<byte> rhs)
            => Avx2.Max(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec128<sbyte> max(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Avx2.Max(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec128<short> max(Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.Max(lhs, rhs);

 
        [MethodImpl(Inline)]
        public static Vec128<int> max(Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> max(Vec128<uint> lhs, Vec128<uint> rhs)
            => Avx2.Max(lhs, rhs);

 
        [MethodImpl(Inline)]
        public static Vec128<float> max(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.Max(lhs, rhs);

 
 
        [MethodImpl(Inline)]
        public static Vec128<double> max(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.Max(lhs, rhs);

    }
}