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
        public static unsafe Vec128<sbyte> load128v(sbyte* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> load256v(sbyte* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> load128v(byte* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> load256v(byte* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> load128v(short* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> load256v(short* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> load128v(ushort* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> load256v(ushort* src)
            => Avx2.LoadVector256(src);

       [MethodImpl(Inline)]
        public static unsafe Vec128<int> load128v(int* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> load256v(int* src)
            => Avx2.LoadVector256(src);

 
        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> load128v(uint* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> load256v(uint* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<long> load128v(long* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> load256v(long* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> load128v(ulong* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> load256v(ulong* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> load128v(float* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> load256v(float* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<double> load128v(double* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> load256v(double* src)
            => Avx2.LoadVector256(src); 
    }

}