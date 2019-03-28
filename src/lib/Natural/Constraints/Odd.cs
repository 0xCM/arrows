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
        /// Characterizes an odd natural number
        /// </summary>
        /// <typeparam name="K">An Odd nat type</typeparam>
        public interface Odd<K> : Demand<K>
            where K : TypeNat, new()
        {

        }

    }

    /// <summary>
    /// Reifies evidence that k != 0
    /// </summary>
    public readonly struct Odd<K> : Demands.Odd<K>
        where K: TypeNat, new()
    {
        public Odd(K n)
            => valid = demand(n.value % 2 != 0);
        
        public bool valid {get;}

    }

}