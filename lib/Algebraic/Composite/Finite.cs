//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Structures
    {
        public interface DiscreteGroup<S> : IGroup<S>
            where S : DiscreteGroup<S>, new()
        {
            
        }

        /// <summary>
        /// Characterizes a discrete group structure
        /// </summary>
        /// <typeparam name="T">The operational type</typeparam>
        /// <typeparam name="S">The structure type</typeparam>
        public interface DiscreteGroup<S,T> : IGroup<S,T>, IDiscreteSet<S,T>
            where S : DiscreteGroup<S,T>, new()
            where T : IEquatable<T>
        {

        }

        public interface FiniteGroup<S,T> : DiscreteGroup<S,T>
            where S : FiniteGroup<S,T>, new()
            where T : IEquatable<T>
        {


        }

        public interface FiniteAbelianGroup<S,T> : DiscreteAbelianGroup<S,T>, Contain.IFiniteSet<S,T>
            where S : FiniteAbelianGroup<S,T>, new()
            where T : IEquatable<T>
        {


        }

        public interface DiscreteAbelianGroup<S,T> : IGroupA<S,T>, IDiscreteSet<S,T>
            where S : DiscreteAbelianGroup<S,T>, new()
            where T : IEquatable<T>
        {

        }

    }

}