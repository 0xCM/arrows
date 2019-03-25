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


    partial class Traits
    {   
        /// <summary>
        /// Characterizes a contiguous segment of values between lower and upper bounds
        /// </summary>
        public interface Interval<T>
            where T : Ordered<T>
        {
            
            /// <summary>
            ///  The interval's left endpoint
            /// </summary>
            T left {get;}

            /// <summary>
            ///  Specifies whether the left endpoint itself is contained in the interval
            /// </summary>
            bool leftclosed {get;}
            
            /// <summary>
            ///  The interval's right endpoint
            /// </summary>
            T right {get;}

            /// <summary>
            ///  Specifies whether the right endpoint itself is contained in the interval
            /// </summary>
            bool rightclosed {get;}

        }

        /// <summary>
        /// Characterizes an interval that does not contain its lower bound
        /// </summary>
        public interface LeftOpenInterval<T> : Interval<T>
            where T : Ordered<T>
        {

        }

        /// <summary>
        /// Characterizes an interval that does not contain its upper bound
        /// </summary>
        public interface RightOpenInterval<T> : Interval<T>
            where T : Ordered<T>
        {

        }


        /// <summary>
        /// Characterizes an interval that contains its lower bound
        /// </summary>
        public interface LeftClosedInterval<T> : Interval<T>
            where T : Ordered<T>
        {

        }

        /// <summary>
        /// Characterizes an interval that contains its upper bound
        /// </summary>
        public interface RightClosedInterval<T> : Interval<T>
            where T : Ordered<T>
        {

        }

        /// <summary>
        /// Characterizes an interval that contains neither  of its endpoints
        /// </summary>
        public interface OpenInterval<T> : LeftOpenInterval<T>, RightOpenInterval<T>
            where T : Ordered<T>

        {

        }

        /// <summary>
        /// Characterizes an interval that contains its endpoints
        /// </summary>
        public interface ClosedInterval<T> : LeftClosedInterval<T>, RightClosedInterval<T>
            where T : Ordered<T>
        {

        }

    }

}