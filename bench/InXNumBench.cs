//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static As;
    using static InXMetrics;

    public static partial class InXNumBench
    {
        static OpId<T> Id<T>(OpKind op, InXMetricConfig128 config)
            where T : struct
                => op.InXId<T>(config, false);


    }

}
