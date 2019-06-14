//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N32 : INatSeq<N32>, 
        INatPow<N32,N2,N5>,
        INatPow2<N5>
    {
        public static readonly N32 Rep = default;

        public static readonly NatSeq<N3,N2> Seq = default;

        [MethodImpl(Inline)]
        public static implicit operator int(N32 src)
            => (int)src.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq;

        public ulong value 
            => Seq.value;

        ITypeNat INatPow2.Exponent 
            => N5.Rep;

        public override string ToString() 
            => Seq.format();
    }
}