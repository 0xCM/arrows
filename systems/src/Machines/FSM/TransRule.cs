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

    public static class TransRule
    {
        /// <summary>
        /// Defines a state transition rule of the form (input : I, source : S) -> target : S 
        /// </summary>
        /// <param name="input">The input value</param>
        /// <param name="source">The source state</param>
        /// <param name="target">The target state</param>
        /// <typeparam name="I">The input type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        public static TransRule<I,S> Define<I,S>(I input, S source, S target)
            => new TransRule<I, S>(input,source,target);            
    }

    /// <summary>
    /// Characterizes a state transition (input : I, source : S) -> target : S 
    /// </summary>
    public readonly struct TransRule<I,S>
    {
        public TransRule(I input, S source, S target)
        {
            this.Input = input;
            this.Source = source;
            this.Target = target;
        }
        
        /// <summary>
        /// The input value
        /// </summary>
        public readonly I Input;
        
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