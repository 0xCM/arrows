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

        static void v128f64()
        {
            var v01 = Vec128.define(new double[]{1.5,2.6});
            var v02 = Vec128.define(new double[]{3,4});
            print($"{v01} + {v02} = {Vec128.add(v01,v02)}");
        }

        static void v128u64()
        {
            var v1 = Vec128.define(10, (ulong)20);
            var v2 = Vec128.define(30,(ulong)40);
            print($"{v1} + {v2} = {Vec128.add(v1,v2)}");

        }
        void V128Intrinsics()
        {
            v128f64();
            v128u64();
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
                        var sum = Vec128.add(v,v);
                        var vAnd = Vec128.and(v, sum);
                        var vOr = Vec128.or(v, sum);
                        
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

        void RunTests()
        {
            TestRunner.RunTests();
        }

        static void Main(string[] args)
        {     
            var app = new App();
            var stop = false;
            app.V128Intrinsics();
            var task = app.V128Stream(() =>{
                return stop;
            });

            Console.ReadLine();
            stop = true;
            task.Wait();


        }
    }

}