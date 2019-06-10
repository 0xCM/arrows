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
        /// Computes the complementary error function. This function is defined by 2/sqrt(pi) * integral from x to infinity of exp (-t^2) dt.
        /// </summary>
        /// <param name="x">Any real value.</param>
        /// <returns>The complementary error function at x.</returns>
        public static double Erfc(double x)
        {
            return 2 * NormalCdf(-MMath.Sqrt2 * x);
        }

        /// <summary>
        /// Computes the inverse of the complementary error function, i.e.
        /// <c>erfcinv(erfc(x)) == x</c>.
        /// </summary>
        /// <param name="y">A real number between 0 and 2.</param>
        /// <returns>A number x such that <c>erfc(x) == y</c>.</returns>
        public static double ErfcInv(double y)
        {
            const double small = 0.0485, large = 1.9515;
            // check for boundary cases
            if (y < 0 || y > 2)
                throw new ArgumentOutOfRangeException(nameof(y),
                                                      y,
                                                      "function not defined outside [0,2].");

            if (y == 0)
                return double.PositiveInfinity;
            else if (y == 1)
                return 0.0;
            else if (y == 2)
                return double.NegativeInfinity;

            // stores the result
            double x = 0.0;

            // This function uses a polynomial approximation followed by a few steps of Halley's rational method.
            // Origin: unknown

            // Rational approximation for the central region
            if (y >= small && y <= large)
            {
                double q = y - 1.0;
                double r = q * q;
                x = (((((0.01370600482778535 * r - 0.3051415712357203) * r + 1.524304069216834) * r - 3.057303267970988) * r + 2.710410832036097) * r - 0.8862269264526915) * q /
                    (((((-0.05319931523264068 * r + 0.6311946752267222) * r - 2.432796560310728) * r + 4.175081992982483) * r - 3.320170388221430) * r + 1.0);
            }
            // Rational approximation for the lower region
            else if (y < small)
            {
                double q = Math.Sqrt(-2.0 * Math.Log(y / 2.0));
                x = (((((0.005504751339936943 * q + 0.2279687217114118) * q + 1.697592457770869) * q + 1.802933168781950) * q + -3.093354679843504) * q - 2.077595676404383) /
                    ((((0.007784695709041462 * q + 0.3224671290700398) * q + 2.445134137142996) * q + 3.754408661907416) * q + 1.0);
            }
            // Rational approximation for the upper region
            else if (y > large)
            {
                double q = Math.Sqrt(-2.0 * Math.Log(1 - y / 2.0));
                x = -(((((0.005504751339936943 * q + 0.2279687217114118) * q + 1.697592457770869) * q + 1.802933168781950) * q + -3.093354679843504) * q - 2.077595676404383) /
                    ((((0.007784695709041462 * q + 0.3224671290700398) * q + 2.445134137142996) * q + 3.754408661907416) * q + 1.0);
            }

            // Iterate Halley's rational method to increase precision (but only up to the precision of Erfc)
            for (int iter = 0; iter < 4; iter++)
            {
                double oldx = x;
                double u = (Erfc(x) - y) / (-2.0 / Math.Sqrt(Math.PI) * Math.Exp(-x * x));
                x = x - u / (1.0 + x * u);
                if (AreEqual(x, oldx))
                    break;
            }

            // done!
            return x;
        }

        /// <summary>
        /// Computes <c>NormalCdf(x)/N(x;0,1)</c> to high accuracy.
        /// </summary>
        /// <param name="x">Any real number.</param>
        /// <returns></returns>
        public static double NormalCdfRatio(double x)
        {
            if (x > 0)
            {
                return Sqrt2PI * Math.Exp(0.5 * x * x) - NormalCdfRatio(-x);
            }
            else if (x > -6)
            {
                // Taylor expansion
                // works only for |x| < 17
                Assert.IsTrue(x > -17);
                Assert.IsTrue(x <= 0);
                int j = (int)(-x + 0.5);
                if (j >= c_normcdf_table.Length)
                    j = c_normcdf_table.Length - 1;
                double y = c_normcdf_table[j];
                return y + NormalCdfRatioDiff_Simple(-j, x + j, y);
            }
            else
            {
                if (double.IsNaN(x))
                    return x;
                Assert.IsTrue(x <= -6);
                double invX = 1 / x;
                double invX2 = invX * invX;
                // Continued fraction approach
                // can also be used for x > -6, but prohibitively many terms would be required.
                double numer = -invX;
                double numerPrev = 0;
                double denom = 1;
                double denomPrev = 1;
                double a = invX2;
                int n;
                if (x < -80)
                    n = 5;
                else if (x < -15)
                    n = 10;
                else
                    n = 20;
                for (int i = 1; i < n; i++)
                {
                    double numerNew = numer + a * numerPrev;
                    double denomNew = denom + a * denomPrev;
                    a += invX2;
                    numerPrev = numer;
                    numer = numerNew;
                    denomPrev = denom;
                    denom = denomNew;
                }
                return numer / denom;
            }
        }

        /// <summary>
        /// Computes <c>NormalCdfRatio(x+delta)-NormalCdfRatio(x)</c> given <c>NormalCdfRatio(x)</c>.
        /// Is inaccurate for x &lt; -17.  For more accuracy, use NormalCdfRatioDiff.
        /// </summary>
        /// <param name="x">Any real number</param>
        /// <param name="delta">A real number with absolute value less than or equal to 0.5</param>
        /// <param name="y">NormalCdfRatio(x)</param>
        /// <returns></returns>
        private static double NormalCdfRatioDiff_Simple(double x, double delta, double y)
        {
            if (Math.Abs(delta) > 0.5)
                throw new ArgumentException("delta > 0.5");
            // Algorithm: Taylor expansion of NormalCdfRatio based on upward recurrence.
            // Based on Marsaglia's algorithm for cPhi.
            // Reference:
            // "Evaluating the Normal Distribution"
            // Journal of Statistical Software
            // Volume 11, 2004, Issue 5  
            // http://www.jstatsoft.org/v11/i05
            // Reven = deriv(R,i)(z)/i! for even i
            // Rodd = deriv(R,i+1)(z)/(i+1)! for even i
            // deriv(R,i+2)(z) = z*deriv(R,i+1)(z) + (i+1)*deriv(R,i)(z)
            // deriv(R,i+2)(z)/(i+2)! = (z*deriv(R,i+1)(z)/(i+1)! + deriv(R,i)(z)/i!)/(i+2)
            double Reven = y;
            double Rodd = Reven * x + 1;
            double delta2 = delta * delta;
            double sum = delta * Rodd;
            double oldSum = 0;
            double pwr = 1;
            for (int i = 2; i < 1000; i += 2)
            {
                Reven = (Reven + x * Rodd) / i;
                Rodd = (Rodd + x * Reven) / (i + 1);
                pwr *= delta2;
                oldSum = sum;
                sum += pwr * (Reven + delta * Rodd);
                if (AreEqual(sum, oldSum)) break;
            }
            return sum;
        }

        /// <summary>
        /// Computes <c>NormalCdfRatio(x+delta)-NormalCdfRatio(x)</c> 
        /// </summary>
        /// <param name="x">Any real number</param>
        /// <param name="delta">A finite real number with absolute value less than 9.9, or less than 70% of the absolute value of x.</param>
        /// <param name="startingIndex">The first moment to use in the power series.  Used to skip leading terms.  For example, 2 will skip NormalCdfMomentRatio(1, x).</param>
        /// <returns></returns>
        public static double NormalCdfRatioDiff(double x, double delta, int startingIndex = 1)
        {
            if (startingIndex < 1) throw new ArgumentOutOfRangeException(nameof(startingIndex), "startingIndex < 1");
            if (double.IsInfinity(delta)) throw new ArgumentOutOfRangeException(nameof(delta), "delta is infinite");
            // This code is adapted from NormalCdfMomentRatioTaylor
            double sum = 0;
            double term = delta;
            var iter = NormalCdfMomentRatioSequence(startingIndex, x);
            for (int i = 0; i < 1000; i++)
            {
                double sumOld = sum;
                iter.MoveNext();
                double deriv = iter.Current;
                if (deriv == 0 || term == 0) return sum;
                sum += deriv * term;
                if (double.IsNaN(sum)) throw new Exception();
                //Console.WriteLine("{0}: {1}", i, sum);
                if (AreEqual(sum, sumOld)) return sum;
                term *= delta;
            }
            throw new Exception($"Not converging for x={x}, delta={delta}");
        }

        /// <summary>
        /// Computes <c>NormalCdfMomentRatio(n, x+delta)-NormalCdfMomentRatio(n, x)</c>
        /// </summary>
        /// <param name="n">A non-negative integer</param>
        /// <param name="x">Any real number</param>
        /// <param name="delta">A finite real number with absolute value less than 9.9, or less than 70% of the absolute value of x.</param>
        /// <param name="startingIndex">The first moment to use in the power series.  Used to skip leading terms.  For example, 2 will skip NormalCdfMomentRatio(n+1, x).</param>
        /// <returns></returns>
        public static double NormalCdfMomentRatioDiff(int n, double x, double delta, int startingIndex = 1)
        {
            if (n < 0) throw new ArgumentOutOfRangeException(nameof(n), "n < 0");
            if (startingIndex < 1) throw new ArgumentOutOfRangeException(nameof(startingIndex), "startingIndex < 1");
            if (double.IsInfinity(delta)) throw new ArgumentOutOfRangeException(nameof(delta), "delta is infinite");
            // n=1: delta*2!/1!*R(2,x) + delta^2*3!/2!*R(3,x) + ...
            // n=2: delta*3!/1!*R(3,x) + delta^2*4!/2!*R(4,x) + ...
            double sum = 0;
            double term = delta * Gamma(n + 1 + startingIndex) / Gamma(1 + startingIndex);
            var iter = NormalCdfMomentRatioSequence(n + startingIndex, x);
            for (int i = startingIndex - 1; i < 1000; i++)
            {
                double sumOld = sum;
                iter.MoveNext();
                double deriv = iter.Current;
                if (deriv == 0 || term == 0) return sum;
                sum += deriv * term;
                //Console.WriteLine("{0}: {1}", i, sum);
                if (AreEqual(sum, sumOld))
                    return sum;
                term *= delta * (n + i + 2) / (i + 2);
            }
            throw new Exception($"Not converging for n={n}, x={x}, delta={delta}");
        }

        /// <summary>
        /// Computes the cumulative Gaussian distribution, defined as the
        /// integral from -infinity to x of N(t;0,1) dt.  
        /// For example, <c>NormalCdf(0) == 0.5</c>.
        /// </summary>
        /// <param name="x">Any real number.</param>
        /// <returns>The cumulative Gaussian distribution at <paramref name="x"/>.</returns>
        public static double NormalCdf(double x)
        {
            if (double.IsNaN(x))
                return x;
            else if (x > 10)
                return 1.0;
            else if (x < -40)
                return 0.0;
            else if (false && x > -4)
            {
                // Marsaglia's algorithm:
                // NormalCdf(x) = 0.5 + exp(-x^2/2)/sqrt(2*pi)*s
                // where s = x + x^3/3 + x^5/(3*5) + x^7/(3*5*7) + ...
                // http://www.jstatsoft.org/v11/i04/v11i04.pdf
                // Not accurate for x < -4 or x > 10.
                Assert.IsTrue(x >= -4);
                Assert.IsTrue(x <= 10);
                double s = x, t = 0, b = x, x2 = x * x;
                //int count = 0;
                for (int i = 3; s != t; i += 2)
                {
                    t = s;
                    b *= x2 / i;
                    s += b;
                    //count++;
                }
                //Console.WriteLine("count = {0}", count);
                double result = .5 + s * Math.Exp(-.5 * x2) * InvSqrt2PI;
                if (result < 0)
                    result = 0.0;
                else if (result > 1)
                    result = 1.0;
                return result;
            }
            else if (x > 0)
            {
                return 1 - NormalCdf(-x);
            }
            else
            {
                // we could use GammaUpper to compute this via:
                // return 0.5 * GammaUpper(0.5, x * x / 2);
                // however, this is less accurate because GammaUpper uses the Gamma function 
                // which only gets 14 digits of accuracy.
                double s = NormalCdfRatio(x);
                s *= Math.Exp(-0.5 * x * x) / Sqrt2PI;
                return s;
            }
        }

        /// <summary>
        /// The natural logarithm of the cumulative Gaussian distribution.
        /// </summary>
        /// <param name="x">Any real number.</param>
        /// <returns>ln(NormalCdf(x)).</returns>
        /// <remarks>This function provides higher accuracy than <c>Math.Log(NormalCdf(x))</c>, which can fail for x &lt; -7.</remarks>
        public static double NormalCdfLn(double x)
        {
            const double large = -8;
            if (x > 4)
            {
                // log(NormalCdf(x)) = log(1-NormalCdf(-x))
                double y = NormalCdf(-x);
                // log(1-y)
                return -y * (1 + y * (0.5 + y * (1.0 / 3 + y * (0.25))));
            }
            else if (x >= large)
            {
                return Math.Log(NormalCdf(x));
            }
            else
            {
                // x < large
                double z = 1 / (x * x);
                // asymptotic series for log(normcdf)
                // Maple command: subs(x=-x,asympt(log(normcdf(-x)),x));
                double s = z * (c_normcdfln_series[0] + z *
                              (c_normcdfln_series[1] + z *
                               (c_normcdfln_series[2] + z *
                                (c_normcdfln_series[3] + z *
                                 (c_normcdfln_series[4] + z *
                                  (c_normcdfln_series[5] + z *
                                   c_normcdfln_series[6]))))));
                return s - LnSqrt2PI - 0.5 * x * x - Math.Log(-x);
            }
        }

        /// <summary>
        /// The log-odds of the cumulative Gaussian distribution.
        /// </summary>
        /// <param name="x">Any real number.</param>
        /// <returns>ln(NormalCdf(x)/(1-NormalCdf(x))).</returns>
        public static double NormalCdfLogit(double x)
        {
            return NormalCdfLn(x) - NormalCdfLn(-x);
        }

        /// <summary>
        /// Computes the inverse of the cumulative Gaussian distribution,
        /// i.e. <c>NormalCdf(NormalCdfInv(p)) == p</c>.
        /// For example, <c>NormalCdfInv(0.5) == 0</c>.
        /// This is also known as the Gaussian quantile function.  
        /// </summary>
        /// <param name="p">A real number in [0,1].</param>
        /// <returns>A number x such that <c>NormalCdf(x) == p</c>.</returns>
        public static double NormalCdfInv(double p)
        {
            return -Sqrt2 * ErfcInv(2 * p);
        }

    }

}