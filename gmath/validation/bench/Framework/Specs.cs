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

    using static zfunc;
    using static mfunc;

    public interface IBenchSummary
    {

        IOpMetrics Metrics {get;}

        AppMsg Description {get;}

    }

    public interface IBenchComparison
    {
        string LeftTitle {get;}

        AppMsg LeftMsg {get;}
        
        IOpMetrics LeftMetrics{get;}

        string RightTitle {get;}

        AppMsg RightMsg {get;}

        IOpMetrics RightMetrics {get;}

        double Ratio {get;}

        BenchComparisonRecord ToRecord();
    }


}