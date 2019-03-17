//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    /// <summary>
    /// Characterizes an integral domain, which is a nonzero commutative ring
    /// such that for every pair of nonzero elements a and b, the product
    /// ab is nonzero, i.e., ab = 0 iff a = 0 or b = 0
    /// </summary>
    /// <typeparam name="I">The individual type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Integral_domain</remarks>
    public interface IntegralDomain<I> : CommutativeRing<I>
    {
        
    }

    /// <summary>
    /// Characterizes a GCD domain
    /// </summary>
    /// <typeparam name="I">The individual type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/GCD_domain</remarks>
    public interface Gcd<I> : IntegralDomain<I>
    {


    }

    /// <summary>
    /// Characterizes a unique factorization domain
    /// </summary>
    /// <typeparam name="I">The individual type</typeparam>
    public interface Ufd<I> : Gcd<I>
    {

        
    }

    /// <summary>
    /// Characterizes a principal ideal domain
    /// </summary>
    /// <typeparam name="I">The individual type</typeparam>
    public interface Pid<I> : Ufd<I>
    {

        
    }

    /// <summary>
    /// Characterizes a Euclidean domain
    /// </summary>
    /// <typeparam name="I">The individual type</typeparam>
    public interface Eud<I> : Pid<I>
    {


    }


}