//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{        
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Concurrent;
    using static zfunc;
    public class App : TestApp<App>
    {   

        static void EvolveSeries<T>(Interval<T> domain, int count, Action<ITimeSeries,Duration> complete)
            where T : struct
        {
            var sw = stopwatch();
            var series = TimeSeries.Define(domain);
            var terms = series.Terms().TakeSpan(count);
            var time = snapshot(sw);
            Claim.eq(terms.Length, count);
            Claim.eq(series.LastTerm.Observed, terms[count - 1].Observed);
            complete(series,time);
        }

        static Task EvolveSeriesAsync<T>(Interval<T> domain, int count, Action<ITimeSeries,Duration> complete)
            where T : struct
            => Task.Factory.StartNew(() => EvolveSeries(domain, count, complete));

        AppMsg CompleteMsg(ITimeSeries series, Duration runtime)
            => AppMsg.Define($"Series Id = {series.Id} | Last Term = {series.LastTerm} | Evolution Time = {runtime.FractionalMs} ms", SeverityLevel.Info);
        
        void EmitCompletion(ITimeSeries series, Duration runtime)
            => print(CompleteMsg(series,runtime));

        void RunPll()
        {
            var domain = closed(-250.75, 256.5);
            var series = Pow2.T06;
            var terms = Pow2.T19;            
            var sw = stopwatch();
            var variations = from i in range(series) 
                    select EvolveSeriesAsync(domain,terms, EmitCompletion);
            Task.WaitAll(variations.ToArray());
            print($"Computed {series} time series, each with {terms} terms, in {snapshot(sw).FractionalMs} ms");

        }

        void TestSeries()
        {
            var terms = Pow2.T19;
            var sw = stopwatch();
            var series = 5;
            EvolveSeries(closed((sbyte)-50, (sbyte)50), terms, EmitCompletion);
            EvolveSeries(closed((byte)50, (byte)200), terms, EmitCompletion);
            EvolveSeries(closed((short)-5000, (short)5000), terms, EmitCompletion);
            EvolveSeries(closed(-2892839898392L, 2892839898392L), terms, EmitCompletion);
            EvolveSeries(closed(0ul, 2892839898392ul), terms, EmitCompletion);
            print($"Computed {series} time series, each with {terms} terms, in {snapshot(sw).FractionalMs} ms");

        }

        
        public static void Main(params string[] args)
            => Run(args);
    }
}