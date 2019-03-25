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

    public readonly struct ClosedInterval<T> : Traits.ClosedInterval<T>
        where T : Traits.Ordered<T>
    {

        public static implicit operator Interval<T>(ClosedInterval<T> x)
            => new Interval<T>(x.left,x.leftclosed, x.right,x.rightclosed);

        public ClosedInterval(T left, T right)
        {
            this.left = left;

            this.right = right;
        }

        public T left {get;}

        public bool leftclosed 
            => true;

        public T right {get;}
            

        public bool rightclosed 
            => true;

        Interval<T> generalize()
            =>this;

        public override string ToString()
            => generalize().ToString();
                    
    }




}