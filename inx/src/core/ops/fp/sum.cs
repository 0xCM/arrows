//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;    

    partial class dfp
    {
        public static float Sum(ReadOnlySpan<float> src)
        {
            var veclen = Vec128<float>.Length;
            var seglen = 2*veclen;
            var srclen = src.Length;
            require(0 == srclen % seglen);

            var dst = Vec128.Fill((float)0);
            var offset = 0;
            for(var i=0; i< srclen; i+= seglen)
            {
                var v1 = Vec128.Load(src, offset);
                offset += veclen;
                var v2 = Vec128.Load(src, offset);
                offset += veclen;
                var vSum = dfp.hadd(in v1, in v2);
                dst = dfp.add(dst,vSum);                
            }
            
            Span<float> final = stackalloc float[veclen];
            vstore(dst, ref final[0]);

            var total = (float)0;
            for(var i=0; i< veclen; i++)
                 total += final[i];            
            return total;
        }

        [MethodImpl(Inline)]
        public static float sum(Span<float> src)
            => src.ReadOnly().Sum();

        public static double sum(ReadOnlySpan<double> src)
        {
            var veclen = Vec128<double>.Length;
            var seglen = 2*veclen;
            var srclen = src.Length;
            require(0 == srclen % seglen);

            var dst = Vec128.Fill((double)0);
            var offset = 0;
            for(var i=0; i< srclen; i+= seglen)
            {
                var v1 = Vec128.Load(src, offset);
                offset += veclen;
                var v2 = Vec128.Load(src, offset);
                offset += veclen;
                var vSum = dfp.hadd(in v1, in v2);
                dst = dfp.add(dst,vSum);                
            }
            
            Span<double> final = stackalloc double[veclen];
            vstore(dst, ref final[0]);

            var total = (double)0;
            for(var i=0; i< veclen; i++)
                 total += final[i];            
            return total;
        }

        [MethodImpl(Inline)]
        public static double sum(Span<double> src)        
            => sum(src.ReadOnly());


    }

}