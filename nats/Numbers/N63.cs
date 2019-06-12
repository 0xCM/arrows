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


    public readonly struct N63 : INatSeq<N63>, 
        INatPrior<N63,N64>
    {
        public static readonly N63 Rep = default;

        public static readonly NatSeq<N6,N3> Seq = default;
        
        [MethodImpl(Inline)]
        public static implicit operator int(N63 src)
            => (int)src.value;

        public ITypeNat rep 
            => Rep;
        
        public NatSeq seq 
            => Seq;
        
        public ulong value 
            => Seq.value;                
        
        public override string ToString() 
            => Seq.format();        
    }
}