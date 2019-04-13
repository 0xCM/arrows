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
        public static Vec128<byte> max(Vec128<byte> lhs, Vec128<byte> rhs)
            => Sse41.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> max(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Sse41.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> max(Vec128<short> lhs, Vec128<short> rhs)
            => Sse41.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> max(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Sse41.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> max(Vec128<int> lhs, Vec128<int> rhs)
            => Sse41.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> max(Vec128<uint> lhs, Vec128<uint> rhs)
            => Sse41.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> max(Vec128<float> lhs, Vec128<float> rhs)
            => Sse41.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> max(Vec128<double> lhs, Vec128<double> rhs)
            => Sse41.Max(lhs, rhs);
    }

}