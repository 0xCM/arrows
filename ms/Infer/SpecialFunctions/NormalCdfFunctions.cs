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

        // [0] contains moments for x=-2
        // [1] contains moments for x=-3, etc.
        private static readonly double[][] NormalCdfMomentRatioTable = new double[7][];

        /// <summary>
        /// Computes int_0^infinity t^n N(t;x,1) dt / (n! N(x;0,1))
        /// </summary>
        /// <param name="n">The exponent</param>
        /// <param name="x">Any real number</param>
        /// <returns></returns>
        public static double NormalCdfMomentRatio(int n, double x)
        {
            const int tableSize = 200;
            const int maxTerms = 60;
            if (x >= -0.5)
                return NormalCdfMomentRatioRecurrence(n, x);
            else if (n <= tableSize - maxTerms && x > -8)
            {
                int index = (int)(-x - 1.5); // index ranges from 0 to 6
                double x0 = -index - 2;
                if (NormalCdfMomentRatioTable[index] == null)
                {
                    double[] derivs = new double[tableSize];
                    // this must not try to use the lookup table, since we are building it
                    var iter = NormalCdfMomentRatioSequence(0, x0, true);
                    for (int i = 0; i < derivs.Length; i++)
                    {
                        iter.MoveNext();
                        derivs[i] = iter.Current;
                    }
                    NormalCdfMomentRatioTable[index] = derivs;
                }
                return NormalCdfMomentRatioTaylor(n, x - x0, NormalCdfMomentRatioTable[index]);
            }
            else if (x > -2)
            {
                // x is between -2 and -1
                // use Taylor from -2
                double x0 = -2;
                return NormalCdfMomentRatioTaylor(n, x - x0, x0);
            }
            else
                return NormalCdfMomentRatioConFrac(n, x);
        }

        /// <summary>
        /// Computes <c>int_0^infinity t^n N(t;x,1) dt / (n! N(x;0,1))</c>
        /// </summary>
        /// <param name="n">The exponent</param>
        /// <param name="x">A real number &gt; -1</param>
        /// <returns></returns>
        private static double NormalCdfMomentRatioRecurrence(int n, double x)
        {
            double rPrev = MMath.NormalCdfRatio(x);
            if (n == 0)
                return rPrev;
            double r = x * rPrev + 1;
            for (int i = 1; i < n; i++)
            {
                double rNew = (x * r + rPrev) / (i + 1);
                rPrev = r;
                r = rNew;
            }
            return r;
        }

        /// <summary>
        /// Compute <c>int_0^infinity t^n N(t;x,1) dt / (n! N(x;0,1))</c> by Taylor expansion around <c>x0</c>
        /// </summary>
        /// <param name="n"></param>
        /// <param name="delta"></param>
        /// <param name="x0"></param>
        /// <returns></returns>
        private static double NormalCdfMomentRatioTaylor(int n, double delta, double x0)
        {
            double sum = 0;
            double term = 1;
            var iter = NormalCdfMomentRatioSequence(n, x0);
            for (int i = n; i < n + 1000; i++)
            {
                double sumOld = sum;
                iter.MoveNext();
                double deriv = iter.Current;
                sum += deriv * term;
                //Console.WriteLine("{0}: {1}", i, sum);
                if (AreEqual(sum, sumOld))
                    return sum;
                term *= delta * (i + 1) / (i - n + 1);
            }
            throw new Exception("Not converging for n=" + n + ",delta=" + delta);
        }

        /// <summary>
        /// Compute <c>int_0^infinity t^n N(t;x,1) dt / (n! N(x;0,1))</c> by Taylor expansion given pre-computed derivatives
        /// </summary>
        /// <param name="n"></param>
        /// <param name="delta"></param>
        /// <param name="derivs"></param>
        /// <returns></returns>
        private static double NormalCdfMomentRatioTaylor(int n, double delta, double[] derivs)
        {
            // derivs[i] is already divided by i!, and the result is divided by n!
            double sum = 0;
            double term = 1;
            for (int i = n; i < derivs.Length; i++)
            {
                double sumOld = sum;
                sum += derivs[i] * term;
                //Console.WriteLine("{0}: {1}", i, sum);
                if (AreEqual(sum, sumOld))
                    return sum;
                term *= delta * (i + 1) / (i - n + 1);
            }
            throw new Exception("Not converging for n=" + n + ",delta=" + delta);
        }

        /// <summary>
        /// Computes int_0^infinity t^n N(t;x,1) dt / (n! N(x;0,1))
        /// </summary>
        /// <param name="n">The exponent</param>
        /// <param name="x">A real number &lt;= -1</param>
        /// <returns></returns>
        private static double NormalCdfMomentRatioConFrac(int n, double x)
        {
            double invX = 1 / x;
            double invX2 = invX * invX;
            double numer = -invX;
            double numerPrev = 0;
            // denom and denomPrev are always > 0
            double denom = 1;
            double denomPrev = 1;
            double a = invX2;
            for (int i = 1; i <= n; i++)
            {
                numer *= -invX;
                double denomNew = denom + a * denomPrev;
                a += invX2;
                denomPrev = denom;
                denom = denomNew;
            }
            if (numer == 0) return 0;
            // a = (n+1)*invX2
            double rOld = 0;
            const double smallestNormalized = 1e-308;
            const double smallestNormalizedOverEpsilon = smallestNormalized / double.Epsilon;
            // the number of iterations required may grow with n, so we need to explicitly test for convergence.
            for (int i = 0; i < 1000; i++)
            {
                double numerNew = numer + a * numerPrev;
                double denomNew = denom + a * denomPrev;
                a += invX2;
                // Rescale to avoid overflow or underflow.
                // Let c=1e-308 be the smallest normalized number.
                // We want to stay above this magnitude if possible.
                // Thus we want to ensure that after rescaling, (|numerPrev|<c)==(|numer|<c)
                // We know that |numerNew| > |numer| > 0 at this point.
                // Thus we need |numer|*s >= c or |numerNew|*s < c, the latter only if |numerNew|/denomNew < double.Epsilon.
                // Thus s >= c/|numer| and s >= c/double.Epsilon/denomNew.
                // c/|numer| > c/double.Epsilon/denomNew when double.Epsilon*denomNew > |numer|
                double s;
                if (double.Epsilon * denomNew > Math.Abs(numer))
                    s = smallestNormalized / Math.Abs(numer);
                else
                    s = smallestNormalizedOverEpsilon / denomNew;
                numerPrev = numer * s;
                numer = numerNew * s;
                denomPrev = denom * s;
                denom = denomNew * s;
                double r = numer / denom;
                if (AreEqual(r, rOld))
                    return r;
                rOld = r;
            }
            throw new Exception($"Not converging for n={n},x={x:r}");
        }

        /// <summary>
        /// Computes the cumulative bivariate normal distribution.
        /// </summary>
        /// <param name="x">First upper limit.</param>
        /// <param name="y">Second upper limit.</param>
        /// <param name="r">Correlation coefficient.</param>
        /// <returns><c>phi(x,y,r)</c></returns>
        /// <remarks>
        /// The cumulative bivariate normal distribution is defined as
        /// <c>int_(-inf)^x int_(-inf)^y N([x;y],[0;0],[1 r; r 1]) dx dy</c>
        /// where <c>N([x;y],[0;0],[1 r; r 1]) = exp(-0.5*(x^2+y^2-2*x*y*r)/(1-r^2))/(2*pi*sqrt(1-r^2))</c>.
        /// </remarks>
        public static double NormalCdf(double x, double y, double r)
        {
            if (Double.IsNegativeInfinity(x) || Double.IsNegativeInfinity(y))
            {
                return 0.0;
            }
            else if (Double.IsPositiveInfinity(x))
            {
                return NormalCdf(y);
            }
            else if (Double.IsPositiveInfinity(y))
            {
                return NormalCdf(x);
            }
            else if (r == 0)
            {
                return NormalCdf(x) * NormalCdf(y);
            }
            else if (r == 1)
            {
                return NormalCdf(Math.Min(x, y));
            }
            else if (r == -1)
            {
                return Math.Max(0.0, NormalCdf(x) + NormalCdf(y) - 1);
            }
            // at this point, both x and y are finite.
            // swap to ensure |x| > |y|
            if (Math.Abs(y) > Math.Abs(x))
            {
                double t = x;
                x = y;
                y = t;
            }
            double offset = 0;
            double scale = 1;
            // ensure x <= 0
            if (x > 0)
            {
                // phi(x,y,r) = phi(inf,y,r) - phi(-x,y,-r)
                offset = MMath.NormalCdf(y);
                scale = -1;
                x = -x;
                r = -r;
            }
            // ensure r <= 0
            if (r > 0)
            {
                // phi(x,y,r) = phi(x,inf,r) - phi(x,-y,-r)
                offset += scale * MMath.NormalCdf(x);
                scale *= -1;
                y = -y;
                r = -r;
            }
            double omr2 = (1 - r) * (1 + r); // more accurate than 1-r*r            
            double ymrx = (y - r * x) / Math.Sqrt(omr2);
            double exponent;
            double result = NormalCdf_Helper(x, y, r, omr2, ymrx, out exponent);
            return offset + scale * result * Math.Exp(exponent);
        }


        // factor out the dominant terms and then call confrac
        private static double NormalCdf_Helper(double x, double y, double r, double omr2, double ymrx, out double exponent)
        {
            exponent = Gaussian.GetLogProb(x, 0, 1);
            double scale;
            if (ymrx < 0)
            {
                // since phi(ymrx) will be small, we factor N(ymrx;0,1) out of the confrac
                exponent += Gaussian.GetLogProb(ymrx, 0, 1);
                scale = 1;
            }
            else
            {
                // leave N(ymrx;0,1) in the confrac
                scale = Math.Exp(Gaussian.GetLogProb(ymrx, 0, 1));
            }
            // For debugging, see SpecialFunctionsTests.NormalCdf2Test3
            if (x < -1.5)
            {
                exponent -= Math.Log(-x);
                return NormalCdfRatioConFrac(x, y, r, scale);
            }
            else if (omr2 > 0.75 || (omr2 > 1 - 0.56 * 0.56 && x > -0.5))
            {
                return NormalCdfRatioTaylor(x, y, r) * scale;
                //return NormalCdfRatioConFrac3(x, y, r, scale);
            }
            else
            {
                return NormalCdfRatioConFrac2b(x, y, r, scale);
            }
        }

        // Returns NormalCdf divided by N(x;0,1) N((y-rx)/sqrt(1-r^2);0,1)
        // requires -1 < x < 0, abs(r) <= 0.6, and x-r*y <= 0 (or equivalently y < -x).
        // Uses Taylor series at r=0.
        private static double NormalCdfRatioTaylor(double x, double y, double r)
        {
            if (Math.Abs(x) > 5 || Math.Abs(y) > 5) throw new ArgumentOutOfRangeException();
            // First term of the Taylor series
            double sum = MMath.NormalCdfRatio(x) * MMath.NormalCdfRatio(y);
            double Halfx2y2 = (x * x + y * y) / 2;
            double xy = x * y;
            // Q = NormalCdf(x,y,r)/dNormalCdf(x,y,r)
            // where dNormalCdf(x,y,r) = N(x;0,1) N(y; rx, 1-r^2)
            List<double> Qderivs = new List<double>();
            Qderivs.Add(sum);
            List<double> logphiDerivs = new List<double>();
            double dlogphi = xy;
            logphiDerivs.Add(dlogphi);
            // dQ(0) = 1 - Q(0) d(log(dNormalCdf))
            double Qderiv = 1 - sum * dlogphi;
            Qderivs.Add(Qderiv);
            double rPowerN = r;
            // Second term of the Taylor series
            sum += Qderiv * rPowerN;
            double sumOld = sum;
            for (int n = 2; n <= 100; n++)
            {
                if (n == 100) throw new Exception($"not converging for x={x}, y={y}, r={r}");
                //Console.WriteLine($"n = {n - 1} sum = {sum:r}");
                double dlogphiOverFactorial;
                if (n % 2 == 0) dlogphiOverFactorial = 1.0 / n - Halfx2y2;
                else dlogphiOverFactorial = xy;
                logphiDerivs.Add(dlogphiOverFactorial);
                // ddQ = -dQ d(log(dNormalCdf)) - Q dd(log(dNormalCdf)), and so on
                double QderivOverFactorial = 0;
                for (int i = 0; i < n; i++)
                {
                    QderivOverFactorial -= Qderivs[i] * logphiDerivs[n - i - 1] * (n - i) / n;
                }
                Qderivs.Add(QderivOverFactorial);
                rPowerN *= r;
                sum += QderivOverFactorial * rPowerN;
                if ((sum > double.MaxValue) || double.IsNaN(sum))
                    throw new Exception($"not converging for x={x}, y={y}, r={r}");
                if (AreEqual(sum, sumOld)) break;
                sumOld = sum;
            }
            double omr2 = (1 - r) * (1 + r); // more accurate than 1-r*r            
            return sum / Math.Sqrt(omr2);
        }

        // Returns NormalCdf divided by N(x;0,1)/(-x) N((y-rx)/sqrt(1-r^2);0,1), multiplied by scale
        // requires x < -1, r <= 0, and x-r*y <= 0 (or equivalently y < -x).
        private static double NormalCdfRatioConFrac(double x, double y, double r, double scale)
        {
            if (x >= -1)
                throw new ArgumentException("x >= -1");
            if (r > 0)
                throw new ArgumentException("r > 0");
            if (x - r * y > 0)
                throw new ArgumentException("x - r*y > 0");
            if (scale == 0)
                return scale;
            double omr2 = (1 - r) * (1 + r); // more accurate than 1-r*r
            double sqrtomr2 = Math.Sqrt(omr2);
            double diff = (x - r * y) / sqrtomr2;
            var RdiffIter = NormalCdfMomentRatioSequence(0, diff);
            RdiffIter.MoveNext();
            double Rdiff = RdiffIter.Current;
            double numer = NormalCdfRatioConFracNumer(x, y, r, scale, sqrtomr2, diff, Rdiff);
            double numerPrev = 0;
            double denom = 1;
            double denomPrev = denom;
            double resultPrev = 0;
            double result = 0;
            double invX2 = 1 / (x * x);
            double a = invX2;
            double b = scale * r;
            double bIncr = sqrtomr2 / x;
            for (int i = 1; i < 1000; i++)
            {
                b *= bIncr * i;
                RdiffIter.MoveNext();
                //double c = b * MMath.NormalCdfMomentRatio(i, diff);
                double c = b * RdiffIter.Current;
                double numerNew = numer + a * numerPrev + c;
                double denomNew = denom + a * denomPrev;
                a += invX2;
                numerPrev = numer;
                numer = numerNew;
                denomPrev = denom;
                denom = denomNew;
                result = numer / denom;
                //Console.WriteLine("iter {0}: {1} {2}", i, result.ToString("r"), c.ToString("g4"));
                if ((result > double.MaxValue) || double.IsNaN(result) || result < 0)
                    throw new Exception($"not converging for x={x}, y={y}, r={r}");
                if (AreEqual(result, resultPrev))
                    return result;
                resultPrev = result;
            }
            throw new Exception($"not converging for x={x}, y={y}, r={r}");
        }

        // Helper function for NormalCdfRatioConFrac
        private static double NormalCdfRatioConFracNumer(double x, double y, double r, double scale, double sqrtomr2, double diff, double Rdiff)
        {
            double delta = (1 + r) * (y - x) / sqrtomr2;
            double numer;
            if (Math.Abs(delta) > 0.5)
            {
                numer = scale * r * Rdiff;
                double diffy = (y - r * x) / sqrtomr2;
                if (scale == 1)
                    numer += MMath.NormalCdfRatio(diffy);
                else // this assumes scale = N((y-rx)/sqrt(1-r^2);0,1)
                    numer += MMath.NormalCdf(diffy);
            }
            else
            {
                numer = scale * (NormalCdfRatioDiff(diff, delta) + (1 + r) * Rdiff);
            }
            return numer;
        }

        // Returns NormalCdf divided by N(x;0,1) N((y-rx)/sqrt(1-r^2);0,1), multiplied by scale
        // requires x <= 0, r <= 0, and x-r*y <= 0 (or equivalently y < -x).
        // This version works best for -1 < x <= 0.
        private static double NormalCdfRatioConFrac2(double x, double y, double r, double scale)
        {
            if (x > 0)
                throw new ArgumentException("x >= 0");
            if (r > 0)
                throw new ArgumentException("r > 0");
            if (x - r * y > 0)
                throw new ArgumentException("x - r*y > 0");
            if (scale == 0)
                return scale;
            double omr2 = (1 - r) * (1 + r); // more accurate than 1-r*r
            double sqrtomr2 = Math.Sqrt(omr2);
            double diff = (x - r * y) / sqrtomr2;
            var RdiffIter = NormalCdfMomentRatioSequence(0, diff);
            RdiffIter.MoveNext();
            double Rdiff = RdiffIter.Current;
            double numer = NormalCdfRatioConFracNumer(x, y, r, scale, sqrtomr2, diff, Rdiff);
            double numerPrev = 0;
            double denom = -x;
            double denomPrev = -1;
            double resultPrev = 0;
            double cEven = scale * r;
            double cOdd = cEven * sqrtomr2;
            for (int i = 1; i < 1000; i++)
            {
                double numerNew, denomNew;
                //double c = MMath.NormalCdfMomentRatio(i, diff);
                RdiffIter.MoveNext();
                double c = RdiffIter.Current;
                if (i % 2 == 1)
                {
                    if (i > 1)
                        cOdd *= (i - 1) * omr2;
                    c *= cOdd;
                    numerNew = x * numer + numerPrev + c;
                    denomNew = x * denom + denomPrev;
                }
                else
                {
                    cEven *= i * omr2;
                    c *= cEven;
                    numerNew = (x * numer + i * numerPrev + c) / (i + 1);
                    denomNew = (x * denom + i * denomPrev) / (i + 1);
                }
                numerPrev = numer;
                numer = numerNew;
                denomPrev = denom;
                denom = denomNew;
                if (i % 2 == 1)
                {
                    double result = numer / denom;
                    //Console.WriteLine($"iter {i}: result={result:r} c={c:g4} numer={numer:r} denom={denom:r} numerPrev={numerPrev:r}");
                    if ((result > double.MaxValue) || double.IsNaN(result) || result < 0)
                        throw new Exception($"NormalCdfRatioConFrac2 not converging for x={x} y={y} r={r} scale={scale}");
                    if (AreEqual(result, resultPrev))
                        return result;
                    resultPrev = result;
                }
            }
            throw new Exception($"NormalCdfRatioConFrac2 not converging for x={x} y={y} r={r} scale={scale}");
        }

        // Returns NormalCdf divided by N(x;0,1) N((y-rx)/sqrt(1-r^2);0,1), multiplied by scale
        // requires x <= 0, r <= 0, and x-r*y <= 0 (or equivalently y < -x).
        // This version works best for -1 < x <= 0.
        private static double NormalCdfRatioConFrac2b(double x, double y, double r, double scale)
        {
            if (x > 0)
                throw new ArgumentException("x >= 0");
            if (r > 0)
                throw new ArgumentException("r > 0");
            if (x - r * y > 0)
                throw new ArgumentException("x - r*y > 0");
            if (scale == 0)
                return scale;
            double omr2 = (1 - r) * (1 + r); // more accurate than 1-r*r
            double sqrtomr2 = Math.Sqrt(omr2);
            double diff = (x - r * y) / sqrtomr2;
            var RdiffIter = NormalCdfMomentRatioSequence(0, diff);
            RdiffIter.MoveNext();
            double Rdiff = RdiffIter.Current;
            double numer = NormalCdfRatioConFracNumer(x, y, r, scale, sqrtomr2, diff, Rdiff);
            double numerPrev = 0;
            double denom = -x;
            double denomPrev = -1;
            double resultPrev = 0;
            double rDy = scale * r;
            for (int i = 1; i < 1000; i++)
            {
                RdiffIter.MoveNext();
                double c = RdiffIter.Current;
                rDy *= sqrtomr2 * i;
                double numerNew = x * numer + i * numerPrev + c * rDy;
                double denomNew = x * denom + i * denomPrev;
                numerPrev = numer;
                numer = numerNew;
                denomPrev = denom;
                denom = denomNew;
                if (i % 2 == 1)
                {
                    double result = numer / denom;
                    //Console.WriteLine($"iter {i}: result={result:r} c={c:g4} numer={numer:r} denom={denom:r} numerPrev={numerPrev:r}");
                    if ((result > double.MaxValue) || double.IsNaN(result) || result < 0)
                        throw new Exception($"NormalCdfRatioConFrac2b not converging for x={x} y={y} r={r} scale={scale}");
                    if (AreEqual(result, resultPrev))
                        return result;
                    resultPrev = result;
                }
            }
            throw new Exception($"NormalCdfRatioConFrac2b not converging for x={x} y={y} r={r} scale={scale}");
        }

        /// <summary>
        /// Computes <c>1-sqrt(1-x)</c> to high accuracy.
        /// </summary>
        /// <param name="x">A real number between 0 and 1</param>
        /// <returns></returns>
        public static double OneMinusSqrtOneMinus(double x)
        {
            if (x > 1e-4)
                return 1 - Math.Sqrt(1 - x);
            else
                return x * (1.0 / 2 + x * (1.0 / 8 + x * (1.0 / 16 + x * 5.0 / 128)));
        }

        /// <summary>
        /// Returns NormalCdfMomentRatio(i,x) for i=n,n+1,n+2,...
        /// </summary>
        /// <param name="n">A starting index &gt;= 0</param>
        /// <param name="x">A real number</param>
        /// <param name="useConFrac">If true, do not use the lookup table</param>
        /// <returns></returns>
        private static IEnumerator<double> NormalCdfMomentRatioSequence(int n, double x, bool useConFrac = false)
        {
            if (n < 0)
                throw new ArgumentException("n < 0");
            if (x > -1)
            {
                // Use the upward recurrence.
                double rPrev = MMath.NormalCdfRatio(x);
                if (n == 0)
                    yield return rPrev;
                double r = x * rPrev + 1;
                if (n <= 1)
                    yield return r;
                for (int i = 1; ; i++)
                {
                    double rNew = (x * r + rPrev) / (i + 1);
                    rPrev = r;
                    r = rNew;
                    if (n <= i + 1)
                        yield return r;
                }
            }
            else
            {
                // Use the downward recurrence.
                // Each batch of tableSize items is generated in advance.
                // If tableSize is larger than 50, the results will lose accuracy.
                // If tableSize is too small, then the recurrence is used less often, requiring more computation.
                int maxTableSize = 30;
                // rtable[tableStart-i] = R_i
                double[] rtable = new double[maxTableSize];
                int tableStart = -1;
                int tableSize = 2;
                for (int i = n; ; i++)
                {
                    if (i > tableStart)
                    {
                        // build the table
                        tableStart = i + tableSize - 1;
                        if (useConFrac)
                        {
                            rtable[0] = MMath.NormalCdfMomentRatioConFrac(tableStart, x);
                            rtable[1] = MMath.NormalCdfMomentRatioConFrac(tableStart - 1, x);
                        }
                        else
                        {
                            rtable[0] = MMath.NormalCdfMomentRatio(tableStart, x);
                            rtable[1] = MMath.NormalCdfMomentRatio(tableStart - 1, x);
                        }
                        for (int j = 2; j < tableSize; j++)
                        {
                            int nj = tableStart - j + 1;
                            if (rtable[j - 2] == 0 && rtable[j - 1] == 0)
                            {
                                rtable[j] = MMath.NormalCdfMomentRatio(nj - 1, x);
                            }
                            else
                            {
                                rtable[j] = (nj + 1) * rtable[j - 2] - x * rtable[j - 1];
                            }
                        }
                        // Increase tableSize up to the maximum.
                        tableSize = Math.Min(maxTableSize, 2 * tableSize);
                    }
                    yield return rtable[tableStart - i];
                }
            }
        }

        /// <summary>
        /// Computes the natural logarithm of the cumulative bivariate normal distribution.
        /// </summary>
        /// <param name="x">First upper limit.</param>
        /// <param name="y">Second upper limit.</param>
        /// <param name="r">Correlation coefficient.</param>
        /// <returns><c>ln(phi(x,y,r))</c></returns>
        public static double NormalCdfLn(double x, double y, double r)
        {
            if (Double.IsNegativeInfinity(x) || Double.IsNegativeInfinity(y))
            {
                return Double.NegativeInfinity;
            }
            else if (Double.IsPositiveInfinity(x))
            {
                return NormalCdfLn(y);
            }
            else if (Double.IsPositiveInfinity(y))
            {
                return NormalCdfLn(x);
            }
            else if (r == 0)
            {
                return NormalCdfLn(x) + NormalCdfLn(y);
            }
            else if (r == 1)
            {
                return NormalCdfLn(Math.Min(x, y));
            }
            else if (r == -1)
            {
                if (x > 0)
                {
                    if (y > 0)
                    {
                        // 1-NormalCdf(-x) + 1-NormalCdf(-y)-1 = 1 - NormalCdf(-x) - NormalCdf(-y)
                        return Log1MinusExp(LogSumExp(NormalCdfLn(-x), NormalCdfLn(-y)));
                    }
                    else
                    {
                        // 1-NormalCdf(-x) + NormalCdf(y) - 1 = NormalCdf(y) - NormalCdf(-x)
                        double nclx = NormalCdfLn(-x);
                        double diff = NormalCdfLn(y) - nclx;
                        if (diff < 0)
                            return double.NegativeInfinity;
                        return LogExpMinus1(diff) + nclx;
                    }
                }
                else
                {
                    if (y > 0)
                    {
                        // NormalCdf(x) - NormalCdf(-y)
                        if (x < -y)
                            return double.NegativeInfinity;
                        double ncly = NormalCdfLn(-y);
                        double diff = NormalCdfLn(x) - ncly;
                        if (diff < 0)
                            return double.NegativeInfinity;
                        return LogExpMinus1(diff) + ncly;
                    }
                    else
                    {
                        // x < 0 and y < 0
                        return double.NegativeInfinity;
                    }
                }
            }
            // at this point, both x and y are finite.
            // swap to ensure |x| > |y|
            if (Math.Abs(y) > Math.Abs(x))
            {
                double t = x;
                x = y;
                y = t;
            }
            double logOffset = double.NegativeInfinity;
            double scale = 1;
            // ensure x <= 0
            if (x > 0)
            {
                // phi(x,y,r) = phi(inf,y,r) - phi(-x,y,-r)
                logOffset = MMath.NormalCdfLn(y);
                scale = -1;
                x = -x;
                r = -r;
            }
            // ensure r <= 0
            if (r > 0)
            {
                // phi(x,y,r) = phi(x,inf,r) - phi(x,-y,-r)
                double logOffset2 = MMath.NormalCdfLn(x);
                if (scale == 1)
                    logOffset = logOffset2;
                else
                {
                    // the difference here must always be positive since y > -x
                    // offset -= offset2;
                    // logOffset = log(exp(logOffset) - exp(logOffset2))
                    logOffset = MMath.LogDifferenceOfExp(logOffset, logOffset2);
                }
                scale *= -1;
                y = -y;
                r = -r;
            }
            double omr2 = (1 - r) * (1 + r); // more accurate than 1-r*r            
            double ymrx = (y - r * x) / Math.Sqrt(omr2);
            double exponent;
            double result = NormalCdf_Helper(x, y, r, omr2, ymrx, out exponent);
            double logResult = exponent + Math.Log(result);
            if (scale == -1)
                return MMath.LogDifferenceOfExp(logOffset, logResult);
            else
                return MMath.LogSumExp(logOffset, logResult);
        }



    }

}