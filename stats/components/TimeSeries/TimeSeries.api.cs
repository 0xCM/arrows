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
    using System.Threading.Tasks;

    using static zfunc;    


    public static class TimeSeries
    {
        static long LastSeriesId;

        static long NextId(ref long x)
            => Interlocked.Increment(ref x);

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
                var term = Term(series.Observed.Index + 1, random.Next<T>(series.Domain));
                series.Witnessed(term);
                return term;
            }
            else
                return series.Observed;
        }

        internal static IEnumerable<SeriesTerm<T>> Evolve<T>(TimeSeries<T> series)
            where T : struct
        {
            if(States.TryGetValue(series.Id, out IRandomSource random))
            {                
                while(true)
                {
                    var term = Term(series.Observed.Index + 1, random.Next<T>(series.Domain));
                    series.Witnessed(term);
                    yield return term;
                }
            }
        }

        public static TimeSeries<T> Define<T>(Interval<T> domain, ulong[] seed)
            where T : struct
        {
            var id = NextId(ref LastSeriesId);
            var rng = RNG.XOrShift1024(seed);
            if(!States.TryAdd(id,rng))
                throw new Exception($"Key {id} already exists");
            return new TimeSeries<T>(id, domain, Term(0, gmath.zero<T>()));
        }

        public static void EvolveSeries<T>(Interval<T> domain, ulong[] seed, int count, Action<TimeSeries<T>,Duration> complete)
            where T : struct
        {
            var sw = stopwatch();
            var series = Define(domain, seed); 
            var terms = series.Terms().TakeSpan(count);
            var time = snapshot(sw);
            Claim.eq(terms.Length, count);
            Claim.eq(series.Observed.Observed, terms[count - 1].Observed);
            complete(series,time);
        }

        static SeriesEvolution<T> Execute<T>(in ulong[] seed, in Interval<T> domain, int steps)
            where T : struct
        {
            var sw = stopwatch();
            var series = Define(domain, seed); 
            var s0 = series.Snapshot();                     
            var terms = series.Terms().TakeSpan(steps);
            Claim.eq(terms.Length, steps);
            Claim.eq(series.Observed.Observed, terms[steps - 1].Observed);
            var evolved = SeriesEvolution.Define(seed, domain, s0.Observed, series.Observed, snapshot(sw));
            return evolved;            
        }

        public static Task<SeriesEvolution<T>> Evolve<T>(ulong[] seed, Interval<T> domain, int steps)
            where T : struct        
            => Task.Factory.StartNew(() => Execute(seed, domain, steps));    
        
        public static async Task Evolve<T>(Interval<T> domain, Action<SeriesEvolution<T>> receiver, int count = Pow2.T06, int steps = Pow2.T19)
            where T : struct
        {
            var sw = stopwatch();
            var variations = from i in range(count) 
                    let seed = Seed1024.Entropic
                    let evolve = TimeSeries.Evolve(seed, domain, steps)
                    let status = evolve.ContinueWith(t => receiver(t.Result))
                    select evolve;
            
            await task(() => Task.WaitAll(variations.ToArray()));

        }
    }

}