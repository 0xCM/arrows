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
        public static BitVector<N8,sbyte> Load(ref sbyte src)
            => BitVector<N8,sbyte>.Load(ref src);

        [MethodImpl(Inline)]
        public static BitVector<N8, byte> Load(ref byte src)
            => BitVector<N8,byte>.Load(ref src);

        [MethodImpl(Inline)]
        public static BitVector<N16,short> Load(ref short src)
            => BitVector<N16,short>.Load(ref src);

        [MethodImpl(Inline)]
        public static BitVector<N16,ushort> Load(ref ushort src)
            => BitVector<N16,ushort>.Load(ref src);

        [MethodImpl(Inline)]
        public static BitVector<N32,int> Load(ref int src)
            => BitVector<N32,int>.Load(ref src);

        [MethodImpl(Inline)]
        public static BitVector<N32,uint> Load(ref uint src)
            => BitVector<N32,uint>.Load(ref src);

        [MethodImpl(Inline)]
        public static BitVector<N64,long> Load(ref long src)
            => BitVector<N64,long>.Load(ref src);

        [MethodImpl(Inline)]
        public static BitVector<N64,ulong> Load(ref ulong src)
            => BitVector<N64,ulong>.Load(ref src);


    }  
}