//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using static corefunc;
    using static Nats;

    public readonly struct Mul<T1, T2> 
        : Traits.NatMul<Mul<T1, T2>, T1, T2>,
          IEquatable<Exp<T1,T2>>,
          IEquatable<NatSeq> 
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
    {
        public static readonly Mul<T1,T2> Rep = default;

        public static readonly uint Value
            = Nat.nat<T1>().value * 10
            + Nat.nat<T2>().value;

        public static readonly byte[] Digits 
            = corefunc.digits(Value);

        public static readonly NatSeq Seq
            = Nat.reflect(Digits);


        public uint value 
            => Value;

        Mul<T1, T2> TypeNat<Mul<T1, T2>>.rep 
            => Rep;

        [MethodImpl(Inline)]
        public byte[] digits()
            => Digits;

        [MethodImpl(Inline)]
        public NatSeq natseq()
            => Seq;

        [MethodImpl(Inline)]
        public bool Equals(Exp<T1, T2> other)
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

    public readonly struct Exp<B, E> 
        : Traits.NatMul<Exp<B, E>, B, E>, 
          IEquatable<Exp<B,E>>,
          IEquatable<NatSeq>
            where B : TypeNat, new()
            where E : TypeNat, new()
    {
        public static readonly Exp<B,E> Rep = default;

            
        public static readonly uint Value
            = pow(Nat.nat<B>().value, Nat.nat<E>().value);
            
        public static readonly byte[] Digits 
            = corefunc.digits(Value);

        public static readonly NatSeq Seq
            = Nat.reflect(Digits);

        public uint value 
            => Value;

        public Exp<B, E> rep 
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

        public bool Equals(Exp<B, E> other)
            => Value == other.value;

        public bool Equals(NatSeq other)
            => Value == other.value;

    }


    public readonly struct Add<T1, T2> 
        : Traits.NatAdd<Add<T1, T2>, T1, T2>,
          IEquatable<Exp<T1,T2>>,
          IEquatable<NatSeq>
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
    {
        public static readonly Add<T1,T2> Rep = default;

        public static readonly uint Value
            = Nat.nat<T1>().value
            + Nat.nat<T2>().value;

        public static readonly byte[] Digits 
            = corefunc.digits(Value);

        public static readonly NatSeq Seq
            = Nat.reflect(Digits);

        public uint value 
            => Value;

        Add<T1, T2> TypeNat<Add<T1, T2>>.rep 
            => Rep;

        [MethodImpl(Inline)]
        public byte[] digits()
            => Digits;

        [MethodImpl(Inline)]
        public NatSeq natseq()
            => Seq;

        [MethodImpl(Inline)]
        public bool Equals(Exp<T1, T2> other)
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