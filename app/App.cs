//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
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


        void CheckRandomBounds<T>(Interval<T> domain)
            where T : struct, IEquatable<T>
        {
            var stream = Randomizer.Stream(domain);
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


        static Vec128<double> addDirect(Vec128<double> lhs, Vec128<double> rhs)
        {
            var s1 = dinx.add(lhs,rhs);
            var s2 = dinx.add(s1,rhs);
            var s3 = dinx.add(s1,lhs);
            return dinx.add(s1,s2);
        }




        void HistoTest<T>(Interval<T> domain, T? grain = null)
            where T : struct, IEquatable<T>
        {            
            CheckRandomBounds(domain);

            var width = primops.sub(domain.right, domain.left);
            var data = Randomizer.Array(domain, Pow2.T20);
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
        

        void TestRandomFloat()
        {
            var domain = Interval.leftclosed(-150.0d, 150.0d).canonical();
            CheckRandomBounds(domain);            
            var stream = Randomizer.Stream(domain);
            var samples = stream.Freeze(Pow2.T20);
            
            inform($"Domain = {domain} | Min = {samples.Min()} | Max = {samples.Max()}");

            var pos = samples.Where(x => x > 0).Count;
            var neg = samples.Where(x => x < 0).Count;
            inform($"(+) = {pos} | (-) = {neg}");                       
                  
        }

        void TestBenchmarks()
        {
            var domain = Interval.leftclosed(-150.0d, 150.0d).canonical();
            var stream = Randomizer.Stream(domain).Freeze(Pow2.T20);

            double SumInX()
            {
                return Math.Round(stream.InXSum(),4);
            }

            double SumPrimal()
            {
                var result = 0d;
                for(var i=0; i< stream.Length; i++)
                    result += stream[i];
                return Math.Round(result,4);                
            }

            double SumPrimOpDel()
            {
                var add = PrimalOps.add<double>();
                var result = 0d;
                for(var i=0; i< stream.Length; i++)
                    result = add(result, stream[i]);
                return Math.Round(result,4);                

            }

            double SumPrimOps()
            {
                var result = 0d;
                for(var i=0; i< stream.Length; i++)
                    result = primops.add(result, stream[i]);
                return Math.Round(result,4);                
            }

            Claim.eq(SumInX(), SumPrimal());
            Claim.eq(SumPrimOpDel(), SumPrimal());
            Claim.eq(SumPrimOps(), SumPrimal());

            measure(() => SumPrimOpDel(), "primops-d/sum", 100);
            measure(() => SumPrimOps(), "primops/sum", 100);
            measure(() => SumPrimal(), "primal/sum", 100);
            measure(() => SumInX(), "intrinsics/sum", 100);

        }

        void TestInXSum()
        {
            var domain = Interval.leftclosed(-150.0d, 150.0d).canonical();
            var stream = Randomizer.Stream(domain);
            var src = stream.Freeze(Pow2.T20);
            var expect = Math.Round(src.Sum(),4);
            var result = Math.Round(src.InXSum(),4);
            Claim.eq(expect,result);            
            inform($"sum = {result}");

        }

        void RunBenchmarks()
        {
            var opSets = items(OpSet.All);
            var opKinds = literals<OpKind>();
            var primKinds = literals<PrimalKind>();
            // var specs = BenchSpecs.Choose(opKinds, opSets, primKinds);
            // Benchmarker.Run(specs);
        }

        void RunTests()
        {
            var paths = new[]{""};            
            var pll = false;
            RunTests(paths,pll);

        }



        Duration SumGeneric<T>(int cycles, int reps)
            where T :struct, IEquatable<T>
        {
            var src = num.numbers(Randomizer.Array<T>(reps));
            var t1 = stopwatch();
            var r1 = num<T>.Zero;
            for(var i=0; i< cycles; i++)
                r1 = src.Sum();
            return elapsed(t1);

        }

        Duration SumDirect(PrimalInfo.I32 prim, int cycles, int reps)
        {
            var src = num.numbers(Randomizer.Array<int>(reps));
            var t = stopwatch();
            var r = 0;
            for(var i=0; i< cycles; i++)
                r = src.Sum();
            return elapsed(t);

        }

        [MethodImpl(Inline)]
        Duration transform(PrimalInfo.I32 prim, int cycles,  int[] src, int[] dst)
        {
            var t = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle ++)
            for(var i = 0; i< src.Length; i++)
            {
                var input = src[i];
                dst[i] = input*input - input;
            }        
        
            return elapsed(t);
        }



        void TestGenericAdd<T>()
            where T : struct, IEquatable<T>
        {
            var reps = Pow2.T20;

            var t1 = stopwatch();
            gmath.init();
            elapsed(t1);

            var t2 = stopwatch();
            var lhs1 = Randomizer.Array<T>(reps);
            var rhs1 = Randomizer.Array<T>(reps);
            var lhs2 = Randomizer.Array<T>(reps);
            var rhs2 = Randomizer.Array<T>(reps);
            elapsed(t2);

            var t5 = stopwatch();
            var dst1 = alloc<T>(reps);
            var dst2 = alloc<T>(reps);
            elapsed(t5);

            var t3 = stopwatch();
            gmath.add(Randomizer.Array<T>(reps), Randomizer.Array<T>(reps), dst1);
            elapsed(t3);

            var t4 = stopwatch();
            gmath.add(Randomizer.Array<T>(reps), Randomizer.Array<T>(reps), dst2);
            elapsed(t4);

        }

        void TestComparison()
        {
            var lhs = Vec128.define(5,10,20,30);
            var rhs = Vec128.define(6,9,20,25);
            var gt = dinx.gt(lhs,rhs);
            inform($"{lhs} > {rhs} = {gt}");
        }
        void TestGenericFloat()
        {
            TestGenericAdd<float>();  
        }
        static void Main(string[] args)
        {     
            try
            {
                var app = new App();

                app.TestComparison();
                //app.RunBench();
                //app.TestGInXAdd();
                
            }
            catch(Exception e)
            {
                error(e);
            }


            
        }
    }

}