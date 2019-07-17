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
        public static Vec128<sbyte> lo(in Vec256<sbyte> src)
            => ExtractVector128(src,0);

        [MethodImpl(Inline)]
        public static Vec128<byte> lo(in Vec256<byte> src)
            => ExtractVector128(src,0);

        [MethodImpl(Inline)]
        public static Vec128<short> lo(in Vec256<short> src)
            => ExtractVector128(src,0);

        [MethodImpl(Inline)]
        public static Vec128<ushort> lo(in Vec256<ushort> src)
            => ExtractVector128(src,0);

        [MethodImpl(Inline)]
        public static Vec128<int> lo(in Vec256<int> src)
            => ExtractVector128(src,0);

        [MethodImpl(Inline)]
        public static Vec128<uint> lo(in Vec256<uint> src)
            => ExtractVector128(src,0);

        [MethodImpl(Inline)]
        public static Vec128<long> lo(in Vec256<long> src)
            => ExtractVector128(src,0);

        [MethodImpl(Inline)]
        public static Vec128<ulong> lo(in Vec256<ulong> src)
            => ExtractVector128(src,0);

        [MethodImpl(Inline)]
        public static Vec128<float> lo(in Vec256<float> src)
            => ExtractVector128(src,0);

        [MethodImpl(Inline)]
        public static Vec128<double> lo(in Vec256<double> src)
            => ExtractVector128(src,0);



    }

}