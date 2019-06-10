// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace MsInfer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    partial class MMath
    {

        /// <summary>
        /// Computes the logistic function 1/(1+exp(-x)).
        /// </summary>
        /// <param name="x">Any real number from -Inf to Inf, or NaN.</param>
        /// <returns>1/(1+exp(-x)).</returns>
        public static double Logistic(double x)
        {
            if (x > 0.0)
                return 1.0 / (1 + Math.Exp(-x));
            else
            {
                double y = Math.Exp(x);
                return y / (1.0 + y);
            }
        }

        /// <summary>
        /// Compute the natural logarithm of the logistic function, i.e. -log(1+exp(-x)).
        /// </summary>
        /// <param name="x">Any real number from -Inf to Inf, or NaN.</param>
        /// <returns>-log(1+exp(-x)).</returns>
        /// <remarks>This function provides higher accuracy than a direct evaluation of <c>-log(1+exp(-x))</c>, 
        /// which can fail for x &lt; -50 and x > 36.</remarks>
        public static double LogisticLn(double x)
        {
            return -Log1PlusExp(-x);
#if false
            const double small = -50;
            const double large = 12.5;
            if (x < small) return x;
            if (x < large) return -Math.Log(1 + Math.Exp(-x));
            // x >= large
            // use the Taylor series for -log(1+x) around x=0
            // Maple command: series(-log(1+x),x);
            double e = Math.Exp(-x);
            return -e * (1 - e * 0.5);
#endif
        }

        /// <summary>
        /// Computes the natural logarithm of 1+x.
        /// </summary>
        /// <param name="x">A real number in the range -1 &lt;= x &lt;= Inf, or NaN.</param>
        /// <returns>log(1+x), which is always >= 0.</returns>
        /// <remarks>This function provides higher accuracy than a direct evaluation of <c>log(1+x)</c>,
        /// particularly when <paramref name="x"/> is small.
        /// </remarks>
        public static double Log1Plus(double x)
        {
            Assert.IsTrue(Double.IsNaN(x) || x >= -1);
            if (x > -1e-3 && x < 2e-3)
            {
                // use the Taylor series for log(1+x) around x=0
                // Maple command: series(log(1+x),x);
                return x * (1 - x * (0.5 - x * (1.0 / 3 - x * (0.25 - x * (1.0 / 5)))));
            }
            else
            {
                return Math.Log(1 + x);
            }
        }

        /// <summary>
        /// Computes log(numerator/denominator) to high accuracy.
        /// </summary>
        /// <param name="numerator">Any positive real number.</param>
        /// <param name="denominator">Any positive real number.</param>
        /// <returns>log(numerator/denominator)</returns>
        public static double LogRatio(double numerator, double denominator)
        {
            Assert.IsTrue(numerator > 0 && denominator > 0);
            double delta = (numerator - denominator) / denominator;
            if (delta > -1e-3 && delta < 5e-4)
                return Log1Plus(delta);
            else
                return Math.Log(numerator / denominator);
        }

        /// <summary>
        /// Computes log(1 + exp(x)) to high accuracy.
        /// </summary>
        /// <param name="x">Any real number from -Inf to Inf, or NaN.</param>
        /// <returns>log(1+exp(x)), which is always >= 0.</returns>
        /// <remarks>This function provides higher accuracy than a direct evaluation of <c>log(1+exp(x))</c>,
        /// particularly when x &lt; -36 or x > 50.</remarks>
        public static double Log1PlusExp(double x)
        {
            if (x > 50)
                return x;
            else
                return Log1Plus(Math.Exp(x));
        }

        /// <summary>
        /// Computes log(1 - exp(x)) to high accuracy.
        /// </summary>
        /// <param name="x">A non-positive real number: -Inf &lt;= x &lt;= 0, or NaN.</param>
        /// <returns>log(1-exp(x)), which is always &lt;= 0.</returns>
        /// <remarks>This function provides higher accuracy than a direct evaluation of <c>log(1-exp(x))</c>,
        /// particularly when x &lt; -7.5 or x > -1e-5.</remarks>
        public static double Log1MinusExp(double x)
        {
            if (x > 0)
                throw new ArgumentException("x (" + x + ") > 0");
            if (x < -7.5)
            {
                double y = Math.Exp(x);
                return -y * (1 + y * (0.5 + y * (1.0 / 3 + y * (0.25))));
            }
            else
            {
                return Math.Log(-ExpMinus1(x));
            }
        }

        /// <summary>
        /// Computes the exponential of x and subtracts 1.
        /// </summary>
        /// <param name="x">Any real number from -Inf to Inf, or NaN.</param>
        /// <returns>exp(x)-1</returns>
        /// <remarks>
        /// This function is more accurate than a direct evaluation of <c>exp(x)-1</c> when x is small.
        /// It is the inverse function to Log1Plus: <c>ExpMinus1(Log1Plus(x)) == x</c>.
        /// </remarks>
        public static double ExpMinus1(double x)
        {
            if (Math.Abs(x) < 2e-3)
            {
                return x * (1 + x * (0.5 + x * (1.0 / 6 + x * (1.0 / 24))));
            }
            else
            {
                return Math.Exp(x) - 1.0;
            }
        }

        /// <summary>
        /// Computes ((exp(x)-1)/x - 1)/x - 0.5
        /// </summary>
        /// <param name="x">Any real number from 0 to Inf, or NaN.</param>
        /// <returns>((exp(x)-1)/x - 1)/x - 0.5</returns>
        public static double ExpMinus1RatioMinus1RatioMinusHalf(double x)
        {
            if (x < 0) throw new ArgumentOutOfRangeException(nameof(x), "x < 0");
            if (Math.Abs(x) < 6e-1)
            {
                return x * (1.0 / 6 + x * (1.0 / 24 + x * (1.0 / 120 + x * (1.0 / 720 +
                    x * (1.0 / 5040 + x * (1.0 / 40320 + x * (1.0 / 362880 + x * (1.0 / 3628800 +
                    x * (1.0 / 39916800 + x * (1.0 / 479001600 + x * (1.0 / 6227020800 + x * (1.0 / 87178291200))))))))))));
            }
            else if (double.IsPositiveInfinity(x))
            {
                return x;
            }
            else
            {
                return ((Math.Exp(x) - 1) / x - 1) / x - 0.5;
            }
        }

        /// <summary>
        /// Computes <c>log(exp(x)-1)</c> for non-negative x.
        /// </summary>
        /// <param name="x">A non-negative real number: 0 &lt;= x &lt;= Inf, or NaN.</param>
        /// <returns><c>log(exp(x)-1)</c></returns>
        /// <remarks>
        /// This function is more accurate than a direct evaluation of <c>log(exp(x)-1)</c> when x &lt; 1e-3
        /// or x > 50.
        /// It is the inverse function to Log1PlusExp: <c>LogExpMinus1(Log1PlusExp(x)) == x</c>.
        /// </remarks>
        public static double LogExpMinus1(double x)
        {
            if (x < 1e-3)
            {
                return Math.Log(x) + x * (0.5 + x * (1.0 / 24 + x * (-1.0 / 2880)));
            }
            else if (x > 50)
            {
                return x;
            }
            else
            {
                return Math.Log(Math.Exp(x) - 1.0);
            }
        }

        /// <summary>
        /// Computes log(exp(x) - exp(y)) to high accuracy.
        /// </summary>
        /// <param name="x">Any real number from -Inf to Inf, or NaN.  Must be greater or equal to y.</param>
        /// <param name="y">Any real number from -Inf to Inf, or NaN.  Must be less or equal to x.</param>
        /// <returns></returns>
        /// <remarks>This function provides higher accuracy than a direct evaluation of <c>log(exp(x)-exp(y))</c>.</remarks>
        public static double LogDifferenceOfExp(double x, double y)
        {
            if (x == y)
                return Double.NegativeInfinity;
            if (Double.IsNegativeInfinity(y))
                return x;
            return x + MMath.Log1MinusExp(y - x);
        }

        /// <summary>
        /// Computes exp(x)-exp(y) to high accuracy.
        /// </summary>
        /// <param name="x">Any real number</param>
        /// <param name="y">Any real number</param>
        /// <returns>exp(x)-exp(y)</returns>
        public static double DifferenceOfExp(double x, double y)
        {
            if (x == y)
                return 0.0;
            else if (x > y)
                return Math.Exp(x + MMath.Log1MinusExp(y - x));
            else
                return -DifferenceOfExp(y, x);
        }

        /// <summary>
        /// Computes log(exp(x) + exp(y)) to high accuracy.
        /// </summary>
        /// <param name="x">Any real number from -Inf to Inf, or NaN.</param>
        /// <param name="y">Any real number from -Inf to Inf, or NaN.</param>
        /// <returns>log(exp(x)+exp(y)), which is always >= max(x,y).</returns>
        /// <remarks>This function provides higher accuracy than a direct evaluation of <c>log(exp(x)+exp(y))</c>.</remarks>
        public static double LogSumExp(double x, double y)
        {
            if (double.IsNegativeInfinity(x))
            {
                return y;
            }

            if (double.IsNegativeInfinity(y))
            {
                return x;
            }

            double delta = Math.Abs(x - y);
            double max = Math.Max(x, y); // also 0.5*(x+y+delta)
            // if x = y = Inf or -Inf, delta will be NaN.
            // return max to also catch the case where x = NaN or y = NaN.
            if (Double.IsNaN(delta))
                return max;
            return max + Log1PlusExp(-delta);
        }

        /// <summary>
        /// Returns the log of the sum of exponentials of a list of doubles
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static double LogSumExp(IEnumerable<double> list)
        {
            double max = Max(list);
            IEnumerator<double> iter = list.GetEnumerator();
            if (!iter.MoveNext() || Double.IsNegativeInfinity(max))
                return Double.NegativeInfinity; // log(0)
            if (Double.IsPositiveInfinity(max))
                return Double.PositiveInfinity;
            // at this point, max is finite
            double Z = Math.Exp(iter.Current - max);
            while (iter.MoveNext())
            {
                Z += Math.Exp(iter.Current - max);
            }
            return Math.Log(Z) + max;
        }


        /// <summary>
        /// Computes log(exp(x)+exp(a))-log(exp(x)+exp(b)) to high accuracy.
        /// </summary>
        /// <param name="x">Any real number from -Inf to Inf, or NaN.</param>
        /// <param name="a">A finite real number.</param>
        /// <param name="b">A finite real number.</param>
        /// <returns>log(exp(x)+exp(a))-log(exp(x)+exp(b))</returns>
        /// <remarks>This function provides higher accuracy than a direct evaluation of 
        /// <c>LogSumExp(x,a)-LogSumExp(x,b)</c>, particularly when x is large.
        /// </remarks>
        public static double DiffLogSumExp(double x, double a, double b)
        {
            Assert.IsTrue(!Double.IsInfinity(a));
            Assert.IsTrue(!Double.IsInfinity(b));
            if (x > a && x > b)
            {
                return Log1PlusExp(a - x) - Log1PlusExp(b - x);
            }
            // x cannot be Inf here so this difference is safe.
            // if a and b could be infinite, we would need extra checks.
            return LogSumExp(x, a) - LogSumExp(x, b);
        }

        /// <summary>
        /// Computes the log-odds function log(p/(1-p)).
        /// </summary>
        /// <param name="p">Any number between 0 and 1, inclusive.</param>
        /// <returns>log(p/(1-p))</returns>
        /// <remarks>This function is the inverse of the logistic function, 
        /// i.e. <c>Logistic(Logit(p)) == p.</c></remarks>
        public static double Logit(double p)
        {
            if (p >= 1.0)
                return Double.PositiveInfinity;
            else if (p <= 0.0)
                return Double.NegativeInfinity;
            else
                return Math.Log(p / (1 - p));
        }

        /// <summary>
        /// Compute log(p/(1-p)) from log(p).
        /// </summary>
        /// <param name="logp">Any number between -infinity and 0, inclusive.</param>
        /// <returns>log(exp(logp)/(1-exp(logp))) = -log(exp(-logp)-1).</returns>
        public static double LogitFromLog(double logp)
        {
            return -LogExpMinus1(-logp);
        }


        /// <summary>
        /// Evaluates E[log(1+exp(x))] under a Gaussian distribution with specified mean and variance.
        /// </summary>
        /// <param name="mean"></param>
        /// <param name="variance"></param>
        /// <returns></returns>
        public static double Log1PlusExpGaussian(double mean, double variance)
        {
            double[] nodes = new double[11];
            double[] weights = new double[11];
            Quadrature.GaussianNodesAndWeights(mean, variance, nodes, weights);
            double z = 0;
            for (int i = 0; i < nodes.Length; i++)
            {
                double x = nodes[i];
                double f = MMath.Log1PlusExp(x);
                z += weights[i] * f;
            }
            return z;
        }


        /// <summary>
        /// Specifies the number of quadrature nodes that should be used when doing
        /// Gauss Hermite quadrature for direct KL minimisation 
        /// </summary>
        private const int LogisticGaussianQuadratureNodeCount = 50;

        /// <summary>
        /// For integrals with variance greater than this Clenshaw curtis quadrature will be used
        /// instead of Gauss-Hermite quadrature. 
        /// </summary>
        private const double LogisticGaussianVarianceThreshold = 2.0;

        // Use the large variance approximation to sigma(m,v) = \int N(x;m,v) logistic(x)
        private static void BigvProposal(double m, double v, out double mf, out double vf)
        {
            double v2 = v + Math.PI * Math.PI / 3.0;
            double Z = MMath.NormalCdf(m / Math.Sqrt(v2));
            double s1 = Math.Exp(Gaussian.GetLogProb(0, m, v2));
            double s2 = -s1 * m / v2;
            mf = m + v * s1 / Z;
            double Ex2 = v + m * m + 2 * m * v * s1 / Z + v * v * s2 / Z;
            vf = Ex2 - mf * mf;
        }

        // Math.Exp(-745.14) == 0
        private const double log0 = -745.14;
        // 1-Math.Exp(-38) == 1
        private const double logEpsilon = -38;


        /// <summary>
        /// Calculate (kth derivative of LogisticGaussian)*exp(0.5*mean^2/variance)
        /// </summary>
        /// <param name="mean"></param>
        /// <param name="variance"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static double LogisticGaussianRatio(double mean, double variance, int k)
        {
            if (k < 0 || k > 2) throw new ArgumentException("invalid k (" + k + ")");
            double a = mean / variance;
            // int 0.5 cosh(x(m/v+1/2))/cosh(x/2) N(x;0,v) dx
            double f(double x)
            {
                double logSigma = MMath.LogisticLn(x);
                double extra = 0;
                double s = 1;
                if (k > 0) extra += MMath.LogisticLn(-x);
                if (k > 1) s = -Math.Tanh(x / 2);
                return s * Math.Exp(logSigma + extra + x * a + Gaussian.GetLogProb(x, 0, variance));
            }
            double upperBound = (Math.Abs(a + 0.5) - 0.5) * variance + Math.Sqrt(variance);
            upperBound = Math.Max(upperBound, 10);
            return Quadrature.AdaptiveClenshawCurtis(f, upperBound, 32, 1e-10);
        }


        /// <summary>
        /// Calculate sigma(m,v) = \int N(x;m,v) logistic(x) dx
        /// </summary>
        /// <param name="mean">Mean</param>
        /// <param name="variance">Variance</param>
        /// <returns>The value of this special function.</returns>
        /// <remarks><para>
        /// Note <c>1-LogisticGaussian(m,v) = LogisticGaussian(-m,v)</c> which is more accurate.
        /// </para><para>
        /// For large v we can use the big v approximation <c>\sigma(m,v)=normcdf(m/sqrt(v+pi^2/3))</c>.
        /// For small and moderate v we use Gauss-Hermite quadrature.
        /// For moderate v we first find the mode of the (log concave) function since this may be quite far from m.
        /// </para></remarks>
        public static double LogisticGaussian(double mean, double variance)
        {
            double halfVariance = 0.5 * variance;

            // use the upper bound exp(m+v/2) to prune cases that must be zero or one
            if (mean + halfVariance < log0)
                return 0.0;
            if (-mean + halfVariance < logEpsilon)
                return 1.0;

            // use the upper bound 0.5 exp(-0.5 m^2/v) to prune cases that must be zero or one
            double q = -0.5 * mean * mean / variance - MMath.Ln2;
            if (mean <= 0 && mean + variance >= 0 && q < log0)
                return 0.0;
            if (mean >= 0 && variance - mean >= 0 && q < logEpsilon)
                return 1.0;
            // sigma(|m|,v) <= 0.5 + |m| sigma'(0,v)
            // sigma'(0,v) <= N(0;0,v+8/pi)
            double d0Upper = MMath.InvSqrt2PI / Math.Sqrt(variance + 8 / Math.PI);
            if (mean * mean / (variance + 8 / Math.PI) < 2e-20 * Math.PI)
            {
                double deriv = LogisticGaussianDerivative(mean, variance);
                return 0.5 + mean * deriv;
            }

            // Handle tail cases using the following exact formulas:
            // sigma(m,v) = 1 - exp(-m+v/2) + exp(-2m+2v) - exp(-3m+9v/2) sigma(m-3v,v)
            if (-mean + variance < logEpsilon)
                return 1.0 - Math.Exp(halfVariance - mean);
            if (-3 * mean + 9 * halfVariance < logEpsilon)
                return 1.0 - Math.Exp(halfVariance - mean) + Math.Exp(2 * (variance - mean));
            // sigma(m,v) = exp(m+v/2) - exp(2m+2v) + exp(3m + 9v/2) (1 - sigma(m+3v,v))
            if (mean + 1.5 * variance < logEpsilon)
                return Math.Exp(mean + halfVariance);
            if (2 * mean + 4 * variance < logEpsilon)
                return Math.Exp(mean + halfVariance) * (1 - Math.Exp(mean + 1.5 * variance));

            if (variance > LogisticGaussianVarianceThreshold)
            {
                double f(double x)
                {
                    return Math.Exp(MMath.LogisticLn(x) + Gaussian.GetLogProb(x, mean, variance));
                }
                double upperBound = mean + Math.Sqrt(variance);
                upperBound = Math.Max(upperBound, 10);
                return Quadrature.AdaptiveClenshawCurtis(f, upperBound, 32, 1e-10);
            }
            else
            {
                Vector nodes = Vector.Zero(LogisticGaussianQuadratureNodeCount);
                Vector weights = Vector.Zero(LogisticGaussianQuadratureNodeCount);
                double m_p, v_p;
                BigvProposal(mean, variance, out m_p, out v_p);
                Quadrature.GaussianNodesAndWeights(m_p, v_p, nodes, weights);
                double weightedIntegrand(double z)
                {
                    return Math.Exp(MMath.LogisticLn(z) + Gaussian.GetLogProb(z, mean, variance) - Gaussian.GetLogProb(z, m_p, v_p));
                }
                return Integrate(weightedIntegrand, nodes, weights);
            }

        }


        /// <summary>
        /// Calculate <c>\sigma'(m,v)=\int N(x;m,v)logistic'(x) dx</c>
        /// </summary>
        /// <param name="mean">Mean.</param>
        /// <param name="variance">Variance.</param>
        /// <returns>The value of this special function.</returns>
        /// <remarks><para>
        /// For large v we can use the big v approximation <c>\sigma'(m,v)=N(m,0,v+pi^2/3)</c>.
        /// For small and moderate v we use Gauss-Hermite quadrature.
        /// For moderate v we first find the mode of the (log concave) function since this may be quite far from m.
        /// </para></remarks>
        public static double LogisticGaussianDerivative(double mean, double variance)
        {
            double halfVariance = 0.5 * variance;
            mean = Math.Abs(mean);

            // use the upper bound exp(-|m|+v/2) to prune cases that must be zero
            if (-mean + halfVariance < log0)
                return 0.0;

            // use the upper bound 0.5 exp(-0.5 m^2/v) to prune cases that must be zero
            double q = -0.5 * mean * mean / variance - MMath.Ln2;
            if (mean <= variance && q < log0)
                return 0.0;
            if (double.IsPositiveInfinity(variance))
                return 0.0;

            // Handle the tail cases using the following exact formula:
            // sigma'(m,v) = exp(-m+v/2) -2 exp(-2m+2v) +3 exp(-3m+9v/2) sigma(m-3v,v) - exp(-3m+9v/2) sigma'(m-3v,v)
            if (-mean + 1.5 * variance < logEpsilon)
                return Math.Exp(halfVariance - mean);
            if (-2 * mean + 4 * variance < logEpsilon)
                return Math.Exp(halfVariance - mean) - 2 * Math.Exp(2 * (variance - mean));

            if (variance > LogisticGaussianVarianceThreshold)
            {
                double f(double x)
                {
                    return Math.Exp(MMath.LogisticLn(x) + MMath.LogisticLn(-x) + Gaussian.GetLogProb(x, mean, variance));
                }
                return Quadrature.AdaptiveClenshawCurtis(f, 10, 32, 1e-10);
            }
            else
            {
                Vector nodes = Vector.Zero(LogisticGaussianQuadratureNodeCount);
                Vector weights = Vector.Zero(LogisticGaussianQuadratureNodeCount);
                double m_p, v_p;
                BigvProposal(mean, variance, out m_p, out v_p);
                Quadrature.GaussianNodesAndWeights(m_p, v_p, nodes, weights);
                double weightedIntegrand(double z)
                {
                    return Math.Exp(MMath.LogisticLn(z) + MMath.LogisticLn(-z) + Gaussian.GetLogProb(z, mean, variance) - Gaussian.GetLogProb(z, m_p, v_p));
                }
                return Integrate(weightedIntegrand, nodes, weights);
            }

        }

        /// <summary>
        /// Calculate <c>\sigma''(m,v)=\int N(x;m,v)logistic''(x) dx</c>
        /// </summary>
        /// <param name="mean">Mean.</param>
        /// <param name="variance">Variance.</param>
        /// <returns>The value of this special function.</returns>
        /// <remarks><para>
        /// For large v we can use the big v approximation <c>\sigma'(m,v)=-m/(v+pi^2/3)*N(m,0,v+pi^2/3)</c>.
        /// For small and moderate v we use Gauss-Hermite quadrature.
        /// The function is multimodal so mode finding is difficult and probably won't help.
        /// </para></remarks>
        public static double LogisticGaussianDerivative2(double mean, double variance)
        {
            if (double.IsPositiveInfinity(variance))
                return 0.0;
            if (mean == 0)
                return 0;

            double halfVariance = 0.5 * variance;

            // use the upper bound exp(-|m|+v/2) to prune cases that must be zero
            if (-Math.Abs(mean) + halfVariance < log0)
                return 0.0;

            // use the upper bound 0.5 exp(-0.5 m^2/v) to prune cases that must be zero
            double q = -0.5 * mean * mean / variance - MMath.Ln2;
            if (Math.Abs(mean) <= variance && q < log0)
                return 0.0;

            // Handle the tail cases using the following exact formulas:
            // sigma''(m,v) = -exp(-m+v/2) +4 exp(-2m+2v) -9 exp(-3m+9v/2) sigma(m-3v,v) +6 exp(-3m+9v/2) sigma'(m-3v,v) - exp(-3m+9v/2) sigma''(m-3v,v)
            if (-mean + 1.5 * variance < logEpsilon)
                return -Math.Exp(halfVariance - mean);
            if (-2 * mean + 4 * variance < logEpsilon)
                return -Math.Exp(halfVariance - mean) + 4 * Math.Exp(2 * (variance - mean));
            // sigma''(m,v) = exp(m+v/2) -4 exp(2m+2v) +9 exp(3m + 9v/2) (1 - sigma(m+3v,v)) - 6 exp(3m+9v/2) sigma'(m+3v,v) - exp(3m + 9v/2) sigma''(m+3v,v)
            if (mean + 1.5 * variance < logEpsilon)
                return Math.Exp(mean + halfVariance);
            if (2 * mean + 4 * variance < logEpsilon)
                return Math.Exp(mean + halfVariance) * (1 - 4 * Math.Exp(mean + 1.5 * variance));

            if (variance > LogisticGaussianVarianceThreshold)
            {
                double f(double x)
                {
                    double logSigma = MMath.LogisticLn(x);
                    double log1MinusSigma = MMath.LogisticLn(-x);
                    double OneMinus2Sigma = -Math.Tanh(x / 2);
                    return OneMinus2Sigma * Math.Exp(logSigma + log1MinusSigma + Gaussian.GetLogProb(x, mean, variance));
                }
                return Quadrature.AdaptiveClenshawCurtis(f, 10, 32, 1e-10);
            }
            else
            {
                Vector nodes = Vector.Zero(LogisticGaussianQuadratureNodeCount);
                Vector weights = Vector.Zero(LogisticGaussianQuadratureNodeCount);
                double m_p, v_p;
                BigvProposal(mean, variance, out m_p, out v_p);
                Quadrature.GaussianNodesAndWeights(m_p, v_p, nodes, weights);
                double weightedIntegrand(double z)
                {
                    double logSigma = MMath.LogisticLn(z);
                    double log1MinusSigma = MMath.LogisticLn(-z);
                    double OneMinus2Sigma = -Math.Tanh(z / 2);
                    return OneMinus2Sigma * Math.Exp(logSigma + log1MinusSigma + Gaussian.GetLogProb(z, mean, variance) - Gaussian.GetLogProb(z, m_p, v_p));
                }
                return Integrate(weightedIntegrand, nodes, weights);
            }
        }
    }

}