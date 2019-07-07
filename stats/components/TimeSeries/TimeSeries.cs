//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Threading;

    using static zfunc;    


    public class TimeSeries<T> : ITimeSeries<T>
        where T : struct
    {
        [MethodImpl]
        public TimeSeries(long Id, Interval<T> Domain, SeriesTerm<T> FirstTerm)
        {
            this.Id = Id;
            this.Domain = Domain;
            this.Observed = FirstTerm;
        }

        public void Witnessed(SeriesTerm<T> term)
            => Observed = term;

        public long Id {get;}

        /// <summary>
        /// Specifies the observation domain
        /// </summary>
        public Interval<T> Domain {get;}    

        public SeriesTerm<T> Observed {get; private set;}
 
        [MethodImpl]
        public TimeSeries<T> Snapshot()
            => new TimeSeries<T>(Id, Domain, Observed);
    }
}