//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    
    using static nfunc;

    public readonly struct N16 : 
        INatSeq<N16>, 
        INatPow<N16,N2,N4>,
        INatPow2<N4>
    {
        public static readonly N16 Rep = default;

        public static readonly NatSeq<N1,N6> Seq = default;

        [MethodImpl(Inline)]
        public static implicit operator int(N16 src)
            => (int)src.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq;

        public ulong value 
            => Seq.value;

        ITypeNat INatPow2.Exponent 
            => N4.Rep;

        public override string ToString() 
            => Seq.format();
    }

}