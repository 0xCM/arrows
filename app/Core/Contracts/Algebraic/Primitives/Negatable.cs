//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    /// <summary>
    /// Characterizes external unary negation
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface Negatable<T> : Operational<T>
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
    public interface Negatable<S,T> : Structural<S,T>
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