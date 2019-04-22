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

    
    public static partial class PrimalSpans
    {
    
        [MethodImpl(Inline)]
        public static Span<sbyte> Add(this Span<sbyte> lhs, Span<sbyte> rhs)
            => fuse(lhs, rhs,(x,y) => (sbyte)(x + y));

        [MethodImpl(Inline)]
        public static Span<byte> Add(this Span<byte> lhs, Span<byte> rhs)
            => fuse(lhs,rhs,(x,y) => (byte)(x + y));

        [MethodImpl(Inline)]
        public static Span<short> Add(this Span<short> lhs, Span<short> rhs)
            => fuse(lhs,rhs,(x,y) => (short)(x + y));

        [MethodImpl(Inline)]
        public static Span<ushort> Add(this Span<ushort> lhs, Span<ushort> rhs)
            => fuse(lhs,rhs,(x,y) => (ushort)(x + y));

        [MethodImpl(Inline)]
        public static Span<int> Add(this Span<int> lhs, Span<int> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Span<uint> Add(this Span<uint> lhs, Span<uint> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Span<long> Add(this Span<long> lhs, Span<long> rhs)
            => fuse(lhs, rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Span<ulong> Add(this Span<ulong> lhs, Span<ulong> rhs)
            => fuse(lhs, rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Span<float> Add(this Span<float> lhs, Span<float> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Span<double> Add(this Span<double> lhs, Span<double> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Span<decimal> Add(this Span<decimal> lhs, Span<decimal> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Span<BigInteger> Add(this Span<BigInteger> lhs, Span<BigInteger> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);
    
    }


}