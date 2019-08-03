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

    public static class Rules
    {

        /// <summary>
        /// Defines a state transition rule of the form (input : E, souce : S) -> target : S 
        /// </summary>
        /// <param name="input">The incoming event</param>
        /// <param name="source">The source state</param>
        /// <param name="target">The target state</param>
        /// <typeparam name="E">The input type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        public static TransRule<E,S> TransRule<E,S>(E input, S source, S target)
            => new TransRule<E, S>(input,source,target);            

        /// <summary>
        /// Defines an output rule of the form (input : I, source : S) -> output : O
        /// that specifies that output to emit when an input is received when in the source state
        /// </summary>
        /// <param name="source">The source state</param>
        /// <param name="target">The target state</param>
        /// <param name="output">The output value</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="O">The output type</typeparam>
        public static OutputRule<S,O> OutputRule<S,O>(S source, S target, O output)
            => (source, target, output);

        /// <summary>
        /// Defines an action that fires upon state entry
        /// </summary>
        /// <param name="input">The incoming event</param>
        /// <param name="source">The source state</param>
        /// <param name="target">The target state</param>
        /// <typeparam name="E">The input type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        public static EntryRule<S,A> EntryRule<S,A>(S source, A action)
            => new EntryRule<S,A>(source,action);            


    }

}