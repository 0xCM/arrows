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
    using static x86;

    public partial class Vec128
    {

        [MethodImpl(Inline)]
        public static Vec128<byte> abs(Vec128<sbyte> src)
            => Sse42.Abs(src);

        [MethodImpl(Inline)]
        public static Vec128<ushort> abs(Vec128<short> src)
            => Sse42.Abs(src);

        [MethodImpl(Inline)]
        public static Vec128<uint> abs(Vec128<int> src)
            => Sse42.Abs(src);


    }

}