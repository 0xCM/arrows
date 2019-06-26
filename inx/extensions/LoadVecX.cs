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

    public static class LoadVecX
    {
        [MethodImpl(Inline)]
        public static Vec128<sbyte> LoadVec128(this ReadOnlySpan128<sbyte> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<byte> LoadVec128(this ReadOnlySpan128<byte> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<short> LoadVec128(this ReadOnlySpan128<short> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<ushort> LoadVec128(this ReadOnlySpan128<ushort> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<int> LoadVec128(this ReadOnlySpan128<int> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<uint> LoadVec128(this ReadOnlySpan128<uint> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<long> LoadVec128(this ReadOnlySpan128<long> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<ulong> LoadVec128(this ReadOnlySpan128<ulong> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<float> LoadVec128(this ReadOnlySpan128<float> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec128<double> LoadVec128(this ReadOnlySpan128<double> src, int offset)
            => Vec128.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<sbyte> LoadVec256(this ReadOnlySpan256<sbyte> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<byte> LoadVec256(this ReadOnlySpan256<byte> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<short> LoadVec256(this ReadOnlySpan256<short> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<ushort> LoadVec256(this ReadOnlySpan256<ushort> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<int> LoadVec256(this ReadOnlySpan256<int> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<uint> LoadVec256(this ReadOnlySpan256<uint> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<long> LoadVec256(this ReadOnlySpan256<long> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<ulong> LoadVec256(this ReadOnlySpan256<ulong> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<float> LoadVec256(this ReadOnlySpan256<float> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));

        [MethodImpl(Inline)]
        public static Vec256<double> LoadVec256(this ReadOnlySpan256<double> src, int offset)
            => Vec256.load(ref asRef(in src[offset]));    
    }
}