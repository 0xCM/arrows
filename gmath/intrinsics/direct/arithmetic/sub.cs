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
    
    using static zcore;
    using static mfunc;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<byte> sub(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> sub(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> sub(in Vec128<short> lhs, in Vec128<short> rhs)
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> sub(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> sub(in Vec128<int> lhs, in Vec128<int> rhs)
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> sub(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> sub(in Vec128<long> lhs, in Vec128<long> rhs)
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> sub(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> sub(in Vec128<float> lhs, in Vec128<float> rhs)
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> sub(in Vec128<double> lhs, in Vec128<double> rhs)
            => Avx2.Subtract(lhs,rhs);
 
        [MethodImpl(Inline)]
        public static Vec256<byte> sub(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Avx2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> sub(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Avx2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> sub(in Vec256<short> lhs, in Vec256<short> rhs)
            => Avx2.Subtract(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec256<ushort> sub(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Avx2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> sub(in Vec256<int> lhs, in Vec256<int> rhs)
            => Avx2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> sub(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Avx2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> sub(in Vec256<long> lhs, in Vec256<long> rhs)
            => Avx2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> sub(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Avx2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> sub(in Vec256<float> lhs, in Vec256<float> rhs)
            => Avx2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> sub(in Vec256<double> lhs, in Vec256<double> rhs)
            => Avx2.Subtract(lhs, rhs);


         //! add: ptr[T] -> ptr[T] -> ptr[T]
        //! --------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static unsafe void sub(sbyte* lhs, sbyte* rhs, sbyte* dst)  
            => Avx2.Store(dst, Avx2.Subtract(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void sub(byte* lhs, byte* rhs, byte* dst)  
            => Avx2.Store(dst, Avx2.Subtract(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void sub(short* lhs, short* rhs, short* dst)  
            => Avx2.Store(dst, Avx2.Subtract(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void sub(ushort* lhs, ushort* rhs, ushort* dst)  
            => Avx2.Store(dst, Avx2.Subtract(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void sub(int* lhs, int* rhs, int* dst)  
            => Avx2.Store(dst, Avx2.Subtract(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void sub(uint* lhs, uint* rhs, uint* dst)  
            => Avx2.Store(dst, Avx2.Subtract(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void sub(long* lhs, long* rhs, long* dst)  
            => Avx2.Store(dst, Avx2.Subtract(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void sub(ulong* lhs, ulong* rhs, ulong* dst)  
            => Avx2.Store(dst, Avx2.Subtract(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void sub(float* lhs, float* rhs, float* dst)  
            => Avx2.Store(dst, Avx2.Subtract(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void sub(double* lhs, double* rhs, double* dst)  
            => Avx2.Store(dst, Avx2.Subtract(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        //! sub: vec -> vec -> dst*
        //! -------------------------------------------------------------------


        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, void* dst)
            => Avx2.Store((sbyte*)dst, Avx2.Subtract(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<byte> lhs, in Vec128<byte> rhs, void* dst)
            => Avx2.Store((byte*)dst, Avx2.Subtract(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<short> lhs, in Vec128<short> rhs, void* dst)
            => Avx2.Store((short*)dst, Avx2.Subtract(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<ushort> lhs, in Vec128<ushort> rhs, void* dst)
            => Avx2.Store((ushort*)dst, Avx2.Subtract(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<int> lhs, in Vec128<int> rhs, void* dst)
            => Avx2.Store((int*)dst, Avx2.Subtract(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<uint> lhs, in Vec128<uint> rhs, void* dst)
            => Avx2.Store((uint*)dst, Avx2.Subtract(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<long> lhs, in Vec128<long> rhs, void* dst)
            => Avx2.Store((long*)dst, Avx2.Subtract(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<ulong> lhs, in Vec128<ulong> rhs, void* dst)
            => Avx2.Store((ulong*)dst, Avx2.Subtract(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<float> lhs, in Vec128<float> rhs, void* dst)
            => Avx2.Store((float*)dst, Avx2.Subtract(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<double> lhs, in Vec128<double> rhs, void* dst)
            => Avx2.Store((double*)dst, Avx2.Subtract(lhs, rhs));



         //! and: [] -> [] -> ref [] -> return []
        //! --------------------------------------------------------------------


        public static unsafe ref sbyte[] sub(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, ref sbyte[] dst)
        {
            var vLen = Vector128<sbyte>.Count;            
            fixed(sbyte* pLhs = &(lhs[0]))
            fixed(sbyte* pRhs = &(rhs[0]))
            fixed(sbyte* pDst = &dst[0])
            {
                sbyte* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i < dst.Length; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    sub(pLeft, pRight, pTarget);
            }
            
            return ref dst;
        }

        public static unsafe Span<sbyte> sub(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var dst = span<sbyte>(length(lhs,rhs));
            var vLen = Vector128<sbyte>.Count;            
            fixed(sbyte* pLhs = &(lhs[0]))
            fixed(sbyte* pRhs = &(rhs[0]))
            fixed(sbyte* pDst = &dst[0])
            {
                sbyte* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i < dst.Length; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    sub(pLeft, pRight, pTarget);
            }
            
            return dst;            
        }

        public static unsafe ref byte[] sub(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, ref byte[] dst)
        {
            var vLen = Vector128<byte>.Count;
            fixed(byte* pLhs = &(lhs[0]))
            fixed(byte* pRhs = &(rhs[0]))
            fixed(byte* pDst = &dst[0])
            {
                byte* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i < dst.Length; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    sub(pLeft, pRight, pTarget);

            }
            return ref dst;
        }

        public static unsafe ref short[] sub(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, ref short[] dst)
        {
            var vLen = Vector128<short>.Count;
            fixed(short* pLhs = &(lhs[0]))
            fixed(short* pRhs = &(rhs[0]))
            fixed(short* pDst = &dst[0])
            {
                short* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i < dst.Length; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    sub(pLeft, pRight, pTarget);
            }

            return ref dst;
        }

        public static unsafe ref ushort[] sub(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, ref ushort[] dst)
        {
            var vLen = Vector128<ushort>.Count;
            fixed(ushort* pLhs = &(lhs[0]))
            fixed(ushort* pRhs = &(rhs[0]))
            fixed(ushort* pDst = &dst[0])
            {
                ushort* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i < dst.Length; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    sub(pLeft, pRight, pTarget);
            }

            return ref dst;
        }

        public static unsafe ref int[] sub(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, ref int[] dst)
        {
            var vLen = Vector128<int>.Count;
            fixed(int* pLhs = &(lhs[0]))
            fixed(int* pRhs = &(rhs[0]))
            fixed(int* pDst = &dst[0])
            {
                int* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i < dst.Length; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    sub(pLeft, pRight, pTarget);
            }

            return ref dst;
        }


        public static unsafe ref uint[] sub(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, ref uint[] dst)
        {
            var vLen = Vector128<uint>.Count;
            var dLen = length(lhs,rhs);

            fixed(uint* pLhs = &(lhs[0]))
            fixed(uint* pRhs = &(rhs[0]))
            fixed(uint* pDst = &dst[0])
            {
                uint* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i < dLen; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    sub(pLeft, pRight, pTarget);
            }

            return ref dst;
        }

        public static unsafe ref long[] sub(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, ref long[] dst)
        {
            var vLen = Vector128<long>.Count;
            var dLen = length(lhs,rhs);

            fixed(long* pLhs = &(lhs[0]))
            fixed(long* pRhs = &(rhs[0]))
            fixed(long* pDst = &dst[0])
            {
                long* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i < dLen; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    sub(pLeft, pRight, pTarget);
            }
            
            return ref dst;
        }

        public static unsafe ref ulong[] sub(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, ref ulong[] dst)
        {
            var vLen = Vector128<ulong>.Count;
            var dLen = length(lhs,rhs);

            fixed(ulong* pLhs = &(lhs[0]))
            fixed(ulong* pRhs = &(rhs[0]))
            fixed(ulong* pDst = &dst[0])
            {
                ulong* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i < dLen; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    sub(pLeft, pRight, pTarget);
            }
            
            return ref dst;
        }

        public static unsafe ref float[] sub(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, ref float[] dst)
        {
            var vLen = Vector128<float>.Count;
            var dLen = length(lhs,rhs);

            fixed(float* pLhs = &(lhs[0]))
            fixed(float* pRhs = &(rhs[0]))
            fixed(float* pDst = &dst[0])
            {
                float* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i < dLen; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    sub(pLeft, pRight, pTarget);
            }

            return ref dst;
        }

        public static unsafe Span<float> sub(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
        {
            var dst = span<float>(length(lhs,rhs));
            var vLen = Vector128<float>.Count;            
            fixed(float* pLhs = &(lhs[0]))
            fixed(float* pRhs = &(rhs[0]))
            fixed(float* pDst = &dst[0])
            {
                float* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i < dst.Length; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    sub(pLeft, pRight, pTarget);
            }
            
            return dst;        
        }    

        public static unsafe ref double[] sub(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, ref double[] dst)
        {
            var vLen = Vector128<double>.Count;
            var dLen = length(lhs,rhs);

            fixed(double* pLhs = &(lhs[0]))
            fixed(double* pRhs = &(rhs[0]))
            fixed(double* pDst = &dst[0])
            {
                double* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i < dLen; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    sub(pLeft, pRight, pTarget);
            }

            return ref dst;
        } 
    }
}