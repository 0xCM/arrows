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
        T LeftRotate(T lhs, int rhs);
        
        /// <summary>
        /// Rotates bits leftwards, from LSB -> MSB
        /// </summary>
        /// <param name="lhs">The value to rotate</param>
        /// <param name="rhs">The magnitude of the rotation</param>
        T RightRotate(T lhs, int rhs);
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

}