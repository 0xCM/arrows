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

    partial class Reify
    {
        
        public static class Interval
        {

            public static Interval<T> closed<T>(T left, T right)
                where T : Class.Ordered<T>
                    => new Interval<T>(left,right, (true,true));

            public static Interval<T> open<T>(T left, T right)
                where T : Class.Ordered<T>
                    => new Interval<T>(left,right, (false,false));
            
        }
        
        public readonly struct Interval<T> : Class.Interval<T>
            where T : Class.Ordered<T>
        {
            public Interval(Option<T> left, Option<T> right, (bool left, bool right) inclusion)
            {
                this.left = left;
                this.right = right;
                this.inclusion = inclusion;
            }
            public Option<T> left {get;}

            public Option<T> right {get;}
            
            public (bool left, bool right) inclusion {get;}
        }
    }

}