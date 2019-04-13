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

    partial class Vec128
    {

        [MethodImpl(Inline)]
        public static Vec128<byte> eq(Vec128<byte> lhs, Vec128<byte> rhs)
            => Sse2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> eq(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Sse2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> eq(Vec128<short> lhs, Vec128<short> rhs)
            => Sse2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> eq(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Sse2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> eq(Vec128<uint> lhs, Vec128<uint> rhs)
            => Sse2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> eq(Vec128<int> lhs, Vec128<int> rhs)
            => Sse2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> eq(Vec128<float> lhs, Vec128<float> rhs)
            => Sse.CompareEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> eq(Vec128<double> lhs, Vec128<double> rhs)
            => Sse2.CompareEqual(lhs, rhs);


    }


}