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
        /// Requires k:K => k != 0
        /// </summary>
        /// <typeparam name="K">A nonzero natural type</typeparam>
        public interface Nonzero<K> : Demand<K>, Larger<K,N0>
            where K : TypeNat, new()
        {

        }

    }

    /// <summary>
    /// Captures evidence that k:K => k != 0
    /// </summary>
    /// <typeparam name="K">A nonzero natural type</typeparam>
    public readonly struct Nonzero<K> : Demands.Nonzero<K>
        where K: TypeNat, new()
    {
        static readonly K k = default;
        static readonly string description = $"{k} != 0";
    

        public Nonzero(K n)
            => valid = demand(n.value != 0);
        
        public bool valid {get;}

        public string format()
            => valid ? description: $"INVALID({description})";    
        
        public override string ToString()
            => format();

    }

}