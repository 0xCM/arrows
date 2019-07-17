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

    public readonly struct N17 : INatSeq<N17>, INatPrime<N11>
    {
        public static readonly N17 Rep = default;

        public static readonly NatSeq<N1,N7> Seq = default;

        [MethodImpl(Inline)]
        public static implicit operator int(N17 src)
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