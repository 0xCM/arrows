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
    
    
    using static mfunc;


    partial class dinx
    {


        [MethodImpl(Inline)]
        public static Vec128<float> div(in Vec128<float> lhs, in Vec128<float> rhs)
            => Avx2.Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> div(in Vec128<double> lhs, in Vec128<double> rhs)
            => Avx2.Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> div(in Vec256<float> lhs, in Vec256<float> rhs)
            => Avx2.Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> div(in Vec256<double> lhs, in Vec256<double> rhs)
            => Avx2.Divide(lhs, rhs);

        public static unsafe ref Span128<float> div(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, ref Span128<float> dst)
        {
            var len = length(lhs,rhs);
            var vLen = Span128<float>.BlockLength;

            fixed(float* pLhs0 = &first(lhs))
            fixed(float* pRhs0 = &first(rhs))
            fixed(float* pDst0 =  &first(dst))
            {
                float* pDst = pDst0, pLhs = pLhs0, pRhs = pRhs0;
                for(var i =0; i < len; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    store(div(vLhs,vRhs), pDst);
                }
            }

            return ref dst;
        }

        public static unsafe ref Span128<double> div(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, ref Span128<double> dst)
        {
            var len = length(lhs,rhs);
            var vLen = Span128<double>.BlockLength;

            fixed(double* pLhs0 = &first(lhs))
            fixed(double* pRhs0 = &first(rhs))
            fixed(double* pDst0 =  &first(dst))
            {
                double* pDst = pDst0, pLhs = pLhs0, pRhs = pRhs0;
                for(var i =0; i < len; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    store(div(vLhs,vRhs), pDst);
                }
            }

            return ref dst;
        }

        public static unsafe ref Span256<float> div(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, ref Span256<float> dst)
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
                    store(div(vLhs,vRhs), pDst);
                }
            }

            return ref dst;
        }

        public static unsafe ref Span256<double> div(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, ref Span256<double> dst)
        {
            var len = length(lhs,rhs);
            var vLen = Span256<double>.BlockLength;

            fixed(double* pLhs0 = &first(lhs))
            fixed(double* pRhs0 = &first(rhs))
            fixed(double* pDst0 =  &first(dst))
            {
                double* pDst = pDst0, pLhs = pLhs0, pRhs = pRhs0;
                for(var i =0; i < len; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    store(div(vLhs,vRhs), pDst);
                }
            }

            return ref dst;
        }    
    }
}