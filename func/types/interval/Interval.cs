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

    public enum IntervalKind
    {
        Closed = 0,
        
        Open = 1,
        
        LeftClosed = 4,        
        
        RightClosed = 8,
        
        LeftOpen = RightClosed,
        
        RightOpen = LeftClosed
    }


    /// <summary>
    /// Defines a contiguous segment of homogenous values that lie within
    /// left and right boundaries 
    /// </summary>
    /// <remarks>
    /// Note that extended real numbers may also serve as endpoints,
    /// enabling representations such as (-∞,3] and (-3, ∞).
    /// </remarks>
    public readonly struct Interval<T> : IInterval<Interval<T>,T>
        where T : struct
    {
        
        public Interval(T left, bool leftclosed, T right, bool rightclosed)
        {
            this.Left = left;
            this.LeftClosed = leftclosed;

            this.Right = right;
            this.RightClosed = rightclosed;
        }
        
        public T Left {get;}

        public T Right {get;}

        public bool LeftClosed {get;}

        public bool RightClosed {get;}

        public IntervalKind Kind 
            => LeftClosed && RightClosed ? IntervalKind.Closed
            :  not(LeftClosed) && not(RightClosed) ? IntervalKind.Open
            : LeftClosed && not(RightClosed) ? IntervalKind.LeftClosed
            : IntervalKind.RightClosed;

        public Interval<T> AsCanonical()
            => this;

    
        public string format()
            => append(
                LeftClosed ? "[": "(", 
                Left.ToString(), ",", Right.ToString(), 
                RightClosed ? "]" : ")"
                );

        public override string ToString()
            => format();        
    }
}