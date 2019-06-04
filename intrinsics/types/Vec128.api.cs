//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using Member = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;
    using static ErrorMessages;

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;
    
    using static zfunc;
    using static As;
    

    public static partial class Vec128
    {

        [MethodImpl(Inline)]
        public static Vec128<T> zero<T>() 
            where T : struct
                => Vec128<T>.Zero;

        [MethodImpl(Inline)]
        public static Span128<T> load<T>(Vec128<T> src, Span128<T> dst, int blockIndex)
            where T : struct        
        {
            var offset = Span128.blocklength<T>(blockIndex);
            src.ExtractTo(dst, offset);
            return dst;                        
        }


    }
}