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
    using static Operative;


    partial class InXX
    {
        public static unsafe Index<sbyte> InXAdd(this Index<sbyte> lhs, Index<sbyte> rhs)
        {
            var len = Vector128<sbyte>.Count;
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();
            var vCount = lhs.Length/len;
            var dst = new sbyte[lArray.Length];

            fixed(sbyte* pLhs = &lArray[0])
            fixed(sbyte* pRhs = &rArray[0])
            fixed(sbyte* pDst = &dst[0])
            {
                var pLeft = pLhs;
                var pRight = pRhs;
                var pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len)
                {
                    var vL = Avx.LoadVector128(pLeft);
                    var vR = Avx.LoadVector128(pRight);
                    Avx2.Store(pTarget,Avx2.Add(vL,vR));
                    pLeft += len;
                    pRight += len;
                    pTarget += len;

                }
            }
            return dst;
        }

        public static unsafe Index<byte> InXAdd(this Index<byte> lhs, Index<byte> rhs)
        {
            var len = Vector128<byte>.Count;
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();
            var vCount = lhs.Length/len;
            var dst = new byte[lArray.Length];

            fixed(byte* pLhs = &lArray[0])
            fixed(byte* pRhs = &rArray[0])
            fixed(byte* pDst = &dst[0])
            {
                var pLeft = pLhs;
                var pRight = pRhs;
                var pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len)
                {
                    var vL = Avx.LoadVector128(pLeft);
                    var vR = Avx.LoadVector128(pRight);
                    Avx2.Store(pTarget,Avx2.Add(vL,vR));
                    pLeft += len;
                    pRight += len;
                    pTarget += len;

                }
            }
            return dst;
        }

        public static unsafe Index<short> InXAdd(this Index<short> lhs, Index<short> rhs)
        {
            var len = Vector128<short>.Count;
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();
            var vCount = lhs.Length/len;
            var dst = new short[lArray.Length];

            fixed(short* pLhs = &lArray[0])
            fixed(short* pRhs = &rArray[0])
            fixed(short* pDst = &dst[0])
            {
                var pLeft = pLhs;
                var pRight = pRhs;
                var pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len)
                {
                    var vL = Avx.LoadVector128(pLeft);
                    var vR = Avx.LoadVector128(pRight);
                    Avx2.Store(pTarget,Avx2.Add(vL,vR));
                    pLeft += len;
                    pRight += len;
                    pTarget += len;

                }
            }
            return dst;
        }

        public static unsafe Index<ushort> InXAdd(this Index<ushort> lhs, Index<ushort> rhs)
        {
            var len = Vector128<ushort>.Count;
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();
            var vCount = lhs.Length/len;
            var dst = new ushort[lArray.Length];

            fixed(ushort* pLhs = &lArray[0])
            fixed(ushort* pRhs = &rArray[0])
            fixed(ushort* pDst = &dst[0])
            {
                var pLeft = pLhs;
                var pRight = pRhs;
                var pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len)
                {
                    var vL = Avx.LoadVector128(pLeft);
                    var vR = Avx.LoadVector128(pRight);
                    Avx2.Store(pTarget,Avx2.Add(vL,vR));
                    pLeft += len;
                    pRight += len;
                    pTarget += len;

                }
            }
            return dst;
        }

        public static unsafe Index<int> InXAdd(this Index<int> lhs, Index<int> rhs)
        {
            var len = Vector128<int>.Count;
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();
            var vCount = lhs.Length/len;
            var dst = new int[lArray.Length];

            fixed(int* pLhs = &lArray[0])
            fixed(int* pRhs = &rArray[0])
            fixed(int* pDst = &dst[0])
            {
                var pLeft = pLhs;
                var pRight = pRhs;
                var pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len)
                {
                    var vL = Avx.LoadVector128(pLeft);
                    var vR = Avx.LoadVector128(pRight);
                    Avx2.Store(pTarget,Avx2.Add(vL,vR));
                    pLeft += len;
                    pRight += len;
                    pTarget += len;

                }
            }
            return dst;
        }

        public static unsafe Index<uint> InXAdd(this Index<uint> lhs, Index<uint> rhs)
        {
            var len = Vector128<uint>.Count;
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();
            var vCount = lhs.Length/len;
            var dst = new uint[lArray.Length];

            fixed(uint* pLhs = &lArray[0])
            fixed(uint* pRhs = &rArray[0])
            fixed(uint* pDst = &dst[0])
            {
                var pLeft = pLhs;
                var pRight = pRhs;
                var pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len)
                {
                    var vL = Avx.LoadVector128(pLeft);
                    var vR = Avx.LoadVector128(pRight);
                    Avx2.Store(pTarget,Avx2.Add(vL,vR));
                    pLeft += len;
                    pRight += len;
                    pTarget += len;

                }
            }
            return dst;
        }


        public static unsafe Index<long> InXAdd(this Index<long> lhs, Index<long> rhs)
        {
            var len = Vector128<long>.Count;
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();
            var vCount = lhs.Length/len;
            var dst = new long[lArray.Length];

            fixed(long* pLhs = &lArray[0])
            fixed(long* pRhs = &rArray[0])
            fixed(long* pDst = &dst[0])
            {
                var pLeft = pLhs;
                var pRight = pRhs;
                var pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len)
                {
                    var vL = Avx.LoadVector128(pLeft);
                    var vR = Avx.LoadVector128(pRight);
                    Avx2.Store(pTarget,Avx2.Add(vL,vR));
                    pLeft += len;
                    pRight += len;
                    pTarget += len;

                }
            }
            return dst;
        }

        public static unsafe Index<ulong> InXAdd(this Index<ulong> lhs, Index<ulong> rhs)
        {
            var len = Vector128<ulong>.Count;
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();
            var vCount = lhs.Length/len;
            var dst = new ulong[lArray.Length];

            fixed(ulong* pLhs = &lArray[0])
            fixed(ulong* pRhs = &rArray[0])
            fixed(ulong* pDst = &dst[0])
            {
                var pLeft = pLhs;
                var pRight = pRhs;
                var pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len)
                {
                    var vL = Avx.LoadVector128(pLeft);
                    var vR = Avx.LoadVector128(pRight);
                    Avx2.Store(pTarget,Avx2.Add(vL,vR));
                    pLeft += len;
                    pRight += len;
                    pTarget += len;

                }
            }
            return dst;
        }


        public static unsafe Index<float> InXAdd(this Index<float> lhs, Index<float> rhs)
        {
            var len = Vector128<float>.Count;
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();
            var vCount = lhs.Length/len;
            var dst = new float[lArray.Length];

            fixed(float* pLhs = &lArray[0])
            fixed(float* pRhs = &rArray[0])
            fixed(float* pDst = &dst[0])
            {
                var pLeft = pLhs;
                var pRight = pRhs;
                var pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len)
                {
                    var vL = Avx.LoadVector128(pLeft);
                    var vR = Avx.LoadVector128(pRight);
                    Avx2.Store(pTarget,Avx2.Add(vL,vR));
                    pLeft += len;
                    pRight += len;
                    pTarget += len;

                }
            }
            return dst;
        }


        public static unsafe Index<double> InXAdd(this Index<double> lhs, Index<double> rhs)
        {
            var len = Vector128<double>.Count;
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();
            var vCount = lhs.Length/len;
            var dst = new double[lArray.Length];

            fixed(double* pLhs = &lArray[0])
            fixed(double* pRhs = &rArray[0])
            fixed(double* pDst = &dst[0])
            {
                var pLeft = pLhs;
                var pRight = pRhs;
                var pTarget = pDst;
                
                for(var i = 0; i< lhs.Count; i += len)
                {
                    var vL = Avx.LoadVector128(pLeft);
                    var vR = Avx.LoadVector128(pRight);
                    Avx2.Store(pTarget,Avx2.Add(vL,vR));
                    pLeft += len;
                    pRight += len;
                    pTarget += len;

                }
            }
            return dst;
        }


    }

}