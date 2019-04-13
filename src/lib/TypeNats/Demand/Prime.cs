//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    using static zcore;

    partial class Demands
    {

        /// <summary>
        /// Requires n:T => n is prime
        /// </summary>
        /// <typeparam name="K">A prime nat type</typeparam>
        public interface Prime<K> : Demand<K>
            where K : TypeNat, new()
        {
            
        }

        /// <summary>
        /// Requires n:T =>  n = p^m for some prime number p and and integer m
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface PrimePower<T> : Demand<T>
            where T : TypeNat, new()
        {

        }

        /// <summary>
        /// Requires m:T =>  m = p^n for some prime number p and and natural n
        /// </summary>
        /// <typeparam name="P">The prime type</typeparam>
        /// <typeparam name="N">The power type</typeparam>
        public interface PrimePower<P,N> : Demand<P,N>
            where P : TypeNat, Prime<P>,new()
            where N : TypeNat, new()
        {

        }

    }

   /// <summary>
   // Captures evidence that k:K => k is prime
   // </summary>
   public readonly struct Prime<K> : Demands.Prime<K>
        where K : TypeNat, new()
    {
        static readonly K k = default;

        public Prime(K n)
            => valid = demand(prime<ulong>(n.value));

        public bool valid {get;}

        public string format()
            => valid ? $"{k} is prime" : $"INVALID({k} is prime)";    
        
        public override string ToString()
            => format();

    }


}