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
    /// Characterizes a natural k such that b:B & e:E => k = b^e
    /// </summary>
    /// <typeparam name="B">The base type</typeparam>
    /// <typeparam name="E">The exponent type</typeparam>
    public interface IPow<B,E> : TypeNat
        where B : TypeNat, new()
        where E : TypeNat, new()
    {

    }

    /// <summary>
    /// Characterizes the reification of a natural k such that 
    /// b:B & e:E => k = b^e
    /// </summary>
    /// <typeparam name="B">The base type</typeparam>
    /// <typeparam name="E">The exponent type</typeparam>
    public interface IPow<S,B,E> : IPow<B,E>, TypeNat<S>
        where S : IPow<S,B,E>, new()
        where B : TypeNat, new()
        where E : TypeNat, new()
    {
        
    }

    /// <summary>
    /// Reifies a natural k such that b:B & e:E => k = b^e
    /// </summary>
    public readonly struct Pow<B,E> : IPow<Pow<B, E>, B, E>,
          IEquatable<Pow<B,E>>,
          IEquatable<NatSeq>
            where B : TypeNat, new()
            where E : TypeNat, new()
    {
        public static readonly Pow<B,E> Rep = default;

        public static readonly TypeNat[] Operands = {new B(), new E()};            

        /// <summary>
        /// Raises a baise to a power
        /// </summary>
        /// <param name="@base">The base value</param>
        /// <param name="exp">The exponent value</param>
        static ulong pow(ulong @base, ulong exp)
            => fold(repeat(@base, exp), (x,y) => x*y);

        public static readonly ulong Value
            = pow(Nat.nat<B>().value, Nat.nat<E>().value);
            
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

        public byte[] digits()
            => Digits;

        public NatSeq natseq()
            => Seq;

         public string format()
            => Value.ToString();

        public override string ToString() 
            => format();

        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object rhs)
            => Value.Equals(rhs);

        public bool Equals(Pow<B, E> other)
            => Value == other.value;

        public bool Equals(NatSeq other)
            => Value == other.value;

    }
}