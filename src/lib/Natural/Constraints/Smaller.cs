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
        /// Requires n1:T1 & n2:T2 => n1 < T2
        /// </summary>
        public interface Smaller<K1,K2> : Demand<K1,K2>
            where K1: TypeNat, new()
            where K2: TypeNat, new()
        {
            
        }
    }

    /// <summary>
    /// Reifies evidence that n1:T1 & n2:T2 => n1 < T2
    /// </summary>
    public readonly struct Smaller<T1,T2> : Demands.Smaller<T1,T2>
        where T1: TypeNat, new()
        where T2: TypeNat, new()
    {
        public static bool holds()
            => natval<T1>() < natval<T2>();
        
        public Smaller(T1 n1, T2 n2)
            => valid = demand(n1.value < n2.value);
        
        public bool valid {get;}

    }
}