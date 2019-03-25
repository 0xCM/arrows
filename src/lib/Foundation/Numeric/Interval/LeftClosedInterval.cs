
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

    using static corefunc;

    public readonly struct LeftClosedInterval<T> : Traits.LeftClosedInterval<T>, Traits.RightOpenInterval<T> 
        where T : Traits.OrderedNumber<T>
    {

        public static implicit operator Interval<T>(LeftClosedInterval<T> x)
            => new Interval<T>(x.left,x.leftclosed, x.right,x.rightclosed);

        public LeftClosedInterval(T left, T right)
        {
            this.left = left;

            this.right = right;
        }

        public T left {get;}

        public bool leftclosed 
            => true;


        public T right {get;}
            

        public bool rightclosed 
            => false;

        Interval<T> generalize()
            =>this;

        public override string ToString()
            => generalize().ToString();
                    
    }




}