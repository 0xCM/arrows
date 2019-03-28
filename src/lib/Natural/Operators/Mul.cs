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
        /// Characterizes the natural k such that k1:K1 & k2:K2 => k = k1 * k2
        /// </summary>
        /// <typeparam name="K1">The first operand type</typeparam>
        /// <typeparam name="K2">The second operand type</typeparam>
        public interface Mul<K1,K2> : TypeNat
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
        {

        }

        /// <summary>
        /// Characterizes a refification K that encodes a natural value 
        /// k:K such that k1:K1 & k2:K2 => k = k1*k2
        /// </summary>
        /// <typeparam name="K">The defining reification</typeparam>
        /// <typeparam name="K1">The first operand type</typeparam>
        /// <typeparam name="K2">The second operand type</typeparam>
        public interface Mul<K,K1,K2> : Mul<K1,K2>, NatOp<K,K1,K2>
            where K : Mul<K,K1,K2>, new()
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
        {
            
        }
    }

    /// <summary>
    /// Encodes a natural number k such that k1:K1 & k2:K2 => k = k1*k2
    /// </summary>
    public readonly struct Mul<K1, K2> : Traits.Mul<Mul<K1, K2>, K1, K2>,
          IEquatable<Pow<K1,K2>>,
          IEquatable<NatSeq> 
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
    {
        public static readonly Mul<K1,K2> Rep = default;        
        
        public static readonly TypeNat[] Operands = {new K1(), new K2()};

        public static readonly uint Value
            = Nat.nat<K1>().value * 10
            + Nat.nat<K2>().value;

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
        public bool Equals(Pow<K1, K2> other)
            => Value == other.value;

        [MethodImpl(Inline)]
        public bool Equals(NatSeq other)
            => Value == other.value;

        public override string ToString() 
            => Value.ToString();            

        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object rhs)
            => Value.Equals(rhs);
    }
}