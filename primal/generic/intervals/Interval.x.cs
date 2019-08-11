//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
       
    using static As;
    using static zfunc;

    public static class IntervalX
    {
        [MethodImpl(Inline)]
        public static T Width<T>(this IInterval<T> src)
            where T : struct
                => gmath.abs(gmath.sub(src.Right, src.Left));

        [MethodImpl(Inline)]
        public static bool Contains<T>(this IInterval<T> src, T point)
            where T : struct
        {
            if(src.Kind == IntervalKind.Closed)
                return gmath.gteq(point, src.Left) && gmath.lteq(point, src.Right);
            else if(src.Kind == IntervalKind.Open)
                return gmath.gt(point, src.Left) && gmath.lt(point, src.Right);
            else if(src.Kind == IntervalKind.LeftClosed)
                return gmath.gteq(point, src.Left) && gmath.lt(point, src.Right);
            else
                return gmath.gt(point, src.Left) && gmath.lteq(point, src.Right);
        }


        [MethodImpl(Inline)]
        public static IEnumerable<T> PartitionPointStream<T>(this Interval<T> src, T? stepWidth = null, int? precision = null)
            where T : struct
        {            
            var width = stepWidth ?? gmath.one<T>();            
            var scale = precision ?? 4;
            if(src.LeftClosed)
                yield return src.Left;
            
            var next = gmath.round(gmath.add(src.Left, width), scale);
            while(gmath.lt(next,src.Right))
            {
                yield return next;
                next = gmath.round(gmath.add(next, width), scale);
            }

            if(src.RightClosed)
                yield return src.Right;
        }

        public static Span<T> StepwisePartitionPoints<T>(this Interval<T> src, T? stepWidth = null)
            where T : struct
        {
            var negOne = gmath.dec(gmath.zero<T>());
            var step = stepWidth ?? gmath.one<T>();
            var width =  gmath.sub(src.Right, src.Left);            
            convert<T,int>(gmath.div(width, step), out int count);
            
            var dst = span<T>(count + 1);
            var point = src.Left;
            for(var i=0; i < dst.Length; i++)
            {
                if(i == 0)            
                {        
                    dst[i] = src.Left;
                    point = gmath.add(point, step);
                }
                else if(i == dst.Length - 1)
                {
                    dst[i] = src.Right;                        
                }
                else
                {
                    dst[i] = point;                            
                    point = gmath.add(point, step);
                }
                        
            }
            return dst;
        }

        public static Span<Interval<T>> StepwisePartition<T>(this Interval<T> src, T stepWidth)
            where T : struct
        {
            var points = src.StepwisePartitionPoints(stepWidth);
            var dst = span<Interval<T>>(points.Length - 1);
            var lastIx = points.Length - 1;
            var lastCycleIx = lastIx - 1;
            
            for(var i = 0; i < lastIx; i++)
            {
                var left = points[i];
                var right = points[i + 1];
                if(i == 0)
                    if(src.Open || src.LeftOpen)
                        dst[i] = open(left,right);
                    else
                        dst[i] = leftclosed(left,right);
                else if(i == lastCycleIx)
                    if(src.Closed || src.RightClosed)
                        dst[i] = closed(left, right);
                    else
                        dst[i] = leftclosed(left,right);
                else
                    dst[i] = leftclosed(left, right);
            }
            return dst;
            
        }

        [MethodImpl(Inline)]
        public static IntervalPoint<T> Point<T>(this Interval<T> src, T value)        
            where T : struct
                => IntervalPoint<T>.Define(src,value);

        // <summary>
        /// Calculates the partition points in an interval
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="parts">The number of partition points</param>
        /// <typeparam name="T">The underlying interval type</typeparam>
        public static Span<T> PartitionPoints<T>(this Interval<T> src, int count)
            where T : struct
        {            
            var step = gmath.div(gmath.sub(src.Right, src.Left), convert<T>(count - 1));
            return src.StepwisePartitionPoints(step);            
        }

        public static Span<Interval<T>> Partition<T>(this Interval<T> src, int count)
            where T : struct
        {
            var step = gmath.div(gmath.sub(src.Right, src.Left), convert<T>(count));
            return src.StepwisePartition(step);
        }

        public static Interval<T> Add<T>(this ref Interval<T> lhs, Interval<T> rhs)
            where T : struct
            => lhs.WithEndpoints(
                    gmath.add(lhs.Left, rhs.Left), 
                    gmath.add(lhs.Right, rhs.Right)
                    );

        public static Interval<T> Sub<T>(this ref Interval<T> lhs, Interval<T> rhs)
            where T : struct
            => lhs.WithEndpoints(
                    gmath.sub(lhs.Left, rhs.Left), 
                    gmath.sub(lhs.Right, rhs.Right)
                    );

    }
}