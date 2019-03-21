//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{

    partial class Class
    {

        /// <summary>
        /// Characterizes a group consisting of individuals that can be enumerated
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
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

        public interface FiniteGroup<H,T> : TypeClass<H>, FiniteGroup<T>
            where H : FiniteGroup<H,T>, new()
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

        public interface FiniteAbelianGroup<H,T> : TypeClass<H>,FiniteAbelianGroup<T>
            where H : FiniteAbelianGroup<H,T>, new()
        {


        }


    }

}