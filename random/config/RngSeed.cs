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
    using System.Runtime.InteropServices;

    using static zfunc;

    public ref struct RngSeed<N,T>
        where N : ITypeNat, new()
        where T : struct
    {
        public RngSeed(Span<N,T> src)
            => this.Bytes = MemoryMarshal.AsBytes(src.Unsize());

        public ReadOnlySpan<byte> Bytes;

    }
}
