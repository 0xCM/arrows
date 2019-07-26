//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.InteropServices;

    using static zfunc;    
    
    partial class dinxx
    {

        [MethodImpl(Inline)]
        public static Vec256<T> ToVec256<T>(this Span256<T> src, int block)
            where T : struct
                => Vec256.load(ref src.Block(block));

        [MethodImpl(Inline)]
        public static Vec128<T> ToVec128<T>(this Span128<T> src, int block)
            where T : struct
                => Vec128.load(ref src.Block(block));

    }
}


