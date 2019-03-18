//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;

    /// <summary>
    /// Characterizes a set of mappings
    /// </summary>
    /// <typeparam name="A">The domain of the contained mappings</typeparam>
    /// <typeparam name="B">The codomain of the contained mappings</typeparam>
    public interface HomSet<A,B> : Set<Func<A,B>>
    {
        
    }


}