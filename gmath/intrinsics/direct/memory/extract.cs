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
    using static System.Runtime.Intrinsics.X86.Avx;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<sbyte> extract(Vec256<sbyte> src, byte index)
            => ExtractVector128(src,index);

        [MethodImpl(Inline)]
        public static Vec128<byte> extract(Vec256<byte> src, byte index)
            => ExtractVector128(src,index);

        [MethodImpl(Inline)]
        public static Vec128<short> extract(Vec256<short> src, byte index)
            => ExtractVector128(src,index);

        [MethodImpl(Inline)]
        public static Vec128<ushort> extract(Vec256<ushort> src, byte index)
            => ExtractVector128(src,index);

        [MethodImpl(Inline)]
        public static Vec128<int> extract(Vec256<int> src, byte index)
            => ExtractVector128(src,index);

        [MethodImpl(Inline)]
        public static Vec128<uint> extract(Vec256<uint> src, byte index)
            => ExtractVector128(src,index);

        [MethodImpl(Inline)]
        public static Vec128<long> extract(Vec256<long> src, byte index)
            => ExtractVector128(src,index);

        [MethodImpl(Inline)]
        public static Vec128<ulong> extract(Vec256<ulong> src, byte index)
            => ExtractVector128(src,index);

        [MethodImpl(Inline)]
        public static Vec128<float> extract(Vec256<float> src, byte index)
            => ExtractVector128(src,index);

        [MethodImpl(Inline)]
        public static Vec128<double> extract(Vec256<double> src, byte index)
            => ExtractVector128(src,index);

    }
}