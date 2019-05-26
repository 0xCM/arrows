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


    public readonly struct N12 : INatSeq<N12>
    {
        public static readonly N12 Rep = default;

        public static readonly NatSeq<N1,N2> Seq = default;

        public override bool Equals(object obj)
            => obj is N12;


        public ITypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();

        public override string ToString() => format();

        public override int GetHashCode()
            => value.GetHashCode();
    }


}