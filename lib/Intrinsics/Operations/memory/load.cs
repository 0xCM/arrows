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
    using static inxfunc;


    partial class InX
    {

        
        // ! Array load operators
        // ! ------------------------------------------------------------------


        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> load(byte[] src, int offset = 0)
        {
            fixed (byte* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> load(sbyte[] src, int offset = 0)
        {
            fixed (sbyte* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> load(short[] src, int offset = 0)
        {
            fixed (short* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> load(ushort[] src, int offset = 0)
        {
            fixed (ushort* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> load(int[] src, int offset = 0)
        {
            fixed (int* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }
 

        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> load(uint[] src, int offset = 0)
        {
            fixed (uint* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec128<long> load(long[] src, int offset = 0)
        {
            checklen128(src,offset);

            fixed (long* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> load(ulong[] src, int offset = 0)
        {
            fixed (ulong* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> load(float[] src, int offset = 0)
        {
            fixed (float* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }
 
        [MethodImpl(Inline)]
        public static unsafe Vec128<double> load(double[] src, int startpos = 0)
        {
            fixed (double* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }

        // ! Span128 load operators
        // ! ------------------------------------------------------------------

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
 
 
        // ! Parameter array load operators
        // ! ------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> load(params byte[] src)
        {
            checklen128(src);

            fixed(byte* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> load(params sbyte[] src)
        {
            checklen128(src);

            fixed(sbyte* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> load(params short[] src)
        {
            checklen128(src);

            fixed(short* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> load(params ushort[] src)
        {
            checklen128(src);

            fixed(ushort* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> load(params int[] src)
        {
            checklen128(src);

            fixed(int* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> load(params uint[] src)
        {
            checklen128(src);

            fixed(uint* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<long> load(params long[] src)
        {
            checklen128(src);

            fixed(long* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> load(params ulong[] src)
        {
            checklen128(src);

            fixed(ulong* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<double> load(params double[] src)
        {
            checklen128(src);

            fixed(double* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> load(params float[] src)
        {
            checklen128(src);

            fixed(float* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        //! Loads from pointers
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static unsafe Num128<int> load(void* src, out Num128<int> dst)
            => dst = Avx2.LoadScalarVector128((int*)src);

        [MethodImpl(Inline)]
        public static unsafe Num128<uint> load(void* src, out Num128<uint> dst)
            => dst = Avx2.LoadScalarVector128((uint*)src);

        [MethodImpl(Inline)]
        public static unsafe Num128<ulong> load(void* src, out Num128<ulong> dst)
            => dst = Avx2.LoadScalarVector128((ulong*) src);

        [MethodImpl(Inline)]
        public static unsafe Num128<float> load(void* src, out Num128<float> dst)
            => dst = Avx2.LoadScalarVector128((float*)src);

        [MethodImpl(Inline)]
        public static unsafe Num128<double> load(void* src, out Num128<double> dst)
            => dst = Avx2.LoadScalarVector128((double*)src);
        
        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> load(void* src, out Vec128<byte> dst)
            => dst = Avx2.LoadVector128((byte*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> load(void* src, out Vec128<sbyte> dst)
            => dst = Avx2.LoadVector128((sbyte*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> load(void* src, out Vec128<short> dst)
            => dst = Avx2.LoadVector128((short*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> load(void* src, out Vec128<ushort> dst)
            => dst = Avx2.LoadVector128((ushort*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> load(void* src, out Vec128<int> dst)
            => dst = Avx2.LoadVector128((int*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> load(void* src, out Vec128<uint> dst)
            => dst = Avx2.LoadVector128((uint*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<long> load(void* src, out Vec128<long> dst)
            => dst = Avx2.LoadVector128((long*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> load(void* src, out Vec128<ulong> dst)
            => dst = Avx2.LoadVector128((ulong*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> load(void* src, out Vec128<float> dst)
           => dst = Avx2.LoadVector128((float*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<double> load(void* src, out Vec128<double> dst)
            => dst = Avx2.LoadVector128((double*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> load(void* src, out Vec256<sbyte> dst)
            => dst = Avx2.LoadVector256((sbyte*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> load(void* src, out Vec256<byte> dst)
            => dst = Avx2.LoadVector256((byte*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> load(void* src, out Vec256<short> dst)
            => dst = Avx2.LoadVector256((short*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> load(void* src, out Vec256<ushort> dst)
            => dst = Avx2.LoadVector256((ushort*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> load(void* src, out Vec256<int> dst)
            => dst = Avx2.LoadVector256((int*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> load(void* src, out Vec256<uint> dst)
            => dst = Avx2.LoadVector256((uint*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> load(void* src, out Vec256<long> dst)
            => dst = Avx2.LoadVector256((long*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> load(void* src, out Vec256<ulong> dst)
            => dst = Avx2.LoadVector256((ulong*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> load(void* src, out Vec256<float> dst)
            => dst = Avx2.LoadVector256((float*)src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> load(void* src, out Vec256<double> dst)
            => dst = Avx2.LoadVector256((double*)src);
 

        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> load(byte* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> load(sbyte* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> load(short* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> load(ushort* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> load(int* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> load(uint* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<long> load(long* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> load(ulong* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> load(float* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<double> load(double* src)
            => Avx2.LoadVector128(src);
 

    }
}