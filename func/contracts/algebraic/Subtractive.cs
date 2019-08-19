//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes operational negation and subtraction
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface ISubtractiveOps<T> 
    {
        /// <summary>
        /// Combines the first operand with the negation of the second
        /// </summary>
        /// <param name="lhs">The first operand</param>
        /// <param name="rhs">The second operand</param>
        /// <returns></returns>
        T Sub(T lhs, T rhs);
    }

    public interface ISubtractive<S> 
        where S : ISubtractive<S>, new()
    {
        /// <summary>
        /// Structural subtraction
        /// </summary>
        /// <param name="rhs">The right operand</param>
        S Sub(S rhs);
    }

}