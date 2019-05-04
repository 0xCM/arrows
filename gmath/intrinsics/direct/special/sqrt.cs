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
        public static Vec128<float> sqrt(Vec128<float> src)
            => Avx2.Sqrt(src);

        [MethodImpl(Inline)]
        public static Vec128<double> sqrt(Vec128<double> src)
            => Avx2.Sqrt(src);
 
         [MethodImpl(Inline)]
        public static Vec256<float> sqrt(Vec256<float> src)
            => Avx2.Sqrt(src);

        [MethodImpl(Inline)]
        public static Vec256<double> sqrt(Vec256<double> src)
            => Avx2.Sqrt(src);


        [MethodImpl(Inline)]
        public static unsafe void sqrt(float* src, float* dst)  
            => store(sqrt(Vec128.load(src)), dst);

        [MethodImpl(Inline)]
        public static unsafe void sqrt(double* src, double* dst)  
            => store(sqrt(Vec128.load(src)), dst);

        public static unsafe Index<double> sqrt(Index<double> src)
        {
            var len = Vector128<double>.Count;
            var dst = new double[src.Length];

            fixed(double* pLhs = &(src.ToArray()[0]))
            fixed(double* pDst = &dst[0])
            {
                double* pLeft = pLhs, pTarget = pDst;                
                for(var i = 0; i< src.Count; i += len, pLeft += len, pTarget += len)
                    sqrt(pLeft, pTarget);
            }
            return dst;
        }

        public static unsafe Index<float> sqrt(Index<float> src)
        {
            var len = Vector128<float>.Count;
            var dst = new float[src.Length];

            fixed(float* pLhs = &(src.ToArray()[0]))
            fixed(float* pDst = &dst[0])
            {
                float* pLeft = pLhs, pTarget = pDst;                
                for(var i = 0; i< src.Count; i += len, pLeft += len, pTarget += len)
                    sqrt(pLeft, pTarget);
            }
            return dst;
        }


    }

}