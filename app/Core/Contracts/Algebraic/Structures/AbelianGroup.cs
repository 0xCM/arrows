//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    /// <summary>
    /// Characterizes a commutative / additive structure
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface Abelian<T> : Commutative<T>, Nullary<T>, Additive<T>, Negative<T>
    {
        
    }

    /// <summary>
    /// Characterizes an abelian group
    /// </summary>
    public interface AbelianGroup<T> : Group<T>, Abelian<T>
    {

    }

    public interface FreeAbelianGroup<T> : AbelianGroup<T>, FreeMonoid<T>
    {
        
    }

    /// <summary>
    /// Characterizes a discrete abelian group
    /// </summary>
    public interface DiscreteAbelianGroup<T> : AbelianGroup<T>, DiscreteSet<T>
    {

    }

    /// <summary>
    /// Characterizes a finite abelian group
    /// </summary>
    public interface FiniteAbelianGroup<T> : DiscreteAbelianGroup<T>, FiniteSet<T>
    {


    }

}