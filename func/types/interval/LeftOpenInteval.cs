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

    public readonly struct LeftOpenInterval<T> : ILeftOpenInterval<T>, IRightClosedInterval<T>
        where T : struct
    {

        public static implicit operator Interval<T>(LeftOpenInterval<T> x)
            => x.AsCanonical();

        public LeftOpenInterval(T left, T right)
        {
            this.Left = left;

            this.Right = right;
        }

        public T Left {get;}

        public bool LeftClosed 
            => false;

        public T Right {get;}
            

        public bool RightClosed 
            => true;

        public IntervalKind Kind
            => IntervalKind.LeftOpen;

        public Interval<T> AsCanonical()
            => new Interval<T>(Left,LeftClosed, Right,RightClosed);
                    
        public string format()
            => AsCanonical().format();
        
        public override string ToString()
            => format(); 
    }
}