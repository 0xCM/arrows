//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;

    public static class M512x
    {
        [MethodImpl(Inline)]
        public static BitString ToBitString(in this M512 src)
            => m512.bitstring(in src);

        [MethodImpl(Inline)]
        public static HexString ToHexString(in this M512 src)
            => m512.hexstring(in src);

    }

}