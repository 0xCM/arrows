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
        public static Vec128<byte> shuffle(Vec128<byte> src, Vec128<byte> mask)
            => Shuffle(src, mask);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> shuffle(Vec128<sbyte> src, Vec128<sbyte> mask)
            => Shuffle(src, mask);

        [MethodImpl(Inline)]
        public static Vec128<int> shuffle(Vec128<int> src, byte control)
            => Shuffle(src, control);

        [MethodImpl(Inline)]
        public static Vec128<double> shuffle(Vec128<double> lhs, Vec128<double> rhs,  byte control)
            => Shuffle(lhs,rhs, control);

        [MethodImpl(Inline)]
        public static Vec128<float> shuffle(Vec128<float> lhs, Vec128<float> rhs,  byte control)
            => Shuffle(lhs,rhs, control);

        [MethodImpl(Inline)]
        public static Vec128<short> shuffleHi(Vec128<short> src, byte control)
            => ShuffleHigh(src, control);

        [MethodImpl(Inline)]
        public static Vec128<ushort> shuffleHi(Vec128<ushort> src, byte control)
            => ShuffleHigh(src, control);

        [MethodImpl(Inline)]
        public static Vec128<short> shuffleLow(Vec128<short> src, byte control)
            => ShuffleLow(src, control);

        [MethodImpl(Inline)]
        public static Vec128<ushort> shuffleLow(Vec128<ushort> src, byte control)
            => ShuffleLow(src, control);
    }

}