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
        public static Vec256<byte> eq(Vec256<byte> lhs, Vec256<byte> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> eq(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> eq(Vec256<short> lhs, Vec256<short> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> eq(Vec256<ushort> lhs, Vec256<ushort> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> eq(Vec256<int> lhs, Vec256<int> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> eq(Vec256<uint> lhs, Vec256<uint> rhs)
            => Avx2.CompareEqual(lhs, rhs);



    }

}