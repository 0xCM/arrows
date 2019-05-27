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
    
    using static nfunc;
    using static zfunc;


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
            => fold(repeat(@base, exp), (x,y) => x*y);

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

        byte[] ITypeNat. Digits()
            => Digits;

        public NatSeq natseq()
            => Seq;

         ITypeNat INatPow2.Exponent 
            => new E();

         public string format()
            => Value.ToString();

        public override string ToString() 
            => format();

        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object rhs)
            => Value.Equals(rhs);

        public bool Equals(NatPow2<E> rhs)
            => Value == rhs.value;

        public bool Equals(NatSeq other)
            => Value == other.value;

    }
}