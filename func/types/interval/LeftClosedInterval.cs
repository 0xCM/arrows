
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

    

    public readonly struct LeftClosedInterval<T> : ILeftClosedInterval<T>, IRightOpenInterval<T> 
        where T : struct

    {

        public static implicit operator Interval<T>(LeftClosedInterval<T> x)
            => x.AsCanonical();

        public LeftClosedInterval(T left, T right)
        {
            this.Left = left;

            this.Right = right;
        }

        public T Left {get;}

        public bool LeftClosed 
            => true;


        public T Right {get;}
            

        public bool RightClosed 
            => false;

        public IntervalKind Kind
            => IntervalKind.LeftClosed;

        public Interval<T> AsCanonical()
            =>new Interval<T>(Left,LeftClosed, Right,RightClosed);

       public string format()
            => AsCanonical().format();
        
       public override string ToString()
            => format();
                     
    }




}