//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static nfunc;

    public readonly struct N4096 : INatSeq<N4096>, 
        INatPow<N4096, N2, N12>,
        INatPow2<N12>
    {
        public static readonly N4096 Rep = default;

        public static readonly NatSeq<N4,N0,N9,N6> Seq = default;

        public override bool Equals(object obj)
            => obj is N4096;

        [MethodImpl(Inline)]
        public static bool operator ==(N4096 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N4096 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N4096 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N4096 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N4096 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N4096 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq.seq;

        public ulong value => Seq.value;

        ITypeNat INatPow2.Exponent 
            => N12.Rep;

        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();

        public override string ToString() 
            => Seq.format();
        
        public override int GetHashCode()
            => value.GetHashCode();
    }


}