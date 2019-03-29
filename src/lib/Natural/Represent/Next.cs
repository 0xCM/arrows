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


    partial class Traits
    {
        /// <summary>
        /// Characterizes natural numbers j and k such that k:K & j: Next[K] => k + 1 = j
        /// </summary>
        /// <typeparam name="K">The antecedent type</typeparam>
        public interface Next<K> : TypeNat
            where K : TypeNat, new()
        {

        }

    }

    /// <summary>
    /// Encodes a natural number k such that k1:K1 & k2:K2 => k = k1 + 1
    /// </summary>
    public readonly struct Next<K> : Traits.Next<K>, IEquatable<Next<K>>
            where K : TypeNat, new()
    {
        
        static K k = default;

        public static readonly Next<K> Rep = default;

        public static readonly uint Value
            = k.value + 1u;

        static readonly string description = $"++{k} = {Value}";

        public static readonly byte[] Digits 
            = zcore.digits(Value);

        public static readonly NatSeq Seq
            = Nat.reflect(Digits);

        public TypeNat rep 
            => Rep;

        public NatSeq seq
            => Seq;

        public uint value 
            => Value;


        [MethodImpl(Inline)]
        public byte[] digits()
            => Digits;

        [MethodImpl(Inline)]
        public NatSeq natseq()
            => Seq;

        [MethodImpl(Inline)]
        public bool Equals(Next<K> rhs)
            => Value == rhs.value;

        [MethodImpl(Inline)]
        public bool Equals(NatSeq rhs)
            => Value == rhs.value;

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
