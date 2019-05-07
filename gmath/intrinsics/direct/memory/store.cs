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
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zcore;
    using static mfunc;

    partial class dinx
    {

        #region store:vec -> *

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<byte> src, byte* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<sbyte> src, sbyte* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<short> src, short* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ushort> src, ushort* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<int> src, int* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<uint> src, uint* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<long> src, long* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ulong> src, ulong* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<float> src, float* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<double> src, double* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<sbyte> src, sbyte* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<byte> src, byte* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<short> src, short* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<ushort> src, ushort* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<int> src, int* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<uint> src, uint* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<long> src, long* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<ulong> src, ulong* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<float> src, float* dst)
            => Store(dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<double> src, double* dst)
            => Store(dst,src);            

        #endregion

        #region store:vec -> span -> offset

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<byte> src, Span<byte> dst, int offset = 0)
        {
            fixed (byte* pdst = &dst[offset])
                Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<sbyte> src, Span<sbyte> dst, int offset = 0)
        {
            fixed (sbyte* pdst = &dst[offset])
                Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<short> src, Span<short> dst, int offset = 0)
        {
            fixed (short* pdst = &dst[offset])
                Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ushort> src, Span<ushort> dst, int offset = 0)
        {
            fixed (ushort* pdst = &dst[offset])
                Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<int> src, Span<int> dst, int offset = 0)
        {
            fixed (int* pdst = &dst[offset])
                Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<uint> src, Span<uint> dst, int offset = 0)
        {
            fixed (uint* pdst = &dst[offset])
                Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<long> src, Span<long> dst, int offset = 0)
        {
            fixed (long* pdst = &dst[offset])
                Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ulong> src, Span<ulong> dst, int offset = 0)
        {
            fixed (ulong* pdst = &dst[offset])
                Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<float> src, Span<float> dst, int offset = 0)
        {
            fixed (float* pdst = &dst[offset])
                Store(pdst,src);
        }

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<double> src, Span<double> dst, int offset = 0)
        {
            fixed (double* pdst = &dst[offset])
                Store(pdst,src);
        }

        #endregion        
    }

}