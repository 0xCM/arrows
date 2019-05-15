//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    
    using static zfunc;

    partial class xfunc
    {
        /// <summary>
        /// Constructs the closed interval [left,right]
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static ClosedInterval<T> ToClosedInterval<T>(this (T left, T right) x)
            where T : struct
                => Interval.closed(x.left,x.right);

        /// <summary>
        /// Constructs the left-open(or right-closed interval) interval (left,right]
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static LeftOpenInterval<T> ToLeftOpenInterval<T>(this (T left, T right) x)
            where T : struct
                => Interval.leftopen(x.left,x.right);

        /// <summary>
        /// Constructs the left-closed (or right-open interval) interval [left,right)
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static LeftClosedInterval<T> ToRightOpenInterval<T>(this (T left, T right) x)
            where T : struct
                => Interval.leftclosed(x.left,x.right);

        /// <summary>
        /// Constructs the open interval (left,right)
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static OpenInterval<T> ToOpenInterval<T>(this (T left, T right) x)
            where T : struct
                => Interval.open(x.left,x.right);     

    }
}