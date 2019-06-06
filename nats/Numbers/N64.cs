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

    public readonly struct N64 : INatSeq<N64>, 
        INatPow<N64, N2,N6>,
        INatPow2<N6>
    {
        [MethodImpl(Inline)]
        public static bool operator ==(N64 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N64 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N64 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N64 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N64 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N64 rhs)
            => (ulong)lhs >= rhs.value;

        public static readonly N64 Rep = default;
        
        public static readonly NatSeq<N6,N4> Seq = default;
        
        public ITypeNat rep => Rep;
        
        public NatSeq seq => Seq;

        ITypeNat INatPow2.Exponent 
            => N6.Rep;
       
        public ulong value => Seq.value;
        
        byte[] ITypeNat.Digits() => (Seq as ITypeNat).Digits();
        
        public string format() => Seq.format();
        
        public override string ToString() => format();

        public override bool Equals(object obj)
            => obj is N64;
        
        public override int GetHashCode()
            => value.GetHashCode();
    }


}