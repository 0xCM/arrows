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
        public static Num128<float> sub(in Num128<float> lhs, in Num128<float> rhs)
            => Avx2.SubtractScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> sub(in Num128<double> lhs, in Num128<double> rhs)
            => Avx2.SubtractScalar(lhs, rhs);

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

         //! add: index -> index -> index
        //! --------------------------------------------------------------------

        public static unsafe Index<sbyte> sub(Index<sbyte> lhs, Index<sbyte> rhs)
        {
            var vLen = Vector128<sbyte>.Count;
            var dst = new sbyte[matchedCount(lhs,rhs)];

            fixed(sbyte* pLhs = &(lhs.ToArray()[0]))
            fixed(sbyte* pRhs = &(rhs.ToArray()[0]))
            fixed(sbyte* pDst = &dst[0])
            {
                sbyte* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    sub(pLeft, pRight, pTarget);

            }
            return dst;
        }

        public static unsafe Index<byte> sub(Index<byte> lhs, Index<byte> rhs)
        {
            var len = Vector128<byte>.Count;
            var dst = new byte[matchedCount(lhs,rhs)];

            fixed(byte* pLhs = &(lhs.ToArray()[0]))
            fixed(byte* pRhs = &(rhs.ToArray()[0]))
            fixed(byte* pDst = &dst[0])
            {
                byte* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    sub(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<short> sub(Index<short> lhs, Index<short> rhs)
        {
            var len = Vector128<short>.Count;
            var dst = new short[matchedCount(lhs,rhs)];

            fixed(short* pLhs = &(lhs.ToArray()[0]))
            fixed(short* pRhs = &(rhs.ToArray()[0]))
            fixed(short* pDst = &dst[0])
            {
                short* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    sub(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<ushort> sub(Index<ushort> lhs, Index<ushort> rhs)
        {
            var len = Vector128<ushort>.Count;
            var dst = new ushort[matchedCount(lhs,rhs)];

            fixed(ushort* pLhs = &(lhs.ToArray()[0]))
            fixed(ushort* pRhs = &(rhs.ToArray()[0]))
            fixed(ushort* pDst = &dst[0])
            {
                ushort* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    sub(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<int> sub(Index<int> lhs, Index<int> rhs)
        {
            var len = Vector128<int>.Count;
            var dst = new int[matchedCount(lhs,rhs)];

            fixed(int* pLhs = &(lhs.ToArray()[0]))
            fixed(int* pRhs = &(rhs.ToArray()[0]))
            fixed(int* pDst = &dst[0])
            {
                int* pLeft = pLhs, pRight = pRhs, pTarget = pDst;                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    sub(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<uint> sub(Index<uint> lhs, Index<uint> rhs)
        {
            var len = Vector128<uint>.Count;
            var dst = new uint[matchedCount(lhs,rhs)];

            fixed(uint* pLhs = &(lhs.ToArray()[0]))
            fixed(uint* pRhs = &(rhs.ToArray()[0]))
            fixed(uint* pDst = &dst[0])
            {
                uint* pLeft = pLhs, pRight = pRhs, pTarget = pDst;                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    sub(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<long> sub(Index<long> lhs, Index<long> rhs)
        {
            var len = Vector128<long>.Count;
            var dst = new long[matchedCount(lhs,rhs)];

            fixed(long* pLhs = &(lhs.ToArray()[0]))
            fixed(long* pRhs = &(rhs.ToArray()[0]))
            fixed(long* pDst = &dst[0])
            {
                long* pLeft = pLhs, pRight = pRhs, pTarget = pDst;                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    sub(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<ulong> sub(Index<ulong> lhs, Index<ulong> rhs)
        {
            var len = Vector128<ulong>.Count;
            var dst = new ulong[matchedCount(lhs,rhs)];

            fixed(ulong* pLhs = &(lhs.ToArray()[0]))
            fixed(ulong* pRhs = &(rhs.ToArray()[0]))
            fixed(ulong* pDst = &dst[0])
            {
                ulong* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    sub(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<float> sub(Index<float> lhs, Index<float> rhs)
        {
            var len = Vector128<float>.Count;
            var dst = new float[matchedCount(lhs,rhs)];

            fixed(float* pLhs = &(lhs.ToArray()[0]))
            fixed(float* pRhs = &(rhs.ToArray()[0]))
            fixed(float* pDst = &dst[0])
            {
                float* pLeft = pLhs, pRight = pRhs, pTarget = pDst;                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    sub(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<double> sub(Index<double> lhs, Index<double> rhs)
        {
            var len = Vector128<double>.Count;
            var dst = new double[matchedCount(lhs,rhs)];

            fixed(double* pLhs = &(lhs.ToArray()[0]))
            fixed(double* pRhs = &(rhs.ToArray()[0]))
            fixed(double* pDst = &dst[0])
            {
                double* pLeft = pLhs, pRight = pRhs, pTarget = pDst;                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    sub(pLeft, pRight, pTarget);
            }
            return dst;
        }

        static readonly PrimalIndex SubLU
            = PrimKinds.index
                (@sbyte: new PrimalFusedBinOp<sbyte>(InX.sub),
                @byte: new PrimalFusedBinOp<byte>(InX.sub),
                @short: new PrimalFusedBinOp<short>(InX.sub),
                @ushort: new PrimalFusedBinOp<ushort>(InX.sub),
                @int: new PrimalFusedBinOp<int>(InX.sub),
                @uint: new PrimalFusedBinOp<uint>(InX.sub),
                @long: new PrimalFusedBinOp<long>(InX.sub),
                @ulong: new PrimalFusedBinOp<ulong>(InX.sub),
                @float: new PrimalFusedBinOp<float>(InX.sub),
                @double:new PrimalFusedBinOp<double>(InX.sub)
                );

        internal readonly struct Sub<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedBinOp<T> Op = SubLU.lookup<T,PrimalFusedBinOp<T>>();
        }

 
    }

}