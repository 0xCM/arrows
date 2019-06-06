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


    public readonly struct N32 : INatSeq<N32>, 
        INatPow<N32,N2,N5>,
        INatPow2<N5>
    {
        public static readonly N32 Rep = default;

        public static readonly NatSeq<N3,N2> Seq = default;


        public override bool Equals(object obj)
            => obj is N32;

        [MethodImpl(Inline)]
        public static bool operator ==(N32 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N32 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N32 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N32 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N32 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N32 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        ITypeNat INatPow2.Exponent 
            => N5.Rep;

        byte[] ITypeNat.Digits() => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();
        
        public override string ToString() => format();

        public override int GetHashCode()
            => value.GetHashCode();
    }


}