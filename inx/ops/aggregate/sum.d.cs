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

    partial class dinxx
    {
        public static short Sum(this ReadOnlySpan<short> src, NumericSystem system = NumericSystem.Intrinsic)
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
                var vSum = addh(in v1, in v2);
                dst = add(dst,vSum);                
            }
            
            Span<short> final = stackalloc short[veclen];
            vstore(dst, ref final[0]);

            var total = (short)0;
            for(var i=0; i< veclen; i++)
                 total += final[i];            
            return total;
        }

        [MethodImpl(Inline)]
        public static short Sum(this Span<short> src, NumericSystem system = NumericSystem.Intrinsic)        
            => src.ReadOnly().Sum(system);
            
        public static int Sum(this ReadOnlySpan<int> src, NumericSystem system = NumericSystem.Intrinsic)
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
                var vSum = addh(in v1, in v2);
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
        public static int Sum(this Span<int> src, NumericSystem system = NumericSystem.Intrinsic)
            => src.ReadOnly().Sum(system);

        public static float Sum(this ReadOnlySpan<float> src, NumericSystem system = NumericSystem.Intrinsic)
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
                var vSum = addh(in v1, in v2);
                dst = add(dst,vSum);                
            }
            
            Span<float> final = stackalloc float[veclen];
            vstore(dst, ref final[0]);

            var total = (float)0;
            for(var i=0; i< veclen; i++)
                 total += final[i];            
            return total;
        }

        [MethodImpl(Inline)]
        public static float Sum(this Span<float> src, NumericSystem system = NumericSystem.Intrinsic)
            => src.ReadOnly().Sum(system);

        public static double Sum(this ReadOnlySpan<double> src, NumericSystem system = NumericSystem.Intrinsic)
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
                var vSum = addh(in v1, in v2);
                dst = add(dst,vSum);                
            }
            
            Span<double> final = stackalloc double[veclen];
            vstore(dst, ref final[0]);

            var total = (double)0;
            for(var i=0; i< veclen; i++)
                 total += final[i];            
            return total;
        }

        [MethodImpl(Inline)]
        public static double Sum(this Span<double> src, NumericSystem system = NumericSystem.Intrinsic)        
            => src.ReadOnly().Sum(system);
    }
}