//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Operative
    {


    }
    partial class Structure
    {

        /// <summary>
        /// Characterizes a set that has a countable number of members
        /// </summary>
        /// <typeparam name="T">The member type</typeparam>
        public interface DiscreteSet<S> : Set<S>
        {
        }

        /// <summary>
        /// Characteries a type that repesents an infinite number of values but
        /// which can be enumerated
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface InfiniteDiscreteSet<T> : InfiniteSet<T>, DiscreteSet<T>
            where T : InfiniteDiscreteSet<T>, new()
        {            


        }

        /// <summary>
        /// Characteriizes a reified set for which there are a countable number of members
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        /// <typeparam name="M">The member type</typeparam>
        public interface DiscreteSet<S,T> : DiscreteSet<S>, Set<S,T> 
            where S: DiscreteSet<S,T>, new()
        {
            /// <summary>
            /// Enumerates the members of the set
            /// </summary>
            Z0.Seq<T> members();

        }

    }



}