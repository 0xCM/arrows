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
    using static inxfunc;

    partial class dinx
    {

        /// <summary>
        /// Writes a scalar value to an array segment
        /// </summary>
        /// <param name="src">The soruce vector</param>
        /// <param name="dst">The target array</param>
        /// <param name="startpos">The array index of the first element</param>
        [MethodImpl(Inline)]
        public static unsafe float[] store(Num128<float> src, float[] dst, int startpos)
        {
            fixed (float* pdst = &dst[startpos])
            {                
                Avx2.StoreScalar(pdst,src);
                return dst;
            }                
        }

        /// <summary>
        /// Writes a scalar value to an array segment
        /// </summary>
        /// <param name="src">The soruce vector</param>
        /// <param name="dst">The target array</param>
        /// <param name="startpos">The array index of the first element</param>
        [MethodImpl(Inline)]
        public static unsafe double[] store(Num128<double> src, double[] dst, int startpos)
        {
            fixed (double* pdst = &dst[startpos])
            {                
                Avx2.StoreScalar(pdst,src);
                return dst;
            }                
        }
 
        [MethodImpl(Inline)]
        public static unsafe void store(in Num128<float> src, float[] dst, int offset = 0)
        {
            fixed (float* pdst = &dst[offset])
                Avx2.StoreScalar(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Num128<float> src, void* dst)
            => Avx2.StoreScalar((float*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Num128<double> src, void* dst)
            => Avx2.StoreScalar((double*)dst,src);            

        //! vec[T] -> T* -> void
        //! ---------------------------------------------------------------


        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<byte> src, void* dst)
            => Avx2.Store((byte*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<sbyte> src, void* dst)
            => Avx2.Store((sbyte*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<short> src, void* dst)
            => Avx2.Store((short*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ushort> src, void* dst)
            => Avx2.Store((ushort*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<int> src, void* dst)
            => Avx2.Store((int*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<uint> src, void* dst)
            => Avx2.Store((uint*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<long> src, void* dst)
            => Avx2.Store((long*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ulong> src, void* dst)
            => Avx2.Store((ulong*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<float> src, void* dst)
            => Avx2.Store((float*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<double> src, void* dst)
            => Avx2.Store((double*)dst,src);            

        //! vec [T] -> [T]
        //! ---------------------------------------------------------------


        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<sbyte> src, sbyte[] dst, int offset = 0)
        {
            fixed (sbyte* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<byte> src, byte[] dst, int offset = 0)
        {
            fixed (byte* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<short> src, short[] dst, int offset = 0)
        {
            fixed (short* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ushort> src, ushort[] dst, int offset = 0)
        {
            fixed (ushort* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<int> src, int[] dst, int offset = 0)
        {
            fixed (int* pdst = &dst[offset = 0])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<uint> src, uint[] dst, int offset = 0)
        {
            fixed (uint* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }        

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<long> src, long[] dst, int offset = 0)
        {
            fixed (long* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }


        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ulong> src, ulong[] dst, int offset = 0)
        {
            fixed (ulong* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<float> src, float[] dst, int offset = 0)
        {
            fixed (float* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<double> src, double[] dst, int offset = 0)
        {
            fixed (double* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        //! index[vec[T]] -> [T]
        //! ---------------------------------------------------------------

        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<sbyte>> src, sbyte[] dst, int offset = 0)
        {
            for(int i=0, nextOffset = offset; i<src.Count; i++, nextOffset += Vec128<sbyte>.Length)
                store(src[i], dst, nextOffset);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<byte>> src, byte[] dst, int offset = 0)
        {
            for(int i=0, nextOffset = offset; i<src.Count; i++, nextOffset += Vec128<byte>.Length)
                store(src[i], dst, nextOffset);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<short>> src, short[] dst, int offset = 0)
        {
            for(int i=0, nexpos = offset; i<src.Count; i++, nexpos += Vec128<short>.Length)
                store(src[i], dst, nexpos);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<ushort>> src, ushort[] dst, int offset = 0)
        {
            for(int i=0, nexpos = offset; i<src.Count; i++, nexpos += Vec128<ushort>.Length)
                store(src[i], dst, nexpos);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<int>> src, int[] dst, int offset = 0)
        {
            checkTarget(src,dst,offset);

            for(int i=0, nextOffset = offset; i<src.Count; i++, nextOffset += Vec128<int>.Length)
                store(src[i], dst, nextOffset);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<uint>> src, uint[] dst, int offset = 0)
        {
            checkTarget(src,dst,offset);

            for(int i=0, nextOffset = offset; i < src.Count; i++, nextOffset += Vec128<uint>.Length)
                store(src[i], dst, nextOffset);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<long>> src, long[] dst, int offset = 0)
        {
            checkTarget(src,dst,offset);

            for(int i=0, nextOffset = offset; i<src.Count; i++, nextOffset += Vec128<long>.Length)
                store(src[i], dst, nextOffset);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<ulong>> src, ulong[] dst, int offset = 0)
        {
            checkTarget(src,dst,offset);

            for(int i=0, nextOffset = offset; i<src.Count; i++, nextOffset += Vec128<ulong>.Length)
                store(src[i], dst, nextOffset);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<float>> src, float[] dst, int offset = 0)
        {
            checkTarget(src,dst,offset);

            for(int i=0, nextOffset = offset; i<src.Count; i++, nextOffset += Vec128<float>.Length)
                store(src[i], dst, nextOffset);                    
        }


        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<double>> src, double[] dst, int offset = 0)
        {
            checkTarget(src,dst,offset);

            for(int i=0, nextOffset = offset; i<src.Count; i++, nextOffset += Vec128<double>.Length)
                store(src[i], dst, nextOffset);                    
        }


        //! vec[T] -> span[T]
        //! ---------------------------------------------------------------

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<byte> src, Span<byte> dst, int offset = 0)
        {
            fixed (byte* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<sbyte> src, Span<sbyte> dst, int offset = 0)
        {
            fixed (sbyte* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<short> src, Span<short> dst, int offset = 0)
        {
            fixed (short* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ushort> src, Span<ushort> dst, int offset = 0)
        {
            fixed (ushort* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<int> src, Span<int> dst, int offset = 0)
        {
            fixed (int* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<uint> src, Span<uint> dst, int offset = 0)
        {
            fixed (uint* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<long> src, Span<long> dst, int offset = 0)
        {
            fixed (long* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ulong> src, Span<ulong> dst, int offset = 0)
        {
            fixed (ulong* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<float> src, Span<float> dst, int offset = 0)
        {
            fixed (float* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<double> src, Span<double> dst, int offset = 0)
        {
            fixed (double* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }
    }

}