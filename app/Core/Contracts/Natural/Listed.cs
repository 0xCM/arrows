//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using C = Contracts;

    using static corefunc;

    /// <summary>
    /// Characterizes an immutable list whose length is specified via a typenat
    /// </summary>
    public interface Listed<N,T> : Enumerable<N,T>, IReadOnlyList<T>
        where N : C.TypeNat
    {
    
    }

    public interface Array<N,T> : Enumerable<N,T>
        where N : C.TypeNat
    {
        T this[int ix] {get; set;}

    }


}