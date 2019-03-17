//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    /// <summary>
    /// Characterizes external subtraction
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface Subtractive<T> 
    {
        T sub(T x, T y);
    }

    /// <summary>
    /// Characterizes intrinsic subtraction
    /// </summary>
    /// <typeparam name="T">The structure type</typeparam>
    /// <typeparam name="T">The individual type</typeparam>
    public interface Subtractive<S,T> 
        where S : Subtractive<S,T>, new()
    {
        S sub(S rhs);
    }


    /// <summary>
    /// Characterizes external unary negation
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface Negative<T>  
    {
        /// <summary>
        /// Unary negation of input
        /// </summary>
        /// <param name="a">The input value</param>
        /// <returns></returns>
        T negate(T a);
    }

    /// <summary>
    /// Characterizes self unary negation
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    /// <typeparam name="S">The structure/self type</typeparam>
    public interface Negatable<S,T>
        where S : Negatable<S,T>, new()
        where T : new()
    {
        /// <summary>
        /// Unary negation of self
        /// </summary>
        /// <param name="a">The input value</param>
        /// <returns></returns>
        S negate();

    }
}