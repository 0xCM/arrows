//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;

    public static class SliceX
    {
        [MethodImpl(Inline)]
        public static Slice<N,T> Slice<N,T>(this Z0.TypeNat<N> nat, IEnumerable<T> src)
            where N : TypeNat, new()
                => new Slice<N, T>(src);
    
        [MethodImpl(Inline)]
        public static Vector<N,T> ToVector<N,T>(this Slice<N,T> src)
            where N : TypeNat, new()
                => vector<N,T>(src.cells);

        [MethodImpl(Inline)]
        public static Vector<N,T> Vector<N,T>(this Z0.TypeNat<N> nat, params T[] components)
            where N : TypeNat, new()
                => new Vector<N, T>(components);

    }
}    