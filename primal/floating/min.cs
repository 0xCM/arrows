//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static float min(float lhs, float rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static double min(double lhs, double rhs)
            => lhs < rhs ? lhs : rhs;

    }

}