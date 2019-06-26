//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    
    using static zfunc;
    using static As;
    using static AsInX;

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static bool gteq<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.gteq(in float32(in lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                return dinx.gteq(in float64(in lhs), in float64(in rhs));
            else
                throw unsupported<T>();

        }

    }

}
