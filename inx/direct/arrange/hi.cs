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
        public static Vec128<sbyte> hi(in Vec256<sbyte> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<byte> hi(in Vec256<byte> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<short> hi(in Vec256<short> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<ushort> hi(in Vec256<ushort> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<int> hi(in Vec256<int> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<uint> hi(in Vec256<uint> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<long> hi(in Vec256<long> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<ulong> hi(in Vec256<ulong> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<float> hi(in Vec256<float> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<double> hi(in Vec256<double> src)
            => ExtractVector128(src,1);
    }

}