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

        public static Span256<double> sqrt(Span256<double> src, Span256<double> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                ref var data = ref src.Block(block);
                var x =  Vec256.load(ref data);
                var y = Avx2.Sqrt(x);
                store(y, ref dst[block]);
                
            }
            return dst;
        }

        public static Span256<float> sqrt(Span256<float> src, Span256<float> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                ref var data = ref src.Block(block);
                var x =  Vec256.load(ref data);
                var y = Avx2.Sqrt(x);
                store(y, ref dst[block]);
                
            }
            return dst;
        }

    }

}