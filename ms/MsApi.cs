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

    using MsInfer;
    using MsMl;
    using MsInfer.Distributions;
    using Dist = MsInfer.Distributions;
    using MlStats = MsMl.Stats;
    using static zfunc;

    /// <summary>
    /// Exposes desired operations
    /// </summary>
    public static class MsApi
    {   
        /// <summary>
        /// Defines a sample stream for a biniomian distribution
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The number of trials</param>
        /// <param name="p">The probability of success of a given trial</param>
        public static IEnumerable<int> SampleBinomial(this IRandomSource random, int n, double p)
        {
            var sysrand = SysRand.FromSource(random);
            while(true)
                yield return MlStats.SampleFromBinomial(sysrand, n, p);
        }

        /// <summary>
        /// Defines a sample stream for a biniomian distribution
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The number of trials</param>
        /// <param name="p">The probability of success of a given trial</param>
        public static IEnumerable<T> SampleBinomial<T>(this IRandomSource random, T n, double p)
            where T : struct
        {
            var sysrand = SysRand.FromSource(random);
            while(true)
                yield return convert<T>(MlStats.SampleFromBinomial(sysrand, convert<T,int>(n), p));
        }

        /// <summary>
        /// Defines a sample stream for a poisson distribution which represents the probability of
        /// a given number of independent events occurring over a period of time at a constant rate
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="lambda">The constant rate of occurrence</param>
        public static IEnumerable<int> SamplePoisson(this IRandomSource random, double lambda)
        {
            var sysrand = SysRand.FromSource(random);
            while(true)
                yield return MlStats.SampleFromPoisson(sysrand, lambda);
        }

        /// <summary>
        /// Defines a sample stream for a poisson distribution which represents the probability of
        /// a given number of independent events occurring over a period of time at a constant rate
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="lambda">The constant rate of occurrence</param>
        public static IEnumerable<T> SamplePoisson<T>(this IRandomSource random, T lambda)
            where T : struct
        {
            var sysrand = SysRand.FromSource(random);
            var l = convert<T,double>(lambda);
            while(true)
                yield return convert<T>(MlStats.SampleFromPoisson(sysrand, l));
        }


        public static IEnumerable<float> SampleLaplace(this IRandomSource random, float mean, float scale)
        {
            var sysrand = SysRand.FromSource(random);
            while(true)
                yield return MlStats.SampleFromLaplacian(sysrand, mean, scale);
        }

        public static IEnumerable<T> SampleLaplace<T>(this IRandomSource random, T mean, T scale)
            where T : struct
        {
            var sysrand = SysRand.FromSource(random);
            while(true)
                yield return convert<T>((MlStats.SampleFromLaplacian(sysrand, convert<T,float>(mean), convert<T,float>(scale))));
        }

        public static IEnumerable<double> SampleGaussian(this IRandomSource random, double mean, double σ)
        {
            var dist = Dist.Gaussian.FromMeanAndVariance(mean, σ*σ);
            while(true)
                yield return dist.Sample(random);
        }

        public static IEnumerable<T> SampleGaussian<T>(this IRandomSource random, T mean, T σ)
            where T : struct
        {
            var sig = convert<T,double>(σ);
            var mu = convert<T,double>(mean);
            var dist = Dist.Gaussian.FromMeanAndVariance(mu, sig*sig);
            while(true)
                yield return convert<T>(dist.Sample(random));
        }

        public static IEnumerable<double> SampleTruncatedGaussian(this IRandomSource random, double mean, double σ, double lower, double upper)
        {
            var dist = new Dist.TruncatedGaussian(Dist.Gaussian.FromMeanAndVariance(mean, σ*σ),lower,upper);
            while(true)
                yield return dist.Sample(random);
        }

        public static IEnumerable<bool> SampleBernoulli(this IRandomSource random, double p)
        {
            var dist = new Dist.Bernoulli(p);
            while(true)
                yield return dist.Sample(random);
        }

        public static IEnumerable<double> SampleGamma(this IRandomSource random, double shape, double rate)
        {
            var dist = Dist.Gamma.FromShapeAndRate(shape, rate);
            while(true)
                yield return dist.Sample(random);
        }

        public static IEnumerable<T> SampleGamma<T>(this IRandomSource random, T shape, T rate)
            where T : struct
        {
            var dist = Dist.Gamma.FromShapeAndRate(convert<T,double>(shape), convert<T,double>(rate));
            while(true)
                yield return convert<T>(dist.Sample(random));
        }

        public static IEnumerable<double> SampleBeta(this IRandomSource random, double trueCount, double falseCount)
        {
            var dist = new Dist.Beta(trueCount, falseCount);                
            while(true)
                yield return dist.Sample(random);
        }

        public static IEnumerable<T> SampleBeta<T>(this IRandomSource random, T trueCount, T falseCount)
            where T : struct
        {
            var dist = new Dist.Beta( convert<T,double>(trueCount), convert<T,double>(falseCount));                
            while(true)
                yield return As.generic<T>(dist.Sample(random));
        }

        public static IEnumerable<double[]> SampleDirichlet(IRandomSource random, double[] alphas)
        {
            var sysrand = SysRand.FromSource(random);
            while(true)
            {
                var dst = new double[alphas.Length];
                MlStats.SampleFromDirichlet(sysrand, alphas, dst);
                yield return dst;
            }
        }
        
        public static IEnumerable<double> SampleBeta2(this IRandomSource random, double alpha, double beta)
        {
            var sysrand = SysRand.FromSource(random);
            while(true)
                yield return MlStats.SampleFromBeta(sysrand, alpha, beta);
        }

        public static IEnumerable<double> SamplePareto(this IRandomSource random, double shape, double lowerBound)
        {
            var dist = new Dist.Pareto(shape, lowerBound);
            while(true)
                yield return dist.Sample(random);
        }

        public static IEnumerable<T> SamplePareto<T>(this IRandomSource random, T shape, T lowerBound)
            where T : struct
        {
            var dist = new Dist.Pareto(convert<T,double>(shape), convert<T,double>(lowerBound));
            while(true)
                yield return convert<T>(dist.Sample(random));
        }

        
    }

    public static class MsFn
    {

        [MethodImpl(Inline)]       
        public static double erfc(double x)        
            => ProbabilityFunctions.Erfc(x);
        
        [MethodImpl(Inline)]       
        public static double erf(double x)
            => ProbabilityFunctions.Erf(x);

        [MethodImpl(Inline)]       
        public static double erfinv(double x)
            => ProbabilityFunctions.Erfinv(x);
    }

}