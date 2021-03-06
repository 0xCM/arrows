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

    using static constant;

    /// <summary>
    /// Encodes a natural number k such that k:K & j:Prior[K] => k = j + 1
    /// </summary>
    public readonly struct Prior<K1> : ITypeNat
        where K1 : ITypeNat, new()
    {
        
        static K1 k = default;

        public static readonly Prior<K1> Rep = default;

        public static readonly ulong Value
            = k.value - 1u;

        static readonly string description = $"--{k} = {Value}";

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

        public bool Equals(Prior<K1> rhs)
            => Value == rhs.value;

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