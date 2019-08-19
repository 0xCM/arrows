//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public enum Ordering
    {
        LT = -1,
        EQ = 0,
        GT = 1
    }



    /// <summary>
    /// Characterizes an integral domain, which is a nonzero commutative ring
    /// such that for every pair of nonzero elements a and b, the product
    /// ab is nonzero, i.e., ab = 0 iff a = 0 or b = 0
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Integral_domain</remarks>
    public interface IIntegralDomainOps<T> : ICommutativeRingOps<T>
    {
        
    }


    /// <summary>
    /// Characterizes a GCD domain
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/GCD_domain</remarks>
    public interface IGcdDomainOps<T> : IIntegralDomainOps<T>
        where T : IGcdDomainOps<T>, new()
    {


    }

    public interface IModularOps<T>
    {
        T Mod(T lhs, T rhs);

    }

    public interface IDivisiveOps<T> : IModularOps<T>
        where T : struct
    {
        T Div(T lhs, T rhs);        

        T Gcd(T lhs, T rhs);

        Quorem<T> DivRem(T lhs, T rhs);
    }

    /// <summary>
    /// Characterizes a **unique** factorization domain
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface IUniqueFactorDomainOps<T> : IGcdDomainOps<T>
        where T : IUniqueFactorDomainOps<T>, new()
    {

        
    }

    /// <summary>
    /// Characterizes a principal ideal domain
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface IPrincipalIdealDomainOps<T> : IUniqueFactorDomainOps<T>
        where T : IPrincipalIdealDomainOps<T>, new()
    {

        
    }

    /// <summary>
    /// Characterizes a Euclidean domain
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface IEuclideanDomainOps<T> : IPrincipalIdealDomainOps<T>
        where T : IEuclideanDomainOps<T>, new()
    {

    }

    public interface IModular<S> 
        where S : IModular<S>
    {
        S Mod(S rhs);

    }
    public interface IDivisive<S> : IModular<S>
        where S : IDivisive<S>, new()
    {
        S Div(S rhs);        

        S Gcd(S rhs);


    }

    public interface IDivisive<S,T> : IDivisive<S>
        where S : IDivisive<S,T>, new()
    {

    }        

}