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
        /// Requires k1:K1, k2:K2 => k1 > k2
        /// </summary>
        /// <typeparam name="K1">The larger nat type</typeparam>
        /// <typeparam name="K2">The smaller nat type</typeparam>
        public interface Larger<K1,K2> : Demand<K1,K2>
            where K1: TypeNat, new()
            where K2: TypeNat, new()
        {
            
        }

    }
    
    /// <summary>
    /// Captures evidence that k1:K1, k2:K2 => k1 > k2
    /// </summary>
    /// <typeparam name="K1">The larger nat type</typeparam>
    /// <typeparam name="K2">The smaller nat type</typeparam>
    public readonly struct Larger<K1,K2> : Demands.Larger<K1,K2>
        where K1: TypeNat, new()
        where K2: TypeNat, new()
    {
        static readonly K1 k1 = default;
        static readonly K2 k2 = default;
        static readonly string description = $"{k1} > {k2}";

        public Larger(K1 n1, K2 n2)
                => valid = demand(n1.value > n2.value);
        
        public bool valid {get;}
  
        public string format()
            => valid ? description : $"INVALID({description})";    
        
        public override string ToString()
            => format();

    }
 }