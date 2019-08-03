//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
 
    using static zfunc;


    /// <summary>
    /// Defines a key for efficient/predicatable transition rule indexing/lookup
    /// </summary>
    public readonly struct TransRuleKey<E,S>
    {
        public static implicit operator TransRuleKey<E,S>((E input, S source) x)
            => new TransRuleKey<E, S>(x.input,x.source);

        public TransRuleKey(E input, S source)
        {
            this.Input = input;
            this.Source = source;
            this.Hash = HashCode.Combine(input,source);
        }

        readonly int Hash;

        /// <summary>
        /// The input event
        /// </summary>
        public readonly E Input;
        
        /// <summary>
        /// The source state
        /// </summary>
        public readonly S Source;

        public override int GetHashCode()
            => Hash; 

        public override string ToString() 
            => $"({Source}, {Input})";
    }

}