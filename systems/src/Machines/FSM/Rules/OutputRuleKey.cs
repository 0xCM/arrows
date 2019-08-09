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
    /// Defines a key for efficient/predicatable output rule indexing/lookup
    /// </summary>
    /// <typeparam name="S">The state type</typeparam>
    public readonly struct OutputRuleKey<E,S> : IRuleKey
    {
        public static implicit operator OutputRuleKey<E,S>((E trigger, S source) x)
            => new OutputRuleKey<E,S>(x.trigger, x.source);
        
        public OutputRuleKey(E trigger, S target)
        {
            this.Trigger = trigger;
            this.Source = target;
            this.Hash = HashCode.Combine(trigger,target);
        }

        /// <summary>
        /// The invariant hash
        /// </summary>
        public int Hash {get;}

        public readonly E Trigger;

        public readonly S Source;


        public override string ToString() 
            => $"({Trigger}, {Source})";

    }

}