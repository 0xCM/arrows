//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static zfunc;

    public interface ITimeSeries
    {
        long Id {get;}

    }

    public interface ITimeSeries<T> : ITimeSeries
        where T : struct
    {
        SeriesTerm<T> Observed {get;}

        Interval<T> Domain {get;}         
    }
}