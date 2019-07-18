//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    using static zfunc;


    public class RunningMean
    {

        public RunningMean(params double[] init)
        {

        }

        public double Current {get; private set;}

        public ulong PointCount {get; private set;}

    }

}