//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Traits
    {
        public interface BitShifts<T>
        {
            T lshift(T lhs, int rhs);

            T rshift(T lhs, int rhs);

        }

        public interface BitShifts<S,T> : BitShifts<S>, Structural<S,T>
            where S : BitShifts<S,T>, new()
        {
            S lshift(int rhs);

            S rshift(int rhs);

        }
        

        /// <summary>
        /// Characterizes bitwise logical operations over a type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface BitLogic<T>
        {
            /// <summary>
            /// Computes the bitwise and from the supplied values
            /// </summary>
            /// <param name="lhs">The left value</param>
            /// <param name="rhs">The right value</param>
            /// <returns></returns>
            T and(T lhs, T rhs);

            /// <summary>
            /// Computes the bitwise or from the supplied values
            /// </summary>
            /// <param name="lhs">The left value</param>
            /// <param name="rhs">The right value</param>
            /// <returns></returns>
            T or(T lhs, T rhs);

            /// <summary>
            /// Computes the bitwise exlusive or from the supplied values
            /// </summary>
            /// <param name="lhs">The left value</param>
            /// <param name="rhs">The right value</param>
            /// <returns></returns>
            T xor(T lhs, T rhs);

            /// <summary>
            /// Calculates the bitwise two's-complement of the input
            /// </summary>
            /// <param name="x">The source value</param>
            /// <returns></returns>
            T flip(T x);
        }


        /// <summary>
        /// Characterizes a structure over which logical bitwise operations may be applied
        /// </summary>
        /// <typeparam name="S"></typeparam>
        /// <typeparam name="T"></typeparam>
        public interface BitLogic<S,T> : BitLogic<S>, Structural<S,T>
            where S : BitLogic<S,T>, new()
        {
            /// <summary>
            /// Computes the bitwise and
            /// </summary>
            /// <param name="rhs">The right value</param>
            /// <returns></returns>
            S and(S rhs);

            /// <summary>
            /// Computes the bitwise or
            /// </summary>
            /// <param name="rhs">The right  value</param>
            /// <returns></returns>
            S or(S rhs);

            /// <summary>
            /// Computes the bitwise exlusive or
            /// </summary>
            /// <param name="rhs">The right  value</param>
            /// <returns></returns>
            S xor(S rhs);

            /// <summary>
            /// Calculates the bitwise two's-complement
            /// </summary>
            /// <returns></returns>
            S flip();
        }
 
        /// <summary>
        /// Characterizes bitwise operations over an operand
        /// </summary>
        public interface Bitwise<T> : BitLogic<T>, BitShifts<T> { }

        /// <summary>
        /// Characterizes a structure that supports bitwise operations
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The underlying operand type</typeparam>
       public interface Bitwise<S,T> : Bitwise<S>, Structural<S,T>
            where S : Bitwise<S,T>, new() { }


    }


}