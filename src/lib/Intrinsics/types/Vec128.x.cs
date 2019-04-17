//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zcore;
    using static inX;

    partial class InXX
    {

        [MethodImpl(Inline)]
        public static Vec128<sbyte> NextVec128(this IEnumerable<sbyte> src)
            => Vec128.define(src.TakeArray(Vec128<sbyte>.Length));

        [MethodImpl(Inline)]
        public static Vec128<short> NextVec128(this IEnumerable<short> src)
                => Vec128.define(src.TakeArray(Vec128<short>.Length));

        [MethodImpl(Inline)]
        public static Vec128<ushort> NextVec128(this IEnumerable<ushort> src)
                => Vec128.define(src.TakeArray(Vec128<ushort>.Length));

        [MethodImpl(Inline)]
        public static Vec128<int> NextVec128(this IEnumerable<int> src)
                => Vec128.define(src.TakeArray(Vec128<int>.Length));

        [MethodImpl(Inline)]
        public static Vec128<int> ToVec128(this int[] src)
                => Vec128.define(src);

        [MethodImpl(Inline)]
        public static Vec128<uint> NextVec128(this IEnumerable<uint> src)
                => Vec128.define(src.TakeArray(Vec128<uint>.Length));

        [MethodImpl(Inline)]
        public static Vec128<uint> ToVec128(this uint[] src)
                => Vec128.define(src);

        [MethodImpl(Inline)]
        public static Vec128<long> NextVec128(this IEnumerable<long> src)
                => Vec128.define(src.TakeArray(Vec128<long>.Length));

        [MethodImpl(Inline)]
        public static Vec128<ulong> NextVec128(this IEnumerable<ulong> src)
                => Vec128.define(src.TakeArray(Vec128<ulong>.Length));

        [MethodImpl(Inline)]
        public static Vec128<ulong> ToVec128(this ulong[] src)
                => Vec128.define(src);

        [MethodImpl(Inline)]
        public static Vec128<float> NextVec128(this IEnumerable<float> src)
                => Vec128.define(src.TakeArray(Vec128<float>.Length));

        [MethodImpl(Inline)]
        public static Vec128<double> NextVec128(this IEnumerable<double> src)
                => Vec128.define(src.TakeArray(Vec128<double>.Length));
    }
}