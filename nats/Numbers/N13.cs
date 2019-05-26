//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    
    using static nfunc;


    public readonly struct N13 : INatSeq<N13>
    {
        public static readonly N13 Rep = default;

        public static readonly NatSeq<N1,N3> Seq = default;

        public override bool Equals(object obj)
            => obj is N13;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();

        public override string ToString() 
            => Seq.format();

        public override int GetHashCode()
            => value.GetHashCode();
    }


}