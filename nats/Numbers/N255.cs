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

    public readonly struct N255 : INatSeq<N255>, INatPrior<N255,N256>
    {
        public static readonly N255 Rep = default;

        public static readonly NatSeq<N2,N5,N5> Seq = default;

        [MethodImpl(Inline)]
        public static implicit operator int(N255 src)
            => (int)src.value;
        
        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq.seq;

        public ulong value 
            => Seq.value;

        public string format() => Seq.format();

        public override string ToString() 
            => Seq.format();
        
    }

}