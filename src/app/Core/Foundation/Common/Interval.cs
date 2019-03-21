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

    partial class Class
    {

        
        public interface Interval<T>
            where T : Ordered<T>
        {
            
            Option<T> left {get;}                
            

            Option<T> right {get;}

            /// <summary>
            /// Specifies whether specified endpoints are included in
            /// the interval
            /// </summary>
            /// <value></value>
            (bool left, bool right) inclusion {get;}

        }

        public interface LeftOpenInterval<T> : Interval<T>
            where T : Ordered<T>
        {

        }

        public interface LeftClosedInterval<T> : Interval<T>
            where T : Ordered<T>
        {

        }

        public interface RightOpenInterval<T> : Interval<T>
            where T : Ordered<T>
        {

        }

        public interface RightClosedInterval<T> : Interval<T>
            where T : Ordered<T>
        {

        }

        public interface LeftBoundInterval<T> : Interval<T>
            where T : Ordered<T>
        {
            new T left {get;}                
            
            
        }

        public interface RightBoundInterval<T> : Interval<T>
            where T : Ordered<T>
        {            

            new T right {get;}

        }

        public interface BoundInterval<T> : LeftBoundInterval<T>, RightBoundInterval<T>
            where T : Ordered<T>
        {

        }

    }

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