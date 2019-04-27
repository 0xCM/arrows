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


    public partial class InX
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


        //! add: index -> index -> index
        //! --------------------------------------------------------------------

        public static unsafe Index<long> mul(Index<int> lhs, Index<int> rhs)
        {
            var len = Vector128<int>.Count;
            var dst = new long[matchedCount(lhs,rhs)];

            fixed(int* pLhs = &(lhs.ToArray()[0]))
            fixed(int* pRhs = &(rhs.ToArray()[0]))
            fixed(long* pDst = &dst[0])
            {
                int* pLeft = pLhs, pRight = pRhs;
                long* pTarget = pDst;                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    mul(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<long> mul(Index<long> lhs, Index<long> rhs)
            => mul(lhs.Convert<int>(), rhs.Convert<int>());

        public static unsafe Index<ulong> mul(Index<uint> lhs, Index<uint> rhs)
        {
            var len = Vector128<int>.Count;
            var dst = new ulong[matchedCount(lhs,rhs)];

            fixed(uint* pLhs = &(lhs.ToArray()[0]))
            fixed(uint* pRhs = &(rhs.ToArray()[0]))
            fixed(ulong* pDst = &dst[0])
            {
                uint* pLeft = pLhs, pRight = pRhs;
                ulong* pTarget = pDst;                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    mul(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<ulong> mul(Index<ulong> lhs, Index<ulong> rhs)
            => mul(lhs.Convert<uint>(), rhs.Convert<uint>());

        public static unsafe Index<float> mul(Index<float> lhs, Index<float> rhs)
        {
            var len = Vector128<float>.Count;
            var dst = new float[matchedCount(lhs,rhs)];

            fixed(float* pLhs = &(lhs.ToArray()[0]))
            fixed(float* pRhs = &(rhs.ToArray()[0]))
            fixed(float* pDst = &dst[0])
            {
                float* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    mul(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<double> mul(Index<double> lhs, Index<double> rhs)
        {
            var len = Vector128<double>.Count;
            var dst = new double[matchedCount(lhs,rhs)];

            fixed(double* pLhs = &(lhs.ToArray()[0]))
            fixed(double* pRhs = &(rhs.ToArray()[0]))
            fixed(double* pDst = &dst[0])
            {
                double* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    mul(pLeft, pRight, pTarget);
            }
            return dst;
        }

    }
}