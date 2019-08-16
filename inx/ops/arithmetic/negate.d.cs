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
    using static System.Runtime.Intrinsics.X86.Fma;        
    using static zfunc;

    partial class dinx    
    {
        [MethodImpl(Inline)]
        public static Vec128<sbyte> negate(in Vec128<sbyte> src)
            =>  sub(Vec128<sbyte>.Zero, src);

        [MethodImpl(Inline)]
        public static Vec128<byte> negate(in Vec128<byte> src)
            =>  add(BitUtil.flip(src), Vec128.Ones<byte>());

        [MethodImpl(Inline)]
        public static Vec128<short> negate(in Vec128<short> src)
            =>  sub(Vec128<short>.Zero, src);

        [MethodImpl(Inline)]
        public static Vec128<ushort> negate(in Vec128<ushort> src)
            =>  add(BitUtil.flip(src), Vec128.Ones<ushort>());

        [MethodImpl(Inline)]
        public static Vec128<int> negate(in Vec128<int> src)
            =>  sub(Vec128<int>.Zero, src);

        [MethodImpl(Inline)]
        public static Vec128<uint> negate(in Vec128<uint> src)
            =>  add(BitUtil.flip(src), Vec128.Ones<uint>());

        [MethodImpl(Inline)]
        public static Vec128<long> negate(in Vec128<long> src)
            =>  sub(Vec128<long>.Zero, src);

        [MethodImpl(Inline)]
        public static Vec128<ulong> negate(in Vec128<ulong> src)
            =>  add(BitUtil.flip(src), Vec128.Ones<ulong>());

        [MethodImpl(Inline)]
        public static Vec128<float> negate(in Vec128<float> src)
            =>  sub(Vec128<float>.Zero, src);

        [MethodImpl(Inline)]
        public static Vec128<double> negate(in Vec128<double> src)
            =>  sub(Vec128<double>.Zero, src);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> negate(in Vec256<sbyte> src)
            =>  sub(Vec256<sbyte>.Zero, src);

        [MethodImpl(Inline)]
        public static Vec256<byte> negate(in Vec256<byte> src)
            =>  add(BitUtil.flip(src), Vec256.Ones<byte>());

        [MethodImpl(Inline)]
        public static Vec256<short> negate(in Vec256<short> src)
            =>  sub(Vec256<short>.Zero, src);

        [MethodImpl(Inline)]
        public static Vec256<ushort> negate(in Vec256<ushort> src)
            =>  add(BitUtil.flip(src), Vec256.Ones<ushort>());

        [MethodImpl(Inline)]
        public static Vec256<int> negate(in Vec256<int> src)
            =>  sub(Vec256<int>.Zero, src);

        [MethodImpl(Inline)]
        public static Vec256<uint> negate(in Vec256<uint> src)
            =>  add(BitUtil.flip(src), Vec256.Ones<uint>());

        [MethodImpl(Inline)]
        public static Vec256<long> negate(in Vec256<long> src)
            =>  sub(Vec256<long>.Zero, src);

        [MethodImpl(Inline)]
        public static Vec256<ulong> negate(in Vec256<ulong> src)
            =>  add(BitUtil.flip(src), Vec256.Ones<ulong>());

        [MethodImpl(Inline)]
        public static Vec256<float> negate(in Vec256<float> src)
            =>  sub(Vec256<float>.Zero, src);

        [MethodImpl(Inline)]
        public static Vec256<double> negate(in Vec256<double> src)
            =>  sub(Vec256<double>.Zero, src);

    }
}