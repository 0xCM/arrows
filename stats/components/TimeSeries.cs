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

    public static class TimeSeries
    {
        static long LastSeriesId;
        
        static readonly ConcurrentDictionary<long, IRandomSource> States
            = new ConcurrentDictionary<long, IRandomSource>();

        public static SeriesTerm<T> Term<T>(long index, T value)
            where T : struct
            => new SeriesTerm<T>(index, value);  

        public static SeriesTerm<T> NextTerm<T>(TimeSeries<T> series)      
            where T : struct
        {
            if(States.TryGetValue(series.Id, out IRandomSource random))
            {                
                var term = Term(series.LastTerm.Index + 1, random.Next<T>(series.Domain));
                series.Observed(term);
                return term;
            }
            else
                return series.LastTerm;
        }

        public static IEnumerable<SeriesTerm<T>> Terms<T>(TimeSeries<T> series)
            where T : struct
        {
            if(States.TryGetValue(series.Id, out IRandomSource random))
            {                
                while(true)
                {
                    var term = Term(series.LastTerm.Index + 1, random.Next<T>(series.Domain));
                    series.Observed(term);
                    yield return term;
                }
            }
        }

        static long inc(ref long x)
            => Interlocked.Increment(ref x);

        public static TimeSeries<T> Define<T>(Interval<T> domain)
            where T : struct
        {
            var id = inc(ref LastSeriesId);
            var rng = RNG.XOrShift1024(Seed1024.Entropic);
            if(!States.TryAdd(id,rng))
                throw new Exception($"Key {id} already exists");
            return new TimeSeries<T>(id, domain, Term(0, gmath.zero<T>()));
        }
    }

    public interface ITimeSeries
    {
        long Id {get;}

        SeriesTerm LastTerm {get;}
    }

    public interface ITimeSeries<T> : ITimeSeries
        where T : struct
    {
        new SeriesTerm<T> LastTerm {get;}

        Interval<T> Domain {get;}         
    }
    
    public class TimeSeries<T> : ITimeSeries
        where T : struct
    {
        public TimeSeries(long Id, Interval<T> Domain, SeriesTerm<T> FirstTerm)
        {
            this.Id = Id;
            this.Domain = Domain;
            this.LastTerm = FirstTerm;
        }

        public void Observed(SeriesTerm<T> term)
            => LastTerm = term;

        public long Id {get;}

        /// <summary>
        /// Specifies the observation domain
        /// </summary>
        /// <value></value>
        public Interval<T> Domain {get;}    

        public SeriesTerm<T> LastTerm {get; private set;}

        SeriesTerm ITimeSeries.LastTerm 
            => LastTerm;
    }

    public static class TimeSeriesX
    {
        public static IEnumerable<SeriesTerm<T>> Terms<T>(this TimeSeries<T> series)
            where T : struct
                => TimeSeries.Terms(series);
    }

    public readonly struct SeriesTerm
    {
        public SeriesTerm(long index, object observation)
        {
            this.Index = index;
            this.Observed = observation;
        }

        public readonly long Index;

        public readonly object Observed;

        public string Format()
            => $"({Index}, {Observed})";
    
        public override string ToString()
            => Format();
    }

    public readonly struct SeriesTerm<T>
    {
        public static implicit operator SeriesTerm(SeriesTerm<T> src)
            => new SeriesTerm(src.Index, src.Observed);

        public SeriesTerm(long index, T observation)
        {
            this.Index = index;
            this.Observed = observation;
        }

        public readonly long Index;

        public readonly T Observed;

        public string Format()
            => $"({Index}, {Observed})";
    
        public override string ToString()
            => Format();
    }

}