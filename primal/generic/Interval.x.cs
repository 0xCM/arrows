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
        public static T Width<T>(this Interval<T> src)
            where T : struct
                => gmath.sub(src.Right, src.Left);

        [MethodImpl(Inline)]
        public static bool Contains<T>(this Interval<T> src, T point)
            where T : struct
        {
            if(src.Closed)
                return gmath.gteq(point, src.Left) && gmath.lteq(point, src.Right);
            else if(src.Open)
                return gmath.gt(point, src.Left) && gmath.lt(point, src.Right);
            else if(src.LeftClosed)
                return gmath.gteq(point, src.Left) && gmath.lt(point, src.Right);
            else
                return gmath.gt(point, src.Left) && gmath.lteq(point, src.Right);
        }

        public static Span<T> PartitionPoints<T>(this Interval<T> src, T? width = null)
            where T : struct
        {
            var includeLeft = src.LeftClosed;
            var includeRight = src.RightClosed;
            var negOne = gmath.dec(gmath.zero<T>());

            gmath.width(src.Right, src.Left, out T totalWidth);
            convert<T,int>(gmath.div(totalWidth, width ?? gmath.one<T>()), out int count);
            
            var dstLen = count + (includeLeft ? 1 : 0) + (includeRight ? 1 : 0);
            var dst = span<T>(dstLen);
            var startix = includeLeft ? 1 : 0;
            var endix = (dst.Length - 1);
            var point = src.Left;
            
            if(includeLeft)
                dst[0] = point;        

            for(var i = startix; i < endix; i++)
                dst[i] = gmath.inc(ref point);            

            if(includeRight && gmath.neq(src.Right, dst[endix - 1]))
                dst[endix] = src.Right;
            else if(includeRight && gmath.eq(src.Right, dst[endix - 1]))
                dst[endix] = negOne;
                    
            return gmath.eq(dst[endix], negOne) 
                 ? dst.Slice(0, dst.Length - 1) 
                 : dst;
        }

        public static Span<Interval<T>> Partitions<T>(this Interval<T> src, T? width = null)
            where T : struct
        {
            var points = src.PartitionPoints(width ?? gmath.one<T>());
            var dst = span<Interval<T>>(points.Length);
            var lastIx = points.Length - 1;
            
            if(src.Open || src.LeftOpen)
                dst[0] = open(src.Left, points[0]);
            else
                dst[0] = leftclosed(src.Left, points[0]);
            
            for(var i = 1; i< lastIx; i++)
                dst[i] = leftclosed(points[i-1], points[i]);
            
            if(src.Open)
            {
                dst[lastIx] = leftclosed(points[lastIx - 1], src.Right);                
                return dst;
            }
            else if(src.Closed)
            {
                dst[lastIx] = closed(points[lastIx - 1], points[lastIx]);
                return dst.Slice(1);                
            }
            else if(src.RightClosed)
            {
                dst[lastIx] = closed(points[lastIx - 1], points[lastIx]);                    
                return dst;
            }                
            else
            {            
                dst[lastIx] = leftclosed(points[lastIx - 1], src.Right);
                return dst.Slice(1);
            }
        }

        [MethodImpl(Inline)]
        public static IEnumerable<T> Discretize<T>(this Interval<T> src, T? step = null)
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