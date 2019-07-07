//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;

    public static partial class BitMatrixX
    {   
        [MethodImpl(Inline)]
        public static BitVector8 Row(this in BitMatrix8 src, int index)
            => src.bits[index];

        [MethodImpl(Inline)]
        public static BitVector16 Row(this in BitMatrix16 src, int index)
            => src.bits[index];

        [MethodImpl(Inline)]
        public static BitVector32 Row(this in BitMatrix32 src, int index)
            => src.bits[index];

        [MethodImpl(Inline)]
        public static BitVector64 Row(this in BitMatrix64 src, int index)
            => src.bits[index];

 
    }
}