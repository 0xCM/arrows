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
    using System.Numerics;
    
    using static zfunc;    

    partial class math
    {
        [MethodImpl(Inline)]
        public static int bits(float src)
            => BitConverter.SingleToInt32Bits(src);

        [MethodImpl(Inline)]
        public static long bits(double src)
            => BitConverter.DoubleToInt64Bits(src);        
    }

}