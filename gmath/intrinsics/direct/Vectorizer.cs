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
    
    using static global::mfunc;

    public unsafe delegate Index<T> Vec128Fuser<T>(in Vec128BinOp<T> Op, in Index<T> lhs, in Index<T> rhs)
        where T : struct, IEquatable<T>;

    public static class Vectorizer
    {
        public static unsafe sbyte[] Vectorize(in Vec128BinOp<sbyte> Op, in sbyte[] lhs, in sbyte[] rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<sbyte>.Length;
            var dst = new sbyte[count];

            fixed(sbyte* pLhs = &lhs[0])
            fixed(sbyte* pRhs = &rhs[0])
            fixed(sbyte* pDst = &dst[0])
            {
                sbyte* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return dst;            
        }

        public static unsafe byte[] Vectorize(in Vec128BinOp<byte> Op, in byte[] lhs, in byte[] rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<byte>.Length;
            var dst = new byte[count];

            fixed(byte* pLhs = &lhs[0])
            fixed(byte* pRhs = &rhs[0])
            fixed(byte* pDst = &dst[0])
            {
                byte* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return dst;            
        }

        public static unsafe short[] Vectorize(in Vec128BinOp<short> Op, in short[] lhs, in short[] rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<short>.Length;
            var dst = new short[count];

            fixed(short* pLhs = &lhs[0])
            fixed(short* pRhs = &rhs[0])
            fixed(short* pDst = &dst[0])
            {
                short* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return dst;            
        }

        public static unsafe ushort[] Vectorize(in Vec128BinOp<ushort> Op, in ushort[] lhs, in ushort[] rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<ushort>.Length;
            var dst = new ushort[count];

            fixed(ushort* pLhs = &lhs[0])
            fixed(ushort* pRhs = &rhs[0])
            fixed(ushort* pDst = &dst[0])
            {
                ushort* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return dst;            
        }

        public static unsafe int[] Vectorize(in Vec128BinOp<int> Op, in int[] lhs, in int[] rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<int>.Length;
            var dst = new int[count];
            fixed(int* pLhs = &lhs[0])
            fixed(int* pRhs = &rhs[0])
            fixed(int* pDst = &dst[0])
            {
                int* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return dst;            
        }

        public static unsafe uint[] Vectorize(in Vec128BinOp<uint> Op, in uint[] lhs, in uint[] rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<uint>.Length;
            var dst = new uint[count];

            fixed(uint* pLhs = &lhs[0])
            fixed(uint* pRhs = &rhs[0])
            fixed(uint* pDst = &dst[0])
            {
                uint* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return dst;            
        }


        public static unsafe long[] Vectorize(in Vec128BinOp<long> Op, in long[] lhs, in long[] rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<long>.Length;
            var dst = new long[count];

            fixed(long* pLhs = &lhs[0])
            fixed(long* pRhs = &rhs[0])
            fixed(long* pDst = &dst[0])
            {
                long* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return dst;            
        }

        public static unsafe ulong[] Vectorize(in Vec128BinOp<ulong> Op, in ulong[] lhs, in ulong[] rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<ulong>.Length;
            var dst = new ulong[count];

            fixed(ulong* pLhs = &lhs[0])
            fixed(ulong* pRhs = &rhs[0])
            fixed(ulong* pDst = &dst[0])
            {
                ulong* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return dst;            
        }
        
        public static unsafe float[] Vectorize(in Vec128BinOp<float> Op, in float[] lhs, in float[] rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<float>.Length;
            var dst = new float[count];

            fixed(float* pLhs = &lhs[0])
            fixed(float* pRhs = &rhs[0])
            fixed(float* pDst = &dst[0])
            {
                float* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return dst;            
        }


        public static unsafe double[] Vectorize(in Vec128BinOp<double> Op, in double[] lhs, in double[] rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<double>.Length;
            var dst = new double[count];

            fixed(double* pLhs = &lhs[0])
            fixed(double* pRhs = &rhs[0])
            fixed(double* pDst = &dst[0])
            {
                double* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return dst;            
        }

    }
}