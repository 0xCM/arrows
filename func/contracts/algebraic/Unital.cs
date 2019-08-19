//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes operations over a unital type
    /// </summary>
    /// <typeparam name="T">The characterized type</typeparam>
    public interface IUnitalOps<T> 
    {
        /// <summary>
        /// The unital value
        /// </summary>
        T One {get;}
    }

    /// <summary>
    /// Characterizes an multiplicative structure S for which there exists a
    /// distinguished element 1:S such that for every s:S, 1*s = s*1 = s
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    public interface IUnital<S> 
        where S : IUnital<S>, new()
    {
        S One {get;}
    }


}