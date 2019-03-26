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
        /// Characterizes a nonzero natural number
        /// </summary>
        /// <typeparam name="K">A nonzero nat type</typeparam>
        public interface Nonzero<K> : Demand<K>
            where K : TypeNat, new()
        {

        }

    }

    /// <summary>
    /// Reifies evidence that k != 0
    /// </summary>
    public readonly struct Nonzero<K> : Demands.Nonzero<K>
        where K: TypeNat, new()
    {
        public Nonzero(K n)
            => valid = demand(n.value != 0);
        
        public bool valid {get;}

    }

}