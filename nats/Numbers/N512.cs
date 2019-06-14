//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static constant;    

    public readonly struct N512 : INatSeq<N512>, 
        INatPow<N512, N2,N9>,
        INatPow2<N9>
    {
        public static readonly N512 Rep = default;

        public static readonly NatSeq<N5,N1,N2> Seq = default;

        [MethodImpl(Inline)]
        public static implicit operator int(N512 src)
            => (int)src.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq.seq;

        public ulong value 
            => Seq.value;

        ITypeNat INatPow2.Exponent 
            => N9.Rep;


        public override string ToString() 
            => Seq.format();

    }


}