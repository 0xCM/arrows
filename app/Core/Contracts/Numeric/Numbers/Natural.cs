//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;
    

    /// <summary>
    /// Characterizes a natural number, i.e. one of {0,1,...} subject to the maximum
    /// value of the underlying primitive
    /// </summary>
    /// <typeparam name="S">The type of the realizing structure</typeparam>
    /// <typeparam name="P">The type of the underlying primitive</typeparam>
    public interface Natural<S,P> : UnsignedInt<S,P>
        where S : Natural<S,P>, new()
        where P : new()
    {
        
    }
}
