//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    public interface LeftDistributive<T> : Multiplicative<T>, Additive<T>
    {
        /// <summary>
        /// Characterizes a type that defines an operator that left-distributes
        /// multiplication over addition
        /// </summary>
        /// <typeparam name="X">The operand type</typeparam>
        T distribute(T lhs, (T x, T y) rhs);
    }

    /// <summary>
    /// Characterizes a type that defines an operator that right-distributes
    /// multiplication over addition
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface RightDistributive<T> : Multiplicative<T>, Additive<T>
    {
        T distribute((T x, T y) lhs, T rhs);
    }

    /// <summary>
    /// Characterizes a type that defines both left and right distribution
    /// over addition
    /// </summary>
    public interface Distributive<T> : LeftDistributive<T>, RightDistributive<T>
    {

    }



}