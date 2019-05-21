//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static nfunc;


    public readonly struct N256 : INatSeq<N256>, 
        INatPow<N256, N2,N8>,
        INatPow2<N8>
    {
        public static readonly N256 Rep = default;

        public static readonly NatSeq<N2,N5,N6> Seq = default;

        public override bool Equals(object obj)
            => obj is N256;

        [MethodImpl(Inline)]
        public static bool operator ==(N256 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N256 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N256 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N256 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N256 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N256 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq.seq;

        public ulong value => Seq.value;

        ITypeNat INatPow2.Exponent 
            => N8.Rep;

        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();

        public override string ToString() 
            => Seq.format();
        
        public override int GetHashCode()
            => value.GetHashCode();
    }


}