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
        public static BitVector<N8> Define(in sbyte src)
            => BitVector<N8>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N8> Define(in byte src)
            => BitVector<N8>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N16> Define(in short src)
            => BitVector<N16>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N16> Define(in ushort src)
            => BitVector<N16>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N32> Define(in int src)
            => BitVector<N32>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N32> Define(in uint src)
            => BitVector<N32>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N64> Define(in long src)
            => BitVector<N64>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N64> Define(in ulong src)
            => BitVector<N64>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N128> Define(in i128 src)
            => BitVector<N128>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N128> Define(in u128 src)
            => BitVector<N128>.Define(src.ToBits());

        [MethodImpl(Inline)]
        public static BitVector<N> Define<N>(in ReadOnlySpan<char> src)
            where N : INatPow2, new()
                => BitVector<N>.Define(src);

        [MethodImpl(Inline)]
        public static BitVector<N> Define<N>(in ReadOnlySpan<Bit> src)
            where N : INatPow2, new()
                => BitVector<N>.Define(src);

        [MethodImpl(Inline)]
        public static BitVector<N> Define<N>(in ReadOnlySpan<byte> src)
            where N : INatPow2, new()
                => BitVector<N>.Define(src);

        [MethodImpl(Inline)]
        public static BitVector<N> Define<N>(ref Span<byte> src)
            where N : INatPow2, new()
                => BitVector<N>.Define(ref src);

    }  
}