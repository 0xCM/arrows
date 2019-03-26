//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static zcore;

    partial class Demands
    {


        /// <summary>
        /// Requires n:K & n1:K1 & n2:K2 => n1 <= n <= n2
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second nat type</typeparam>
        public interface Between<K,K1,K2> : Demand<K,K1,K2>
            where K : TypeNat, new()
            where K1: TypeNat, new()
            where K2: TypeNat, new()
        {
            
        }

    }
    
    /// <summary>
    /// Provides evidence that n:K & n1:K1 & n2:K2 => n1 <= n <= n2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public readonly struct Between<K,K1,K2> : Demands.Between<K,K1,K2>
        where K: TypeNat, new()
        where K1: TypeNat, new()
        where K2: TypeNat, new()
    {
        public static bool holds()
            => natval<K>() >= natval<K1>() && natval<K>() <= natval<K2>();
        
        public Between(K n, K1 n1, K2 n2)
            => valid = demand(n.value >= n1.value && n.value <= n2.value);
        
        public bool valid {get;}

    }
 }