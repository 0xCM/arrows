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
        public static IEnumerable<real<T>> partition<T>(Traits.Interval<real<T>> src, real<T> width)
            where T: IConvertible
        {
            if(width.neq(real<T>.Zero))
            {            
                if(src.leftclosed)
                    yield return src.left;
                
                var prior = src.left;
                var current = src.left + width;
                while(current < src.right)
                {
                    yield return current;
                    prior = current;
                    current += width;

                    //Detects overlow
                    if(current < prior)
                        break;
                }
            }
        }
        
        public static ClosedInterval<T> closed<T>(T left, T right)
            => new ClosedInterval<T>(left,right);

        public static LeftOpenInterval<T> leftopen<T>(T left, T right)
            => new LeftOpenInterval<T>(left,right);

        public static LeftClosedInterval<T> leftclosed<T>(T left, T right)
            => new LeftClosedInterval<T>(left,right);

        public static OpenInterval<T> open<T>(T left, T right)
            => new OpenInterval<T>(left,right);
        
    }

    public static class IntervalX
    {
        public static ClosedInterval<T> ToClosedInterval<T>(this (T left, T right) x)
            => Interval.closed(x.left,x.right);

        public static LeftOpenInterval<T> ToLeftOpenInterval<T>(this (T left, T right) x)
            => Interval.leftopen(x.left,x.right);

        public static LeftClosedInterval<T> ToRightOpenInterval<T>(this (T left, T right) x)
            => Interval.leftclosed(x.left,x.right);

        public static OpenInterval<T> ToOpenInterval<T>(this (T left, T right) x)
            => Interval.open(x.left,x.right);        
    }
}
