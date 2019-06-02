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
        public static Span128<T> load<T>(Vec128<T> src, Span128<T> dst, int blockIndex)
            where T : struct        
        {
            var offset = Span128.blocklength<T>(blockIndex);
            src.ExtractTo(dst, offset);
            return dst;                        
        }

        [MethodImpl(Inline)]
        public static bool requireEq<T>(Vec128<T> lhs, Vec128<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
                => lhs.Eq(rhs) ? true : throw Errors.NotEqual(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool requireEq<T>(Vec256<T> lhs, Vec256<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
                => lhs.Eq(rhs) ? true : throw Errors.NotEqual(lhs,rhs, caller, file, line);

    }
}