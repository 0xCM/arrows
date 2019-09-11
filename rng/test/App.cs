//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rng
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;

    using System.Numerics;

    using static zfunc;
    public class App : TestApp<App>
    {

        static AppMsg CompleteMsg<T>(ITimeSeries<T> series, Duration runtime)
            where T : struct
            => AppMsg.Define($"Series Id = {series.Id} | Last Term = {series.Observed} | Evolution Time = {runtime.Ms} ms", SeverityLevel.Info);

        static void EmitCompletion<T>(ITimeSeries<T> series, Duration runtime)
            where T : struct
                => print(CompleteMsg(series, runtime));

        static void Show<T>(SeriesEvolution<T> evolution)
            where T : struct
                => print($"{evolution.FirstTerm} -> {evolution.FinalTerm}: {evolution.Time}");

        void EvolveSeries()
        {
            TimeSeries.Evolve(closed(-250.75, 256.5), Show).Wait();
        }
    
        Task<MemorySpan<uint>> Collect(uint[] state, ulong width, int points)
        {
            return Task.Factory.StartNew(() =>
            {
                var dst = MemorySpan.Alloc<uint>(points);

                var src = RNG.XOr128(state);
                var subseq = src.SubSeq(Pow2.T14, width, points);
                var total = BigInteger.Zero;
                            
                for(var i=0; i< points; i++)
                {            
                    (var idx, var value) = subseq[i];  
                    total += idx;                    

                    print(appMsg($"src[{i.ToString().PadLeft(3,'0')}:{total.ToString().PadLeft(12,'0')}] = {value.FormatHex()}"));
                }

                return dst;

            });
        }

        void CollectSubSeq()
        {
            var state = new uint[]
            {
                (uint)Seed64.Seed00, (uint)Seed64.Seed00 >> 32,
                (uint)Seed64.Seed01, (uint)Seed64.Seed01 >> 32
            };
            const ulong width = Pow2.T31;
            const int points = 4;

            var result = Collect(state, width, points).Result;

        }

        void TestMrg32k3a()
        {
            var sw = stopwatch();
            var rng = new MRG32k3a();
            var min = long.MaxValue;
            var max = long.MinValue;
            var cycles = Pow2.T08;
            var samples = Pow2.T22;
            for(var cycle = 0; cycle < cycles; cycle++)
            {
                for(var i=0; i<samples; i++)
                {   
                    var next = rng.Next();
                    if(next < min)
                        min = next;
                    if(next > max)
                        max = next;
                }
                print('.');
                if(cycle != 0 && cycle % 80 == 0)
                    print();

            }
            print();
            
            OpTime time = (cycles*samples, sw, "MRG32k3a");
            print(time);

        }

        protected override void RunTests(params string[] filters)
        {     
            TestMrg32k3a();
            
            //base.RunTests(filters);        
        }
        public static void Main(params string[] args)
            => Run(args);

                    
    }
}