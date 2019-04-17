//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zcore;
    using static inX;

    partial class InX
    {
        [MethodImpl(Inline)]
        public static Vec256<byte> abs(Vec256<sbyte> src)
            => Avx2.Abs(src);

        [MethodImpl(Inline)]
        public static Vec256<ushort> abs(Vec256<short> src)
            => Avx2.Abs(src);

        [MethodImpl(Inline)]
        public static Vec256<uint> abs(Vec256<int> src)
            => Avx2.Abs(src);



    }
}