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

        //! scalar addition
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static Num128<float> add(in Num128<float> lhs, in Num128<float> rhs)
            => Avx2.AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> add(in Num128<double> lhs, in Num128<double> rhs)
            => Avx2.AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static void add(in Num128<float> lhs, in Num128<float> rhs, out Num128<float> dst)
            => dst = Avx2.AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static void add(in Num128<double> lhs, in Num128<double> rhs, out Num128<double> dst)
            => dst = Avx2.AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static unsafe void add(in Num128<float> lhs, in Num128<float> rhs, void* dst)
            => Avx2.StoreScalar((float*)dst,Avx2.AddScalar(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(in Num128<double> lhs, in Num128<double> rhs, void* dst)
            => Avx2.StoreScalar((double*)dst,Avx2.AddScalar(lhs, rhs));

        //! add: vec -> vec -> vec
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static Vec128<byte> add(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> add(in Vec128<short> lhs, in Vec128<short> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> add(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> add(in Vec128<int> lhs, in Vec128<int> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> add(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> add(in Vec128<long> lhs, in Vec128<long> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> add(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> add(in Vec128<double> lhs, in Vec128<double> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> add(in Vec128<float> lhs, in Vec128<float> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> add(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> add(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> add(in Vec256<short> lhs, in Vec256<short> rhs)
            => Avx2.Add(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec256<ushort> add(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> add(in Vec256<int> lhs, in Vec256<int> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> add(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> add(in Vec256<long> lhs, in Vec256<long> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> add(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> add(in Vec256<float> lhs, in Vec256<float> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> add(in Vec256<double> lhs, in Vec256<double> rhs)
            => Avx2.Add(lhs, rhs);


        //! add: vec -> vec -> dst*
        //! -------------------------------------------------------------------


        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, void* dst)
            => Avx2.Store((sbyte*)dst, Avx2.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<byte> lhs, in Vec128<byte> rhs, void* dst)
            => Avx2.Store((byte*)dst, Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<short> lhs, in Vec128<short> rhs, void* dst)
            => Avx2.Store((short*)dst, Avx2.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<ushort> lhs, in Vec128<ushort> rhs, void* dst)
            => Avx2.Store((ushort*)dst, Avx2.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<int> lhs, in Vec128<int> rhs, void* dst)
            => Avx2.Store((int*)dst, Avx2.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<uint> lhs, in Vec128<uint> rhs, void* dst)
            => Avx2.Store((uint*)dst, Avx2.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<long> lhs, in Vec128<long> rhs, void* dst)
            => Avx2.Store((long*)dst, Avx2.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<ulong> lhs, in Vec128<ulong> rhs, void* dst)
            => Avx2.Store((ulong*)dst, Avx2.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<float> lhs, in Vec128<float> rhs, void* dst)
            => Avx2.Store((float*)dst, Avx2.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<double> lhs, in Vec128<double> rhs, void* dst)
            => Avx2.Store((double*)dst, Avx2.Add(lhs, rhs));


        //! add: ptr[T] -> ptr[T] -> ptr[T]
        //! --------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static unsafe void add(sbyte* lhs, sbyte* rhs, sbyte* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(byte* lhs, byte* rhs, byte* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(short* lhs, short* rhs, short* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(ushort* lhs, ushort* rhs, ushort* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(int* lhs, int* rhs, int* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(uint* lhs, uint* rhs, uint* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(long* lhs, long* rhs, long* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(ulong* lhs, ulong* rhs, ulong* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(float* lhs, float* rhs, float* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void add(double* lhs, double* rhs, double* dst)  
            => Avx2.Store(dst,Avx2.Add(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

 
         //! add: index -> index -> index
        //! --------------------------------------------------------------------

        public static unsafe Index<sbyte> add(Index<sbyte> lhs, Index<sbyte> rhs)
        {
            var vLen = Vector128<sbyte>.Count;
            var dst = new sbyte[matchedCount(lhs,rhs)];

            fixed(sbyte* pLhs = &(lhs.ToArray()[0]))
            fixed(sbyte* pRhs = &(rhs.ToArray()[0]))
            fixed(sbyte* pDst = &dst[0])
            {
                sbyte* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += vLen, pLeft += vLen, pRight += vLen, pTarget += vLen)
                    add(pLeft, pRight, pTarget);

            }
            return dst;
        }

        public static unsafe Index<byte> add(Index<byte> lhs, Index<byte> rhs)
        {
            var len = Vector128<byte>.Count;
            var dst = new byte[matchedCount(lhs,rhs)];

            fixed(byte* pLhs = &(lhs.ToArray()[0]))
            fixed(byte* pRhs = &(rhs.ToArray()[0]))
            fixed(byte* pDst = &dst[0])
            {
                byte* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<short> add(Index<short> lhs, Index<short> rhs)
        {
            var len = Vector128<short>.Count;
            var dst = new short[matchedCount(lhs,rhs)];

            fixed(short* pLhs = &(lhs.ToArray()[0]))
            fixed(short* pRhs = &(rhs.ToArray()[0]))
            fixed(short* pDst = &dst[0])
            {
                short* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<ushort> add(Index<ushort> lhs, Index<ushort> rhs)
        {
            var len = Vector128<ushort>.Count;
            var dst = new ushort[matchedCount(lhs,rhs)];

            fixed(ushort* pLhs = &(lhs.ToArray()[0]))
            fixed(ushort* pRhs = &(rhs.ToArray()[0]))
            fixed(ushort* pDst = &dst[0])
            {
                ushort* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<int> add(Index<int> lhs, Index<int> rhs)
        {
            var len = Vector128<int>.Count;
            var dst = new int[matchedCount(lhs,rhs)];

            fixed(int* pLhs = &(lhs.ToArray()[0]))
            fixed(int* pRhs = &(rhs.ToArray()[0]))
            fixed(int* pDst = &dst[0])
            {
                int* pLeft = pLhs, pRight = pRhs, pTarget = pDst;                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<uint> add(Index<uint> lhs, Index<uint> rhs)
        {
            var len = Vector128<uint>.Count;
            var dst = new uint[matchedCount(lhs,rhs)];

            fixed(uint* pLhs = &(lhs.ToArray()[0]))
            fixed(uint* pRhs = &(rhs.ToArray()[0]))
            fixed(uint* pDst = &dst[0])
            {
                uint* pLeft = pLhs, pRight = pRhs, pTarget = pDst;                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<long> add(Index<long> lhs, Index<long> rhs)
        {
            var len = Vector128<long>.Count;
            var dst = new long[matchedCount(lhs,rhs)];

            fixed(long* pLhs = &(lhs.ToArray()[0]))
            fixed(long* pRhs = &(rhs.ToArray()[0]))
            fixed(long* pDst = &dst[0])
            {
                long* pLeft = pLhs, pRight = pRhs, pTarget = pDst;                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<ulong> add(Index<ulong> lhs, Index<ulong> rhs)
        {
            var len = Vector128<ulong>.Count;
            var dst = new ulong[matchedCount(lhs,rhs)];

            fixed(ulong* pLhs = &(lhs.ToArray()[0]))
            fixed(ulong* pRhs = &(rhs.ToArray()[0]))
            fixed(ulong* pDst = &dst[0])
            {
                ulong* pLeft = pLhs, pRight = pRhs, pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<float> add(Index<float> lhs, Index<float> rhs)
        {
            var len = Vector128<float>.Count;
            var dst = new float[matchedCount(lhs,rhs)];

            fixed(float* pLhs = &(lhs.ToArray()[0]))
            fixed(float* pRhs = &(rhs.ToArray()[0]))
            fixed(float* pDst = &dst[0])
            {
                float* pLeft = pLhs, pRight = pRhs, pTarget = pDst;                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }

        public static unsafe Index<double> add(Index<double> lhs, Index<double> rhs)
        {
            var len = Vector128<double>.Count;
            var dst = new double[matchedCount(lhs,rhs)];

            fixed(double* pLhs = &(lhs.ToArray()[0]))
            fixed(double* pRhs = &(rhs.ToArray()[0]))
            fixed(double* pDst = &dst[0])
            {
                double* pLeft = pLhs, pRight = pRhs, pTarget = pDst;                
                for(var i = 0; i< lhs.Count; i += len, pLeft += len, pRight += len, pTarget += len)
                    add(pLeft, pRight, pTarget);
            }
            return dst;
        }
    }
}