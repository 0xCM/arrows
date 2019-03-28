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
        /// Characterizes an even natural number
        /// </summary>
        /// <typeparam name="K">An even nat type</typeparam>
        public interface Even<K> : Demand<K>
            where K : TypeNat, new()
        {

        }

    }

    /// <summary>
    /// Reifies evidence that k != 0
    /// </summary>
    public readonly struct Even<K> : Demands.Even<K>
        where K: TypeNat, new()
    {
        public Even(K n)
            => valid = demand(n.value % 2 == 0);
        
        public bool valid {get;}

    }

}