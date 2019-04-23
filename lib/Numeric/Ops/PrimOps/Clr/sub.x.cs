//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using static zcore;

    public static class SubX
    {

        [MethodImpl(Inline)]
        public static Index<sbyte> Sub(this Index<sbyte> lhs, Index<sbyte> rhs)
            => fuse(lhs, rhs,(x,y) => (sbyte)(x - y));

        [MethodImpl(Inline)]
        public static Index<byte> Sub(this Index<byte> lhs, Index<byte> rhs)
            => fuse(lhs,rhs,(x,y) => (byte)(x - y));

        [MethodImpl(Inline)]
        public static Index<short> Sub(this Index<short> lhs, Index<short> rhs)
            => fuse(lhs,rhs,(x,y) => (short)(x - y));

        [MethodImpl(Inline)]
        public static Index<ushort> Sub(this Index<ushort> lhs, Index<ushort> rhs)
            => fuse(lhs,rhs,(x,y) => (ushort)(x - y));

        [MethodImpl(Inline)]
        public static Index<int> Sub(this Index<int> lhs, Index<int> rhs)
            => fuse(lhs,rhs,(x,y) => x - y);

        [MethodImpl(Inline)]
        public static Index<uint> Sub(this Index<uint> lhs, Index<uint> rhs)
            => fuse(lhs,rhs,(x,y) => x - y);

        [MethodImpl(Inline)]
        public static Index<long> Sub(this Index<long> lhs, Index<long> rhs)
            => fuse(lhs, rhs,(x,y) => x - y);

        [MethodImpl(Inline)]
        public static Index<ulong> Sub(this Index<ulong> lhs, Index<ulong> rhs)
            => fuse(lhs, rhs,(x,y) => x - y);

        [MethodImpl(Inline)]
        public static Index<float> Sub(this Index<float> lhs, Index<float> rhs)
            => fuse(lhs,rhs,(x,y) => x - y);

        [MethodImpl(Inline)]
        public static Index<double> Sub(this Index<double> lhs, Index<double> rhs)
            => fuse(lhs,rhs,(x,y) => x - y);

        [MethodImpl(Inline)]
        public static Index<decimal> Sub(this Index<decimal> lhs, Index<decimal> rhs)
            => fuse(lhs,rhs,(x,y) => x - y);

        [MethodImpl(Inline)]
        public static Index<BigInteger> Sub(this Index<BigInteger> lhs, Index<BigInteger> rhs)
            => fuse(lhs,rhs,(x,y) => x - y);
    }
}