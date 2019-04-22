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


    public static class IntervalX
    {
        /// <summary>
        /// Constructs the closed interval [left,right]
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static ClosedInterval<T> ToClosedInterval<T>(this (T left, T right) x)
            where T : struct, IEquatable<T>
                => Interval.closed(x.left,x.right);

        /// <summary>
        /// Constructs the left-open(or right-closed interval) interval (left,right]
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static LeftOpenInterval<T> ToLeftOpenInterval<T>(this (T left, T right) x)
            where T : struct, IEquatable<T>
                => Interval.leftopen(x.left,x.right);

        /// <summary>
        /// Constructs the left-closed (or right-open interval) interval [left,right)
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static LeftClosedInterval<T> ToRightOpenInterval<T>(this (T left, T right) x)
            where T : struct, IEquatable<T>
                => Interval.leftclosed(x.left,x.right);

        /// <summary>
        /// Constructs the open interval (left,right)
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static OpenInterval<T> ToOpenInterval<T>(this (T left, T right) x)
            where T : struct, IEquatable<T>
                => Interval.open(x.left,x.right);     

        /// <summary>
        /// Partitions an interval into a specified number of pieces
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="parts">The number of partition points</param>
        /// <typeparam name="T">The underlying interval type</typeparam>
        [MethodImpl(Inline)]
        public static Index<floatg<T>> Discretize<T>(this Interval<floatg<T>> src, floatg<T> parts)   
            where T : struct, IEquatable<T>
                => Interval.partition(src, parts).ToIndex();

        [MethodImpl(Inline)]
        public static Index<T> Discretize<T>(this Interval<T> src, T? step = null)
            where T : struct, IEquatable<T> 
                => DiscretizationStream(src, step).ToIndex();

        static IEnumerable<T> DiscretizationStream<T>(this Interval<T> src, T? step = null)
            where T : struct, IEquatable<T>
        {            
            var ops = primops.typeops<T>();

            var width = step ?? ops.one;

            if(src.leftclosed)
                yield return src.left;
            
            var next = ops.add(src.left, width);
            while(ops.lt(next,src.right))
            {
                yield return next;
                next = ops.add(next, width);
            }

            if(src.rightclosed)
                yield return src.right;
        }

        /// <summary>
        /// Determines whether the point lies within the interval
        /// </summary>
        /// <param name="src">The interval</param>
        /// <param name="point">The test point</param>
        /// <typeparam name="T">The domain of the point</typeparam>
        [MethodImpl(Inline)]
        public static bool Contains<T>(this Interval<T> src, T point)
            where T : struct, IEquatable<T> 
                => Interval.contains(src,point);
    }
}
