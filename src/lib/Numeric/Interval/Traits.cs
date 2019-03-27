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


    partial class Traits
    {   
        /// <summary>
        /// Characterizes a contiguous segment of homogenous values that lie within
        /// left and right boundaries 
        /// </summary>
        /// <remarks>
        /// Note that extended real numbers may also serve as endpoints,
        /// enabling representations such as (-∞,3] and (-3, ∞).
        /// </remarks>
        public interface Interval<T> : Formattable
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

            /// <summary>
            /// Presents the interval in canonical/general form
            /// </summary>
            Z0.Interval<T> canonical();

        }

        /// <summary>
        /// Characterizes a discrete interval
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        public interface DiscreteInterval<T> : Interval<T>, DiscreteSet<T> { }

        /// <summary>
        /// Characterizes an interval that does not contain its lower bound
        /// </summary>
        public interface LeftOpenInterval<T> : Interval<T> { }

        /// <summary>
        /// Characterizes an interval that does not contain its upper bound
        /// </summary>
        public interface RightOpenInterval<T> : Interval<T> { }


        /// <summary>
        /// Characterizes an interval that contains its lower bound
        /// </summary>
        public interface LeftClosedInterval<T> : Interval<T> { }

        /// <summary>
        /// Characterizes an interval that contains its upper bound
        /// </summary>
        public interface RightClosedInterval<T> : Interval<T> { }

        /// <summary>
        /// Characterizes an interval that contains neither  of its endpoints
        /// </summary>
        public interface OpenInterval<T> : LeftOpenInterval<T>, RightOpenInterval<T> { }

        /// <summary>
        /// Characterizes an interval that contains its endpoints
        /// </summary>
        public interface ClosedInterval<T> : LeftClosedInterval<T>, RightClosedInterval<T> {}

        
    }

}