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
    public readonly struct TransRule<E,S>
    {
        /// <summary>
        /// Constructs a state transition rule from an (input,source,target) triple
        /// </summary>
        /// <param name="input">The input event</param>
        /// <param name="source">The source state</param>
        /// <param name="target">The target state</param>
        public static implicit operator TransRule<E,S>((E input, S source, S target) x)
            => new TransRule<E, S>(x.input, x.source, x.target);
        
        public TransRule(E input, S source, S target)
        {
            this.Input = input;
            this.Source = source;
            this.Target = target;
        }
        
        /// <summary>
        /// The incoming event
        /// </summary>
        public readonly E Input;
        
        /// <summary>
        /// The state upon which the rule is predicated
        /// </summary>
        public readonly S Source;        

        /// <summary>
        /// The target state
        /// </summary>
        public readonly S Target;

        public override string ToString() 
            => $"({Input},{Source}) -> {Target}";
    }
}