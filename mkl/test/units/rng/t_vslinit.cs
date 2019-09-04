//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;

    using static zfunc;
    using static nfunc;
    
    using Z0.Test;

    public class t_vslinit : UnitTest<t_vslinit>
    {
        public void t_bernoulli()
        {
            var pTarget = 0.7;
            var tolerance = .02;
            var count = Pow2.T12;
            using var stream = mkl.gMt19937(54u);
            
            var sum = 0.0;
            var buffer = stream.BernoulliBuffer(pTarget);
            foreach(var point in buffer.Samples.TakeSpan(count))
                if(point != 0) 
                    sum++;

            var pActual = sum / ((double)count);
            var radius = closed(pTarget - tolerance, pTarget + tolerance);
            Claim.yea(radius.Contains(pActual));

        }


        public void CreateMt2203Generators()
        {
            var gencount = Pow2.T08;
            var samplesize = Pow2.T16;
            var seeds = Polyrand.Array<uint>(gencount);
            var streams = new RngStream[gencount];
            for(var i=0; i<gencount; i++)
                streams[i] = mkl.gMt2203(seeds[i], i);
            
            var bufferF64 = new double[samplesize];
            var bufferU32 = new uint[samplesize];
            var bufferI32 = new int[samplesize];
            var ufRange = closed(1.0, 250.0);
            for(var i=0; i<gencount; i++)
            {
                var stream = streams[i];
                var uniform = mkl.uniform(stream, ufRange, bufferF64);
                //Claim.eq(BRNG.MT2203 + i, uniform.Rng);
                var extrema = Sample.Load(bufferF64,1).Extrema();
                var max = Sample.Load(bufferF64,1).Max()[0];
                Claim.lteq(max, ufRange.Right);
                Claim.neq(max,0);

                var ubits = mkl.bits(stream, bufferU32);
                //Claim.eq(BRNG.MT2203 + i, ubits.Rng);

                var bernoulli = mkl.bernoulli(stream, .40, bufferI32);
                var bData = bernoulli.Data.Span;
                for(var j=0; j<samplesize; j++)
                    Claim.yea(bData[j] == 0 || bData[j] == 1);

                var gaussian = mkl.gaussian(stream, .75, .75, bufferF64);
                //Claim.eq(BRNG.MT2203 + i, gaussian.Rng);

                var laplace = mkl.laplace(stream, .5, .5, bufferF64);
            }

            for(var i=0; i<gencount; i++)
                streams[i].Dispose();

        }
        
        public void TestVlsInit()
        {
            var report = sbuild();
            bool silent = true;

            string append(string msg)
            {
                report.AppendLine(msg); 
                if(!silent)
                    Trace(msg);
                return msg;
            };

            using var stream = mkl.gRandom();
            
                //VSL.viRngUniform(0, stream, buffer.Length, ref buffer[0], -200, 200).ThrowOnError();
            var i32 = mkl.uniform(stream, closed(-200, 200), array<int>(10));
            var i32Fmt = i32.Format();                
            append($"Discrete uniform i32 {appMsg(i32Fmt)}");

            var f32 = mkl.uniform(stream, closed(-250f, 250f), array<float>(10));
            append($"Continuous uniform f32 {appMsg(f32.Format())}");

            var f64 = mkl.uniform(stream, closed(-250d, 250d), array<double>(10));
            append($"Continuous uniform f64 {appMsg(f64.Format())}");

            var u32 = mkl.bits(stream, array<uint>(10));
            var u32Fmt = u32.Format();
            append(u32Fmt);

            var u64 = mkl.bits(stream, array<ulong>(10));
            var u64Fmt = u64.Format();
            append(u64Fmt);

            var bernoulli = mkl.bernoulli(stream, .5, array<int>(10));
            append($"Bernoulli  {bernoulli.Format()}");

            var geometric = mkl.geometric(stream, .5, array<int>(20));
            append(geometric.Format());
            
        }
    }
}
