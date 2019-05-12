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
        byte[] Bytes();

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

    public interface IBitwise<S> : IBitLogic<S>, IBitShifty<S>, IBitSource<S>
        where S : IBitwise<S>, new()
    {

    }
}