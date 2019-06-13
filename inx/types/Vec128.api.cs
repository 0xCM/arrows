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
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;
    using static As;
    
    public static partial class Vec128
    {

        [MethodImpl(Inline)]
        public static Vec128<T> zero<T>() 
            where T : struct
                => Vec128<T>.Zero;

        [MethodImpl(Inline)]
        public static Vec128<T> one<T>()
            where T : struct
                => Vec128C.one<T>();
    }
}