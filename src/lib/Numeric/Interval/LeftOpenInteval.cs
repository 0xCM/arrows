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

    using static zcore;

    public readonly struct LeftOpenInterval<T> : Traits.LeftOpenInterval<T>, Traits.RightClosedInterval<T>
        where T : Traits.OrderedNumber<T>

    {

        public static implicit operator Interval<T>(LeftOpenInterval<T> x)
            => x.canonical();

        public LeftOpenInterval(T left, T right)
        {
            this.left = left;

            this.right = right;
        }

        public T left {get;}

        public bool leftclosed 
            => false;


        public T right {get;}
            

        public bool rightclosed 
            => true;

        public Interval<T> canonical()
            => new Interval<T>(left,leftclosed, right,rightclosed);

                    
        public string format()
            => canonical().format();
        
        public override string ToString()
            => format();
 
    }




}