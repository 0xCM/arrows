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

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Ssse3;
    
    using static zfunc;    

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<byte> shuffle(in Vec128<byte> src, in Vec128<byte> mask)
            => Shuffle(src, mask);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> shuffle(in Vec128<sbyte> src, in Vec128<sbyte> mask)
            => Shuffle(src, mask);

        [MethodImpl(Inline)]
        public static Vec128<int> shuffle(in Vec128<int> src, byte control)
            => Shuffle(src, control);

        [MethodImpl(Inline)]
        public static Vec128<double> shuffle(in Vec128<double> lhs, in Vec128<double> rhs, byte control)
            => Shuffle(lhs,rhs, control);

        [MethodImpl(Inline)]
        public static Vec128<float> shuffle(in Vec128<float> lhs, in Vec128<float> rhs,  byte control)
            => Shuffle(lhs,rhs, control);

        [MethodImpl(Inline)]
        public static Vec128<short> shuffleHi(in Vec128<short> src, byte control)
            => ShuffleHigh(src, control);

        [MethodImpl(Inline)]
        public static Vec128<ushort> shuffleHi(in Vec128<ushort> src, byte control)
            => ShuffleHigh(src, control);

        [MethodImpl(Inline)]
        public static Vec128<short> shuffleLow(in Vec128<short> src, byte control)
            => ShuffleLow(src, control);

        [MethodImpl(Inline)]
        public static Vec128<ushort> shuffleLow(in Vec128<ushort> src, byte control)
            => ShuffleLow(src, control);
    }

}