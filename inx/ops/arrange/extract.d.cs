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
    
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse41.X64;
    using static System.Runtime.Intrinsics.X86.Sse42.X64;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static byte extract(in Vec128<byte> src, byte pos)
            => Extract(src,pos);

        [MethodImpl(Inline)]
        public static uint extract(in Vec128<ushort> src, byte pos)
            => Extract(src,pos);

        [MethodImpl(Inline)]
        public static int extract(in Vec128<int> src, byte pos)
            => Extract(src,pos);

        [MethodImpl(Inline)]
        public static uint extract(in Vec128<uint> src, byte pos)
            => Extract(src,pos);

        [MethodImpl(Inline)]
        public static long extract(in Vec128<long> src, byte pos)
            => Extract(src,pos);

        [MethodImpl(Inline)]
        public static ulong extract(in Vec128<ulong> src, byte pos)
            => Extract(src,pos);

        [MethodImpl(Inline)]
        public static float extract(in Vec128<float> src, byte pos)
            => Extract(src,pos);
    }
}