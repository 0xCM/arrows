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

    /// <summary>
    /// Characterizes a contiguous segment of homogenous values that lie within
    /// left and right boundaries 
    /// </summary>
    /// <remarks>
    /// Note that extended real numbers may also serve as endpoints,
    /// enabling representations such as (-∞,3] and (-3, ∞).
    /// </remarks>
    public interface IInterval<T>
        where T : struct
    {
    
        /// <summary>
        ///  The interval's left endpoint
        /// </summary>
        T Left {get;}

        /// <summary>
        ///  Specifies whether the left endpoint itself is contained in the interval
        /// </summary>
        bool LeftClosed {get;}

        /// <summary>
        ///  The interval's right endpoint
        /// </summary>
        T Right {get;}

        /// <summary>
        ///  Specifies whether the right endpoint itself is contained in the interval
        /// </summary>
        bool RightClosed {get;}

        IntervalKind Kind {get;}

        bool Closed
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Kind == IntervalKind.Closed;
            }
        }

        bool Open
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Kind == IntervalKind.Open;
            }
        }

    }

    /// <summary>
    /// Characterizes a discrete interval
    /// </summary>
    /// <typeparam name="T">The value type</typeparam>
    public interface IDiscreteInterval<T> : IInterval<T> 
        where T : struct
    {

    }
}