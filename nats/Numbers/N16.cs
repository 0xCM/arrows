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

    public readonly struct N16 : 
        INatSeq<N16>, 
        INatPow<N16,N2,N4>,
        INatPow2<N4>
    {
        public static readonly N16 Rep = default;

        public static readonly NatSeq<N1,N6> Seq = default;

        
        public override bool Equals(object obj)
            => obj is N16;

        [MethodImpl(Inline)]
        public static bool operator ==(N16 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N16 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N16 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N16 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N16 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N16 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq;

        public ulong value 
            => Seq.value;

        ITypeNat INatPow2.Exponent 
            => N4.Rep;

        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();

        public override string ToString() 
            => Seq.format();

        public override int GetHashCode()
            => value.GetHashCode();
    }

}