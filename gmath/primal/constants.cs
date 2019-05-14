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
    
    
    using static atoms;
    using static mfunc;

    public readonly struct Constants<T>
        where T : struct
    {
        public static readonly T Zero = gmath.zero<T>();
        
        public static readonly T One = gmath.one<T>();

    }



}