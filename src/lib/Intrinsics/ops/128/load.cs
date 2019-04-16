//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zcore;
    using static x86;

    public interface InX128Load<T> : InX128Op<T>
        where T : struct, IEquatable<T>
    {
        /// <summary>
        /// Hydrates a signle vector from the data starting at a specified position in an arry
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="startpos">The 0-based start position</param>
        Vec128<T> load(T[] src, int startpos = 0);

        /// <summary>
        /// Hydrates a stream of vectors from the entirety of an array
        /// </summary>
        /// <param name="src">The source array</param>
        IEnumerable<Vec128<T>> load(T[] src);

    }


    partial class InX
    {

        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> load(byte[] src, int startpos = 0)
        {
            fixed (byte* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> load(sbyte[] src, int startpos = 0)
        {
            fixed (sbyte* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> load(short[] src, int startpos = 0)
        {
            fixed (short* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }



        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> load(ushort[] src, int startpos = 0)
        {
            fixed (ushort* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> load(int[] src, int startpos = 0)
        {
            fixed (int* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }
 

        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> load(uint[] src, int startpos = 0)
        {
            fixed (uint* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }



        [MethodImpl(Inline)]
        public static unsafe Vec128<long> load(long[] src, int startpos = 0)
        {
            fixed (long* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> load(ulong[] src, int startpos = 0)
        {
            fixed (ulong* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> load(float[] src, int startpos = 0)
        {
            fixed (float* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }
 
        [MethodImpl(Inline)]
        public static unsafe Vec128<double> load(double[] src, int startpos = 0)
        {
            fixed (double* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> load(Span128<sbyte> src)
        {
            fixed (sbyte* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> load(Span128<byte> src)
        {
            fixed (byte* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> load(Span128<short> src)
        {
            fixed (short* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> load(Span128<ushort> src)
        {
            fixed (ushort* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> load(Span128<int> src)
        {
            fixed (int* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> load(Span128<uint> src)
        {
            fixed (uint* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<long> load(Span128<long> src)
        {
            fixed (long* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> load(Span128<ulong> src)
        {
            fixed (ulong* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> load(Span128<float> src)
        {
            fixed (float* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<double> load(Span128<double> src)
        {
            fixed (double* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }
    }
}