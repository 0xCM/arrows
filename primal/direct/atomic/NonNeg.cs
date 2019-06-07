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
        public static bool nonneg(sbyte src)
            => src >= 0;
    
        [MethodImpl(Inline)]
        public static bool nonneg(short src)
            => src >= 0;

        [MethodImpl(Inline)]
        public static bool nonneg(int src)
            => src >= 0;

        [MethodImpl(Inline)]
        public static bool nonneg(long src)
            => src >= 0;

        [MethodImpl(Inline)]
        public static bool nonneg(float src)
            => src >= 0;

        [MethodImpl(Inline)]
        public static bool nonneg(double src)
            => src >= 0; 
    }
}