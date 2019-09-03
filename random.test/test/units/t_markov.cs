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
    using Z0.Mkl;

    using static zfunc;
    
    public class t_markov : UnitTest<t_markov>
    {
        const uint Seed = 0x78941u;
        public void ProbabilityVectors0()
        {
            using var rng = mkl.gMcg31(Seed);
            var src = rng.Uniform(closed(.0001, .0100)).Select(x => x.Round(4));
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

        /// <summary>
        /// Generates Markov vectors with dimensions that vary with the factor and scale parameters
        /// </summary>
        /// <param name="factor"></param>
        /// <param name="scale"></param>
        /// <param name="ws">A workspace span of sufficient length to receive the components. For a uniform distribution,
        /// if the factor parameter is bounded below by .005, a span of length 1024 should be sufficient</param>
        Span<double> MarkovVector(double factor, int scale,  Span<double> dst)
        {
            var src = Polyrand.Stream<double>().Select(x => (x *factor).Round(scale));
            var sum = 0.0;
            var count = 0;
            var min = 1.0;
            var max = 0.0;
            while(sum < 1)
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

        public void MarkovVectors()
        {
            var tol = .0001;
            var radius = closed(1 - tol,1 + tol);   
            var points = range(.005, .35, .005);
            Span<double> ws = new double[1000];
            foreach(var point in points)
            {
                var v = MarkovVector(point, 6, ws);                
                Claim.yea(radius.Contains(v.Sum()));
            }        
        }


        Span<double> MarkovVector(double factor, int scale = 6)
        {
            Span<double> dst = new double[1000];
            return MarkovVector(factor, scale, dst);
        }   

        public void ProbabilityVectors1()
        {
            var tol = .0001;
            var radius = closed(1 - tol,1 + tol);   
            var points = range(.005, .35, .005);
            Span<double> ws = new double[1000];
            foreach(var point in points)
            {
                var v = MarkovVector(point, 6, ws);
                Claim.yea(radius.Contains(v.Sum()));
            }        
        }

        public void ProbabilityVectors2()
        {
            var rng = mkl.gR250(Seed);
            var src = rng.Uniform(closed(.0001, .0100)).Select(x => x.Round(4));
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

        void VerifyRightStochastic<N,T>(Matrix<N,T> m, N n = default)
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
            var m = Matrix.Alloc(n, rep);
            for(var i=0; i< count; i++)
            {
                Polyrand.MarkovMat(ref m);
                VerifyRightStochastic(m);
            }
        }

        void MarkovVector<N,T>(int count, N n = default, T rep = default )
            where N : ITypeNat, new()
            where T : struct
        {
            var tol = .0001;
            var radius = closed(1 - tol,1 + tol);   
            var v = Vector.Alloc<N,T>();
            for(var i=0; i< count; i++)
            {
                Polyrand.MarkovVec(ref v);
                var sum =  convert<T,double>(gmath.sum(v.Unsized));
                Claim.yea(radius.Contains(sum));
            }
        }

        public void MarkovMatrix()
        {
            var count = Pow2.T08;
            MarkovMatrix(count, n5, 1f);
            MarkovMatrix(count, n20, 1d);
            MarkovMatrix(count, n30, 1f);            

        }

        public void MarkovVector()
        {
            var count = Pow2.T08;
            MarkovVector(count, n30, 0f);
            MarkovVector(count, n30, 0d);
            MarkovVector(count, n128, 0d);
        }

        void MarkovMatMulF32<N>(int count, N n = default)
            where N : ITypeNat, new()
        {

            var m1 = Matrix.Alloc(n, 0f);
            var m2 = Matrix.Alloc(n, 0f);
            var m3 = Matrix.Alloc(n, 0f);
            for(var i=0; i< count; i++)
            {
                Polyrand.MarkovMat(ref m1);
                Polyrand.MarkovMat(ref m2);
                m1.Mul(m2, ref m3);
                VerifyRightStochastic(m3);
            }
        
        }

        void MarkovMatMulF64<N>(int count, N n = default)
            where N : ITypeNat, new()
        {

            var m1 = Matrix.Alloc(n, 0d);
            var m2 = Matrix.Alloc(n, 0d);
            var m3 = Matrix.Alloc(n, 0d);
            for(var i=0; i< count; i++)
            {
                Polyrand.MarkovMat(ref m1);
                Polyrand.MarkovMat(ref m2);
                m1.Mul(m2, ref m3);
                VerifyRightStochastic(m3);
            }        
        }

        public void MarkovMatrixMul()
        {
            MarkovMatMulF32(Pow2.T08, n12);
            MarkovMatMulF64(Pow2.T08, n12);

        }

    }

}