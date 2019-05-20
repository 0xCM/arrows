//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Globalization;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;
    using static mfunc;

    /// <summary>
    /// Defines primary bitvector api
    /// </summary>
    public static class BitVector
    {

        [MethodImpl(Inline)]
        public static BitVector<N8> Define(sbyte src)
            => BitVector<N8>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N8> Define(byte src)
            => BitVector<N8>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N16> Define(short src)
            => BitVector<N16>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N16> Define(ushort src)
            => BitVector<N16>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N32> Define(int src)
            => BitVector<N32>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N32> Define(uint src)
            => BitVector<N32>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N64> Define(long src)
            => BitVector<N64>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N64> Define(ulong src)
            => BitVector<N64>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N128> Define(i128 src)
            => BitVector<N128>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N128> Define(u128 src)
            => BitVector<N128>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N> Define<N>(Span<char> src)
            where N : ITypeNat, new()
                => BitVector<N>.Define(src);

        [MethodImpl(Inline)]
        public static BitVector<N> Define<N>(Span<Bit> src)
            where N : ITypeNat, new()
                => BitVector<N>.Define(src);

    }  
}