//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using static zcore;


    /// <summary>
    /// Encodes a natural number k such that k1:K1 & k2:K2 => k = k1*k2
    /// </summary>
    public readonly struct Mul<K1, K2> : TypeNat, IEquatable<Pow<K1,K2>>, IEquatable<NatSeq> 
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
    {
        static readonly K1 k1 = default;

        static readonly K2 k2 = default;

        public static readonly Mul<K1,K2> Rep = default;        
        
        public static readonly TypeNat[] Operands = {k1, k2};

        public static readonly ulong Value
            = k1.value * k2.value;

        static readonly string description = $"{k1} * {k2} = {Value}";

        public static readonly byte[] Digits 
            = zcore.digits(Value);

        public static readonly NatSeq Seq
            = Nat.reflect(Digits);

        public TypeNat rep 
            => Rep;

        public NatSeq seq
            => Seq;

        public ulong value 
            => Value;

        [MethodImpl(Inline)]
        public byte[] digits()
            => Digits;

        [MethodImpl(Inline)]
        public NatSeq natseq()
            => Seq;

        [MethodImpl(Inline)]
        public bool Equals(Pow<K1, K2> other)
            => Value == other.value;

        [MethodImpl(Inline)]
        public bool Equals(NatSeq other)
            => Value == other.value;

         public string format()
            => description;

        public override string ToString() 
            => format();

        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object rhs)
            => Value.Equals(rhs);
    }
}