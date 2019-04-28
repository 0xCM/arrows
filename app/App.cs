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

        static readonly PrimalIndex AddDelegates = PrimKinds.index<object>
            (
                @sbyte : new Vec128BinOp<sbyte>(InX.add),
                @byte : new Vec128BinOp<byte>(InX.add),
                @short : new Vec128BinOp<short>(InX.add),
                @ushort : new Vec128BinOp<ushort>(InX.add),
                @int : new Vec128BinOp<int>(InX.add),
                @uint : new Vec128BinOp<uint>(InX.add),
                @long : new Vec128BinOp<long>(InX.add),
                @ulong : new Vec128BinOp<ulong>(InX.add),
                @float : new Vec128BinOp<float>(InX.add),
                @double : new Vec128BinOp<double>(InX.add)
            );

        static Vec128<T> addGeneric<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var adder = AddDelegates.lookup<T,Vec128BinOp<T>>();
            var s1 = adder(lhs,rhs);
            var s2 = adder(s1,rhs);
            var s3 = adder(s1,lhs);
            return adder(s1,s2);
        }


        static Vec128<double> addDelegate(Vec128<double> lhs, Vec128<double> rhs)
        {
            var adder = AddDelegates.lookup<double,Vec128BinOp<double>>();
            var s1 = adder(lhs,rhs);
            var s2 = adder(s1,rhs);
            var s3 = adder(s1,lhs);
            return adder(s1,s2);
        }

        static Vec128<double> addDirect(Vec128<double> lhs, Vec128<double> rhs)
        {
            var s1 = InX.add(lhs,rhs);
            var s2 = InX.add(s1,rhs);
            var s3 = InX.add(s1,lhs);
            return InX.add(s1,s2);
        }


        void TestAdd()
        {
            var config = BenchConfig.Default;
            var domain = Defaults.Float64Domain;
            var lhs = RandomIndex<double>(domain, config.SampleSize);
            var rhs = RandomIndex<double>(domain, config.SampleSize);
            var veclen = Vec128<double>.Length;
            var sw = stopwatch();
            
            sw.Restart();
            for(var j = 0; j<config.Reps; j++)
                for(var k = 0; k < lhs.Length; k+= veclen)
                    addDelegate(Vec128.load(lhs[k],k), Vec128.load(rhs[k],k));            
            inform($"Delegate: {ticksToMs(elapsed(sw))}ms");
            
            sw.Restart();
            for(var j = 0; j<config.Reps; j++)
                for(var k = 0; k < lhs.Length; k+= veclen)
                    addGeneric(Vec128.load(lhs[k],k), Vec128.load(rhs[k],k));            
            inform($"Generic: {ticksToMs(elapsed(sw))}ms");
            
            sw.Restart();
            for(var j = 0; j<config.Reps; j++)
                for(var k = 0; k < lhs.Length; k+= veclen)
                    addDirect(Vec128.load(lhs[k],k), Vec128.load(rhs[k],k));            
            inform($"Direct: {ticksToMs(elapsed(sw))}ms");

        }
        void TestAdd54()
        {
            var config = BenchConfig.Default;
            var domain = Defaults.Float64Domain;
            var lhs = Vec128.stream(RandomIndex<double>(domain, config.SampleSize)).ToList();
            var rhs = Vec128.stream(RandomIndex<double>(domain, config.SampleSize)).ToList();
            var veclen = Vec128<double>.Length;
            var sw = stopwatch();
            var generic = 0L;
            var direct = 0L;
            var del = 0L;

            var f = InX.addg<double>();

            for(var j = 0; j<10; j++)
            {
                sw.Restart();
                for(var i = 0; i< 10; i++)
                    for(var k = 0; k < lhs.Count; k++)
                        InX.addg(lhs[k],rhs[k]);
                    
                generic += elapsed(sw);
                inform($"Generic: {ticksToMs(elapsed(sw))}ms");

                sw.Restart();
                for(var i = 0; i< 10; i++)
                    for(var k = 0; k < lhs.Count; k++)
                        InX.add(lhs[k],rhs[k]);
                direct += elapsed(sw);
                inform($"Direct: {ticksToMs(elapsed(sw))}ms");

                sw.Restart();
                for(var i = 0; i< 10; i++)
                    for(var k = 0; k < lhs.Count; k++)
                        f(lhs[k],rhs[k]);
                del += elapsed(sw);
                inform($"Delegate: {ticksToMs(elapsed(sw))}ms");

            }


            inform($"Generic Total = {ticksToMs(generic)}ms");
            inform($"Direct Total = {ticksToMs(direct)}ms");
            inform($"Delegate Total = {ticksToMs(del)}ms");

        }


        void TestAdd50()
        {
            var config = BenchConfig.Default;
            var domain = Defaults.Float64Domain;
            var lhs = RandomIndex<double>(domain, config.SampleSize);
            var rhs = RandomIndex<double>(domain, config.SampleSize);
            var veclen = Vec128<double>.Length;
            var sw = stopwatch();
            var generic = 0L;            
            var direct = 0L;
            for(var j = 0; j<10; j++)
            {
                sw.Restart();
                for(var i = 0; i< 10; i++)
                    InX.addg(lhs,rhs);
                generic += elapsed(sw);
                inform($"Generic: {ticksToMs(elapsed(sw))}ms");

                sw.Restart();
                for(var i = 0; i< 10; i++)
                    InX.add(lhs,rhs);
                direct += elapsed(sw);
                inform($"Direct: {ticksToMs(elapsed(sw))}ms");

            }


            inform($"Generic Total = {ticksToMs(generic)}ms");
            inform($"Direct Total = {ticksToMs(direct)}ms");

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

        void TestBenchmarks()
        {
            var domain = Interval.leftclosed(-150.0d, 150.0d).canonical();
            var stream = RandomStream(domain).Freeze(Pow2.T20);

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
            var stream = RandomStream(domain);
            var src = stream.Freeze(Pow2.T20);
            var expect = Math.Round(src.Sum(),4);
            var result = Math.Round(src.InXSum(),4);
            Claim.eq(expect,result);            
            inform($"sum = {result}");

        }

        void RunBenchmarks()
        {
            //var opKinds = items(OpKind.Add, OpKind.Sub);
            var opSets = items(OpSet.All);
            //var primKinds = items(PrimKind.int16, PrimKind.int32, PrimKind.float32, PrimKind.float64);
            var opKinds = literals<OpKind>();
            var primKinds = literals<PrimKind>();
            var specs = BenchSpecs.Choose(opKinds, opSets, primKinds);
            Benchmarker.Run(specs);
        }

        void RunTests()
        {
            var paths = new[]{""};            
            var pll = false;
            RunTests(paths,pll);

        }

        static void Main(string[] args)
        {     
            try
            {
                var app = new App();
                //app.RunBenchmarks();
                //app.RunTests();
                //app.TestAdd54();
                DynInvoke.Test();
                
            }
            catch(Exception e)
            {
                error(e);
            }


            
        }
    }

}