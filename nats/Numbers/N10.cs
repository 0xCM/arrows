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

    public readonly struct N10 : INatSeq<N10>
    {
        public static readonly N10 Rep = default;

        public static readonly NatSeq<N1,N0> Seq = default;

        public override bool Equals(object obj)
            => obj is N10;

        [MethodImpl(Inline)]
        public static bool operator ==(N10 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N10 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N10 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N10 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N10 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N10 rhs)
            => (ulong)lhs >= rhs.value;

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