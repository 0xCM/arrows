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


    public static class ModX
    {

        [MethodImpl(Inline)]
        public static Index<sbyte> Mod(this Index<sbyte> lhs, Index<sbyte> rhs)
            => fuse(lhs, rhs,(x,y) => (sbyte)(x % y));

        [MethodImpl(Inline)]
        public static Index<byte> Mod(this Index<byte> lhs, Index<byte> rhs)
            => fuse(lhs,rhs,(x,y) => (byte)(x % y));

        [MethodImpl(Inline)]
        public static Index<short> Mod(this Index<short> lhs, Index<short> rhs)
            => fuse(lhs,rhs,(x,y) => (short)(x % y));

        [MethodImpl(Inline)]
        public static Index<ushort> Mod(this Index<ushort> lhs, Index<ushort> rhs)
            => fuse(lhs,rhs,(x,y) => (ushort)(x % y));

        [MethodImpl(Inline)]
        public static Index<int> Mod(this Index<int> lhs, Index<int> rhs)
            => fuse(lhs,rhs,(x,y) => x % y);

        [MethodImpl(Inline)]
        public static Index<uint> Mod(this Index<uint> lhs, Index<uint> rhs)
            => fuse(lhs,rhs,(x,y) => x % y);

        [MethodImpl(Inline)]
        public static Index<long> Mod(this Index<long> lhs, Index<long> rhs)
            => fuse(lhs, rhs,(x,y) => x % y);

        [MethodImpl(Inline)]
        public static Index<ulong> Mod(this Index<ulong> lhs, Index<ulong> rhs)
            => fuse(lhs, rhs,(x,y) => x % y);

        [MethodImpl(Inline)]
        public static Index<float> Mod(this Index<float> lhs, Index<float> rhs)
            => fuse(lhs,rhs,(x,y) => x % y);

        [MethodImpl(Inline)]
        public static Index<double> Mod(this Index<double> lhs, Index<double> rhs)
            => fuse(lhs,rhs,(x,y) => x % y);

        [MethodImpl(Inline)]
        public static Index<decimal> Mod(this Index<decimal> lhs, Index<decimal> rhs)
            => fuse(lhs,rhs,(x,y) => x % y);

        [MethodImpl(Inline)]
        public static Index<BigInteger> Mod(this Index<BigInteger> lhs, Index<BigInteger> rhs)
            => fuse(lhs,rhs,(x,y) => x % y);

    }

}