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

    public readonly struct N128 : INatSeq<N128>,  
        INatPow<N128, N2,N7>,
        INatPow2<N7>
    {
        public static readonly N128 Rep = default;
        
        public static readonly NatSeq<N1,N2,N8> Seq = default;
        
        [MethodImpl(Inline)]
        public static implicit operator int(N128 src)
            => (int)src.value;

        public ITypeNat rep 
            => Rep;
        
        public NatSeq seq 
            => Seq;
        
        public ulong value 
            => Seq.value;

        ITypeNat INatPow2.Exponent 
            => N7.Rep;
               
        public override string ToString() 
            => Seq.format();
    }


}