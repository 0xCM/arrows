//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static corefunc;

    public static class SliceX
    {
        public static Slice<N,T> slice<N,T>(this Core.TypeNat<N> nat, IEnumerable<T> src)
            where N : TypeNat, new()
                => new Slice<N, T>(src);
    }
}    
