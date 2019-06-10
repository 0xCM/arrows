// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Linq;
using System;
//using Microsoft.ML.Probabilistic.Utilities;
//using Microsoft.ML.Probabilistic.Distributions; // for Gaussian.GetLogProb
namespace MsInfer
{
    public static class Assert
    {
        public static bool IsTrue(bool condition)
            => condition ? true : throw new Exception();

        public static bool IsTrue(bool condition, string msg)
            => condition ? true : throw new Exception(msg);

    }

    public static class Beta
    {
        /// <summary>
        /// Computes the log Beta function: <c>GammaLn(trueCount)+GammaLn(falseCount)-GammaLn(trueCount+falseCount)</c>.
        /// </summary>
        /// <param name="trueCount">Any real number.</param>
        /// <param name="falseCount">Any real number.</param>
        /// <returns><c>GammaLn(trueCount)+GammaLn(falseCount)-GammaLn(trueCount+falseCount)</c></returns>
        /// <remarks>
        /// If trueCount &lt;= 0 or falseCount &lt;= 0, the result is defined to be 0.
        /// </remarks>
        public static double BetaLn(double trueCount, double falseCount)
        {
            if (trueCount <= 0.0 || falseCount <= 0.0) return 0.0;
            double totalCount = trueCount + falseCount;
            return MMath.GammaLn(trueCount) + MMath.GammaLn(falseCount) - MMath.GammaLn(totalCount);
        }

    }
    public static class Gaussian
    {
        /// <summary>
        /// Evaluates the log of one-dimensional Gaussian density.
        /// </summary>
        /// <param name="x">Must be finite.</param>
        /// <param name="mean">Must be finite.</param>
        /// <param name="variance">Any real number.  May be zero or negative.</param>
        /// <remarks>
        /// <c>N(x;m,v) = 1/sqrt(2*pi*v) * exp(-(x-m)^2/(2v))</c>.
        /// When v=0, this reduces to delta(x-m).
        /// When v=infinity, the density is redefined to be 1.
        /// When v &lt; 0, the density is redefined to be <c>exp(-0.5*x^2*(1/v) + x*(m/v))</c>, 
        /// i.e. we drop the terms <c>exp(-m^2/(2v))/sqrt(2*pi*v)</c>.
        /// </remarks>
        /// <returns><c>log(N(x;mean,variance))</c></returns>
        public static double GetLogProb(double x, double mean, double variance)
        {
            if (variance == 0) return (x == mean) ? 0.0 : Double.NegativeInfinity;
            else if (Double.IsPositiveInfinity(variance)) return 0.0;
            else
            {
                if (variance > 0)
                {
                    double diff = x - mean;
                    return -0.5 * (System.Math.Log(variance) + diff * diff / variance) - MMath.LnSqrt2PI;
                }
                else
                {
                    return (mean - 0.5 * x) * x / variance;
                }
            }
        }


    }
}