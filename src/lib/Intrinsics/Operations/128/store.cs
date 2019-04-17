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
    using static inX;

    partial class InX
    {

        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<sbyte> src, sbyte[] dst, int offset = 0)
        {
            fixed (sbyte* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<sbyte>> src, sbyte[] dst, int offset = 0)
        {
            for(int i=0, nextOffset = offset; i<src.Count; i++, nextOffset += Vec128<byte>.Length)
                store(src[i], dst, nextOffset);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<byte> src, byte[] dst, int offset = 0)
        {
            fixed (byte* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<byte>> src, byte[] dst, int startpos = 0)
        {
            for(int i=0, nexpos = startpos; i<src.Count; i++, nexpos += Vec128<byte>.Length)
                store(src[i], dst, nexpos);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<short> src, short[] dst, int offset = 0)
        {
            fixed (short* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<short>> src, short[] dst, int offset = 0)
        {
            for(int i=0, nexpos = offset; i<src.Count; i++, nexpos += Vec128<short>.Length)
                store(src[i], dst, nexpos);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<ushort> src, ushort[] dst, int offset = 0)
        {
            fixed (ushort* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }


        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<ushort>> src, ushort[] dst, int offset = 0)
        {
            for(int i=0, nexpos = offset; i<src.Count; i++, nexpos += Vec128<ushort>.Length)
                store(src[i], dst, nexpos);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<int> src, int[] dst, int offset = 0)
        {
            fixed (int* pdst = &dst[offset = 0])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<int>> src, int[] dst, int offset = 0)
        {
            checkTarget(src,dst,offset);

            for(int i=0, nextOffset = offset; i<src.Count; i++, nextOffset += Vec128<int>.Length)
                store(src[i], dst, nextOffset);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<uint> src, uint[] dst, int offset = 0)
        {
            fixed (uint* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        

        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<uint>> src, uint[] dst, int offset = 0)
        {
            checkTarget(src,dst,offset);

            for(int i=0, nextOffset = offset; i < src.Count; i++, nextOffset += Vec128<uint>.Length)
                store(src[i], dst, nextOffset);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<long> src, long[] dst, int offset = 0)
        {
            fixed (long* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<long>> src, long[] dst, int offset = 0)
        {
            checkTarget(src,dst,offset);

            for(int i=0, nextOffset = offset; i<src.Count; i++, nextOffset += Vec128<long>.Length)
                store(src[i], dst, nextOffset);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<ulong> src, ulong[] dst, int offset = 0)
        {
            fixed (ulong* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<ulong>> src, ulong[] dst, int offset = 0)
        {
            checkTarget(src,dst,offset);

            for(int i=0, nextOffset = offset; i<src.Count; i++, nextOffset += Vec128<ulong>.Length)
                store(src[i], dst, nextOffset);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<float> src, float[] dst, int offset = 0)
        {
            fixed (float* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<float>> src, float[] dst, int offset = 0)
        {
            checkTarget(src,dst,offset);

            for(int i=0, nextOffset = offset; i<src.Count; i++, nextOffset += Vec128<float>.Length)
                store(src[i], dst, nextOffset);                    
        }

        [MethodImpl(Inline)]
        public static unsafe void store(Vec128<double> src, double[] dst, int offset = 0)
        {
            fixed (double* pdst = &dst[offset])
                Avx2.Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(IReadOnlyList<Vec128<double>> src, double[] dst, int offset = 0)
        {
            checkTarget(src,dst,offset);

            for(int i=0, nextOffset = offset; i<src.Count; i++, nextOffset += Vec128<double>.Length)
                store(src[i], dst, nextOffset);                    
        }

    }

}