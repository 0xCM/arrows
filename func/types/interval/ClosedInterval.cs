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

    public readonly struct ClosedInterval<T> : IClosedInterval<T>
        where T : struct

    {

        public static implicit operator Interval<T>(ClosedInterval<T> x)
            => x.AsCanonical();

        public ClosedInterval(T left, T right)
        {
            this.Left = left;

            this.Right = right;
        }

        public T Left {get;}

        public bool LeftClosed 
            => true;

        public T Right {get;}
            

        public bool RightClosed 
            => true;

        public IntervalKind Kind
            => IntervalKind.Closed;

        public Interval<T> AsCanonical()
            => new Interval<T>(Left,LeftClosed, Right,RightClosed);

        public string format()
            => AsCanonical().format();
        
        public override string ToString()
            => format();                    
    }

}