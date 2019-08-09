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

        public static IEnumerable<float> SampleLaplace(this IRandomSource random, float mean, float scale)
        {
            var sysrand = SysRand.FromSource(random);
            while(true)
                yield return MlStats.SampleFromLaplacian(sysrand, mean, scale);
        }

        public static IEnumerable<double> SampleGaussian(this IRandomSource random, double mean, double σ)
        {
            var dist = Dist.Gaussian.FromMeanAndVariance(mean, σ*σ);
            while(true)
                yield return dist.Sample(random);
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

        public static IEnumerable<double> SampleBeta(this IRandomSource random, double trueCount, double falseCount)
        {
            var dist = new Dist.Beta(trueCount, falseCount);                
            while(true)
                yield return dist.Sample(random);
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

        /// <summary>
        /// Draws, without replacement, a specified number of samples from a source comprising a specified number of items
        /// </summary>
        /// <param name="random">A uniform random source</param>
        /// <param name="sourceCount">The number of source items</param>
        /// <param name="samples">The number of samples to take</param>
        internal static IEnumerable<int> SampleWithoutReplacement(this IRandomSource random, int sourceCount, int samples)
            => Rand.SampleWithoutReplacement(sourceCount, samples, random);

        /// <summary>
        /// Draws, without replacement, a specified number of items from a list
        /// </summary>
        /// <param name="random">A uniform random source</param>
        /// <param name="src">The source list</param>
        /// <param name="samples">The number of samples to draw</param>
        /// <typeparam name="T">The list item type</typeparam>
        internal static HashSet<T> SampleWithoutReplacement<T>(this IRandomSource random, IReadOnlyList<T> src, int samples)
            => Rand.SampleWithoutReplacement(src,samples, random);        
        
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