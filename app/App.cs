namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Testing;
    using Tests;
    using System.IO;
    using System.Runtime.CompilerServices;

    using Z0.Bench;

    using static zcore;
    using static primops;
    using static algorithms;


    public sealed class ZTest : ZTest<ZTest>
    {
        
    }

    public class App : Context<App>
    {

        public App()
         : base(RandSeeds.AppSeed)
         {

         }
        static void SaveDivisors()
        {
            var sw = stopwatch();
            var step = 50000UL;
            var interval = Interval.closed(0UL,UInt32.MaxValue - step);
            foreach(var d in divisors(interval,step))
            {
                inform($"{d.Range}, count = {d.Lists.Count()} {sw.ElapsedMilliseconds}ms");
                NumberFile.save(d, FolderPath.Define(@"C:\temp"));
                sw.Restart();
            }

        }

        static void V64Intrinsics()
        {
            var vec = Vec64.define(0, 1,2,3,4,5,6,7);
            inform(vec.ToString());
            
        }


        void Random()
        {
            var random = Randomizer.define(RandSeeds.TestSeed);
            var stream = random.stream(10u,30u);
            var data = stream.Freeze(Pow2.T20);
            var histo = new Dictionary<uint, uint>();
            foreach(var datum in data)
            {
                if(histo.ContainsKey(datum))
                    histo[datum] = histo[datum] + 1u;
                else
                    histo[datum] = 1u;
            }

            foreach(var key in histo.Keys.OrderBy(x => x))
                inform($"{key}: {histo[key]}");

        }
        void RunTests(string[] paths, bool pll)
        {
            iter(paths, path => TestRunner.RunTests(path,pll));
        }

        void MeasureDelegates()
        {
            new DelegateBench().Run();
        }

        long Benchmark()
        {
            var runner = AddBaseline.Runner();
            
            var duration = runner.Run<long>();            
            duration += Benchmarks.Run<long>();
            
            return duration;
        }

        static void Main(string[] args)
        {     
            var app = new App();

            //app.MeasureDelegates();
            app.Benchmark();

            // var paths = new[]{Paths.perf,};            
            // var pll = true;
            // app.RunTests(paths,pll);

            
        }
    }

}