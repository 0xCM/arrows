//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes an operation provider for floating point values
    /// </summary>
    /// <typeparam name="T">The underlying numeric type</typeparam>
    public interface IFloatingOps<T> : 
        IRealNumberOps<T>, 
        IFractionalOps<T>, 
        IResignableOps<T>, 
        ISubtractiveOps<T>, 
        ITrigonmetricOps<T>
            where T : struct
    {
        /// <summary>
        /// The minimal resolution of the data type
        /// </summary>
        T Epsilon {get;}

        /// <summary>
        /// Calculates the square root of the input
        /// </summary>
        /// <param name="x">The input value</param>
        T Sqrt(T x);   
    }


    /// <summary>
    /// Characterizes an operation provider for bounded floating point values
    /// </summary>
    /// <typeparam name="T">The underlying numeric type</typeparam>
    public interface IFiniteFloatOps<T> : IFloatingOps<T>, IBoundRealOps<T> 
        where T : struct

    { }
        

    /// <summary>
    /// Characterizes operational reifications of RealFiniteUInt 
    /// </summary>
    /// <typeparam name="R">The reification type</typeparam>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IFiniteFloatOps<R,T> : IFiniteFloatOps<T>
        where T : struct
        where R : IFiniteFloatOps<R,T>, new() { }

    public interface IFloating<S> : 
        IRealNumber<S>, 
        IFractional<S>, 
        IResignable<S>, 
        ISubtractive<S>, 
        ITrigonmetric<S>
    where S : IFloating<S>, new()
    {
        S Sqrt();
    }

    /// <summary>
    /// Characterizes a structure for a floating point number
    /// </summary>
    /// <typeparam name="T">The underlying numeric type</typeparam>
    public interface IFloating<S,T> : IFloating<S>
        where S : IFloating<S,T>, new()
    {
        
    }
}