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
    /// Specifies an output rule predicated on source -> target transitions
    /// </summary>
    /// <typeparam name="S">The state type</typeparam>
    /// <typeparam name="O">The output type</typeparam>
    public readonly struct OutputRule<S,O>
    {
        /// <summary>
        /// Constructs an output rule from a (source,target,output) triple
        /// </summary>
        /// <param name="source">The source state</param>
        /// <param name="target">The target state</param>
        /// <param name="output">The output to emit upon a source -> target transition</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="O">The output type</typeparam>
        public static implicit operator OutputRule<S,O>((S source, S target, O output) x)
            => new OutputRule<S, O>(x.source, x.target, x.output);
            
        public OutputRule(S source, S target, O output)
        {
            this.Source = source;
            this.Target = target;
            this.Output = output;
        }

        /// <summary>
        /// The source state
        /// </summary>
        public readonly S Source;

        /// <summary>
        /// The target state
        /// </summary>
        public readonly S Target;

        /// <summary>
        /// The output value associated with the specified state
        /// </summary>
        public readonly O Output;

        public override string ToString() 
            => $"({Source},{Target}) -> {Output}";
    }

}