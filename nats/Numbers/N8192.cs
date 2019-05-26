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

    public readonly struct N8192: INatSeq<N8192>, 
        INatPow<N8192, N2, N13>,
        INatPow2<N13>
    {
        public static readonly N8192 Rep = default;

        public static readonly NatSeq<N8,N1,N9,N2> Seq = default;

 
        public override bool Equals(object obj)
            => obj is N8192;

        [MethodImpl(Inline)]
        public static bool operator ==(N8192 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N8192 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N8192 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N8192 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N8192 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N8192 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq.seq;

        public ulong value 
            => Seq.value;

        ITypeNat INatPow2.Exponent 
            => N13.Rep;
        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();
 
        public override string ToString() 
            => Seq.format();
        
        public override int GetHashCode()
            => value.GetHashCode();
   }


}