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

    public static class OuputRule
    {
        public static OutputRule<I,S,O> Define<I,S,O>(I input, S source, O output)
            => (input, source,output);
    }

    /// <summary>
    /// Specifies an output rule predicated on input and source state
    /// </summary>
    /// <typeparam name="I">The input symbol type</typeparam>
    /// <typeparam name="S">The state type</typeparam>
    /// <typeparam name="O">The output symbol type</typeparam>
    public readonly struct OutputRule<I,S,O>
    {
        public static implicit operator OutputRule<I,S,O>((I input, S source, O output) x)
            => new OutputRule<I, S, O>(x.input, x.source, x.output);
            
        public OutputRule(I input, S source, O output)
        {
            this.Input = input;
            this.Source = source;
            this.Output = output;
        }

        /// <summary>
        /// The inpuut upon which the output is predicated
        /// </summary>
        public readonly I Input;

        /// <summary>
        /// The state upon which the rule is predicated
        /// </summary>
        public readonly S Source;

        /// <summary>
        /// The output value associated with the specified state
        /// </summary>
        public readonly O Output;

        public override string ToString() 
            => $"({Source}, {Input}) -> {Output}";
    }

}