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

    using static constant;

    /// <summary>
    /// Characterizes the reification of a natural number k such that 
    /// a:K1 & b:K2 & k = a + b
    /// </summary>
    /// <typeparam name="K2">The base type</typeparam>
    /// <typeparam name="E">The exponent type</typeparam>
    public interface INatSum<K1,K2> : ITypeNat
        where K1 : ITypeNat, new()
        where K2 : ITypeNat, new()
    {

    }

    public interface INatSum<K> : ITypeNat
        where K : ITypeNat, new()
    {
        ITypeNat Lhs {get;}        

        ITypeNat Rhs {get;}
    }

    public readonly struct NatSum<K> : INatSum<K>
        where K : ITypeNat, new()
    {
        public static readonly K Rep = default;

        internal NatSum(ITypeNat lhs, ITypeNat rhs)
        {
            this.Lhs = lhs;
            this.Rhs = rhs;
        }
        
        public ITypeNat Lhs {get;}

        public ITypeNat Rhs {get;}

        NatSeq ITypeNat.seq
            => Rep.seq;

        ulong ITypeNat.value
            => Rep.value;


    }
    /// <summary>
    /// Encodes a natural number k such that k1:K1 & k2:K2 => k = k1 + k2
    /// </summary>
    public readonly struct NatSum<K1, K2> : INatSum<K1,K2>
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
    {
        static readonly K1 k1 = default;

        static readonly K2 k2 = default;

        public static readonly NatSum<K1,K2> Rep = default;

        [MethodImpl(Inline)]
        public static implicit operator int(NatSum<K1,K2> src)
            => (int)src.value;
        
        public static readonly ulong Value
            = k1.value + k2.value;

        static readonly string description = $"{k1} + {k2} = {Value}";

        public static readonly byte[] Digits 
            = digits(Value);

        public static readonly NatSeq Seq
            = Nat.reflect(Digits);

        NatSeq ITypeNat.seq
            => Seq;

        ulong ITypeNat.value 
            => Value;

        public ulong value 
            => Value;

        public NatSeq natseq()
            => Seq;

        public bool Equals(Pow<K1, K2> other)
            => Value == other.value;

        public bool Equals(NatSeq other)
            => Value == other.value;

        public override string ToString() 
            => description;

        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object rhs)
            => Value.Equals(rhs);
 
        [MethodImpl(Inline)]
        public NatSum<K> Reduce<K>(K target = default)
            where K : ITypeNat, new()
        {
            if(Value == target.value)
                return new NatSum<K>(k1,k2);
            else 
                throw new Exception($"{k1} + {k2} != {target}");
        } 
    }
}