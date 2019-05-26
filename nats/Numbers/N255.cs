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


    public readonly struct N255 : INatSeq<N255>, INatPrior<N255,N256>
    {
        public static readonly N255 Rep = default;

        public static readonly NatSeq<N2,N5,N5> Seq = default;

        public override bool Equals(object obj)
            => obj is N255;

        [MethodImpl(Inline)]
        public static bool operator ==(N255 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N255 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N255 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N255 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N255 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N255 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq.seq;

        public ulong value 
            => Seq.value;

        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();

        public override string ToString() 
            => Seq.format();
        
        public override int GetHashCode()
            => value.GetHashCode();
    }

}