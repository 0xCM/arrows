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
        [MethodImpl(Inline)]   
        public static string Format(this ReadOnlySpan<char> src)
            => new string(src);

        [MethodImpl(Inline)]   
        public static string Format(this Span<char> src)
            => new string(src);

        [MethodImpl(Inline)]   
        public static ReadOnlySpan<char> Concat(this ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs)
            => lhs.Format() + rhs.Format();

        /// <summary>
        /// Converts a number to a string of decimal digits
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<DeciDigit> ToDecimalDigits<T>(this num<T> src)
            where T : struct    
                =>  DeciDigits.Parse(src.Abs().ToString());

        /// <summary>
        /// Converts a number to a string of decimal digits
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
         [MethodImpl(Inline)]   
        public static Span<HexDigit> ToHexDigits<T>(this num<T> src)
            where T : struct    
                =>  HexDigits.Parse(src.ToString());

        /// <summary>
        /// Converts a number to a string of decimal digits
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<BinaryDigit> ToBinaryDigits<T>(this num<T> src)
            where T : struct    
                =>  BinaryDigits.Parse(src.ToBitString());

        /// <summary>
        /// Determines whether the point lies within the interval
        /// </summary>
        /// <param name="src">The interval</param>
        /// <param name="point">The test point</param>
        /// <typeparam name="T">The domain of the point</typeparam>
        [MethodImpl(Inline)]
        public static bool Contains<T>(this ITimeInterval<T> src, T point)
            where T : struct 
                => src.Contains(point);

        [MethodImpl(Inline)]
        public static bool Contains<T>(this IInterval<T> interval, T point)
            where T : struct
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
            where T : struct 
                => DiscretizationStream(src, step).ToArray();

        static IEnumerable<T> DiscretizationStream<T>(this Interval<T> src, T? step = null)
            where T : struct
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


    }
}