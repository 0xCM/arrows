//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    /// <summary>
    /// Characterizes a type that defines an internal law over composition over its values
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface Semigroup<T> : Set<T>, BinaryOperator<T>
    {        
    
    }

    /// <summary>
    /// Characterizes a *finitely generated* free semigroup over a set
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface FreeSemigroup<T> : Semigroup<T>, FiniteSet<T>
    {
        
    }

}