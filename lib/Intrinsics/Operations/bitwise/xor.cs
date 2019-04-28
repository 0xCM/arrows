//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
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

    partial class InX
    {

        [MethodImpl(Inline)]
        public static Vec128<sbyte> xor(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> xor(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> xor(in Vec128<short> lhs, in Vec128<short> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> xor(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> xor(in Vec128<int> lhs, in Vec128<int> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> xor(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> xor(in Vec128<long> lhs, in Vec128<long> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> xor(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> xor(in Vec128<float> lhs, in Vec128<float> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> xor(in Vec128<double> lhs, in Vec128<double> rhs)
            => Sse2.Xor(lhs, rhs); 
 
       [MethodImpl(Inline)]
        public static Vec256<sbyte> xor(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Avx2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> xor(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Avx2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> xor(in Vec256<short> lhs, in Vec256<short> rhs)
            => Avx2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> xor(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Avx2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> xor(in Vec256<int> lhs, in Vec256<int> rhs)
            => Avx2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> xor(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Avx2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> xor(in Vec256<long> lhs, in Vec256<long> rhs)
            => Avx2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> xor(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Avx2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> xor(in Vec256<float> lhs, in Vec256<float> rhs)
            => Avx2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> xor(in Vec256<double> lhs, in Vec256<double> rhs)
            => Avx2.Xor(lhs, rhs);
 
 
         //! and: ptr -> ptr -> ptr
        //! --------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static unsafe void xor(sbyte* lhs, sbyte* rhs, sbyte* dst)  
            => Avx2.Store(dst,Avx2.Xor(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void xor(byte* lhs, byte* rhs, byte* dst)  
            => Avx2.Store(dst,Avx2.Xor(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void xor(short* lhs, short* rhs, short* dst)  
            => Avx2.Store(dst,Avx2.Xor(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void xor(ushort* lhs, ushort* rhs, ushort* dst)  
            => Avx2.Store(dst,Avx2.Xor(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void xor(int* lhs, int* rhs, int* dst)  
            => Avx2.Store(dst,Avx2.Xor(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void xor(uint* lhs, uint* rhs, uint* dst)  
            => Avx2.Store(dst,Avx2.Xor(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void xor(long* lhs, long* rhs, long* dst)  
            => Avx2.Store(dst,Avx2.Xor(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void xor(ulong* lhs, ulong* rhs, ulong* dst)  
            => Avx2.Store(dst,Avx2.Xor(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void xor(float* lhs, float* rhs, float* dst)  
            => Avx2.Store(dst,Avx2.Xor(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void xor(double* lhs, double* rhs, double* dst)  
            => Avx2.Store(dst,Avx2.Xor(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

 

        //! add: index -> index -> index   
        //! --------------------------------------------------------------------
        public static unsafe Index<sbyte> xor(Index<sbyte> lhs, Index<sbyte> rhs)
        {
            var vLen = Vector128<sbyte>.Count;
            var dst = new sbyte[matchedCount(lhs,rhs)];

            fixed(sbyte* pLhs = &(lhs.ToArray()[0]))
            fixed(sbyte* pRhs = &(rhs.ToArray()[0]))
            fixed(sbyte* pDst = &dst[0])
            {
                sbyte* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    xor(pLeft, pRight, pTarget);

            }
            return dst;
        }

        public static unsafe Index<byte> xor(Index<byte> lhs, Index<byte> rhs)
        {
            var len = Vector128<byte>.Count;
            var dst = new byte[matchedCount(lhs,rhs)];

            fixed(byte* pLhs = &(lhs.ToArray()[0]))
            fixed(byte* pRhs = &(rhs.ToArray()[0]))
            fixed(byte* pDst = &dst[0])
            {
                byte* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    xor(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<short> xor(Index<short> lhs, Index<short> rhs)
        {
            var len = Vector128<short>.Count;
            var dst = new short[matchedCount(lhs,rhs)];

            fixed(short* pLhs = &(lhs.ToArray()[0]))
            fixed(short* pRhs = &(rhs.ToArray()[0]))
            fixed(short* pDst = &dst[0])
            {
                short* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    xor(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<ushort> xor(Index<ushort> lhs, Index<ushort> rhs)
        {
            var len = Vector128<ushort>.Count;
            var dst = new ushort[matchedCount(lhs,rhs)];

            fixed(ushort* pLhs = &(lhs.ToArray()[0]))
            fixed(ushort* pRhs = &(rhs.ToArray()[0]))
            fixed(ushort* pDst = &dst[0])
            {
                ushort* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    xor(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<int> xor(Index<int> lhs, Index<int> rhs)
        {
            var len = Vector128<int>.Count;
            var dst = new int[matchedCount(lhs,rhs)];

            fixed(int* pLhs = &(lhs.ToArray()[0]))
            fixed(int* pRhs = &(rhs.ToArray()[0]))
            fixed(int* pDst = &dst[0])
            {
                int* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    xor(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<uint> xor(Index<uint> lhs, Index<uint> rhs)
        {
            var len = Vector128<uint>.Count;
            var dst = new uint[matchedCount(lhs,rhs)];

            fixed(uint* pLhs = &(lhs.ToArray()[0]))
            fixed(uint* pRhs = &(rhs.ToArray()[0]))
            fixed(uint* pDst = &dst[0])
            {
                uint* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    xor(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<long> xor(Index<long> lhs, Index<long> rhs)
        {
            var len = Vector128<long>.Count;
            var dst = new long[matchedCount(lhs,rhs)];

            fixed(long* pLhs = &(lhs.ToArray()[0]))
            fixed(long* pRhs = &(rhs.ToArray()[0]))
            fixed(long* pDst = &dst[0])
            {
                long* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    xor(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<ulong> xor(Index<ulong> lhs, Index<ulong> rhs)
        {
            var len = Vector128<ulong>.Count;
            var dst = new ulong[matchedCount(lhs,rhs)];

            fixed(ulong* pLhs = &(lhs.ToArray()[0]))
            fixed(ulong* pRhs = &(rhs.ToArray()[0]))
            fixed(ulong* pDst = &dst[0])
            {
                ulong* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    xor(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<float> xor(Index<float> lhs, Index<float> rhs)
        {
            var len = Vector128<float>.Count;
            var dst = new float[matchedCount(lhs,rhs)];

            fixed(float* pLhs = &(lhs.ToArray()[0]))
            fixed(float* pRhs = &(rhs.ToArray()[0]))
            fixed(float* pDst = &dst[0])
            {
                float* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    xor(pLeft, pRight, pTarget);
            }
            return dst;
        }

 
        public static unsafe Index<double> xor(Index<double> lhs, Index<double> rhs)
        {
            var len = Vector128<double>.Count;
            var dst = new double[matchedCount(lhs,rhs)];

            fixed(double* pLhs = &(lhs.ToArray()[0]))
            fixed(double* pRhs = &(rhs.ToArray()[0]))
            fixed(double* pDst = &dst[0])
            {
                double* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    xor(pLeft, pRight, pTarget);
            }
            return dst;
        }

        static readonly PrimalIndex XOrLU
            = PrimKinds.index
                (@sbyte: new PrimalFusedBinOp<sbyte>(InX.xor),
                @byte: new PrimalFusedBinOp<byte>(InX.xor),
                @short: new PrimalFusedBinOp<short>(InX.xor),
                @ushort: new PrimalFusedBinOp<ushort>(InX.xor),
                @int: new PrimalFusedBinOp<int>(InX.xor),
                @uint: new PrimalFusedBinOp<uint>(InX.xor),
                @long: new PrimalFusedBinOp<long>(InX.xor),
                @ulong: new PrimalFusedBinOp<ulong>(InX.xor),
                @float: new PrimalFusedBinOp<float>(InX.xor),
                @double:new PrimalFusedBinOp<double>(InX.xor)
                );

        internal readonly struct XOr<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedBinOp<T> Op = XOrLU.lookup<T,PrimalFusedBinOp<T>>();
        }



    }    
}