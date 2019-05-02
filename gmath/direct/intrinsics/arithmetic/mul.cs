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
    using static inxfunc;


    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Num128<float> mul(in Num128<float> lhs, in Num128<float> rhs)
            => Avx2.MultiplyScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> mul(in Num128<double> lhs, in Num128<double> rhs)
            => Avx2.MultiplyScalar(lhs, rhs);

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


        //! add: ptr[T] -> ptr[T] -> ptr[T]
        //! --------------------------------------------------------------------


        [MethodImpl(Inline)]
        public static unsafe void mul(int* lhs, int* rhs, long* dst)  
            => Avx2.Store(dst,Avx2.Multiply(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void mul(uint* lhs, uint* rhs, ulong* dst)  
            => Avx2.Store(dst,Avx2.Multiply(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void mul(float* lhs, float* rhs, float* dst)  
            => Avx2.Store(dst,Avx2.Multiply(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void mul(double* lhs, double* rhs, double* dst)  
            => Avx2.Store(dst,Avx2.Multiply(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));


        public static unsafe ref long[] mul(in int[] lhs, in int[] rhs, ref long[] dst)
        {
            var vLen = Vector128<int>.Count;
            var dLen = length(lhs,rhs);

            fixed(int* pLhs = &lhs[0])
            fixed(int* pRhs = &rhs[0])
            fixed(long* pDst = &dst[0])
            {
                int* pLeft = pLhs, pRight = pRhs;
                long* pTarget = pDst;                
                
                for(var i = 0; i < dLen; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    mul(pLeft, pRight, pTarget);
            }

            return ref dst;
        }

        public static unsafe ref ulong[] mul(in uint[] lhs, in uint[] rhs, ref ulong[] dst)
        {
            var vLen = Vector128<uint>.Count;
            var dLen = length(lhs,rhs);

            fixed(uint* pLhs = &lhs[0])
            fixed(uint* pRhs = &rhs[0])
            fixed(ulong* pDst = &dst[0])
            {
                uint* pLeft = pLhs, pRight = pRhs;
                ulong* pTarget = pDst;                
                
                for(var i = 0; i < dLen; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    mul(pLeft, pRight, pTarget);
            }

            return ref dst;
        }


        public static unsafe ref float[] mul(in float[] lhs, in float[] rhs, ref float[] dst)
        {
            var vLen = Vector128<float>.Count;
            var dLen = length(lhs,rhs);

            fixed(float* pLhs = &lhs[0])
            fixed(float* pRhs = &rhs[0])
            fixed(float* pDst = &dst[0])
            {
                float* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i < dLen; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    mul(pLeft, pRight, pTarget);
            }

            return ref dst;
        }

        public static unsafe ref double[] mul(in double[] lhs, in double[] rhs, ref double[] dst)
        {
            var vLen = Vector128<double>.Count;
            var dLen = length(lhs,rhs);

            fixed(double* pLhs = &lhs[0])
            fixed(double* pRhs = &rhs[0])
            fixed(double* pDst = &dst[0])
            {
                double* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i < dLen; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    mul(pLeft, pRight, pTarget);
            }

            return ref dst;
        }


        [MethodImpl(Inline)]
        public static unsafe long[] mul(int[] lhs, int[] rhs)
        {
            var dst  = new long[length(lhs,rhs)];
            return mul(lhs, rhs, ref dst);
        }

        [MethodImpl(Inline)]
        public static unsafe ulong[] mul(uint[] lhs, uint[] rhs)
        {
            var dst  = new ulong[length(lhs,rhs)];
            return mul(lhs, rhs, ref dst);
        }

        [MethodImpl(Inline)]
        public static unsafe float[] mul(float[] lhs, float[] rhs)
        {
            var dst  = new float[length(lhs,rhs)];
            return mul(lhs, rhs, ref dst);
        }

        [MethodImpl(Inline)]
        public static unsafe double[] mul(double[] lhs, double[] rhs)
        {
            var dst  = new double[length(lhs,rhs)];
            return mul(lhs, rhs, ref dst);
        }

    }
}