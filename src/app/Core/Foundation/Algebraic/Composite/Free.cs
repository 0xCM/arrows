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
        public interface Concatenable<T>
        {
            T concat(T lhs, T rhs);


        }

        public interface Concatenable<S,T>
            where S : Concatenable<S,T>,new()
        {

            S append(S rhs);

        }

        public interface FinitelyGenerable<T>
        {
            FiniteSet<T> generators {get;}
        }


        /// <summary>
        /// Characterizes a free moinoid over a set
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Free_monoid 
        /// and http://localhost:9000/refs/books/Y2007GRAA.pdf#page=39&view=fit</remarks>
        public interface FreeMonoid<T> : Monoid<T>, Concatenable<T>
        {
            T empty {get;}

        }

        public interface FreeMonoid<S,T> : Monoid<S,T>, Concatenable<S,T>
            where S : FreeMonoid<S,T>, new()
        {
            
            S empty {get;}
                    
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