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

    public interface IOpMetrics
    {
       OpId OpId {get;}
  
       long OpCount {get;}

       Duration WorkTime {get;}

        ReadOnlyMemory<R> Results<R>()
            where R : struct;        
        AppMsg Describe(bool total = false, bool digitcommas = true);

        bool PrimalDirect {get;}
    }

 

}