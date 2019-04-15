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
        public static unsafe Vec128<sbyte> load(Span128<sbyte> src, int startpos = 0)
        {
            fixed (sbyte* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> load(Span128<byte> src, int startpos = 0)
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
        public static unsafe Vec128<byte> load(byte[] src, int startpos = 0)
        {
            fixed (byte* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> load(Span128<short> src, int startpos = 0)
        {
            fixed (short* psrc = &src[startpos])
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
        public static unsafe Vec128<ushort> load(Span128<ushort> src, int startpos = 0)
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
        public static unsafe Vec128<int> load(Span128<int> src, int startpos = 0)
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
        public static unsafe Vec128<uint> load(Span128<uint> src, int startpos = 0)
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
        public static unsafe Vec128<long> load(Span128<long> src, int startpos = 0)
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
        public static unsafe Vec128<ulong> load(Span128<ulong> src, int startpos = 0)
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
        public static unsafe Vec128<float> load(Span128<float> src, int startpos = 0)
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
        public static unsafe Vec128<double> load(Span128<double> src, int startpos = 0)
        {
            fixed (double* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<sbyte>> load(sbyte[] src)
            => map(range(0, src.Length, Vec128<sbyte>.Length),i => load(src,i));    
            
        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<byte>> load(byte[] src)
            => map(range(0, src.Length, Vec128<byte>.Length),i => load(src,i));    

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<short>> load(short[] src)
            => map(range(0, src.Length, Vec128<short>.Length),i => load(src,i));

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<ushort>> load(ushort[] src)
            => map(range(0, src.Length, Vec128<ushort>.Length),i => load(src,i));

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<int>> load(int[] src)
            => map(range(0, src.Length, Vec128<int>.Length),i => load(src,i));

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<uint>> load(uint[] src)
            => map(range(0, src.Length, Vec128<uint>.Length),i => load(src,i));

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<long>> load(long[] src)
            => map(range(0, src.Length, Vec128<long>.Length),i => load(src,i));

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<ulong>> load(ulong[] src)
            => map(range(0, src.Length, Vec128<ulong>.Length),i => load(src,i));

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<float>> load(float[] src)
            => map(range(0, src.Length, Vec128<float>.Length),i => load(src,i));

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<double>> load(double[] src)
            => map(range(0, src.Length, Vec128<double>.Length),i => load(src,i));
    }
}