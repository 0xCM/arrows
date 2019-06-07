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
            :base(Z0.Randomizer.define(Seed256.BenchSeed))
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



        void TestBits()
        {
            var bits = RNG.XOrShift1024().Bits().Take(Pow2.T16);
            var on = 0;
            var off = 0;

            foreach(var bit in bits)
            {
                if(bit)
                    ++on;
                else
                    ++off;
            }
            var onPct = ((double)on)/((double)on + (double)off);
            var offPct = ((double)off)/((double)on + (double)off); 
            print($"on = {onPct}, off={offPct}");


        }

        [MethodImpl(Inline)]
        static bool between(byte test, byte min, byte max)
            => test >= min && test < max;

        void TestBytes()
        {
            var bytes = RNG.XOrShift1024().SignedBytes().Take(Pow2.T16);
            var histo = new Dictionary<sbyte,int>();

            for(var i = 0; i<= Byte.MaxValue; i++)
                histo[(sbyte)i] = 0;

            foreach(var b in bytes)
                histo[b] = histo[b] + 1;

            
            foreach(var k in histo.Keys.OrderBy(x => x))
            {
                var count = histo[k];
                var pct = ((((double)count)/((double)Pow2.T16))*100.0).Round(4);
                print($"# {k} = {count} {pct} %");
            }


        }

        void TestUniformity()
        {
            TestBytes();
        }

        void AdHocTest()
        {
            var rng = RNG.XOrShift1024();
            var sampleSize = Pow2.T21;
            var maxVal = 100ul;
            var sw = stopwatch();
            var samples = rng.Integers(maxVal).Take(sampleSize).ToArray();
            print($"Sample Time: {snapshot(sw)}");

            var histo = new Dictionary<ulong,int>();
            for(ulong i = 0; i< maxVal; i++)
                histo[i] = 0;
            
            foreach(var b in  samples)
                histo[b] = histo[b] + 1;

            foreach(var k in histo.Keys.OrderBy(x => x))
            {
                var count = histo[k];
                var pct = ((((double)count)/((double)sampleSize))*100.0).Round(4);
                print($"# {k} = {count} {pct} %");
            }
            

        }

        static void TestPartitions()
        {
            var src2 = closed(5,20);
            var dst2 = src2.Partitions(1);
            var fmt2 = dst2.Map(x => x.ToString()).Concat(" + ");

            var src4 = leftopen(5,20);
            var dst4 = src4.Partitions(1);
            var fmt4 = dst4.Map(x => x.ToString()).Concat(" + ");

            var src1 = leftclosed(5,20);
            var dst1 = src1.Partitions(1);
            var fmt1 = dst1.Map(x => x.ToString()).Concat(" + ");

            var src3 = open(5,20);
            var dst3 = src3.Partitions(1);
            var fmt3 = dst3.Map(x => x.ToString()).Concat(" + ");

        
            print($"{dst2.Length} {src2} = {fmt2}");
            print($"{dst4.Length} {src4} = {fmt4}");
            print($"{dst1.Length} {src1} = {fmt1}");
            print($"{dst3.Length} {src3} = {fmt3}");        
        
        }
        public static void Run()
        {
            
            var app = new TestRunner();
            try
            {
                //TestPartitions();
                TestTools.RunTests(string.Empty, false);

            }
            catch (Exception e)
            {
                app.NotifyError(e);
            }

        }

        static void Main(params string[] args)
                => Run();

    }

}