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

    using static As;
    using static AsInX;

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static Vec128<T> dec<T>(in Vec128<T> src)
            where T : struct
                => sub(in src, in Vec128.Ones<T>());

        [MethodImpl(Inline)]
        public static Vec256<T> dec<T>(in Vec256<T> src)
            where T : struct
                => sub(in src, in Vec256.Ones<T>());

    }

}