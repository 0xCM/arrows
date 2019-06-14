//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static constant;


    /// <summary>
    /// Reifies a natural k such that e:E => k = 2^e
    /// </summary>
    public readonly struct NatPow2<E> : INatPow2<E>
        where E : ITypeNat, new()
    {
        public static readonly NatPow2<E> Rep = default;

        /// <summary>
        /// Raises a baise to a power
        /// </summary>
        /// <param name="@base">The base value</param>
        /// <param name="exp">The exponent value</param>
        static ulong pow(ulong @base, ulong exp)
            => repeat(@base, exp).Aggregate((x,y) => x * y); 

        public static readonly ulong Value
            = pow(Nat.nat<E>().value, Nat.nat<E>().value);
            
        public static readonly byte[] Digits 
            = digits(Value);

        public static readonly NatSeq Seq
            = Nat.reflect(Digits);

        public ITypeNat rep 
            => Rep;

        public NatSeq seq
            => Seq;

        public ulong value 
            => Value;

        public NatSeq natseq()
            => Seq;

         ITypeNat INatPow2.Exponent 
            => new E();

        public override string ToString() 
            => Value.ToString();

        public override int GetHashCode()
            => Value.GetHashCode();

        public bool Equals(NatPow2<E> rhs)
            => Value == rhs.value;

        public bool Equals(NatSeq other)
            => Value == other.value;

    }
}