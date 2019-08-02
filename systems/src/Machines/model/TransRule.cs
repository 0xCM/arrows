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
    /// Characterizes a state transition (initial : S, input : I) -> target : S 
    /// </summary>
    public class TransRule<S, I> : FsmRule<S>
    {
        public TransRule(S s, I i, S t)
            : base(s)
        {
            this.Input = i;
            this.Target = t;
        }
        
        /// <summary>
        /// The input value
        /// </summary>
        public I Input {get;}
        
        /// <summary>
        /// The target state
        /// </summary>
        public S Target {get;}

        public override string ToString() 
            => $"({Source}, {Input}) -> {Target}";
    }


}