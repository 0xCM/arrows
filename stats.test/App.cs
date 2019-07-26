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
        static AppMsg CompleteMsg<T>(ITimeSeries<T> series, Duration runtime)
            where T : struct
            => AppMsg.Define($"Series Id = {series.Id} | Last Term = {series.Observed} | Evolution Time = {runtime.Ms} ms", SeverityLevel.Info);

        static void EmitCompletion<T>(ITimeSeries<T> series, Duration runtime)
            where T : struct
                => print(CompleteMsg(series,runtime));

        static void Show<T>(SeriesEvolution<T> evolution)
            where T : struct
                => print($"{evolution.FirstTerm} -> {evolution.FinalTerm}: {evolution.Time}");

        void EvolveSeries()
        {
            TimeSeries.Evolve(closed(-250.75, 256.5),Show).Wait();            
        }
        
        protected override void RunTests(params string[] filter)
        {
            var samples = Random.BernoulliStream(.2).Take(Pow2.T20).Freeze();
            var success = (double)samples.Where(x => x).Count();
            var result = success / (double) Pow2.T20;
            print(result.ToString());
        }
        
        public static void Main(params string[] args)
            => Run(args);
    }
}