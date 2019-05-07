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
    using static mfunc;


    partial class dinx
    {

        [MethodImpl(Inline)]
        public static byte extract(Vec128<byte> src, byte pos)
            => Avx2.Extract(src,pos);

        
        [MethodImpl(Inline)]
        public static int extract(Vec128<int> src, byte pos)
            => Avx2.Extract(src,pos);

        [MethodImpl(Inline)]
        public static uint extract(Vec128<uint> src, byte pos)
            => Avx2.Extract(src,pos);

        [MethodImpl(Inline)]
        public static long extract(Vec128<long> src, byte pos)
            => Avx2.X64.Extract(src,pos);

        [MethodImpl(Inline)]
        public static ulong extract(Vec128<ulong> src, byte pos)
            => Avx2.X64.Extract(src,pos);


        [MethodImpl(Inline)]
        public static float extract(Vec128<float> src, byte pos)
            => Avx2.Extract(src,pos);
    }

}