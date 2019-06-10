// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace MsInfer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static partial class MMath
    {
        /// <summary>
        /// Modified Bessel function of the first kind
        /// </summary>
        /// <param name="a">Order parameter.  Any real number except a negative integer.</param>
        /// <param name="x">Argument of the Bessel function.  Non-negative real number.</param>
        /// <remarks>
        /// Reference:
        /// "A short note on parameter approximation for von Mises-Fisher distributions, And a fast implementation of Is(x)"
        /// Suvrit Sra
        /// Computational Statistics, 2011
        /// http://people.kyb.tuebingen.mpg.de/suvrit/papers/vmfFinal.pdf
        /// </remarks>
        /// <returns>BesselI(a,x)</returns>
        public static double BesselI(double a, double x)
        {
            if (x < 0)
                throw new ArgumentException("x (" + x + ") cannot be negative");
            if (a < 0 && a == Math.Floor(a))
                throw new ArgumentException("Order parameter a=" + a + " cannot be a negative integer");
            // http://functions.wolfram.com/Bessel-TypeFunctions/BesselI/02/
            double xh = 0.5 * x;
            double term = Math.Pow(xh, a) / MMath.Gamma(a + 1);
            double xh2 = xh * xh;
            double sum = 0;
            for (int k = 0; k < 1000; k++)
            {
                double oldsum = sum;
                sum += term;
                term *= xh2 / ((k + 1 + a) * (k + 1));
                if (AreEqual(oldsum, sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>
        /// Returns the median of the array elements.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>The median ignoring NaNs.</returns>
        public static double Median(double[] array)
        {
            return Median(array, 0, array.Length);
        }

        /// <summary>
        /// Returns the median of elements in a subrange of an array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="start">Starting index of the range.</param>
        /// <param name="length">The number of elements in the range.</param>
        /// <returns>The median of array[start:(start+length-1)], ignoring NaNs.</returns>
        public static double Median(double[] array, int start, int length)
        {
            if (length <= 0)
                return Double.NaN;
            // this can be done in O(n) time, but here we take a slower shortcut.
            // Array.Sort does not sort NaNs reliably, so we must extract them first.
            double[] a = RemoveNaNs(array, start, length);
            length = a.Length;
            if (length == 0)
                return Double.NaN;
            Array.Sort(a);
            int middle = length / 2;
            if (length % 2 == 0)
            {
                // average the two middle elements
                return Average(a[middle - 1], a[middle]);
            }
            else
            {
                return a[middle];
            }
        }

        /// <summary>
        /// Given an array, returns a new array with all NANs removed.
        /// </summary>
        /// <param name="array">The source array</param>
        /// <param name="start">The start index in the source array</param>
        /// <param name="length">How many items to look at in the source array</param>
        /// <returns></returns>
        public static double[] RemoveNaNs(double[] array, int start, int length)
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (!Double.IsNaN(array[i + start]))
                    count++;
            }
            double[] result = new double[count];
            if (count == length)
            {
                Array.Copy(array, start, result, 0, length);
            }
            else
            {
                count = 0;
                for (int i = 0; i < length; i++)
                {
                    if (!Double.IsNaN(array[i + start]))
                        result[count++] = array[i + start];
                }
            }
            return result;
        }

        /// <summary>
        /// Returns the relative distance between two numbers.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="rel">An offset to avoid division by zero.</param>
        /// <returns><c>abs(x - y)/(abs(x) + rel)</c>. 
        /// Matching infinities give zero.
        /// </returns>
        /// <remarks>
        /// This routine is often used to measure the error of y in estimating x.
        /// </remarks>
        public static double AbsDiff(double x, double y, double rel)
        {
            if (x == y)
                return 0; // catches infinities
            return Math.Abs(x - y) / (Math.Min(Math.Abs(x), Math.Abs(y)) + rel);
        }

        /// <summary>
        /// Returns the distance between two numbers.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns><c>abs(x - y)</c>. 
        /// Matching infinities give zero.
        /// </returns>
        public static double AbsDiff(double x, double y)
        {
            if (x == y)
                return 0; // catches infinities
            return Math.Abs(x - y);
        }

        /// <summary>
        /// Returns true if two numbers are equal when represented in double precision.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool AreEqual(double x, double y)
        {
            // These casts force the runtime to represent in double precision instead of a higher internal precision.
            // See section I.12.1.3 of the ECMA specification.
            return (double)x == (double)y;
            // The below approach does not work when x or y is infinity.  For example, try running GaussianTest in 32-bit Release mode.
            // Also, the ECMA specification allows differences larger than double.Epsilon, as long as the internal precision is higher than double precision.
            ////return AbsDiff(x, y) < double.Epsilon;
        }

        /// <summary>
        /// Returns the positive distance between a value and the next representable value that is larger in magnitude.
        /// </summary>
        /// <param name="value">Any double-precision value.</param>
        /// <returns></returns>
        public static double Ulp(double value)
        {
            if (double.IsNaN(value)) return value;
            value = Math.Abs(value);
            if (double.IsPositiveInfinity(value)) return 0;
            long bits = BitConverter.DoubleToInt64Bits(value);
            double nextValue = BitConverter.Int64BitsToDouble(bits + 1);
            return nextValue - value;
        }

        /// <summary>
        /// Returns the smallest double precision number greater than value, if one exists.  Otherwise returns value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double NextDouble(double value)
        {
            if (value < 0) return -PreviousDouble(-value);
            value = Math.Abs(value); // needed to handle -0
            if (double.IsNaN(value)) return value;
            if (double.IsPositiveInfinity(value)) return value;
            long bits = BitConverter.DoubleToInt64Bits(value);
            return BitConverter.Int64BitsToDouble(bits + 1);
        }

        /// <summary>
        /// Returns the largest double precision number less than value, if one exists.  Otherwise returns value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double PreviousDouble(double value)
        {
            if (value <= 0) return -NextDouble(-value);
            if (double.IsNaN(value)) return value;
            if (double.IsNegativeInfinity(value)) return value;
            long bits = BitConverter.DoubleToInt64Bits(value);
            return BitConverter.Int64BitsToDouble(bits - 1);
        }

        /// <summary>
        /// Returns the largest value such that value/denominator &lt;= ratio.
        /// </summary>
        /// <param name="denominator"></param>
        /// <param name="ratio"></param>
        /// <returns></returns>
        internal static double LargestDoubleProduct(double denominator, double ratio)
        {
            if (denominator < 0) return LargestDoubleProduct(-denominator, -ratio);
            if (denominator == 0)
            {
                if (double.IsNaN(ratio)) return 0;
                else if (double.IsPositiveInfinity(ratio))
                    return double.PositiveInfinity;
                else if (double.IsNegativeInfinity(ratio))
                    return PreviousDouble(0);
                else
                    return double.NaN;
            }
            if (double.IsPositiveInfinity(denominator))
            {
                if (double.IsNaN(ratio)) return denominator;
                else return double.MaxValue;
            }
            if (double.IsPositiveInfinity(ratio)) return ratio;
            // denominator > 0
            // avoid infinite bounds
            double lowerBound = (double)Math.Max(double.MinValue, denominator * PreviousDouble(ratio));
            if (lowerBound == 0 && ratio < 0) lowerBound = -denominator; // must have ratio > -1
            if (double.IsPositiveInfinity(lowerBound)) lowerBound = denominator; // must have ratio > 1
            // subnormal numbers are linearly spaced, which can lead to lowerBound being too large.  Set lowerBound to zero to avoid this.
            const double maxSubnormal = 2.3e-308;
            if (lowerBound > 0 && lowerBound < maxSubnormal) lowerBound = 0;
            double upperBound = (double)Math.Min(double.MaxValue, denominator * NextDouble(ratio));
            if (upperBound == 0 && ratio > 0) upperBound = denominator; // must have ratio < 1
            if (double.IsNegativeInfinity(upperBound)) return upperBound; // must have ratio < -1 and denominator > 1
            if (upperBound < 0 && upperBound > -maxSubnormal) upperBound = 0;
            if (double.IsNegativeInfinity(ratio))
            {
                if (AreEqual(upperBound / denominator, ratio)) return upperBound;
                else return PreviousDouble(upperBound);
            }
            while (true)
            {
                double value = (double)Average(lowerBound, upperBound);
                if (value < lowerBound || value > upperBound) throw new Exception($"value={value:r}, lowerBound={lowerBound:r}, upperBound={upperBound:r}, denominator={denominator:r}, ratio={ratio:r}");
                if ((double)(value / denominator) <= ratio)
                {
                    double value2 = NextDouble(value);
                    if (value2 == value || (double)(value2 / denominator) > ratio)
                    {
                        return value;
                    }
                    else
                    {
                        // value is too low
                        lowerBound = value2;
                        if (lowerBound > upperBound || double.IsNaN(lowerBound)) throw new Exception($"value={value:r}, lowerBound={lowerBound:r}, upperBound={upperBound:r}, denominator={denominator:r}, ratio={ratio:r}");
                    }
                }
                else
                {
                    // value is too high
                    upperBound = PreviousDouble(value);
                    if (lowerBound > upperBound || double.IsNaN(upperBound)) throw new Exception($"value={value:r}, lowerBound={lowerBound:r}, upperBound={upperBound:r}, denominator={denominator:r}, ratio={ratio:r}");
                }
            }
        }

        /// <summary>
        /// Returns the largest value such that value - b &lt;= sum.
        /// </summary>
        /// <param name="sum"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        internal static double LargestDoubleSum(double b, double sum)
        {
            if (double.IsPositiveInfinity(b))
            {
                if (double.IsNaN(sum)) return double.PositiveInfinity;
                else return double.MaxValue;
            }
            if (double.IsNegativeInfinity(b))
            {
                if (double.IsNaN(sum)) return double.NegativeInfinity;
                else return double.PositiveInfinity;
            }
            if (double.IsPositiveInfinity(sum)) return sum;
            double lowerBound = PreviousDouble(b + sum);
            double upperBound;
            if (Math.Abs(sum) > Math.Abs(b))
            {
                upperBound = b + NextDouble(sum);
            }
            else
            {
                upperBound = NextDouble(b) + sum;
            }
            long iterCount = 0;
            while (true)
            {
                iterCount++;
                double value = Average(lowerBound, upperBound);
                //double value = RepresentationMidpoint(lowerBound, upperBound);
                if (value < lowerBound || value > upperBound) throw new Exception($"value={value:r}, lowerBound={lowerBound:r}, upperBound={upperBound:r}, b={b:r}, sum={sum:r}");
                if (value - b <= sum)
                {
                    double value2 = NextDouble(value);
                    if (value2 == value || value2 - b > sum)
                    {
                        //if (iterCount > 100)
                        //    throw new Exception();
                        return value;
                    }
                    else
                    {
                        // value is too low
                        lowerBound = value2;
                        if (lowerBound > upperBound || double.IsNaN(lowerBound)) throw new Exception($"value={value:r}, lowerBound={lowerBound:r}, upperBound={upperBound:r}, b={b:r}, sum={sum:r}");
                    }
                }
                else
                {
                    // value is too high
                    upperBound = PreviousDouble(value);
                    if (lowerBound > upperBound || double.IsNaN(upperBound)) throw new Exception($"value={value:r}, lowerBound={lowerBound:r}, upperBound={upperBound:r}, b={b:r}, sum={sum:r}");
                }
            }
        }

        /// <summary>
        /// Returns (a+b)/2, avoiding overflow.  The result is guaranteed to be between a and b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Average(double a, double b)
        {
            double midpoint = (a + b) / 2;
            if (double.IsInfinity(midpoint)) midpoint = 0.5 * a + 0.5 * b;
            return midpoint;
        }

        /// <summary>
        /// Returns (a+b)/2, avoiding overflow.  The result is guaranteed to be between a and b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static long Average(long a, long b)
        {
            return a / 2 + b / 2 + ((a % 2) + (b % 2)) / 2;
        }

        private static double RepresentationMidpoint(double lower, double upper)
        {
            if (lower == 0)
            {
                if (upper < 0) return -RepresentationMidpoint(-lower, -upper);
                else if (upper == 0) return lower;
                // fall through
            }
            else if (lower < 0)
            {
                if (upper <= 0) return -RepresentationMidpoint(-lower, -upper);
                else return 0; // upper > 0
            }
            else if (upper < 0) return 0; // lower > 0
            // must have lower >= 0, upper >= 0
            long lowerBits = BitConverter.DoubleToInt64Bits(lower);
            long upperBits = BitConverter.DoubleToInt64Bits(upper);
            long midpoint = MMath.Average(lowerBits, upperBits);
            return BitConverter.Int64BitsToDouble(midpoint);
        }


    }
}