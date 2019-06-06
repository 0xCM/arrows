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

    public readonly struct N17 : INatSeq<N17>
    {
        public static readonly N17 Rep = default;

        public static readonly NatSeq<N1,N7> Seq = default;

        public override bool Equals(object obj)
            => obj is N17;

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