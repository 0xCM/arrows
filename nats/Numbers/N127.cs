//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static nfunc;


    public readonly struct N127 : INatSeq<N127>, INatPrior<N127,N128>
    {
        [MethodImpl(Inline)]
        public static bool operator ==(N127 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N127 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N127 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N127 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N127 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N127 rhs)
            => (ulong)lhs >= rhs.value;

        public static readonly N127 Rep = default;
        
        public static readonly NatSeq<N1,N2,N7> Seq = default;
        
        public ITypeNat rep => Rep;
        
        public NatSeq seq => Seq;
        
        public ulong value => Seq.value;
        
        byte[] ITypeNat.Digits() => (Seq as ITypeNat).Digits();
        
        public string format() => Seq.format();
        
        public override string ToString() => format();

        public override bool Equals(object obj)
            => obj is N127;
        
        public override int GetHashCode()
            => value.GetHashCode();
    }


}