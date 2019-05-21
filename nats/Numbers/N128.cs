//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static nfunc;


    public readonly struct N128 : INatSeq<N128>,  
        INatPow<N128, N2,N7>,
        INatPow2<N7>
    {
        [MethodImpl(Inline)]
        public static bool operator ==(N128 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N128 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N128 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N128 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N128 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N128 rhs)
            => (ulong)lhs >= rhs.value;

        public static readonly N128 Rep = default;
        
        public static readonly NatSeq<N1,N2,N8> Seq = default;
        
        public ITypeNat rep => Rep;
        
        public NatSeq seq => Seq;
        
        public ulong value => Seq.value;

        ITypeNat INatPow2.Exponent 
            => N7.Rep;
       
        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();
        
        public string format() => Seq.format();
        
        public override string ToString() => format();

        public override bool Equals(object obj)
            => obj is N128;
        
        public override int GetHashCode()
            => value.GetHashCode();
    }


}