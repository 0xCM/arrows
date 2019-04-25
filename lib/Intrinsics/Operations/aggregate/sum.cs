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


    partial class InXX
    {
        public static unsafe short InXSum(this Index<short> src)
        {
            var veclen = Vector128<short>.Count;
            var seglen = 2*veclen;
            var srclen = src.Count;
            Claim.eq(0, srclen % seglen);

            var dst = Vector128.Create((short)0);
            fixed(short* pSrc = &(src.ToArray()[0]))            
            {
                short* pSrcWalker = pSrc;
                for(var i = 0; i< srclen; i += seglen)
                {
                    var v1 = load(pSrcWalker);
                    pSrcWalker += veclen;                       

                    var v2 = load(pSrcWalker);
                    pSrcWalker += veclen;

                    var vSum = Avx2.HorizontalAdd(v1,v2);
                    dst = Avx2.Add(dst, vSum);
                }
            }
            
            var final = stackalloc short[veclen];
            store(dst,final);
            var total = (short)0;
            for(var i=0; i< veclen; i++)
                total += final[0];            
            return total;
        }

        public static unsafe int InXSum(this Index<int> src)
        {
            var veclen = Vector128<int>.Count;
            var seglen = 2*veclen;
            var srclen = src.Count;
            Claim.eq(0, srclen % seglen);

            var dst = Vector128.Create(0);
            fixed(int* pSrc = &(src.ToArray()[0]))            
            {
                int* pSrcWalker = pSrc;
                for(var i = 0; i< srclen; i += seglen)
                {
                    var v1 = load(pSrcWalker);
                    pSrcWalker += veclen;                       

                    var v2 = load(pSrcWalker);
                    pSrcWalker += veclen;

                    var vSum = Avx2.HorizontalAdd(v1,v2);
                    dst = Avx2.Add(dst, vSum);
                }
            }
            
            var final = stackalloc int[veclen];
            store(dst,final);
            var total = 0;
            for(var i=0; i< veclen; i++)
                total += final[0];            
            return total;
        }

        public static unsafe float InXSum(this Index<float> src)
        {
            var veclen = Vector128<float>.Count;
            var seglen = 2*veclen;
            var srclen = src.Count;
            Claim.eq(0, srclen % seglen);

            var dst = Vector128.Create(0.0f);
            fixed(float* pSrc = &(src.ToArray()[0]))            
            {
                float* pSrcWalker = pSrc;
                for(var i = 0; i< srclen; i += seglen)
                {
                    var v1 = load(pSrcWalker);
                    pSrcWalker += veclen;                       

                    var v2 = load(pSrcWalker);
                    pSrcWalker += veclen;

                    var vSum = Avx2.HorizontalAdd(v1,v2);
                    dst = Avx2.Add(dst, vSum);
                }
            }
            
            var final = stackalloc float[veclen];
            store(dst,final);
            var total = 0f;
            for(var i=0; i< veclen; i++)
                total += final[0];            
            return total;
        }

        public static unsafe double InXSum(this Index<double> src)
        {
            var veclen = Vector128<double>.Count;
            var seglen = 2*veclen;
            var srclen = src.Count;
            Claim.eq(0, srclen % seglen);

            var dst = Vector128.Create(0.0);
            fixed(double* pSrc = &(src.ToArray()[0]))            
            {
                double* pSrcWalker = pSrc;
                for(var i = 0; i< srclen; i += seglen)
                {
                    var v1 = load(pSrcWalker);
                    pSrcWalker += veclen;                       

                    var v2 = load(pSrcWalker);
                    pSrcWalker += veclen;

                    var vSum = Avx2.HorizontalAdd(v1,v2);
                    dst = Avx2.Add(dst, vSum);
                }
            }
            
            var final = stackalloc double[veclen];
            store(dst,final);
            var total = 0d;
            for(var i=0; i< veclen; i++)
                total += final[0];
            return total;
        }
    }
}