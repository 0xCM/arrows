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

    public partial class dinx
    {

        [MethodImpl(Inline)]
        public static Num128<float> min(in Num128<float> lhs, in Num128<float> rhs)
            => Avx2.MinScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> min(in Num128<double> lhs, in Num128<double> rhs)
            => Avx2.MinScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> min(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> min(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> min(in Vec128<short> lhs, in Vec128<short> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> min(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> min(in Vec128<int> lhs, in Vec128<int> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> min(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Avx2.Min(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec128<float> min(in Vec128<float> lhs, in Vec128<float> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> min(in Vec128<double> lhs, in Vec128<double> rhs)
            => Avx2.Min(lhs, rhs);
 
         [MethodImpl(Inline)]
        public static Vec256<byte> min(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> min(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> min(in Vec256<short> lhs, in Vec256<short> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> min(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> min(in Vec256<int> lhs, in Vec256<int> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> min(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> min(in Vec256<float> lhs, in Vec256<float> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> min(in Vec256<double> lhs, in Vec256<double> rhs)
            => Avx2.Min(lhs, rhs);
 
    }

}