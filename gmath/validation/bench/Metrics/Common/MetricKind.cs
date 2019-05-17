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
    using static mfunc;


    public enum MetricKind
    {
        Common,

        /// <summary>
        /// Identifies primal + generic + fused benchmarks
        /// </summary>        
        PrimalFused,
        
        /// <summary>
        /// Identifies primal + generic + atomic benchmarks
        /// </summary>        
        PrimalGeneric,

        /// <summary>
        /// Identifies primal + direct + atomic metrics
        /// </summary>        
        PrimalDirect,

        /// <summary>
        /// Identifies number + generic + atomic metrics
        /// </summary>        
        Number,

        /// <summary>
        /// Identifies numbers + generic + fused metrics
        /// </summary>        
        Numbers,

        
        Num128,

        Vec128,

        Vec128Direct,

        Vec256,

        Vec256Direct

    }


}