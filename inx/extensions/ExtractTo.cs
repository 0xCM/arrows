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


    public static class StoreToX
    {
        [MethodImpl(Inline)]
        public static Span<T> StoreTo<T>(this in Vec256<T> src, Span<T> dst, int offset = 0)
            where T : struct
        {
            
            Vec256.store(src,ref dst[offset]);
            return  dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> StoreTo<T>(this in Vec128<T> src, Span<T> dst, int offset = 0)
            where T : struct
        {            
            Vec128.store(src, ref dst[offset]);
            return  dst;
        }

    }

}