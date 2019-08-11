//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
	using static zfunc;

    public static class VslStreamX
    {
        static IEnumerable<T> Stream<T>(this VslStream vsls, Action<T[]> refill)
            where T : struct
        {
            var buffer = new T[vsls.BlockSize];
            var i = 0;
            while(true)
            {
                if(i == buffer.Length || i==0)
                {
                    refill(buffer);
                    i = 0;
                }
                yield return buffer[i++];
            }

        }

        public static IEnumerable<ulong> UniformBits(this VslStream vsls)
        {
            void Refill(ulong[] buffer)            
                => mkl.bits(vsls, buffer);
            
            return vsls.Stream<ulong>(Refill);
        }

        public static IEnumerable<double> Uniform(this VslStream vsls, Interval<double> range)
        {
            void Refill(double[] buffer)            
                => mkl.uniform(vsls,range,buffer);
            
            return vsls.Stream<double>(Refill);                                
        }

        public static IEnumerable<float> Uniform(this VslStream vsls, Interval<float> range)
        {
            void Refill(float[] buffer)            
                => mkl.uniform(vsls,range,buffer);
            
            return vsls.Stream<float>(Refill);                                
        }

        public static IEnumerable<int> Uniform(this VslStream vsls, Interval<int> range)
        {
            void Refill(int[] buffer)            
                => mkl.uniform(vsls,range,buffer);
            
            return vsls.Stream<int>(Refill);                                
        }

        public static IEnumerable<float> Gaussian(this VslStream vsls, float mu, float sigma)
        {
            void Refill(float[] buffer)
                => mkl.gaussian(vsls,mu,sigma,buffer);

            return vsls.Stream<float>(Refill);                                
        }

        public static IEnumerable<double> Gaussian(this VslStream vsls, double mu, double sigma)
        {
            void Refill(double[] buffer)
                => mkl.gaussian(vsls,mu,sigma,buffer);

            return vsls.Stream<double>(Refill);                                
        }

        public static IEnumerable<float> Gamma(this VslStream vsls, float alpha, float dx, float beta)
        {
            void Refill(float[] buffer)
                => mkl.gamma(vsls,alpha,dx,beta,buffer);

            return vsls.Stream<float>(Refill);                                
        }

        public static IEnumerable<double> Gamma(this VslStream vsls, double alpha, double dx, double beta)
        {
            void Refill(double[] buffer)
                => mkl.gamma(vsls,alpha,dx,beta,buffer);

            return vsls.Stream<double>(Refill);                                
        }

        public static IEnumerable<float> Exponential(this VslStream vsls, float dx, float beta)
        {
            void Refill(float[] buffer)
                => mkl.exp(vsls,dx,beta,buffer);

            return vsls.Stream<float>(Refill);                                
        }

        public static IEnumerable<double> Exponential(this VslStream vsls, double dx, double beta)
        {
            void Refill(double[] buffer)
                => mkl.exp(vsls,dx,beta,buffer);

            return vsls.Stream<double>(Refill);                                
        }

        public static IEnumerable<Bit> Bernoulli(this VslStream vsls, double p)
        {
            void Refill(int[] buffer)
                => mkl.bernoulli(vsls,p, buffer);
            
            foreach(var value in vsls.Stream<int>(Refill))
                yield return value;
        }

        public static IEnumerable<int> Geometric(this VslStream vsls, double p)
        {
            void Refill(int[] buffer)
                => mkl.geometric(vsls,p, buffer);
            return vsls.Stream<int>(Refill);
        }

        public static IEnumerable<int> Poisson(this VslStream vsls, double alpha)
        {
            void Refill(int[] buffer)
                => mkl.poisson(vsls,alpha, buffer);
            return vsls.Stream<int>(Refill);
        }

        public static IEnumerable<float> Chi32(this VslStream vsls, int freedom)
        {
            void Refill(float[] buffer)
                => mkl.chi2(vsls,freedom, buffer);
            
            return vsls.Stream<float>(Refill);
        }

        public static IEnumerable<double> Chi64(this VslStream vsls, int freedom)
        {
            void Refill(double[] buffer)
                => mkl.chi2(vsls,freedom, buffer);
            
            return vsls.Stream<double>(Refill);
        }

        public static IEnumerable<float> Laplace(this VslStream vsls, float mean, float beta)
        {
            void Refill(float[] buffer)
                => mkl.laplace(vsls,mean,beta,buffer);

            return vsls.Stream<float>(Refill);                                
        }

        public static IEnumerable<double> Laplace(this VslStream vsls, double mean, double beta)
        {
            void Refill(double[] buffer)
                => mkl.laplace(vsls,mean,beta,buffer);

            return vsls.Stream<double>(Refill);                                
        }       
    }


}