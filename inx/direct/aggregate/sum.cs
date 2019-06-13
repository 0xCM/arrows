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
    using static zfunc;
    
    partial class dinx
    {
        public static short sum(ReadOnlySpan<short> src)
        {
            var veclen = Vec128<short>.Length;
            var seglen = 2*veclen;
            var srclen = src.Length;
            require(0 == srclen % seglen);

            var dst = Vec128.define((short)0);
            var offset = 0;
            for(var i=0; i< srclen; i+= seglen)
            {
                var v1 = Vec128.single(src, offset);
                offset += veclen;
                var v2 = Vec128.single(src, offset);
                offset += veclen;
                var vSum = addh(in v1, in v2);
                dst = add(dst,vSum);                
            }
            
            Span<short> final = stackalloc short[veclen];
            store(dst, ref final[0]);

            var total = (short)0;
            for(var i=0; i< veclen; i++)
                 total += final[i];            
            return total;
        }

        public static int sum(ReadOnlySpan<int> src)
        {
            var veclen = Vec128<int>.Length;
            var seglen = 2*veclen;
            var srclen = src.Length;
            require(0 == srclen % seglen);

            var dst = Vec128.define((int)0);
            var offset = 0;
            for(var i=0; i< srclen; i+= seglen)
            {
                var v1 = Vec128.single(src, offset);
                offset += veclen;
                var v2 = Vec128.single(src, offset);
                offset += veclen;
                var vSum = addh(in v1, in v2);
                dst = add(dst,vSum);                
            }
            
            Span<int> final = stackalloc int[veclen];
            store(dst, ref final[0]);

            var total = (int)0;
            for(var i=0; i< veclen; i++)
                 total += final[i];            
            return total;
        }

        public static float sum(ReadOnlySpan<float> src)
        {
            var veclen = Vec128<float>.Length;
            var seglen = 2*veclen;
            var srclen = src.Length;
            require(0 == srclen % seglen);

            var dst = Vec128.define((float)0);
            var offset = 0;
            for(var i=0; i< srclen; i+= seglen)
            {
                var v1 = Vec128.single(src, offset);
                offset += veclen;
                var v2 = Vec128.single(src, offset);
                offset += veclen;
                var vSum = addh(in v1, in v2);
                dst = add(dst,vSum);                
            }
            
            Span<float> final = stackalloc float[veclen];
            store(dst, ref final[0]);

            var total = (float)0;
            for(var i=0; i< veclen; i++)
                 total += final[i];            
            return total;
        }

        public static double sum(ReadOnlySpan<double> src)
        {
            var veclen = Vec128<double>.Length;
            var seglen = 2*veclen;
            var srclen = src.Length;
            require(0 == srclen % seglen);

            var dst = Vec128.define((double)0);
            var offset = 0;
            for(var i=0; i< srclen; i+= seglen)
            {
                var v1 = Vec128.single(src, offset);
                offset += veclen;
                var v2 = Vec128.single(src, offset);
                offset += veclen;
                var vSum = addh(in v1, in v2);
                dst = add(dst,vSum);                
            }
            
            Span<double> final = stackalloc double[veclen];
            store(dst, ref final[0]);

            var total = (double)0;
            for(var i=0; i< veclen; i++)
                 total += final[i];            
            return total;
        }
    }
}