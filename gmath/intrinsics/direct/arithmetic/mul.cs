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
    using static global::mfunc;


    partial class dinx
    {

        #region mul:vec -> vec -> vec

        [MethodImpl(Inline)]
        public static Vec128<long> mul(in Vec128<int> lhs, in Vec128<int> rhs)
            => Avx2.Multiply(lhs, rhs);

            
        [MethodImpl(Inline)]
        public static Vec128<ulong> mul(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Avx2.Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> mul(in Vec128<float> lhs,in Vec128<float> rhs)
            => Avx2.Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> mul(in Vec128<double> lhs,in Vec128<double> rhs)
            => Avx2.Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> mul(in Vec256<int> lhs,in Vec256<int> rhs)
            => Avx2.Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> mul(in Vec256<uint> lhs,in Vec256<uint> rhs)
            => Avx2.Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> mul(in Vec256<float> lhs,in Vec256<float> rhs)
            => Avx2.Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> mul(in Vec256<double> lhs, in Vec256<double> rhs)
            => Avx2.Multiply(lhs, rhs);
        
        #endregion
        
        #region  mul:vec->vec->*

        [MethodImpl(Inline)]
        public static unsafe void mul(in Vec128<int> lhs, in Vec128<int> rhs, long* dst)
            => Avx2.Store(dst, Avx2.Multiply(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void mul(in Vec128<uint> lhs, in Vec128<uint> rhs, ulong* dst)
            => Avx2.Store(dst, Avx2.Multiply(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void mul(in Vec128<float> lhs, in Vec128<float> rhs, float* dst)
            => Avx2.Store(dst, Avx2.Multiply(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void mul(in Vec128<double> lhs, in Vec128<double> rhs, double* dst)
            => Avx2.Store(dst, Avx2.Multiply(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void mul(in Vec256<int> lhs, in Vec256<int> rhs, long* dst)
            => Avx2.Store(dst, Avx2.Multiply(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void mul(in Vec256<uint> lhs, in Vec256<uint> rhs, ulong* dst)
            => Avx2.Store(dst, Avx2.Multiply(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void mul(in Vec256<float> lhs, in Vec256<float> rhs, float* dst)
            => Avx2.Store(dst, Avx2.Multiply(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void mul(in Vec256<double> lhs, in Vec256<double> rhs, double* dst)
            => Avx2.Store(dst, Avx2.Multiply(lhs, rhs));

        #endregion

        #region mul: span -> span -> ref span -> ref span

        public static unsafe ref Span128<long> mul(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, ref Span128<long> dst)
        {
            var vLen = Span128<int>.BlockLength;
            var dLen = length(lhs,rhs);

            fixed(int* pLhs0 = &first(lhs))
            fixed(int* pRhs0 = &first(rhs))
            fixed(long* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.mul(vLhs,vRhs), pDst);
                }
            }

            return ref dst;
        }

        public static unsafe ref Span128<ulong> mul(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, ref Span128<ulong> dst)
        {
            var vLen = Span128<uint>.BlockLength;
            var dLen = length(lhs,rhs);

            fixed(uint* pLhs0 = &first(lhs))
            fixed(uint* pRhs0 = &first(rhs))
            fixed(ulong* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.mul(vLhs,vRhs), pDst);
                }
            }            

            return ref dst;            
        }

        public static unsafe ref Span128<float> mul(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, ref Span128<float> dst)
        {
            var vLen = Span128<float>.BlockLength;
            var dLen = length(lhs,rhs);

            fixed(float* pLhs0 = &first(lhs))
            fixed(float* pRhs0 = &first(rhs))
            fixed(float* pDst0 = &dst[0])
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.mul(vLhs,vRhs), pDst);
                }
            }

            return ref dst;
        }

        public static unsafe ref Span128<double> mul(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, ref Span128<double> dst)
        {
            var vLen = Span128<double>.BlockLength;
            var dLen = length(lhs,rhs);

            fixed(double* pLhs0 = &first(lhs))
            fixed(double* pRhs0 = &first(rhs))
            fixed(double* pDst0 = &dst[0])
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.mul(vLhs,vRhs), pDst);
                }
            }

            return ref dst;
        }

        public static unsafe ref Span256<long> mul(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, ref Span256<long> dst)
        {
            var vLen = Span256<int>.BlockLength;
            var dLen = Span256<long>.BlockLength;
            var len = length(lhs,rhs);

            fixed(int* pLhs0 = &first(lhs))
            fixed(int* pRhs0 = &first(rhs))
            fixed(long* pDst0 = &first(dst))
            {
                int* pLhs = pLhs0, pRhs = pRhs0;
                long* pDst = pDst0;                
                
                for(var i =0; i < len; i+= vLen, pLhs += vLen, pRhs += vLen, pDst += dLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    store(mul(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<float> mul(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, ref Span256<float> dst)
        {
            var len = length(lhs,rhs);
            var vLen = Span256<float>.BlockLength;

            fixed(float* pLhs0 = &first(lhs))
            fixed(float* pRhs0 = &first(rhs))
            fixed(float* pDst0 =  &first(dst))
            {
                float* pDst = pDst0, pLhs = pLhs0, pRhs = pRhs0;
                for(var i =0; i < len; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    store(mul(vLhs,vRhs), pDst);
                }
            }

            return ref dst;
        }

        public static unsafe ref Span256<ulong> mul(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, ref Span256<ulong> dst)
        {
            var vLen = Span256<uint>.BlockLength;
            var dLen = length(lhs,rhs);

            fixed(uint* pLhs0 = &first(lhs))
            fixed(uint* pRhs0 = &first(rhs))
            fixed(ulong* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    dinx.store(dinx.mul(vLhs,vRhs), pDst);
                }
            }            
            return ref dst;            
        }

        public static unsafe ref Span256<double> mul(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs,ref Span256<double> dst)
        {
            var dLen = length(lhs,rhs);
            var vLen = Span256<double>.BlockLength;
            fixed(double* pLhs0 = &first(lhs))
            fixed(double* pRhs0 = &first(rhs))
            fixed(double* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    dinx.store(dinx.mul(vLhs,vRhs), pDst);
                }
            }
            return ref dst;
        }

        #endregion

    }
}