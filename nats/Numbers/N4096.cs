//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N4096 : INatSeq<N4096>, 
        INatPow<N4096, N2, N12>,
        INatPow2<N12>
    {
        public static readonly N4096 Rep = default;

        public static readonly NatSeq<N4,N0,N9,N6> Seq = default;

        [MethodImpl(Inline)]
        public static implicit operator int(N4096 src)
            => (int)src.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq.seq;

        public ulong value 
            => Seq.value;

        ITypeNat INatPow2.Exponent 
            => N12.Rep;

        public override string ToString() 
            => Seq.format();
    }


}