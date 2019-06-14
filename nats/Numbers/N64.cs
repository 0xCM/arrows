//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N64 : INatSeq<N64>, 
        INatPow<N64, N2,N6>,
        INatPow2<N6>
    {

        public static readonly N64 Rep = default;
        
        public static readonly NatSeq<N6,N4> Seq = default;

        [MethodImpl(Inline)]
        public static implicit operator int(N64 src)
            => (int)src.value;

        public ITypeNat rep 
            => Rep;
        
        public NatSeq seq 
            => Seq;

        ITypeNat INatPow2.Exponent 
            => N6.Rep;
       
        public ulong value 
            => Seq.value;                
        
        public override string ToString() 
            => Seq.format();
    }
}