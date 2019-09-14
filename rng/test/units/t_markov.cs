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
    using Z0.Mkl;

    using static zfunc;
    
    public class t_markov : UnitTest<t_markov>
    {
        const uint Seed = 0x78941u;

        public void markov_v0()
        {
            var tol = .0001;
            var radius = closed(1 - tol,1 + tol);   
            var points = range(.005, .35, .005);
            Span<double> ws = new double[1000];
            foreach(var point in points)
            {
                var v = markov_vgen(point, 6, ws);                
                Claim.yea(radius.Contains(v.Sum()));
            }        
        }

        public void markov_v1()
        {
            using var rng = MklRng.Define(BRNG.MCG31,Seed);
            var src = samplers.uniform(rng,.0001, .0100).Select(x => x.Round(4));
            var sum = 0.0;
            var count = 0;
            var min = 1.0;
            var max = 0.0;

            while(sum < 1)
            {
                var next = src.First();
                sum += next;
                count++;

                if(next < min)
                    min = next;
                if(next > max)
                    max = next;                
            }
        }

        public void markov_v2()
        {
            var tol = .0001;
            var radius = closed(1 - tol,1 + tol);   
            var points = range(.005, .35, .005);
            Span<double> ws = new double[1000];
            foreach(var point in points)
            {
                var v = markov_vgen(point, 6, ws);
                Claim.yea(radius.Contains(v.Sum()));
            }        
        }

        public void markov_v3()
        {
            using var rng = MklRng.Define(BRNG.R250,Seed);
            var samples = samplers.uniform(rng, .0001, .0100);
            var src = samples.Select(x => x.Round(4));
            var sum = 0.0;
            var count = 0;
            var min = 1.0;
            var max = 0.0;

            while(sum < 1)
            {
                var next = src.First();
                sum += next;
                count++;

                if(next < min)
                    min = next;
                if(next > max)
                    max = next;                
            }
        }

        public void markov_v4()
        {
            var count = Pow2.T08;
            MarkovVector(count, n30, 0f);
            MarkovVector(count, n30, 0d);
            MarkovVector(count, n128, 0d);
        }

        public void markov_mcreate()
        {
            var count = Pow2.T08;
            MarkovMatrix(count, n5, 1f);
            MarkovMatrix(count, n20, 1d);
            MarkovMatrix(count, n30, 1f);            

        }

        public void markov_mmul()
        {
            MarkovMatMulF32(Pow2.T08, n12);
            MarkovMatMulF64(Pow2.T08, n12);
        }


        /// <summary>
        /// Generates Markov vectors with dimensions that vary with the factor and scale parameters
        /// </summary>
        /// <param name="factor"></param>
        /// <param name="scale"></param>
        /// <param name="ws">A workspace span of sufficient length to receive the components. For a uniform distribution,
        /// if the factor parameter is bounded below by .005, a span of length 1024 should be sufficient</param>
        Span<double> markov_vgen(double factor, int scale, Span<double> dst)
        {
            var src = Random.Stream<double>().Select(x => (x *factor).Round(scale));
            var sum = 0.0;
            var count = 0;
            var min = 1.0;
            var max = 0.0;

            while(sum < 1 && count < dst.Length)
            {
                var next = src.First();
                sum += next;
                dst[count++] = next;

                if(next < min)
                    min = next;
                if(next > max)
                    max = next;
                
            }
            var s2 = sum - dst[count -1];
            var s3 = 1.0 - s2;
            dst[count - 1] = s3.Round(scale);
            var v = dst.Slice(0, count);
            return v;

        }   

        Span<double> MarkovVector(double factor, int scale = 6)
        {
            Span<double> dst = new double[1000];
            return markov_vgen(factor, scale, dst);
        }   
        
        void VerifyRightStochastic<N,T>(BlockMatrix<N,T> m, N n = default)
            where N : ITypeNat, new()
            where T : struct
        {
            Claim.yea(m.IsRightStochastic());
        }

        void MarkovMatrix<N,T>(int count, N n = default, T rep = default )
            where N : ITypeNat, new()
            where T : struct
        {
            var tol = .0001;
            var radius = closed(1 - tol,1 + tol);   
            var m = BlockMatrix.Alloc(n, rep);
            for(var i=0; i< count; i++)
            {
                Random.MarkovMat(ref m);
                VerifyRightStochastic(m);
            }
        }

        void MarkovVector<N,T>(int count, N n = default, T rep = default )
            where N : ITypeNat, new()
            where T : struct
        {
            var tol = .0001;
            var radius = closed(1 - tol,1 + tol);   
            var v = BlockVector.Alloc<N,T>();
            for(var i=0; i< count; i++)
            {
                Random.MarkovVec(ref v);
                var sum =  convert<T,double>(gmath.sum(v.Unsized));
                Claim.yea(radius.Contains(sum));
            }
        }

        void MarkovMatMulF32<N>(int count, N n = default)
            where N : ITypeNat, new()
        {

            var m1 = BlockMatrix.Alloc(n, 0f);
            var m2 = BlockMatrix.Alloc(n, 0f);
            var m3 = BlockMatrix.Alloc(n, 0f);
            for(var i=0; i< count; i++)
            {
                Random.MarkovMat(ref m1);
                Random.MarkovMat(ref m2);
                m1.Mul(m2, ref m3);
                VerifyRightStochastic(m3);
            }
        
        }

        void MarkovMatMulF64<N>(int count, N n = default)
            where N : ITypeNat, new()
        {
            var m1 = BlockMatrix.Alloc(n, 0d);
            var m2 = BlockMatrix.Alloc(n, 0d);
            var m3 = BlockMatrix.Alloc(n, 0d);
            for(var i=0; i< count; i++)
            {
                Random.MarkovMat(ref m1);
                Random.MarkovMat(ref m2);
                m1.Mul(m2, ref m3);
                VerifyRightStochastic(m3);
            }        
        }


    }

}