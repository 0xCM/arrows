//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;

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
        T RotL(T lhs, int rhs);
        
        /// <summary>
        /// Rotates bits leftwards, from LSB -> MSB
        /// </summary>
        /// <param name="lhs">The value to rotate</param>
        /// <param name="rhs">The magnitude of the rotation</param>
        T RotR(T lhs, int rhs);
    }

    /// <summary>
    /// Characterizes bit-shift operations
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IBitShiftOps<T> 
    {
        T ShiftL(T lhs, int rhs);

        T ShiftR(T lhs, int rhs);

    }

    /// <summary>
    /// Characterizes bit-shift structure
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    public interface IBitShifty<S>
        where S : IBitShifty<S>, new()
    {
        S ShiftL(int rhs);

        S ShiftR(int rhs);

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
        /// Computes the bitwise or from the supplied values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        T or(T lhs, T rhs);
 
        /// <summary>
        /// Computes the bitwise exlusive or from the supplied values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        T xor(T lhs, T rhs);

        /// <summary>
        /// Calculates the bitwise two's-complement of the input
        /// </summary>
        /// <param name="x">The source value</param>
        T flip(T x); 
    }

    public interface IBitLogic<S> 
        where S : IBitLogic<S>, new()
    {
        /// <summary>
        /// Computes the bitwise and
        /// </summary>
        /// <param name="rhs">The right value</param>
        S And(S rhs);
        
        /// <summary>
        /// Computes the bitwise or
        /// </summary>
        /// <param name="rhs">The right  value</param>
        S Or(S rhs);

        /// <summary>
        /// Computes the bitwise exlusive or
        /// </summary>
        /// <param name="rhs">The right  value</param>
        S XOr(S rhs);

        /// <summary>
        /// Calculates the bitwise two's-complement
        /// </summary>
        S Flip();
    }

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
        /// <param name="src">The source value</param>
        string BitString(T src);


        /// <summary>
        /// Determines whether a bit at a specified position is on
        /// </summary>
        bool TestBit(T src, int pos);
        
        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        byte[] Bytes(T src);

        /// <summary>
        /// Interprets the source as an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        Bit[] Bits(T src);

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
        bool TestBit(int pos);

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        byte[] Bytes {get;}

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
        S RotL(int rhs);
        
        /// <summary>
        /// Rotates bits leftwards, from LSB -> MSB
        /// </summary>
        /// <param name="rhs">The magnitude of the rotation</param>
        S RotR(int rhs);
    }

    public interface IBitwise<S> : IBitLogic<S>, IBitShifty<S>, IBitSource<S>
        where S : IBitwise<S>, new()
    {

    }

}