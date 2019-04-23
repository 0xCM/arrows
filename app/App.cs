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
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

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

        void CheckRandomBounds<T>(Interval<T> domain)
            where T : struct, IEquatable<T>
        {
            var stream = RandomStream(domain);
            var samples = stream.Freeze(Pow2.T20);
            var underflow = samples.Where(x => primops.lt(x,domain.left) );
            var overflow = samples.Where(x => primops.gteq(x, domain.right));
            
            if(underflow.Count != 0)
                foreach(var i in underflow)
                    babble(i);

            if(overflow.Count != 0)
                foreach(var i in overflow)
                    babble(i);

            Claim.eq(0, underflow.Count, $"Generation underflow: numbers should be greater than or equal to {domain.left}");
            Claim.eq(0, overflow.Count, $"Generation overlfow: numbers should be less than {domain.right}");

        }


        void HistoTest<T>(Interval<T> domain, T? grain = null)
            where T : struct, IEquatable<T>
        {            
            CheckRandomBounds(domain);

            var width = primops.sub(domain.right, domain.left);
            var data = RandomIndex(domain, Pow2.T20);
            var histo = new Histogram<T>(domain, grain ?? (primops.div(width,convert<T>(100))));
            histo.Deposit(data);  

            var buckets = histo.Buckets().Freeze();
            var total = (int)buckets.TotalCount();

            inform($"Histogram domain: {histo.Domain}");
            inform($"Histogram grain: {histo.Grain}");
            inform($"Histogram bucket count: {buckets.Count}");            
            inform($"Total number of samples: {data.Length}");
            inform($"Sum of bucket counts: {total}");
            Claim.eq(total, data.Length);

        }

        void DiscretizeTestT<T>(Interval<T> domain, T step)
            where T : struct, IEquatable<T>
        {
            var discretized = domain.Discretize(step);
            inform($"Discretized the interval {domain}");
            for(var i=0; i< discretized.Length; i++)
                inform($"Index {i} = {discretized[i]}");
        }


        void RandomTests()
        {
            HistoTest(Interval.closed(-(short)25021,1538).canonical());
            HistoTest(Interval.closed((ushort)2000, 25000).canonical());
            HistoTest(Interval.closed(-250000,250000).canonical());
            HistoTest(Interval.closed(7500u,250000u).canonical());
            HistoTest(Interval.closed(-300000L,250000L).canonical());
            HistoTest(Interval.closed(250000ul,500000ul).canonical());
            //DiscretizeTestT(Interval.closed<short>(-5000,5000).canonical(),(short)250);        
        }

        void RunTests(string[] paths, bool pll)
        {
            iter(paths, path => TestRunner.RunTests(path,pll));
        }

        void MeasureDelegates()
        {
            new DelegateBaselines().Run();
        }


        void RunBenchmarks()
        {
            var sw = stopwatch();
            var primal = 0L;
            var intrinsic = 0L;
            iter(BaselineBench.PrimalAddRunners(), runner => primal += runner.Run());
            iter(BaselineBench.InXAddRunners(), runner =>  intrinsic += runner.Run());

            inform($"Total Runtime          = {sw.ElapsedMilliseconds}ms");
            inform($"Total Benchtime        = {primal + intrinsic}ms");
            inform($"Primal Benchmark       = {primal}ms");
            inform($"Intrinsics Benchmark   = {intrinsic}ms");            
        }

        void TestRandomFloat()
        {
            var domain = Interval.leftclosed(-150.0d, 150.0d).canonical();
            CheckRandomBounds(domain);            
            var stream = RandomStream(domain);
            var samples = stream.Freeze(Pow2.T20);
            
            inform($"Domain = {domain} | Min = {samples.Min()} | Max = {samples.Max()}");

            var pos = samples.Where(x => x > 0).Count;
            var neg = samples.Where(x => x < 0).Count;
            inform($"(+) = {pos} | (-) = {neg}");

                       
          
        }

        void TestInXAdd()
        {
            var domain = Interval.leftclosed(-150.0d, 150.0d).canonical();
            var stream = RandomStream(domain);
            var lhs = stream.Freeze(Pow2.T20);
            var rhs = stream.Freeze(Pow2.T20);
            var sum1 = lhs.InXAdd(rhs);
            var sum2 = lhs.Add(rhs);
            Claim.eq(sum1,sum2);




        }


        void RunTests()
        {
            var paths = new[]{""};            
            var pll = true;
            RunTests(paths,pll);

        }
        static void Main(string[] args)
        {     
            try
            {
                var app = new App();
                // app.RunTests();
                app.RunBenchmarks();
                

            }
            catch(Exception e)
            {
                error(e);
            }


            
        }
    }

}