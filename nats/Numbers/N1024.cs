//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static constant;    

    public readonly struct N1024 : INatSeq<N1024>, 
        INatPow<N1024, N2,N10>,
        INatPow2<N10>
    {
        public static readonly N1024 Rep = default;

        public static readonly NatSeq<N1,N0,N2,N4> Seq = default;

        [MethodImpl(Inline)]
        public static implicit operator int(N1024 src)
            => (int)src.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq.seq;

        public ulong value 
            => Seq.value;

        ITypeNat INatPow2.Exponent 
            => N10.Rep;

        public override string ToString() 
            => Seq.format();       
    }

}