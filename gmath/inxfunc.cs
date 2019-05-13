namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static mfunc;
    using static zfunc;

    public static class SomeX
    {
        /// <summary>
        /// Converts a number to a string of decimal digits
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<DeciDigit> ToDecimalDigits<T>(this num<T> src)
            where T : struct, IEquatable<T>    
                =>  DeciDigits.Parse(src.Abs().ToString());

        /// <summary>
        /// Converts a number to a string of decimal digits
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
         [MethodImpl(Inline)]   
        public static Span<HexDigit> ToHexDigits<T>(this num<T> src)
            where T : struct, IEquatable<T>    
                =>  HexDigits.Parse(src.ToString());

        /// <summary>
        /// Converts a number to a string of decimal digits
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<BinaryDigit> ToBinaryDigits<T>(this num<T> src)
            where T : struct, IEquatable<T>    
                =>  BinaryDigits.Parse(src.ToBitString());

        /// <summary>
        /// Determines whether the point lies within the interval
        /// </summary>
        /// <param name="src">The interval</param>
        /// <param name="point">The test point</param>
        /// <typeparam name="T">The domain of the point</typeparam>
        [MethodImpl(Inline)]
        public static bool Contains<T>(this ITimeInterval<T> src, T point)
            where T : struct, IEquatable<T> 
                => src.Contains(point);

        [MethodImpl(Inline)]
        public static bool Contains<T>(this IInterval<T> interval, T point)
            where T : struct, IEquatable<T>
                => interval.Kind switch {
                        IntervalKind.Closed 
                            => gmath.gteq(point,interval.Left) && gmath.lteq(point, interval.Right),
                        IntervalKind.Open 
                            => gmath.gt(point, interval.Left) && gmath.lt(point, interval.Right),
                        IntervalKind.LeftClosed 
                            => gmath.gteq(point, interval.Left) && gmath.lt(point, interval.Right),
                        IntervalKind.RightClosed 
                            => gmath.gt(point, interval.Left) && gmath.lteq(point, interval.Right),
                        _ => throw new ArgumentException()
                };


        [MethodImpl(Inline)]
        public static T[] Discretize<T>(this Interval<T> src, T? step = null)
            where T : struct, IEquatable<T> 
                => DiscretizationStream(src, step).ToArray();

        static IEnumerable<T> DiscretizationStream<T>(this Interval<T> src, T? step = null)
            where T : struct, IEquatable<T>
        {            

            var width = step ?? gmath.one<T>();            

            if(src.LeftClosed)
                yield return src.Left;
            
            var next = gmath.add(src.Left, width);
            while(gmath.lt(next,src.Right))
            {
                yield return next;
                next = gmath.add(next, width);
            }

            if(src.RightClosed)
                yield return src.Right;
        }

        // <summary>
        /// Partitions an interval into a specified number of pieces
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="parts">The number of partition points</param>
        /// <typeparam name="T">The underlying interval type</typeparam>
        public static IEnumerable<num<T>> Partition<T>(this IInterval<num<T>> src, num<T> parts)
            where T : struct, IEquatable<T>
        {
            
            if(parts != num<T>.Zero)
            {            
                var width = (src.Right - src.Left)/parts;
                var current = src.Left;
                
                yield return src.Left;
                for(var i = num<T>.Zero; i < parts - num<T>.One; i++)
                {
                    current += width;
                    yield return current;
                }
                yield return src.Right;
            }
        }

        /// <summary>
        /// Partitions an interval into a specified number of pieces
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="parts">The number of partition points</param>
        /// <typeparam name="T">The underlying interval type</typeparam>
        [MethodImpl(Inline)]
        public static num<T>[] Discretize<T>(this Interval<num<T>> src, num<T> parts)   
            where T : struct, IEquatable<T>
                => src.Partition(parts).ToArray();

        [MethodImpl(Inline)]   
        public static T[] Unwrap<T>(this num<T>[] src)
            where T : struct, IEquatable<T>
                => map(src,x => x.Value);

        [MethodImpl(Inline)]   
        public static IEnumerable<T> Unwrap<T>(this IEnumerable<num<T>> src)
            where T : struct, IEquatable<T>
                => src.Select(x => x.Value);

        [MethodImpl(Inline)]   
        public static IEnumerable<T> Collapse<T>(IEnumerable<IEnumerable<T>> src)
            => src.SelectMany(x => x);


        [MethodImpl(Inline)]   
        public static bool IsFinite(this double src)
            => double.IsFinite(src);

        [MethodImpl(Inline)]   
        public static bool IsNegative(this double src)
            => double.IsNegative(src);

        /// <summary>
        /// Determines whether a value is positive
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static bool IsPositive(this double src)
            => src > 0;

        /// <summary>
        /// Determines whether a value is nonzero
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static bool IsNonzero(this double src)
            => src != 0;
    }
}