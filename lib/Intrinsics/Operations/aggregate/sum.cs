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
    using static vec128;
    

    partial class InX
    {
        public static unsafe short sum(in Index<short> src)
        {
            var veclen = Vec128<short>.Length;
            var seglen = 2*veclen;
            var srclen = src.Count;
            Claim.eq(0, srclen % seglen);

            var dst = Vec128.define((short)0);
            fixed(short* pSrc = &(src.ToArray()[0]))            
            {
                short* pSrcWalker = pSrc;
                for(var i = 0; i< srclen; i += seglen)
                {
                    var v1 = Vec128.load(pSrcWalker);
                    pSrcWalker += veclen;                       

                    var v2 = Vec128.load(pSrcWalker);
                    pSrcWalker += veclen;

                    var vSum = addh(v1,v2);
                    dst = add(dst, vSum);
                }
            }
            
            var final = stackalloc short[veclen];
            store(dst,final);
            var total = (short)0;
            for(var i=0; i< veclen; i++)
                total += final[i];            
            return total;
        }

        public static unsafe int sum(in Index<int> src)
        {
            var veclen = Vec128<short>.Length;
            var seglen = 2*veclen;
            var srclen = src.Count;
            Claim.eq(0, srclen % seglen);

            var dst = Vec128.define(0);
            fixed(int* pSrc = &(src.ToArray()[0]))            
            {
                int* pSrcWalker = pSrc;
                for(var i = 0; i< srclen; i += seglen)
                {
                    var v1 = Vec128.load(pSrcWalker);
                    pSrcWalker += veclen;                       

                    var v2 = Vec128.load(pSrcWalker);
                    pSrcWalker += veclen;

                    var vSum = addh(v1,v2);
                    dst = add(dst, vSum);
                }
            }
            
            var final = stackalloc int[veclen];
            store(dst,final);
            var total = 0;
            for(var i=0; i< veclen; i++)
                total += final[i];            
            return total;

        }

        public static unsafe float sum(in Index<float> src)
        {
            var veclen = Vec128<short>.Length;
            var seglen = 2*veclen;
            var srclen = src.Count;
            Claim.eq(0, srclen % seglen);

            var dst = Vec128.define(0.0f);
            fixed(float* pSrc = &(src.ToArray()[0]))            
            {
                float* pSrcWalker = pSrc;
                for(var i = 0; i< srclen; i += seglen)
                {
                    var v1 = Vec128.load(pSrcWalker);
                    pSrcWalker += veclen;                       

                    var v2 = Vec128.load(pSrcWalker);
                    pSrcWalker += veclen;

                    var vSum = addh(v1,v2);
                    dst = add(dst, vSum);
                }
            }
            
            var final = stackalloc float[veclen];
            store(dst,final);
            var total = 0f;
            for(var i=0; i< veclen; i++)
                total += final[i];            
            return total;
        }

        public static unsafe double sum(in Index<double> src)
        {
            var veclen = Vec128<double>.Length;
            var seglen = 2*veclen;
            var srclen = src.Count;
            Claim.eq(0, srclen % seglen);

            var dst = Vec128.define(0.0);
            fixed(double* pSrc = &(src.ToArray()[0]))            
            {
                double* pSrcWalker = pSrc;
                for(var i = 0; i< srclen; i += seglen)
                {
                    var v1 = Vec128.load(pSrcWalker);
                    pSrcWalker += veclen;                       

                    var v2 = Vec128.load(pSrcWalker);
                    pSrcWalker += veclen;

                    var vSum = addh(v1,v2);
                    dst = add(dst, vSum);
                }
            }
            
            var final = stackalloc double[veclen];
            store(dst,final);
            var total = 0d;
            for(var i=0; i< veclen; i++)
                total += final[i];
            return total;
        }

        static readonly PrimalIndex SumLU
            = PrimalKinds.index<object>
                (
                    @short: new PrimalAggOp<short>(InX.sum),
                    @int: new PrimalAggOp<int>(InX.sum),
                    @float: new PrimalAggOp<float>(InX.sum),
                    @double:new PrimalAggOp<double>(InX.sum)
                );

        internal readonly struct Sum<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalAggOp<T> Op = SumLU.lookup<T,PrimalAggOp<T>>();
        }

    }
}