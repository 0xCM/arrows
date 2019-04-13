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


    public partial class Vec128
    {

        [MethodImpl(Inline)]
        public static Vec128<byte> add(Vec128<byte> lhs, Vec128<byte> rhs)
            => Sse42.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> add(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Sse42.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> add(Vec128<short> lhs, Vec128<short> rhs)
            => Sse42.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> add(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Sse42.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> add(Vec128<int> lhs, Vec128<int> rhs)
            => Sse42.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> add(Vec128<uint> lhs, Vec128<uint> rhs)
            => Sse42.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> add(Vec128<long> lhs, Vec128<long> rhs)
            => Sse42.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> add(Vec128<ulong> lhs, Vec128<ulong> rhs)
            => Sse42.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> add(Vec128<float> lhs, Vec128<float> rhs)
            => Sse42.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> add(Vec128<double> lhs, Vec128<double> rhs)
            => Sse42.Add(lhs, rhs);

    }

}