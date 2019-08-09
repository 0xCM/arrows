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
    /// Characterizes a state transition (input : E, source : S) -> target : S 
    /// </summary>
    /// <typeparam name="E">The input event type</typeparam>
    /// <typeparam name="S">The state type</typeparam>
    public readonly struct TransitionRule<E,S> : ITransitionRule<E,S>
    {
        /// <summary>
        /// Constructs a state transition rule from an (input,source,target) triple
        /// </summary>
        /// <param name="input">The input event</param>
        /// <param name="source">The source state</param>
        /// <param name="target">The target state</param>
        public static implicit operator TransitionRule<E,S>((E input, S source, S target) x)
            => new TransitionRule<E, S>(x.input, x.source, x.target);
        
        public TransitionRule(E trigger, S source, S target)
        {
            this.Trigger = trigger;
            this.Source = source;
            this.Target = target;
            this.Key = Fsm.TransitionRuleKey(Trigger,Source);
        }

        /// <summary>
        /// The transiion event trigger
        /// </summary>
        public E Trigger {get;}

        /// <summary>
        /// The state upon which the rule is predicated
        /// </summary>
        public S Source {get;}        
        
        /// <summary>
        /// The target state
        /// </summary>
        public S Target {get;}
        
        public TransitionRuleKey<E,S> Key {get;}

        public int RuleId 
            => Key.Hash;

        public override string ToString() 
            => $"({Trigger},{Source}) -> {Target}";
    }
}