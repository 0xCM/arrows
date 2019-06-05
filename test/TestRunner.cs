//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using Z0.Test;
    
    using static zfunc;    
    using static math;
    using static ansi;

    public class TestRunner : Context
    {

        public TestRunner()
            :base(Z0.Randomizer.define(RandSeeds.BenchSeed))
        {
            
        }
       
         // Converts an array of bytes into a long.  
        static long ToInt64(byte[] value, int startIndex)
        {

            return Unsafe.ReadUnaligned<long>(ref value[startIndex]);
        }


        void Bernouli(double alpha, int count)
        {
            var sw = stopwatch(false);
            sw.Start();
            var samples = Distributions.Bernoulli<long>(alpha, Randomizer).Sample().Take(count);
            var avg = samples.Average();
            sw.Stop();
            print($"Samples = {count} | Alpha = {alpha.Round(4)} | Average = {avg.Round(4)} | Time = {snapshot(sw).Ms} ms");

        }

        void RunBernouli()
        {
            var alpha = 0.0;
            var factor = 0.10;
            while( (alpha += factor) <= 1.0)
            {
                Bernouli(alpha, Pow2.T18);
            }

        }

        void AdHocTest()
        {
            PCG.Demo1();
            PCG.Demo2();
            PCG.Demo3();

        }

        public static void Run()
        {
            
            var app = new TestRunner();
            app.AdHocTest();
            // try
            // {
            //     TestTools.RunTests(string.Empty, false);

            // }
            // catch (Exception e)
            // {
            //     app.NotifyError(e);
            // }

        }

        static void Main(params string[] args)
                => Run();

    }

}