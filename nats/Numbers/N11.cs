//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N11 : INatSeq<N11>
    {
        public static readonly N11 Rep = default;

        public static readonly NatSeq<N1,N1> Seq = default;

        [MethodImpl(Inline)]
        public static implicit operator int(N11 src)
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