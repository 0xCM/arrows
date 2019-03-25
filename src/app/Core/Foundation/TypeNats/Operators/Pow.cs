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
    using static corefunc;

    partial class Traits
    {
        public interface Pow<S,B,E> : NatOp<S,B,E>
            where S : Pow<S,B,E>, new()
            where B : TypeNat, new()
            where E : TypeNat, new()
        {
            
        }


        /// <summary>
        /// Characterizes a natural base raised to a natural power
        /// </summary>
        public interface PrimePower<S,B,P> : Prime<P>, Pow<S, B, P>
            where S : PrimePower<S,B,P>, new()
            where B : TypeNat, new()
            where P : TypeNat, new()
        {

        }

    }

    public readonly struct Pow<B, E> : Traits.Pow<Pow<B, E>, B, E>,
          IEquatable<Pow<B,E>>,
          IEquatable<NatSeq>
            where B : TypeNat, new()
            where E : TypeNat, new()
    {
        public static readonly Pow<B,E> Rep = default;

        public static readonly TypeNat[] Operands = {new B(), new E()};            
        public static readonly uint Value
            = pow(Nat.nat<B>().value, Nat.nat<E>().value);
            
        public static readonly byte[] Digits 
            = corefunc.digits(Value);

        public static readonly NatSeq Seq
            = Nat.reflect(Digits);

        public uint value 
            => Value;

        public TypeNat rep 
            => Rep;

        public byte[] digits()
            => Digits;

        public NatSeq natseq()
            => Seq;

        public override string ToString() 
            => Value.ToString();            

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