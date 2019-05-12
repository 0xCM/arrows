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
    using static zfunc;
    

    using static primops;
    using static Divisors;

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
            foreach(var d in Compute(interval,step))
            {
                inform($"{d.Range}, count = {d.Lists.Count()} {sw.ElapsedMilliseconds}ms");
                d.WriteTo(FolderPath.Define(@"C:\temp"));
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
            
            if(underflow.Count() != 0)
                foreach(var i in underflow)
                    babble(i);

            if(overflow.Count() != 0)
                foreach(var i in overflow)
                    babble(i);

            Claim.eq(0, underflow.Count(), AppMsg.Define($"Generation underflow: numbers should be greater than or equal to {domain.left}"));
            Claim.eq(0, overflow.Count(), AppMsg.Define($"Generation overlfow: numbers should be less than {domain.right}"));

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

            var pos = samples.Where(x => x > 0).Count();
            var neg = samples.Where(x => x < 0).Count();
            inform($"(+) = {pos} | (-) = {neg}");                                         
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

        void TestComparison()
        {
            var lhs = Vec128.define(5,10,20,30);
            var rhs = Vec128.define(6,9,20,25);
            var gt = dinx.gt(lhs,rhs);
            inform($"{lhs} > {rhs} = {gt}");
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