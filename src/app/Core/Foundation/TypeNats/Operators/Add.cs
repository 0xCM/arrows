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


    partial class Traits
    {
        public interface Add<S,T1,T2> : NatOp<S,T1,T2>
            where S : Add<S,T1,T2>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
        {

        }

    }

    public readonly struct Add<T1, T2> : Traits.Add<Add<T1, T2>, T1, T2>,
          IEquatable<Pow<T1,T2>>,
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

        public TypeNat rep 
            => Rep;

        [MethodImpl(Inline)]
        public byte[] digits()
            => Digits;

        [MethodImpl(Inline)]
        public NatSeq natseq()
            => Seq;

        [MethodImpl(Inline)]
        public bool Equals(Pow<T1, T2> other)
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