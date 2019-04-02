//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    partial class Operative
    {

        public interface Natural<T> : Integer<T>, Unsigned<T> {}


        /// <summary>
        /// Characterizes an operation provider for bounded natural types
        /// </summary>
        /// <typeparam name="T">The type over which operations are defined</typeparam>
        public interface FiniteNatural<T> : Natural<T>, BoundReal<T> { }

        /// <summary>
        /// Characterizes operational reifications of RealFiniteUInt 
        /// </summary>        
        /// <typeparam name="R">The reification type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        public interface FiniteNatural<R,T> : FiniteNatural<T>
            where R : FiniteNatural<R,T>, new() {  }
    }

    partial class Structure
    {
        /// <summary>
        /// Characterizes a structured natural
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        public interface Natural<S> : Integer<S>, Unsigned<S>
        {

        }            


        /// <summary>
        /// Characterizes a reification structure over natural types T where
        /// t:T => t ∈ {1, … n} where n is some natural number subject to the
        /// bounds implied by the underlying primitive
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underlying primitive</typeparam>
        public interface Natural<S,T> : Natural<S>
            where S : Natural<S,T>, new() { }

    }
}

