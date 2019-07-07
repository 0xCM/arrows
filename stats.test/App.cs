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
            => AppMsg.Define($"Series Id = {series.Id} | Last Term = {series.Observed} | Evolution Time = {runtime.FractionalMs} ms", SeverityLevel.Info);

        static void EmitCompletion<T>(ITimeSeries<T> series, Duration runtime)
            where T : struct
                => print(CompleteMsg(series,runtime));

        static void Show<T>(SeriesEvolution<T> evolution)
            where T : struct
                => print($"{evolution.FirstTerm} -> {evolution.FinalTerm}: {evolution.Time}");

        protected override void RunTests(string filter)
        {
            TimeSeries.Evolve(closed(-250.75, 256.5),Show).Wait();
        }
        
        public static void Main(params string[] args)
            => Run(args);
    }
}