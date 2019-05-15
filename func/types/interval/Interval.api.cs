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

    public static class Interval
    {
        
        /// <summary>
        /// Constructs the closed interval [left,right]
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static ClosedInterval<T> closed<T>(T left, T right)
            where T : struct
                => new ClosedInterval<T>(left,right);

        /// <summary>
        /// Constructs the left-open(or right-closed interval) interval (left,right]
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static LeftOpenInterval<T> leftopen<T>(T left, T right)
            where T : struct
                => new LeftOpenInterval<T>(left,right);

        /// <summary>
        /// Constructs the left-closed (or right-open interval) interval [left,right)
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static LeftClosedInterval<T> leftclosed<T>(T left, T right)
            where T : struct
                => new LeftClosedInterval<T>(left,right);

        /// <summary>
        /// Constructs the open interval (left,right)
        /// </summary>
        /// <param name="left">The left end point</param>
        /// <param name="right">The right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline)]
        public static OpenInterval<T> open<T>(T left, T right)
            where T : struct
                => new OpenInterval<T>(left,right);                        
    }
}