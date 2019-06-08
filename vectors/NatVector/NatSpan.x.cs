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
    using System.Runtime.InteropServices;

    using static nfunc;
    using static zfunc;

    /// <summary>
    /// Defines a span of natural length N
    /// </summary>
    public static class NatSpanX
    {
        public static Span<N,T> ToNatSpan<N,T>(this Span<T> src, N size = default)
            where T : struct
            where N : ITypeNat, new()
                => new Span<N, T>(ref src);

    }

}