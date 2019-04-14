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
    using static x86;

    partial class InX
    {
        [MethodImpl(Inline)]
        public static unsafe void store(sbyte* dst, Vec128<sbyte> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(sbyte* dst, Vec256<sbyte> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(byte* dst, Vec128<byte> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(byte* dst, Vec256<byte> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(short* dst, Vec128<short> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(short* dst, Vec256<short> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(ushort* dst, Vec128<ushort> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(ushort* dst, Vec256<ushort> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(int* dst, Vec128<int> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(int* dst, Vec256<int> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(uint* dst, Vec128<uint> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(uint* dst, Vec256<uint> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(long* dst, Vec128<long> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(long* dst, Vec256<long> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(ulong* dst, Vec128<ulong> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(ulong* dst, Vec256<ulong> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(float* dst, Vec128<float> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(float* dst, Vec256<float> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(double* dst, Vec128<double> src)
            => Avx2.Store(dst,src);

        [MethodImpl(Inline)]
        public static unsafe void store(double* dst, Vec256<double> src)
            => Avx2.Store(dst,src);
    }

}