//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{

    using System;
    using System.Collections.Generic;

    partial class Traits
    {
        /// <summary>
        /// Characterizes a *finitely generated* free semigroup over a set
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        public interface FreeSemigroup<T> : Semigroup<T>
        {
            FiniteSet<T> generators {get;}
        }

        public interface FreeSemigroup<S,T> : Semigroup<S,T>
            where S : FreeSemigroup<S,T>,new()
        {

        }

        /// <summary>
        /// Characterizes a finitely generated free monoid
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Free_monoid 
        /// and http://localhost:9000/refs/books/Y2007GRAA.pdf#page=39&view=fit</remarks>
        public interface FreeMonoid<T> : Monoid<T>, FreeSemigroup<T>
        {
            IEnumerable<T> concat(IEnumerable<T> s1, IEnumerable<T> s2);
        }

        public interface FreeMonoid<S,T> : Monoid<S,T>, FreeSemigroup<S,T>
            where S : FreeMonoid<S,T>, new()
        {

            IEnumerable<T> concat(IEnumerable<T> s1);

        }

        public interface FreeGroup<T> : Group<T>, FreeMonoid<T>
        {

        }

        public interface FreeGroup<S,T> : Group<S,T>
            where S : FreeGroup<S,T>, new()
        {
            
        }

        public interface FreeAbelianGroup<T> : FreeGroup<T>, GroupA<T>,  FreeMonoid<T>
        {
            
        }

        public interface FreeAbelianGroup<S,T> : FreeGroup<S,T>, GroupA<S,T>, FreeMonoid<S,T>
            where S : FreeAbelianGroup<S,T>, new()
        {
            
        }

    }

}