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

    public readonly struct N16384 : INatSeq<N16384>, 
        INatPow<N16384, N2, N13>,
        INatPow2<N13>
    {
        public static readonly N16384 Rep = default;

        public static readonly NatSeq<N1,N6,N3,N8,N4> Seq = default; 

        [MethodImpl(Inline)]
        public static implicit operator int(N16384 src)
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