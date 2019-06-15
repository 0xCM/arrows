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
    
    
    
    using static As;
    using static zfunc;

    public static partial class MathX
    {
        [MethodImpl(Inline)]
        public static int ToBits(this float src)
            => BitConverter.SingleToInt32Bits(src);

        [MethodImpl(Inline)]
        public static long ToBits(this double src)
            => BitConverter.DoubleToInt64Bits(src);
    }
    
}