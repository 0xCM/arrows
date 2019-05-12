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

    public static class Constants<T>
        where T : struct, IEquatable<T>
    {
        public static readonly T Zero = Converters.convert(0, out Zero);
        
        public static readonly T One = Converters.convert(0, out One);
         
    }



}