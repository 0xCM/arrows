//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static nfunc;

    /// <summary>
    /// Requires n:K & n1:K1 & n2:K2 => n1 <= n <= n2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface IBetween<K,K1,K2> : IDemand<K,K1,K2>
        where K : ITypeNat, new()
        where K1: ITypeNat, new()
        where K2: ITypeNat, new()
    {
        
    }

    
    /// <summary>
    /// Captures evidence that n:K & n1:K1 & n2:K2 => n1 <= n <= n2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public readonly struct Between<K,K1,K2> : IBetween<K,K1,K2>
        where K: ITypeNat, new()
        where K1: ITypeNat, new()
        where K2: ITypeNat, new()
    {        
        static readonly K k = default;

        static readonly K1 k1 = default;

        static readonly K2 k2 = default;

        static readonly string description = $"{k1} <= {k} <= {k2}";

        public Between(K k, K1 k1, K2 k2)
            => valid = demand(k.value >= k1.value && k.value <= k2.value);
        
        public bool valid {get;}

        public string format()
            => valid ? description: $"INVALID({description})";    
        
        public override string ToString()
            => format();
    }
 }