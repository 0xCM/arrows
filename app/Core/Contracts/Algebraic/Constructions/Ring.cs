//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    public enum Ordering
    {
        LT = -1,
        EQ = 0,
        GT = 1
    }


    /// <summary>
    /// Characterizes a (unital) ring
    /// </summary>
    public interface Ring<T> : Unital<T>, Multiplicative<T>, Distributive<T>
    {
        
    }

    /// <summary>
    /// Characterizes a commutative, unital ring
    /// </summary>
    public interface CommutativeRing<T> : Ring<T>
    {
        
    }

    public interface DivisionRing<T> : Ring<T>, EuclideanDiv<T>
    {


    }

}
