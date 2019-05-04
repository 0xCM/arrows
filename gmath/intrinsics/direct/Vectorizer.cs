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


    public unsafe delegate Index<T> Vec128Fuser<T>(in Vec128BinOp<T> Op, in Index<T> lhs, in Index<T> rhs)
        where T : struct, IEquatable<T>;

    public static class Vectorizer
    {
        static readonly PrimalIndex LU = PrimalIndex.define(
            @sbyte: new Vec128Fuser<sbyte>(Vectorize),
            @byte: new Vec128Fuser<byte>(Vectorize),
            @short: new Vec128Fuser<short>(Vectorize),
            @ushort: new Vec128Fuser<ushort>(Vectorize),
            @int: new Vec128Fuser<int>(Vectorize),
            @uint: new Vec128Fuser<uint>(Vectorize),
            @long: new Vec128Fuser<long>(Vectorize),
            @ulong: new Vec128Fuser<ulong>(Vectorize),
            @float: new Vec128Fuser<float>(Vectorize),
            @double: new Vec128Fuser<double>(Vectorize)
        );

        readonly struct Cache<T>
            where T : struct, IEquatable<T>
        {
            public static readonly Vec128Fuser<T> Op = LU.lookup<T,Vec128Fuser<T>>();
        }


        public static unsafe Index<sbyte> Vectorize(in Vec128BinOp<sbyte> Op, in Index<sbyte> lhs, in Index<sbyte> rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<sbyte>.Length;
            var target = new sbyte[count];
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();

            fixed(sbyte* pLhs = &lArray[0])
            fixed(sbyte* pRhs = &rArray[0])
            fixed(sbyte* pDst = &target[0])
            {
                sbyte* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return target;            
        }

        public static unsafe Index<byte> Vectorize(in Vec128BinOp<byte> Op, in Index<byte> lhs, in Index<byte> rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<byte>.Length;
            var target = new byte[count];
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();

            fixed(byte* pLhs = &lArray[0])
            fixed(byte* pRhs = &rArray[0])
            fixed(byte* pDst = &target[0])
            {
                byte* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return target;            
        }

        public static unsafe Index<short> Vectorize(in Vec128BinOp<short> Op, in Index<short> lhs, in Index<short> rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<short>.Length;
            var target = new short[count];
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();

            fixed(short* pLhs = &lArray[0])
            fixed(short* pRhs = &rArray[0])
            fixed(short* pDst = &target[0])
            {
                short* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return target;            
        }

        public static unsafe Index<ushort> Vectorize(in Vec128BinOp<ushort> Op, in Index<ushort> lhs, in Index<ushort> rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<ushort>.Length;
            var target = new ushort[count];
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();

            fixed(ushort* pLhs = &lArray[0])
            fixed(ushort* pRhs = &rArray[0])
            fixed(ushort* pDst = &target[0])
            {
                ushort* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return target;            
        }

        public static unsafe Index<int> Vectorize(in Vec128BinOp<int> Op, in Index<int> lhs, in Index<int> rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<int>.Length;
            var target = new int[count];
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();

            fixed(int* pLhs = &lArray[0])
            fixed(int* pRhs = &rArray[0])
            fixed(int* pDst = &target[0])
            {
                int* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return target;            
        }

        public static unsafe Index<uint> Vectorize(in Vec128BinOp<uint> Op, in Index<uint> lhs, in Index<uint> rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<uint>.Length;
            var target = new uint[count];
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();

            fixed(uint* pLhs = &lArray[0])
            fixed(uint* pRhs = &rArray[0])
            fixed(uint* pDst = &target[0])
            {
                uint* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return target;            
        }


        public static unsafe Index<long> Vectorize(in Vec128BinOp<long> Op, in Index<long> lhs, in Index<long> rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<long>.Length;
            var target = new long[count];
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();

            fixed(long* pLhs = &lArray[0])
            fixed(long* pRhs = &rArray[0])
            fixed(long* pDst = &target[0])
            {
                long* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return target;            
        }

        public static unsafe Index<ulong> Vectorize(in Vec128BinOp<ulong> Op, in Index<ulong> lhs, in Index<ulong> rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<ulong>.Length;
            var target = new ulong[count];
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();

            fixed(ulong* pLhs = &lArray[0])
            fixed(ulong* pRhs = &rArray[0])
            fixed(ulong* pDst = &target[0])
            {
                ulong* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return target;            
        }



        public static unsafe Index<float> Vectorize(in Vec128BinOp<float> Op, in Index<float> lhs, in Index<float> rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<float>.Length;
            var target = new float[count];
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();

            fixed(float* pLhs = &lArray[0])
            fixed(float* pRhs = &rArray[0])
            fixed(float* pDst = &target[0])
            {
                float* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return target;            
        }


        public static unsafe Index<double> Vectorize(in Vec128BinOp<double> Op, in Index<double> lhs, in Index<double> rhs)
        {
            var count = length(lhs,rhs);
            var veclen = Vec128<double>.Length;
            var target = new double[count];
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();

            fixed(double* pLhs = &lArray[0])
            fixed(double* pRhs = &rArray[0])
            fixed(double* pDst = &target[0])
            {
                double* pLhsWalk = pLhs, pRhsWalk = pRhs, pDstWalk = pDst;
                for(var i = 0; i< count; i += veclen, pLhsWalk += veclen, pRhsWalk += veclen, pDstWalk += veclen)
                {
                    var vLeft = Vec128.load(pLhs);
                    var vRight = Vec128.load(pRhs);
                    dinx.store(Op(vLeft,vRight), pDst);                
                }
            }
            return target;            
        }

        public static Vec128Fuser<T> vectorize<T>()
            where T : struct, IEquatable<T>
                => Cache<T>.Op;
        public static Index<T> vectorize<T>(Vec128BinOp<T> op, in Index<T> lhs, in Index<T> rhs)
            where T : struct, IEquatable<T>
                => Cache<T>.Op(op,lhs,rhs);
    }
}