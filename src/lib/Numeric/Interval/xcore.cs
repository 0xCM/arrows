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

        public static ClosedInterval<T> closed<T>(T left, T right)
            where T : Traits.OrderedNumber<T>
                => new ClosedInterval<T>(left,right);

        public static LeftOpenInterval<T> leftopen<T>(T left, T right)
            where T : Traits.OrderedNumber<T>
                => new LeftOpenInterval<T>(left,right);

        public static LeftClosedInterval<T> leftclosed<T>(T left, T right)
            where T : Traits.OrderedNumber<T>
                => new LeftClosedInterval<T>(left,right);

        public static OpenInterval<T> open<T>(T left, T right)
            where T : Traits.OrderedNumber<T>
                => new OpenInterval<T>(left,right);
        
    }

    public static class IntervalX
    {
        public static ClosedInterval<T> ToClosedInterval<T>(this (T left, T right) x)
            where T : Traits.OrderedNumber<T>
                => Interval.closed(x.left,x.right);

        public static LeftOpenInterval<T> ToLeftOpenInterval<T>(this (T left, T right) x)
            where T : Traits.OrderedNumber<T>
                => Interval.leftopen(x.left,x.right);

        public static LeftClosedInterval<T> ToRightOpenInterval<T>(this (T left, T right) x)
            where T : Traits.OrderedNumber<T>
                => Interval.leftclosed(x.left,x.right);

        public static OpenInterval<T> ToOpenInterval<T>(this (T left, T right) x)
            where T : Traits.OrderedNumber<T>
                => Interval.open(x.left,x.right);        
    }
}
