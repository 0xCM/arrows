//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;    
    using System.Diagnostics;
    
    using static zfunc;
    
    partial class xfunc
    {

        /// <summary>
        /// Retrieves information about a processes' threads
        /// </summary>
        /// <param name="proc">The process to query</param>
        public static IEnumerable<ProcessThread> ProcessThreads(this Process proc)
            => from ProcessThread pt in proc.Threads select pt;

    }

}