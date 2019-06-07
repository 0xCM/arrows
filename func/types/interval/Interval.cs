//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Defines a contiguous segment of homogenous values that lie within
    /// left and right boundaries 
    /// </summary>
    /// <remarks>
    /// Note that extended real numbers may also serve as endpoints,
    /// enabling representations such as (-∞,3] and (-3, ∞).
    /// </remarks>
    public readonly struct Interval<T> : IInterval<T>
        where T : struct
    {
        
        [MethodImpl(Inline)]
        public Interval(T left, bool leftclosed, T right, bool rightclosed)
        {
            this.Left = left;
            this.LeftClosed = leftclosed;

            this.Right = right;
            this.RightClosed = rightclosed;
        }
        
        public T Left {get;}

        public bool LeftClosed {get;}

        public T Right {get;}

        public bool RightClosed {get;}

        public bool Open
        {
            [MethodImpl(Inline)]
            get => !LeftClosed && !RightClosed;
        }

        public bool Closed
        {
            [MethodImpl(Inline)]
            get => LeftClosed && RightClosed;
        }

        public bool RightOpen
        {
            [MethodImpl(Inline)]
            get => !RightClosed;
        }

        public bool LeftOpen
        {
            [MethodImpl(Inline)]
            get => !LeftClosed;
        }

        public IntervalKind Kind 
            => Closed ? IntervalKind.Closed
            :  Open ? IntervalKind.Open
            :  LeftClosed && !RightClosed ? IntervalKind.LeftClosed
            :  IntervalKind.RightClosed;


        public Interval<T> ToOpen()
            => Interval.open(Left, Right);

        public Interval<T> ToLeftOpen()
            => Interval.leftopen(Left, Right);

        public Interval<T> ToLeftClosed()
            => Interval.leftclosed(Left, Right);

        public Interval<T> ToClosed()
            => Interval.closed(Left, Right);

        [MethodImpl(Inline)]
        public Interval<U> Convert<U>()
            where U : struct
                => new Interval<U>(convert(Left, out U x), LeftClosed, convert(Right, out U y), RightClosed);

        public string Format()
            => concat(
                LeftClosed ? "[": "(", 
                Left.ToString(), ",", Right.ToString(), 
                RightClosed ? "]" : ")"
                );

        public override string ToString()
            => Format();        
    }

    public enum IntervalKind
    {
        Closed = 0,
        
        Open = 1,
        
        LeftClosed = 4,        
        
        RightClosed = 8,
        
        LeftOpen = RightClosed,
        
        RightOpen = LeftClosed
    }


}