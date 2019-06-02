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
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
        
    using static zfunc;    

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<float> sqrt(in Vec128<float> src)
            => Sqrt(src);

        [MethodImpl(Inline)]
        public static Vec128<double> sqrt(in Vec128<double> src)
            => Sqrt(src);
 
        [MethodImpl(Inline)]
        public static Vec256<float> sqrt(in Vec256<float> src)
            => Sqrt(src);

        [MethodImpl(Inline)]
        public static Vec256<double> sqrt(in Vec256<double> src)
            => Sqrt(src);

        public static Span256<double> sqrt(in Span256<double> src, Span256<double> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.load(ref src.Block(block));
                store(Sqrt(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span256<float> sqrt(in Span256<float> src, Span256<float> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.load(ref src.Block(block));
                store(Sqrt(x), ref dst[block]);                
            }
            return dst;
        }
    }
}