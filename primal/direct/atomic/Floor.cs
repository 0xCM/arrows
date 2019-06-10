//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    
    partial class math
    {

        [MethodImpl(Inline)]
        public static float floor(float src)
            => MathF.Floor(src);

        [MethodImpl(Inline)]
        public static double floor(double src)
            => Math.Floor(src);

    }

}