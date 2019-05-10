//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ILeftDistributiveOps<T>  : IMultiplicativeOps<T>, IAdditiveOps<T>
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
    public interface IRightDistributiveOps<T> : IMultiplicativeOps<T>, IAdditiveOps<T>
    {
        T distribute((T x, T y) lhs, T rhs);
    }

    /// <summary>
    /// Characterizes a type that defines both left and right distribution
    /// over addition
    /// </summary>
    public interface IDistributiveOps<T> : ILeftDistributiveOps<T>, IRightDistributiveOps<T>
    {

    }

    public interface ILeftDistributive<S>: IMultiplicative<S>, IAdditive<S>
        where S : ILeftDistributive<S>, new()
    {
        /// <summary>
        /// Characterizes a type that defines an operator that left-distributes
        /// multiplication over addition
        /// </summary>
        /// <typeparam name="X">The operand type</typeparam>
        S distributeL((S x, S y) rhs);

    }

    public interface IRightDistributive<S> : IMultiplicative<S>, IAdditive<S>
        where S : IRightDistributive<S>, new()
    {
        /// <summary>
        /// Characterizes a type that defines an operator that left-distributes
        /// multiplication over addition
        /// </summary>
        /// <typeparam name="X">The operand type</typeparam>
        S distributeR((S x, S y) rhs);

    }
    
    public interface IDistributive<S> : ILeftDistributive<S>, IRightDistributive<S> 
        where S : IDistributive<S>, new()
    {}

    public interface ILeftDistributive<S,T>  : ILeftDistributive<S>, IMultiplicative<S,T>, IAdditive<S>
        where S : ILeftDistributive<S,T>, new() { }

    public interface IRightDistributive<S,T>  : IRightDistributive<S>, IMultiplicative<S,T>, IAdditive<S>
        where S : IRightDistributive<S,T>, new() { }

    public interface IDistributive<S,T> : IDistributive<S>, ILeftDistributive<S,T>, IRightDistributive<S,T>
        where S : IDistributive<S,T>,new() { }

}