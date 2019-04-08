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
            => new ClosedInterval<T>(left,right);

        /// <summary>
        /// Constructs the left-open(or right-closed interval) interval (left,right]
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static LeftOpenInterval<T> leftopen<T>(T left, T right)
            => new LeftOpenInterval<T>(left,right);

        /// <summary>
        /// Constructs the left-closed (or right-open interval) interval [left,right)
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static LeftClosedInterval<T> leftclosed<T>(T left, T right)
            => new LeftClosedInterval<T>(left,right);

        /// <summary>
        /// Constructs the open interval (left,right)
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static OpenInterval<T> open<T>(T left, T right)
            => new OpenInterval<T>(left,right);
        
    }

    partial class xcore
    {
        /// <summary>
        /// Constructs the closed interval [left,right]
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static ClosedInterval<T> ToClosedInterval<T>(this (T left, T right) x)
            => Interval.closed(x.left,x.right);

        /// <summary>
        /// Constructs the left-open(or right-closed interval) interval (left,right]
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static LeftOpenInterval<T> ToLeftOpenInterval<T>(this (T left, T right) x)
            => Interval.leftopen(x.left,x.right);

        /// <summary>
        /// Constructs the left-closed (or right-open interval) interval [left,right)
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static LeftClosedInterval<T> ToRightOpenInterval<T>(this (T left, T right) x)
            => Interval.leftclosed(x.left,x.right);

        /// <summary>
        /// Constructs the open interval (left,right)
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static OpenInterval<T> ToOpenInterval<T>(this (T left, T right) x)
            => Interval.open(x.left,x.right);     

        /// <summary>
        /// Partitions an interval into a specified number of pieces
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="parts">The number of partition points</param>
        /// <typeparam name="T">The underlying interval type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<floatg<T>> Partition<T>(this Traits.Interval<floatg<T>> src, floatg<T> parts)   
            where T : struct, IEquatable<T>
                => Interval.partition(src, parts);
    }
}
