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
            T lshift(T a, int shift);

            T rshift(T a, int shift);

        }

        public interface BitShifts<S,T>
            where S : BitShifts<S,T>
        {
            S lshift(int shift);

            S rshift(int shift);

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
            /// <param name="a">The left value</param>
            /// <param name="b">The right value</param>
            /// <returns></returns>
            T and(T a, T b);

            /// <summary>
            /// Computes the bitwise or from the supplied values
            /// </summary>
            /// <param name="a">The left value</param>
            /// <param name="b">The right value</param>
            /// <returns></returns>
            T or(T a, T b);

            /// <summary>
            /// Computes the bitwise exlusive or from the supplied values
            /// </summary>
            /// <param name="a">The left value</param>
            /// <param name="b">The right value</param>
            /// <returns></returns>
            T xor(T a, T b);

            /// <summary>
            /// Calculates the bitwise two's-complement of the input
            /// </summary>
            /// <param name="a">The source value</param>
            /// <returns></returns>
            T flip(T a);
        }


        /// <summary>
        /// Characterizes a structure over which logical bitwise operations may be applied
        /// </summary>
        /// <typeparam name="S"></typeparam>
        /// <typeparam name="T"></typeparam>
        public interface BitLogic<S,T>
            where S : BitLogic<S,T>
        {
            /// <summary>
            /// Computes the bitwise and from the supplied values
            /// </summary>
            /// <param name="a">The left value</param>
            /// <param name="b">The right value</param>
            /// <returns></returns>
            S and(S a);

            /// <summary>
            /// Computes the bitwise or from the supplied values
            /// </summary>
            /// <param name="a">The left value</param>
            /// <param name="b">The right value</param>
            /// <returns></returns>
            S or(S a);

            /// <summary>
            /// Computes the bitwise exlusive or from the supplied values
            /// </summary>
            /// <param name="a">The left value</param>
            /// <param name="b">The right value</param>
            /// <returns></returns>
            S xor(S a);

            /// <summary>
            /// Calculates the bitwise two's-complement of the input
            /// </summary>
            /// <param name="a">The source value</param>
            /// <returns></returns>
            S flip();
        }
 
        public interface Bitwise<T> : BitLogic<T>, BitShifts<T>
        {
            
        }

       public interface Bitwise<S,T> : BitLogic<S,T>, BitShifts<S,T>
            where S : Bitwise<S,T>, new()
        {
            
        }


    }


}