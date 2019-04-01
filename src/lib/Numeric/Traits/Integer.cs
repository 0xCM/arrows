//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;

    partial class Operative
    {

        /// <summary>
        /// Characterizes operations over an integer type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Integer<T> : RealNumber<T>, Stepwise<T>, Bitwise<T> { }

        public interface FiniteInt<T> : Integer<T>, BoundReal<T> { }


        /// <summary>
        /// Characterizes operations over unbound integers
        /// </summary>
        public interface InfiniteInt<T> : Integer<T>, Infinite<T> { }


        /// <summary>
        /// Characterizes operations over a signed interal type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface SignedInt<T> : Integer<T>, Signed<T>, Subtractive<T> { }


        /// <summary>
        /// Characterizes operations over a signed, finite interal type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface FiniteSignedInt<T> : SignedInt<T>, BoundReal<T> { } 

        /// <summary>
        /// Characterizes operations over an unbound signed integral type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface InfiniteSignedInt<T> : InfiniteInt<T>, SignedInt<T> {}


    }

    partial class Structure
    {

        public interface Integer<S> :  RealNumber<S>, Stepwise<S>, Bitwise<S> { }

        /// <summary>
        /// Characterizes a reification structure over an integer type
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface Integer<S,T> : Integer<S>
            where S : Integer<S,T>, new() { }

        

    }
}