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
        [MethodImpl(Inline)]
        public static Vec256<byte> min(Vec256<byte> lhs, Vec256<byte> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> min(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> min(Vec256<short> lhs, Vec256<short> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> min(Vec256<ushort> lhs, Vec256<ushort> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> min(Vec256<int> lhs, Vec256<int> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> min(Vec256<uint> lhs, Vec256<uint> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> min(Vec256<float> lhs, Vec256<float> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> min(Vec256<double> lhs, Vec256<double> rhs)
            => Avx2.Min(lhs, rhs);
 


    }

}