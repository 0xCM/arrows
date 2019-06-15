//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    
    public class RandomTest : UnitTest<RandomTest>
    {

        public void I8DomainSatisifed()
        {
            var samples = Pow2.T11;
            var domain = closed((sbyte)(-100),(sbyte)(100));
            var data = Randomizer.Stream<sbyte>(domain).Take(samples);
            var h = Histogram.Define(domain,10);
            h.Deposit(data,false);
        }

        public void U32DomainSatisifed()
        {
            var samples = Pow2.T11;
            var domain = closed(1u,1000u);
            var data = Randomizer.Stream<uint>(domain).Take(samples);
            var h = Histogram.Define(domain);
            h.Deposit(data,false);
        }


        public void U64DomainSatisfied()
        {
            var samples = Pow2.T11;
            var domain = closed(1ul,1000ul);
            var data = Randomizer.Stream<ulong>(domain).Take(samples);
            var h = Histogram.Define(domain);
            h.Deposit(data,false);
        }

        public void I64DomainSatisfied()
        {
            var samples = Pow2.T11;
            var domain = closed(-250L,250L);
            var data = Randomizer.Stream<long>(domain).Take(samples);
            var h = Histogram.Define(domain);
            h.Deposit(data,false);
        
        }

        public void SystemRandomTest()
        {
            var samples = Pow2.T11;
            var domain = closed(10,20);
            var random = Randomizer.SystemRandom();
            var dst = span<int>(samples);
            for(var i=0; i<samples; i++)            
            {
                var next = random.Next(domain.Left, domain.Right);
                Claim.@true(next >= domain.Left && next < domain.Right);
                dst[i] = random.Next(domain.Left, domain.Right);
            }
            var h = Histogram.Define(domain);
            h.Deposit(dst);        
        }
    
        public IEnumerable<Bin<T>> DefineBins<T>(Interval<T> domain, int count)        
            where T : struct
        {
            var partition = domain.Partition(count);
            var bins = array<Bin<T>>(count);
            for(var i=0; i<count; i++)
                bins[i] = new Bin<T>(partition[i]);
            return bins;        
        }

        static void Count<T>(IEnumerable<Bin<T>> bins, T point)
            where T : struct
        {
            foreach(var bin in bins)
                if(bin.Domain.Contains(point))
                {
                    bin.Increment();
                    break;
                }
        }

        static void Distribute<T>(IEnumerable<T> values, IEnumerable<Bin<T>> dst, bool pll = true)        
            where T : struct
        {
            if(pll)
                values.AsParallel().ForAll(v => Count(dst, v));                
            else
                values.ForEach(v => Count(dst, v));

        }

        void TestUniformRange<T>(Interval<T> domain, int count)
            where T : struct
        {            
            var sw = stopwatch();
            var samples = Randomizer.UniformStream(domain).TakeArray(count);
            var time = snapshot(sw);
            
            var avg = gmath.avg<T>(samples);
            var min = gmath.min<T>(samples);
            var max = gmath.max<T>(samples);

            inform($"{typeof(T).Name} {domain}: min = {min} | max = {max} | avg = {avg}, time = {time.Ms} ms");

            Claim.@true(gmath.gteq(min, domain.Left));

            Claim.@true(gmath.lt(min, domain.Right));
        }

        void TestUniformUnbounded<T>(int count)
            where T : struct
        {
            var sw = stopwatch();
            var samples = Randomizer.UniformStream<T>().TakeArray(count);
            var time = snapshot(sw);

            var min = gmath.min<T>(samples);
            var max = gmath.max<T>(samples);
            var avg = gmath.avg<T>(samples);
            inform($"{typeof(T).Name}: min = {min} | max = {max} | avg = {avg}, time = {time.Ms} ms");
        }

        public void TestUniformRange()
        {
            var count = Pow2.T16;
            TestUniformRange(leftclosed<sbyte>(-50, 50), count);
            TestUniformRange(leftclosed<byte>(50, 200), count);
            TestUniformRange(leftclosed<double>(-250, 750), count);
            TestUniformRange(leftclosed<double>(-500, 500), count);


            var domain = leftclosed<double>(-1000, 2000);
            var samples = Randomizer.UniformStream(domain).Take(Pow2.T17).ToArray();
            var bins = DefineBins(domain, 25);
            var sw = stopwatch();
            Distribute(samples, bins);
            print($"{samples.Length} samples categorized in {snapshot(sw).Ms} ms");
            bins.ForEach(bin => print($"{bin}"));
        
        }

        public void TestUniform()
        {
            var count = Pow2.T22;
            TestUniformUnbounded<byte>(count);
            TestUniformUnbounded<sbyte>(count);
            TestUniformUnbounded<ushort>(count);
            TestUniformUnbounded<short>(count);
            TestUniformUnbounded<int>(count);
            TestUniformUnbounded<uint>(count);
            // var domain = leftclosed(-(Int32.MaxValue >> 1),Int32.MaxValue >> 1);
            // TestUniformRange<int>(domain,count);
            // TestUniformRange<int>(domain,count);
            // TestUniformRange<int>(domain,count);
        }
    

        static long ToInt64(byte[] value, int startIndex)
        {

            return Unsafe.ReadUnaligned<long>(ref value[startIndex]);
        }


        void Bernouli(double alpha, int count)
        {
            var sw = stopwatch(false);
            sw.Start();
            var samples = BernoulliSpec.Define(alpha).Distribution<long>().Sample(Randomizer).Take(count);
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
            var bytes = RNG.XOrShift1024().SBytes().Take(Pow2.T16);
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


    }


}