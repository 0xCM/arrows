//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static corefunc;


    /// <summary>
    /// Defines a contiguous segment of values between left and round bounds
    /// </summary>
    public readonly struct Interval<T> : Traits.Interval<T>
        where T : Traits.Ordered<T>
    {
        
        public Interval(T left, bool leftclosed, T right, bool rightclosed)
        {
            this.left = left;
            this.leftclosed = leftclosed;

            this.right = right;
            this.rightclosed = rightclosed;
        }
        
        public T left {get;}

        public T right {get;}

        public bool leftclosed {get;}

        public bool rightclosed {get;}

        public override string ToString()
            => concat(
                leftclosed ? AsciSym.LBracket: AsciSym.LParen, 
                format(left), AsciSym.Colon, format(right), 
                rightclosed ? AsciSym.RBracket : AsciSym.RParen
                );
    }

    public static class Interval
    {

        public static ClosedInterval<T> closed<T>(T left, T right)
            where T : Traits.Ordered<T>
                => new ClosedInterval<T>(left,right);

        public static LeftOpenInterval<T> leftopen<T>(T left, T right)
            where T : Traits.Ordered<T>
                => new LeftOpenInterval<T>(left,right);

        public static RightOpenInterval<T> rightopen<T>(T left, T right)
            where T : Traits.Ordered<T>
                => new RightOpenInterval<T>(left,right);

        public static OpenInterval<T> open<T>(T left, T right)
            where T : Traits.Ordered<T>
                => new OpenInterval<T>(left,right);
        
    }

    public static class IntervalX
    {
        public static ClosedInterval<T> ToClosedInterval<T>(this (T left, T right) x)
            where T : Traits.Ordered<T> => Interval.closed(x.left,x.right);

        public static LeftOpenInterval<T> ToLeftOpenInterval<T>(this (T left, T right) x)
            where T : Traits.Ordered<T> => Interval.leftopen(x.left,x.right);

        public static RightOpenInterval<T> ToRightOpenInterval<T>(this (T left, T right) x)
            where T : Traits.Ordered<T> => Interval.rightopen(x.left,x.right);

        public static OpenInterval<T> ToOpenInterval<T>(this (T left, T right) x)
            where T : Traits.Ordered<T> => Interval.open(x.left,x.right);
        
    }

}