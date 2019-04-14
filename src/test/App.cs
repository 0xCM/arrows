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
                print($"{d.Range}, count = {d.Lists.Count()} {sw.ElapsedMilliseconds}ms");
                NumberFile.save(d, FolderPath.Define(@"C:\temp"));
                sw.Restart();
            }

        }

        static void V64Intrinsics()
        {
            var vec = Vec64.define(0, 1,2,3,4,5,6,7);
            print(vec.ToString());
            
        }

        Task V128Stream(Func<bool> stop, uint batchSize = Pow2.T18, int delay = 0, bool diagnostic = false)
        {   
            void worker()
            {
                var counter = 1;
                while(!stop())
                {
                    var batch = Random<long>().stream(Defaults.Int64Min, Defaults.Int64Max).Freeze(batchSize);
                    foreach(var v in Vec128.stream<long>(batch))
                    {
                        var sum = InX.add(v,v);
                        var vAnd = InX.and(v, sum);
                        var vOr = InX.or(v, sum);
                        
                        if(diagnostic)
                            print($"{v} + {v} = {sum}");
                    }

                    if(diagnostic)
                        inform($"Completed batch {counter++}");
                    else
                        write(".");

                    if(delay != 0)
                        Task.Delay(delay).Wait();
                }}
            ;
            
            return Task.Factory.StartNew(worker);                
        }

        void RunTests(string filter)
        {
            TestRunner.RunTests(filter);
        }

        void RunStream()
        {
           var stop = false;
 
            var task = V128Stream(() =>{
                return stop;
            });

            Console.ReadLine();
            stop = true;
            task.Wait();

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
                print($"{key}: {histo[key]}");

        }
        static void Main(string[] args)
        {     
            var app = new App();
            app.RunTests(Paths.InX);
            //app.Random();

        }
    }

}