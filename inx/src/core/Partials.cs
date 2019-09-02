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
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.CompilerServices;
    using static zfunc;

    public static partial class dinx
    {

    }

    public static partial class dinxx
    {
        
    }

    public static partial class ginxs
    {        

    }

    /// <summary>
    /// Defines direct floating-point operations
    /// </summary>
    public static partial class dfp
    {
        [MethodImpl(Inline)]
        static FloatComparisonMode fpmode(FpCmpMode m)
            => (FloatComparisonMode)m;


    }
    public static partial class dfpx
    {


    }
    public static partial class ginx
    {        
        public static IEnumerable<MethodInfo> BinOps()
        {
            return typeof(ginx).Methods().Public().OpenGeneric().Where(x => x.ParameterTypes().Count() == 2);
        }

    }
}