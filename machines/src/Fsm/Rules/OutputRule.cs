//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Specifies a state machine rule of the form (input:E, source:S) -> output:O
    /// </summary>
    /// <typeparam name="E">The event type</typeparam>
    /// <typeparam name="O">The output type</typeparam>
    public readonly struct OutputRule<E,S,O> : IOutputRule<E,S,O>
    {
        /// <summary>
        /// Constructs an output rule from a (source,target,output) triple
        /// </summary>
        /// <param name="source">The source state</param>
        /// <param name="target">The target state</param>
        /// <param name="output">The output to emit upon a source -> target transition</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="O">The output type</typeparam>
        [MethodImpl(Inline)]
        public static implicit operator OutputRule<E,S,O>((E trigger, S source, O output) x)
            => new OutputRule<E, S, O>(x.trigger, x.source, x.output);
                    
        [MethodImpl(Inline)]
        public OutputRule(E trigger, S source, O output)
        {
            this.Trigger = trigger;
            this.Source = source;
            this.Output = output;
            this.Key = Fsm.OutputRuleKey(trigger,source);
        }

        /// <summary>
        /// The source state
        /// </summary>
        public readonly E Trigger {get;}

        /// <summary>
        /// The target state
        /// </summary>
        public readonly S Source {get;}

        /// <summary>
        /// The output value associated with the specified state
        /// </summary>
        public readonly O Output {get;}

        /// <summary>
        /// The key that identifies the rule
        /// </summary>
        public readonly IRuleKey<E,S> Key {get;}

        /// <summary>
        /// The rule id as determined by the key
        /// </summary>
        public readonly int RuleId 
        {
            [MethodImpl(Inline)]
            get => Key.Hash;
        }

        [MethodImpl(Inline)]
        public string Format()
            => $"({Trigger},{Source}) -> {Output}";

        public readonly override string ToString() 
            => Format();
    }

}