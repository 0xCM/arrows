//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N8192: INatSeq<N8192>, 
        INatPow<N8192, N2, N13>,
        INatPow2<N13>
    {
        public static readonly N8192 Rep = default;

        public static readonly NatSeq<N8,N1,N9,N2> Seq = default; 

        [MethodImpl(Inline)]
        public static implicit operator int(N8192 src)
            => (int)src.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq.seq;

        public ulong value 
            => Seq.value;

        ITypeNat INatPow2.Exponent 
            => N13.Rep;
 
        public override string ToString() 
            => Seq.format();
   }


}