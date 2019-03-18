//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{


    /// <summary>
    /// Characterizes an algebraic monoid
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface Monoid<T> : Semigroup<T>
    {
        /// <summary>
        /// The monoidal unit, relative to the composition operator on the
        /// subsumed semigroup
        /// </summary>
        /// <value></value>
        T unit {get;}
    }

    /// <summary>
    /// Characterizes a finitely generated free monoid
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Free_monoid </remarks>
    public interface FreeMonoid<T> : Monoid<T>, FreeSemigroup<T>
    {
        
    }

    

}