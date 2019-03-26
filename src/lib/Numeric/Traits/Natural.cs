//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    partial class Traits
    {

        public interface Natural<T> : Integer<T>, Unsigned<T>
        {
            
        }


        /// <summary>
        /// Characterizes a natural number, i.e. one of {0,1,...} subject to the maximum
        /// value of the underlying primitive
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underlying primitive</typeparam>
        public interface Natural<S,T> : Integer<S,T>, Unsigned<S,T>
            where S : Natural<S,T>, new()
            where T : new()
        {
            
        }

        /// <summary>
        /// Characterizes an operation provider for bounded natural types
        /// </summary>
        /// <typeparam name="T">The type over which operations are defined</typeparam>
        public interface FiniteNatural<T> : Natural<T>, Bounded<T>
        {
            
        }

        /// <summary>
        /// Characterizes a natural number, i.e. one of {0,1,...} subject to the maximum
        /// value of the underlying type
        /// </summary>
        /// <typeparam name="S">The realizing type</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface FiniteNatural<S,T> : Natural<S,T>, Bounded<S,T>
            where S : FiniteNatural<S,T>, new()
            where T : new()
        {
            
        }

        public interface InfiniteNatural<T> :  Infinite<T>, Integer<T>, Unsigned<T>
            where T : InfiniteNatural<T>, new()
        {
            
        }

        /// <summary>
        /// Characterizes structure over the natural numbers: N
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underlying primitive</typeparam>
        public interface InfiniteNatural<S,T> : Infinite<S,T>,  Integer<S,T>, Unsigned<S,T>
            where S : InfiniteNatural<S,T>, new()
            where T : new()
        {
            
        }


    }

}
