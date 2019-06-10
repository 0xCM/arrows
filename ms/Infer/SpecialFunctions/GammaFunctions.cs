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
        /// The Euler-Mascheroni Constant.
        /// </summary>
        public const double EulerGamma = 0.57721566490153286060651209;

        /// <summary>
        /// Digamma(1)
        /// </summary>
        public const double Digamma1 = -EulerGamma;



        /// <summary>
        /// Evaluates Gamma(x), defined as the integral from 0 to x of t^(x-1)*exp(-t) dt.
        /// </summary>
        /// <param name="x">Any real value.</param>
        /// <returns>Gamma(x).</returns>
        public static double Gamma(double x)
        {
            /* Negative values */
            if (x < 0)
            {
                // this test also catches -inf
                if (Math.Floor(x) == x)
                {
                    return Double.NaN;
                }

                // Gamma(z)*Gamma(-z) = -pi/z/sin(pi*z)
                return -Math.PI / (x * Math.Sin(Math.PI * x) * Gamma(-x));
            }

            if (x > 180)
            {
                return Double.PositiveInfinity;
            }

            return Math.Exp(GammaLn(x));
        }

        /// <summary>
        /// Computes the natural logarithm of the Gamma function.
        /// </summary>
        /// <param name="x">A real value >= 0.</param>
        /// <returns>ln(Gamma(x)).</returns>
        /// <remarks>This function provides higher accuracy than <c>Math.Log(Gamma(x))</c>, which may fail for large x.</remarks>
        public static double GammaLn(double x)
        {
            if (Double.IsPositiveInfinity(x) || (x == 0))
            {
                return Double.PositiveInfinity;
            }

            /* Negative values */
            if (x < 0)
            {
                // answer might be complex
                return Double.NaN;
            }

            if (x < 6)
            {
                double result = 0;
                while (x < 1.5)
                {
                    result -= Math.Log(x);
                    x++;
                }
                while (x > 2.5)
                {
                    x--;
                    result += Math.Log(x);
                }
                // 1.5 <= x <= 2.5
                // Use Taylor series at x=2
                // Reference: https://dlmf.nist.gov/5.7#E3
                double dx = x - 2;
                double sum = 0;
                for (int i = gammaTaylorCoefficients.Length - 1; i >= 0; i--)
                {
                    sum = dx * (gammaTaylorCoefficients[i] + sum);
                }
                sum = dx * (1 + Digamma1 + sum);
                result += sum;
                return result;
            }
            else // x >= 6
            {
                double sum = LnSqrt2PI;
                while (x < 10)
                {
                    sum -= Math.Log(x);
                    x++;
                }
                // x >= 10
                // Use asymptotic series
                return GammaLnSeries(x) + (x - 0.5) * Math.Log(x) - x + sum;
            }
        }

        /// <summary>
        /// Evaluates Digamma(x), the derivative of ln(Gamma(x)).
        /// </summary>
        /// <param name="x">Any real value.</param>
        /// <returns>Digamma(x).</returns>
        public static double Digamma(double x)
        {
            /* Negative values */
            /* Use the reflection formula (Jeffrey 11.1.6):
             * digamma(-x) = digamma(x+1) + pi*cot(pi*x)
             *
             * This is related to the identity
             * digamma(-x) = digamma(x+1) - digamma(z) + digamma(1-z)
             * where z is the fractional part of x
             * For example:
             * digamma(-3.1) = 1/3.1 + 1/2.1 + 1/1.1 + 1/0.1 + digamma(1-0.1)
             *                 = digamma(4.1) - digamma(0.1) + digamma(1-0.1)
             * Then we use
             * digamma(1-z) - digamma(z) = pi*cot(pi*z)
             */
            if (x < 0)
            {
                // this test also catches -inf
                if (Math.Floor(x) == x)
                {
                    return Double.NaN;
                }

                return (Digamma(1 - x) - Math.PI / Math.Tan(Math.PI * x));
            }

            /* Lookup table for when x is an integer */
            const int tableLength = 100;
            int xAsInt = (int)x;
            if ((xAsInt == x) && (xAsInt < tableLength))
            {
                if (DigammaLookup == null)
                {
                    double[] table = new double[tableLength];
                    table[0] = double.NegativeInfinity;
                    table[1] = Digamma1;
                    for (int i = 2; i < table.Length; i++)
                        table[i] = table[i - 1] + 1.0 / (i - 1);
                    // This is thread-safe because read/write to a reference type is atomic. See
                    // http://msdn.microsoft.com/en-us/library/aa691278%28VS.71%29.aspx
                    DigammaLookup = table;
                }
                return DigammaLookup[xAsInt];
            }

            // The threshold for applying de Moivre's expansion for the digamma function.
            const double c_digamma_small = 1e-6;

            /* Use Taylor series if argument <= S */
            if (x <= c_digamma_small)
            {
                return (Digamma1 - 1 / x + Zeta2 * x);
            }

            if (x <= 2.5)
            {
                double result2 = 1 + Digamma1;
                while (x < 1.5)
                {
                    result2 -= 1 / x;
                    x++;
                }
                double dx = x - 2;
                double sum2 = 0;
                for (int i = gammaTaylorCoefficients.Length - 1; i >= 0; i--)
                {
                    sum2 = dx * (gammaTaylorCoefficients[i] * (i + 2) + sum2);
                }
                result2 += sum2;
                return result2;
            }

            const double c_digamma_large = 8;

            /* Reduce to digamma(X + N) where (X + N) >= C */
            double result = 0;
            while (x < c_digamma_large)
            {
                result -= 1 / x;
                ++x;
            }

            /* X >= L. Use de Moivre's expansion. */
            // This expansion can be computed in Maple via asympt(Psi(x),x)
            double invX = 1 / x;
            result += Math.Log(x) - 0.5 * invX;
            double invX2 = invX * invX;
            double sum = 0;
            for (int i = c_digamma_series.Length - 1; i >= 0; i--)
            {
                sum = invX2 * (c_digamma_series[i] + sum);
            }
            result -= sum;
            return result;
        }

        /// <summary>
        /// Second derivative of the natural logarithm of the multivariate Gamma function.
        /// </summary>
        /// <param name="x">A real value >= 0</param>
        /// <param name="d">The dimension, an integer > 0</param>
        /// <returns>trigamma_d(x)</returns>
        public static double Trigamma(double x, double d)
        {
            double result = 0;
            for (int i = 0; i < d; i++)
            {
                result += Trigamma(x - 0.5 * i);
            }
            return result;
        }

        /// <summary>
        /// Evaluates the natural logarithm of Gamma(n+1)/(Gamma(k+1)*Gamma(n-k+1))
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static double ChooseLn(double n, double k)
        {
            if (k < 0 || k > n)
                return Double.NegativeInfinity;
            return GammaLn(n + 1) - GammaLn(k + 1) - GammaLn(n - k + 1);
        }

        /// <summary>
        /// Evaluates the natural logarithm of Gamma(n+1)/(prod_i Gamma(k[i]+1))
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static double ChooseLn(double n, double[] k)
        {
            double result = GammaLn(n + 1);
            for (int i = 0; i < k.Length; i++)
            {
                result -= GammaLn(k[i] + 1);
            }
            return result;
        }

        /// <summary>
        /// Compute the regularized upper incomplete Gamma function: int_x^inf t^(a-1) exp(-t) dt / Gamma(a)
        /// </summary>
        /// <param name="a">The shape parameter, &gt; 0</param>
        /// <param name="x">The lower bound of the integral, &gt;= 0</param>
        /// <returns></returns>
        public static double GammaUpper(double a, double x)
        {
            // special cases:
            // GammaUpper(1,x) = exp(-x)
            // GammaUpper(a,0) = 1
            // GammaUpper(a,x) = GammaUpper(a-1,x) + x^(a-1) exp(-x) / Gamma(a)
            if (x < 0)
                throw new ArgumentException($"x ({x}) < 0");
            if (a <= 0)
                throw new ArgumentException($"a ({a}) <= 0");
            if (x == 0) return 1; // avoid 0/0
            // Use the criterion from Gautschi (1979) to determine whether GammaLower(a,x) or GammaUpper(a,x) is smaller.
            // useLower = true means that GammaLower is smaller.
            bool useLower;
            if (x > 0.25)
                useLower = (a > x + 0.25);
            else
                useLower = (a > -MMath.Ln2 / Math.Log(x));
            if (useLower)
            {
                if (x < 0.5 * a + 67)
                    return 1 - GammaLowerSeries(a, x);
                else // x > 67, a > 67, a > x + 0.25
                    return GammaAsympt(a, x, true);
            }
            else if ((a > 20) && x < 2.35 * a)
                return GammaAsympt(a, x, true);
            else if (x > 1.5)
                return GammaUpperConFrac(a, x);
            else
                return GammaUpperSeries(a, x);
        }

        /// <summary>
        /// Computes <c>1/Gamma(x+1) - 1</c> to high accuracy
        /// </summary>
        /// <param name="x">A real number &gt;= 0</param>
        /// <returns></returns>
        public static double ReciprocalFactorialMinus1(double x)
        {
            if (x > 0.3)
                return 1 / MMath.Gamma(x + 1) - 1;
            double sum = 0;
            double term = x;
            for (int i = 0; i < reciprocalFactorialMinus1Coeffs.Length; i++)
            {
                sum += reciprocalFactorialMinus1Coeffs[i] * term;
                term *= x;
            }
            return sum;
        }

        // Origin: James McCaffrey, http://msdn.microsoft.com/en-us/magazine/dn520240.aspx
        /// <summary>
        /// Compute the regularized lower incomplete Gamma function: int_0^x t^(a-1) exp(-t) dt / Gamma(a)
        /// </summary>
        /// <param name="a">The shape parameter, &gt; 0</param>
        /// <param name="x">The upper bound of the integral, &gt;= 0</param>
        /// <returns></returns>
        public static double GammaLower(double a, double x)
        {
            if (x < 0)
                throw new ArgumentException($"x ({x}) < 0");
            if (a <= 0)
                throw new ArgumentException($"a ({a}) <= 0");
            if (x == 0) return 0; // avoid 0/0
            // Use the criterion from Gautschi (1979) to determine whether GammaLower(a,x) or GammaUpper(a,x) is smaller.
            // useLower = true means that GammaLower is smaller.
            bool useLower;
            if (x > 0.25)
                useLower = (a > x + 0.25);
            else
                useLower = (a > -MMath.Ln2 / Math.Log(x));
            if (useLower)
            {
                if (x < 0.5 * a + 67)
                    return GammaLowerSeries(a, x);
                else // x > 67, a > 67, a > x + 0.25
                    return GammaAsympt(a, x, false);
            }
            else if ((a > 20) && x < 2.35 * a)
                return GammaAsympt(a, x, false);
            else if (x > 1.5)
                return 1 - GammaUpperConFrac(a, x);
            else
                return 1 - GammaUpperSeries(a, x);
        }

        /// <summary>
        /// Computes the natural logarithm of the multivariate Gamma function.
        /// </summary>
        /// <param name="x">A real value >= 0.</param>
        /// <param name="d">The dimension, an integer > 0.</param>
        /// <returns>ln(Gamma_d(x))</returns>
        /// <remarks>The <a href="http://en.wikipedia.org/wiki/Multivariate_gamma_function">multivariate Gamma function</a> 
        /// is defined as Gamma_d(x) = pi^(d*(d-1)/4)*prod_(i=1..d) Gamma(x + (1-i)/2)</remarks>
        public static double GammaLn(double x, double d)
        {
            double result = d * (d - 1) / 4 * LnPI;
            for (int i = 0; i < d; i++)
            {
                result += GammaLn(x - 0.5 * i);
            }
            return result;
        }

        /// <summary>
        /// Derivative of the natural logarithm of the multivariate Gamma function.
        /// </summary>
        /// <param name="x">A real value >= 0</param>
        /// <param name="d">The dimension, an integer > 0</param>
        /// <returns>digamma_d(x)</returns>
        public static double Digamma(double x, double d)
        {
            double result = 0;
            for (int i = 0; i < d; i++)
            {
                result += Digamma(x - 0.5 * i);
            }
            return result;
        }


        /// <summary>
        /// Evaluates Trigamma(x), the derivative of Digamma(x).
        /// </summary>
        /// <param name="x">Any real value.</param>
        /// <returns>Trigamma(x).</returns>
        public static double Trigamma(double x)
        {
            double result;

            /* Negative values */
            /* Use the derivative of the digamma reflection formula:
             * -trigamma(-x) = trigamma(x+1) - (pi*csc(pi*x))^2
             */
            if (x < 0)
            {
                // this test also catches -inf
                if (Math.Floor(x) == x)
                {
                    return Double.NaN;
                }

                result = Math.PI / Math.Sin(Math.PI * x);
                return (-Trigamma(1 - x) + result * result);
            }

            // The threshold for applying de Moivre's expansion for the trigamma function.
            const double c_trigamma_large = 8;
            const double c_trigamma_small = 1e-4;

            /* Use Taylor series if argument <= small */
            if (x <= c_trigamma_small)
            {
                return (1.0 / (x * x) + Zeta2 + M2Zeta3 * x);
            }

            result = 0.0;

            /* Reduce to trigamma(x+n) where ( X + N ) >= L */
            while (x < c_trigamma_large)
            {
                result += 1 / (x * x);
                ++x;
            }

            /* X >= L.    Apply asymptotic formula. */
            // This expansion can be computed in Maple via asympt(Psi(1,x),x)
            double invX2 = 1 / (x * x);
            result += 0.5 * invX2;
            double sum = 0;
            for (int i = c_trigamma_series.Length - 1; i >= 0; i--)
            {
                sum = invX2 * (c_trigamma_series[i] + sum);
            }
            result += (1 + sum) / x;
            return result;
        }


        /// <summary>
        ///  Evaluates Tetragamma, the forth derivative of logGamma(x)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Tetragamma(double x)
        {
            if (x < 0)
                return double.NaN;

            // The threshold for applying de Moivre's expansion for the quadgamma function.
            const double c_tetragamma_large = 12,
                         c_tetragamma_small = 1e-4;
            /* Use Taylor series if argument <= small */
            if (x < c_tetragamma_small)
                return -2 / (x * x * x) + M2Zeta3 + 6 * Zeta4 * x;
            double result = 0;
            /* Reduce to Tetragamma(x+n) where ( X + N ) >= L */
            while (x < c_tetragamma_large)
            {
                result -= 2 / (x * x * x);
                x++;
            }
            /* X >= L.    Apply asymptotic formula. */
            // This expansion can be computed in Maple via asympt(Psi(2,x),x) or found in
            // Milton Abramowitz and Irene A. Stegun, Handbook of Mathematical Functions, Section 6.4
            double invX2 = 1 / (x * x);
            result += -invX2 / x;
            double sum = 0;
            for (int i = c_tetragamma_series.Length - 1; i >= 0; i--)
            {
                sum = invX2 * (c_tetragamma_series[i] + sum);
            }
            result += sum;
            return result;
        }

        /// <summary>
        /// Coefficients of de Moivre's expansion for the quadgamma function.
        /// Each coefficient is -(2j+1) B_{2j} where B_{2j} are the Bernoulli numbers, starting from j=0
        /// </summary>
        private static readonly double[] c_tetragamma_series = { -1, -.5, +1 / 6.0, -1 / 6.0, +3 / 10.0, -5 / 6.0, 691.0 / 210, -35.0 / 2 };

        /// <summary>
        /// Coefficients of de Moivre's expansion for the trigamma function.
        /// Each coefficient is B_{2j} where B_{2j} are the Bernoulli numbers, starting from j=1
        /// </summary>
        private static readonly double[] c_trigamma_series = { 1.0 / 6, -1.0 / 30, 1.0 / 42, -1.0 / 30, 5.0 / 66, -691.0 / 2730, 7.0 / 6, -3617.0 / 510 };

        /// <summary>
        /// Coefficients of de Moivre's expansion for the digamma function.
        /// Each coefficient is B_{2j}/(2j) where B_{2j} are the Bernoulli numbers, starting from j=1
        /// </summary>
        private static readonly double[] c_digamma_series =
        {
            1.0/12, -1.0/120, 1.0/252, -1.0/240, 1.0/132,
            -691.0/32760, 1.0/12, /* -3617.0/8160, 43867.0/14364, -174611.0/6600 */
        };

        // Reference:
        // "Computation of the incomplete gamma function ratios and their inverse"
        // Armido R DiDonato and Alfred H Morris, Jr.   
        // ACM Transactions on Mathematical Software (TOMS)
        // Volume 12 Issue 4, Dec. 1986  
        // http://dl.acm.org/citation.cfm?id=23109
        // and section 8.3 of
        // "Numerical Methods for Special Functions"
        // Amparo Gil, Javier Segura, Nico M. Temme, 2007
        /// <summary>
        /// Compute the regularized lower incomplete Gamma function: <c>int_0^x t^(a-1) exp(-t) dt / Gamma(a)</c>
        /// </summary>
        /// <param name="a">Must be &gt; 20</param>
        /// <param name="x"></param>
        /// <param name="upper">If true, compute the upper incomplete Gamma function</param>
        /// <returns></returns>
        private static double GammaAsympt(double a, double x, bool upper)
        {
            if (a <= 20)
                throw new Exception("a <= 20");
            double xOverAMinus1 = (x - a) / a;
            double phi = xOverAMinus1 - MMath.Log1Plus(xOverAMinus1);
            double y = a * phi;
            double z = Math.Sqrt(2 * phi);
            if (x <= a)
                z *= -1;
            double[] b = new double[GammaLowerAsympt_C0.Length];
            b[b.Length - 1] = GammaLowerAsympt_C0[b.Length - 1];
            double sum = b[b.Length - 1];
            b[b.Length - 2] = GammaLowerAsympt_C0[b.Length - 2];
            sum = z * sum + b[b.Length - 2];
            for (int i = b.Length - 3; i >= 0; i--)
            {
                b[i] = b[i + 2] * (i + 2) / a + GammaLowerAsympt_C0[i];
                sum = z * sum + b[i];
            }
            sum *= a / (a + b[1]);
            if (x <= a)
                sum *= -1;
            double result = 0.5 * Erfc(Math.Sqrt(y)) + sum * Math.Exp(-y) / (Math.Sqrt(a) * MMath.Sqrt2PI);
            return ((x > a) == upper) ? result : 1 - result;
        }

        // Reference: Appendix F of
        // "Computation of the incomplete gamma function ratios and their inverse"
        // Armido R DiDonato and Alfred H Morris, Jr.   
        // ACM Transactions on Mathematical Software (TOMS)
        // Volume 12 Issue 4, Dec. 1986  
        // http://dl.acm.org/citation.cfm?id=23109
        private static double[] GammaLowerAsympt_C0 =
        {
            -.333333333333333333333333333333E+00,
            .833333333333333333333333333333E-01,
            -.148148148148148148148148148148E-01,
            .115740740740740740740740740741E-02,
            .352733686067019400352733686067E-03,
            -.178755144032921810699588477356E-03,
            .391926317852243778169704095630E-04,
            -.218544851067999216147364295512E-05,
            -.185406221071515996070179883623E-05,
            .829671134095308600501624213166E-06,
            -.176659527368260793043600542457E-06,
            .670785354340149858036939710030E-08,
            .102618097842403080425739573227E-07,
            -.438203601845335318655297462245E-08,
            .914769958223679023418248817633E-09,
            -.255141939949462497668779537994E-10,
            -.583077213255042506746408945040E-10,
            .243619480206674162436940696708E-10,
            -.502766928011417558909054985926E-11,
            .110043920319561347708374174497E-12,
            .337176326240098537882769884169E-12,
            -.139238872241816206591936618490E-12,
            .285348938070474432039669099053E-13,
            -.513911183424257261899064580300E-15,
            -.197522882943494428353962401581E-14,
            .809952115670456133407115668703E-15,
            -.165225312163981618191514820265E-15,
            .253054300974788842327061090060E-17,
            .116869397385595765888230876508E-16
        };


        /* Python code to generate this table (must not be indented):
for k in range(2,26):
		print("            %0.20g," % ((-1)**k*(zeta(k)-1)/k))
         */
        private static readonly double[] gammaTaylorCoefficients =
        {
            0.32246703342411320303,
            -0.06735230105319810201,
            0.020580808427784546416,
            -0.0073855510286739856768,
            0.0028905103307415229257,
            -0.0011927539117032610189,
            0.00050966952474304234172,
            -0.00022315475845357938579,
            9.945751278180853098e-05,
            -4.4926236738133142046e-05,
            2.0507212775670691067e-05,
            -9.4394882752683967152e-06,
            4.3748667899074873274e-06,
            -2.0392157538013666132e-06,
            9.551412130407419353e-07,
            -4.4924691987645661855e-07,
            2.1207184805554664645e-07,
            -1.0043224823968100408e-07,
            4.7698101693639803983e-08,
            -2.2711094608943166813e-08,
            1.0838659214896952939e-08,
            -5.1834750419700474714e-09,
            2.4836745438024780616e-09,
            -1.1921401405860913615e-09,
            5.7313672416788612175e-10,
        };

        private static double[] DigammaLookup;


        // Origin: James McCaffrey, http://msdn.microsoft.com/en-us/magazine/dn520240.aspx
        /// <summary>
        /// Compute the regularized lower incomplete Gamma function by a series expansion
        /// </summary>
        /// <param name="a">The shape parameter, &gt; 0</param>
        /// <param name="x">The lower bound of the integral, &gt;= 0</param>
        /// <returns></returns>
        private static double GammaLowerSeries(double a, double x)
        {
            // the series is: x^a exp(-x) sum_{k=0}^inf x^k / Gamma(a+k+1)
            // if x < a+1, then the terms decrease monotonically.
            // to have a reasonably fast convergence, we want x < 0.5*a + 67
            double denom = a;
            double delta = 1.0 / a;
            double sum = delta;
            double scale = GammaUpperScale(a, x);
            for (int i = 0; i < 1000; i++)
            {
                ++denom;
                delta *= x / denom;
                double oldSum = sum;
                sum += delta;
                if (AreEqual(sum, oldSum))
                    return sum * scale;
            }
            throw new Exception(string.Format("GammaLowerSeries not converging for a={0} x={1}", a, x));
        }



        /* using http://sagecell.sagemath.org/ (must not be indented)
var('x');
f = 1/gamma(x+1)-1
[c[0].n(100) for c in f.taylor(x,0,16).coefficients()]
         */
        private static readonly double[] reciprocalFactorialMinus1Coeffs =
        {
            0.57721566490153286060651209008,
            -0.65587807152025388107701951515,
            -0.042002635034095235529003934875,
            0.16653861138229148950170079510,
            -0.042197734555544336748208301289,
            -0.0096219715278769735621149216721,
            0.0072189432466630995423950103404,
            -0.0011651675918590651121139710839,
            -0.00021524167411495097281572996312,
            0.00012805028238811618615319862640,
            -0.000020134854780788238655689391375,
            -1.2504934821426706573453594884e-6,
            1.1330272319816958823741296196e-6,
            -2.0563384169776071034501526118e-7,
            6.1160951044814158178625767024e-9,
            5.0020076444692229300557063872e-9
        };

        /// <summary>
        /// Computes <c>x^a e^(-x)/Gamma(a)</c> to high accuracy.
        /// </summary>
        /// <param name="a">A positive real number</param>
        /// <param name="x"></param>
        /// <returns></returns>
        private static double GammaUpperScale(double a, double x)
        {
            if (double.IsPositiveInfinity(x) || double.IsPositiveInfinity(a))
                return 0;
            double scale;
            if (a < 10)
                scale = Math.Exp(a * Math.Log(x) - x - GammaLn(a));
            else
            {
                double xia = x / a;
                double phi = xia - 1 - Math.Log(xia);
                scale = Math.Exp(0.5 * Math.Log(a) - MMath.LnSqrt2PI - GammaLnSeries(a) - a * phi);
            }
            return scale;
        }

        /// <summary>
        /// Compute the regularized upper incomplete Gamma function by a series expansion
        /// </summary>
        /// <param name="a">The shape parameter, &gt; 0</param>
        /// <param name="x">The lower bound of the integral, &gt;= 0</param>
        /// <returns></returns>
        private static double GammaUpperSeries(double a, double x)
        {
            // this series should only be applied when x is small
            // the series is: 1 - x^a sum_{k=0}^inf (-x)^k /(k! Gamma(a+k+1))
            // = (1 - 1/Gamma(a+1)) + (1 - x^a)/Gamma(a+1) - x^a sum_{k=1}^inf (-x)^k/(k! Gamma(a+k+1))
            double xaMinus1 = MMath.ExpMinus1(a * Math.Log(x));
            double aReciprocalFactorial, aReciprocalFactorialMinus1;
            if (a > 0.3)
            {
                aReciprocalFactorial = 1 / MMath.Gamma(a + 1);
                aReciprocalFactorialMinus1 = aReciprocalFactorial - 1;
            }
            else
            {
                aReciprocalFactorialMinus1 = ReciprocalFactorialMinus1(a);
                aReciprocalFactorial = 1 + aReciprocalFactorialMinus1;
            }
            // offset = 1 - x^a/Gamma(a+1)
            double offset = -xaMinus1 * aReciprocalFactorial - aReciprocalFactorialMinus1;
            double scale = 1 - offset;
            double term = x / (a + 1) * a;
            double sum = term;
            for (int i = 1; i < 1000; i++)
            {
                term *= -(a + i) * x / ((a + i + 1) * (i + 1));
                double sumOld = sum;
                sum += term;
                //Console.WriteLine("{0}: {1}", i, sum);
                if (AreEqual(sum, sumOld))
                    return scale * sum + offset;
            }
            throw new Exception(string.Format("GammaUpperSeries not converging for a={0} x={1}", a, x));
        }

        // Origin: James McCaffrey, http://msdn.microsoft.com/en-us/magazine/dn520240.aspx
        /// <summary>
        /// Compute the regularized upper incomplete Gamma function by a continued fraction
        /// </summary>
        /// <param name="a">A real number &gt; 0</param>
        /// <param name="x">A real number &gt;= 1.1</param>
        /// <returns></returns>
        private static double GammaUpperConFrac(double a, double x)
        {
            double scale = GammaUpperScale(a, x);
            if (scale == 0)
                return scale;
            // the confrac coefficients are:
            // a_i = -i*(i-a)
            // b_i = x+1-a+2*i
            // the confrac is evaluated using Lentz's algorithm
            double b = x + 1.0 - a;
            const double tiny = 1e-30;
            double c = 1.0 / tiny;
            double d = 1.0 / b;
            double h = d * scale;
            for (int i = 1; i < 1000; ++i)
            {
                double an = -i * (i - a);
                b += 2.0;
                d = an * d + b;
                if (Math.Abs(d) < tiny)
                    d = tiny;
                c = b + an / c;
                if (Math.Abs(c) < tiny)
                    c = tiny;
                d = 1.0 / d;
                double del = d * c;
                double oldH = h;
                h *= del;
                if (AreEqual(h, oldH))
                    return h;
            }
            throw new Exception(string.Format("GammaUpperConFrac not converging for a={0} x={1}", a, x));
        }

        /// <summary>
        /// Computes <c>GammaLn(x) - (x-0.5)*log(x) + x - 0.5*log(2*pi)</c> for x &gt;= 10
        /// </summary>
        /// <param name="x">A real number &gt;= 10</param>
        /// <returns></returns>
        private static double GammaLnSeries(double x)
        {
            // GammaLnSeries(10) = 0.008330563433362871
            if (x < 10)
            {
                return MMath.GammaLn(x) - (x - 0.5) * Math.Log(x) + x - LnSqrt2PI;
            }
            else
            {
                // the series is:  sum_{i=1}^inf B_{2i} / (2i*(2i-1)*x^(2i-1))
                double sum = 0;
                double term = 1.0 / x;
                double delta = term * term;
                for (int i = 0; i < c_gammaln_series.Length; i++)
                {
                    sum += c_gammaln_series[i] * term;
                    term *= delta;
                }
                return sum;
            }
        }

        private static double[] c_gammaln_series =
        {
            1.0 / (6 * 2), -1.0 / (30 * 4 * 3), 1.0 / (42 * 6 * 5), -1.0 / (30 * 8 * 7),
            5.0/(66*10*9), -691.0/(2730*12*11), 7.0/(6*14*13)
        };

    }

}