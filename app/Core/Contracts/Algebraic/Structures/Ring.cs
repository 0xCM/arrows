//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

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

    public interface DivisionRing<T> : Ring<T>, IntDiv<T>
    {


    }

}
