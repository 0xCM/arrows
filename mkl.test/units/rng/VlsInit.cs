//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl.Test
{
    using System;
    using System.Linq;

    using static zfunc;
    using static nfunc;
    
    using Z0.Test;

    public class VlSInitTest : UnitTest<VlSInitTest>
    {
        public void CreateMt2203Generators()
        {
            var gencount = Pow2.T08;
            var samplesize = Pow2.T16;
            var seeds = Random.Array<uint>(gencount);
            var streams = new VslStream[gencount];
            for(var i=0; i<gencount; i++)
                streams[i] = mkl.gMt2203(seeds[i], i);
            
            Span<double> bufferF64 = new double[samplesize];
            Span<uint> bufferU32 = new uint[samplesize];
            Span<int> bufferI32 = new int[samplesize];
            var ufRange = closed(1.0, 250.0);
            for(var i=0; i<gencount; i++)
            {
                var stream = streams[i];
                var uniform = mkl.uniform(stream, ufRange, bufferF64);
                Claim.eq(BRNG.VSL_BRNG_MT2203 + i, uniform.SourceRng);
                var extrema = Sample.Load(bufferF64,1).Extrema();
                var max = Sample.Load(bufferF64,1).Max()[0];
                Claim.lteq(max, ufRange.Right);
                Claim.neq(max,0);

                var ubits = mkl.ubits(stream, bufferU32);
                Claim.eq(BRNG.VSL_BRNG_MT2203 + i, ubits.SourceRng);

                var bernoulli = mkl.bernoulli(stream, .40, bufferI32);
                for(var j=0; j<samplesize; j++)
                    Claim.yea(bernoulli[j] == 0 || bernoulli[j] == 1);

                var gaussian = mkl.gaussian(stream, .75, .75, bufferF64);
                Claim.eq(BRNG.VSL_BRNG_MT2203 + i, gaussian.SourceRng);
            }

            for(var i=0; i<gencount; i++)
                streams[i].Dispose();

        }
        void TestVlsInit()
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

            using(var stream = mkl.stream(BRNG.VSL_BRNG_NONDETERM, 1))
            {
                //VSL.viRngUniform(0, stream, buffer.Length, ref buffer[0], -200, 200).ThrowOnError();
                var i32 = mkl.uniform(stream, closed(-200, 200), span<int>(10));
                var i32Fmt = i32.Format();                
                append($"Discrete uniform i32 {appMsg(i32Fmt)}");

                var f32 = mkl.uniform(stream, closed(-250f, 250f), span<float>(10));
                append($"Continuous uniform f32 {appMsg(f32.Format())}");

                var f64 = mkl.uniform(stream, closed(-250d, 250d), span<double>(10));
                append($"Continuous uniform f64 {appMsg(f64.Format())}");

                var u32 = mkl.ubits(stream, span<uint>(10));
                var u32Fmt = u32.Format();
                append(u32Fmt);

                var u64 = mkl.ubits(stream, span<ulong>(10));
                var u64Fmt = u64.Format();
                append(u64Fmt);

                var bernoulli = mkl.bernoulli(stream, .5, span<Bit>(10));
                append($"Bernoulli  {bernoulli.Format()}");

                var geometric = mkl.geometric(stream, .5, span<int>(20));
                append(geometric.Format());
            }                    
        }
    }
}