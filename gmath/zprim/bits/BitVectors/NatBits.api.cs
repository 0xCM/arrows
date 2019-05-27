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

    /// <summary>
    /// Defines primary bitvector api
    /// </summary>
    public static class NatBits
    {
        [MethodImpl(Inline)]
        public static BitVector<N8,sbyte> Define(in sbyte src)
            => BitVector<N8,sbyte>.Define(src);

        [MethodImpl(Inline)]
        public static BitVector<N8, byte> Define(in byte src)
            => BitVector<N8,byte>.Define(src);

        [MethodImpl(Inline)]
        public static BitVector<N16,short> Define(in short src)
            => BitVector<N16,short>.Define(src);

        [MethodImpl(Inline)]
        public static BitVector<N16,ushort> Define(in ushort src)
            => BitVector<N16,ushort>.Define(src);

        [MethodImpl(Inline)]
        public static BitVector<N32,int> Define(in int src)
            => BitVector<N32,int>.Define(src);

        [MethodImpl(Inline)]
        public static BitVector<N32,uint> Define(in uint src)
            => BitVector<N32,uint>.Define(src);

        [MethodImpl(Inline)]
        public static BitVector<N64,long> Define(in long src)
            => BitVector<N64,long>.Define(src);

        [MethodImpl(Inline)]
        public static BitVector<N64,ulong> Define(in ulong src)
            => BitVector<N64,ulong>.Define(src);

        [MethodImpl(Inline)]
        public static BitVector<N,byte> Define<N>(in ReadOnlySpan<byte> src)
            where N : INatPow2, new()
                => BitVector<N,byte>.Define(src);

        [MethodImpl(Inline)]
        public static BitVector<N,byte> Define<N>(in Span<byte> src)
            where N : INatPow2, new()
                => BitVector<N,byte>.Define(src);

    }  
}