//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;

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

}