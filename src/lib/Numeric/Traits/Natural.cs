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
        public interface FiniteNatural<R,T> : FiniteNatural<T>, Operational<R,T>
            where R : FiniteNatural<R,T>, new() {  }
    }

    partial class Structure
    {
        public interface Natural<S> : Integer<S>, Unsigned<S>
        {

        }            


        /// <summary>
        /// Characterizes a natural number, i.e. one of {0,1,...} subject to the maximum
        /// value of the underlying primitive
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underlying primitive</typeparam>
        public interface Natural<S,T> : Natural<S>, Integer<S,T>, Unsigned<S,T>
            where S : Natural<S,T>, new() { }

    }
}

