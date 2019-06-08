//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public interface ISymbol<S,T> :  IFreeMonoid<S>
        where S : ISymbol<S,T>, new()
        where T : INullary<T>, new()
    {
    }

}