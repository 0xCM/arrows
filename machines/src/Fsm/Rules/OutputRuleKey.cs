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
    public readonly struct OutputRuleKey<E,S> : IRuleKey<E,S>
    {
        public static implicit operator OutputRuleKey<E,S>((E trigger, S source) x)
            => new OutputRuleKey<E,S>(x.trigger, x.source);
        
        public OutputRuleKey(E trigger, S target)
        {
            this.Trigger = trigger;
            this.Source = target;
            this.Hash = HashCode.Combine(trigger,target);
        }

        public readonly E Trigger {get;}

        public readonly S Source {get;}

        /// <summary>
        /// The invariant hash
        /// </summary>
        public readonly int Hash {get;}


        public override string ToString() 
            => $"({Trigger}, {Source})";

    }

}