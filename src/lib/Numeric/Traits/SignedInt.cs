//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;

    partial class Traits
    {

        /// <summary>
        /// Characterizes operations over a signed interal type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface SignedInt<T> : Integer<T>, Signed<T>, Negatable<T> { }

        /// <summary>
        /// Characterizes an structural signed integer
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface SignedInt<S,T> : SignedInt<S>, Structure<S,T>
            where S : SignedInt<S,T>, new() { }


        /// <summary>
        /// Characterizes operations over a signed, finite interal type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface FiniteSignedInt<T> : SignedInt<T>, Bounded<T> { }

        /// <summary>
        /// Characterizes a structural integer that is bounded and signed
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        /// <remarks>
        /// Applies to structures, for instance, with underlying types of {sbyte, short, int, long}
        /// </remarks>
        public interface FiniteSignedInt<S,T> : FiniteSignedInt<S>, Structure<S,T>
            where S : FiniteSignedInt<S,T>, new() { }

 
        /// <summary>
        /// Characterizes operations over an unbound signed integral type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface InfiniteSignedInt<T> : InfiniteInt<T>, SignedInt<T> {}

        /// <summary>
        /// Characterizes structure over unbounded signed ingegers: Z
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        public interface InfiniteSignedInt<S,T> : InfiniteSignedInt<S>, Structure<S,T>
            where S : InfiniteSignedInt<S,T>, new() { }
   }

}