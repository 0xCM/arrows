//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static As;

    public static class InXX
    {

        [MethodImpl(Inline)]
        public static Vec128<sbyte> LoadVector(this ReadOnlySpan128<sbyte> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<byte> LoadVector(this ReadOnlySpan128<byte> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<short> LoadVector(this ReadOnlySpan128<short> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<ushort> LoadVector(this ReadOnlySpan128<ushort> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<int> LoadVector(this ReadOnlySpan128<int> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<uint> LoadVector(this ReadOnlySpan128<uint> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<long> LoadVector(this ReadOnlySpan128<long> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<ulong> LoadVector(this ReadOnlySpan128<ulong> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<float> LoadVector(this ReadOnlySpan128<float> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<double> LoadVector(this ReadOnlySpan128<double> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<sbyte> LoadVector(this ReadOnlySpan256<sbyte> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<byte> LoadVector(this ReadOnlySpan256<byte> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<short> LoadVector(this ReadOnlySpan256<short> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<ushort> LoadVector(this ReadOnlySpan256<ushort> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<int> LoadVector(this ReadOnlySpan256<int> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<uint> LoadVector(this ReadOnlySpan256<uint> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<long> LoadVector(this ReadOnlySpan256<long> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<ulong> LoadVector(this ReadOnlySpan256<ulong> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<float> LoadVector(this ReadOnlySpan256<float> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<double> LoadVector(this ReadOnlySpan256<double> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

    }
}