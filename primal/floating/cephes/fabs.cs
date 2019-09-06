//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    
    partial class cephes
    {
        [MethodImpl(Inline)]
        public static double fabs(double x)
            => Float64.From(x).Abs();
    }
}
