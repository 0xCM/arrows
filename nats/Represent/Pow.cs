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
    using static nconst;



    /// <summary>
    /// Reifies a natural k such that b:B & e:E => k = b^e
    /// </summary>
    public readonly struct Pow<B,E> : INatPow<Pow<B, E>, B, E>
        where B : ITypeNat, new()
        where E : ITypeNat, new()
    {
        public static readonly Pow<B,E> Rep = default;

        public static readonly ITypeNat[] Operands = {new B(), new E()};            

        /// <summary>
        /// Raises a baise to a power
        /// </summary>
        /// <param name="@base">The base value</param>
        /// <param name="exp">The exponent value</param>
        static ulong pow(ulong @base, ulong exp)
            => repeat(@base, exp).Aggregate((x,y) => x * y); 

        public static readonly ulong Value
            = pow(Nat.nat<B>().value, Nat.nat<E>().value);
            
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

        public E Exponent 
            => new E();

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