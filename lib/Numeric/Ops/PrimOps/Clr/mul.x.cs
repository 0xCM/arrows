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

    public static class MulX
    {

        [MethodImpl(Inline)]
        public static Index<sbyte> Mul(this Index<sbyte> lhs, Index<sbyte> rhs)
            => fuse(lhs,rhs,(x,y) => (sbyte)(x * y));

        [MethodImpl(Inline)]
        public static Index<byte> Mul(this Index<byte> lhs, Index<byte> rhs)
            => fuse(lhs,rhs,(x,y) => (byte)(x * y));

        [MethodImpl(Inline)]
        public static Index<short> Mul(this Index<short> lhs, Index<short> rhs)
            => fuse(lhs,rhs,(x,y) => (short)(x * y));

        [MethodImpl(Inline)]
        public static Index<ushort> Mul(this Index<ushort> lhs, Index<ushort> rhs)
            => fuse(lhs,rhs,(x,y) => (ushort)(x * y));

        [MethodImpl(Inline)]
        public static Index<int> Mul(this Index<int> lhs, Index<int> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static Index<uint> Mul(this Index<uint> lhs, Index<uint> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static Index<long> Mul(this Index<long> lhs, Index<long> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static Index<ulong> Mul(this Index<ulong> lhs, Index<ulong> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static Index<float> Mul(this Index<float> lhs, Index<float> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static Index<double> Mul(this Index<double> lhs, Index<double> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static Index<decimal> Mul(this Index<decimal> lhs, Index<decimal> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static Index<BigInteger> Mul(this Index<BigInteger> lhs, Index<BigInteger> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

    }        
}