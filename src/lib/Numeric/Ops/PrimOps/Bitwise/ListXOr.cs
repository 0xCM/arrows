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
        public static IReadOnlyList<sbyte> XOr(this IReadOnlyList<sbyte> lhs, IReadOnlyList<sbyte> rhs)
            => fuse(lhs,rhs,(x,y) => (sbyte)(x ^ y));

        [MethodImpl(Inline)]
        public static IReadOnlyList<byte> XOr(this IReadOnlyList<byte> lhs, IReadOnlyList<byte> rhs)
            => fuse(lhs,rhs,(x,y) => (byte)(x ^ y));

        [MethodImpl(Inline)]
        public static IReadOnlyList<short> XOr(this IReadOnlyList<short> lhs, IReadOnlyList<short> rhs)
            => fuse(lhs,rhs,(x,y) => (short)(x ^ y));

        [MethodImpl(Inline)]
        public static IReadOnlyList<ushort> XOr(this IReadOnlyList<ushort> lhs, IReadOnlyList<ushort> rhs)
            => fuse(lhs,rhs,(x,y) => (ushort)(x ^ y));

        [MethodImpl(Inline)]
        public static IReadOnlyList<int> XOr(this IReadOnlyList<int> lhs, IReadOnlyList<int> rhs)
            => fuse(lhs,rhs,(x,y) => x ^ y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<uint> XOr(this IReadOnlyList<uint> lhs, IReadOnlyList<uint> rhs)
            => fuse(lhs,rhs,(x,y) => x ^ y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<long> XOr(this IReadOnlyList<long> lhs, IReadOnlyList<long> rhs)
            => fuse(lhs,rhs,(x,y) => x ^ y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<ulong> XOr(this IReadOnlyList<ulong> lhs, IReadOnlyList<ulong> rhs)
            => fuse(lhs,rhs,(x,y) => x ^ y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<BigInteger> XOr(this IReadOnlyList<BigInteger> lhs, IReadOnlyList<BigInteger> rhs)
            => fuse(lhs,rhs,(x,y) => x ^ y);

    }    
}