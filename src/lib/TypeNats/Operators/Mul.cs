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
        /// <summary>
        /// Characterizes a refification S that encodes a natural value 
        /// n such that x:T1 & yT2 => n = x*y
        /// </summary>
        /// <typeparam name="S">The defining reification</typeparam>
        /// <typeparam name="T1">The first operand type</typeparam>
        /// <typeparam name="T2">The second operand type</typeparam>
        public interface Mul<S,T1,T2> : NatOp<S,T1,T2>
            where S : Mul<S,T1,T2>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
        {
            
        }

        /// <summary>
        /// Characterizes a refification S that encodes a natural value 
        /// n such that a:T1 & b:T2 & c:T3 => n = a*b*c
        /// </summary>
        /// <typeparam name="S">The defining reification</typeparam>
        /// <typeparam name="T1">The first operand type</typeparam>
        /// <typeparam name="T2">The second operand type</typeparam>
        /// <typeparam name="T3">The third operand type</typeparam>
        public interface Mul<S,T1,T2,T3> : NatOp<S,T1,T2,T3>
            where S : Mul<S,T1,T2,T3>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
        {
            
        }

        /// <summary>
        /// Characterizes a refification S that encodes a natural value 
        /// n such that a:T1 & b:T2 & c:T3 & d:T4 => n = a*b*c*d
        /// </summary>
        /// <typeparam name="S">The defining reification</typeparam>
        /// <typeparam name="T1">The first operand type</typeparam>
        /// <typeparam name="T2">The second operand type</typeparam>
        /// <typeparam name="T3">The third operand type</typeparam>
        /// <typeparam name="T4">The fourth operand type</typeparam>
        public interface Mul<S,T1,T2,T3,T4> : NatOp<S,T1,T2,T3,T4>
            where S : Mul<S,T1,T2,T3,T4>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
        {
            
        }


    }

    public readonly struct Mul<T1, T2> : Traits.Mul<Mul<T1, T2>, T1, T2>,
          IEquatable<Pow<T1,T2>>,
          IEquatable<NatSeq> 
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
    {
        public static readonly Mul<T1,T2> Rep = default;        
        
        public static readonly TypeNat[] Operands = {new T1(), new T2()};

        public static readonly uint Value
            = Nat.nat<T1>().value * 10
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