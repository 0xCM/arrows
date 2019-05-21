//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static nfunc;


    public readonly struct N1024 : INatSeq<N1024>, 
        INatPow<N1024, N2,N10>,
        INatPow2<N10>
    {
        public static readonly N1024 Rep = default;

        public static readonly NatSeq<N1,N0,N2,N4> Seq = default;

        public override bool Equals(object obj)
            => obj is N1024;
 
        [MethodImpl(Inline)]
        public static bool operator ==(N1024 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N1024 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N1024 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N1024 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N1024 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N1024 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq.seq;

        public ulong value 
            => Seq.value;

        ITypeNat INatPow2.Exponent 
            => N10.Rep;

        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();


        public override string ToString() 
            => Seq.format();
       
        public override int GetHashCode()
            => value.GetHashCode();
    }


}