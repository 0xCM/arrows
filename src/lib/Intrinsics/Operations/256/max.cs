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

    public partial class InX
    {

       [MethodImpl(Inline)]
        public static Vec256<byte> max(Vec256<byte> lhs, Vec256<byte> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> max(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> max(Vec256<short> lhs, Vec256<short> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> max(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> max(Vec256<ushort> lhs, Vec256<ushort> rhs)
            => Avx2.Max(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec256<int> max(Vec256<int> lhs, Vec256<int> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> max(Vec256<uint> lhs, Vec256<uint> rhs)
            => Avx2.Max(lhs, rhs);

       [MethodImpl(Inline)]
        public static Vec256<float> max(Vec256<float> lhs, Vec256<float> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> max(Vec256<double> lhs, Vec256<double> rhs)
            => Avx2.Max(lhs, rhs);
 
    }

}
