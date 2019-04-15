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

    partial class InX
    {
        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> load128v(sbyte[] src, int startpos)
        {
            fixed (sbyte* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> load256v(sbyte[] src, int startpos)
        {
            fixed (sbyte* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> load128v(byte[] src, int startpos)
        {
            fixed (byte* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> load256v(byte[] src, int startpos)
        {
            fixed (byte* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec128<short> load128v(short[] src, int startpos)
        {
            fixed (short* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> load256v(short[] src, int startpos)
        {
            fixed (short* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> load128v(ushort[] src, int startpos)
        {
            fixed (ushort* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> load256v(ushort[] src, int startpos)
        {
            fixed (ushort* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }


       [MethodImpl(Inline)]
        public static unsafe Vec128<int> load128v(int[] src, int startpos)
        {
            fixed (int* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> load256v(int[] src, int startpos)
        {
            fixed (int* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }
 
        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> load128v(uint[] src, int startpos)
        {
            fixed (uint* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> load256v(uint[] src, int startpos)
        {
            fixed (uint* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec128<long> load128v(long[] src, int startpos)
        {
            fixed (long* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> load256v(long[] src, int startpos)
        {
            fixed (long* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> load128v(ulong[] src, int startpos)
        {
            fixed (ulong* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> load256v(ulong[] src, int startpos)
        {
            fixed (ulong* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec128<float> load128v(float[] src, int startpos)
        {
            fixed (float* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> load256v(float[] src, int startpos)
        {
            fixed (float* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<double> load128v(double[] src, int startpos)
        {
            fixed (double* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> load256v(double[] src, int startpos)
        {
            fixed (double* psrc = &src[startpos])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        static Exception segerror<T>(T[] src)
            => new Exception($"The source array of {typename<int>()} values with length {src.Length} is not segmented properly");                


        static int alloc<T>(T[] src, out Vec128<T>[] dst)
            where T : struct, IEquatable<T>
        {
            var vecLen = Vec128<T>.Length;
            var vecCount = src.Length / vecLen;
            if(src.Length % vecCount != 0)
               throw segerror(src);

            dst = new Vec128<T>[vecCount];
            return vecLen;
        }

        /// <summary>
        /// Presents an array of vectorized mutable views over an array of values
        /// </summary>
        /// <param name="src">The source array</param>
        public static Vec128<sbyte>[] load128v(sbyte[] src)
        {
            var veclen = alloc(src, out Vec128<sbyte>[] dst);
            for(var i=0; i< dst.Length; i++)
                dst[i] = load128v(src, i*veclen);
            return dst;
        }

        /// <summary>
        /// Presents an array of vectorized mutable views over an array of values
        /// </summary>
        /// <param name="src">The source array</param>
        public static Vec128<byte>[] load128v(byte[] src)
        {
            var veclen = alloc(src, out Vec128<byte>[] dst);
            for(var i=0; i< dst.Length; i++)
                dst[i] = load128v(src, i*veclen);
            return dst;
        }

        /// <summary>
        /// Presents an array of vectorized mutable views over an array of values
        /// </summary>
        /// <param name="src">The source array</param>
        public static Vec128<short>[] load128v(short[] src)
        {
            var veclen = alloc(src, out Vec128<short>[] dst);
            for(var i=0; i< dst.Length; i++)
                dst[i] = load128v(src, i*veclen);
            return dst;
        }

        /// <summary>
        /// Presents an array of vectorized mutable views over an array of values
        /// </summary>
        /// <param name="src">The source array</param>
        public static Vec128<ushort>[] load128v(ushort[] src)
        {
            var veclen = alloc(src, out Vec128<ushort>[] dst);
            for(var i=0; i< dst.Length; i++)
                dst[i] = load128v(src, i*veclen);
            return dst;
        }

        /// <summary>
        /// Presents an array of vectorized mutable views over an array of values
        /// </summary>
        /// <param name="src">The source array</param>
        public static Vec128<int>[] load128v(int[] src)
        {
            var veclen = alloc(src, out Vec128<int>[] dst);
            for(var i=0; i< dst.Length; i++)
                dst[i] = load128v(src, i*veclen);
            return dst;
        }

        /// <summary>
        /// Presents an array of vectorized mutable views over an array of values
        /// </summary>
        /// <param name="src">The source array</param>
        public static Vec128<uint>[] load128v(uint[] src)
        {
            var veclen = alloc(src, out Vec128<uint>[] dst);
            for(var i=0; i< dst.Length; i++)
                dst[i] = load128v(src, i*veclen);
            return dst;
        }

        /// <summary>
        /// Presents an array of vectorized mutable views over an array of values
        /// </summary>
        /// <param name="src">The source array</param>
        public static Vec128<long>[] load128v(long[] src)
        {        
            var veclen = alloc(src, out Vec128<long>[] dst);
            for(var i=0; i< dst.Length; i++)
                dst[i] = load128v(src, i*veclen);
            return dst;
        }
        
        /// <summary>
        /// Presents an array of vectorized mutable views over an array of values
        /// </summary>
        /// <param name="src">The source array</param>
        public static Vec128<ulong>[] load128v(ulong[] src)
        {        
            var veclen = alloc(src, out Vec128<ulong>[] dst);
            for(var i=0; i< dst.Length; i++)
                dst[i] = load128v(src, i*veclen);
            return dst;
        }

        /// <summary>
        /// Presents an array of vectorized mutable views over an array of values
        /// </summary>
        /// <param name="src">The source array</param>
        public static Vec128<float>[] load128v(float[] src)
        {        
            var veclen = alloc(src, out Vec128<float>[] dst);
            for(var i=0; i< dst.Length; i++)
                dst[i] = load128v(src, i*veclen);
            return dst;
        }

        /// <summary>
        /// Presents an array of vectorized mutable views over an array of values
        /// </summary>
        /// <param name="src">The source array</param>
        public static Vec128<double>[] load128v(double[] src)
        {        
            var veclen = alloc(src, out Vec128<double>[] dst);
            for(var i=0; i< dst.Length; i++)
                dst[i] = load128v(src, i*veclen);
            return dst;
        }


        /// <summary>
        /// Presents a stream of vectorized mutable views over an array of values
        /// </summary>
        /// <param name="src">The source array</param>
        public static IEnumerable<Vec128<uint>> stream128v(uint[] src)
        {            
            var veclen = Vec128<uint>.Length;
            for(var i=0; i< src.Length; i += veclen)
                yield return load128v(src, i);
        }

    }
}