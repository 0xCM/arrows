//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    /// <summary>
    /// Characterizes operational reversiblity
    /// </summary>
    /// <typeparam name="T">The type for which a reverse operator is defined</typeparam>
    public interface IReversibleOps<T> 
    
    {
        T Reverse(T src);
    }

    /// <summary>
    /// Characterizes a reversible structure
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    public interface IReversible<S>
        where S : IReversible<S>, new()
    {
        S Reverse();
    }    
}