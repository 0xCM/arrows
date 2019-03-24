//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;

    partial class Traits
    {

        /// <summary>
        /// Characterizes operations over an integer type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Integer<T> : Number<T>,  Ordered<T>, Stepwise<T>, Bitwise<T>
        {
            
        }

        /// <summary>
        /// Characterizes a structure over an integer type
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underlying primitive</typeparam>
        public interface Integer<S,T> : Number<S,T>, Ordered<S,T>, Stepwise<S,T>, Bitwise<S,T> 
            where S : Integer<S,T>, new()
        {        
            

        } 

       public interface SignedInt<T> : Integer<T>, Signed<T>, Negatable<T>
        {

        }

        /// <summary>
        /// Characterizes an structural integer that spans both positive and negative
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface SignedInt<S,T> : Integer<S,T>, Signed<S,T>, Negatable<S,T>
            where S : SignedInt<S,T>, new()
        {
        }

        public interface FiniteInt<T> : Integer<T>, Finite<T>
            where T: FiniteInt<T>, new()
        {

        }

        /// <summary>
        /// Characterizes a structure over a bound integral type
        /// </summary>
        public interface FiniteInt<S,T> : Integer<S,T>, Finite<S,T>
            where S : FiniteInt<S,T>, new()
            where T : new()
        {

        }

        /// <summary>
        /// Characterizes an operation provider for bounded and signed integer types
        /// </summary>
        /// <typeparam name="T">The type over which operations are defined</typeparam>
        /// <remarks>
        /// Applies to, for instance, the types {sbyte, short, int, long}
        /// </remarks>
        public interface FiniteSignedInt<T> : SignedInt<T>, Finite<T>
        {

        }

        /// <summary>
        /// Characterizes a structural integer that is bounded and signed
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        /// <remarks>
        /// Applies to structures, for instance, with underlying types of {sbyte, short, int, long}
        /// </remarks>
        public interface FiniteSignedInt<S,T> : SignedInt<S,T>, Finite<S,T>
            where S : FiniteSignedInt<S,T>, new()
        {

        }

        public interface InfiniteInt<T> : Integer<T>, Infinite<T>
        {

        }


        /// <summary>
        /// Characterizes a structure over a bound integral type
        /// </summary>
        public interface InfiniteInt<S,T> : Integer<S,T>, Infinite<S,T>
            where S : InfiniteInt<S,T>, new()
        {

        }

        /// <summary>
        /// Characterizes operations over unbounded, signed ingegers: Z
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface InfiniteSignedInt<T> : InfiniteInt<T>, SignedInt<T>
        {

        }

        /// <summary>
        /// Characterizes structure over unbounded signed ingegers: Z
        /// </summary>
        public interface InfiniteSignedInt<S,T> : InfiniteInt<S,T>, SignedInt<S,T>
            where S : InfiniteSignedInt<S,T>, new()
            where T : new()
        {

        }

 
    }
}