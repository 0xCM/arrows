//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IFreeGroup<S> : IGroupA<S>, IFreeMonoid<S>
        where S : IFreeGroup<S>, new()
    {
        
    }
    
    public interface IFreeGroup<S,T> : IFreeGroup<S>
        where S : IFreeGroup<S,T>, new()
    {
        
    }

}