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
            var data = Random.Stream<sbyte>(domain).Take(samples);
            var h = Histogram.Define(domain,10);
            h.Deposit(data,false);
        }

        public void U32DomainSatisifed()
        {
            var samples = Pow2.T11;
            var domain = closed(1u,1000u);
            var data = Random.Stream<uint>(domain).Take(samples);
            var h = Histogram.Define(domain);
            h.Deposit(data,false);
        }


        public void U64DomainSatisfied()
        {
            var samples = Pow2.T11;
            var domain = closed(1ul,1000ul);
            var data = Random.Stream<ulong>(domain).Take(samples);
            var h = Histogram.Define(domain);
            h.Deposit(data,false);
        }

        public void I64DomainSatisfied()
        {
            var samples = Pow2.T11;
            var domain = closed(-250L,250L);
            var data = Random.Stream<long>(domain).Take(samples);
            var h = Histogram.Define(domain);
            h.Deposit(data,false);
        
        }

        public void MultiRandInt32()
        {
            var mr = RNG.Polyrand(Random); 
            var data = mr.Take<int>(Pow2.T23);
            int pos = 0, neg = 0, zed = 0;
            foreach(var x in data)
                if(x > 0)       pos++;
                else if(x < 0)  neg++;
                else            zed++;
            var r = math.abs(pos - neg)/((double)pos + (double)neg);
            var tolerance = .01;
            Claim.lt(r, tolerance);

                       
        }

        public void MultiRandInt64()
        {
            var mr = RNG.Polyrand(Random); 
            var data = mr.Take<long>(Pow2.T12);
            int pos = 0, neg = 0, zed = 0;
            foreach(var x in data)
                if(x > 0)       pos++;
                else if(x < 0)  neg++;
                else            zed++;
            var r = math.abs(pos - neg)/((double)pos + (double)neg);
            var tolerance = .01;
            Claim.lt(r, tolerance);

                       
        }


        public void TestWyHash64()
        {
            var rng = RNG.WyHash64();
            var data = rng.Take(Pow2.T20);
            var cutpoint = (double)UInt64.MaxValue/2.0;

            var above = 0;
            var below = 0;
            foreach(var x in data)
                if(x>= cutpoint)
                    above++;
                else if(x < cutpoint)
                    below++;
            
            var r = (math.abs(above - below)/((double)(above + below))).Round(4);
            var tolerance = .01;
            Claim.lt(r, tolerance);                    
        }

        public void SystemRandomTest()
        {
            var samples = Pow2.T11;
            var domain = closed(10,20);
            var random = SysRand.FromSource(Random);
            var dst = span<int>(samples);
            for(var i=0; i<samples; i++)            
            {
                var next = random.Next(domain.Left, domain.Right);
                Claim.yea(next >= domain.Left && next < domain.Right);
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

        void UniformRange<T>(Interval<T> domain, int count)
            where T : struct
        {            
            TypeCaseStart<T>();
            var sw = stopwatch();
            var samples = Random.Stream(domain).TakeArray(count);
            var time = snapshot(sw);
            
            var avg = gmath.avg<T>(samples);
            var min = gmath.min<T>(samples);
            var max = gmath.max<T>(samples);

            Claim.yea(gmath.between(max, domain.Left, domain.Right));
            Claim.yea(gmath.between(min, domain.Left, domain.Right));

            TypeCaseEnd<T>();
            //TypeCaseEnd<T>(appMsg($"{domain}: min = {min} | max = {max} | avg = {avg}, time = {time}"));
        }

        void UniformBounded<T>(int count)
            where T : struct
        {
            TypeCaseStart<T>();
            var sw = stopwatch();
            var samples = Random.Stream<T>().TakeArray(count);
            var time = snapshot(sw);
            var min = gmath.min<T>(samples);
            var max = gmath.max<T>(samples);
            var avg = gmath.avg<T>(samples);
            TypeCaseEnd<T>();
            //TypeCaseEnd<T>(appMsg($"min = {min} | max = {max} | avg = {avg}, time = {time}"));
        }

        public void TestUniformRange()
        {
            var count = Pow2.T16;
            UniformRange(leftclosed<sbyte>(-50, 50), count);
            UniformRange(leftclosed<byte>(50, 200), count);
            UniformRange(leftclosed<double>(-250, 750), count);
            UniformRange(leftclosed<double>(-500, 500), count);        
        }

        public void TestUniform()
        {
            var count = Pow2.T16;
            UniformBounded<byte>(count);
            UniformBounded<sbyte>(count);
            UniformBounded<ushort>(count);
            UniformBounded<short>(count);
            UniformBounded<int>(count);
            UniformBounded<uint>(count);
        }

        static long ToInt64(byte[] value, int startIndex)
        {

            return Unsafe.ReadUnaligned<long>(ref value[startIndex]);
        }

        void Bernouli(double alpha, int count)
        {
            var sw = stopwatch(false);
            sw.Start();
            var samples = BernoulliSpec.Define(alpha).Distribution<long>(Random).Sample().Take(count);
            var avg = samples.Average();
            sw.Stop();
            //print($"Samples = {count} | Alpha = {alpha.Round(4)} | Average = {avg.Round(4)} | Time = {snapshot(sw).Ms} ms");

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

        void Sample512<T>(Interval<T> domain, int count)
            where T : struct
        {
            TypeCaseStart<T>();
            for(var i=0; i<count; i++)
            {
                var xSample = Random.m512i(domain);
                for(var partIx=0; partIx < __m512i.PartCount<T>(); partIx++)
                {
                    var xPart = xSample.Part<T>(partIx);
                    Claim.yea(domain.Contains(xPart));
                }

            }
            TypeCaseEnd<T>();
             
        }

        public void SampleM512()
        {
            var count = Pow2.T10;
            Sample512(closed((byte)10, (byte)50), count);
            Sample512(closed((sbyte)-50, (sbyte)50), count);
            Sample512(closed(-250000, 250000), count);
            Sample512(closed(-250000d, 250000d), count);

        }
    }
}