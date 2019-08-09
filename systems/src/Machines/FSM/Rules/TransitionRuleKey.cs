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
    /// Defines a key, predicated on input event and current state, identifies a transition rule
    /// </summary>
    public readonly struct TransitionRuleKey<E,S> : IRuleKey
    {
        public static implicit operator TransitionRuleKey<E,S>((E trigger, S source) x)
            => new TransitionRuleKey<E, S>(x.trigger,x.source);

        public TransitionRuleKey(E input, S source)
        {
            this.Trigger = input;
            this.Source = source;
            this.Hash = HashCode.Combine(input,source);
        }

        public int Hash {get;}

        /// <summary>
        /// The triggering event
        /// </summary>
        public E Trigger {get;}

    
        /// <summary>
        /// The source state
        /// </summary>
        public readonly S Source;

        public override int GetHashCode()
            => Hash; 

        public override string ToString() 
            => $"({Source}, {Trigger})";
    }

}