//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Traits
    {

        /// <summary>
        /// Characterizes operations over a discrete group
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface DiscreteGroup<T> : Group<T>, DiscreteSet<T>
        {

        }


        /// <summary>
        /// Characterizes a group that consists of finitely many individuals
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface FiniteGroup<T> : DiscreteGroup<T>, FiniteSet<T>
        {


        }


        /// <summary>
        /// Characterizes a discrete abelian group
        /// </summary>
        public interface DiscreteAbelianGroup<T> : GroupA<T>, DiscreteSet<T>
        {

        }



        /// <summary>
        /// Characterizes a finite abelian group
        /// </summary>
        public interface FiniteAbelianGroup<T> : DiscreteAbelianGroup<T>, FiniteSet<T>
        {


        }

    }

    partial class Structure
    {
        /// <summary>
        /// Characterizes a discrete group structure
        /// </summary>
        /// <typeparam name="T">The operational type</typeparam>
        /// <typeparam name="S">The structure type</typeparam>
        public interface DiscreteGroup<S,T> : Group<S,T>, Traits.DiscreteSet<S,T>
            where S : DiscreteGroup<S,T>, new()
        {

        }
        public interface FiniteGroup<H,T> : DiscreteGroup<H,T>
            where T : IEquatable<T>
            where H : FiniteGroup<H,T>, new()
        {


        }

        public interface FiniteAbelianGroup<S,T> : DiscreteAbelianGroup<S,T>, Traits.FiniteSet<S,T>
            where S : FiniteAbelianGroup<S,T>, new()
            where T : IEquatable<T>
        {


        }

        public interface DiscreteAbelianGroup<S,T> : GroupA<S,T>, Traits.DiscreteSet<S,T>
            where S : DiscreteAbelianGroup<S,T>, new()
        {

        }

    }

}