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


    public readonly struct N20 : INatSeq<N20>
    {
        public static readonly N20 Rep = default;

        public static readonly NatSeq<N2,N0> Seq = default;

        [MethodImpl(Inline)]
        public static implicit operator int(N20 src)
            => (int)src.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq;

        public ulong value => Seq.value;

        public override string ToString() 
            => Seq.format();
    }


}