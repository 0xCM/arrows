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
    using System.Collections.Generic;
    
    using static zcore;
    using static x86;

    partial class InX
    {
        /// <summary>
        /// Writes the componets of a vector to an array segment
        /// </summary>
        /// <param name="src">The soruce vector</param>
        /// <param name="dst">The target array</param>
        /// <param name="startpos">The array index of the first element</param>
        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<sbyte> src, sbyte[] dst, int startpos)
        {
            fixed (sbyte* pdst = &dst[startpos])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<sbyte>> src, sbyte[] dst, int startpos = 0)
        {
            for(int i=0, nexpos = startpos; i<src.Count; i++, nexpos += Vec128<byte>.Length)
                store(src[i], dst, nexpos);                    
        }

        /// <summary>
        /// Writes the componets of a vector to an array segment
        /// </summary>
        /// <param name="src">The soruce vector</param>
        /// <param name="dst">The target array</param>
        /// <param name="startpos">The array index of the first element</param>
        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<byte> src, byte[] dst, int startpos)
        {
            fixed (byte* pdst = &dst[startpos])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<byte>> src, byte[] dst, int startpos = 0)
        {
            for(int i=0, nexpos = startpos; i<src.Count; i++, nexpos += Vec128<byte>.Length)
                store(src[i], dst, nexpos);                    
        }

        /// <summary>
        /// Writes the componets of a vector to an array segment
        /// </summary>
        /// <param name="src">The soruce vector</param>
        /// <param name="dst">The target array</param>
        /// <param name="startpos">The array index of the first element</param>
        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<short> src, short[] dst, int startpos)
        {
            fixed (short* pdst = &dst[startpos])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<short>> src, short[] dst, int startpos = 0)
        {
            for(int i=0, nexpos = startpos; i<src.Count; i++, nexpos += Vec128<short>.Length)
                store(src[i], dst, nexpos);                    
        }

        /// <summary>
        /// Writes the componets of a vector to an array segment
        /// </summary>
        /// <param name="src">The soruce vector</param>
        /// <param name="dst">The target array</param>
        /// <param name="startpos">The array index of the first element</param>
        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<ushort> src, ushort[] dst, int startpos)
        {
            fixed (ushort* pdst = &dst[startpos])
                Avx2.Store(pdst,src);
        }


        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<ushort>> src, ushort[] dst, int startpos = 0)
        {
            for(int i=0, nexpos = startpos; i<src.Count; i++, nexpos += Vec128<ushort>.Length)
                store(src[i], dst, nexpos);                    
        }

        /// <summary>
        /// Writes the componets of a vector to an array segment
        /// </summary>
        /// <param name="src">The soruce vector</param>
        /// <param name="dst">The target array</param>
        /// <param name="startpos">The array index of the first element</param>
        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<int> src, int[] dst, int startpos)
        {
            fixed (int* pdst = &dst[startpos])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<int>> src, int[] dst, int startpos = 0)
        {
            for(int i=0, nexpos = startpos; i<src.Count; i++, nexpos += Vec128<int>.Length)
                store(src[i], dst, nexpos);                    
        }

        /// <summary>
        /// Writes the componets of a vector to an array segment
        /// </summary>
        /// <param name="src">The soruce vector</param>
        /// <param name="dst">The target array</param>
        /// <param name="startpos">The array index of the first element</param>
        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<uint> src, uint[] dst, int startpos)
        {
            fixed (uint* pdst = &dst[startpos])
                Avx2.Store(pdst,src);
        }

        static Exception arrayToSmall(int arrayLen, int lenRequired, int vecCount)
            => new Exception($"Array of length {arrayLen} too small;" 
                + $" An array of length {lenRequired} is required to store {vecCount} vectors");
        
        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<uint>> src, uint[] dst, int startpos = 0)
        {
            var vecCount = src.Count;
            var required = Vec128<uint>.Length * vecCount;
            var available = dst.Length - startpos;
            
            if(required > available)
                throw arrayToSmall(dst.Length, required, vecCount);
        
            for(int i=0, nexpos = startpos; i < src.Count; i++, nexpos += Vec128<uint>.Length)
                store(src[i], dst, nexpos);                    
        }


        /// <summary>
        /// Writes the componets of a vector to an array segment
        /// </summary>
        /// <param name="src">The soruce vector</param>
        /// <param name="dst">The target array</param>
        /// <param name="startpos">The array index of the first element</param>
        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<long> src, long[] dst, int startpos)
        {
            fixed (long* pdst = &dst[startpos])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<long>> src, long[] dst, int startpos = 0)
        {
            for(int i=0, nexpos = startpos; i<src.Count; i++, nexpos += Vec128<long>.Length)
                store(src[i], dst, nexpos);                    
        }

        /// <summary>
        /// Writes the componets of a vector to an array segment
        /// </summary>
        /// <param name="src">The soruce vector</param>
        /// <param name="dst">The target array</param>
        /// <param name="startpos">The array index of the first element</param>
        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<ulong> src, ulong[] dst, int startpos)
        {
            fixed (ulong* pdst = &dst[startpos])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<ulong>> src, ulong[] dst, int startpos = 0)
        {
            for(int i=0, nexpos = startpos; i<src.Count; i++, nexpos += Vec128<ulong>.Length)
                store(src[i], dst, nexpos);                    
        }

        /// <summary>
        /// Writes the componets of a vector to an array segment
        /// </summary>
        /// <param name="src">The soruce vector</param>
        /// <param name="dst">The target array</param>
        /// <param name="startpos">The array index of the first element</param>
        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<float> src, float[] dst, int startpos)
        {
            fixed (float* pdst = &dst[startpos])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<float>> src, float[] dst, int startpos = 0)
        {
            for(int i=0, nexpos = startpos; i<src.Count; i++, nexpos += Vec128<float>.Length)
                store(src[i], dst, nexpos);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<double> src, double[] dst, int startpos)
        {
            fixed (double* pdst = &dst[startpos])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<double>> src, double[] dst, int startpos = 0)
        {
            for(int i=0, nexpos = startpos; i<src.Count; i++, nexpos += Vec128<double>.Length)
                store(src[i], dst, nexpos);                    
        }

    }

}