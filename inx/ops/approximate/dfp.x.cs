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

    public static class dfpx
    {

        public static Span256<double> sqrt(this Span256<double> src, Span256<double> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.Load(ref src.Block(block));
                dinx.store(dfp.sqrt(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span256<float> sqrt(this Span256<float> src, Span256<float> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.Load(ref src.Block(block));
                dinx.store(dfp.sqrt(x), ref dst[block]);                
            }
            return dst;
        }


    }

}