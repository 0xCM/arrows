//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zcore;
    using static x86;

    partial class InX256
    {
        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> load256v(sbyte[] src, int startpos)
        {
            fixed (sbyte* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> load256v(byte[] src, int startpos)
        {
            fixed (byte* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> load256v(short[] src, int startpos)
        {
            fixed (short* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> load256v(ushort[] src, int startpos)
        {
            fixed (ushort* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> load256v(int[] src, int startpos)
        {
            fixed (int* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> load256v(uint[] src, int startpos)
        {
            fixed (uint* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> load256v(long[] src, int startpos)
        {
            fixed (long* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> load256v(ulong[] src, int startpos)
        {
            fixed (ulong* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> load256v(float[] src, int startpos)
        {
            fixed (float* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }

       [MethodImpl(Inline)]
        public static unsafe Vec256<double> load256v(double[] src, int startpos)
        {
            fixed (double* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }
    }
}