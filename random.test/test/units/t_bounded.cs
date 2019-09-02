//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rng
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    
    public class t_bounded : UnitTest<t_bounded>
    {
        public void bound8i()
        {
            var samples = Pow2.T11;
            var domain = closed((sbyte)(-100),(sbyte)(100));
            var data = Polyrand.Stream<sbyte>(domain).Take(samples);
            var h = Histogram.Define(domain,10);
            h.Deposit(data,false);
        }

        public void bound32u()
        {
            var samples = Pow2.T11;
            var domain = closed(1u,1000u);
            var data = Polyrand.Stream<uint>(domain).Take(samples);
            var h = Histogram.Define(domain);
            h.Deposit(data,false);
        }


        public void bound64u()
        {
            var samples = Pow2.T11;
            var domain = closed(1ul,1000ul);
            var data = Polyrand.Stream<ulong>(domain).Take(samples);
            var h = Histogram.Define(domain);
            h.Deposit(data,false);
        }

        public void bound64i()
        {
            var samples = Pow2.T11;
            var domain = closed(-250L,250L);
            var data = Polyrand.Stream<long>(domain).Take(samples);
            var h = Histogram.Define(domain);
            h.Deposit(data,false);        
        }


        public void MultiRandInt32()
        {
            var mr = RNG.SplitMix64().ToRandSource();                        
            var data = mr.Span<int>(Pow2.T23);
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
            var mr = RNG.WyHash64().ToPolyrand();
            var data = mr.Take<long>(Pow2.T15);
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

        public void sysrand()
        {
            var samples = Pow2.T11;
            var domain = closed(10,20);
            var random = Random.ToSysRand();
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
    
        IEnumerable<Bin<T>> DefineBins<T>(Interval<T> domain, int count)        
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
                values.Effects(v => Count(dst, v));
        }

        void UniformRange<T>(Interval<T> domain, int count)
            where T : struct
        {            
            TypeCaseStart<T>();
            var sw = stopwatch();
            var samples = Polyrand.Stream(domain).TakeArray(count);
            var time = snapshot(sw);
            
            var avg = gmath.avg<T>(samples);
            var min = gmath.min<T>(samples);
            var max = gmath.max<T>(samples);

            Claim.yea(gmath.between(max, domain.Left, domain.Right));
            Claim.yea(gmath.between(min, domain.Left, domain.Right));

            TypeCaseEnd<T>();
        }

        void UniformBounded<T>(int count)
            where T : struct
        {
            TypeCaseStart<T>();
            var sw = stopwatch();
            var samples = Polyrand.Stream<T>().TakeArray(count);
            var time = snapshot(sw);
            var min = gmath.min<T>(samples);
            var max = gmath.max<T>(samples);
            var avg = gmath.avg<T>(samples);
            TypeCaseEnd<T>();
        }

        public void TestUniformRange()
        {
            var count = Pow2.T16;
            UniformRange(leftclosed<sbyte>(-50, 50), count);
            UniformRange(leftclosed<byte>(50, 200), count);
            UniformRange(leftclosed<double>(-250, 750), count);
            UniformRange(leftclosed<double>(-500, 500), count);        
        }

        void TestUniform()
        {
            var count = Pow2.T16;
            UniformBounded<byte>(count);
            UniformBounded<sbyte>(count);
            UniformBounded<ushort>(count);
            UniformBounded<short>(count);
            UniformBounded<int>(count);
            UniformBounded<uint>(count);
        }

        void Bernouli(double p, int count)
        {
            var sw = stopwatch(false);
            sw.Start();
            var samples = BernoulliSpec<long>.Define(p).Distribution<long>(Random).Sample().Take(count);
            var avg = samples.Average();
            sw.Stop();

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

    }
}