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

        #region store to pointer

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

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<sbyte> src, void* dst)
            => Avx2.Store((sbyte*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<byte> src, void* dst)
            => Avx2.Store((byte*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<short> src, void* dst)
            => Avx2.Store((short*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<ushort> src, void* dst)
            => Avx2.Store((ushort*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<int> src, void* dst)
            => Avx2.Store((int*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<uint> src, void* dst)
            => Avx2.Store((uint*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<long> src, void* dst)
            => Avx2.Store((long*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<ulong> src, void* dst)
            => Avx2.Store((ulong*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<float> src, void* dst)
            => Avx2.Store((float*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<double> src, void* dst)
            => Avx2.Store((double*)dst,src);            

        #endregion



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