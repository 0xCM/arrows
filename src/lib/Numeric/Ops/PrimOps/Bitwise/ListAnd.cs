//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;
    using static zcore;

    partial class PrimalList
    {

        [MethodImpl(Inline)]
        public static IReadOnlyList<sbyte> And(this IReadOnlyList<sbyte> lhs, IReadOnlyList<sbyte> rhs)
            => fuse(lhs,rhs,(x,y) => (sbyte)(x & y));

        [MethodImpl(Inline)]
        public static IReadOnlyList<byte> And(this IReadOnlyList<byte> lhs, IReadOnlyList<byte> rhs)
            => fuse(lhs,rhs,(x,y) => (byte)(x & y));

        [MethodImpl(Inline)]
        public static IReadOnlyList<short> And(this IReadOnlyList<short> lhs, IReadOnlyList<short> rhs)
            => fuse(lhs,rhs,(x,y) => (short)(x & y));

        [MethodImpl(Inline)]
        public static IReadOnlyList<ushort> And(this IReadOnlyList<ushort> lhs, IReadOnlyList<ushort> rhs)
            => fuse(lhs,rhs,(x,y) => (ushort)(x & y));

        [MethodImpl(Inline)]
        public static IReadOnlyList<int> And(this IReadOnlyList<int> lhs, IReadOnlyList<int> rhs)
            => fuse(lhs,rhs,(x,y) => x & y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<uint> And(this IReadOnlyList<uint> lhs, IReadOnlyList<uint> rhs)
            => fuse(lhs,rhs,(x,y) => x & y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<long> And(this IReadOnlyList<long> lhs, IReadOnlyList<long> rhs)
            => fuse(lhs,rhs,(x,y) => x & y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<ulong> And(this IReadOnlyList<ulong> lhs, IReadOnlyList<ulong> rhs)
            => fuse(lhs,rhs,(x,y) => x & y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<BigInteger> And(this IReadOnlyList<BigInteger> lhs, IReadOnlyList<BigInteger> rhs)
            => fuse(lhs,rhs,(x,y) => x & y);

    }    
}