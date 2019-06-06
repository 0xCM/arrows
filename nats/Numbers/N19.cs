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


    public readonly struct N19 : INatSeq<N19>
    {
        public static readonly N19 Rep = default;

        public static readonly NatSeq<N1,N9> Seq = default;

        public override bool Equals(object obj)
            => obj is N19;

        [MethodImpl(Inline)]
        public static bool operator ==(N19 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N19 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N19 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N19 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N19 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N19 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();

        public override string ToString() => format();

        public override int GetHashCode()
            => value.GetHashCode();
    }


}