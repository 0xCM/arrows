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

    using static zfunc;

    /// <summary>
    /// Encodes a natural number k such that k:K & j:Prior[K] => k = j + 1
    /// </summary>
    public readonly struct Prior<K> : ITypeNat, IEquatable<Prior<K>>
            where K : ITypeNat, new()
    {
        
        static K k = default;

        public static readonly Prior<K> Rep = default;

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


        byte[] ITypeNat. Digits()
            => Digits;

        public NatSeq natseq()
            => Seq;

        public bool Equals(Prior<K> rhs)
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