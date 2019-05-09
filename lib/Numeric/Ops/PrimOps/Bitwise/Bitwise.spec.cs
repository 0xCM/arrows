//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes operations over operands that can be interpreted 
    /// as an odered sequence of bits
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IBitSourceOps<T>

    {
        /// <summary>
        /// Extracts the character bits from the falue
        /// </summary>
        /// <param name="src"></param>
        string bitstring(T src);


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
        Bit[] bits(T src);

    }

    /// <summary>
    /// Characterizes bit-shift operations
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IBitShiftOps<T> 
    {
        T lshift(T lhs, int rhs);

        T rshift(T lhs, int rhs);

    }

    /// <summary>
    /// Characterizes bit rotation operations
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Circular_shift</remarks>
    public interface IBitCylceOps<T>
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
    public interface IBitLogicOps<T>
    {
        /// <summary>
        /// Computes the bitwise and from the supplied values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <returns></returns>
        T and(T lhs, T rhs);

        /// <summary>
        /// Computes the bitwise and between corresponding components in the supplied lists
        /// </summary>
        /// <param name="lhs">The first list</param>
        /// <param name="rhs">The second list</param>
        Index<T> and(Index<T>  lhs, Index<T>  rhs);

        /// <summary>
        /// Computes the bitwise or from the supplied values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        T or(T lhs, T rhs);

        /// <summary>
        /// Computes the bitwise or between corresponding components in the supplied lists
        /// </summary>
        /// <param name="lhs">The first list</param>
        /// <param name="rhs">The second list</param>
        Index<T> or(Index<T>  lhs, Index<T>  rhs);

        /// <summary>
        /// Computes the bitwise exlusive or from the supplied values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        T xor(T lhs, T rhs);

        /// <summary>
        /// Computes the bitwise xor between corresponding components in the supplied lists
        /// </summary>
        /// <param name="lhs">The first list</param>
        /// <param name="rhs">The second list</param>
        Index<T> xor(Index<T>  lhs, Index<T>  rhs);

        /// <summary>
        /// Calculates the bitwise two's-complement of the input
        /// </summary>
        /// <param name="x">The source value</param>
        T flip(T x);

        /// <summary>
        /// computes the bitwise two's-complement of each element in a list
        /// </summary>
        /// <param name="lhs">The first list</param>
        /// <param name="rhs">The second list</param>
        Index<T> flip(Index<T> lhs);

    }


    /// <summary>
    /// Characterizes bitwise operations over an operand
    /// </summary>
    public interface IBitwiseOps<T> : IBitLogicOps<T>, IBitShiftOps<T> ,IBitSourceOps<T> 
    { }


    /// <summary>
    /// Characterizes a bit source reification
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    public interface IBitSource<S>
        where S : IBitSource<S>, new()
    {
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
    public interface IBitShifty<S>
        where S : IBitShifty<S>, new()
    {
        S lshift(int rhs);

        S rshift(int rhs);

    }

    /// <summary>
    /// Characterizes structural bit rotation
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Circular_shift</remarks>
    public interface IBitCycle<S>
        where S : IBitCycle<S>, new()
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

    
    public interface IBitLogic<S> 
        where S : IBitLogic<S>, new()
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

    public interface IBitwise<S> : IBitLogic<S>, IBitShifty<S>, IBitSource<S>
        where S : IBitwise<S>, new()
    {

    }
}