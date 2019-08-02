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
    /// Specifies an output rule predicated on a source state
    /// </summary>
    /// <typeparam name="S">The state type</typeparam>
    /// <typeparam name="O">The output symbol type</typeparam>
    public class OutRule<S,O> : FsmRule<S>
    {
        public OutRule(S s, O o)
            : base(s)
        {
            this.Output = o;
        }

        /// <summary>
        /// The output value associated with the specified state
        /// </summary>
        public O Output {get;}

        public override string ToString() 
            => $"{Source}-> {Output}";
    }

    /// <summary>
    /// Specifies an output rule predicated on both state and input
    /// </summary>
    /// <typeparam name="S">The state type</typeparam>
    /// <typeparam name="I">The input symbol type</typeparam>
    /// <typeparam name="O">The output symbol type</typeparam>
    public class OutRule<S,I,O> : OutRule<S,O>
    {
        public OutRule(S s, I i, O o)
            : base(s, o)
        {
            this.Input = i;
        }

        /// <summary>
        /// The inpuut upon which the output is predicated
        /// </summary>
        public I Input {get;}

        public override string ToString() 
            => $"({Source}, {Input}) -> {Output}";
    }

}