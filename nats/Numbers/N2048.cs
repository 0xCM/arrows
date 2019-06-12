//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static nconst;    
    using static nfunc;

    public readonly struct N2048 : INatSeq<N2048>, 
        INatPow<N2048, N2, N11>,
        INatPow2<N11>
    {
        public static readonly N2048 Rep = default;

        public static readonly NatSeq<N2,N0,N4,N8> Seq = default;

        [MethodImpl(Inline)]
        public static implicit operator int(N2048 src)
            => (int)src.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq.seq;

        public ulong value 
            => Seq.value;

        ITypeNat INatPow2.Exponent 
            => N11.Rep;

        public override string ToString() 
            => Seq.format();
    }
}