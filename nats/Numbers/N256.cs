//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N256 : INatSeq<N256>, 
        INatPow<N256, N2,N8>,
        INatPow2<N8>
    {
        public static readonly N256 Rep = default;

        public static readonly NatSeq<N2,N5,N6> Seq = default;

        [MethodImpl(Inline)]
        public static implicit operator int(N256 src)
            => (int)src.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq.seq;

        public ulong value 
            => Seq.value;

        ITypeNat INatPow2.Exponent 
            => N8.Rep;

        public override string ToString() 
            => Seq.format();
    }


}