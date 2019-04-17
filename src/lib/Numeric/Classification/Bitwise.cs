//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Operative
    {
        /// <summary>
        /// Characterizes operations over operands that can be interpreted 
        /// as an odered sequence of bits
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface BitSource<T>

        {
            /// <summary>
            /// Extracts the character bits from the falue
            /// </summary>
            /// <param name="src"></param>
            /// <returns></returns>
            string bitchars(T src);

            /// <summary>
            /// Formats the source value a sequence of base-2 digits
            /// </summary>
            Z0.BitString bitstring(T src);

            /// <summary>
            /// Determines whether a bit at a specified position is on
            /// </summary>
            bool testbit(T src, int pos);
            
            /// <summary>
            /// Interprets the source as an array of bytes
            /// </summary>
            /// <param name="src">The source value</param>
            byte[] bytes(T src);

            /// <summary>
            /// Interprets the source as an array of bits
            /// </summary>
            /// <param name="src">The source value</param>
            bit[] bits(T src);

        }
     
        /// <summary>
        /// Characterizes bit-shift operations
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface BitShifty<T> 
        {
            T lshift(T lhs, int rhs);

            T rshift(T lhs, int rhs);

        }

        /// <summary>
        /// Characterizes bit rotation operations
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Circular_shift</remarks>
        public interface BitCylce<T>
        {
            /// <summary>
            /// Rotates bits rightwards, from MSB -> LSB
            /// </summary>
            /// <param name="lhs">The value to rotate</param>
            /// <param name="rhs">The magnitude of the rotation</param>
            T lrot(T lhs, int rhs);
            
            /// <summary>
            /// Rotates bits leftwards, from LSB -> MSB
            /// </summary>
            /// <param name="lhs">The value to rotate</param>
            /// <param name="rhs">The magnitude of the rotation</param>
            T rrot(T lhs, int rhs);
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
        /// Characterizes bitwise operations over an operand
        /// </summary>
        public interface Bitwise<T> : BitLogic<T>, BitShifty<T> ,BitSource<T> 
        { }


    }

    partial class Structures
    {
        /// <summary>
        /// Characterizes a bit source reification
        /// </summary>
        /// <typeparam name="S">The reifying type</typeparam>
        public interface BitSource<S>
            where S : BitSource<S>, new()
        {
            /// <summary>
            /// Formats the source value a sequence of base-2 digits
            /// </summary>
            Z0.BitString bitstring();

            /// <summary>
            /// Determines whether a bit at a specified position is on
            /// </summary>
            bool testbit(int pos);

            /// <summary>
            /// Interprets the source as an array of bytes
            /// </summary>
            /// <param name="src">The source value</param>
            byte[] bytes();

        }

        /// <summary>
        /// Characterizes bit-shift structure
        /// </summary>
        /// <typeparam name="S">The reifying type</typeparam>
        public interface BitShifty<S>
            where S : BitShifty<S>, new()
        {
            S lshift(int rhs);

            S rshift(int rhs);

        }

        /// <summary>
        /// Characterizes structural bit rotation
        /// </summary>
        /// <typeparam name="S">The reifying type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Circular_shift</remarks>
        public interface BitCycle<S>
            where S : BitCycle<S>, new()
        {
            /// <summary>
            /// Rotates bits rightwards, from MSB -> LSB
            /// </summary>
            /// <param name="rhs">The magnitude of the rotation</param>
            S lrot(int rhs);
            
            /// <summary>
            /// Rotates bits leftwards, from LSB -> MSB
            /// </summary>
            /// <param name="rhs">The magnitude of the rotation</param>
            S rrot(int rhs);
        }

        
        public interface BitLogic<S> 
            where S : BitLogic<S>, new()
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

        public interface Bitwise<S> : BitLogic<S>, BitShifty<S>, BitSource<S>
            where S : Bitwise<S>, new()
        {

        }


    }

}