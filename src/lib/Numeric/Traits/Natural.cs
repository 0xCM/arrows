//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    partial class Operative
    {

        public interface Natural<T> : Integer<T>, NonNegative<T> {}


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

    partial class Structures
    {
        /// <summary>
        /// Characterizes a reification structure over natural types S where
        /// s:S => s ∈ {1, … n} where n is some natural number subject to the
        /// bounds implied by the underlying data structure
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        public interface Natural<S> : Integer<S>, NonNegative<S>
            where S : Natural<S>, new()
        {

        }            

    }
}

