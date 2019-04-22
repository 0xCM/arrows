//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    


    using static zcore;


    public static class Interval
    {
        /// <summary>
        /// Partitions an interval into a specified number of pieces
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="parts">The number of partition points</param>
        /// <typeparam name="T">The underlying interval type</typeparam>
        public static IEnumerable<floatg<T>> partition<T>(Traits.Interval<floatg<T>> src, floatg<T> parts)
            where T : struct, IEquatable<T>
        {
            
            if(parts.neq(floatg<T>.Zero))
            {            
                var width = (src.right - src.left)/parts;
                var current = src.left;
                
                yield return src.left;
                for(var i = floatg<T>.Zero; i < parts - floatg<T>.One; i++)
                {
                    current += width;
                    yield return current;
                }
                yield return src.right;
            }
        }
        
        /// <summary>
        /// Constructs the closed interval [left,right]
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static ClosedInterval<T> closed<T>(T left, T right)
            where T : struct, IEquatable<T>
                => new ClosedInterval<T>(left,right);

        /// <summary>
        /// Constructs the left-open(or right-closed interval) interval (left,right]
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static LeftOpenInterval<T> leftopen<T>(T left, T right)
            where T : struct, IEquatable<T>
                => new LeftOpenInterval<T>(left,right);

        /// <summary>
        /// Constructs the left-closed (or right-open interval) interval [left,right)
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static LeftClosedInterval<T> leftclosed<T>(T left, T right)
            where T : struct, IEquatable<T>
                => new LeftClosedInterval<T>(left,right);

        /// <summary>
        /// Constructs the open interval (left,right)
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static OpenInterval<T> open<T>(T left, T right)
            where T : struct, IEquatable<T>
                => new OpenInterval<T>(left,right);        

        [MethodImpl(Inline)]
        public static bool contains<T>(Traits.Interval<T> interval, T point)
            where T : struct, IEquatable<T>
                => interval.kind switch {
                        IntervalKind.Closed 
                            => primops.gteq(point,interval.left) && primops.lteq(point, interval.right),
                        IntervalKind.Open 
                            => primops.gt(point, interval.left) && primops.lt(point, interval.right),
                        IntervalKind.LeftClosed 
                            => primops.gteq(point, interval.left) && primops.lt(point, interval.right),
                        IntervalKind.RightClosed 
                            => primops.gt(point, interval.left) && primops.lteq(point, interval.right),
                        _ => throw new ArgumentException()
                };
                
    
    }
}