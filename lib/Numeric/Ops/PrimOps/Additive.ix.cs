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
    using static zcore;

    using static Operative;

    partial class PrimalIndex
    {

        [MethodImpl(Inline)]
        public static Index<sbyte> Add(this Index<sbyte> lhs, Index<sbyte> rhs)
            => fuse(lhs, rhs,(x,y) => (sbyte)(x + y));

        [MethodImpl(Inline)]
        public static Index<byte> Add(this Index<byte> lhs, Index<byte> rhs)
            => fuse(lhs,rhs,(x,y) => (byte)(x + y));

        [MethodImpl(Inline)]
        public static Index<short> Add(this Index<short> lhs, Index<short> rhs)
            => fuse(lhs,rhs,(x,y) => (short)(x + y));

        [MethodImpl(Inline)]
        public static Index<ushort> Add(this Index<ushort> lhs, Index<ushort> rhs)
            => fuse(lhs,rhs,(x,y) => (ushort)(x + y));

        [MethodImpl(Inline)]
        public static Index<int> Add(this Index<int> lhs, Index<int> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Index<uint> Add(this Index<uint> lhs, Index<uint> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Index<long> Add(this Index<long> lhs, Index<long> rhs)
            => fuse(lhs, rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Index<ulong> Add(this Index<ulong> lhs, Index<ulong> rhs)
            => fuse(lhs, rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Index<float> Add(this Index<float> lhs, Index<float> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Index<double> Add(this Index<double> lhs, Index<double> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Index<decimal> Add(this Index<decimal> lhs, Index<decimal> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Index<BigInteger> Add(this Index<BigInteger> lhs, Index<BigInteger> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

    }

}