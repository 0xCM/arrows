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
    using static dinx;

    partial class dinx
    {
        public static short Sum(ReadOnlySpan<short> src)
        {
            var veclen = Vec128<short>.Length;
            var seglen = 2*veclen;
            var srclen = src.Length;
            require(0 == srclen % seglen);

            var dst = Vec128.Fill((short)0);
            var offset = 0;
            for(var i=0; i< srclen; i+= seglen)
            {
                var v1 = Vec128.Load(src, offset);
                offset += veclen;
                var v2 = Vec128.Load(src, offset);
                offset += veclen;
                var vSum = hadd(in v1, in v2);
                dst = add(dst,vSum);                
            }
            
            Span<short> final = stackalloc short[veclen];
            vstore(dst, ref final[0]);

            var total = (short)0;
            for(var i=0; i< veclen; i++)
                 total += final[i];            
            return total;
        }

            
        public static int Sum(ReadOnlySpan<int> src)
        {
            var veclen = Vec128<int>.Length;
            var seglen = 2*veclen;
            var srclen = src.Length;
            require(0 == srclen % seglen);

            var dst = Vec128.Fill((int)0);
            var offset = 0;
            for(var i=0; i< srclen; i+= seglen)
            {
                var v1 = Vec128.Load(src, offset);
                offset += veclen;
                var v2 = Vec128.Load(src, offset);
                offset += veclen;
                var vSum = hadd(in v1, in v2);
                dst = add(dst,vSum);                
            }
            
            Span<int> final = stackalloc int[veclen];
            vstore(dst, ref final[0]);

            var total = (int)0;
            for(var i=0; i< veclen; i++)
                 total += final[i];            
            return total;
        }

        [MethodImpl(Inline)]
        public static int Sum(Span<int> src)
            => Sum(src.ReadOnly());

    }
}