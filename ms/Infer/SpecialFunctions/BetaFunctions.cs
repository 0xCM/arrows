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
        public static double BetaLn(double trueCount, double falseCount)
        {
            if (trueCount <= 0.0 || falseCount <= 0.0) return 0.0;
            double totalCount = trueCount + falseCount;
            return MMath.GammaLn(trueCount) + MMath.GammaLn(falseCount) - MMath.GammaLn(totalCount);
        }

        /// <summary>
        /// Power series for incomplete beta function obtained by replacing the second term in the integrand.
        /// BPSER method described in Didonato and Morris.
        /// </summary>
        /// <param name="x">The value.</param>
        /// <param name="a">The true count for the Beta.</param>
        /// <param name="b">The false count for the Beta.</param>
        /// <param name="epsilon">A tolerance for terminating the series calculation.</param>
        /// <returns></returns>
        private static double BPSer(double x, double a, double b, double epsilon)
        {
            double coeff = 1.0;
            double result = 1.0 / a;

            for (int j = 1; ; j++)
            {
                coeff *= (1.0 - b / j) * x;
                double term = coeff / (a + j);
                result += term;

                if (Math.Abs(term) < epsilon * Math.Abs(result))
                {
                    break;
                }
            }

            return Math.Exp(Math.Log(result) + a * Math.Log(x) - BetaLn(a, b));
        }

        /// <summary>
        /// BUP method described in Didonato and Morris.
        /// </summary>
        /// <param name="x">Value.</param>
        /// <param name="a">True count.</param>
        /// <param name="b">False count.</param>
        /// <param name="n">True count increment.</param>
        /// <param name="epsilon">Tolerance.</param>
        /// <returns></returns>
        private static double BUp(double x, double a, double b, int n, double epsilon)
        {
            double y = 1.0 - x;
            double d = 1.0;
            double xPow = 1.0;
            double sumh = 1.0;

            // i must be greater than iCheck to check for convergence
            int iCheck = 0;
            if (b > 1)
            {
                iCheck = (int)Math.Floor((b - 1) * x / y - a);
            }

            for (int i = 1; i < n; i++)
            {
                int i1 = i - 1;
                d = (a + b + i1) * d / (a + 1 + i1);
                xPow *= x;
                double h = d * xPow;
                sumh += h;

                if (i > iCheck && h <= epsilon * sumh)
                    break;
            }

            return Math.Exp(Math.Log(sumh) + a * Math.Log(x) + b * Math.Log(y) - Math.Log(a) - BetaLn(a, b));
        }

        /// <summary>
        /// BGRAT method described in Didonato and Morris.
        /// </summary>
        /// <param name="x">Value.</param>
        /// <param name="a">True count.</param>
        /// <param name="b">False count.</param>
        /// <param name="epsilon">Tolerance.</param>
        /// <returns></returns>
        private static double BGRat(double x, double a, double b, double epsilon)
        {
            List<double> p = new List<double>();
            List<int> twoNPlus1Factorial = new List<int>();
            p.Add(1.0);
            twoNPlus1Factorial.Add(1);
            double T = a + 0.5 * (b - 1);
            double u = -T * Math.Log(x);
            double lnHOfBU = -u + b * Math.Log(u) - MMath.GammaLn(b);
            double M = Math.Exp(lnHOfBU + MMath.GammaLn(a + b) - MMath.GammaLn(a) - (b * Math.Log(T)));
            double oneOver4TSq = 0.25 / (T * T);
            // Starting point for J
            double J = Math.Exp(Math.Log(GammaUpper(b, u)) - lnHOfBU);
            double result = J;

            double bPlus2n = b;
            double bPlus2nPlus1 = b + 1;
            double lnXOver2 = 0.5 * Math.Log(x);
            double lnXOver2Sq = lnXOver2 * lnXOver2;
            double lnXTerm = 1.0;

            for (int n = 1; ; n++)
            {
                J = oneOver4TSq * ((bPlus2n * bPlus2nPlus1 * J) + ((bPlus2nPlus1 + u) * lnXTerm));
                bPlus2n += 2;
                bPlus2nPlus1 += 2;
                lnXTerm *= lnXOver2Sq;
                twoNPlus1Factorial.Add(twoNPlus1Factorial.Last() * (2 * n) * (2 * n + 1));

                double currP = 0.0;
                for (int m = 1; m <= n; m++)
                {
                    currP += p[n - m] * (m * b - n) / twoNPlus1Factorial[m];
                }

                currP /= n;

                double term = J * currP;
                result += term;

                if (Math.Abs(term) <= epsilon * Math.Abs(result))
                {
                    break;
                }

                if (n > 100)
                {
                    throw new Exception("BGRat series not converging");
                }

                p.Add(currP);
            }

            return M * result;
        }

        /// <summary>
        /// The classic incomplete beta function continued fraction.
        /// </summary>
        private class BetaConFracClassic : ContinuedFraction
        {
            /// <summary>
            /// True count.
            /// </summary>
            public double A
            {
                get;
                set;
            }

            /// <summary>
            /// False count.
            /// </summary>
            public double B
            {
                get;
                set;
            }

            /// <summary>
            /// The value.
            /// </summary>
            public double X
            {
                get;
                set;
            }

            /// <summary>
            /// 1.0 minus the value.
            /// </summary>
            public double Y
            {
                get
                {
                    return 1.0 - this.X;
                }
            }

            /// <summary>
            /// The probability of true.
            /// </summary>
            public double P
            {
                get
                {
                    return this.A / (this.A + this.B);
                }
            }

            /// <summary>
            /// Evaluate the incomplete beta function.
            /// </summary>
            /// <param name="epsilon">The convergence tolerance.</param>
            /// <returns>The function value.</returns>
            public virtual double EvaluateIncompleteBeta(double epsilon)
            {
                return Math.Exp(
                   Math.Log(base.Evaluate(epsilon)) +
                   this.A * Math.Log(this.X) +
                   this.B * Math.Log(this.Y) -
                   this.A -
                   BetaLn(this.A, this.B));
            }

            /// <summary>
            /// Gets the numerator of the nth term of the continued fraction.
            /// </summary>
            /// <param name="n">The term index.</param>
            /// <returns>The numerator of the nth term.</returns>
            public override double GetNumerator(int n)
            {
                if (n == 1)
                {
                    return 1.0;
                }
                else
                {
                    int m = (n - 1) / 2;
                    double aPlus2m = this.A + 2 * m;
                    if ((n % 2) == 0)
                    {
                        double num = -(this.A + m) * (this.A + this.B + m) * this.X;
                        double den = aPlus2m * (aPlus2m + 1.0);
                        return num / den;
                    }
                    else
                    {
                        double num = m * (this.B - m) * this.X;
                        double den = (aPlus2m - 1) * aPlus2m;
                        return num / den;
                    }
                }
            }

            /// <summary>
            /// Gets the deniminator of the nth term of the continued fraction.
            /// </summary>
            /// <param name="n">The term index.</param>
            /// <returns>The denominator of the nth term.</returns>
            public override double GetDenominator(int n)
            {
                return 1.0;
            }
        }

        /// <summary>
        /// Incomplete beta function continued fraction according to Didonato and Morris.
        /// </summary>
        private class BetaConFracDidonatoMorris : BetaConFracClassic
        {
            /// <summary>
            /// Evaluate the incomplete beta function.
            /// </summary>
            /// <param name="epsilon">The convergence tolerance.</param>
            /// <returns>The function value.</returns>
            public override double EvaluateIncompleteBeta(double epsilon)
            {
                if (this.X > this.P)
                    throw new InvalidOperationException(@"x must be greater than a/(a+b)");

                return Math.Exp(
                    Math.Log(base.Evaluate(epsilon)) +
                    this.A * Math.Log(this.X) +
                    this.B * Math.Log(this.Y) -
                    BetaLn(this.A, this.B));
            }

            /// <summary>
            /// Gets the numerator of the nth term of the continued fraction.
            /// </summary>
            /// <param name="n">The term index.</param>
            /// <returns>The numerator of the nth term.</returns>
            public override double GetNumerator(int n)
            {
                if (n == 1)
                {
                    return 1.0;
                }
                else
                {
                    int m = n - 1;
                    double am1 = this.A + m - 1;
                    double a2m1 = am1 + m;
                    double abm1 = am1 + this.B;
                    return am1 * abm1 * m * (this.B - m) * this.X * this.X / (a2m1 * a2m1);
                }
            }

            /// <summary>
            /// Gets the deniminator of the nth term of the continued fraction.
            /// </summary>
            /// <param name="n">The term index.</param>
            /// <returns>The denominator of the nth term.</returns>
            public override double GetDenominator(int n)
            {
                int m = n - 1;
                double lambda = this.A - (this.A + this.B) * this.X;
                double a2mMinus1 = this.A + (2 * m) - 1.0;
                double a2mPlus1 = a2mMinus1 + 2.0;
                return
                    m +
                    (m * (this.B - m) * this.X / a2mMinus1) +
                    ((this.A + m) / a2mPlus1) * (lambda + 1.0 + m * (1.0 + this.Y));
            }
        }

        /// <summary>
        /// BFRAC method using continued fraction described in Didonato and Morris.
        /// </summary>
        /// <param name="x">Value.</param>
        /// <param name="a">True count.</param>
        /// <param name="b">False count.</param>
        /// <param name="maxIterations">Maximum number of iterations.</param>
        /// <param name="epsilon">Tolerance.</param>
        /// <param name="useDM">Whether to use the Didonato-Morris (default) or the classic continued fraction.</param>
        /// <returns></returns>
        private static double BFrac(double x, double a, double b, double epsilon, double maxIterations = 60, bool useDM = true)
        {
            BetaConFracClassic conFrac = useDM ? new BetaConFracDidonatoMorris() : new BetaConFracClassic();
            conFrac.X = x;
            conFrac.A = a;
            conFrac.B = b;
            return conFrac.EvaluateIncompleteBeta(epsilon);
        }

        /// <summary>
        /// BASYM method described in Didonato and Morris.
        /// </summary>
        /// <param name="x">Value.</param>
        /// <param name="a">True count.</param>
        /// <param name="b">False count.</param>
        /// <param name="epsilon">Tolerance.</param>
        /// <returns></returns>
        private static double BAsym(double x, double a, double b, double epsilon)
        {
            double p = a / (a + b);
            double q = 1.0 - p;
            double y = 1.0 - x;
            double lambda = (a + b) * (p - x);
            double zsq = -(a * Math.Log(x / p) + b * Math.Log(y / q)); // should be >= 0
            double z = Math.Sqrt(zsq);
            double twoPowMinus15 = Math.Pow(2, -1.5);
            double zsqrt2 = z * Math.Sqrt(2.0);
            double LPrev = 0.25 * Math.Sqrt(Math.PI) * Math.Exp(zsq) * MMath.Erfc(z);
            double LCurr = twoPowMinus15;
            double U = Math.Exp(GammaLnSeries(a + b) - GammaLnSeries(a) - GammaLnSeries(b));
            double mult = 2 * U * Math.Exp(-zsq) / Math.Sqrt(Math.PI);
            double betaGamma = (a < b) ? Math.Sqrt(q / a) : Math.Sqrt(p / b);
            List<double> aTerm = new List<double>();
            List<double> cTerm = new List<double>();
            List<double> eTerm = new List<double>();
            double aFunc(int n)
            {
                double neg = (n % 2) == 0 ? 1.0 : -1.0;
                return (a <= b) ?
                    2.0 * q * (1.0 + neg * Math.Pow(a / b, n + 1)) / (2.0 + n) :
                    2.0 * p * (neg + Math.Pow(b / a, n + 1)) / (2.0 + n);
            }

            // Assumes aTerm has been populated up to n
            double bFunc(int n, double r)
            {
                if (n == 0)
                {
                    return 1.0;
                }
                else if (n == 1)
                {
                    return r * aTerm[1];
                }
                else
                {
                    List<double> bTerm = new List<double>();
                    bTerm.Add(1.0);
                    bTerm.Add(r * aTerm[1]);
                    for (int j = 2; j <= n; j++)
                    {
                        bTerm.Add(r * aTerm[j] + Enumerable.Range(1, j - 1).Sum(i => ((j - i) * r - i) * bTerm[i] * aTerm[j - i]) / j);
                    }

                    return bTerm[n];
                }
            }

            // Assumes aTerm has been populated up to n
            double cFunc(int n) => bFunc(n - 1, -n / 2.0) / n;
            aTerm.Add(aFunc(0));
            aTerm.Add(aFunc(1));
            cTerm.Add(cFunc(1));
            cTerm.Add(cFunc(2));
            eTerm.Add(1.0);
            eTerm.Add(-eTerm[0] * cTerm[1]);

            double result = LPrev + eTerm[1] * LCurr * betaGamma;
            double powBetaGamma = betaGamma;
            double powZSqrt2 = 1.0;

            for (int n = 2; ; n++)
            {
                powZSqrt2 *= zsqrt2;
                double L = (twoPowMinus15 * powZSqrt2) + (n - 1) * LPrev;
                LPrev = LCurr;
                LCurr = L;

                powBetaGamma *= betaGamma;
                aTerm.Add(aFunc(n));
                cTerm.Add(cFunc(n + 1));
                eTerm.Add(-Enumerable.Range(0, n).Sum(i => eTerm[i] * cTerm[n - i]));
                double term = eTerm[n] * LCurr * powBetaGamma;
                result += term;

                if (aTerm.Last() != 0 && Math.Abs(term) <= epsilon * Math.Abs(result))
                {
                    break;
                }

                if (n > 100)
                {
                    throw new Exception("BASym series not converging");
                }
            }

            return mult * result;
        }

        /// <summary>
        /// Computes the regularized incomplete beta function: int_0^x t^(a-1) (1-t)^(b-1) dt / Beta(a,b)
        /// </summary>
        /// <param name="x">The first argument - any real number between 0 and 1.</param>
        /// <param name="a">The second argument - any real number greater than 0.</param>
        /// <param name="b">The third argument - any real number greater than 0.</param>
        /// <param name="epsilon">A tolerance for terminating the series calculation.</param>
        /// <returns>The incomplete beta function at (<paramref name="x"/>, <paramref name="a"/>, <paramref name="b"/>).</returns>
        /// <remarks>The beta function is obtained by setting x to 1.</remarks>
        public static double Beta(double x, double a, double b, double epsilon = 1e-15)
        {
            double result = 0.0;
            bool swap = false;

            if (Math.Min(a, b) <= 1)
            {
                swap = x > 0.5;
                if (swap)
                {
                    // Swap a for b, x for y
                    double c = a;
                    a = b;
                    b = c;
                    x = 1.0 - x;
                }

                double y = 1.0 - x;
                double p = a / (a + b);
                double q = 1.0 - p;
                double maxAB = Math.Max(a, b);
                double minPt2B = Math.Min(0.2, b);
                double bx = b * x;
                double xPowA = Math.Pow(x, a);
                double bxPowA = Math.Pow(bx, a);

                // Conditions
                bool maxAB_LE_1 = maxAB <= 1;
                bool a_LE_MinPt2B = a < minPt2B;
                bool xPowA_LE_Pt9 = xPowA <= 0.9;
                bool x_GE_Pt1 = x >= 0.1;
                bool x_GE_Pt3 = x >= 0.3;
                bool b_LE_1 = b <= 1;
                bool b_LE_15 = b <= 15;
                bool bxPowA_LE_Pt7 = bxPowA <= 0.7;

                if ((maxAB_LE_1 && !a_LE_MinPt2B) ||
                    (maxAB_LE_1 && a_LE_MinPt2B && xPowA_LE_Pt9) ||
                    (!maxAB_LE_1 && b_LE_1) ||
                    (!maxAB_LE_1 && !b_LE_1 && !x_GE_Pt1 && bxPowA_LE_Pt7))
                {
                    result = BPSer(x, a, b, epsilon);
                }
                else if (
                    (maxAB_LE_1 && a_LE_MinPt2B && !xPowA_LE_Pt9 && x_GE_Pt3) ||
                    (!maxAB_LE_1 && !b_LE_1 && x_GE_Pt3))
                {
                    result = BPSer(y, b, a, epsilon);
                    if (!swap)
                    {
                        result = 1.0 - result;
                    }

                    swap = false;
                }
                else if (
                    (!maxAB_LE_1 && !b_LE_15 && x_GE_Pt1 && !x_GE_Pt3) ||
                    (!maxAB_LE_1 && !b_LE_15 && !x_GE_Pt1 && !bxPowA_LE_Pt7))
                {
                    result = BGRat(y, b, a, 15.0 * epsilon);
                    if (!swap)
                    {
                        result = 1.0 - result;
                    }

                    swap = false;
                }
                else if (
                    (!maxAB_LE_1 && !b_LE_1 && x_GE_Pt1 && !x_GE_Pt3 && b_LE_15) ||
                    (!maxAB_LE_1 && !b_LE_1 && !x_GE_Pt1 && !bxPowA_LE_Pt7 && b_LE_15) ||
                    (maxAB_LE_1 && a_LE_MinPt2B && !xPowA_LE_Pt9 && !x_GE_Pt3))
                {
                    int n = 20;
                    double w0 = BUp(y, b, a, n, epsilon);
                    result = w0 + BGRat(y, b + n, a, 15.0 * epsilon);
                    if (!swap)
                    {
                        result = 1.0 - result;
                    }

                    swap = false;
                }
                else
                {
                    throw new InvalidOperationException(String.Format("Unexpected condition: a = {0}, b = {1}, x = {2}", a, b, x));
                }
            }
            else
            {
                double p = a / (a + b);
                swap = x > p;
                if (swap)
                {
                    // Swap a for b, x for y
                    double c = a;
                    a = b;
                    b = c;
                    x = 1.0 - x;
                }

                double y = 1.0 - x;
                p = a / (a + b);
                double q = 1.0 - p;
                double bx = b * x;
                int n = (int)Math.Floor(b);
                if (n == b)
                {
                    n -= 1;
                }

                double bbar = b - n;

                // Conditions
                bool b_LT_40 = b < 40;
                bool a_GT_15 = a > 15;
                bool a_LE_100 = a <= 100;
                bool b_LE_100 = b <= 100;
                bool x_LE_Pt7 = x <= 0.7;
                bool x_LT_Pt97p = x < 0.97 * p;
                bool y_GT_1Pt03q = y > 1.03 * q;
                bool bx_LE_Pt7 = bx <= 0.7;
                bool a_LE_b = a <= b;

                if (b_LT_40 && bx_LE_Pt7)
                {
                    result = BPSer(x, a, b, epsilon);
                }
                else if (b_LT_40 && !bx_LE_Pt7 && x_LE_Pt7)
                {
                    result = BUp(y, bbar, a, n, epsilon) + BPSer(x, a, bbar, epsilon);
                }
                else if (b_LT_40 && !x_LE_Pt7 && a_GT_15)
                {
                    result = BUp(y, bbar, a, n, epsilon) + BGRat(x, a, bbar, 15.0 * epsilon);
                }
                else if (b_LT_40 && !x_LE_Pt7 && !a_GT_15)
                {
                    int m = 20;
                    result = BUp(y, bbar, a, n, epsilon) + BUp(x, a, bbar, m, epsilon) + BGRat(x, a + m, bbar, 15.0 * epsilon);
                }
                else if (
                    (!b_LT_40 && a_LE_b && a_LE_100) ||
                    (a_LE_b && !a_LE_100 && x_LT_Pt97p) ||
                    (!b_LT_40 && !a_LE_b && b_LE_100) ||
                    (!a_LE_b && b > 100 && y_GT_1Pt03q))
                {
                    result = BFrac(x, a, b, 15.0 * epsilon);
                }
                else if (
                    (a_LE_b && !a_LE_100 && !x_LT_Pt97p) ||
                    (!a_LE_b && !b_LE_100 && !y_GT_1Pt03q))
                {
                    result = BAsym(x, a, b, 100.0 * epsilon);
                }
                else
                {
                    throw new InvalidOperationException(String.Format("Unexpected condition: a = {0}, b = {1}, x = {2}", a, b, x));
                }
            }

            if (swap)
            {
                result = 1.0 - result;
            }

            return result;
        }

    }

}