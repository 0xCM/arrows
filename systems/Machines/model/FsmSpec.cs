//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes a derministic finite state machine
    /// </summary>
    /// <typeparam name="S">The state type</typeparam>
    /// <typeparam name="I">The input symbol type</typeparam>
    public class FsmSpec<S, I>
    {        
        public FsmSpec(S s0, TransRules<S,I> rules, IEnumerable<S> endstates)
        {
            this.Initial = s0;
            this.Transitions = rules;
            this.EndStates = new HashSet<S>(endstates);
        }
        
        public S Initial {get;}

        public TransRules<S,I> Transitions {get;}


        public HashSet<S> EndStates {get;}
        
    }

    public class FsmTransducerSpec<S,I,O> : FsmSpec<S,I>
    {
        public FsmTransducerSpec(S s0, TransRules<S,I> rules, IEnumerable<S> endstates)
            : base(s0, rules, endstates)
        {
       
        }

    }
}
