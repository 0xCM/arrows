//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    partial class Traits
    {
        /// <summary>
        /// Characterizes any type family
        /// </summary>
        public interface TypeFamily : Function
        {

        }

        /// <summary>
        /// Characterizes a type family with domain A and codomain U. This models
        /// a collection of types indexed by A-values, typically denoted by
        /// B:A->U where B is understood to be a type that **depends** on a value
        /// of A.
        /// </summary>
        /// <typeparam name="A">The domain</typeparam>
        /// <typeparam name="U">The codomain</typeparam>
        /// <remarks>
        /// See http://localhost:9000/refs/books/Y2013HTT.pdf#page=36
        /// </remarks>
        public interface TypeFamily<in A, out U> : TypeFamily, Function<A,U>
            where U : Universe
        {

        }

        /// <summary>
        /// Characterizes a constant type family
        /// </summary>
        /// <typeparam name="A">The domain</typeparam>
        /// <typeparam name="B">A distinguished element of U</typeparam>
        /// <typeparam name="U">The universe containing B</typeparam>
        public interface TypeFamily<in A, out B, U> : TypeFamily<A,U>
            where U : Universe
        {


        }

       /// <summary>
        /// Characterizes a function whose type inhabits a parameter-identified universe
        /// </summary>
        /// <typeparam name="A">The function domain</typeparam>
        /// <typeparam name="B">The function codomain</typeparam>
        /// <typeparam name="U">The universe that is inhabited by the function type A->B</typeparam>
        public interface Function<A,B,U> : Inhabitant<U>, Function<A,B>
            where U : Universe        
        {

        }    
 
        /// <summary>
        /// Characterizes a function that ranges over values of a type A ∈ 𝒰 and
        /// yields values (types) in 𝒰
        /// </summary>
        /// <typeparam name="A">The function domain type</typeparam>
        /// <typeparam name="U">The universal codomain</typeparam>
        /// <remarks>
        /// See http://localhost:9000/refs/books/Y2013HTT.pdf#page=37
        /// </remarks>
        public interface DependentFunction<A,U> : Function<A,U>
        where U : Universe
        {

            TypeFamily<A,U> B {get;}
        }

    }
}